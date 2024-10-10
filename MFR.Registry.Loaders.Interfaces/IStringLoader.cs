namespace MFR.Registry.Loaders.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that loads
    /// textual data from the system Registry.
    /// </summary>
    public interface IStringLoader
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
        string FromRegistry(string keyName, string valueName,
            string defaultValue = default);
    }
}