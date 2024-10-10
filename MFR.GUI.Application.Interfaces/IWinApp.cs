using MFR.CommandLine.Models.Interfaces;
using System;

namespace MFR.GUI.Application.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an application object.
    /// </summary>
    public interface IWinApp
    {
        /// <summary>
        /// A <see cref="T:System.Guid" /> that uniquely identifies this product.
        /// </summary>
        Guid AppId
        {
            get;
        }

        /// <summary>
        /// Gets a value indicating whether the application should automatically process
        /// operations requested by the user from the command line.
        /// </summary>
        bool AutoStart
        {
            get;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface.
        /// </summary>
        ICommandLineInfo CommandLineInfo
        {
            get;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the user specified any arguments on
        /// this application's command line at startup or not.
        /// </summary>
        bool CommandLineSpecified
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when the application has been initialized, but has not yet processed the
        /// command line.
        /// </summary>
        event EventHandler Initialized;

        /// <summary>
        /// Called to instruct the application to begin processing.
        /// </summary>
        /// <param name="args">
        /// (Required.) An array of <see cref="T:System.String" />
        /// values, each of which corresponds to a value that was passed by the user on the
        /// application's command line.
        /// </param>
        void WinInit(string[] args);
    }
}