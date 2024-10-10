using MFR.Settings.Profiles.Interfaces;
using System;
using System.Collections.Generic;

namespace MFR.Settings.Profiles.Collections.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// <c>Profile Collection</c> object.
    /// </summary>
    /// <remarks>
    /// A <c>Profile Collection</c> object is what it sounds like -- a
    /// container of profiles.
    /// </remarks>
    public interface IProfileCollection : ICollection<IProfile>
    {
        /// <summary>
        /// Gets the object implementing the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface at the
        /// position <paramref name="i" />  in the collection.
        /// </summary>
        /// <param name="i">
        /// (Required.) Integer, that is zero or greater, referring to the
        /// index of the desired element.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface that
        /// exists at the specified index.
        /// </returns>
        IProfile this[int i]
        {
            get;
        }

        /// <summary>
        /// Determines whether the profile collection already has a profile with the
        /// name provided.
        /// <para />
        /// There can only be one profile with a given name, case-insensitive.
        /// </summary>
        /// <param name="name">(Required.) Name of the profile to be searched for.</param>
        /// <returns>
        /// <see langword="true" /> if a profile having the given name is found;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool HasProfileNamed(string name);

        /// <summary>
        /// Removes all of those elements from the collection that satisfy the specified
        /// <paramref name="predicate" />.
        /// </summary>
        /// <param name="predicate">
        /// (Required.) A predicate that returns
        /// <see langword="true" /> if a specific item is to be removed from the
        /// collection.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the element(s) matching the specified
        /// <paramref name="predicate" /> were removed successfully, or if the collection
        /// is empty; <see langword="false" /> otherwise.
        /// </returns>
        bool RemoveAll(Predicate<IProfile> predicate);
    }
}