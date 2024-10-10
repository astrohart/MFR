using MFR.Metadata.Registry.Interfaces;
using MFR.Metadata.Registry.Validators.Interfaces;
using MFR.Metadata.Registry.Validators.Properties;
using MFR.Registry.Helpers;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Metadata.Registry.Validators
{
    /// <summary>
    /// Validates the data in the properties of instances of objects that
    /// implement the
    /// <see
    ///     cref="T:MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{T}" />
    /// interface.
    /// </summary>
    /// <typeparam name="T">
    /// Name of the type of data that is being fetched from, or written to, the
    /// system Registry.
    /// </typeparam>
    public class
        RegOperationMetadataValidator<T> : IRegOperationMetadataValidator<T>
        where T : class
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RegOperationMetadataValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RegOperationMetadataValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.RegOperationMetadataValidator" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IRegOperationMetadataValidator<T> Instance
        {
            get;
        } = new RegOperationMetadataValidator<T>();

        /// <summary>
        /// Gets the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.IRegOperationMetadata" />
        /// interface that is being validated.
        /// </summary>
        [Log(AttributeExclude = true)]
        public IRegOperationMetadata<T> Metadata
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes the value of the
        /// <see
        ///     cref="P:MFR.IRegOperationMetadataValidator.Metadata" />
        /// property to refer to the data that is to be validated.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public IRegOperationMetadataValidator<T> ForRegOperationMetadata(
            IRegOperationMetadata<T> expression
        )
        {
            Metadata = expression ??
                       throw new ArgumentNullException(nameof(expression));

            return this;
        }

        /// <summary>
        /// Validates the data.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the value of the
        /// <see
        ///     cref="P:MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator{T}.Metadata" />
        /// property is valid; <see langword="false" /> otherwise.
        /// </returns>
        public bool Validate()
        {
            var result = true;

            try
            {
                if (Metadata == null)
                    throw new InvalidOperationException(
                        Resources.Error_MetadataPropertyIsNull
                    );

                if (string.IsNullOrWhiteSpace(Metadata.KeyPath))
                    throw new InvalidOperationException(
                        Resources.Error_RegistryKeyPathnameBlank
                    );

                if (!Metadata.KeyPath.StartsWithValidHiveName())
                    throw new InvalidOperationException(
                        Resources
                            .Error_RegistryKeyPathnameDoesNotStartWithValidHive
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            /*
             * OKAY, if we are here, then our validation rules have been passed.
             */

            return result;
        }
    }
}