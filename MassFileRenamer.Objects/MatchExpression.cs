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
    public class MatchExpression
    {
        /// <summary>
        /// Gets or sets a string containing data to be searched.
        /// </summary>
        public string Pattern
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing a pattern to be matched against.
        /// </summary>
        public string Source
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the data that each of the occurrences of <see
        /// cref="P:MassFileRenamer.Objects.MatchExpression.Pattern"/> in the
        /// <see cref="P:MassFileRenamer.Objects.MatchExpression.Source"/> are
        /// to be replaced with.
        /// </summary>
        public string SubstitutionDestination
        {
            get;
            set;
        }
    }
}