using PostSharp.Patterns.Threading;
using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Validators.Interfaces;
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
    [TestFixture, ExplicitlySynchronized]
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
        private static IFileSystemEntryValidator ThatTheProjectFileValidatorSays
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
            Assert.That(
                File.Exists(StringConstants.FILE_MATCHING_OPERATIONAL_CRITERIA)
            );
            Assert.That(!
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
            => Assert.That(ThatTheProjectFileValidatorSays.ShouldSkip(string.Empty));

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
            Assert.That(File.Exists(StringConstants.PATHNAME_OF_DOTFILE));
            Assert.That(
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
            Assert.That(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER
                )
            );
            Assert.That(
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
            Assert.That(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER
                )
            );
            Assert.That(
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
            Assert.That(
                File.Exists(
                    StringConstants
                        .PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER
                )
            );
            Assert.That(
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
            Assert.That(
                File.Exists(
                    StringConstants
                        .PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER
                )
            );
            Assert.That(
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
            Assert.That(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_VS_DOTFOLDER
                )
            );
            Assert.That(
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
            => Assert.That(ThatTheProjectFileValidatorSays.ShouldSkip(null));

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that is guaranteed not to exist on the file system.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFile()
        {
            Assert.That(!File.Exists(StringConstants.NONEXISTENT_FILE));
            Assert.That(
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
            Assert.That(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_HAVING_NO_EXTENSION
                )
            );
            Assert.That(
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
            => Assert.That(
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
            Assert.That(
                File.Exists(StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE)
            );
            Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE
                )
            );
        }
    }
}