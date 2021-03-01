using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Provides common functionality for all those objects that get composed
    /// with another object that implements the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
    /// interface.
    /// </summary>
    public abstract class
        ConfigurationComposedObjectBase : IConfigurationComposedObject
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ConfigurationComposedObjectBase" />
        /// and returns a reference to it.
        /// </summary>
        /// <remarks>
        /// This constructor calls the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ConfigurationComposedObjectBase.EnforceClientRequirementToCallAttachConfiguration" />
        /// method in order to enforce a fluent method call to the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IConfigurationComposedObject.AndAttachConfiguration" />
        /// method by whosoever invokes this constructor in order to finish
        /// building this object.
        /// </remarks>
        protected ConfigurationComposedObjectBase()
        {
            EnforceClientRequirementToCallAttachConfiguration();
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextExpressionMatcherBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration" /> interface
        /// that holds settings that are specified by the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        protected ConfigurationComposedObjectBase(IConfiguration configuration)
        {
            Configuration = configuration ??
                            throw new ArgumentNullException(
                                nameof(configuration)
                            );
            if (Configuration != null)
                RemoveClientRequirementToCallAttachConfiguration();
        }

        /// <summary>
        /// Gets or sets a value indicating whether this object has been
        /// properly composed with an instance of an object that implements the
        /// <see cref="T:MassFileRenamer.Objects.IConfiguration" /> interface.
        /// </summary>
        protected bool IsConfigurationAttached
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration" /> interface.
        /// </summary>
        public IConfiguration Configuration
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
        /// -implementing object controls the behavior of this text-expression
        /// matcher object by dint of the settings chosen by the user at runtime.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        public dynamic AndAttachConfiguration(IConfiguration configuration)
        {
            Configuration = configuration ??
                            throw new ArgumentNullException(
                                nameof(configuration)
                            );

            if (Configuration != null)
                RemoveClientRequirementToCallAttachConfiguration();

            return this;
        }

        /// <summary>
        /// Sets the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.ConfigurationComposedObjectBase.IsConfigurationAttached" />
        /// property to <c>false</c>.
        /// </summary>
        /// <remarks>
        /// This setting for the property ensures that the client must call the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.AndAttachConfiguration" />
        /// method prior to any match operation commencing (the operation will
        /// throw a <see cref="T:System.InvalidOperationException" /> if this is
        /// the case).
        /// </remarks>
        protected void EnforceClientRequirementToCallAttachConfiguration()

            // Enforce the calling of the AttachConfiguration fluent-builder method.
            => IsConfigurationAttached = false;

        /// <summary>
        /// Sets the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.ConfigurationComposedObjectBase.IsConfigurationAttached" />
        /// property to <c>true</c>.
        /// </summary>
        /// <remarks>
        /// This setting for the property removes the requirement that the
        /// client of this object call the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.AndAttachConfiguration" />
        /// method prior to invoking any other method of this class.
        /// </remarks>
        protected void RemoveClientRequirementToCallAttachConfiguration()
            => IsConfigurationAttached = true;
    }
}