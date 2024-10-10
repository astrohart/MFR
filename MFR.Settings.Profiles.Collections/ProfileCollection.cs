using MFR.Settings.Profiles.Collections.Interfaces;
using MFR.Settings.Profiles.Interfaces;
using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Collections
{
    /// <summary>
    /// Implements the methods and properties of a <c>Profile Collection</c>
    /// object.
    /// </summary>
    /// <remarks>
    /// A <c>Profile Collection</c> object is just that -- a container for
    /// <c>Profile</c> s.
    /// </remarks>
    public class ProfileCollection : Collection<IProfile>, IProfileCollection
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Settings.Profiles.Collections.ProfileCollection" /> and
        /// returns a reference to it.
        /// </summary>
        /// <remarks>
        /// The object instance reference returned by this constructor represents the empty
        /// collection.
        /// </remarks>
        public ProfileCollection()
        {
            // Default constructor
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Settings.Profiles.Collections.ProfileCollection" /> and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true), JsonConstructor]
        public ProfileCollection(IEnumerable<IProfile> profiles)
        {
            if (profiles == null) return;

            foreach (var profile in profiles)
                Add(profile);
        }

        /// <summary>
        /// A <see cref="T:System.Guid" /> that delineates which profile is
        /// currently "active" i.e., is in use.
        /// </summary>
        public Guid ActiveProfile
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the empty <c>ProfileCollection</c>.
        /// </summary>
        public static IProfileCollection Empty
        {
            get;
        } = new ProfileCollection();

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
        public bool HasProfileNamed(string name)
        {
            var result = false;

            try
            {
                if (Count == 0) return result;
                if (string.IsNullOrWhiteSpace(name)) return result;

                result = Items.Any(
                    profile => name.ToLowerInvariant()
                                   .Equals(profile.Name.ToLowerInvariant())
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

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
        public bool RemoveAll(Predicate<IProfile> predicate)
        {
            var result = true;

            try
            {
                if (Count == 0) return result;
                if (predicate == null) return result;

                for (var i = Count - 1; i >= 0; i--)
                {
                    if (!predicate(this[i])) continue;

                    RemoveAt(i);
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}