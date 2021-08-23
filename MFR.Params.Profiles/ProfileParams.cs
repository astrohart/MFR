namespace MFR.Params.Profiles
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a <c>ProfileParams</c>
    /// object.
    /// </summary>
    /// <remarks>
    /// Such objects allow us to make requests on profiles in a more
    /// functional-programming method.
    /// </remarks>
    public interface IProfileParams
    {
        /// <summary>
        /// Gets or sets a string that contains the name of the <c>Profile</c>.
        /// </summary>
        string Name
        {
            get;
            set;
        }
    }

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