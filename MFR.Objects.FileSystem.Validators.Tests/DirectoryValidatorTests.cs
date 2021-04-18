using MFR.Objects.FileSystem.Factories;
using MFR.Objects.FileSystem.Validators.Factories;
using MFR.Objects.Operations.Constants;
using MFR.Objects.Tests.Common;
using NUnit.Framework;
using System;
using System.IO;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.Objects.FileSystem.Validators.Tests
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
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.DoesExist" />
        /// method returns <see langword="false" /> when the folder path provided
        /// to the method as its argument does not, in fact, exist on the disk.
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
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.DoesExist" />
        /// method returns <see langword="true" /> when provided with the path to
        /// a folder on the disk that is guaranteed to exist.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.DoesExist"/> method throws <see cref="T:System.ArgumentException"/> when passed a blank value for its parameter.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.DoesExist"/> method throws <see cref="T:System.ArgumentException"/> when passed a <see langword="null" /> value for its parameter.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.DoesExist"/> method throws <see cref="T:System.ArgumentException"/> when passed a whitespace value for its parameter.
        /// </summary>
        [Test]
        public void Test_DoesExist_ThrowsArgumentException_ForWhitespacePath()
            => Assert.Throws<ArgumentException>(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .DoesExist(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.WHITESPACE
                          )
                      )
            );

        /// <summary>
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.IsValid"/> method does not throw any exceptions when passed the pathname of the C:\WINDOWS\System32 folder (which is guaranteed to always be valid).
        /// </summary>
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.IsValid"/> method throws <see cref="T:System.ArgumentException"/> when passed a blank string for its parameter.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.IsValid"/> method throws <see cref="T:System.ArgumentException"/> when passed a <see langword="null" /> string for its parameter.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.IsValid"/> method throws <see cref="T:System.ArgumentException"/> when passed whitespace for its parameter.
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

        /// <summary>
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.IsValid"/> method throws <see cref="T:System.IO.DirectoryNotFoundException"/> when passed the path to a folder that is guaranteed not to actually exist on the machine's hard disk.
        /// </summary>
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="false" /> when passed the path to a folder that matches the operational criteria.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> when passed a blank string for its argument.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> when passed the pathname to a dotfolder (a folder whose name begins with a period), as such a folder does not meet the operational criteria.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForDotfolder()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .DOTFOLDER_PATH_KNOWN_TO_EXIST
                                           )
            );

        /// <summary>
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> for a folder named <c>bin</c>, which does not meet the operational criteria.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> for a folder named <c>obj</c>, which does not meet the operational criteria.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> when passed the <see langword="null" /> string for its argument.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForNullInput()
            => Assert.IsTrue(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(null)
            );

        /// <summary>
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> when passed the <see langword="null" /> string for its argument.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> when passed the pathname of a folder that is known not to exist.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> for a folder named <c>.git</c>, or a subfolder thereof, which does not meet the operational criteria.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> for a folder named <c>packages</c>, or a subfolder thereof, which does not meet the operational criteria.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> for a folder named <c>.vs</c>, or a subfolder thereof, which does not meet the operational criteria.
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
        /// Asserts that the <see cref="M:MFR.Objects.FileSystem.Validators.DirectoryValidator.ShouldSkip"/> method returns <see langword="true" /> when passed whitespace for its argument.
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