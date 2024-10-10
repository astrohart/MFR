using MFR.Settings.Profiles.Collections.Interfaces;
using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Collections.Converters
{
    /// <summary>
    /// Converts incoming/outgoing JSON to/from the proper concrete types for
    /// ProfileCollections.
    /// </summary>
    /// <typeparam name="T">
    /// Name of a concrete object that implements the
    /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" /> interface.
    /// </typeparam>
    /// <remarks>
    /// The type parameter is used here since we are converting properties
    /// based on the <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" /> interface, and not any of
    /// its concrete types.
    /// <para />
    /// Since this class has no way of knowing which of the concrete implementations of
    /// the <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" /> interface we will be using, we
    /// supply the type parameter in order to let the user of this class decide for us.
    /// </remarks>
    [Log(AttributeExclude = true)]
    public class ProfileCollectionConverter<T> : JsonConverter
        where T : IProfileCollection
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// <c>true</c> if this instance can convert the specified object type; otherwise,
        /// <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
            => objectType == typeof(IProfileCollection);

        /// <summary>Reads the JSON representation of the object.</summary>
        /// <param name="reader">
        /// The <see cref="T:Newtonsoft.Json.JsonReader" /> to read
        /// from.
        /// </param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType,
            object existingValue, JsonSerializer serializer)
            => serializer.Deserialize(reader, typeof(T));

        /// <summary>Writes the JSON representation of the object.</summary>
        /// <param name="writer">
        /// The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write
        /// to.
        /// </param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value,
            JsonSerializer serializer)
            => serializer.Serialize(writer, value);
    }
}