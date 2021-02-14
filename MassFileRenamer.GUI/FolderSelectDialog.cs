using MassFileRenamer.GUI.Properties;
using MassFileRenamer.Objects;
using System;
using System.Windows.Forms;

namespace MassFileRenamer.GUI
{
    /// <summary>
    /// Wraps System.Windows.Forms.OpenFileDialog to make it present a vista-style Folder Select dialog.
    /// </summary>
    public class FolderSelectDialog : IDisposable
    {
        // Wrapped dialog
        private OpenFileDialog _ofd;

        ///<summary>
        /// Constructs an instance of <see cref="T:FolderSelectDialog"/> and returns a reference to the new instance.
        ///</summary>
        public FolderSelectDialog()
        {
            _ofd = new OpenFileDialog
            {
                Filter = Resources.FolderSelectDialogFIlters,
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
        {
            get { return _ofd.FileName; }
        }

        /// <summary>
        /// Gets/Sets the initial folder to be selected. A null value selects the current directory.
        /// </summary>
        public string InitialDirectory
        {
            get { return _ofd.InitialDirectory; }
            set { _ofd.InitialDirectory = string.IsNullOrEmpty(value) ? Environment.CurrentDirectory : value; }
        }

        /// <summary>
        /// Gets/Sets the title to show in the dialog
        /// </summary>
        public string Title
        {
            get { return _ofd.Title; }
            set { _ofd.Title = value ?? "Select a folder"; }
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            if (_ofd != null)
            {
                _ofd.Dispose();
                _ofd = null;
            }
        }

        /// <summary>
        /// Shows the dialog
        /// </summary>
        /// <returns>True if the user presses OK else false</returns>
        public bool ShowDialog()
        {
            return ShowDialog(IntPtr.Zero);
        }

        /// <summary>
        /// Shows this <see cref="T:FolderSelectDialog"/> to the user to allow the user to select a folder on their 
        /// computer.  Returns a value indicating whether the dialog ended with the OK or Cancel button being clicked.
        /// </summary>
        /// <param name="hWndOwner">Handle of the control to be parent</param>
        /// <returns>True if the user presses OK else false</returns>
        public bool ShowDialog(IntPtr hWndOwner)
        {
            var flag = false;

            if (Environment.OSVersion.Version.Major >= 6)
            {
                var r = new Reflector("System.Windows.Forms");

                uint num = 0;
                var typeIFileDialog = r.GetType("FileDialogNative.IFileDialog");
                var dialog = Reflector.Call(_ofd, "CreateVistaDialog");
                Reflector.Call(_ofd, "OnBeforeVistaDialog", dialog);

                var options = (uint)Reflector.CallAs(typeof(FileDialog), _ofd, "GetOptions");
                options |= (uint)r.GetEnum("FileDialogNative.FOS", "FOS_PICKFOLDERS");
                Reflector.CallAs(typeIFileDialog, dialog, "SetOptions", options);

                var pfde = r.New("FileDialog.VistaDialogEvents", _ofd);
                var parameters = new[] { pfde, num };
                Reflector.CallAs2(typeIFileDialog, dialog, "Advise", parameters);
                num = (uint)parameters[1];
                try
                {
                    var num2 = (int)Reflector.CallAs(typeIFileDialog, dialog, "Show", hWndOwner);
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
                var fbd = new FolderBrowserDialog
                {
                    Description = Title,
                    SelectedPath = InitialDirectory,
                    ShowNewFolderButton = false
                };
                if (fbd.ShowDialog(new WindowWrapper(hWndOwner)) != DialogResult.OK)
                {
                    return false;
                }
                _ofd.FileName = fbd.SelectedPath;
                flag = true;
            }

            return flag;
        }
    }
}