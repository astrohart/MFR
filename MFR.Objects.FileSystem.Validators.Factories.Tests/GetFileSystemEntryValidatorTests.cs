using NUnit.Framework;
using System;

namespace MFR.Objects.FileSystem.Validators.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.GetFileSystemEntryValidator" />
    /// class.
    /// </summary>
    [TestFixture]
    public class GetFileSystemEntryValidatorTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsDirectoryValidator_For_RenameSubFolders_Operation()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                    is DirectoryValidator
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFileValiator_For_ReplaceTextInFiles_Operation()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(
                    OperationType.ReplaceTextInFiles
                ) is FileValidator
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFileValidator_ForRenameFilesInFolder_Operation()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(
                    OperationType.RenameFilesInFolder
                ) is FileValidator
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_Operation()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetFileSystemEntryValidator.For(
                    OperationType.CloseActiveSolution
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_Operaiton()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetFileSystemEntryValidator.For(
                    OperationType.FindVisualStudio
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_GettingListOfFilesToBeRenamed_Operation()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetFileSystemEntryValidator.For(
                    OperationType.GettingListOfFilesToBeRenamed
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_Operation()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetFileSystemEntryValidator.For(
                    OperationType.OpenActiveSolution
                )
            );
    }
}