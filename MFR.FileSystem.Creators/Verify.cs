using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Creators.Properties;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Creators
{
    /// <summary>
    /// Methods to assert that file system entries satisfy certain conditions, or else.
    /// </summary>
    
    public static class Verify
    {
        /// <summary>
        /// Insists that the folder whose path is provided in the parameter
        /// <paramref name="containingFolderName" /> exists.
        /// </summary>
        /// <param name="containingFolderName">
        /// (Required.) String containing the path to the folder whose existence on the
        /// disk is to be verified.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="containingFolderName" />, is passed a blank or
        /// <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the folder whose path is <paramref name="containingFolderName" />
        /// does not exist on the file system when it is supposed to.
        /// </exception>
        public static void FolderWasCreated(string containingFolderName)
        {
            if (string.IsNullOrWhiteSpace(containingFolderName))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace,
                    nameof(containingFolderName)
                );
            if (Directory.Exists(containingFolderName))
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** SUCCESS *** Folder with path '{containingFolderName}' created."
                );
            else
                throw new InvalidOperationException(
                    $"Failed to create folder '{containingFolderName}'."
                );
        }
    }
}
