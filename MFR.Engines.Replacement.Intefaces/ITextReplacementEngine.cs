using MFR.Settings.Configuration.Interfaces;
using MFR.Expressions.Matches.Interfaces;
using MFR.Operations.Interfaces;

namespace MFR.Engines.Replacement.Intefaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a text-replacement object.
    /// </summary>
    /// <remarks>
    /// These objects specify rules as to how to replace text when matches have
    /// already been located.
    /// </remarks>
    public interface ITextReplacementEngine : IConfigurationComposedObject, IFixedOperationTypeSpecificObject
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
        /// or <paramref name="pattern" />, are passed blank or
        /// <see langword="null" /> string for values.
        /// </exception>
        string Replace(string value, string pattern, string dest = "");

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="expression" />. Returns a string
        /// containing the results.
        /// </summary>
        /// <param name="expression">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.IMatchExpression" />
        /// interface that contains the replacement data.
        /// </param>
        /// <returns>
        /// String containing the new data.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        string Replace(IMatchExpression expression);
    }
}