using Alphaleonis.Win32.Filesystem;
using MFR.Services.Solutions.Actions;
using MFR.Services.Solutions.Interfaces;
using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
using xyLOGIX.VisualStudio;
using xyLOGIX.VisualStudio.Instances.Interfaces;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Services.Solutions
{
    /// <summary>
    /// Manages running instances of Visual Studio that have solutions in
    /// specified folder(s) loaded.
    /// </summary>
    public class VisualStudioSolutionService : IVisualStudioSolutionService
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static VisualStudioSolutionService() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected VisualStudioSolutionService() { }

        /// <summary>
        /// Gets or sets the fully-qualified pathname of the folder that is to be searched
        /// for <c>.sln</c> files.
        /// </summary>
        [Log(AttributeExclude = true)]
        public string FolderToSearch
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Services.Solutions.VisualStudioSolutionService" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static VisualStudioSolutionService Instance
        {
            get;
        } = new VisualStudioSolutionService();

        /// <summary>
        /// Alias for the
        /// <see
        ///     cref="M:MFR.Services.Solutions.VisualStudioSolutionService.ContainsLoadedSolutions" />
        /// method.
        /// <para />
        /// This serves to make this class more fluent.
        /// </summary>
        /// <returns>
        /// This method returns the same value as the
        /// <see
        ///     cref="M:MFR.Services.Solutions.VisualStudioSolutionService.ContainsLoadedSolutions" />
        /// method does when a blank value is passed for its input.
        /// </returns>
        public bool ContainLoadedSolutions()
            => ContainsLoadedSolutions(string.Empty);

        /// <summary>
        /// Determines whether the folder having path passed in the
        /// <paramref
        ///     name="folder" />
        /// parameter contains any <c>*.sln</c> files that represent
        /// solutions currently loaded by running instances of Visual Studio.
        /// </summary>
        /// <param name="folder">
        /// (Required.) String containing the fully-qualified pathname of a
        /// folder that should be scanned for <c>*.sln</c> files.
        /// <para />
        /// If this parameter is passed a blank value, then the method tries to utilize the
        /// value of the
        /// <see cref="P:MFR.Services.Solutions.VisualStudioSolutionService.FolderToSearch" />
        /// property.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="folder" />
        /// contains <c>*.sln</c> files that are currently loaded by running instances
        /// of Visual Studio; <see langword="false" /> otherwise.
        /// </returns>
        public bool ContainsLoadedSolutions(string folder = "")
        {
            var result = false;

            try
            {
                /*
                 * If the value of the folder parameter is blank, or it
                 * contains a value that is not the fully-qualified pathname
                 * of a folder that exists on the file system, attempt to utilize
                 * the value of the FolderToSearch property.
                 *
                 * If THAT property is blank or contains a value that is
                 * not the fully-qualified pathname of a folder that exists
                 * on the file system, then unfortunately, we are screwed.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"VisualStudioSolutionService.ContainsLoadedSolutions: Checking whether the folder '{folder}' exists..."
                );

                if (string.IsNullOrWhiteSpace(folder) ||
                    !Directory.Exists(folder))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Warning,
                        $"VisualStudioSolutionService.ContainsLoadedSolutions: The folder '{folder}' could not be found.  Falling back on the value of the FolderToSearch property..."
                    );

                    // Dump the variable FolderToSearch to the log
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"VisualStudioSolutionService.ContainsLoadedSolutions: FolderToSearch = '{FolderToSearch}'"
                    );

                    folder = FolderToSearch;
                    if (string.IsNullOrWhiteSpace(folder) ||
                        !Directory.Exists(folder))
                    {
                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            $"VisualStudioSolutionService.ContainsLoadedSolutions: The folder '{folder}' cannot be located on the file system."
                        );
                        return result;
                    }

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "VisualStudioSolutionService.ContainsLoadedSolutions: The folder having the path contained in the FolderToSearch property shall be used."
                    );
                }
                else
                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "VisualStudioSolutionService.ContainsLoadedSolutions: The folder whose path was passed in the 'folder' parameter shall be used for the search."
                    );

                result = GetLoadedSolutionsInFolder(folder)
                    .Any();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }

        /// <summary>
        /// Scans the folder whose path is provided in the
        /// <paramref
        ///     name="folder" />
        /// parameter for <c>*.sln</c> files, and, for each file
        /// located, determines whether a running instance of Visual Studio has
        /// it loaded.
        /// <para />
        /// If this is so, then information about the loaded solution is
        /// returned as an element of a collection of any other such solutions.
        /// </summary>
        /// <param name="folder">
        /// (Required.) String containing the fully-qualified pathname of a
        /// folder that should be scanned for <c>*.sln</c> files.
        /// </param>
        /// <returns>
        /// Read-only list of references to instances of objects that implement
        /// the
        /// <see
        ///     cref="T:MFR.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface for each instance of Visual Studio that has that solution loaded.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="folder" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:DirectoryNotFoundException">
        /// Thrown if the directory whose fully-qualified path is passed in the
        /// <paramref name="folder" /> parameter cannot be found on the file system.
        /// </exception>
        public IReadOnlyList<IVisualStudioSolution> GetLoadedSolutionsInFolder(
            string folder
        )
        {
            var result = Enumerable.Empty<IVisualStudioSolution>()
                                   .ToList();

            if (string.IsNullOrWhiteSpace(folder) || !Directory.Exists(folder))
                return result;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"VisualStudioSolutionService.GetLoadedSolutionsInFolder: Attempting to get a list of all the Visual Studio Solution (*.sln) file(s) present in the directory tree of the folder, '{folder}'..."
                );

                var files = Get.SolutionPathsInFolder(folder)
                               .ToArray();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VisualStudioSolutionService.GetLoadedSolutionsInFolder *** INFO: Checking whether the 'files' collection has greater than zero elements..."
                );

                if (files.Length == 0)
                {
                    // The list, 'files', has zero elements, but we can't proceed if this is so.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "VisualStudioSolutionService.GetLoadedSolutionsInFolder *** ERROR *** The collection, 'files', has zero elements.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** VisualStudioSolutionService.GetLoadedSolutionsInFolder: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"VisualStudioSolutionService.GetLoadedSolutionsInFolder *** SUCCESS *** {files.Length} element(s) found in the 'files' collection.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VisualStudioSolutionService.GetLoadedSolutionsInFolder: Attempting to find the open instance(s) of Visual Studio having the located Solution(s) open..."
                );

                var visualStudioInstances =
                    FindVisualStudioInstancesHavingFilesLoaded(files);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VisualStudioSolutionService.GetLoadedSolutionsInFolder *** INFO: Checking whether the 'visualStudioInstances' collection has greater than zero elements..."
                );

                // Check whether the 'visualStudioInstances' collection has greater than zero elements.
                // If this is not the case, then write an error message to the log file, and then terminate
                // the execution of this method.
                if (visualStudioInstances.Count == 0)
                {
                    // The list, 'visualStudioInstances', has zero elements, but we can't proceed if this is so.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "VisualStudioSolutionService.GetLoadedSolutionsInFolder *** ERROR *** The collection, 'visualStudioInstances', has zero elements.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** VisualStudioSolutionService.GetLoadedSolutionsInFolder: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"VisualStudioSolutionService.GetLoadedSolutionsInFolder *** SUCCESS *** {visualStudioInstances.Count} element(s) found in the 'visualStudioInstances' collection.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VisualStudioSolutionService.GetLoadedSolutionsInFolder: Searching for open Solution files..."
                );

                foreach (var instance in visualStudioInstances.ToArray())
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "VisualStudioSolutionService.GetLoadedSolutionsInFolder: Checking whether the variable 'instance' has a null reference for a value..."
                    );

                    // Check to see if the variable, instance, is null. If it is, send an error to the log file and continue to the next loop iteration.
                    if (instance == null)
                    {
                        // the variable instance is required to have a valid object reference.
                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            "VisualStudioSolutionService.GetLoadedSolutionsInFolder: *** ERROR ***  The 'instance' variable has a null reference.  Skipping to the next loop iteration..."
                        );

                        // continue to the next loop iteration.
                        continue;
                    }

                    // We can use the variable, instance, because it's not set to a null reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "VisualStudioSolutionService.GetLoadedSolutionsInFolder: *** SUCCESS *** The 'instance' variable has a valid object reference for its value.  Proceeding..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "VisualStudioSolutionService.GetLoadedSolutionsInFolder: Getting a handle to the Visual Studio Solution (*.sln) that is loaded in the ccorresponding instance..."
                    );

                    var correspondingSolution =
                        Get.SolutionThatInstanceHasOpen(instance);

                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "VisualStudioSolutionService.GetLoadedSolutionsInFolder: Checking whether the variable 'correspondingSolution' has a null reference for a value..."
                    );

                    // Check to see if the variable, correspondingSolution, is null. If it is, send an error to the log file and continue to the next loop iteration.
                    if (correspondingSolution == null)
                    {
                        // the variable correspondingSolution is required to have a valid object reference.
                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            "VisualStudioSolutionService.GetLoadedSolutionsInFolder: *** ERROR ***  The 'correspondingSolution' variable has a null reference.  Skipping to the next loop iteration..."
                        );

                        // continue to the next loop iteration.
                        continue;
                    }

                    // We can use the variable, correspondingSolution, because it's not set to a null reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "VisualStudioSolutionService.GetLoadedSolutionsInFolder: *** SUCCESS *** The 'correspondingSolution' variable has a valid object reference for its value.  Proceeding..."
                    );

                    result.Add(correspondingSolution);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Enumerable.Empty<IVisualStudioSolution>()
                                   .ToList();
            }

            DebugUtils.WriteLine(
                result.Count > 0 ? DebugLevel.Info : DebugLevel.Error,
                result.Count > 0
                    ? $"*** SUCCESS *** {result.Count} element(s) are in the array of instance metadata for the loaded Visual Studio Solution (*.sln) file(s) in the folder, '{folder}'.  Proceeding..."
                    : $"*** ERROR *** FAILED to obtain information on ANY of the Visual Studio Solution (*.sln) file(s) in the folder, '{folder}'.  Stopping..."
            );

            return result;
        }

        /// <summary>
        /// Instructs the appropriate currently-running instances of Visual
        /// Studio who had solutions in the specified collection open at one
        /// time, to load them again.
        /// </summary>
        /// <param name="solutions">
        /// (Required.) Reference to a collection of references to instances of
        /// objects that implement the
        /// <see
        ///     cref="T:MFR.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represent the solution(s) to be loaded.
        /// </param>
        public void LoadAll(IReadOnlyList<IVisualStudioSolution> solutions)
        {
            if (solutions == null || solutions.All(solt => solt.IsLoaded))
                return;

            try
            {
                foreach (var solution in
                         solutions.Where(solt => !solt.IsLoaded))
                    solution.Load();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Instructs the appropriate currently-running instances of Visual
        /// Studio who had solutions in the specified collection not loaded at
        /// one time, to unload them again.
        /// </summary>
        /// <param name="solutions">
        /// (Required.) Reference to a collection of references to instances of
        /// objects that implement the
        /// <see
        ///     cref="T:MFR.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface which represent the solution(s) to be unloaded.
        /// </param>
        public void UnloadAll(IReadOnlyList<IVisualStudioSolution> solutions)
        {
            try
            {
                if (solutions == null) return;
                if (solutions.Count == 0) return;

                foreach (var solution in solutions.ToArray())
                {
                    if (solution == null) continue;
                    if (!solution.IsLoaded) continue;

                    solution.Unload();
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        private static IList<IVisualStudioInstanceMetadata>
            FindVisualStudioInstancesHavingFilesLoaded(string[] files)
        {
            IList<IVisualStudioInstanceMetadata> result =
                new AdvisableCollection<IVisualStudioInstanceMetadata>();

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: Checking whether the 'files' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, files, is null. If it is, send an
                // error to the log file and quit, returning the default return value of this
                // method.
                if (files == null)
                {
                    // The parameter, 'files', is required and is not supposed to have a NULL value.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: *** ERROR *** A null reference was passed for the 'files' method parameter.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: *** SUCCESS *** We have been passed a valid object reference for the 'files' method parameter.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: Checking whether the 'files' collection has greater than zero elements..."
                );

                // Check to see whether the 'files' collection has greater than zero elements.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (files.Length == 0)
                {
                    // The 'files' collection has zero elements.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The 'files' collection has zero elements.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: *** SUCCESS *** The 'files' collection has greater than zero elements.  Proceeding..."
                );

                foreach (var file in files)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"*** VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: Checking whether the current Visual Studio Solution (*.sln) file, '{file}', exists on the file system..."
                    );

                    // Check to see whether the current Visual Studio Solution (*.sln) file exists on the file system.
                    // If this is not the case, then write an error message to the log file,
                    // and then skip to the next loop iteration.
                    if (!Does.FileExist(file))
                    {
                        // The current file does NOT exist on the file system.  This is not desirable.
                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            $"*** ERROR: The current Visual Studio Solution (*.sln) file, '{file}', does NOT exist on the file system.  Skipping to the next Visual Studio Solution (*.sln) file..."
                        );

                        // skip to the next loop iteration.
                        continue;
                    }

                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: *** SUCCESS *** The current Visual Studio Solution (*.sln) file, '{file}', exists on the file system.  Proceeding..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: Attempting to get info about the running instance (if any) of Visual Studio that has the file, '{file}', loaded..."
                    );

                    var currentInstance = VisualStudioManager
                        .GetVsInstanceHavingSolutionOpened(file);

                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: Checking whether the variable 'currentInstance' has a null reference for a value..."
                    );

                    // Check to see if the variable, currentInstance, is null. If it is, send an error to the log file and continue to the next loop iteration.
                    if (currentInstance == null)
                    {
                        // the variable currentInstance is required to have a valid object reference.
                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            "VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: *** ERROR ***  The 'currentInstance' variable has a null reference.  Skipping to the next loop iteration..."
                        );

                        // continue to the next loop iteration.
                        continue;
                    }

                    // We can use the variable, currentInstance, because it's not set to a null reference.
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "VisualStudioSolutionService.FindVisualStudioInstancesHavingFilesLoaded: *** SUCCESS *** The 'currentInstance' variable has a valid object reference for its value.  Proceeding..."
                    );

                    result.Add(currentInstance);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result =
                    new AdvisableCollection<IVisualStudioInstanceMetadata>();
            }

            DebugUtils.WriteLine(
                result.Count > 0 ? DebugLevel.Info : DebugLevel.Error,
                result.Count > 0
                    ? $"*** SUCCESS *** {result.Count} running Visual Studio instance(s) were located having the specified file(s) loaded.  Proceeding..."
                    : "*** ERROR *** FAILED to find any running Visual Studio instance(s) having the specified file(s) loaded.  Stopping..."
            );

            return result;
        }
    }
}