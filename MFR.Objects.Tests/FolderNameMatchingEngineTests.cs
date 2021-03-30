using NUnit.Framework;

namespace MFR.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.FolderNameMatchingEngine" />
    /// class.
    /// </summary>
    [TestFixture]
    public class FolderNameMatchingEngineTests : TextExpressionMatchingEngineTestBase
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_IsMatch_ReturnsTrue_ForExactFolderSearchMatch()
        {
            _configuration = ConfigurationBuilder.Instance
                                                 .SetMatchCase()
                                                 .AndSetMatchExactWord(false)
                                                 .Build();
            _matcher.UpdateConfiguration(_configuration);

            Assert.IsTrue(
                _matcher.IsMatch(
                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Servicess.Brokers",
                    "PortfolioMonitor.States.Servicess.Brokers",
                    "PortfolioMonitor.States.Brokers"
                )
            );
            Assert.IsTrue(
                _matcher.IsMatch(
                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Servicess.Brokers.Interfaces",
                    "PortfolioMonitor.States.Servicess.Brokers",
                    "PortfolioMonitor.States.Brokers"
                )
            );
        }

        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public override void Initialize()
        {
            base.Initialize();

            CreateMatchingEngineFor(OperationType.RenameSubFolders);
        }
    }
}