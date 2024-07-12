using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.Paths.Config.Provider.Actions
{
    /// <summary>
    /// Exposes static methods to obtain and formulate various values.
    /// </summary>
    public static class Obtain
    {
        /// <summary>
        /// Attempts to determine the fully-qualified pathname of the <c>config.json</c>
        /// file that stores the application configuration.
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
        /// <returns></returns>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the
        /// fully-qualified pathname of the <c>config.json</c> file that contains the
        /// user's previously-saved configuration profiles.
        /// </returns>
        /// <remarks>
        /// Configuration profiles let the user save a set of their previously-used
        /// settings to easily recall for later use.
        /// <para />
        /// If an error occurred, or if required information is missing, during the
        /// operation, then this method returns the value of the
        /// <paramref name="currentPathname" />
        /// parameter.
        /// <para />
        /// <b>NOTE:</b> The <paramref name="currentPathname" /> is allowed to be passed
        /// the <see cref="F:System.String.Empty" /> value as its argument, so be mindful.
        /// </remarks>
        public static string ConfigFilePath(
            string companyName,
            string productName,
            string currentPathname = ""
        )
        {
            var result = currentPathname;

            /*
             * OKAY, the objective of this method is to give the caller a
             * fully-qualified pathname to a config.json file to be used
             * for storing the application configuration.
             *
             * We formulate this using the name of the company associated with
             * this application and the product name to string together the
             * default pathname and the name of the key in the system Registry
             * under which the pathname is stored.
             *
             * If either of these pieces of info are blank, then stop.  The
             * currentPathname parameter allows us to return it as a default
             * value in case we otherwise fail.
             *
             * If the path listed in the argument of the currentPathname
             * parameter refers to a file on the file system that exists, and that
             * has a name of config.json, then simply return that pathname.
             * Otherwise, try to load the config.json file's pathname from the
             * system Registry.
             */

            try
            {
                if (string.IsNullOrWhiteSpace(companyName)) return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;
                if (Does.FileExist(currentPathname) &&
                    ConfigFile.DefaultFilename.Equals(
                        Path.GetFileName(currentPathname)
                    ))
                    return result;

                result = Retrieve.ConfigPathFromRegistry(
                    companyName, productName, currentPathname
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = currentPathname;
            }

            return result;
        }
    }
}