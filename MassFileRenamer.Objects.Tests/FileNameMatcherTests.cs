using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.TextExpressionMatcher" />
    /// class.
    /// </summary>
    [TestFixture]
    public class FileNameMatcherTests : TextExpressionMatcherTestBase
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public override void Initialize()
        {
            base.Initialize();

            CreateMatcherFor(OperationType.RenameFilesInFolder);
        }
    }
}