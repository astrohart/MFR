using MFR.Engines.Constants;
using MFR.Engines.Interfaces;
using MFR.Renamers.Files.Factories;
using MFR.Renamers.Files.Interfaces;
using MFR.Settings.Configuration;
using System;

namespace MFR.Engines
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all operation
    /// engines.
    /// </summary>
    public abstract class OperationEngineBase : ConfigurationComposedObjectBase,
        IOperationEngine
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface.
        /// </summary>
        /// <remarks>
        /// This object provides access to the file- and folder-processing functionality of
        /// the application.
        /// <para />
        /// It is marked as <c>protected</c> in the source code, allowing access to
        /// children of the <see cref="T:MFR.Engines.OperationEngineBase" /> class.
        /// </remarks>
        protected static IFileRenamer FileRenamer
            => GetFileRenamer.SoleInstance();

        /// <summary>
        /// Gets a <see cref="T:MFR.Engines.Constants.OperationEngineType" /> enumeration
        /// value that describes what type of operation engine this is.
        /// </summary>
        /// <remarks>
        /// Child classes must implement this property.
        /// </remarks>
        public abstract OperationEngineType Type
        {
            get;
        }

        /// <summary>
        /// Occurs when the operation engine is finished.
        /// </summary>
        public event EventHandler EngineOperationFinished;

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Engines.OperationEngineBase.EngineOperationFinished" /> event.
        /// </summary>
        protected virtual void OnEngineOperationFinished()
            => EngineOperationFinished?.Invoke(this, EventArgs.Empty);
    }
}