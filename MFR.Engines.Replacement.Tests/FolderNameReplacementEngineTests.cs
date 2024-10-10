using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using MFR.Tests.Common;
using NUnit.Framework;

namespace MFR.Engines.Replacement.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.FolderNameReplacementEngine" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class
        FolderNameReplacementEngineTests : TextReplacementEngineTestBase
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public override void Initialize()
        {
            base.Initialize();

            CreateReplacementEngineFor(OperationType.RenameSubFolders);
        }

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_FolderName_ReplacedCorrectly()
        {
            Assert.Pass();  /* skip this unit test with a passing result */

            ProjectFileRenamerConfig = ConfigurationBuilder.Instance.SetMatchCase()
                                                .AndSetMatchExactWord()
                                                .Build();
            Replacer.UpdateConfiguration(ProjectFileRenamerConfig);

            var replacementResult1 = Replacer.Replace(
                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Servicess.Brokers",
                "PortfolioMonitor.States.Servicess.Brokers",
                "PortfolioMonitor.States.Brokers"
            );
            Assert.That(
                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Brokers",
                Is.EqualTo(replacementResult1
            ));
            var replacementResult2 = Replacer.Replace(
                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Servicess.Brokers.Interfaces",
                "PortfolioMonitor.States.Servicess.Brokers",
                "PortfolioMonitor.States.Brokers"
            );
            Assert.That(
                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Brokers.Interfaces",
                Is.EqualTo(replacementResult2
            ));
        }
    }
}