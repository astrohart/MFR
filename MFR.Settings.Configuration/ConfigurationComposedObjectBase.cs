using MFR.Settings.Configuration.Exceptions;
using MFR.Settings.Configuration.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Configuration
{
    /// <summary>
    /// Provides common functionality for all those objects that get composed
    /// with another object that implements the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class
        ConfigurationComposedObjectBase : IConfigurationComposedObject
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.ConfigurationComposedObjectBase" />
        /// and returns a reference to it.
        /// </summary>
        protected ConfigurationComposedObjectBase()
        {
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.TextExpressionMatchingEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" /> interface
        /// that holds settings that are specified by the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        protected ConfigurationComposedObjectBase(IConfiguration configuration)
        {
            Configuration = configuration ??
                            throw new ArgumentNullException(
                                nameof(configuration)
                            );
        }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" /> interface.
        /// </summary>
        /// <remarks>
        /// This object's properties give us access to the settings configured
        /// by the user of the application.
        /// </remarks>
        public IConfiguration Configuration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this object has been
        /// properly composed with an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" /> interface.
        /// </summary>
        protected bool IsConfigurationAttached
            => Configuration != null;

        /// <summary>
        /// Associates user settings, in the form of an instance of an object
        /// that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
        /// interface, with
        /// this matcher.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// The <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
        /// -implementing configuration object controls the behavior of this
        /// object by dint of the settings chosen by the user at runtime.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        public dynamic AndAttachConfiguration(IConfiguration configuration)
        {
            Configuration = configuration ??
                            throw new ArgumentNullException(
                                nameof(configuration)
                            );

            return this;
        }

        /// <summary>
        /// Updates the configuration currently being used with a new value.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" /> interface
        /// which has the new settings.
        /// </param>
        /// <remarks>
        /// The settings in the object specified will be used for all matching
        /// from this point forward.
        /// <para />
        /// NOTE:This member may be overriden by a child class. If this is the
        /// case, the overrider must call the base class method before doing any
        /// of its own processing.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        public virtual void UpdateConfiguration(IConfiguration configuration)
            => Configuration = configuration ??
                               throw new ArgumentNullException(
                                   nameof(configuration)
                               );

        /// <summary>
        /// Verifies that configuration has been attached to this object.
        /// </summary>
        /// <remarks>
        /// If no configuration is attached to this object, then
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException" />
        /// is thrown.
        /// <para />
        /// <strong>NOTE:</strong> Child classes may override this method, e.g., to make
        /// attaching a configuration object optional.
        /// </remarks>
        /// <exception
        ///     cref="T:MFR.Settings.Configuration.Exceptions.ConfigurationNotAttachedException">
        /// Thrown if no configuration data is attached to this object.
        /// </exception>
        public virtual void VerifyConfigurationAttached()
        {
            if (IsConfigurationAttached)
                return;
            throw new ConfigurationNotAttachedException();
        }
    }
}