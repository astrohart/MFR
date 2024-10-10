using MFR.Operations.Constants;
using MFR.TextValues.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.TextValues.Retrievers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.FileSystem.Retrievers.ITextValueRetriever" />
    /// interface.
    /// </summary>
    /// <remarks>
    /// Objects that implement the
    /// <see cref="T:MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever" />
    /// interface examine pathnames of files and folders, or the contents of text
    /// files, for content in which the search term is to be searched for in a
    /// find-and-replace operation.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public static class GetTextValueRetriever
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.ITextValueRetriever" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="type">
        /// One of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values
        /// that specifies which operation is currently being performed.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Retrievers.Interfaces.ITextValueRetriever" />
        /// interface.
        /// </returns>
        /// <remarks>
        /// Objects that implement the
        /// <see cref="T:MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever" />
        /// interface examine pathnames of files and folders, or the contents of text
        /// files, for content in which the search term is to be searched for in a
        /// find-and-replace operation.
        /// </remarks>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the operation type specified by the
        /// <paramref
        ///     name="type" />
        /// parameter is not one of the supported values.
        /// </exception>
        public static ITextValueRetriever For(OperationType type)
        {
            ITextValueRetriever result = default;

            try
            {
                switch (type)
                {
                    case OperationType.RenameFilesInFolder:
                        result = GetFilenameTextValueRetriever.SoleInstance();
                        break;

                    case OperationType.ReplaceTextInFiles:
                        result = GetTextInFileTextValueRetriever.SoleInstance();
                        break;

                    case OperationType.RenameSolutionFolders:
                        result =
                            GetSolutionFolderTextValueRetriever.SoleInstance();
                        break;

                    case OperationType.RenameSubFolders:
                        result = GetFolderTextValueRetriever.SoleInstance();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(
                            nameof(type), type,
                            $"There is no text-value retriever object available for the operation type '{type}'."
                        );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}