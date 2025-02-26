using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
using xyLOGIX.VisualStudio.Solutions.Interfaces;
using Is = xyLOGIX.VisualStudio.Actions.Is;

namespace MFR.Renamers.Files.Actions
{
    public static class Reopen
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Renamers.Files.Actions.Reopen" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Reopen() { }

        /// <summary>
        /// Tasks the associated instance of Visual Studio to load the specified
        /// <paramref name="solution" />.
        /// </summary>
        /// <param name="solution">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represents the Visual Studio Solution (<c>*.sln</c>) file that
        /// is to be loaded.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation completed successfully;
        /// <see langword="false" /> otherwise.
        /// </returns>
        private static bool DoReopenSolution(
            [NotLogged] IVisualStudioSolution solution
        )
        {
            var result = false;

            try
            {
                if (solution == null) return result;
                if (solution.SolutionObject == null) return result;
                if (!solution.ShouldReopen) return result;
                if (Is.SolutionOpen(solution)) return true;

                var fileNameToUse = solution.SolutionObject.FullName;
                if (!Does.FileExist(fileNameToUse))
                    fileNameToUse = solution.FullName;

                if (!Does.FileExist(fileNameToUse)) return result;

                result = solution.Load();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.ReopenSolution: Result = {result}"
            );

            return result;
        }

        public static bool PreviouslyLoadedVisualStudioSolution(
            [NotLogged] IVisualStudioSolution solution
        )
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Reopen.PreviouslyLoadedVisualStudioSolution: Checking whether the 'solution' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, solution, is null. If it is, send an 
                // error to the log file and quit, returning the default return value of this
                // method.
                if (solution == null)
                {
                    // The parameter, 'solution', is required and is not supposed to have a NULL value.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Reopen.PreviouslyLoadedVisualStudioSolution: *** ERROR *** A null reference was passed for the 'solution' method parameter.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Reopen.PreviouslyLoadedVisualStudioSolution: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Reopen.PreviouslyLoadedVisualStudioSolution: *** SUCCESS *** We have been passed a valid object reference for the 'solution' method parameter.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** Reopen.PreviouslyLoadedVisualStudioSolution: Checking whether the specified Solution is to be reopened..."
                );

                // Check to see whether the specified Solution is to be reopened.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (!solution.ShouldReopen)
                {
                    // The specified Solution is NOT to be reopened.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The specified Solution is NOT to be reopened.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Reopen.PreviouslyLoadedVisualStudioSolution: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "Reopen.PreviouslyLoadedVisualStudioSolution: *** SUCCESS *** The specified Solution is to be reopened.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Reopen.PreviouslyLoadedVisualStudioSolution *** INFO: Checking whether the file having pathname, '{solution.FullName}', exists on the file system..."
                );

                // Check whether a file having pathname, 'solution.FullName', exists on the file system.
                // If it does not, then write an error message to the log file, and then terminate
                // the execution of this method, returning the default return value.
                if (!Does.FileExist(solution.FullName))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"Reopen.PreviouslyLoadedVisualStudioSolution: *** ERROR *** The system could not locate the file having pathname, '{solution.FullName}', on the file system.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Reopen.PreviouslyLoadedVisualStudioSolution: Result = {result}"
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Reopen.PreviouslyLoadedVisualStudioSolution: *** SUCCESS *** The file having pathname, '{solution.FullName}', was found on the file system.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Reopen.PreviouslyLoadedVisualStudioSolution: Checking whether the specified Solution, '{solution.FullName}', is already loaded..."
                );

                // Check to see whether the specified Solution is already loaded.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (Is.SolutionOpen(solution))
                {
                    // The specified Solution is already loaded.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The specified Solution, '{solution.FullName}', is already loaded.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** Reopen.PreviouslyLoadedVisualStudioSolution: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Reopen.PreviouslyLoadedVisualStudioSolution: *** SUCCESS *** The specified Solution, '{solution.FullName}', is NOT already loaded.  Proceeding..."
                );

                result = solution.Load();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(DebugLevel.Debug, $"Reopen.PreviouslyLoadedVisualStudioSolution: Result = {result}");

            return result;
        }
    }
}