using PostSharp.Patterns.Threading;
using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using MFR.Expressions.Registry.Factories;
using MFR.Expressions.Registry.Interfaces;
using MFR.Expressions.Registry.Validators.Factories;
using MFR.Expressions.Registry.Validators.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Settings.Configuration.Actions.Constants;
using MFR.Settings.Configuration.Actions.Factories;
using MFR.Tests.Common;
using NUnit.Framework;
using System;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Actions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.LoadStringFromRegistryAction" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class
        LoadConfigurationFilePathFromRegistryActionTests :
            RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Actions.Tests.LoadConfigurationFilePathFromRegistryActionTests" />
        /// and returns a reference to it.
        /// </summary>
        public LoadConfigurationFilePathFromRegistryActionTests()
        {
            LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );
        }

        /// <summary>
        /// Gets the one and only instance of the Registry query expression validator that
        /// read <see cref="T:System.String" /> values  from the system Registry.
        /// </summary>
        private static IRegQueryExpressionValidator<string>
            AccessTheRegueryExpressionValidator
        {
            get;
        } = GetRegistryExpressionValidator<string>.SoleInstance();

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.LoadStringFromRegistryAction.Execute" />
        /// method
        /// correctly loads a path from the system Registry.
        /// </summary>
        [Test]
        public void Test_CanSuccessfullyObtain_AppConfigFilePath()
        {
            var configFilePathRegQueryExpression = MakeNewRegQueryExpression
                                                   .FromScatch<string>()
                                                   .ForKeyPath(KEY_PATH)
                                                   .AndValueName(VALUE_NAME)
                                                   .WithDefaultValue(
                                                       DEFAULT_CONFIG_FILE_PATH
                                                   );
            Assert.That(configFilePathRegQueryExpression, Is.Not.Null);
            Assert.That(
                AccessTheRegueryExpressionValidator
                    .ForRegQueryExpression(configFilePathRegQueryExpression)
                    .Validate()
            );

            var loadConfigFilePathFromRegistryAction = GetConfigAction
                .For<IRegQueryExpression<string>, IFileSystemEntry>(
                    ConfigActionType.LoadConfigFilePathFromRegistry
                );
            Assert.That(loadConfigFilePathFromRegistryAction, Is.Not.Null);

            loadConfigFilePathFromRegistryAction =
                loadConfigFilePathFromRegistryAction.WithInput(
                    configFilePathRegQueryExpression
                );
            Assert.That(loadConfigFilePathFromRegistryAction, Is.Not.Null);

            IFileSystemEntry configFileSystemEntry = default;

            Assert.DoesNotThrow(
                () => configFileSystemEntry =
                    loadConfigFilePathFromRegistryAction.Execute()
            );
            Assert.That(configFileSystemEntry, Is.Not.Null);

            Assert.That(!string.IsNullOrWhiteSpace(configFileSystemEntry.Path));
            Assert.That(
                ConfigFile.DefaultFilename.Equals(
                    Path.GetFileName(configFileSystemEntry.Path)
                )
            );
            Assert.That(
                DEFAULT_CONFIG_FILE_PATH, Is.EqualTo(configFileSystemEntry.Path)
            );
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