using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Events;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using NUnit.Framework;
using System;
using System.IO;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Providers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigurationProvider" />
    /// class.
    /// </summary>
    [TestFixture]
    public class ProjectFileRenamerConfigurationProviderTests
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Tests.ProjectFileRenamerConfigurationProviderTests" />
        /// and returns a reference to it.
        /// </summary>
        public ProjectFileRenamerConfigurationProviderTests()
        {
            LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );

            InitializeProjectFileRenamerConfigurationProvider();
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface that allows access to the currently-loaded application configuration.
        /// </summary>
        private static IProjectFileRenamerConfiguration CurrentConfiguration
            => ProjectFileRenamerConfigurationProvider.CurrentConfiguration;

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface that provides access to this application's configuration.
        /// </summary>
        private static IProjectFileRenamerConfigurationProvider
            ProjectFileRenamerConfigurationProvider
        {
            get;
        } = GetProjectFileRenamerConfigurationProvider.SoleInstance();

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider.Load" />
        /// method functions properly and actually loads a configuration object.
        /// </summary>
        [Test]
        public void Test_Load_Works()
        {
            Assert.DoesNotThrow(
                () => ProjectFileRenamerConfigurationProvider.Load()
            );
            Assert.IsNotNull(CurrentConfiguration);
            Assert.IsNotEmpty(
                ProjectFileRenamerConfigurationProvider.ConfigurationFilePath
            );
            Assert.IsTrue( /* Check that the config was actually loaded from a file. */
                File.Exists(
                    ProjectFileRenamerConfigurationProvider
                        .ConfigurationFilePath
                )
            );

            // Dump the variable CurrentConfiguration.FindWhat to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"ProjectFileRenamerConfigurationProviderTests.Test_Load_Works: CurrentConfiguration.FindWhat = '{CurrentConfiguration.FindWhat}'"
            );
        }

        private static void
            OnProjectFileRenamerConfigurationProviderConfigurationFilePathChanged(
                object sender, ConfigurationFilePathChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Pathname)) return;
            if (!File.Exists(e.Pathname)) return;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: The configuration file's new pathname is: '{e.Pathname}'."
            );
        }

        private static void
            OnProjectFileRenamerConfigurationProviderConfigurationLoaded(
                object sender, EventArgs e)
            => DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** The configuration file has been loaded from '{ProjectFileRenamerConfigurationProvider.ConfigurationFilePath}'."
            );

        private static void
            OnProjectFileRenamerConfigurationProviderConfigurationLoadFailed(
                object sender, ConfigurationLoadFailedEventArgs e)
        {
            DebugUtils.WriteLine(
                DebugLevel.Error,
                "*** ERROR *** Failed to load the configuration file for the application."
            );

            // dump all the exception info to the log
            DebugUtils.LogException(e.Exception);
        }

        /// <summary>
        /// Initializes the project file renamer configuration provider object.
        /// </summary>
        private void InitializeProjectFileRenamerConfigurationProvider()
        {
            ProjectFileRenamerConfigurationProvider
                    .ConfigurationFilePathChanged +=
                OnProjectFileRenamerConfigurationProviderConfigurationFilePathChanged;
            ProjectFileRenamerConfigurationProvider.ConfigurationLoadFailed +=
                OnProjectFileRenamerConfigurationProviderConfigurationLoadFailed;
            ProjectFileRenamerConfigurationProvider.ConfigurationLoaded +=
                OnProjectFileRenamerConfigurationProviderConfigurationLoaded;
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