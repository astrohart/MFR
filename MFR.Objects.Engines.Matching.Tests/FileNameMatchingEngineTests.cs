using NUnit.Framework;

namespace MFR.Objects.Engines.Matching.Tests
{
    /// <summary>
    /// Provides unit tests for the methods of the
    /// <see
    ///     cref="T:MFR.Objects.FileNameMatchingEngine" />
    /// class.
    /// </summary>
    [TestFixture]
    public class FileNameMatchingEngineTests : TextExpressionMatchingEngineTestBase
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public override void Initialize()
        {
            base.Initialize();

            CreateMatchingEngineFor(OperationType.RenameFilesInFolder);
        }
    }
}