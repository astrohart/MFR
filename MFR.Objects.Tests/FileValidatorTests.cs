using MFR.Objects.Tests.Common;
using NUnit.Framework;
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
    public class FileValidatorTests
    {
        private static FileValidator ThatTheFileValidatorSays
            => FileValidator.Instance;

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsFalse_ForAllowedFile()
            => Assert.IsFalse(
                ThatTheFileValidatorSays.ShouldSkip(
                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.PaymentMethods.Tests\CoinbasePaymentMethodsTests.cs"
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForBlankPath()
            => Assert.IsTrue(ThatTheFileValidatorSays.ShouldSkip(string.Empty));

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForDotfile()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    @"C:\Users\Administrator\.bash_history"
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInBinDir()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    @"C:\Users\Administrator\source\repos\astrohart\MassFileRenamer\MFR.Objects.Tests\bin\x86\Release\Newtonsoft.Json.dll"
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInGitDir()
            => Assert.IsTrue(
                ThatTheFileValidatorSays.ShouldSkip(
                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\.git\index.old.2"
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