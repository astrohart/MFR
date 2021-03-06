using MFR.Matchers.Factories.Interfaces;
using MFR.Operations.Constants;
using System;

namespace MFR.Matchers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.IStringMatcher" />
    /// interface.
    /// </summary>
    public static class GetStringMatcher
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringMatcher" />
        /// interface and
        /// returns a reference to it, for the given
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// value.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringMatcher" />
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
                    factory = RenameFilesInFolderStringMatcherFactory.Instance;
                    break;
                case OperationType.ReplaceTextInFiles:
                    factory = ReplaceTextInFilesStringMatcherFactory.Instance;
                    break;
                case OperationType.RenameSubFolders:
                    factory = RenameSubFoldersStringMatcherFactory.Instance;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return factory;
        }
    }
}
