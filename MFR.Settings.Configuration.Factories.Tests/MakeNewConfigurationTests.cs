using MFR.Settings.Configuration.Interfaces;
using NUnit.Framework;

namespace MFR.Settings.Configuration.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Settings.Configuration.Factories.MakeNewConfiguration" />
    /// class.
    /// </summary>
    [TestFixture]
    public class MakeNewConfigurationTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.ProjectFileRenamerConfiguration.Factories.MakeNewConfiguration.FromScratch" />
        /// method returns a reference to an instance of an object that is (a) non-
        /// <see langword="null" />, (b) an instance of the
        /// <see cref="T:MFR.Settings.Configuration.ProjectFileRenamerConfiguration" /> class, and (c)
        /// implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </summary>
        [Test]
        public void Test_MakeNewConfiguraton_FromScratch_Method_Works()
        {
            var result = MakeNewConfiguration.FromScratch();

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.AssignableFrom(typeof(ProjectFileRenamerProjectFileRenamerConfiguration)));
            Assert.That(result, Is.AssignableTo(typeof(IProjectFileRenamerConfiguration)));
        }
    }
}
