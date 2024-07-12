using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Profiles.Provider.Actions
{
    /// <summary>
    /// Exposes static methods to retrieve data from data sources.
    /// </summary>
    public static class Retrieve
    {
        /// <summary>
        /// Attempts to obtain the pathname of the file that contains the list of saved
        /// configuration profiles from the system Registry.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <param name="currentPathname">
        /// (Optional.) A <see cref="T:System.String" /> that
        /// serves as a default return value for this method in case a failure mode is
        /// otherwise hit (blank input, missing file, missing Registry value, etc.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the
        /// fully-qualified pathname of the <c>profiles.json</c> file that contains the
        /// user's previously-saved configuration profiles.
        /// </returns>
        /// <remarks>
        /// Configuration profiles let the user save a set of their previously-used
        /// settings to easily recall for later use.
        /// <para />
        /// If an error occurred, or if required information is missing, during the
        /// operation, then this method returns the <see cref="F:System.String.Empty" />
        /// value.
        /// </remarks>
        public static string ProfileCollectionPathFromRegistry(
            string companyName,
            string productName,
            string currentPathname = ""
        )
        {
            var result = currentPathname;

            try
            {
                if (string.IsNullOrWhiteSpace(companyName))
                    return result;
                if (string.IsNullOrWhiteSpace(productName))
                    return result;

                /*
                 * Attempt to get a default value for the profiles.json file.
                 * We will have our Registry query use this value if the application
                 * cannot locate the pathname of the file it should use otherwise,
                 * in the system Registry.
                 */

                var defaultProfileCollectionPathname =
                    Formulate.DefaultProfileCollectionPathname(
                        companyName, productName, currentPathname
                    );
                if (string.IsNullOrWhiteSpace(defaultProfileCollectionPathname))
                    return result;

                /*
                 * Formulate a Registry query expression that facilitates the application to look
                 * up the pathname of the profiles.json file in the system Registry.
                 */

                var profilePathRegQueryExpression =
                    Generate.ProfilePathRegQueryExpression(
                        companyName, productName,
                        defaultProfileCollectionPathname
                    );
                if (profilePathRegQueryExpression == null) return result;

                /*
                 * OKAY, now get a reference to an action object (from our event-aggregation
                 * architecture) that loads the pathname of the profiles.json file for us from
                 * the system Registry.
                 */
                var retrieveProfileCollectionPathnameFromRegistryAction =
                    Generate
                        .RetrieveProfileCollectionPathnameFromRegistryAction(
                            profilePathRegQueryExpression
                        );
                if (retrieveProfileCollectionPathnameFromRegistryAction == null)
                    return result;

                /*
                 * FINALLY, actually execute the operation of reading the pathname of the
                 * profiles.json file that is stored in the system Registry.  We've also
                 * configured a default value that is to be utilized, in case the operation
                 * fails, such as if there isn't such a value in the system Registry.
                 */

                var profileCollectionFileSystemEntry =
                    Execute
                        .OperationToLoadProfileCollectionFilePathFromRegistry(
                            retrieveProfileCollectionPathnameFromRegistryAction
                        );
                if (profileCollectionFileSystemEntry == null) return result;
                if (string.IsNullOrWhiteSpace(
                        profileCollectionFileSystemEntry.Path
                    ) || !ProfileFile.DefaultFilename.Equals(
                        Path.GetFileName(profileCollectionFileSystemEntry.Path)
                    )) return result;

                /*
                 * If we've got a non-blank pathname, then that's good enough.
                 * Whether File.Exists(profileCollectionFileSystemEntry.Path)
                 * returns true or not, at this juncture, is irrelevant, we just
                 * need a fucking pathname here, and we can check whether it refers
                 * to a file that exists on the file system, some other time.
                 */

                result = profileCollectionFileSystemEntry.Path;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}
