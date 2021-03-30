using System;
using System.IO;
using xyLOGIX.Core.Debug;

namespace MFR.Objects
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
        ///     cref="T:MFR.Objects.TextExpressionMatchRequestedEventArgs" />
        /// as input, provides a reference to an instance of an object that
        /// implements the
        /// <see
        ///     cref="T:MFR.Objects.IMatchExpression" />
        /// interface that
        /// can be used in matching text against user-specified criteria.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.IConfiguration" /> interface
        /// and which represents the configuration settings chosen by the user.
        /// </param>
        /// <param name="e">
        /// An instance of an object that inherits from
        /// <see
        ///     cref="T:MFR.Objects.TextPatternMatchEventArgs" />
        /// and
        /// contains the match data.
        /// </param>
        /// <returns>
        /// A <see cref="T:MFR.Objects.MatchExpression" /> containing
        /// the data to match against a user-specified pattern, or <c>null</c>
        /// if an issue occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if any of the required parameters,
        /// <paramref
        ///     name="configuration" />
        /// or <paramref name="e" /> are passed
        /// <c>null</c> values.
        /// </exception>
        public static IMatchExpression For(IConfiguration configuration,
            TextPatternMatchEventArgs e)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(DebugLevel.Debug, "In GetMatchExpression.For");

            // Dump the variable e.OperationType to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"GetMatchExpression.For: e.OperationType = '{e.OperationType}'"
            );

            // Dump the variable e.Source to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"GetMatchExpression.For: e.Source = '{e.Source}'"
            );

            // Dump the variable e.FindWhat to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"GetMatchExpression.For: e.FindWhat = '{e.FindWhat}'"
            );

            // Dump the variable e.ReplaceWith to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"GetMatchExpression.For: e.ReplaceWith = '{e.ReplaceWith}'"
            );

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));
            if (e == null)
                throw new ArgumentNullException(nameof(e));

            MatchExpression expression;

            switch (e.OperationType)
            {
                case OperationType.RenameFilesInFolder:
                    expression = new MatchExpression {
                        Value = configuration.MatchWholeWord
                            ? Path.GetFileNameWithoutExtension(e.Source)
                            : Path.GetFileName(e.Source),
                        FindWhat = e.FindWhat,
                        ReplaceWith = e.ReplaceWith
                    };
                    break;

                case OperationType.ReplaceTextInFiles:
                    expression = new MatchExpression {
                        Value =
                            FileHelpers.GetContent(
                                e.Source
                            ), // source is the pathname of file
                        FindWhat = e.FindWhat,
                        ReplaceWith = e.ReplaceWith
                    };
                    break;

                default:
                    expression = new MatchExpression {
                        Value = e.Source,
                        FindWhat = e.FindWhat,
                        ReplaceWith = e.ReplaceWith
                    };
                    break;
            }

            return expression;
        }
    }
}