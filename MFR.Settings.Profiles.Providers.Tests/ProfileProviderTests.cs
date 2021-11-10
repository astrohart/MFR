using MFR.Settings.Profiles.Providers.Factories;
using MFR.Settings.Profiles.Providers.Interfaces;
using MFR.Tests;
using NUnit.Framework;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Settings.Profiles.Providers.ProfileProvider" /> class.
    /// </summary>
    [TestFixture]
    public class ProfileProviderTests : DebuggableTestFixture
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        private IProfileProvider ProfileProvider
            => GetProfileProvider.SoleInstance();

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_Load_Method_Works_When_PassedStringEmpty()
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(DebugLevel.Debug, "In ProfileProviderTests.Test_Load_Method_Works_When_PassedStringEmpty");

        }
    }
}