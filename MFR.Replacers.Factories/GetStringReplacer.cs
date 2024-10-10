using MFR.Operations.Constants;
using MFR.Replacers.Factories.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Replacers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.IStringReplacer" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetStringReplacer
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringReplacer" />
        /// interface and
        /// returns a reference to it, for the given
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// value.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringReplacer" />
        /// interface that corresponds to the specified type of operation.
        /// </returns>
        public static IStringReplacerFactory For(OperationType type)
        {
            IStringReplacerFactory result;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    result = GetRenameFilesInFolderStringReplacerFactory
                        .SoleInstance();
                    break;

                case OperationType.ReplaceTextInFiles:
                    result = GetReplaceTextInFilesStringReplacerFactory
                        .SoleInstance();
                    break;

                case OperationType.RenameSolutionFolders:
                    result = GetRenameSolutionFoldersStringReplacerFactory
                        .SoleInstance();
                    break;

                case OperationType.RenameSubFolders:
                    result = GetRenameSubFoldersStringReplacerFactory
                        .SoleInstance();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type, null
                    );
            }

            return result;
        }
    }
}