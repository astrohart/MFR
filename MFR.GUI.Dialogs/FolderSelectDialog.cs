using MFR.Common;
using MFR.GUI.Dialogs.Interfaces;
using MFR.GUI.Dialogs.Properties;
using MFR.GUI.Windows.Wrappers.Factories;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Dialogs
{
    /// <summary>
    /// Wraps System.Windows.Forms.OpenFileDialog to make it present a
    /// vista-style Folder Select dialog.
    /// </summary>
    public class FolderSelectDialog : IFolderSelectDialog
    {
        private OpenFileDialog _ofd;

        /// <summary>
        /// Constructs an instance of <see cref="T:MFR.GUI.Dialogs.FolderSelectDialog" />
        /// and returns a
        /// reference to the new instance.
        /// </summary>
        public FolderSelectDialog()
        {
            _ofd = new OpenFileDialog {
                Filter = Resources.FolderSelectDialogFilters,
                AddExtension = false,
                CheckFileExists = false,
                DereferenceLinks = true,
                Multiselect = false
            };
        }

        /// <summary>
        /// Gets the selected folder
        /// </summary>
        public string FileName
            => _ofd.FileName;

        /// <summary>
        /// Gets/Sets the initial folder to be selected. A null value selects
        /// the current directory.
        /// </summary>
        public string InitialDirectory
        {
            get => _ofd.InitialDirectory;
            set
                => _ofd.InitialDirectory = string.IsNullOrEmpty(value)
                    ? Environment.CurrentDirectory
                    : value;
        }

        /// <summary>
        /// Gets/Sets the title to show in the dialog
        /// </summary>
        public string Title
        {
            get => _ofd.Title;
            set => _ofd.Title = value ?? "Select a folder";
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing,
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>
        /// 2
        /// </filterpriority>
        public void Dispose()
        {
            if (_ofd == null)
                return;

            _ofd.Dispose();
            _ofd = null;
        }

        /// <summary>
        /// Shows the form as a modal dialog box.
        /// </summary>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.DialogResult" /> values.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        /// The form being shown is already visible.
        /// -or- The form being shown is disabled.
        /// -or- The form being shown is not a top-level window.
        /// -or- The form being shown as a dialog box is already a modal form.
        /// -or- The current process is not running in user interactive mode (for
        /// more information, see
        /// <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" />).
        /// </exception>
        public DialogResult ShowDialog()
            => InternalShowDialog() ? DialogResult.OK : DialogResult.Cancel;

        /// <summary>
        /// Shows the form as a modal dialog box with the specified owner.
        /// </summary>
        /// <param name="owner">
        /// Any object that implements
        /// <see
        ///     cref="T:System.Windows.Forms.IWin32Window" />
        /// that represents the
        /// top-level window that will own the modal dialog box.
        /// </param>
        /// <returns>
        /// One of the <see cref="T:System.Windows.Forms.DialogResult" /> values.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// The form specified in the <paramref name="owner" /> parameter is the same
        /// as the form being shown.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// The form being shown is already visible.
        /// -or- The form being shown is disabled.
        /// -or- The form being shown is not a top-level window.
        /// -or- The form being shown as a dialog box is already a modal form.
        /// -or- The current process is not running in user interactive mode (for
        /// more information, see
        /// <see cref="P:System.Windows.Forms.SystemInformation.UserInteractive" />).
        /// </exception>
        public DialogResult ShowDialog(IWin32Window owner)
            => InternalShowDialog(owner.Handle)
                ? DialogResult.OK
                : DialogResult.Cancel;

        /// <summary>
        /// Shows the dialog.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the user presses OK else <see langword="false" />.
        /// </returns>
        private bool InternalShowDialog()
            => InternalShowDialog(IntPtr.Zero);

        /// <summary>
        /// Shows this <see cref="T:MFR.GUI.Dialogs.FolderSelectDialog" /> to the user to
        /// allow
        /// the user to select a folder on their computer. Returns a value
        /// indicating whether the dialog ended with the OK or Cancel button
        /// being clicked.
        /// </summary>
        /// <param name="hWndOwner">
        /// Handle of the control to be parent
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the user presses OK else <see langword="false" />.
        /// </returns>
        private bool InternalShowDialog(IntPtr hWndOwner)
        {
            var flag = false;

            try
            {
                if (_ofd == null)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "FolderSelectDialog.InternalShowDialog: The _ofd variable is set to a null reference."
                    );
                    return false;
                }

                if (Environment.OSVersion.Version.Major >= 6)
                {
                    var formType = typeof(Form);
                    if (formType == null) return flag;

                    var r = new Reflector(formType.Assembly.FullName, formType.Namespace);
                    if (r == null)
                    {
                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            "FolderSelectDialog.InternalShowDialog: The 'r' variable is set to a null reference."
                        );
                        return flag;
                    }

                    uint num = 0;
                    var typeIFileDialog = r.GetType("FileDialogNative.IFileDialog");
                    if (typeIFileDialog == null)
                    {
                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            "FolderSelectDialog.InternalShowDialog: The typeIFileDialog variable is set to a null reference."
                        );
                        return flag;
                    }

                    var dialog = Reflector.Call(_ofd, "CreateVistaDialog");
                    if (dialog == null)
                    {
                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            "FolderSelectDialog.InternalShowDialog: The 'dialog' variable is set to a null reference."
                        );

                        return flag;
                    }

                    Reflector.Call(_ofd, "OnBeforeVistaDialog", dialog);

                    var options = (uint)Reflector.CallAs(
                        typeof(FileDialog), _ofd, "GetOptions"
                    );
                    options |= (uint)r.GetEnum(
                        "FileDialogNative.FOS", "FOS_PICKFOLDERS"
                    );
                    Reflector.CallAs(
                        typeIFileDialog, dialog, "SetOptions", options
                    );

                    var pfde = r.New("FileDialog.VistaDialogEvents", _ofd);
                    if (pfde == null)
                    {
                        DebugUtils.WriteLine(
                            DebugLevel.Error,
                            "FolderSelectDialog.InternalShowDialog: The 'pfde' variable could not be initialized."
                        );
                        return flag;
                    }

                    var parameters = new[] { pfde, num };
                    Reflector.CallAs2(
                        typeIFileDialog, dialog, "Advise", parameters
                    );
                    num = (uint)parameters[1];
                    try
                    {
                        var num2 = (int)Reflector.CallAs(
                            typeIFileDialog, dialog, "Show", hWndOwner
                        );
                        flag = 0 == num2;
                    }
                    finally
                    {
                        Reflector.CallAs(typeIFileDialog, dialog, "Unadvise", num);
                        GC.KeepAlive(pfde);
                    }
                }
                else
                {
                    if (!ShowOldStyleFolderBrowserDialog(hWndOwner, ref flag))
                        return false;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
                
                // If an exception occurs trying to display the new Folder Select dialog box,
                // then use the old-style version instead.
                if (!ShowOldStyleFolderBrowserDialog(hWndOwner, ref flag))
                    return false;
            }

            return flag;
        }

        private bool ShowOldStyleFolderBrowserDialog(IntPtr hWndOwner,
            ref bool flag)
        {
            var fbd = new FolderBrowserDialog {
                Description = Title,
                SelectedPath = InitialDirectory,
                ShowNewFolderButton = false
            };
            if (fbd.ShowDialog(
                    MakeNewWindowWrapper.FromScratch()
                                        .ForWindowHandle(hWndOwner)
                ) != DialogResult.OK)
            {
                flag = false;
                return false;
            }

            _ofd.FileName = fbd.SelectedPath;
            flag = true;
            return true;
        }
    }
}