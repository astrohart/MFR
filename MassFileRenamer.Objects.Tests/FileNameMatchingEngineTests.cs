using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.FileNameMatchingEngine" />
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