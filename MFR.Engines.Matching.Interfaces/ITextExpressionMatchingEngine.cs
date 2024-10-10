using MFR.Settings.Configuration.Interfaces;
using MFR.Expressions.Matches.Interfaces;
using MFR.Operations.Interfaces;

namespace MFR.Engines.Matching.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a filename-matcher object.
    /// </summary>
    public interface ITextExpressionMatchingEngine :
        IConfigurationComposedObject, IFixedOperationTypeSpecificObject
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
        /// <see langword="null" /> string for values.
        /// </exception>
        /// <returns>
        /// Returns <see langword="true" /> if the <paramref name="value" /> is a
        /// match against the provided <paramref name="findWhat" />;
        /// <see
        ///     langword="false" />
        /// if no matches are found.
        /// </returns>
        bool IsMatch(string value, string findWhat, string replaceWith = "");

        /// <summary>
        /// Determines whether data and a search patterned, bound up together in
        /// the form of the <paramref name="expression" /> provided, contain a
        /// data match according to rules specified by the user in the object, a
        /// reference to which is specified in the
        /// <see
        ///     cref="P:MFR.ITextExpressionMatchingEngine.ProjectFileRenamerConfig" />
        /// property.
        /// </summary>
        /// <param name="expression">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.IMatchExpression" />
        /// interface and whose properties contain the match and pattern data.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if more than zero matches are found;
        /// <see
        ///     langword="false" />
        /// otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        bool IsMatch(IMatchExpression expression);
    }
}