using Alphaleonis.Win32.Filesystem;
using MFR.Expressions.Registry.Factories;
using MFR.Expressions.Registry.Interfaces;
using MFR.Settings.Configuration.Actions.Constants;
using MFR.Settings.Configuration.Actions.Factories;
using MFR.Settings.Configuration.Interfaces;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Settings.Configuration.Constants;
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
    [TestFixture]
    public class
        LoadConfigurationFromFileActionTests : RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Asserts that a valid instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface will be loaded from
        /// the configuration file for the application, provided that a valid
        /// path has been supplied as input to the loading action.
        /// </summary>
        [Test]
        public void Test_ConfigurationFileLoadedSuccessfully_GivenValidPath()
        {
            var configurationFilePath = GetConfigAction
                                        .For<IRegQueryExpression<string>,
                                            IFileSystemEntry>(
                                            ConfigActionType
                                                .LoadStringFromRegistry
                                        )
                                        .AsCachedResultAction()
                                        .WithInput(
                                            MakeNewRegQueryExpression
                                                .FromScatch<string>()
                                                .ForKeyPath(
                                                    ConfigPathRegistry
                                                        .KeyName
                                                )
                                                .AndValueName(
                                                    ConfigPathRegistry
                                                        .ValueName
                                                )
                                        )
                                        .Execute()
                                        .Path;

            Assert.IsTrue(File.Exists(configurationFilePath));

            IProjectFileRenamerConfiguration result = null;

            Assert.DoesNotThrow(
                () => result = GetConfigAction
                               .For<IFileSystemEntry, IProjectFileRenamerConfiguration>(
                                   ConfigActionType.LoadConfigFromFile
                               )
                               .WithInput(
                                   MakeNewFileSystemEntry.ForPath(
                                       configurationFilePath
                                   )
                               )
                               .Execute()
            );

            // result should be an IProjectFileRenamerConfiguration-implementing object
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.AssignableTo(typeof(IProjectFileRenamerConfiguration)));
        }
    }
}
