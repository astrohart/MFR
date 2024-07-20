using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using xyLOGIX.Core.Debug;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// Exposes static methods to determine whether certain actions should be taken.
    /// </summary>
    public static class Should
    {
        /// <summary>
        /// Determines whether one or more of the entries in the
        /// <paramref name="previouslyLoadedSolutions" /> list has a value of its
        /// <see
        ///     cref="P:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution.ShouldReopen" />
        /// property that is <see langword="true" />.
        /// </summary>
        /// ///
        /// <param name="previouslyLoadedSolutions">
        /// (Required.) Reference to an instance of a collection of instances of objects
        /// that implement the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </param>
        /// <remarks>
        /// This method returns <see langword="false" /> if the argument of the
        /// <paramref name="previouslyLoadedSolutions" /> parameter is a
        /// <see langword="null" /> reference.
        /// <para />
        /// This method also returns <see langword="false" /> if the count of items in the
        /// <paramref name="previouslyLoadedSolutions" /> collection is zero.
        /// <para />
        /// If an error occurs while searching the
        /// <paramref name="previouslyLoadedSolutions" /> collection, then this method
        /// returns <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if at least one of the
        /// <paramref name="previouslyLoadedSolutions" /> should be reopened;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool AnyPreviouslyLoadedSolutionsBeReopened(
            [NotLogged] IList<IVisualStudioSolution> previouslyLoadedSolutions
        )
        {
            var result = false;

            try
            {
                if (previouslyLoadedSolutions == null) return result;
                if (previouslyLoadedSolutions.Count == 0) return result;

                var found = 0;

                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (var solution in previouslyLoadedSolutions)
                {
                    if (!solution.ShouldReopen) continue;

                    found++;
                    break; /* we do not care how many; just one is enough */
                }

                result = found > 0;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(DebugLevel.Debug, $"Should.AnyPreviouslyLoadedSolutionsBeReopened: Result = {result}");

            return result;
        }
    }
}