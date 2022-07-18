using MFR.Settings.Profiles.Collections.Interfaces;
using MFR.Settings.Profiles.Collections.Properties;
using MFR.Settings.Profiles.Interfaces;
using Newtonsoft.Json;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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
        public ProfileCollection()
        {
            // Default constructor
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Settings.Profiles.Collections.ProfileCollection" /> and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        [JsonConstructor]
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
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(name)
                );

            var result = false;

            if (Count == 0) return result;

            return Items.Any(
                profile => name.ToLowerInvariant()
                               .Equals(profile.Name.ToLowerInvariant())
            );
        }
    }
}
