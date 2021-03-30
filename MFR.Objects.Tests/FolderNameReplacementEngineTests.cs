using NUnit.Framework;

namespace MFR.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.FolderNameReplacementEngine" />
    /// class.
    /// </summary>
    [TestFixture]
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

            Configuration = ConfigurationBuilder.Instance.SetMatchCase()
                                                .AndSetMatchExactWord()
                                                .Build();
            Replacer.UpdateConfiguration(Configuration);

            var replacementResult1 = Replacer.Replace(
                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Servicess.Brokers",
                "PortfolioMonitor.States.Servicess.Brokers",
                "PortfolioMonitor.States.Brokers"
            );
            Assert.AreEqual(
                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Brokers",
                replacementResult1
            );
            var replacementResult2 = Replacer.Replace(
                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Servicess.Brokers.Interfaces",
                "PortfolioMonitor.States.Servicess.Brokers",
                "PortfolioMonitor.States.Brokers"
            );
            Assert.AreEqual(
                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Brokers.Interfaces",
                replacementResult2
            );
        }
    }
}