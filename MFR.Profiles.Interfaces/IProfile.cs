﻿using MFR.Objects.Configuration.Interfaces;
using System;

namespace MFR.Profiles.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a <c>Profile</c> object.
    /// </summary>
    /// <remarks>
    /// <c>Profile</c> objects are basically hot-swappable variations on the
    /// <c>Configuration</c> object.
    /// <para />
    /// Whereas <c>Configuration</c> objects have to be loaded from/saved to a
    /// persistent store, such as a database or a file, <c>Profile</c> s have
    /// this capability as well, but are also named with unique identifiers --
    /// meaning we can allow the user to create profiles so they can hot-swap
    /// the settings, say, for one solution versus another.
    /// </remarks>
    public interface IProfile : IConfiguration
    {
        /// <summary>
        /// Gets or sets a string value that is the name of this profile.
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Guid" /> value that uniquely identifies
        /// this <see cref="T:MFR.Profiles.Profile" />.
        /// </summary>
        /// <remarks>
        /// This property is automatically initialized with a newly-generated
        /// <c>GUID</c> upon construction.
        /// </remarks>
        Guid ProfileId
        {
            get;
        }
    }
}