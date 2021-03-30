namespace MFR.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that is
    /// composed with an instance of another object that implements the
    /// <see
    ///     cref="T:MFR.Objects.IConfiguration" />
    /// interface.
    /// </summary>
    public interface IConfigurationComposedObject
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.IConfiguration" /> interface.
        /// </summary>
        IConfiguration Configuration
        {
            get;
            set;
        }

        /// <summary>
        /// Associates user settings, in the form of an instance of an object
        /// that implements the
        /// <see
        ///     cref="T:MFR.Objects.IConfiguration" />
        /// interface, with
        /// this matcher.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// The <see cref="T:MFR.Objects.IConfiguration" />
        /// -implementing configuration object controls the behavior of this
        /// text-expression matcher object by dint of the settings chosen by the
        /// user at runtime.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        dynamic AndAttachConfiguration(
            IConfiguration configuration);

        /// <summary>
        /// Updates the configuration currently being used with a new value.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.IConfiguration" /> interface
        /// which has the new settings.
        /// </param>
        /// <remarks>
        /// The settings in the object specified will be used for all matching
        /// from this point forward.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        void UpdateConfiguration(IConfiguration configuration);

        /// <summary>
        /// Verifies that configuration has been attached to this object.
        /// </summary>
        /// <remarks>
        /// If no configuration is attached to this object, then a new
        /// <see
        ///     cref="T:MFR.Objects.ConfigurationNotAttachedException" />
        /// exception is thrown.
        /// </remarks>
        /// <exception
        ///     cref="T:MFR.Objects.ConfigurationNotAttachedException">
        /// Thrown if no configuration data is attached to this object.
        /// </exception>
        void VerifyConfigurationAttached();
    }
}