using Microsoft.Win32;

namespace MFR.Expressions.Registry.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that
    /// contains the metadata for a query of a value in the system Registry.
    /// </summary>
    public interface IRegQueryExpression<T> where T : class
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
        ///     cref="P:MFR.Expressions.Registry.Interfaces.IRegQueryExpression.ValueName" />
        /// property.
        /// </summary>
        /// <param name="valueName">
        /// (Required.) String containing the new value for the property.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IRegQueryExpression<T> AndValueName(string valueName);

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
        IRegQueryExpression<T> ForKeyPath(string keyPath);

        /// <summary>
        /// Gets or sets <typeparamref name="T" /> that is used as the default
        /// value in case data cannot otherwise be accessed from the Registry.
        /// </summary>
        T DefaultValue
        {
            get;
            set;
        }

        /// <summary>
        /// Assigns a value to the
        /// <see
        ///     cref="P:MFR.Expressions.Registry.Interfaces.IRegQueryExpression.ValueName" />
        /// property.
        /// </summary>
        /// <param name="defaultValue">
        /// (Required.) Instance of <typeparamref name="T" /> that should serve
        /// as the default value to be returned in case no data is found.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// Calling this method is optional.
        /// </remarks>
        IRegQueryExpression<T> WithDefaultValue(T defaultValue);
    }
}