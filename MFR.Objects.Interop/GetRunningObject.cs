using MFR.Objects.Interop.Factories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MFR.Objects.Interop
{
    /// <summary>
    /// Contains methods that allow access to running object information.
    /// </summary>
    public static class GetRunningObject
    {
        /// <summary>
        /// Gets an entry from the Running Object Table (ROT) by
        /// <paramref name="displayName" />.
        /// </summary>
        /// <param name="displayName">
        /// (Required.) String containing the display name of the running object
        /// that is to be looked up.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that represents the fetched
        /// entry, if found; otherwise, <see langword="null" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="displayName" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// If any one of the lookup operations that the operating system is
        /// instructed to perform in order to carry out the lookup fail.
        /// </exception>
        public static object ByDisplayName(string displayName)
        {
            if (string.IsNullOrWhiteSpace(displayName))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(displayName)
                );

            var bindContext = MakeNewBindContext.FromScratch() ??
                              throw new InvalidOperationException(
                                  "Unable to obtain new bind context object."
                              );

            var runningObjectTable =
                GetRunningObjectTable.FromBindContext(bindContext) ??
                throw new InvalidOperationException(
                    "Unable to obtain a reference to the Running Object Table (ROT) on the local machine."
                );

            var monikerEnumerator =
                MakeNewEnumMoniker.From(runningObjectTable) ??
                throw new InvalidOperationException(
                    "Unable to create an enumerator on the local Running Object Table (ROT)."
                );

            object result = null;

            try
            {
                var collection = MakeNewMonikerCollection.FromScratch()
                    .AndAttachOperatingSystemEnumerator(monikerEnumerator)
                    .AndBindContext(bindContext)
                    .AndRunningObjectTable(runningObjectTable);

                foreach (var moniker in collection)
                {
                    if (string.IsNullOrWhiteSpace(moniker.DisplayName))
                        continue;

                    if (!moniker.DisplayName.EndsWith(
                        displayName, StringComparison.Ordinal
                    )) continue;

                    result = moniker.ComObject ??
                             throw new InvalidOperationException(
                                 $"Failed to obtain a reference to the running object having display name of '{displayName}'."
                             );
                    if (result != null) break;  // we have what we need, so stop
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }

        /// <summary>
        /// Gets the full list of display names of all the elements of the
        /// running object table.
        /// </summary>
        /// <returns>
        /// Collection of strings, each of which contains the display name of a
        /// running object.
        /// </returns>
        public static IList<string> DisplayNames()
        {
            var result = new List<string>();

            var bindContext = MakeNewBindContext.FromScratch() ??
                              throw new InvalidOperationException(
                                  "Unable to obtain new bind context object."
                              );

            var runningObjectTable =
                GetRunningObjectTable.FromBindContext(bindContext) ??
                throw new InvalidOperationException(
                    "Unable to obtain a reference to the Running Object Table (ROT) on the local machine."
                );

            var monikerEnumerator =
                MakeNewEnumMoniker.From(runningObjectTable) ??
                throw new InvalidOperationException(
                    "Unable to create an enumerator on the local Running Object Table (ROT)."
                );

            try
            {
                result = Enumerable.ToList<string>(
                                                     MakeNewMonikerCollection.FromScratch()
                                                         .AndAttachOperatingSystemEnumerator(
                                                             monikerEnumerator
                                                         )
                                                         .AndBindContext(bindContext)
                                                         .AndRunningObjectTable(
                                                             runningObjectTable
                                                         )
                                                         .Where(
                                                             m => !string
                                                                 .IsNullOrWhiteSpace(
                                                                     m.DisplayName
                                                                 )
                                                         )
                                                         .Select(m => m.DisplayName)
                                                 );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new List<string>();
            }

            return result;
        }
    }
}