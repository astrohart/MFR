using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using NUnit.Framework;

namespace MFR.Engines.Matching.Tests
{
    /// <summary>
    /// Provides unit tests for the methods of the
    /// <see
    ///     cref="T:MFR.FileNameMatchingEngine" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
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