namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that is
    /// composed with an instance of another object that implements the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
    /// interface.
    /// </summary>
    public interface IConfigurationComposedObject
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration" /> interface.
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
        ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// interface, with
        /// this matcher.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// The <see cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// -implementing configuration object controls the behavior of this
        /// text-expression matcher object by dint of the settings chosen by the
        /// user at runtime.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        dynamic AndAttachConfiguration(IConfiguration configuration);
    }
}