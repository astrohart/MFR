using MFR.Objects.FileSystem.Factories;
using MFR.Objects.FileSystem.Validators;
using MFR.Objects.FileSystem.Validators.Factories;
using MFR.Objects.Operations.Constants;
using MFR.Objects.Tests.Common;
using NUnit.Framework;
using System;
using System.IO;

namespace MFR.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.FileValidator" />
    /// class.
    /// </summary>
    [TestFixture]
    public class DirectoryValidatorTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_DoesExist_ReturnsFalse_WhenProvidedFolderPath_NotExists()
            => Assert.IsFalse(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .DoesExist(
                                               MakeNewFileSystemEntry.ForPath(
                                                   StringConstants
                                                       .NONEXISTENT_FOLDER
                                               )
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .DoesExist(
                                               MakeNewFileSystemEntry.ForPath(
                                                   StringConstants
                                                       .WINDOWS_SYSTEM_FOLDER
                                               )
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_DoesExist_ThrowsArgumentException_ForBlankPath()
            => Assert.Throws<ArgumentException>(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .DoesExist(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.EMPTY_STRING
                          )
                      )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_DoesExist_ThrowsArgumentException_ForNullPath()
            => Assert.Throws<ArgumentException>(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .DoesExist(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.NULL_STRING
                          )
                      )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_DoesExist_ThrowsArgumentException_ForWhitespacePath()
            => Assert.Throws<ArgumentException>(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .DoesExist(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.EMPTY_STRING
                          )
                      )
            );

        [Test]
        public void Test_IsValid_DoesNotThrowException_ForWindowsSystemFolder()
            => Assert.DoesNotThrow(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .IsValid(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.WINDOWS_SYSTEM_FOLDER
                          )
                      )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_IsValid_ThrowsArgumentException_ForBlankPath()
            => Assert.Throws<ArgumentException>(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .IsValid(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.EMPTY_STRING
                          )
                      )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_IsValid_ThrowsArgumentException_ForNullPath()
            => Assert.Throws<ArgumentException>(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .IsValid(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.NULL_STRING
                          )
                      )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_IsValid_ThrowsArgumentException_ForWhitespacePath()
            => Assert.Throws<ArgumentException>(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .IsValid(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.WHITESPACE
                          )
                      )
            );

        [Test]
        public void
            Test_IsValid_ThrowsDirectoryNotFoundException_ForNonexistentFolder()
            => Assert.Throws<DirectoryNotFoundException>(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .IsValid(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.NONEXISTENT_FOLDER
                          )
                      )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsFalse_ForAllowedDir()
            => Assert.IsFalse(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .FOLDER_MATCHING_OPERATION_CRITIERIA
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForBlankPath()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants.EMPTY_STRING
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForDotfolder()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants.DOTFOLDER_PATH_KNOWN_TO_EXIST
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFolderInBinDir()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .SUBFOLDER_OF_BIN_DIR
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFolderInObjDir()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .SUBFOLDER_OF_OBJ_FOLDER
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForNullInput()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(null)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForNullPath()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants.NULL_STRING
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFolder()
        {
            var path = StringConstants.NONEXISTENT_FOLDER;
            Assert.IsNotNull(path);

            var directoryValidator =
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders);
            Assert.IsNotNull(directoryValidator);
            Assert.IsTrue(directoryValidator is DirectoryValidator);

            Assert.IsFalse(Directory.Exists(path));

            Assert.IsTrue(directoryValidator.ShouldSkip(path));
        }

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForSubfolderOfGitDir()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .SUBFOLDER_OF_GIT_FOLDER
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForSubfolderOfPackagesDir()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForSubfolderOfVsDir()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .SUBFOLDER_OF_VS_DOTFOLDER
                                           )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForWhitespacePath()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants.WHITESPACE
                                           )
            );
    }
}