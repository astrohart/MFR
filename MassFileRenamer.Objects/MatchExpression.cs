namespace MassFileRenamer.Objects
{
    /// <summary>
    /// POCO that models a match expression.
    /// </summary>
    /// <remarks>
    /// Match expressions consist of two strings: a <see
    /// cref="P:MassFileRenamer.Objects.MatchExpression.Source"/> and a <see
    /// cref="P:MassFileRenamer.Objects.MatchExpression.Pattern"/> . The <see
    /// cref="P:MassFileRenamer.Objects.MatchExpression.Source"/> is the string
    /// containing data to be searched for the pattern contained in the <see
    /// cref="P:MassFileRenamer.Objects.MatchExpression.Pattern"/> property.
    /// </remarks>
    public class MatchExpression : IMatchExpression
    {
        /// <summary>
        /// Gets or sets a string containing the pattern that is to be used as textual-expression search criteria.
        /// </summary>
        public string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing a pattern to be matched against.
        /// </summary>
        public string Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the data that each of the occurrences of <see
        /// cref="P:MassFileRenamer.Objects.MatchExpression.FindWhat"/> in the
        /// <see cref="P:MassFileRenamer.Objects.MatchExpression.Value"/> are
        /// to be replaced with.
        /// </summary>
        public string ReplaceWith
        {
            get;
            set;
        }
    }
}