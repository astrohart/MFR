namespace MFR.Profiles.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// needs to access a profile provider.
    /// <para />
    /// The object implements the
    /// <see
    ///     cref="T:MFR.Profiles.Providers.Interfaces.IProfileProvider" />
    /// interface.
    /// <para />
    /// Objects that implement this interface gain the capability of being
    /// associated with a dependency that allows access to profiles.
    /// <para />
    /// In this software system, a "profile" is basically a set of provider
    /// settings, that may or may not be what are currently being used, and
    /// which have a label.
    /// <para />
    /// Profiles allow for hot swapping the provider at runtime.
    /// </summary>
    public interface IProfileProviderComposedObject
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        IProfileProvider ProfileProvider
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
        /// </param>
        /// <returns>
        /// </returns>
        dynamic AndAttachProfileProvider(IProfileProvider profileProvider);

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
        void UpdateProfileProvider(IProfileProvider profileProvider);

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
        void VerifyProfileProviderAttached();
    }
}