using MFR.Objects.Configuration.Converters;
using MFR.Profiles.Collections;
using MFR.Profiles.Collections.Interfaces;
using System;
using System.IO;
using xyLOGIX.Core.Debug;
using File = Alphaleonis.Win32.Filesystem.File;

namespace MFR.Profiles.Serializers
{
    /// <summary>
    /// Loads and stores profile list information to/from a file.
    /// </summary>
    /// <remarks>
    /// The profile information is used in code via the <see
    /// cref="T:MFR.Profiles.Collections.Interfaces.IProfileCollection"/> interface.
    /// </remarks>
    public static class ProfileListSerializer
    {
        /// <summary>
        /// Loads data about the list of profiles from the file with the path specified by the <paramref name="pathname"/> parameter.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the fully-qualified pathname of a JSON-formatted data file on the disk that contains the profile-list data.
        /// </param>
        /// <returns>Reference to an instance of an object that implements the <see cref="T:MFR.Profiles.Collections.Interfaces.IProfileCollection" /> interface.<para/>The object instance referenced contains access to the set of profiles listed in the file.<para/>The <see langword="null" /> reference is returned in the event a problem occurred.</returns>
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
            if (string.IsNullOrWhiteSpace(pathname))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(pathname)
                );
            if (!File.Exists(pathname))
                throw new FileNotFoundException(
                    $"The system could not find the profile list file having the pathname '{pathname}'",
                    pathname
                );

            IProfileCollection result;

            try
            {
                var content = File.ReadAllText(pathname);

                // If the file at the path pathname has zero bytes of data, or
                // only whitespace, then return a blank Configuration instance
                // with its properties all set to default values.
                return string.IsNullOrWhiteSpace(content)
                    ? new ProfileCollection()
                    : ConvertProfileList.FromJson(content);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            return result;
        }
    }
}