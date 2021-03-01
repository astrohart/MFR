using System;
using System.IO;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Gets match expressions (strings) for searching for files and folders to
    /// be included in operations.
    /// </summary>
    public static class GetMatchExpression
    {
        /// <summary>
        /// Given a <see
        /// cref="T:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs"/>
        /// as input, provides a string to be used in matching text against
        /// user-specified criteria.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration"/> interface
        /// and which represents the configuration settings chosen by the user.
        /// </param>
        /// <param name="e">
        /// A <see
        /// cref="T:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs"/>
        /// that contains the match data.
        /// </param>
        /// <returns>
        /// A <see cref="T:MassFileRenamer.Objects.MatchExpression"/> containing
        /// the data to match against a user-specified pattern, or <c>null</c>
        /// if an issue occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if any of the required parameters, <paramref
        /// name="configuration"/> or <paramref name="e"/> are passed
        /// <c>null</c> values.
        /// </exception>
        public static MatchExpression For(IConfiguration configuration,
            TestExpressionMatchRequestedEventArgs e)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));
            if (e == null)
                throw new ArgumentNullException(nameof(e));

            MatchExpression expression;

            switch (e.OperationType)
            {
                case OperationType.RenameFilesInFolder:
                    expression = new MatchExpression
                    {
                        Source =
                            configuration.MatchWholeWord
                                ? Path.GetFileNameWithoutExtension(e.Path)
                                : Path.GetFileName(e.Path),
                        Pattern = e.FindWhat
                    };
                    break;

                default:
                    expression = new MatchExpression
                    {
                        Source = e.Path,
                        Pattern = e.FindWhat,
                        SubstitutionDestination = e.ReplaceWith
                    };
                    break;
            }

            return expression;
        }
    }
}