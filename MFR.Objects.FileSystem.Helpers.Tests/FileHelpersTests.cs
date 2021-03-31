using NUnit.Framework;

namespace MFR.Objects.FileSystem.Helpers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.FileHelpers" />
    /// class.
    /// </summary>
    [TestFixture]
    public class FileHelpersTests
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public void Initialize()
            => DebugFileAndFolderHelper.ClearTempFileDir();

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_FilleWithJunk_Works()
        {
            FileHelpers.FillWithJunk(StringConstants.EXISTING_TEMP_FILE);
            Assert.IsTrue(
                MakeNewFileInfo.ForPath(StringConstants.EXISTING_TEMP_FILE)
                               .Length > 0
            );
        }

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_GetContent_Works_OnTempFileFullOfJunk()
        {
            FileHelpers.FillWithJunk(StringConstants.EXISTING_TEMP_FILE);
            Assert.IsFalse(
                string.IsNullOrWhiteSpace(
                    FileHelpers.GetContent(StringConstants.EXISTING_TEMP_FILE)
                )
            );
        }
    }
}