using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Factories.Actions
{
    /// <summary>
    /// Exposes static methods to determine whether certain conditions are met by data.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class Is
    {
        /// <summary>
        /// Checks for write access for the given file.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the full pathname for which write
        /// permissions should be checked.
        /// </param>
        /// <returns>
        /// This method returns <see langword="true" /> if write access is allowed to the
        /// file with the specified <paramref name="path" />, otherwise
        /// <see langword="false" />.
        /// <para />
        /// The value <see langword="false" /> is also returned in the event that the
        /// <paramref name="path" /> parameter is a <see langword="null" /> value or blank.
        /// <para />
        /// The value <see langword="false" /> is also returned if an operating system
        /// error
        /// or exception occurs while trying to look up the file's permissions.
        /// </returns>
        public static bool FileWriteable(string path)
        {
            // write the name of the current class and method we are now
            var result = false;

            try
            {
                // Check whether the file has the read-only attribute set.
                if ((File.GetAttributes(path) & FileAttributes.ReadOnly) != 0)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Is.FileWriteable: The file '{0}' is not writeable.",
                        path
                    );
                    return result;
                }

                // Get the access rules of the specified files (user groups and
                // user names that have access to the file)
                var rules = File.GetAccessControl(path)
                                .GetAccessRules(
                                    true, true, typeof(SecurityIdentifier)
                                );

                // Get the identity of the current user and the groups that the
                // user is in.
                var groups = WindowsIdentity.GetCurrent()
                                            .Groups;
                var sidCurrentUser = WindowsIdentity.GetCurrent()
                                                    .User.Value;

                // Check if writing to the file is explicitly denied for this
                // user or a group the user is in.
                if (rules.OfType<FileSystemAccessRule>()
                         .Any(
                             r => (groups.Contains(r.IdentityReference) ||
                                   r.IdentityReference.Value ==
                                   sidCurrentUser) &&
                                  r.AccessControlType ==
                                  AccessControlType.Deny &&
                                  (r.FileSystemRights &
                                   FileSystemRights.WriteData) ==
                                  FileSystemRights.WriteData
                         ))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "Is.FileWriteable: The file '{0}' is not writeable due to security settings.",
                        path
                    );
                    return result;
                }

                // Check if writing is allowed
                result = rules.OfType<FileSystemAccessRule>()
                              .Any(
                                  r => (groups.Contains(r.IdentityReference) ||
                                        r.IdentityReference.Value ==
                                        sidCurrentUser) &&
                                       r.AccessControlType ==
                                       AccessControlType.Allow &&
                                       (r.FileSystemRights &
                                        FileSystemRights.WriteData) ==
                                       FileSystemRights.WriteData
                              );
            }
            catch (Exception e)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(e);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the file system entry having the specified
        /// <paramref name="pathname" /> is a folder or not.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the file system entry to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the file system entry having the specified
        /// <paramref name="pathname" /> is a folder; <see langword="false" /> otherwise.
        /// </returns>
        public static bool Folder(string pathname)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;

                // get the file attributes for file or directory
                var attr =
                    Alphaleonis.Win32.Filesystem.File.GetAttributes(pathname);
                if (attr == null) return result;

                //detect whether its a directory or file
                result = (attr & FileAttributes.Directory) ==
                         FileAttributes.Directory;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Checks for write access for the given folder.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the full pathname of the folder whose
        /// permissions are to be checked.
        /// </param>
        /// <returns>
        /// This method returns <see langword="true" /> if write access is allowed to the
        /// folder with the specified <paramref name="pathname" />, otherwise
        /// <see langword="false" />.
        /// <para />
        /// The value <see langword="false" /> is also returned in the event that the
        /// <paramref name="pathname" /> parameter is a <see langword="null" /> value or
        /// blank.
        /// <para />
        /// The value <see langword="false" /> is also returned if an operating system
        /// error
        /// or exception occurs while trying to look up the folder's permissions.
        /// </returns>
        public static bool FolderWriteable(string pathname)
        {
            // write the name of the current class and method we are now
            var result = false;

            try
            {
                if (!Does.FolderExist(pathname)) return result;

                // Get the access rules of the specified files (user groups and
                // user names that have access to the folder)
                var rules = Directory.GetAccessControl(pathname)
                                     .GetAccessRules(
                                         true, true, typeof(SecurityIdentifier)
                                     );

                // Get the identity of the current user and the groups that the
                // user is in.
                var groups = WindowsIdentity.GetCurrent()
                                            .Groups;
                if (!groups.Any()) return result;

                var sidCurrentUser = WindowsIdentity.GetCurrent()
                                                    .User.Value;
                if (string.IsNullOrWhiteSpace(sidCurrentUser)) return result;

                // Check if writing to the folder is explicitly denied for this
                // user or a group the user is in.
                if (rules.OfType<FileSystemAccessRule>()
                         .Any(
                             r => (groups.Contains(r.IdentityReference) ||
                                   r.IdentityReference.Value ==
                                   sidCurrentUser) &&
                                  r.AccessControlType ==
                                  AccessControlType.Deny &&
                                  (r.FileSystemRights &
                                   FileSystemRights.WriteData) ==
                                  FileSystemRights.WriteData
                         )) return result;

                // Check if writing is allowed
                result = rules.OfType<FileSystemAccessRule>()
                              .Any(
                                  r => (groups.Contains(r.IdentityReference) ||
                                        r.IdentityReference.Value ==
                                        sidCurrentUser) &&
                                       r.AccessControlType ==
                                       AccessControlType.Allow &&
                                       (r.FileSystemRights &
                                        FileSystemRights.WriteData) ==
                                       FileSystemRights.WriteData
                              );
            }
            catch (Exception e)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(e);

                result = false;
            }

            return result;
        }
    }
}