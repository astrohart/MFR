using MFR.Settings.Profiles;
using MFR.Settings.Profiles.Collections;
using MFR.Settings.Profiles.Collections.Converters;
using MFR.Settings.Profiles.Collections.Interfaces;
using MFR.Settings.Profiles.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;

namespace MFR.Settings.Configuration.Converters
{
    /// <summary>
    /// Converts JSON-formatted text to and from instances of C# objects that
    /// implement the <see cref="T:MFR.Settings.Configuration.Interfaces.IProfileCollection" />
    /// interface.
    /// </summary>
    public static class ConvertProfileCollection
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
                    },
                    new ProfileCollectionConverter<ProfileCollection>(),
                    new ProfileConverter<Profile>()
                }
            };

        /// <summary>
        /// Converts a string containing JSON-formatted text into an instance of
        /// an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProfileCollection" />
        /// interface and
        /// returns a reference to it.
        /// </summary>
        /// <param name="json">
        /// (Required.) String containing the JSON to convert.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProfileCollection" />
        /// interface whose
        /// properties are initialized to the data values read in from the JSON
        /// text, or <see langword="null" /> if a problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="json" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        public static IProfileCollection FromJson(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(json)
                );
            return JsonConvert.DeserializeObject<ProfileCollection>(json, Settings);
        }

        /// <summary>
        /// Converts an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProfileCollection" />
        /// interface into a
        /// JSON-formatted string and returns the resultant string.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IProfileCollection" /> interface
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
        public static string ToJson(IProfileCollection configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));
            return JsonConvert.SerializeObject(
                configuration as ProfileCollection, Settings
            );
        }
    }
}