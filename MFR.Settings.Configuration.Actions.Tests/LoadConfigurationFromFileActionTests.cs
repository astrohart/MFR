using Alphaleonis.Win32.Filesystem;
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
    [TestFixture]
    public class
        LoadConfigurationFromFileActionTests : RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Asserts that a valid instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IConfiguration" />
        /// interface will be loaded from
        /// the configuration file for the application, provided that a valid
        /// path has been supplied as input to the loading action.
        /// </summary>
        [Test]
        public void Test_ConfigurationFileLoadedSuccessfully_GivenValidPath()
        {
            var configurationFilePath = Path.Combine(
                CONFIG_FILE_DIR, CONFIG_FILE_NAME
            );

            Assert.IsTrue(File.Exists(configurationFilePath));

            IConfiguration result = null;

            Assert.DoesNotThrow(
                () => result = GetConfigurationAction
                               .For<IFileSystemEntry, IConfiguration>(
                                   ConfigurationAction.LoadConfigurationFromFile
                               )
                               .WithInput(
                                   MakeNewFileSystemEntry.ForPath(
                                       configurationFilePath
                                   )
                               )
                               .Execute()
            );

            // result should be an IConfiguration-implementing object
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.AssignableTo(typeof(IConfiguration)));
        }
    }
}