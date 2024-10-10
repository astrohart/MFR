using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using NUnit.Framework;
using System;

namespace MFR.FileSystem.Validators.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.GetFileSystemEntryValidator" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class GetFileSystemEntryValidatorTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsDirectoryPathValidator_For_RenameSubFolders_Operation()
            => Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                    is DirectoryPathValidator
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFileValiator_For_ReplaceTextInFiles_Operation()
            => Assert.That(
                GetFileSystemEntryValidator.For(
                    OperationType.ReplaceTextInFiles
                ) is ProjectFileValidator
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFileValidator_ForRenameFilesInFolder_Operation()
            => Assert.That(
                GetFileSystemEntryValidator.For(
                    OperationType.RenameFilesInFolder
                ) is ProjectFileValidator
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_Operation()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetFileSystemEntryValidator.For(
                    OperationType.CloseActiveSolutions
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
            Test_For_ThrowsArgumentOutOfRangeException_For_CalculateListOfFilesToBeRenamed_Operation()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetFileSystemEntryValidator.For(
                    OperationType.CalculateListOfFilesToBeRenamed
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
                    OperationType.OpenActiveSolutions
                )
            );
    }
}