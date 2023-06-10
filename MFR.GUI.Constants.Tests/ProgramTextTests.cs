using Alphaleonis.Win32.Filesystem;
using NUnit.Framework;
using System;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Constants.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.GUI.Constants.ProgramText" /> class.
    /// </summary>
    [TestFixture]
    public class ProgramTextTests
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Constants.Tests.ProgramTextTests" /> and returns a
        /// reference to it.
        /// </summary>
        public ProgramTextTests()
        {
            LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );
        }

        /// <summary>
        /// Asserts that the value of the
        /// <see cref="P:MFR.GUI.Constants.ProgramText.CompanyName" /> property does not
        /// throw any exceptions (which it has been doing as of late) and that it returns a
        /// non-blank value.
        /// value.
        /// </summary>
        [Test]
        public void
            Test_CompanyName_Property_DoesNotThrow_And_ReturnsValidValue()
        {
            var result = string.Empty;

            Assert.DoesNotThrow(() => result = ProgramText.CompanyName);

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"ProgramTextTests.Test_CompanyName_Property_ReturnsValidValue: Result = '{result}'"
            );

            Assert.IsNotEmpty(result);
        }

        /// <summary>
        /// Asserts that the value of the
        /// <see cref="P:MFR.GUI.Constants.ProgramText.ProductName" /> property does not
        /// throw any exceptions (which it has been doing as of late) and that it returns a
        /// non-blank value.
        /// value.
        /// </summary>
        [Test]
        public void
            Test_ProductName_Property_DoesNotThrow_And_ReturnsValidValue()
        {
            var result = string.Empty;

            Assert.DoesNotThrow(() => result = ProgramText.ProductName);

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"ProgramTextTests.Test_ProductName_Property_ReturnsValidValue: Result = '{result}'"
            );

            Assert.IsNotEmpty(result);
        }
    }

    /// <summary>
    /// Exposes static methods to obtain data from various data sources.
    /// </summary>
    internal static class Get
    {
        /// <summary>
        /// A <see cref="T:System.String" /> containing the final piece of the path of the
        /// log file.
        /// </summary>
        private static readonly string LOG_FILE_PATH_TERMINATOR =
            $@"{AssemblyCompany}\{AssemblyProduct}\Logs\{AssemblyTitle}_log.txt";

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the product name defined
        /// for this application.
        /// </summary>
        /// <remarks>
        /// This property is really an alias for the
        /// <see cref="P:AssemblyMetadata.AssemblyCompany" /> property.
        /// </remarks>
        private static string AssemblyCompany
            => AssemblyMetadata.AssemblyCompany;

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the product name defined
        /// for this application.
        /// </summary>
        /// <remarks>
        /// This property is really an alias for the
        /// <see cref="P:AssemblyMetadata.AssemblyProduct" /> property.
        /// </remarks>
        private static string AssemblyProduct
            => AssemblyMetadata.AssemblyProduct.Replace(
                "xyLOGIX ", string.Empty
            );

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the assembly title defined
        /// for this application.
        /// </summary>
        /// <remarks>
        /// This property is really an alias for the
        /// <see cref="P:AssemblyMetadata.AssemblyTitle" /> property.
        /// </remarks>
        private static string AssemblyTitle
            => AssemblyMetadata.AssemblyTitle.Replace(" ", "_");

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains a user-friendly name for
        /// the software product of which this application or class library is a part.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains a user-friendly name
        /// for the software product of which this application or class library is a part.
        /// </returns>
        public static string ApplicationProductName()
        {
            string result;

            try
            {
                result = AssemblyProduct;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Obtains a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file that should be used for logging messages.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file that should be used for logging messages.
        /// </returns>
        public static string LogFilePath()
            => Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.CommonApplicationData
                ), LOG_FILE_PATH_TERMINATOR
            );
    }
}