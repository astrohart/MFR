using MFR.FileSystem.Factories;
using MFR.FileSystem.Validators.Factories;
using MFR.Operations.Constants;
using NUnit.Framework;
using Alphaleonis.Win32.Filesystem;

namespace MFR.FileSystem.Helpers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.DirectoryInfoExtensions" />
    /// class.
    /// </summary>
    [TestFixture]
    public class DirectoryInfoExtensionsTests
    {
        private const string DEST_FOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Brokers";

        private const string SOURCE_FOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.States.Servicess.Brokers";

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.DirectoryInfoExtensions.RenameTo" />
        /// method renames a directory successfully when passed proper pathnames.
        /// </summary>
        [Test]
        public void Test_Directory_RenamedSuccessfully()
        {
            Assert.DoesNotThrow(
                () => new DirectoryInfo(SOURCE_FOLDER).RenameTo(DEST_FOLDER)
            );

            Assert.IsFalse(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .DoesExist(
                                               MakeNewFileSystemEntry.ForPath(
                                                   SOURCE_FOLDER
                                               )
                                           )
            );
            Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .DoesExist(
                                               MakeNewFileSystemEntry.ForPath(
                                                   DEST_FOLDER
                                               )
                                           )
            );
        }
    }
}