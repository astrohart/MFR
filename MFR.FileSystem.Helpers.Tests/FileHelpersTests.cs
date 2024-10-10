using PostSharp.Patterns.Threading;
using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Factories;
using MFR.Tests.Common;
using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Helpers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.FileHelpers" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    [Log(AttributeExclude = true)]
    public class FileHelpersTests
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public void Initialize()
            => DebugFileAndFolderHelper.ClearTempFileDir();

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Helpers.FillTextFile.WithJunk" /> method
        /// creates a new file of nonzero length.
        /// </summary>
        [Test]
        public void Test_FilleWithJunk_Works()
        {
            FillTextFile.WithJunk(
                StringConstants.EXISTING_TEMP_FILE
            );

            VerifyResultantFile(
                MakeNewFileInfo.ForPath(StringConstants.EXISTING_TEMP_FILE)
            );
        }

        /// <summary>
        /// Asserts that the <see cref="M:MFR.FileSystem.Helpers.FileHelpers.ToTempFile"/> method dumps text to a temporary file.
        /// </summary>
        [Test]
        public void Test_DumpTextToTempFile_Works()
        {
            var result = DumpText.ToTempFile(
                "Now is the time for all good men to come to the aid of their country."
            );

            Assert.That(result, Is.Not.Empty);

            VerifyResultantFile(MakeNewFileInfo.ForPath(result));

            Assert.That(
                FileHelpers.GetTextContent(result),
                Is.EqualTo(
                    "Now is the time for all good men to come to the aid of their country."
                )
            );
        }

        /// <summary>
        /// Runs common assertions on the
        /// <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> instance specified in
        /// the <paramref name="resultantFile" /> parameter.
        /// </summary>
        /// <param name="resultantFile">
        /// (Required.) A
        /// <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> instance that contains
        /// information about the <paramref name="resultantFile" />.
        /// </param>
        /// <remarks>
        /// The <see cref="M:MFR.FileSystem.Factories.MakeNewFileInfo.ForPath" />
        /// method can be utilized to manufacture the
        /// <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> instance given a
        /// pathname.
        /// </remarks>
        private static void VerifyResultantFile(FileInfo resultantFile)
        {
            Assert.That(resultantFile, Is.Not.Null);
            Assert.That(resultantFile.Exists);
            Assert.That(resultantFile.Length > 0);
        }

        /// <summary>
        /// Calls the
        /// <see cref="M:MFR.FileSystem.Helpers.FillTextFile.WithJunk" /> method
        /// to fill a temporary file with random data, and then makes sure that the
        /// <see cref="M:MFR.FileSystem.Helpers.FileHelpers.GetTextContent" /> method
        /// successfully reads the data.
        /// </summary>
        [Test]
        public void Test_GetContent_Works_OnTempFileFullOfJunk()
        {
            FillTextFile.WithJunk(
                StringConstants.EXISTING_TEMP_FILE
            );

            VerifyResultantFile(
                MakeNewFileInfo.ForPath(StringConstants.EXISTING_TEMP_FILE)
            );

            Assert.That(!
                string.IsNullOrWhiteSpace(
                    FileHelpers.GetTextContent(
                        StringConstants.EXISTING_TEMP_FILE
                    )
                )
            );
        }
    }
}