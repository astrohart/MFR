using MFR.Params.Profiles.Interfaces;

namespace MFR.Params.Profiles
{
    /// <summary>
    /// Defines properties that encapsulate information about a <c>Profile</c> object
    /// to be used when initiating requests, e.g., to create profiles etc.
    /// </summary>
    public class ProfileParams : IProfileParams
    {
        /// <summary>
        /// Gets or sets a string that contains the name of the <c>Profile</c>.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
    }
}