namespace MFR.Registry.Writers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that loads
    /// textual data to the system Registry.
    /// </summary>
    public interface IStringWriter
    {
        /// <summary>
        /// Writes a data value to the system Registry key.
        /// </summary>
        /// <param name="keyName">
        /// (Required.) String containing the name of the subkey under which the
        /// value resides, or is to be written.<para/>If the key does not exist, it will be created.
        /// </param>
        /// <param name="valueName">
        /// (Required.) Name of the Registry value of type <c>REG_SZ</c> that
        /// contains the information requested.
        /// </param>
        /// <param name="data">
        /// (Required.) Value data to be written to the system Registry./// </param>
        /// <returns>
        /// Reference to an object containing the value data, or the value of the
        /// <paramref
        ///     name="data" />
        /// parameter if the value was not found or a
        /// problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="keyName" />, is blank.
        /// </exception>
        void ToRegistry(string keyName, string valueName,
            string data);
    }
}