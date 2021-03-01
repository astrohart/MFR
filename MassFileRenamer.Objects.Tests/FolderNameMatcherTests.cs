using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.FolderNameMatcher" />
    /// class.
    /// </summary>
    [TestFixture]
    public class FolderNameMatcherTests : TextExpressionMatcherTestBase
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public override void Initialize()
        {
            base.Initialize();

            CreateMatcherFor(OperationType.RenameSubFolders);
        }
    }
}