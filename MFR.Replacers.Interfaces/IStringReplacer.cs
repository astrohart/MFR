using MFR.Settings.Configuration.Interfaces;
using MFR.Operations.Interfaces;

namespace MFR.Replacers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// performs replacement on strings, said replacement operation differing
    /// depending on the type of file- or folder-rename operation type being
    /// performed and how the matching is configured.
    /// </summary>
    public interface IStringReplacer :
        IFixedTextMatchingConfigurationSpecificObject,
        IFixedOperationTypeSpecificObject
    {
        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="value" />. Returns a string
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data upon which the replacement
        /// operation is to be carried out.
        /// </param>
        /// <param name="pattern">
        /// (Required.) String containing the pattern that allows us to match
        /// the data to be replaced.
        /// </param>
        /// <param name="dest">
        /// (Optional.) Default is blank. String containing the new data that
        /// should be substituted for the replaced text.
        /// </param>
        /// <returns>
        /// String containing the new data.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// , <paramref name="pattern" />, or
        /// <paramref
        ///     name="dest" />
        /// , are passed blank or <see langword="null" /> string
        /// for values.
        /// </exception>
        string Replace(string value, string pattern, string dest = "");
    }
}