using MFR.Profiles.Collections.Interfaces;
using System;

namespace MFR.Profiles.Serializers
{
    /// <summary>
    /// Loads and stores profile list information to/from a file.
    /// </summary>
    /// <remarks>
    /// The profile information is used in code via the <see
    /// cref="T:MFR.Profiles.Collections.Interfaces.IProfileCollection"/> interface.
    /// </remarks>
    public static class ProfileListSerializer
    {
        public static IProfileCollection Load(string path)
            => throw new NotImplementedException();
    }
}