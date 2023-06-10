using Alphaleonis.Win32.Filesystem;
using MFR.GUI.Constants;
using NUnit.Framework;
using System;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Settings.Profiles.Providers.Actions.Obtain" /> class.
    /// </summary>
    [TestFixture]
    public class ObtainTests
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Settings.Profiles.Providers.Actions.Tests.ObtainTests" /> and
        /// returns a reference to it.
        /// </summary>
        public ObtainTests()
        {
            LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.Profiles.Providers.Actions.Obtain.ProfileCollectionFilePath" />
        /// method obtains a fully-qualified pathname to a file that exists, containing
        /// previously-saved configuration-setting profiles, and that the method copes
        /// with, e.g., the absence of the Registry key that contains the pathname of the
        /// <c>profiles.json</c> file and still provide a reasonable default.
        /// </summary>
        [Test]
        public void
            Test_Obtain_ProfileCollectionFilePath_Gets_PathOfFileThatIsNotBlank()
        {
            var result = string.Empty;

            var companyName = ProgramText.CompanyName;
            var productNameWithoutCompany =
                ProgramText.ProductNameWithoutCompany;

            Assert.DoesNotThrow(
                () =>
                {
                    result = Obtain.ProfileCollectionFilePath(
                        companyName, productNameWithoutCompany
                    );
                }
            );

            // Dump the variable result to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"ObtainTests.Test_Obtain_ProfileCollectionFilePath_Gets_PathOfFileThatIsNotBlank: result = '{result}'"
            );

            Assert.IsNotEmpty(result);

            /*
             * For the purposes of this test, we do not care whether the file
             * whose pathname we obtained exists.  We just want to make sure
             * we got a non-blank value.
             */
        }

        /// <summary>
        /// Exposes static methods to obtain data from various data sources.
        /// </summary>
        private static class Get
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
}