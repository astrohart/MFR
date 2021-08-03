using MFR.Profiles.Providers.Exceptions;
using MFR.Profiles.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Profiles.Providers
{
    /// <summary>
    /// Provides common functionality for all those objects that get composed
    /// with another object that implements the
    /// <see
    ///     cref="T:MFR.Objects.IConfiguration" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class
        ProfileProviderComposedObjectBase : IProfileProviderComposedObject
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        public IProfileProvider ProfileProvider
        {
            get;
            set;
        }

        /// <summary>
        /// Associates an object that implements the
        /// <see
        ///     cref="T:MFR.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface with this object.
        /// <para />
        /// This provides access to the
        /// </summary>
        /// <param name="profileProvider">
        /// (Required.) Reference to an instance of an object that implements the <see cref="T:MFR.Profiles.Providers.Interfaces.IProfileProvider" /> interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public dynamic AndAttachProfileProvider(
            IProfileProvider profileProvider)
        {
            ProfileProvider = profileProvider ??
                              throw new ArgumentNullException(
                                  nameof(profileProvider)
                              );

            return this;
        }

        /// <summary>
        /// Updates the profile provider object currently being used with a new value.
        /// </summary>
        /// <param name="profileProvider">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface which has the new settings.
        /// </param>
        /// <remarks>
        /// The settings in the object specified will be used for all matching
        /// from this point forward.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="profileProvider" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        public void UpdateProfileProvider(IProfileProvider profileProvider)
            => ProfileProvider = profileProvider ??
                                 throw new ArgumentNullException(
                                     nameof(profileProvider)
                                 );

        /// <summary>
        /// Gets or sets a value indicating whether this object has been
        /// properly composed with an instance of an object that implements the
        /// <see cref="T:MFR.Profiles.Providers.Interfaces.IProfileProvider" /> interface.
        /// </summary>
        protected bool IsProfileProviderAttached
            => ProfileProvider != null;

        /// <summary>
        /// Verifies that a profile provider object has been attached to this object.
        /// </summary>
        /// <remarks>
        /// If no profile provider object is attached to this object, then a
        /// <see
        ///     cref="T:MFR.Profiles.Providers.Exceptions.ProfileProviderNotAttachedException" />
        /// exception
        /// is thrown.
        /// </remarks>
        /// <exception cref="T:MFR.Profiles.Providers.Exceptions.ProfileProviderNotAttachedException">
        /// Thrown if no provider data is attached to this object.
        /// </exception>
        public void VerifyProfileProviderAttached()
        {
            if (IsProfileProviderAttached)
                return;
            throw new ProfileProviderNotAttachedException();
        }
    }
}