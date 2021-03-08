namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a filename-matcher object.
    /// </summary>
    public interface ITextExpressionMatcher : IConfigurationComposedObject
    {
        /// <summary>
        /// Determines whether a <paramref name="value" /> string is a match
        /// against a <paramref name="findWhat" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="findWhat">
        /// (Optional.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the data that all instances of
        /// <paramref name="findWhat" /> in <paramref name="value" /> are to be
        /// replaced with.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// or <paramref name="findWhat" />, are passed blank or
        /// <c>null</c> string for values.
        /// </exception>
        /// <returns>
        /// Returns <c>true</c> if the <paramref name="value" /> is a match
        /// against the provided <paramref name="findWhat" />; <c>false</c> if no
        /// matches are found.
        /// </returns>
        bool IsMatch(string value, string findWhat, string replaceWith = "");

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
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IMatchExpression" />
        /// interface and whose properties contain the match and pattern data.
        /// </param>
        /// <returns>
        /// <c>true</c> if more than zero matches are found; <c>false</c> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <c>null</c> value.
        /// </exception>
        bool IsMatch(IMatchExpression expression);
    }
}