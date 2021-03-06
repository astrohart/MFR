using Alphaleonis.Win32.Filesystem;
using MFR.Tests.Common;
using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Validators.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.FileSystem.Validators.ProjectFileValidator" />
    /// class.
    /// </summary>
    [TestFixture]
    [Log(AttributeExclude = true)]
    public class ProjectFileValidatorTests
    {
        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.FileSystem.Validators.ProjectFileValidator" />.
        /// </summary>
        /// <remarks>
        /// This property is meant for fluent use.
        /// </remarks>
        private static ProjectFileValidator ThatTheProjectFileValidatorSays
            => ProjectFileValidator.Instance;

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="false" /> in the event that it's passed
        /// the pathname of a file that matches the operational criteria.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsFalse_ForAllowedFile()
        {
            Assert.IsTrue(
                File.Exists(StringConstants.FILE_MATCHING_OPERATIONAL_CRITERIA)
            );
            Assert.IsFalse(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.FILE_MATCHING_OPERATIONAL_CRITERIA
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> in the case that it's passed
        /// the blank/empty string as an argument.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForBlankPath()
            => Assert.IsTrue(ThatTheProjectFileValidatorSays.ShouldSkip(string.Empty));

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the fully
        /// qualified pathname of a dotfile.
        /// <para />
        /// A dotfile is defined as a file whose name begins with a period (.).
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForDotfile()
        {
            Assert.IsTrue(File.Exists(StringConstants.PATHNAME_OF_DOTFILE));
            Assert.IsTrue(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_DOTFILE
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the
        /// fully-qualified pathname of a file that is found in the <c>bin\</c>
        /// subfolder of a given project's directory.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInBinDir()
        {
            Assert.IsTrue(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER
                )
            );
            Assert.IsTrue(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that exists within the <c>.git</c> dotfolder of a Git repository.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInGitDir()
        {
            Assert.IsTrue(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER
                )
            );
            Assert.IsTrue(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when the pathname of a file
        /// that is inside the <c>obj\</c> subfolder of a project is passed to it.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInObjDir()
        {
            Assert.IsTrue(
                File.Exists(
                    StringConstants
                        .PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER
                )
            );
            Assert.IsTrue(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants
                        .PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when provided the pathname of
        /// a file under the <c>packages\</c> folder of a solution as its input.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInPackagesDir()
        {
            Assert.IsTrue(
                File.Exists(
                    StringConstants
                        .PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER
                )
            );
            Assert.IsTrue(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants
                        .PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file located under the <c>.vs\</c> subfolder of a solution.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInVsDir()
        {
            Assert.IsTrue(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_VS_DOTFOLDER
                )
            );
            Assert.IsTrue(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_VS_DOTFOLDER
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the
        /// <see
        ///     langword="null" />
        /// string for its argument.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForNullInput()
            => Assert.IsTrue(ThatTheProjectFileValidatorSays.ShouldSkip(null));

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that is guaranteed not to exist on the disk.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFile()
        {
            Assert.IsFalse(File.Exists(StringConstants.NONEXISTENT_FILE));
            Assert.IsTrue(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.NONEXISTENT_FILE
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that has no extension.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForPathWithNoFileExtension()
        {
            Assert.IsTrue(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_HAVING_NO_EXTENSION
                )
            );
            Assert.IsTrue(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_FILE_HAVING_NO_EXTENSION
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that has zero length.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile()
            => Assert.IsTrue(
                ThatTheProjectFileValidatorSays.ShouldSkip(Path.GetTempFileName())
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that has zero length.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile2()
        {
            Assert.IsTrue(
                File.Exists(StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE)
            );
            Assert.IsTrue(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE
                )
            );
        }
    }
}
