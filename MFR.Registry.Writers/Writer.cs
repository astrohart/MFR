namespace MFR.Registry.Writers
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all writers of data
    /// to the system Registry.
    /// </summary>
    public abstract class Writer<T> where T : class
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
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="keyName" />, is blank.
        /// </exception>
        public abstract void ToRegistry(string keyName, string valueName,
            T data);
    }
}