using MFR.Profiles.Collections.Interfaces;
using MFR.Profiles.Interfaces;
using System.Collections.ObjectModel;

namespace MFR.Profiles.Collections
{
    /// <summary>
    /// Implements the methods and properties of a <c>Profile Collection</c> object.
    /// </summary>
    /// <remarks>
    /// A <c>Profile Collection</c> object is just that -- a container for
    /// <c>Profile</c> s.
    /// </remarks>
    public class ProfileCollection : Collection<IProfile>, IProfileCollection
    {
        // TODO: Add custom method and property definitions here
    }
}