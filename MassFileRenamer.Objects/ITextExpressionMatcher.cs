namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a filename-matcher object.
    /// </summary>
    public interface ITextExpressionMatcher : IConfigurationComposedObject
    {
        /// <summary>
        /// Determines whether a <paramref name="source" /> string is a match
        /// against a <paramref name="pattern" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="pattern">
        /// (Optional.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <param name="dest">
        /// (Required.) String containing the data that all instances of
        /// <paramref name="pattern" /> in <paramref name="source" /> are to be
        /// replaced with.
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
        bool IsMatch(string source, string pattern, string dest = "");

        /// <summary>
        /// Determines whether data and a search patterned, bound up together in
        /// the form of the <paramref name="expression" /> provided, contain a
        /// data match according to rules specified by the user in the object, a
        /// reference to which is specified in the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.ITextExpressionMatcher.Configuration" />
        /// property.
        /// </summary>
        /// <param name="expression">
        /// (Required.) A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchExpression" />
        /// containing the
        /// match and pattern data.
        /// </param>
        /// <returns>
        /// <c>true</c> if more than zero matches are found; <c>false</c> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <c>null</c> value.
        /// </exception>
        bool IsMatch(MatchExpression expression);
    }
}