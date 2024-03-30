using MFR.Engines.Constants;
using MFR.Events.Common;
using MFR.Settings.Configuration.Interfaces;
using System;

namespace MFR.Engines.Operations.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that runs the
    /// File Renamer in a sandbox that provides either GUI or console services, say,
    /// for example.
    /// </summary>
    /// <remarks>
    /// This meant to be kind of an "adapter pattern" on the File Renamer
    /// component so that it can be more easily used in a wide variety of modes (GUI,
    /// console, automatic GUI meaning, MFR GUI is called on the command line so we
    /// don't have to display the main window, etc.).
    /// </remarks>
    public interface IOperationEngine : IConfigurationComposedObject
    {
        /// <summary>
        /// Gets a <see cref="T:MFR.Engines.Constants.OperationEngineType" /> enumeration
        /// value that describes what type of operation engine this.
        /// </summary>
        OperationEngineType Type
        {
            get;
        }

        /// <summary>
        /// Occurs when an exception is thrown during a file operation.
        /// </summary>
        event ExceptionRaisedEventHandler ProcessingError;

        /// <summary>
        /// Occurs when the operation engine is finished.
        /// </summary>
        event EventHandler ProcessingFinished;

        /// <summary>
        /// Occurs when the processing has been started.
        /// </summary>
        event EventHandler ProcessingStarted;

        /// <summary>
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname specified by the <paramref name="rootDirectoryPath" /> parameter.
        /// </summary>
        /// <param name="rootDirectoryPath">
        /// Path to the recursion root.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        void ProcessAll(string rootDirectoryPath, string findWhat,
            string replaceWith, Predicate<string> pathFilter = null);
    }
}