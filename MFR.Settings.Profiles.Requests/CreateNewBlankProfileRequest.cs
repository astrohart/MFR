using MFR.Messages.Constants;
using MFR.Messages.Requests;
using MFR.Settings.Profiles.Factories;
using MFR.Settings.Profiles.Interfaces;
using MFR.Settings.Profiles.Requests.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Settings.Profiles.Requests
{
    /// <summary>
    /// Carries out requests to create new, blank <c>Profile</c> objects.
    /// <para />
    /// The objects thus created have no name associated with them.
    /// <para />
    /// To create a new, blank profile and associate a name at the same time, call the
    /// <see cref="T:MFR.Settings.Profiles.Actions.CreateNewNamedProfileAction" />
    /// class.
    /// </summary>
    public class CreateNewBlankProfileRequest : RequestBase<IProfile>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CreateNewBlankProfileRequest() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CreateNewBlankProfileRequest() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Settings.Profiles.Requests.CreateNewBlankProfileRequest" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static CreateNewBlankProfileRequest Instance
        {
            get;
        } = new CreateNewBlankProfileRequest();

        /// <summary>
        /// Gets the
        /// <see
        ///     cref="T:MFR.MessageType" />
        /// that is
        /// being used to identify which message this.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => ProfileCollectionRequestType.CreateNewBlankProfile;

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface
        /// representing the new, blank profile that has been created.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// </remarks>
        protected override IProfile CommonExecute()
            => MakeNewProfile.FromScratch();
    }
}
