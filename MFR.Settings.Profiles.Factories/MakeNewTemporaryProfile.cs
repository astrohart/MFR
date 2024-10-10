using MFR.Settings.Profiles.Interfaces;
using System;

namespace MFR.Settings.Profiles.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface that are
    /// "temporary profiles."
    /// </summary>
    /// <remarks>
    /// Temporary profiles are those that have a prefix of <c>tmp_</c> in their names,
    /// and a <see cref="T:System.Guid" /> for the rest of the name.
    /// <para />
    /// Temporary profiles are meant to be used only for the lifetime of the
    /// application.
    /// </remarks>
    public static class MakeNewTemporaryProfile
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface that is a
        /// "temporary profile."
        /// </summary>
        /// <returns>
        /// New instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface that is a
        /// "temporary profile."
        /// </returns>
        /// <remarks>
        /// Temporary profiles are those that have a prefix of <c>tmp_</c> in their names,
        /// and a <see cref="T:System.Guid" /> for the rest of the name.
        /// <para />
        /// Temporary profiles are meant to be used only for the lifetime of the
        /// application.
        /// </remarks>
        public static IProfile FromScratch()
            => MakeNewProfile.FromScratch()
                             .HavingName($"tmp_{Guid.NewGuid():B}");
    }
}