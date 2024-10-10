using MFR.Settings.Configuration.Interfaces;
using MFR.Operations.Interfaces;

namespace MFR.Matchers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// performs matching on strings.
    /// </summary>
    /// <remarks>
    /// The type of matching performed varies by file- and folder-renaming
    /// operation type, as well as the specific config of matching (Match
    /// Case, Match Exact Word etc.).
    /// </remarks>
    public interface IStringMatcher :
        IFixedTextMatchingConfigurationSpecificObject,
        IFixedOperationTypeSpecificObject
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
    }
}