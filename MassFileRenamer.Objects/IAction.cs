﻿namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of a command object
    /// that performs an message with regards to the application's configuration.
    /// </summary>
    /// <remarks>
    /// The messages that can be performed on the application's configuration are:
    /// <list type="bullet">
    /// <item>
    /// <term>Load Path from Registry</term>
    /// <description>
    /// Load the path to the application configuration file from the system Registry.
    /// </description>
    /// </item>
    /// <item>
    /// <term>Save Path to Registry</term>
    /// <description>
    /// Save the path to the configuration file to the system Registry.
    /// </description>
    /// </item>
    /// <item>
    /// <term>Load from Configuration File</term>
    /// <description>Loads configuration from a file on the disk.</description>
    /// </item>
    /// <item>
    /// <term>Save to Configuration File</term>
    /// <description>Saves configuration to a file on the disk.</description>
    /// </item>
    /// <item>
    /// <term>Import Configuration from File</term>
    /// <description>
    /// Imports configuration settings from a file on the disk.
    /// </description>
    /// </item>
    /// <item>
    /// <term>Export Configuration from File</term>
    /// <description>
    /// Imports configuration settings from a file that isn't the file whose
    /// path is stored in the system Registry.
    /// </description>
    /// </item>
    /// <item>
    /// <term>Reset to Default</term>
    /// <description>
    /// Resets all the user's configuration settings to their default values.
    /// </description>
    /// </item>
    /// ///
    /// </list>
    /// </remarks>
    /// <typeparam name="TInput">
    /// Name of the class or data type that contains information used to execute
    /// the message.
    /// <para />
    /// This object is composed with the message object at runtime.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// Name of the class or data type that will carry user state information
    /// about the results of the operation.
    /// </typeparam>
    public interface
        IAction<TInput, TResult> : IRequest<TResult>
        where TInput : class where TResult : class
    {
        /// <summary>
        /// Composes this object's <paramref name="input" /> with it.
        /// </summary>
        /// <param name="input">
        /// (Required.) Reference to an instance of
        /// <typeparamref
        ///     name="TInput" />
        /// that contains data to be provided to the message.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IAction<TInput, TResult> WithInput(TInput input);
    }
}