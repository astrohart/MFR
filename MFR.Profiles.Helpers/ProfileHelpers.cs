using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Profiles.Factories;
using MFR.Settings.Profiles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFR.Profiles.Helpers
{
    public static class ProfileHelpers
    {
        public static IProfile ToProfile(this IConfiguration configuration,
            string name)
            => MakeNewProfile.
    }
}
