using MFR.Settings.Profiles.Providers.Interfaces;
using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;

namespace MFR.Settings.Profiles.Providers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Settings.Profiles.Providers.Factories.GetProfileProvider" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized, Log(AttributeExclude = true)]
    public class GetProfileProviderTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.Profiles.Providers.Factories.GetProfileProvider.SoleInstance" />
        /// method returns a reference to the correct object, and that the
        /// reference is not null.
        /// </summary>
        [Test]
        public void Test_SoleInstance_Method_Works()
        {
            var result = GetProfileProvider.SoleInstance();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf(typeof(IProfileProvider)));
            Assert.That(result, Is.InstanceOf(typeof(ProfileProvider)));
        }
    }
}