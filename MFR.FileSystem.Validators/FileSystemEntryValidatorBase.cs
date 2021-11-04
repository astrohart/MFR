using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Validators
{
    /// <summary>
    /// Defines the common methods, properties, events, and other functionality
    /// for all types of file-system-entry validator object.
    /// </summary>
    public abstract class
        FileSystemEntryValidatorBase : IFileSystemEntryValidator
    {
        /// <summary>
        /// Determines whether the specified file-system
        /// <paramref
        ///     name="entry" />
        /// exists on the disk.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the file-system <paramref name="entry" />
        /// exists on the disk; <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public virtual bool DoesExist(IFileSystemEntry entry)
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In FileSystemEntryValidatorBase.DoesExist"
            );

            var result = false;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "FileSystemEntryValidatorBase.DoesExist: Checking whether the 'entry' method parameter has a null reference for a value..."
            );

            // Check to see if the required parameter, entry, is null. If it is, send an
            // error to the log file and quit, returning the default return value of this
            // method.
            if (entry == null)
            {
                // the parameter entry is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "FileSystemEntryValidatorBase.DoesExist: A null reference was passed for the 'entry' method parameter."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "FileSystemEntryValidatorBase.DoesExist: This method parameter is required to have a valid object reference."
                );

                // log the result
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileSystemEntryValidatorBase.DoesExist: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "FileSystemEntryValidatorBase.DoesExist: Done."
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "FileSystemEntryValidatorBase.DoesExist: We have been passed a valid object reference for the 'entry' method parameter."
            );

            // Dump the variable entry.Path to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileSystemEntryValidatorBase.DoesExist: entry.Path = '{entry.Path}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the value of the 'entry.Path' parameter is blank..."
            );

            if (string.IsNullOrWhiteSpace(entry.Path))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "FileSystemEntryValidatorBase.DoesExist: Blank value passed for the 'entry.Path' parameter. This parameter is required."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileSystemEntryValidatorBase.DoesExist: Result = {result}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "FileSystemEntryValidatorBase.DoesExist: Done."
                );

                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The parameter 'entry.Path' is not blank.  Continuing..."
            );

            try
            {
                result = DoesExist(entry.Path);
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
        /// Determines whether a file system <paramref name="entry" /> exists on
        /// the disk at the pathname indicated.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface containing information about the entry to be checked.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="entry" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the pathname to a folder is passed in the
        /// <paramref
        ///     name="entry" />
        /// parameter and the folder cannot be located on the disk.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the pathname to a file is passed in the
        /// <paramref
        ///     name="entry" />
        /// parameter and the file cannot be located on the disk.
        /// </exception>
        public abstract void IsValid(IFileSystemEntry entry);

        /// <summary>
        /// Determines whether the file-system entry with the specified
        /// <paramref name="path" /> should be skipped during an operation.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname on the disk of the
        /// file-system entry that is to potentially be skipped.
        /// </param>
        /// <returns>
        /// <see langword="true" /> is returned by this method if the file-system
        /// entry with the specified <paramref name="path" /> is to be skipped by
        /// the operation; otherwise, <see langword="false" />.
        /// </returns>
        public virtual bool ShouldSkip(string path)
        {
            var result = true;

            if (string.IsNullOrWhiteSpace(path)) return result;

            try
            {
                result = string.IsNullOrWhiteSpace(path) || !DoesExist(path) ||
                         path.Contains("packages") || path.Contains(".git") ||
                         path.Contains(".vs") || path.Contains(@"\bin") ||
                         path.Contains(@"\obj") || Path.GetFileName(path)
                             .StartsWith(".");
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Gets a value determining whether the file system entry having the specified
        /// <paramref name="path" /> should be not be skipped.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of a folder or a
        /// file.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the file or folder specified should not be
        /// skipped during the current operation; <see langword="false" /> otherwise.
        /// </returns>
        public bool ShouldNotSkip(string path)
            => !ShouldSkip(path);

        /// <summary>
        /// Determines whether the file system entry at the specified
        /// <paramref name="path" />, be it a file or a folder, exists.
        /// <para />
        /// Since a different API is used to determine whether files or directories exist,
        /// this method must be overriden by child classes.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname
        /// of the resource whose existence must be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the resource exists at the path specified;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// The purpose of this method is really to provide resource-existence detection
        /// services to the public overload of this method, and so it can be used in the
        /// body of, e.g., the
        /// <see cref="M:MFR.FileSystem.Validators.FileSystemEntryValidatorBase.ShouldSkip" />
        /// method.
        /// </remarks>
        protected virtual bool DoesExist(string path)
        {
            var result = false;

            if (string.IsNullOrWhiteSpace(path)) return result;

            try
            {
                result = File.Exists(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}