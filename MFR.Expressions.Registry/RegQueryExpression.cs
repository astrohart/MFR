using MFR.Expressions.Registry.Interfaces;
using MFR.Metadata.Registry;
using System;

namespace MFR.Expressions.Registry
{
    /// <summary>
    /// Provides metadata for querying the data stored in a value contained
    /// within a key in the Windows system Registry database.
    /// </summary>
    /// <typeparam name="T">
    /// Type of the data to be accessed.
    /// </typeparam>
    public class RegQueryExpression<T> : RegMetadataBase, IRegQueryExpression<T>
        where T : class
    {
        /// <summary>
        /// Gets or sets <typeparamref name="T" /> that is used as the default
        /// value in case data cannot otherwise be accessed from the Registry.
        /// </summary>
        public T DefaultValue
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
        public string ValueName
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
        public IRegQueryExpression<T> AndValueName(string valueName)
        {
            // it's ok for this to be blank, but no whitespace allowed
            ValueName = valueName.Trim();

            return this;
        }

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
        public IRegQueryExpression<T> ForKeyPath(string keyPath)
        {
            if (string.IsNullOrWhiteSpace(keyPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(keyPath)
                );

            KeyPath = keyPath;

            return this;
        }

        /// <summary>
        /// Assigns a value to the
        /// <see
        ///     cref="P:MFR.IRegQueryExpression.ValueName" />
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
        /// <para />
        /// NOTE: If this method is called, then the value <see langword="null" /> is not
        /// acceptable to be passed for the <paramref name="defaultValue" /> parameter.
        /// <para />
        /// If <see langword="null" /> is passed, then this method throws
        /// <see cref="T:System.ArgumentNullException" />.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="defaultValue" />,
        /// is passed <see langword="null" />.
        /// </exception>
        public IRegQueryExpression<T> WithDefaultValue(T defaultValue)
        {
            DefaultValue = defaultValue ??
                           throw new ArgumentNullException(
                               nameof(defaultValue)
                           );

            return this;
        }
    }
}