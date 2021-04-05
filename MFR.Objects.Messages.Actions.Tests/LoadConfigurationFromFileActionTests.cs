using MFR.Objects.Configuration.Interfaces;
using MFR.Objects.FileSystem.Factories;
using MFR.Objects.FileSystem.Interfaces;
using MFR.Objects.Messages.Constants;
using MFR.Objects.Messages.Factories;
using MFR.Objects.Tests.Common;
using NUnit.Framework;
using System.IO;

namespace MFR.Objects.Messages.Actions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.LoadConfigurationFromFileAction" />
    /// class.
    /// </summary>
    [TestFixture]
    public class
        LoadConfigurationFromFileActionTests : RegistryDataExchangeTestsBase
    {
        /// <summary>
        /// Asserts that a valid instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IConfiguration" />
        /// interface will be
        /// loaded from the configuration file for the application, provided
        /// that a valid path has been supplied as input to the loading action.
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
                () => result = GetAction
                               .For<IFileSystemEntry, IConfiguration>(
                                   MessageType.LoadConfigurationFromFile
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
