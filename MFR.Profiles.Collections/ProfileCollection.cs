using MFR.Profiles.Collections.Interfaces;
using MFR.Profiles.Interfaces;
using System;
using System.Collections.Generic;
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
        /// <summary>
        /// A <see cref="T:System.Guid" /> that delineates which profile is
        /// currently "active" i.e., is in use.
        /// </summary>
        public Guid ActiveProfile
        {
            get;
            set;
        }
    }
}