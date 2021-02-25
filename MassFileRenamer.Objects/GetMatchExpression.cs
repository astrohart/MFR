using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Gets match expressions (strings) for searching for files and folders to
    /// be included in operations.
    /// </summary>
    public static class GetMatchExpression
    {
        /// <summary>
        /// Given a
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs" />
        /// as input, provides a string to be used in matching text against
        /// user-specified criteria.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs" />
        /// that contains the match data.
        /// </param>
        /// <returns>
        /// String containing the data to match against a user-specified
        /// pattern, or blank if an issue occurred.
        /// </returns>
        public static string For(TestExpressionMatchRequestedEventArgs e)
        {
            var result = string.Empty;

            switch (e.OperationType)
            {
                case OperationType.RenameFilesInFolder:
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(e.OperationType), e.OperationType,
                        "The OperationType value, '{type}', supplied is not supported."
                    );
            }

            return result;
        }
    }
}