using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using System.Windows.Forms;

namespace MFR.GUI.Launchers.Dialogs.Params
{
    /// <summary>
    /// Common base class for all dialog-launch params.
    /// </summary>
    public abstract class DialogLaunchParamBase : IDialogLaunchParams
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:System.Windows.Forms.IWin32Window" /> interface that represents
        /// the parent window of the new dialog box.
        /// </summary>
        public IWin32Window Owner
        {
            get;
            set;
        }
    }
}