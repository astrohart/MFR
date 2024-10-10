using PostSharp.Patterns.Threading;
using Alphaleonis.Win32.Filesystem;
using MFR.Expressions.Registry.Factories;
using MFR.Expressions.Registry.Interfaces;
using MFR.Settings.Configuration.Actions.Constants;
using MFR.Settings.Configuration.Actions.Factories;
using MFR.Settings.Configuration.Interfaces;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Tests.Common;
using NUnit.Framework;

namespace MFR.Settings.Configuration.Actions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.LoadConfigurationFromFileAction" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class
        LoadConfigurationFromFileActionTests : RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Asserts that a valid instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface will be loaded from
        /// the config file for the application, provided that a valid
        /// path has been supplied as input to the loading action.
        /// </summary>
        [Test]
        public void Test_ConfigurationFileLoadedSuccessfully_GivenValidPath()
        {
            var configurationFilePath = GetConfigAction
                                        .For<IRegQueryExpression<string>,
                                            IFileSystemEntry>(
                                            ConfigActionType
                                                .LoadConfigFilePathFromRegistry
                                        )
                                        .AsCachedResultAction()
                                        .WithInput(
                                            MakeNewRegQueryExpression
                                                .FromScatch<string>()
                                                .ForKeyPath(
                                                    KEY_PATH
                                                )
                                                .AndValueName(
                                                    VALUE_NAME
                                                )
                                                .WithDefaultValue(
                                                    DEFAULT_CONFIG_FILE_PATH
                                                    )
                                        )
                                        .Execute()
                                        .Path;

            Assert.That(File.Exists(configurationFilePath));

            IProjectFileRenamerConfig result = null;

            Assert.DoesNotThrow(
                () => result = GetConfigAction
                               .For<IFileSystemEntry, IProjectFileRenamerConfig>(
                                   ConfigActionType.LoadConfigFromFile
                               )
                               .WithInput(
                                   MakeNewFileSystemEntry.ForPath(
                                       configurationFilePath
                                   )
                               )
                               .Execute()
            );

            // result should be an IProjectFileRenamerConfig-implementing object
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.AssignableTo(typeof(IProjectFileRenamerConfig)));
        }
    }
}