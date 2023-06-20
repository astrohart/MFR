using MFR.GUI.Models.Interfaces;
using MFR.Settings.Configuration.Converters.Interfaces;
using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Configuration.Converters
{
    /// <summary>
    /// Converts incoming/outgoing JSON to/from the proper concrete types for
    /// <c>OperationTypeInfo</c>s.
    /// </summary>
    /// <typeparam name="T">
    /// Name of a concrete object that implements the
    /// <see cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" /> interface.
    /// </typeparam>
    /// <remarks>
    /// The type parameter is used here since we are converting properties based on the
    /// <see cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" /> interface, and
    /// not any of its concrete types.
    /// <para />
    /// Since this class has no way of knowing which of the concrete implementations of
    /// the <see cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" /> interface we
    /// will be using, we supply the type parameter in order to let the user of this
    /// class decide for us.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class OperationTypeInfoConverter<T> : JsonConverter,
        IOperationTypeInfoConverter<T> where T : IOperationTypeInfo
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType"><see cref="T:System.Type" /> of the object.</param>
        /// <returns>
        /// <see langword="true" /> if this instance can convert the specified object type;
        /// otherwise, <see langword="false" />.
        /// </returns>
        public override bool CanConvert(Type objectType)
            => objectType == typeof(IOperationTypeInfo);

        /// <summary>Reads the JSON representation of the object.</summary>
        /// <param name="reader">
        /// The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.
        /// </param>
        /// <param name="objectType"><see cref="T:System.Type" /> of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer
        )
            => serializer.Deserialize(reader, typeof(T));

        /// <summary>Writes the JSON representation of the object.</summary>
        /// <param name="writer">
        /// The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.
        /// </param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(
            JsonWriter writer,
            object value,
            JsonSerializer serializer
        )
            => serializer.Serialize(writer, value);
    }
}