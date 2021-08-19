using Alphaleonis.Win32.Filesystem;
using EnvDTE;
using MFR.Processes.Factories;
using MFR.Processes.Interfaces;
using MFR.RunningObjects.Factories;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using Thread = System.Threading.Thread;

namespace MFR.VisualStudio
{
    /// <summary>
    /// Provides helper methods for interacting with Visual Studio.
    /// </summary>
    public static class VisualStudioManager
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IProcessIdProvider" />
        /// interface and that
        /// provides the ability to obtain the Process IDs (PIDs) of running
        /// processes from the operating system.
        /// </summary>
        private static readonly IProcessIdProvider _processIdProvider;

        /// <summary>
        /// Initializes static data or performs messages that need to be
        /// performed once only for the
        /// <see
        ///     cref="T:MFR.VisualStudio.VisualStudioManager" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static VisualStudioManager()
        {
            _processIdProvider = MakeNewProcessIdProvider.FromScratch();
        }

        /// <summary>
        /// Attempts to find the Visual Studio instance that has the solution
        /// with pathname <paramref name="path" /> currently loaded. Returns
        /// <see
        ///     langword="null" />
        /// if such an instance cannot be found.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of a
        /// Visual Studio solution file.
        /// </param>
        /// <returns>
        /// Reference to an instance of the object that implements the
        /// <see
        ///     cref="T:EnvDTE.DTE" />
        /// automation interface for the Visual Studio
        /// instance that has the solution opened; <see langword="null" /> if
        /// such an instance cannot be located.
        /// </returns>
        public static DTE GetVsProcessHavingSolutionOpened(string path)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In VisualStudioManager.GetVsProcessHavingSolutionOpened"
            );

            DTE result = default;

            // Dump the parameter path to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"VisualStudioManager.GetVsProcessHavingSolutionOpened: path = '{path}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "VisualStudioManager.GetVsProcessHavingSolutionOpened: Checking whether the 'path' parameter references a valid Visual Studio solution..."
            );

            if (string.IsNullOrWhiteSpace(path) || !path.EndsWith(".sln"))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "VisualStudioManager.GetVsProcessHavingSolutionOpened: The 'path' parameter is either blank, or it does not contain the path to a file ending with the '.sln' extension.  Quitting."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "VisualStudioManager.GetVsProcessHavingSolutionOpened: Done."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"VisualStudioManager.GetVsProcessHavingSolutionOpened: Result = {result}"
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The 'path' parameter appears to contain the filename of a Visual Studio Solution file."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "VisualStudioManager.GetVsProcessHavingSolutionOpened: Checking whether the 'path' parameter contains a string that is an absolute pathname..."
            );

            if (!path.IsAbsolutePath())
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "VisualStudioManager.GetVsProcessHavingSolutionOpened: The 'path' parameter does not contain an absolute path."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "VisualStudioManager.GetVsProcessHavingSolutionOpened: Done."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"VisualStudioManager.GetVsProcessHavingSolutionOpened: Result = {result}"
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The 'path' parameter contains an absolute pathname."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Checking whether the file with path '{path}' exists on the disk..."
            );

            if (!File.Exists(path))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the file having the path '{path}' on the disk.  This file is required to exist in order for us to proceed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"VisualStudioManager.GetVsProcessHavingSolutionOpened: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "VisualStudioManager.GetVsProcessHavingSolutionOpened: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The file with path '{path}' was found on the disk.  Proceeding..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"VisualStudioManager.GetVsProcessHavingSolutionOpened: Attempting to find the Visual Studio process that has the solution with path '{path}' open..."
            );

            try
            {
                var pids = _processIdProvider.GetAllProcessIDsOf("devenv.exe")
                                             .ToList();
                if (!pids.Any())    // Visual Studio is not open at all
                    return result;

                result = _processIdProvider.GetAllProcessIDsOf("devenv.exe")
                                           .Select(ConnectToRunningVisualStudio)
                                           .FirstOrDefault(
                                               dte => dte != null &&
                                                   dte.Solution.FullName.Equals(
                                                       path
                                                   )
                                           );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                // if an exception occurs, just give up.
                result = default;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"VisualStudioManager.GetVsProcessHavingSolutionOpened: Result = {result}"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "VisualStudioManager.GetVsProcessHavingSolutionOpened: Done."
            );

            return result;
        }

        /// <summary>
        /// Determines whether the Visual Studio Solution with the specified
        /// <paramref name="path" /> is loaded in an existing instance of Visual Studio.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of a
        /// Visual Studio Solution (*.sln) file.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if a running instance of Visual Studio has
        /// the specified solution open; <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsSolutionOpen(string path)
        {
            var result = false;

            if (string.IsNullOrWhiteSpace(path) ||
                !".sln".Equals(Path.GetExtension(path)) ||
                !path.IsAbsolutePath() || !File.Exists(path))
                return result;

            try
            {
                var pids = _processIdProvider.GetAllProcessIDsOf("devenv.exe")
                                             .ToList();
                if (!pids.Any())    // Visual Studio is not open at all
                    return result;

                result = pids.Select(ConnectToRunningVisualStudio)
                             .Any(
                                 dte => dte != null &&
                                        dte.Solution.FullName.Equals(path)
                             );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Attempts to connect to the instance of Visual Studio that is running
        /// on the local machine, having the specified Process ID, <paramref name="pid" />.
        /// </summary>
        /// <param name="pid">
        /// (Required.) A positive integer that is the Process ID of a running
        /// instance of <c>devenv.exe</c>.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:EnvDTE.DTE" />
        /// interface, or <see langword="null" /> if no
        /// such running Visual Studio instance can be found.
        /// </returns>
        private static DTE ConnectToRunningVisualStudio(int pid)
        {
            DTE result = default;

            if (-1 == pid)
                return result; // Visual Studio is not running

            var retries = 60; /* retry for 60 seconds or until found */

            while (retries >= 0 && result == default)
            {
                try
                {
                    result =
                        (DTE)GetRunningObject.ByDisplayName(
                            $"VisualStudio.DTE.16.0:{pid}"
                        );
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = default;
                }

                if (result == default)
                {
                    Thread.Sleep(1000);
                    retries--;
                }
            }

            return result;
        }
    }
}