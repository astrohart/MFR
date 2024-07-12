using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Helpers;
using MFR.Settings.Configuration.Converters;
using MFR.Settings.Profiles.Collections.Factories;
using MFR.Settings.Profiles.Collections.Interfaces;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.Settings.Profiles.Serializers
{
    /// <summary>
    /// Loads and stores profile list information to/from a file.
    /// </summary>
    /// <remarks>
    /// The profile information is used in code via the
    /// <see
    ///     cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
    /// interface.
    /// </remarks>
    public static class ProfileCollectionSerializer
    {
        /// <summary>
        /// Loads data about the list of profiles from the file with the path specified by
        /// the <paramref name="pathname" /> parameter.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the fully-qualified pathname of a JSON-formatted
        /// data file on the file system that contains the profile-list data.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface.
        /// <para />
        /// The object instance referenced contains access to the set of profiles listed in
        /// the file.
        /// <para />
        /// The <see langword="null" /> reference is returned in the event a problem
        /// occurred.
        /// </returns>
        /// <remarks>
        /// If the <paramref name="pathname" /> parameter is not passed the fully-qualified
        /// pathname of a file that exists on the file system, or if an error occurs during the
        /// execution of the <c>Load</c> operation, then the empty collection is returned.
        /// </remarks>
        public static IProfileCollection Load(string pathname)
        {
            var result = GetEmptyProfileCollection.SoleInstance();

            try
            {
                if (!Does.FileExist(pathname))
                    return result;

                var content = File.ReadAllText(pathname);

                // If the file at the path pathname has zero bytes of data, or
                // only whitespace, then return a blank Configuration instance
                // with its properties all set to default values.
                if (string.IsNullOrWhiteSpace(content))
                    return result;

                result = ConvertProfileCollection.FromJson(content);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = GetEmptyProfileCollection.SoleInstance();
            }

            return result;
        }

        /// <summary>
        /// Saves profile-list data to a file.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname of the file that the data
        /// is to be saved to.
        /// </param>
        /// <param name="profileList">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface, containing the data to be written to the file system.
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

                MakeSure.ContainingFolderExists(pathname);

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