namespace MFR.Settings.Configuration.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that is
    /// composed with an instance of another object that implements the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
    /// interface.
    /// </summary>
    public interface IConfigurationComposedObject
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" /> interface.
        /// </summary>
        IProjectFileRenamerConfiguration ProjectFileRenamerConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// Associates user settings, in the form of an instance of an object
        /// that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface, with
        /// this matcher.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// The <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// -implementing projectFileRenamerConfiguration object controls the behavior of this
        /// object by dint of the settings chosen by the user at runtime.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="projectFileRenamerConfiguration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        dynamic AndAttachConfiguration(
            IProjectFileRenamerConfiguration projectFileRenamerConfiguration);

        /// <summary>
        /// Updates the <paramref name="projectFileRenamerConfiguration"/> currently being used with a new value.
        /// </summary>
        /// <param name="projectFileRenamerConfiguration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" /> interface
        /// which has the new settings.
        /// </param>
        /// <remarks>
        /// The settings in the object specified will be used for all matching
        /// from this point forward.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="projectFileRenamerConfiguration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        void UpdateConfiguration(IProjectFileRenamerConfiguration projectFileRenamerConfiguration);

        /// <summary>
        /// Verifies that projectFileRenamerConfiguration has been attached to this object.
        /// </summary>
        /// <remarks>
        /// If no projectFileRenamerConfiguration is attached to this object, then a new
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException" />
        /// exception is thrown.
        /// </remarks>
        /// <exception
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException">
        /// Thrown if no projectFileRenamerConfiguration data is attached to this object.
        /// </exception>
        void VerifyConfigurationAttached();
    }
}
