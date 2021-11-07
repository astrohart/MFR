namespace MFR.Registry.Loaders
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all loaders of data
    /// from the system Registry.
    /// </summary>
    public abstract class Loader<T> where T : class
    {
        /// <summary>
        /// Obtains a data value from the system Registry key.
        /// </summary>
        /// <param name="keyName">
        /// (Required.) String containing the name of the subkey under which the
        /// value resides.
        /// </param>
        /// <param name="valueName">
        /// (Required.) Name of the Registry value of type <c>REG_SZ</c> that
        /// contains the information requested.
        /// </param>
        /// <param name="defaultValue">
        /// (Optional.) Default value to return if the key/value is not found.
        /// This parameter is <see langword="null" /> by default.
        /// </param>
        /// <returns>
        /// Reference to an object containing the value data, or the value of the
        /// <paramref
        ///     name="defaultValue" />
        /// parameter if the value was not found or a
        /// problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="keyName" />, is blank.
        /// </exception>
        public abstract T FromRegistry(string keyName, string valueName,
            T defaultValue = default);
    }
}