using MFR.Metadata.Registry.Interfaces;
using System;

namespace MFR.Metadata.Registry
{
    /// <summary>
    /// Provides metadata for querying the data stored in a value contained
    /// within a key in the Windows system Registry database.
    /// </summary>
    /// <typeparam name="T">
    /// Type of the data to be accessed.
    /// </typeparam>
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
    public class RegOperationMetadata<T> : RegMetadataBase,
        IRegOperationMetadata<T> where T : class
    {
        /// <summary>
        /// Gets or sets the instance of <typeparamref name="T" /> that is used
        /// as the data to be written to the system Registry.
        /// </summary>
        public T Value
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
        ///     cref="P:MFR.IRegOperationMetadata.ValueName" />
        /// property.
        /// </summary>
        /// <param name="valueName">
        /// (Required.) String containing the new value for the property.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public IRegOperationMetadata<T> AndValueName(string valueName)
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
        public IRegOperationMetadata<T> ForKeyPath(string keyPath)
        {
            if (string.IsNullOrWhiteSpace(keyPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(keyPath)
                );

            KeyPath = keyPath;

            return this;
        }

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
        public IRegOperationMetadata<T> WithValue(T value)
        {
            Value = value;

            return this;
        }
    }
}