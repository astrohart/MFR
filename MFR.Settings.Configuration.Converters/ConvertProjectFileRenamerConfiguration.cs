using MFR.GUI.Models;
using MFR.Settings.Configuration.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Globalization;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Converters
{
    /// <summary>
    /// Converts JSON-formatted text to and from instances of C# objects that
    /// implement the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
    /// interface.
    /// </summary>
    public static class ConvertProjectFileRenamerConfiguration
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
                    new OperationTypeInfoConverter<OperationTypeInfo>()
                }
            };

        /// <summary>
        /// Converts a string containing JSON-formatted text into an instance of
        /// an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface and
        /// returns a reference to it.
        /// </summary>
        /// <param name="json">
        /// (Required.) String containing the JSON to convert.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface whose
        /// properties are initialized to the data values read in from the JSON
        /// text, or <see langword="null" /> if a problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="json" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        public static IProjectFileRenamerConfiguration FromJson(
            [NotLogged] string json)
        {
            IProjectFileRenamerConfiguration result = default;

            try
            {
                if (string.IsNullOrWhiteSpace(json)) return result;

                result =
                    JsonConvert
                        .DeserializeObject<ProjectFileRenamerConfiguration>(
                            json, Settings
                        );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Converts an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface into a
        /// JSON-formatted string and returns the resultant string.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface
        /// that is to be converted into JSON-formatted text.
        /// </param>
        /// <returns>
        /// String containing the JSON equivalent of the
        /// <paramref
        ///     name="configuration" />
        /// object fed in.
        /// </returns>
        /// <remarks>
        /// This method returns the <see cref="F:System.String.Empty" /> value in the event
        /// that either a <see langword="null" /> reference was passed as the argument of
        /// the <paramref name="configuration" /> parameter, or if the deserialization
        /// operation fails.
        /// </remarks>
        [return: NotLogged]
        public static string ToJson(
            IProjectFileRenamerConfiguration configuration)
        {
            var result = string.Empty;

            try
            {
                if (configuration == null) return result;

                result = JsonConvert.SerializeObject(
                    configuration as ProjectFileRenamerConfiguration, Settings
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}