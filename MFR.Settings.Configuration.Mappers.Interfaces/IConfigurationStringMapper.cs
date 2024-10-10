using MFR.Settings.Configuration.Mappers.Constants;

namespace MFR.Settings.Configuration.Mappers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that carries
    /// out string replacement on configuration setting values as defined in an
    /// internal dictionary.
    /// </summary>
    public interface IConfigurationStringMapper
    {
        /// <summary>
        /// Gets or sets a value that indicates whether this mapper replaces <c>\r\n</c>
        /// with <c>\n</c> in strings that it receives.
        /// </summary>
        bool ReplaceCRLFWithNewline
        {
            get;
        }

        /// <summary>
        /// One of the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType" />
        /// enumeration values that defines what type of mapper object this.
        /// </summary>
        ConfigurationStringMapperType Type
        {
            get;
        }

        /// <summary>
        /// Carries out the replacement as configured.
        /// </summary>
        /// <param name="input">
        /// (Required.) A <see cref="T:System.String" /> value to be
        /// mapped.
        /// </param>
        /// <returns>A <see cref="T:System.String" /> value containing the replaced values.</returns>
        string Map(string input);
    }
}