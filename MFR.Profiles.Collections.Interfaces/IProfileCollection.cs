using MFR.Profiles.Interfaces;
using System.Collections.Generic;

namespace MFR.Profiles.Collections.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a <c>Profile Collection</c> object.
    /// </summary>
    /// <remarks>A <c>Profile Collection</c> object is what it sounds like -- a container of profiles.</remarks>
    public interface IProfileCollection : ICollection<IProfile>
    {
    }
}