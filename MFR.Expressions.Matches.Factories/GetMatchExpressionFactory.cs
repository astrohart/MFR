using MFR.Expressions.Matches.Factories.Interfaces;
using MFR.Operations.Constants;
using System;

namespace MFR.Expressions.Matches.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.IMatchExpressionFactory" />
    /// interface.
    /// </summary>
    public static class GetMatchExpressionFactory
    {
        /// <summary>
        /// Creates instances of objects that implement the
        /// <see
        ///     cref="T:MFR.IMatchExpressionFactory" />
        /// interface
        /// for the given operation <paramref name="type" />.
        /// </summary>
        /// <param name="type">
        /// The <see cref="T:MFR.Operations.Constants.OperationType" /> value that
        /// corresponds to the type of operation being performed.
        /// <para />
        /// NOTE: Not all operation types are supported.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IMatchExpressionFactory" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// value passed in the <paramref name="type" /> parameter does not
        /// correspond to an operation type for which a match expression object
        /// can be created.
        /// <para />
        /// Not all <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// are supported.
        /// </exception>
        public static IMatchExpressionFactory For(OperationType type)
        {
            IMatchExpressionFactory result;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    result = MakeNewFileNameReplacementMatchExpressionFactory
                        .FromScratch();
                    break;

                case OperationType.ReplaceTextInFiles:
                    result = MakeNewReplaceTextInFileMatchExpressionFactory
                        .FromScratch();
                    break;

                case OperationType.RenameSolutionFolders:
                    result =
                        MakeNewSolutionFolderNameReplacementMatchExpressionFactory
                            .FromScratch();
                    break;

                case OperationType.RenameSubFolders:
                    result = MakeNewFolderNameReplacementMatchExpressionFactory
                        .FromScratch();

                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"The operation type specified, '{type}', does not support creating match expressions."
                    );
            }

            return result;
        }
    }
}