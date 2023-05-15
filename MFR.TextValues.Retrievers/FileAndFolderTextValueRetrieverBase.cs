using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Validators.Factories;
using MFR.FileSystem.Validators.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.TextValues.Retrievers
{
    /// <summary>
    /// Implements functionality common to retrievers of data for both files and folders.
    /// </summary>
    public abstract class FileAndFolderTextValueRetrieverBase : TextValueRetrieverBase
    {
        /// <summary>
        /// Gets a string containing the text to be searched, from the
        /// file-system <paramref name="entry" /> provided, given the current
        /// <see cref="T:MFR.Operations.Constants.OperationType"/> now being processed.
        /// </summary>
        /// <param name="entry">
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry"/> interface.
        /// </param>
        /// <returns>
        /// String containing the value data to be searched for the current
        /// operation type, or the empty string if the data source has no data.
        /// </returns>
        public override string GetTextValue(IFileSystemEntry entry)
        {
            var result = string.Empty;

            try
            {
                if (entry == null) return result;
                if (!FileSystemEntryValidatorSays.IsValid(entry)) return result;

                // the text value in which replacement should be done
                // for a file or a folder, is merely its pathname
                result = entry.Path;    
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}
