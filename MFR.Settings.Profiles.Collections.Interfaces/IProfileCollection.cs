using MFR.Settings.Profiles.Interfaces;
using System;
using System.Collections.Generic;

namespace MFR.Settings.Profiles.Collections.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a <c>Profile Collection</c> object.
    /// </summary>
    /// <remarks>A <c>Profile Collection</c> object is what it sounds like -- a container of profiles.</remarks>
    public interface IProfileCollection : ICollection<IProfile>
    {
        /// <summary>
        ///     Determines whether the profile collection already has a profile with the
        ///     name provided.
        ///     <para />
        ///     There can only be one profile with a given name, case-insensitive.
        /// </summary>
        /// <param name="name">(Required.) Name of the profile to be searched for.</param>
        /// <returns>
        ///     <see langword="true" /> if a profile having the given name is found;
        ///     <see langword="false" /> otherwise.
        /// </returns>
        bool HasProfileNamed(string name);
    }
}