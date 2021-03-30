using System;

namespace MFR.Objects
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.IMatchExpressionFactory" />
    /// interface.
    /// </summary>
    public static class GetMatchExpressionFactory
    {
        /// <summary>
        /// Creates instances of objects that implement the
        /// <see
        ///     cref="T:MFR.Objects.IMatchExpressionFactory" />
        /// interface
        /// for the given operation <paramref name="type" />.
        /// </summary>
        /// <param name="type">
        /// The <see cref="T:MFR.Objects.OperationType" /> value that
        /// corresponds to the type of operation being performed.
        /// <para />
        /// NOTE: Not all operation types are supported.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IMatchExpressionFactory" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the <see cref="T:MFR.Objects.OperationType" />
        /// value passed in the <paramref name="type" /> parameter does not
        /// correspond to an operation type for which a match expression object
        /// can be created.
        /// <para />
        /// Not all <see cref="T:MFR.Objects.OperationType" /> values
        /// are supported.
        /// </exception>
        public static IMatchExpressionFactory For(OperationType type)
        {
            IMatchExpressionFactory factory = null;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    factory = new FileNameReplacementMatchExpressionFactory();
                    break;

                case OperationType.ReplaceTextInFiles:
                    factory = new ReplaceTextInFileMatchExpressionFactory();
                    break;

                case OperationType.RenameSubFolders:
                    factory = new FolderNameReplacementMatchExpressionFactory();

                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"The operation type specified, '{type}', does not support creating match expressions."
                    );
            }

            return factory;
        }
    }
}