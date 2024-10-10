namespace MFR.Expressions.Matches.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that specifies
    /// textual search criteria.
    /// </summary>
    public interface IMatchExpression
    {
        /// <summary>
        /// Gets or sets a string containing the pattern that is to be used as
        /// textual-expression search criteria.
        /// </summary>
        string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing a pattern to be matched against.
        /// </summary>
        string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing a pattern to be matched against.
        /// </summary>
        string Value
        {
            get;
            set;
        }
    }
}