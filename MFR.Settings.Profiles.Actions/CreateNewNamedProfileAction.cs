using MFR.Expressions.Registry.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions;
using MFR.Messages.Actions.Interfaces;
using MFR.Messages.Constants;
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Factories;
using MFR.Settings.Profiles.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Settings.Profiles.Actions
{
    /// <summary>
    /// Creates a new, blank <c>Profile</c> object and assigns the name specified in
    /// this <c>Action</c>'s input to it.
    /// <para />
    /// To create a new profile with no name assigned, use the
    /// <see cref="T:MFR.Settings.Profiles.Requests.CreateNewBlankProfileRequest" />
    /// class.
    /// </summary>
    public class CreateNewNamedProfileAction : ActionBase<string, IProfile>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CreateNewNamedProfileAction() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CreateNewNamedProfileAction() { }

        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:MFR.MessageType" />
        /// that is
        /// being used to identify which message this.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => ProfileCollectionActionType.CreateNewNamedProfile;

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IAction<string, IProfile> Instance
        {
            get;
        } = new CreateNewNamedProfileAction();

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface and which
        /// represents a <c>Profile</c> object having the name passed as input to this
        /// <c>Action</c>.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// </remarks>
        protected override IProfile CommonExecute()
        {
            if (string.IsNullOrWhiteSpace(Input))
                throw new InvalidOperationException(
                    "The new profile must have a name."
                );

            return MakeNewProfile.FromScratch()
                                 .HavingName(Input);
        }
    }
}