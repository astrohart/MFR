using MFR.GUI.Dialogs.Factories;
using MFR.GUI.Launchers.Dialogs.Interfaces;
using MFR.GUI.Launchers.Dialogs.Params.Interfaces;
using MFR.GUI.Launchers.Dialogs.Results.Factories;
using MFR.GUI.Launchers.Dialogs.Results.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.GUI.Launchers.Dialogs
{
    /// <summary>
    /// Provides helper methods to launch the explainer dialog that provides the user
    /// with Help on what Profiles are.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ProfileNameDialogLauncher : IProfileNameDialogLauncher
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ProfileNameDialogLauncher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ProfileNameDialogLauncher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GUI.Launchers.Dialogs.ProfileNameDialogLauncher" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static ProfileNameDialogLauncher Instance
        {
            get;
        } = new ProfileNameDialogLauncher();

        /// <summary>
        /// Displays a user-friendly dialog box that assists the user with selecting a new
        /// name for a new or existing profile.
        /// </summary>
        /// <param name="parms">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Params.Interfaces.IProfileNameDialogLaunchParams" />
        /// interface.
        /// <para />
        /// This object contains the input parameter variables for the Profile Name dialog
        /// box.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.GUI.Launchers.Dialogs.Results.Interfaces.IProfileNameDialogLaunchResults" />
        /// interface.
        /// <para />
        /// This object's properties' values contain the values chosen by the user,
        /// including the <see cref="T:System.Windows.Forms.DialogResult" /> value that
        /// corresponds to the button the user clicked in order to dismiss the dialog box.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="parms" />, is passed a <see langword="null" />
        /// value.
        /// </exception>
        public IProfileNameDialogLaunchResults Launch(
            IProfileNameDialogLaunchParams parms)
        {
            if (parms == null) throw new ArgumentNullException(nameof(parms));

            IProfileNameDialogLaunchResults launchResult;

            using (var dialogBox = MakeNewProfileNameDialog.FromScratch()
                .ForProfileCreateOperationType(parms.OperationType))
            {
                var dialogResult = parms.Owner == null
                    ? dialogBox.ShowDialog()
                    : dialogBox.ShowDialog(parms.Owner);

                launchResult =
                    MakeNewProfileNameDialogResults.WithPropertyValues(
                        dialogBox.ProfileName, dialogBox.OperationType,
                        dialogResult
                    );
            }

            return launchResult;
        }
    }
}