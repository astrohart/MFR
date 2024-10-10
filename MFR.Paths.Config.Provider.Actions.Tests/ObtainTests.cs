using PostSharp.Patterns.Threading;
using Alphaleonis.Win32.Filesystem;
using NUnit.Framework;
using System;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Config.Provider.Actions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Settings.Profiles.Providers.Actions.Obtain" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class ObtainTests
    {
        /// <summary>
        /// A <see cref="T:System.String" /> that contains the application's company name.
        /// </summary>
        private const string CompanyName = "xyLOGIX, LLC";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains the application's product name.
        /// </summary>
        private const string ProductNameWithoutCompany = "Project File Renamer";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains the default place we, ideally,
        /// want to store the user's profiles -- their local AppData directory.
        /// </summary>
        private static readonly string DefaultConfigPath =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                ), @"xyLOGIX, LLC\Project File Renamer\Config\config.json"
            );

        /// <summary>
        /// Keep this value updated with whatever is stored in the system Registry
        /// under the ConfigPath value of the
        /// Computer\HKEY_CURRENT_USER\SOFTWARE\xyLOGIX, LLC\Project File Renamer\Paths
        /// Registry key.
        /// </summary>
        private static readonly string ExpectedConfigPath =
            Read.RegistryValue(
                @"SOFTWARE\xyLOGIX, LLC\Project File Renamer\Paths",
                "ConfigFile"
            );

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Paths.Config.Provider.Actions.Tests.ObtainTests" /> and
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
        ///     cref="F:MFR.Paths.Config.Provider.Actions.Tests.ObtainTests.DefaultConfigPath" />
        /// field's value is non-blank, well-formed, and does not throw exceptions when
        /// it's computed.
        /// </summary>
        [Test]
        public void
            Test_DefaultConfigPath_IsWellFormed_AndDoesNotThrowExceptions()
        {
            var hashCode = -1;
            Assert.DoesNotThrow(
                () =>
                {
                    hashCode = DefaultConfigPath.GetHashCode();
                }
            );

            // Dump the variable hashCode to the console
            Console.WriteLine($"[  DEBUG  ]  hashCode = {hashCode}");

            Assert.That(DefaultConfigPath, Is.Not.Empty);

            // Dump the variable DefaultConfigPath to the console
            Console.WriteLine(
                $"[  DEBUG  ]  DefaultConfigPath = '{DefaultConfigPath}'"
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="F:MFR.Paths.Config.Provider.Actions.Tests.ObtainTests.ExpectedConfigPath" />
        /// field's value is non-blank, well-formed, and does not throw exceptions when
        /// it's evaluated.
        /// </summary>
        [Test]
        public void
            Test_ExpectedConfigPath_IsWellFormed_AndDoesNotThrowExceptions()
        {
            var hashCode = -1;
            Assert.DoesNotThrow(
                () =>
                {
                    hashCode = ExpectedConfigPath.GetHashCode();
                }
            );
            Assert.That(ExpectedConfigPath, Is.Not.Empty);

            // Dump the variable hashCode to the console
            Console.WriteLine($"[  DEBUG  ]  hashCode = {hashCode}");

            // Dump the variable ExpectedConfigPath to the console
            Console.WriteLine(
                $"[  DEBUG  ]  ExpectedConfigPath = '{ExpectedConfigPath}'"
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.Profiles.Providers.Actions.Obtain.ConfigFilePath" />
        /// method obtains a fully-qualified pathname to a file that exists, containing
        /// the application configuration, and that the method copes with, e.g., the absence
        /// of the Registry key that contains the pathname of the <c>config.json</c> file's
        /// pathname from the system Registry and still provide a reasonable default.
        /// </summary>
        [Test]
        public void
            Test_Obtain_ConfigFilePath_Gets_PathOfFileThatIsNotBlank()
        {
            var result = string.Empty;

            Assert.DoesNotThrow(
                () =>
                {
                    result = Obtain.ConfigFilePath(
                        CompanyName, ProductNameWithoutCompany
                    );
                }
            );

            // Dump the variable result to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"ObtainTests.Test_Obtain_ConfigFilePath_Gets_PathOfFileThatIsNotBlank: result = '{result}'"
            );

            Assert.That(result, Is.Not.Empty);
            Assert.That(ExpectedConfigPath, Is.EqualTo(result));

            /*
             * For the purposes of this test, we do not care whether the file
             * whose pathname we obtained exists.  We just want to make sure
             * we got a non-blank value.
             */
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.Profiles.Providers.Actions.Obtain.ConfigFilePath" />
        /// method successfully obtains the fully-qualified pathname to the
        /// <c>profiles.json</c> file on the user's computer.
        /// </summary>
        [Test]
        public void
            Test_Obtain_ConfigFilePath_UsesInputtedFilePath_ThatExists_UsingDefaultValue()
        {
            Assert.That(DefaultConfigPath, Is.Not.Empty);
            Assert.That(File.Exists(DefaultConfigPath));

            var result = string.Empty;

            Assert.DoesNotThrow(
                () => result = Obtain.ConfigFilePath(
                    CompanyName, ProductNameWithoutCompany,
                    DefaultConfigPath
                )
            );

            Assert.That(result, Is.Not.Empty);
            Assert.That(DefaultConfigPath, Is.EqualTo(result));
            Assert.That(File.Exists(result));
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.Profiles.Providers.Actions.Obtain.ConfigFilePath" />
        /// method successfully obtains the fully-qualified pathname to the
        /// <c>profiles.json</c> file on the user's computer.
        /// <para />
        /// This unit test does not supply the pathname of a default value.
        /// </summary>
        [Test]
        public void
            Test_Obtain_ConfigFilePath_UsesInputtedFilePath_ThatExists_WithNoDefaultProvided()
        {
           var result = string.Empty;

            Assert.DoesNotThrow(
                () => result = Obtain.ConfigFilePath(
                    CompanyName, ProductNameWithoutCompany,
                    string.Empty /* being explicit */
                )
            );

            Assert.That(result, Is.Not.Empty);
            Assert.That(DefaultConfigPath, Is.EqualTo(result));
            Assert.That(File.Exists(result));
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