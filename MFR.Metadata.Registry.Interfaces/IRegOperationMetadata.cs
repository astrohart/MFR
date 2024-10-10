using Microsoft.Win32;

namespace MFR.Metadata.Registry.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that
    /// contains the metadata for a write operation to be performed on the
    /// system Registry.
    /// </summary>
    /// <remarks>
    /// You may ask, what is the difference between this and a Registry Query
    /// Expression object?
    /// <para />
    /// The difference is in semantics only; the two types of object have exactly the
    /// same structure in terms of methods and properties.
    /// <para />
    /// A Registry Operation Metadata object is for
    /// <i>performing an operation on the Registry</i>, whereas a
    /// <i>Registry Query Expression</i> object is for
    /// <i>searching for information or querying data from the Registry.</i>
    /// </remarks>
    public interface IRegOperationMetadata<T> where T : class
    {
        /// <summary>
        /// Gets the <see cref="T:Microsoft.Win32.RegistryHive" /> value that
        /// corresponds to the hive specified by the user, either by default or explicitly.
        /// </summary>
        RegistryHive Hive
        {
            get;
        }

        /// <summary>
        /// Gets or sets the path to the Registry key under which the desired
        /// data is stored.
        /// </summary>
        /// <remarks>
        /// This property should be set to the fully-qualified path of a key
        /// under the <c>HKEY_CURRENT_USER</c> hive. Other hives are not supported.
        /// </remarks>
        string KeyPath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the instance of <typeparamref name="T" /> that is used
        /// as the data to be written to the system Registry.
        /// </summary>
        T Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the value under which data is to be stored
        /// or from which data is to be retrieved.
        /// </summary>
        /// <remarks>
        /// Set this property to <see langword="null" /> to retrieve data from, or store
        /// data to, the (Default) value under a particular registry key.
        /// </remarks>
        string ValueName
        {
            get;
            set;
        }

        /// <summary>
        /// Assigns a value to the
        /// <see
        ///     cref="P:MFR.IRegQueryExpression.ValueName" />
        /// property.
        /// </summary>
        /// <param name="valueName">
        /// (Required.) String containing the new value for the property.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IRegOperationMetadata<T> AndValueName(string valueName);

        /// <summary>
        /// Initializes this object with the path to the Registry key you wish
        /// to access.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// If the hive ( <c>HKEY_</c>) is not included, then
        /// <c>HKEY_CURRENT_USER</c> is assumed.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="keyPath" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        IRegOperationMetadata<T> ForKeyPath(string keyPath);

        /// <summary>
        /// Assigns data to be written to the system Registry to the
        /// <see
        ///     cref="P:MFR.IRegOperationMetadata.Value" />
        /// property.
        /// </summary>
        /// <param name="value">
        /// (Required.) Instance of <typeparamref name="T" /> that contains the
        /// data to be written to the system Registry.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// Calling this method is optional.
        /// </remarks>
        IRegOperationMetadata<T> WithValue(T value);
    }
}