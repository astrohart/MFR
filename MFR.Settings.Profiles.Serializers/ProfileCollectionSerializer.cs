using MFR.Settings.Configuration.Converters;
using MFR.FileSystem.Helpers;
using MFR.Settings.Profiles.Collections;
using MFR.Settings.Profiles.Collections.Interfaces;
using System;
using System.IO;
using xyLOGIX.Core.Debug;
using File = Alphaleonis.Win32.Filesystem.File;

namespace MFR.Settings.Profiles.Serializers
{
    /// <summary>
    /// Loads and stores profile list information to/from a file.
    /// </summary>
    /// <remarks>
    /// The profile information is used in code via the <see
    /// cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection"/> interface.
    /// </remarks>
    public static class ProfileCollectionSerializer
    {
        /// <summary>
        /// Loads data about the list of profiles from the file with the path specified by the <paramref name="pathname"/> parameter.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the fully-qualified pathname of a JSON-formatted data file on the disk that contains the profile-list data.
        /// </param>
        /// <returns>Reference to an instance of an object that implements the <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" /> interface.<para/>The object instance referenced contains access to the set of profiles listed in the file.<para/>The <see langword="null" /> reference is returned in the event a problem occurred.</returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="pathname" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file, the path to which is specified by the
        /// <paramref
        ///     name="pathname" />
        /// parameter, cannot be located on the disk.
        /// </exception>
        public static IProfileCollection Load(string pathname)
        {
            IProfileCollection result;

            if (string.IsNullOrWhiteSpace(pathname)
                || !File.Exists(pathname))
            {
                /*
                 * Create a new data object in this event. We are here, most likely, because
                 * the pathname that was desired to be utilized for the configuration file
                 * referenced a spot on the disk where the user does not have sufficient access
                 * privileges to create new files or read them.
                 */

                return new ProfileCollection();
            }
            
            try
            {
                var content = File.ReadAllText(pathname);

                // If the file at the path pathname has zero bytes of data, or
                // only whitespace, then return a blank Configuration instance
                // with its properties all set to default values.
                return string.IsNullOrWhiteSpace(content)
                    ? new ProfileCollection()
                    : ConvertProfileCollection.FromJson(content);
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
        ///     Saves profile-list data to a file.
        /// </summary>
        /// <param name="pathname">
        ///     (Required.) String containing the pathname of the file that the data
        ///     is to be saved to.
        /// </param>
        /// <param name="profileList">
        ///     (Required.) Reference to an instance of an object that implements
        ///     the
        ///     <see
        ///         cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        ///     interface, containing the data to be written to the disk.
        /// </param>
        public static void Save(string pathname, IProfileCollection profileList)
        {
            if (string.IsNullOrWhiteSpace(pathname))
                return;

            if (profileList == null)
                return;

            try
            {
                var content = ConvertProfileCollection.ToJson(profileList);

                if (string.IsNullOrWhiteSpace(content))
                    return;

                if (File.Exists(pathname))
                    File.Delete(pathname);

                FileHelpers.MakeSureContainingFolderExists(pathname);

                File.WriteAllText(pathname, content);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}
