using MFR.Matchers.Factories.Interfaces;
using MFR.Operations.Constants;
using System;

namespace MFR.Matchers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
    /// interface.
    /// </summary>
    public static class GetStringMatcherFactory
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
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
        ///     cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
        /// interface that corresponds to the specified type of operation.
        /// </returns>
        public static IStringMatcherFactory For(OperationType type)
        {
            IStringMatcherFactory factory = null;
            
            switch (type)
            {
                case OperationType.GettingListOfFilesToBeRenamed:
                    break;
                case OperationType.RenameFilesInFolder:
                    factory = GetRenameFilesInFolderStringMatcherFactory
                        .SoleInstance();
                    break;
                case OperationType.ReplaceTextInFiles:
                    factory = GetReplaceTextInFilesStringMatcherFactory
                        .SoleInstance();
                    break;
                case OperationType.RenameSubFolders:
                    factory = GetRenameSubFoldersStringMatcherFactory
                        .SoleInstance();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return factory;
        }
    }
}
