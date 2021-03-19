using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates new instances of <see cref="T:System.IO.FileInfo"/>.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetNewFileInfo
    {
        /// <summary>
        /// Creates a new instance of a <see cref="T:System.IO.FileInfo"/>
        /// object for the file with the specified <paramref name="path"/>.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of the
        /// file that you wish to be wrapped with an instance of <see cref="T:System.IO.FileInfo"/>.
        /// </param>
        /// <returns>
        /// Reference to the resulting instance of <see
        /// cref="T:System.IO.FileInfo"/> that encapsulates access to the file
        /// whose pathname is passed in the <paramref name="path"/> parameter;
        /// or <see langword="null" /> if an error occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path"/>, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file, the path to which is specified by the <paramref
        /// name="path"/> parameter, cannot be located on the disk.
        /// </exception>
        [Log(AttributeExclude = true)]
        public static FileInfo ForPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            if (!File.Exists(path)
            ) // can't create a FileInfo for a file that does not exist
                throw new FileNotFoundException(
                    $"The file with the pathname '{path}' could not be located on the disk.",
                    path
                );

            FileInfo result;

            try
            {
                result = new FileInfo(path);
            }
            catch
            {
                return null;
            }

            return result;
        }
    }
}