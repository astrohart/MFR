using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
using xyLOGIX.TimeZoneInfo.Extensions;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// Exposes static methods to formulate string values with other values as input.
    /// </summary>
    public static class Formulate
    {
        /// <summary>
        /// Formulates a commit message to be used for either pending changes or
        /// post-operation changes.
        /// </summary>
        /// <param name="format">
        /// (Required.) A <see cref="T:System.String" /> that contains
        /// the message to be formatted.
        /// </param>
        /// <param name="rootDirectory">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified pathname of the directory in which the user
        /// started processing the operations.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) A <see cref="T:System.String" /> containing the text to be searched
        /// for in the files, folders, and names of files and folders under the
        /// <paramref name="rootDirectory" />.
        /// <param name="replaceWith">
        /// (Optional.) A <see cref="T:System.String" />
        /// containing the text that the <paramref name="findWhat" /> value is to be
        /// replaced with in files, folders, and names of folders and files in the
        /// <paramref name="rootDirectory" />.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the results of the format
        /// substitution, or the specified <paramref name="format" /> if no substitution
        /// could be made.
        /// </returns>
        public static string CommitMessage(
            string format,
            string rootDirectory,
            string findWhat,
            string replaceWith = ""
        )
        {
            var result = format;

            try
            {
                if (string.IsNullOrWhiteSpace(format)) return result;
                if (!Does.FolderExist(rootDirectory)) return result;
                if (string.IsNullOrWhiteSpace(findWhat)) return result;

                result = string.Format(
                    format, DateTime.Now.ToShortTimeString(),
                    DateTime.Now.ToShortDateString(), findWhat, replaceWith,
                    rootDirectory, TimeZoneInfo.Local.ToAbbreviation()
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = format;
            }

            return result;
        }
    }
}