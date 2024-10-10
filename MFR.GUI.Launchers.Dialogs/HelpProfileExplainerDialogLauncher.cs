using MFR.GUI.Dialogs.Factories;
using MFR.GUI.Dialogs.Profiles.Help.Factories;
using MFR.GUI.Launchers.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Launchers.Dialogs
{
    /// <summary>
    /// Provides helper methods to launch the explainer dialog that provides the user
    /// with Help on what Profiles are.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class
        HelpProfileExplainerDialogLauncher : IHelpProfileExplainerDialogLauncher
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static HelpProfileExplainerDialogLauncher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected HelpProfileExplainerDialogLauncher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.HelpProfileExplainerDialogLauncher" />.
        /// </summary>
        public static IHelpProfileExplainerDialogLauncher Instance
        {
            get;
        } = new HelpProfileExplainerDialogLauncher();

        /// <summary>
        /// Displays a user-friendly dialog box that assists the user with
        /// recovering from an application-specific error i.e., an
        /// otherwise-unhandled exception.
        /// </summary>
        /// <param name="owner">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Windows.Forms.IWin32Window" /> interface.
        /// This object acts as the parent window of the dialog box.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// corresponds to the means used by the user to dismiss the dialog.
        /// <para />
        /// If an error occurs, then the
        /// <see cref="T:System.Windows.Forms.DialogResult.None" /> value is returned.
        /// </returns>
        public DialogResult Launch(IWin32Window owner)
        {
            var result = DialogResult.None;

            try
            {
                using (var dialog =
                    MakeNewHelpProfileExplainerDialog.FromScratch())
                    result = owner == null
                        ? dialog.ShowDialog()
                        : dialog.ShowDialog(owner);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = DialogResult.None;
            }

            return result;
        }
    }
}