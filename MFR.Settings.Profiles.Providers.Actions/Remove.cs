﻿using MFR.Settings.Profiles.Collections.Interfaces;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
    public static class Remove
    {
        /// <summary>
        /// Removes all temporary profiles from the specified
        /// <paramref name="collection" />.
        /// </summary>
        /// <param name="collection">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface that represents the collection of profiles from which temporary
        /// profiles are to be removed.
        /// </param>
        /// <remarks>
        /// A temporary profile is defined to be one whose name begins with
        /// <c>tmp_</c>.
        /// <para />
        /// If the specified <paramref name="collection" /> is <see langword="null" /> or
        /// does not contain any elements, then this method does nothing.
        /// </remarks>
        public static void TemporaryProfiles(IProfileCollection collection)
        {
            try
            {
                if (collection == null || !collection.Any()) return;

                collection.RemoveAll(
                    profile => profile.Name.StartsWith("tmp_")
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}