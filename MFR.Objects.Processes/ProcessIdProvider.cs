using MFR.Objects.Processes.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Alphaleonis.Win32.Filesystem;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Objects.Processes
{
    /// <summary>
    /// Provides the Process IDs (PIDs) of programs that are running on the
    /// local machine.
    /// </summary>
    public class ProcessIdProvider : IProcessIdProvider
    {
        /// <summary>
        /// Gets a collection of integers representing the process IDs of all
        /// the currently-executing instances of the .exe file with the
        /// specified <paramref name="path" />.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the filename or fully-qualified
        /// pathname, of hte .exe file that you think is currently a running process.
        /// </param>
        /// <returns>
        /// </returns>
        public IEnumerable<int> GetAllProcessIDsOf(string path)
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(DebugLevel.Debug, "In ProcessIdProvider.GetAllProcessIDsOf");

            var result = Enumerable.Empty<int>()
                                   .ToList();

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the value of the 'path' parameter is blank..."
            );

            if (string.IsNullOrWhiteSpace(path))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "ProcessIdProvider.GetAllProcessIDsOf: Blank value passed for the 'path' parameter. This parameter is required."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, $"ProcessIdProvider.GetAllProcessIDsOf: Result = '{result.ToSetString()}'"
                );

                DebugUtils.WriteLine(DebugLevel.Debug, "ProcessIdProvider.GetAllProcessIDsOf: Done.");

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The parameter 'path' is not blank.  Continuing..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "ProcessIdProvider.GetAllProcessIDsOf: Checking whether the value of the 'path' parameter ends with the '.exe' extension..."
            );

            if (!path.EndsWith(".exe"))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "ProcessIdProvider.GetAllProcessIDsOf: The value of the 'path' argument should end with the '.exe' file extension.  The value supplied does not."
                );

                DebugUtils.WriteLine(DebugLevel.Debug, "ProcessIdProvider.GetAllProcessIDsOf: Done.");

                DebugUtils.WriteLine(
                    DebugLevel.Debug, $"ProcessIdProvider.GetAllProcessIDsOf: Result = '{result.ToSetString()}'"
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The path specified ends with the '.exe' extension."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "ProcessIdProvider.GetAllProcessIDsOf: Checking whether the 'path' parameter contains a string that is an absolute pathname..."
            );

            if (path.IsAbsolutePath())
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "ProcessIdProvider.GetAllProcessIDsOf: The 'path' parameter contains an absolute pathname.  We only want a filename."
                );

                DebugUtils.WriteLine(DebugLevel.Debug, "ProcessIdProvider.GetAllProcessIDsOf: Done.");

                DebugUtils.WriteLine(
                    DebugLevel.Debug, $"ProcessIdProvider.GetAllProcessIDsOf: Result = '{result.ToSetString()}'"
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The 'path' parameter does not contain an absolute pathname."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"ProcessIdProvider.GetAllProcessIDsOf: Attempting to obtain the Process IDs (PIDs) of all running instances of '{path}'..."
            );

            try
            {
                var procs = Process.GetProcessesByName(
                    Path.GetFileNameWithoutExtension(path)
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: {procs.Length} processes found having .exe filename '{path}'."
                );

                // return the empty collection if zero results found
                if (!procs.Any())
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** No running processes with the filename '{path}' could be found."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"ProcessIdProvider.GetAllProcessIDsOf: Result = '{result.ToSetString()}'"
                    );

                    DebugUtils.WriteLine(DebugLevel.Debug, "ProcessIdProvider.GetAllProcessIDsOf: Done.");

                    return result;
                }
                
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"ProcessIdProvider.GetAllProcessIDsOf: Gathering the PIDs of all running instances of '{path}'..."
                );

                result = procs
                         .Where(p => p != null)
                         .Select(p => p.Id)
                         .ToList();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Enumerable.Empty<int>()
                                   .ToList();
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug, $"ProcessIdProvider.GetAllProcessIDsOf: Result = '{result.ToSetString()}'"
            );

            DebugUtils.WriteLine(DebugLevel.Debug, "ProcessIdProvider.GetAllProcessIDsOf: Done.");

            return result;
        }

        /// <summary>
        /// Gets the Process ID (PID) of the running process with the .exe file
        /// with the <paramref name="path" /> specified.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the filename or fully-qualified
        /// pathname, of hte .exe file that you think is currently a running process.
        /// </param>
        /// <returns>
        /// Integer whose value is set to the ID of the first process whose .exe
        /// filename matches the specified <paramref name="path" />; <c>-1</c> if
        /// no matches can be found. Process IDs are always positive integers.
        /// </returns>
        public int GetProcessIDOf(string path)
        {
            var result = -1;

            if (string.IsNullOrWhiteSpace(path)) return result;

            try
            {
                var procs = Process.GetProcessesByName(
                    Path.GetFileNameWithoutExtension(path)
                );
                if (!procs.Any()) return result;

                result = procs.First()
                              .Id;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = -1;
            }

            return result;
        }
    }
}