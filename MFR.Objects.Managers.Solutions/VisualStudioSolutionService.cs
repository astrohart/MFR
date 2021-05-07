using MFR.Objects.FileSystem.Retrievers.Factories;
using MFR.Objects.Managers.Solutions.Interfaces;
using MFR.Objects.Operations.Constants;
using MFR.Objects.Solutions.Factories;
using MFR.Objects.Solutions.Interfaces;
using MFR.Objects.VisualStudio;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.Objects.Managers.Solutions
{
    /// <summary>
    /// Manages running instances of Visual Studio that have solutions in
    /// specified folder(s) loaded.
    /// </summary>
    public class VisualStudioSolutionService : IVisualStudioSolutionService
    {
        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.Objects.Managers.Solutions.VisualStudioSolutionService"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static VisualStudioSolutionService Instance
        {
            get;
        } = new VisualStudioSolutionService();

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
        /// Determines whether the folder having path passed in the
        /// <paramref
        ///     name="folder" />
        /// parameter contains any *.sln files that represent
        /// solutions currently loaded by running instances of Visual Studio.
        /// </summary>
        /// <param name="folder">
        /// (Required.) String containing the fully-qualified pathname of a
        /// folder that should be scanned for *.sln files.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="folder" />
        /// contains *.sln files that are currently loaded by running instances
        /// of Visual Studio; <see langword="false" /> otherwise.
        /// </returns>
        public bool ContainsLoadedSolutions(string folder)
        {
            var result = false;

            if (string.IsNullOrWhiteSpace(folder) || !Directory.Exists(folder))
                return result;

            try
            {
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
        /// parameter for *.sln files, and, for each file
        /// located, determines whether a running instance of Visual Studio has
        /// it loaded.
        /// <para />
        /// If this is so, then information about the loaded solution is
        /// returned as an element of a collection of any other such solutions.
        /// </summary>
        /// <param name="folder">
        /// (Required.) String containing the fully-qualified pathname of a
        /// folder that should be scanned for *.sln files.
        /// </param>
        /// <returns>
        /// Read-only list of references to instances of objects that implement
        /// the
        /// <see
        ///     cref="T:MFR.Objects.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface for each instance of Visual Studio that has that solution loaded.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="folder" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:DirectoryNotFoundException">
        /// Thrown if the directory whose fully-qualified path is passed in the
        /// <paramref name="folder" /> parameter cannot be found on the disk.
        /// </exception>
        public IReadOnlyList<IVisualStudioSolution> GetLoadedSolutionsInFolder(
            string folder)
        {
            var result = Enumerable.Empty<IVisualStudioSolution>()
                                   .ToList();

            if (string.IsNullOrWhiteSpace(folder) || !Directory.Exists(folder))
                return result;

            try
            {
                var files = Directory.EnumerateFiles(
                                         folder, "*.sln",
                                         SearchOption.AllDirectories
                                     )
                                     .Where(f=>!ShouldSkipFile(f))
                                     .ToList();

                if (!files.Any())
                    return result;

                var visualStudioInstances = files
                                            .Select(
                                                file => new {
                                                    Instance =
                                                        VisualStudioManager
                                                            .GetVsProcessHavingSolutionOpened(
                                                                file
                                                            ),
                                                    Path = file
                                                }
                                            )
                                            .ToList();

                if (!visualStudioInstances.Any())
                    return result;

                result = visualStudioInstances.Select(
                                                  instanceData
                                                      => GetNewVisualStudioSolutionObject
                                                          .ForVisualStudioInstance(
                                                              instanceData
                                                                  .Instance
                                                          )
                                                          .AndPath(
                                                              instanceData.Path
                                                          )
                                              )
                                              .ToList();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Enumerable.Empty<IVisualStudioSolution>()
                                   .ToList();
            }

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
        ///     cref="T:MFR.Objects.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represent the solution(s) to be loaded.
        /// </param>
        public void LoadAll(IReadOnlyList<IVisualStudioSolution> solutions)
        {
            if (solutions == null || solutions.All(solt => solt.IsLoaded))
                return;

            try
            {
                foreach (var solution in solutions.Where(solt => !solt.IsLoaded))
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
        ///     cref="T:MFR.Objects.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface which represent the solution(s) to be unloaded.
        /// </param>
        public void UnloadAll(IReadOnlyList<IVisualStudioSolution> solutions)
        {
            if (solutions == null || solutions.All(solt => !solt.IsLoaded))
                return;

            try
            {
                foreach (var solution in solutions.Where(solt => solt.IsLoaded))
                    solution.Unload();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Determines whether a file with the <paramref name="path" /> should be
        /// skipped in a search.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the path to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="path" /> provided
        /// should not be included in the results; <see langword="false" /> otherwise.
        /// </returns>
        private static bool ShouldSkipFile(string path)
            => string.IsNullOrWhiteSpace(path) || !File.Exists(path) ||
               path.Contains(".git") && path.Contains(".vs") &&
               path.Contains("packages");
    }
}