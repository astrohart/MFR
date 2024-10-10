using MFR.Settings.Configuration.Constants;
using MFR.Operations.Interfaces;
using MFR.Replacers.Interfaces;

namespace MFR.Replacers.Factories.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a String Replacer
    /// Factory object.
    /// </summary>
    /// <remarks>
    /// There must be one implementer of this interface for each of the relevant
    /// operation types (Rename File in Folder etc.).
    /// </remarks>
    public interface IStringReplacerFactory : IFixedOperationTypeSpecificObject
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringReplacer" />
        /// interface and
        /// returns a reference to it for the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// value
        /// that is specified by the <paramref name="matchingConfig" /> parameter.
        /// </summary>
        /// <param name="matchingConfig">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values
        /// that specifies which type of matching is being done.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringReplacer" />
        /// interface.
        /// </returns>
        IStringReplacer AndTextMatchingConfiguration(
            TextMatchingConfiguration matchingConfig);
    }
}