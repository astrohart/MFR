using MFR.GUI.Models.Interfaces;
using Newtonsoft.Json;
using System;

namespace MFR.Settings.Configuration.Converters.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that converts
    /// instances of objects implementing the
    /// <see cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" /> interface to and
    /// from JSON.
    /// </summary>
    public interface IOperationTypeInfoConverter<T> where T : IOperationTypeInfo
    {
        /// <summary>
        /// Gets a value indicating whether values can be read from JSON.
        /// </summary>
        bool CanRead
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether values can be written to JSON.
        /// </summary>
        bool CanWrite
        {
            get;
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType"><see cref="T:System.Type" /> of the object.</param>
        /// <returns>
        /// <see langword="true" /> if this instance can convert the specified object type;
        /// otherwise, <see langword="false" />.
        /// </returns>
        bool CanConvert(Type objectType);

        /// <summary>Reads the JSON representation of the object.</summary>
        /// <param name="reader">
        /// The <see cref="T:Newtonsoft.Json.JsonReader" /> to read
        /// from.
        /// </param>
        /// <param name="objectType"><see cref="T:System.Type" /> of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer
        );

        /// <summary>Writes the JSON representation of the object.</summary>
        /// <param name="writer">
        /// The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write
        /// to.
        /// </param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        void WriteJson(
            JsonWriter writer,
            object value,
            JsonSerializer serializer
        );
    }
}