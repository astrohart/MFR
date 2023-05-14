using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Factories.Actions
{
    /// <summary>
    /// Determines whether data meets certain conditions.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class Does
    {
        /// <summary>
        /// Determines whether the file having the specified <paramref name="pathname" />
        /// exists.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to check.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="pathname" /> refers to
        /// a file and the file exists; <see langword="false" /> otherwise.
        /// </returns>
        public static bool FileExist(string pathname)
        {
            var result = false;

            // Dump the variable pathname to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, $"Does.FileExist: pathname = '{pathname}'"
            );

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (Is.Folder(pathname)) return result;

                result = File.Exists(pathname);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug, $"Does.FileExist: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Determines whether the file system entry having the specified
        /// <paramref name="pathname" /> exists.
        /// </summary>
        /// <param name="pathname"></param>
        /// <returns></returns>
        /// <remarks>
        /// Use this method when you have no way of telling, in your code, whether
        /// the file system entry having the specified <paramref name="pathname" /> is a
        /// folder or a file.
        /// <para />
        /// This method does the exists check for either a file or a folder having the
        /// specified <paramref name="pathname" />; if either check returns
        /// <see langword="true" />, then this check returns <see langword="true" /> as
        /// well.
        /// <para />
        /// This method returns the result of performing a bitwise OR operation on the
        /// results of the <see cref="M:MFR.FileSystem.Factories.Actions.Does.FileExist" />
        /// and <see cref="M:MFR.FileSystem.Factories.Actions.Does.FolderExist" /> methods.
        /// <para />
        /// If a blank or <see langword="null" /> <see cref="T:System.String" /> is passed
        /// as the argument of the <paramref name="pathname" /> parameter, then this method
        /// returns <see langword="false" />.
        /// </remarks>
        public static bool FileSystemEntryExist(string pathname)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;

                result = FileExist(pathname) | FolderExist(pathname);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the folder having the specified <paramref name="pathname" />
        /// exists.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder to check.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="pathname" /> refers to
        /// a folder and the folder exists; <see langword="false" /> otherwise.
        /// </returns>
        public static bool FolderExist(string pathname)
        {
            var result = false;

            // Dump the variable pathname to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, $"Does.FolderExist: pathname = '{pathname}'"
            );

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;
                if (!Is.Folder(pathname)) return result;

                result = Directory.Exists(pathname);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug, $"Does.FolderExist: Result = {result}"
            );

            return result;
        }
    }
}