using PostSharp.Patterns.Threading;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Validators.Factories;
using MFR.Operations.Constants;
using MFR.Tests.Common;
using NUnit.Framework;
using System;
using System.IO;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.FileSystem.Validators.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.FileSystem.Validators.ProjectFileValidator" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class DirectoryPathValidatorTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.DoesExist" />
        /// method returns <see langword="false" /> when the folder path provided
        /// to the method as its argument does not, in fact, exist on the file system.
        /// </summary>
        [Test]
        public void
            Test_DoesExist_ReturnsFalse_WhenProvidedFolderPath_NotExists()
        {
            Assert.That(!
                Directory.Exists(StringConstants.NONEXISTENT_FOLDER)
            );
            Assert.That(!
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .DoesExist(
                                               MakeNewFileSystemEntry.ForPath(
                                                   StringConstants
                                                       .NONEXISTENT_FOLDER
                                               )
                                           )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.DoesExist" />
        /// method returns <see langword="true" /> when provided with the path to
        /// a folder on the file system that is guaranteed to exist.
        /// </summary>
        [Test]
        public void Test_DoesExist_ReturnsTrue_WhenProvidedFolderPath_Exists()
        {
            Assert.That(
                Directory.Exists(StringConstants.WINDOWS_SYSTEM_FOLDER)
            );
            Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .DoesExist(
                                               MakeNewFileSystemEntry.ForPath(
                                                   StringConstants
                                                       .WINDOWS_SYSTEM_FOLDER
                                               )
                                           )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.DoesExist" />
        /// method throws <see cref="T:System.ArgumentException" /> when passed a
        /// blank value for its parameter.
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
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.DoesExist" />
        /// method throws <see cref="T:System.ArgumentException" /> when passed a
        /// <see langword="null" /> value for its parameter.
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
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.DoesExist" />
        /// method throws <see cref="T:System.ArgumentException" /> when passed a
        /// whitespace value for its parameter.
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
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.IsValid" />
        /// method does not throw any exceptions when passed the pathname of the
        /// C:\WINDOWS\System32 folder (which is guaranteed to always be valid).
        /// </summary>
        [Test]
        public void Test_IsValid_DoesNotThrowException_ForWindowsSystemFolder()
        {
            Assert.That(
                Directory.Exists(StringConstants.WINDOWS_SYSTEM_FOLDER)
            );
            Assert.DoesNotThrow(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .IsValid(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.WINDOWS_SYSTEM_FOLDER
                          )
                      )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.IsValid" />
        /// method throws <see cref="T:System.ArgumentException" /> when passed a
        /// blank string for its parameter.
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
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.IsValid" />
        /// method throws <see cref="T:System.ArgumentException" /> when passed a
        /// <see langword="null" /> string for its parameter.
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
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.IsValid" />
        /// method throws <see cref="T:System.ArgumentException" /> when passed
        /// whitespace for its parameter.
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
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.IsValid" />
        /// method throws <see cref="T:System.IO.DirectoryNotFoundException" />
        /// when passed the path to a folder that is guaranteed not to actually
        /// exist on the machine's hard disk.
        /// </summary>
        [Test]
        public void
            Test_IsValid_ThrowsDirectoryNotFoundException_ForNonexistentFolder()
        {
            Assert.That(!
                Directory.Exists(StringConstants.NONEXISTENT_FOLDER)
            );
            Assert.Throws<DirectoryNotFoundException>(
                () => GetFileSystemEntryValidator
                      .For(OperationType.RenameSubFolders)
                      .IsValid(
                          MakeNewFileSystemEntry.ForPath(
                              StringConstants.NONEXISTENT_FOLDER
                          )
                      )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="false" /> when passed the path to a
        /// folder that matches the operational criteria.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsFalse_ForAllowedDir()
        {
            if (!Directory.Exists(
                StringConstants.FOLDER_MATCHING_OPERATIONAL_CRITIERIA
            ))
            {
                Console.WriteLine(
                    $"Test folder, '{StringConstants.FOLDER_MATCHING_OPERATIONAL_CRITIERIA}', does not exist."
                );
                return;
            }

            Assert.That(
                Directory.Exists(
                    StringConstants.FOLDER_MATCHING_OPERATIONAL_CRITIERIA
                )
            );
            Assert.That(!
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .FOLDER_MATCHING_OPERATIONAL_CRITIERIA
                                           )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed a blank string for
        /// its argument.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForBlankPath()
            => Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants.EMPTY_STRING
                                           )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname to a
        /// dotfolder (a folder whose name begins with a period), as such a
        /// folder does not meet the operational criteria.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForDotfolder()
        {
            Assert.That(
                Directory.Exists(StringConstants.DOTFOLDER_PATH_KNOWN_TO_EXIST)
            );
            Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .DOTFOLDER_PATH_KNOWN_TO_EXIST
                                           )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> for a folder named <c>bin</c>,
        /// which does not meet the operational criteria.
        /// </summary>
        [Test]
        [Obsolete]
        public void Test_ShouldSkip_ReturnsTrue_ForFolderInBinDir()
        {
            Assert.That(
                Directory.Exists(StringConstants.SUBFOLDER_OF_BIN_DIR)
            );
            Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .SUBFOLDER_OF_BIN_DIR
                                           )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> for a folder named <c>obj</c>,
        /// which does not meet the operational criteria.
        /// </summary>
        [Test]
        [Obsolete]
        public void Test_ShouldSkip_ReturnsTrue_ForFolderInObjDir()
        {
            Assert.That(
                Directory.Exists(StringConstants.SUBFOLDER_OF_OBJ_FOLDER)
            );
            Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .SUBFOLDER_OF_OBJ_FOLDER
                                           )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the
        /// <see
        ///     langword="null" />
        /// string for its argument.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForNullInput()
            => Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(null)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the
        /// <see
        ///     langword="null" />
        /// string for its argument.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForNullPath()
            => Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants.NULL_STRING
                                           )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// folder that is known not to exist.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFolder()
        {
            var path = StringConstants.NONEXISTENT_FOLDER;
            Assert.That(path, Is.Not.Null);
            Assert.That(!Directory.Exists(path));

            var directoryValidator =
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders);
            Assert.That(directoryValidator, Is.Not.Null);
            Assert.That(directoryValidator is DirectoryPathValidator);

            Assert.That(!Directory.Exists(path));

            Assert.That(directoryValidator.ShouldSkip(path));
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> for a folder named
        /// <c>.git</c>, or a subfolder thereof, which does not meet the
        /// operational criteria.
        /// </summary>
        [Test]
        [Obsolete]
        public void Test_ShouldSkip_ReturnsTrue_ForSubfolderOfGitDir()
        {
            Assert.That(
                Directory.Exists(StringConstants.SUBFOLDER_OF_GIT_FOLDER)
            );
            Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .SUBFOLDER_OF_GIT_FOLDER
                                           )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> for a folder named
        /// <c>packages</c>, or a subfolder thereof, which does not meet the
        /// operational criteria.
        /// </summary>
        [Test]
        [Obsolete]
        public void Test_ShouldSkip_ReturnsTrue_ForSubfolderOfPackagesDir()
        {
            Assert.That(
                Directory.Exists(
                    StringConstants.SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER
                )
            );
            Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER
                                           )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> for a folder named <c>.vs</c>,
        /// or a subfolder thereof, which does not meet the operational criteria.
        /// </summary>
        [Test]
        [Obsolete]
        public void Test_ShouldSkip_ReturnsTrue_ForSubfolderOfVsDir()
        {
            Assert.That(
                Directory.Exists(StringConstants.SUBFOLDER_OF_VS_DOTFOLDER)
            );
            Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants
                                                   .SUBFOLDER_OF_VS_DOTFOLDER
                                           )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.DirectoryPathValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed whitespace for its argument.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForWhitespacePath()
            => Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .ShouldSkip(
                                               StringConstants.WHITESPACE
                                           )
            );
    }
}