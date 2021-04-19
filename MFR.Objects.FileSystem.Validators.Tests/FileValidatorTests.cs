using Alphaleonis.Win32.Filesystem;
using MFR.Objects.Tests.Common;
using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Objects.FileSystem.Validators.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.FileValidator" />
    /// class.
    /// </summary>
    [TestFixture]
    [Log(AttributeExclude = true)]
    public class FileValidatorTests
    {
        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Objects.FileSystem.Validators.FileValidator" />.
        /// </summary>
        /// <remarks>
        /// This property is meant for fluent use.
        /// </remarks>
        private static FileValidator ThatTheFileValidatorSays
            => FileValidator.Instance;

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.FileSystem.Validators.FileValidator.ShouldSkip" />
        /// method returns <see langword="false" /> in the event that it's passed
        /// the pathname of a file that matches the operational criteria.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsFalse_ForAllowedFile()
            => Assert.IsFalse(
                ThatTheFileValidatorSays.ShouldSkip(
                    StringConstants.FILE_MATCHING_OPERATIONAL_CRITERIA
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.FileSystem.Validators.FileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> in the case that it's passed
        /// the blank/empty string as an argument.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForBlankPath()
            => Assert.IsTrue(ThatTheFileValidatorSays.ShouldSkip(string.Empty));

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.FileSystem.Validators.FileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the fully
        /// qualified pathname of a dotfile.
        /// <para />
        /// A dotfile is defined as a file whose name begins with a period (.).
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForDotfile()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    @"C:\Users\Administrator\.bash_history"
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.FileSystem.Validators.FileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the
        /// fully-qualified pathname of a file that is found in the <c>bin\</c>
        /// subfolder of a given project's directory.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInBinDir()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER
                )
            );

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInGitDir()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInObjDir()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    @"C:\Users\Administrator\source\repos\astrohart\MassFileRenamer\MFR.Objects.Tests\obj\x86\Release\.NETFramework,Version=v4.8.AssemblyAttributes.cs"
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInPackagesDir()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\packages\EntityFramework.6.4.4\EntityFramework.6.4.4.nupkg"
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInVsDir()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\.vs\PortfolioMonitor\config\applicationhost.config"
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForNullInput()
            => Assert.IsTrue(ThatTheFileValidatorSays.ShouldSkip(null));

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFile()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\sfdkjlsdfjlksdlk.txt"
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForPathWithNoFileExtension()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\LICENSE"
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(Path.GetTempFileName())
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile2()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE
                )
            );
    }
}