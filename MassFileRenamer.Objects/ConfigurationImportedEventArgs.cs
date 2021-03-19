﻿using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the data that is passed by all events of type <see cref="T:MassFileRenamer.Objects.ConfigurationImportedEventHandler"/>.
    /// </summary>
    public class ConfigurationImportedEventArgs : EventArgs
    {
        /// <summary>
        /// Creates a new instance of <see
        /// cref="T:MassFileRenamer.Objects.ConfigurationImportedEventArgs"/>
        /// and returns a reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the path of the imported file.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path"/>, is passed
        /// a blank or <see langword="null" /> value.
        /// </exception>
        public ConfigurationImportedEventArgs(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            Path = path;
        }

        /// <summary>
        /// Gets a string containing the path to the file that was imported.
        /// </summary>
        public string Path
        {
            get;
        }
    }
}