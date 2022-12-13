using MFR.Engines.Constants;
using MFR.Engines.Interfaces;
using MFR.Engines.Properties;
using MFR.GUI.Dialogs.Factories;
using MFR.GUI.Dialogs.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;

namespace MFR.Engines
{
    /// <summary>
    /// Coordinates the operation of the <c>File Renamer</c> component inadmidst the
    /// full graphical user interface of the application.
    /// </summary>
    public class FullGuiOperationEngine : OperationEngineBase,
        IFullGuiOperationEngine
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog" />
        /// interface.
        /// </summary>
        private ICancellableProgressDialog _cancellableProgressDialog;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static FullGuiOperationEngine() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected FullGuiOperationEngine()
        {
            ReinitializeProgressDialog(); // reinitialize the progress dialog to a "clean" state
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user projectFileRenamerConfiguration and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IConfigurationProvider ConfigurationProvider
            => GetConfigurationProvider.SoleInstance();


        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Engines.Interfaces.IFullGuiOperationEngine" /> interface.
        /// </summary>
        public static IFullGuiOperationEngine Instance
        {
            get;
        } = new FullGuiOperationEngine();

        /// <summary>
        /// Gets a <see cref="T:MFR.Engines.Constants.OperationEngineType" /> enumeration
        /// value that describes what type of operation engine this is.
        /// </summary>
        /// <remarks>
        /// Child classes must implement this property.
        /// </remarks>
        public override OperationEngineType Type
            => OperationEngineType.FullGUI;

        /// <summary>
        /// Dismisses the progress dialog.
        /// </summary>
        public void CloseProgressDialog()
            => _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Close()
            );

        /// <summary>
        /// Shows a marquee progress bar that indicates the application is
        /// performing work but of an indeterminate length, such as calculating
        /// the amount of files to process.
        /// </summary>
        /// ///
        /// <param name="text">
        /// (Required.) String containing the text to display in the progress dialog.
        /// </param>
        /// <param name="canCancel">
        /// (Required.) <see langword="true" /> to show a <strong>Cancel</strong> button in
        /// the progress dialog; <see langword="false" /> to hide it.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="text" />, is passed
        /// a blank or <see langword="null" /> string for a value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public void ShowCalculatingProgressBar(string text,
            bool canCancel = true)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(text)
                );
            ResetProgressBar();

            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.ProgressBarStyle =
                    ProgressBarStyle.Marquee
            );
            _cancellableProgressDialog.DoIfNotDisposed(
                () => _cancellableProgressDialog.Status = text
            );
        }

        /// <summary>
        /// Handles the <see cref="E:MFR.GUI.ICancellableProgressDialog.CancelRequested" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event data.
        /// </param>
        /// <remarks>
        /// This method handles the situation in which the user has clicked the
        /// Cancel button on the progress dialog. The message taken by this
        /// method is to tell the File Renamer Object to attempt to abort.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private static void OnCancellableProgressDialogRequestedCancel(object sender,
                EventArgs e)

            // Ask the File Renamer component to stop.  Because the user has
            // clicked the Cancel button in the progress dialog.
            => FileRenamer.RequestAbort();

        /// <summary>
        /// Sets the progress dialog and/or reinitializes it from prior use.
        /// </summary>
        [Log(AttributeExclude = true)]
        private void ReinitializeProgressDialog()
        {
            _cancellableProgressDialog.DoIfNotDisposed(
                () =>
                {
                    if (_cancellableProgressDialog != null)
                    {
                        _cancellableProgressDialog.Close();
                        _cancellableProgressDialog.Dispose();
                    }

                    _cancellableProgressDialog = null;
                }
            );
            _cancellableProgressDialog.DoIfDisposed(
                () => _cancellableProgressDialog =
                    MakeNewProgressDialog.FromScratch()
            );

            _cancellableProgressDialog.CancelRequested -=
                OnCancellableProgressDialogRequestedCancel;
            _cancellableProgressDialog.CancelRequested +=
                OnCancellableProgressDialogRequestedCancel;
        }

        /// <summary>
        /// Resets the progress bar back to the beginning.
        /// </summary>
        [Log(AttributeExclude = true)]
        private void ResetProgressBar()
            => _cancellableProgressDialog.DoIfNotDisposed(
                _cancellableProgressDialog.Reset
            );
    }
}