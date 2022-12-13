using MFR.Engines.Constants;
using MFR.Settings.Configuration.Interfaces;
using System;

namespace MFR.Engines.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that runs the
    /// File Renamer in a sandbox that provides either GUI or console services, say,
    /// for example.
    /// </summary>
    /// <remarks>
    /// This is meant to be kind of an "adapter pattern" on the File Renamer
    /// component so that it can be more easily used in a wide variety of modes (GUI,
    /// console, automatic GUI meaning, MFR GUI is called on the command line so we
    /// don't have to display the main window, etc.).
    /// </remarks>
    public interface IOperationEngine : IConfigurationComposedObject
    {
        /// <summary>
        /// Occurs when the operation engine is finished.
        /// </summary>
        event EventHandler EngineOperationFinished;

        /// <summary>
        /// Gets a <see cref="T:MFR.Engines.Constants.OperationEngineType" /> enumeration
        /// value that describes what type of operation engine this is.
        /// </summary>
        OperationEngineType Type
        {
            get;
        }
    }
}