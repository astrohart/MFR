using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Serializers.Actions;
using NUnit.Framework;

namespace MFR.Settings.Configuration.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Factories.MakeNewProjectFileRenamerConfiguration" />
    /// class.
    /// </summary>
    [TestFixture]
    public class MakeNewConfigurationTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.ProjectFileRenamerConfiguration.Factories.MakeNewProjectFileRenamerConfiguration.FromScratch" />
        /// method returns a reference to an instance of an object that is (a) non-
        /// <see langword="null" />, (b) an instance of the
        /// <see cref="T:MFR.Settings.Configuration.ProjectFileRenamerConfiguration" />
        /// class, and (c)
        /// implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </summary>
        [Test]
        public void Test_MakeNewConfiguraton_FromScratch_Method_Works()
        {
            var result = Create.BlankConfiguration();

            Assert.That(result, Is.Not.Null);
            Assert.That(
                result,
                Is.AssignableFrom(typeof(ProjectFileRenamerConfiguration))
            );
            Assert.That(
                result,
                Is.AssignableTo(typeof(IProjectFileRenamerConfiguration))
            );
        }
    }
}