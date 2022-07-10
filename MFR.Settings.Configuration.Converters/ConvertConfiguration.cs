using MFR.Settings.Configuration.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Globalization;

namespace MFR.Settings.Configuration.Converters
{
    /// <summary>
    /// Converts JSON-formatted text to and from instances of C# objects that
    /// implement the <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
    /// interface.
    /// </summary>
    public static class ConvertConfiguration
    {
        /// <summary>
        /// Obtains a reference to an instance of
        /// <see
        ///     cref="T:Newtonsoft.Json.JsonSerializerSettings" />
        /// that specifies how
        /// to serialize objects to/from JSON.
        /// </summary>
        public static readonly JsonSerializerSettings Settings =
            new JsonSerializerSettings {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented,
                DateParseHandling = DateParseHandling.None,
                Converters = {
                    new IsoDateTimeConverter {
                        DateTimeStyles = DateTimeStyles.AssumeUniversal
                    }
                }
            };

        /// <summary>
        /// Converts a string containing JSON-formatted text into an instance of
        /// an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
        /// interface and
        /// returns a reference to it.
        /// </summary>
        /// <param name="json">
        /// (Required.) String containing the JSON to convert.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
        /// interface whose
        /// properties are initialized to the data values read in from the JSON
        /// text, or <see langword="null" /> if a problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="json" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        public static IConfiguration FromJson([NotLogged] string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(json)
                );
            return JsonConvert.DeserializeObject<Configuration>(json, Settings);
        }

        /// <summary>
        /// Converts an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
        /// interface into a
        /// JSON-formatted string and returns the resultant string.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" /> interface
        /// that is to be converted into JSON-formatted text.
        /// </param>
        /// <returns>
        /// String containing the JSON equivalent of the
        /// <paramref
        ///     name="configuration" />
        /// object fed in.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        [return:NotLogged]
        public static string ToJson(IConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));
            return JsonConvert.SerializeObject(
                configuration as Configuration, Settings
            );
        }
    }
}