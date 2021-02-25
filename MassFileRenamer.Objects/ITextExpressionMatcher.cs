namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a filename-matcher object.
    /// </summary>
    public interface ITextExpressionMatcher
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration" /> interface.
        /// </summary>
        IConfiguration Configuration
        {
            get;
            set;
        }

        /// <summary>
        /// Determines whether a <paramref name="source" /> string is a match
        /// against a <paramref name="pattern" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="pattern">
        /// (Required.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="source" />
        /// or <paramref name="pattern" />, are passed blank or
        /// <c>null</c> string for values.
        /// </exception>
        /// <returns>
        /// Returns <c>true</c> if the <paramref name="source" /> is a match
        /// against the provided <paramref name="pattern" />; <c>false</c> if no
        /// matches are found.
        /// </returns>
        bool IsMatch(string source, string pattern);
    }
}