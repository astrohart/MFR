using MFR.Objects.FileSystem.Factories;
using MFR.Objects.FileSystem.Helpers;
using MFR.Objects.FileSystem.Validators.Factories;
using MFR.Objects.Operations.Constants;
using NUnit.Framework;
using System.IO;

namespace MFR.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.DirectoryInfoExtensions" />
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
        ///     cref="M:MFR.Objects.DirectoryInfoExtensions.RenameTo" />
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