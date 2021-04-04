using MFR.Objects.Configuration.Interfaces;
using MFR.Objects.FileSystem.Factories;
using MFR.Objects.FileSystem.Interfaces;
using MFR.Objects.Messages.Constants;
using MFR.Objects.Messages.Factories;
using NUnit.Framework;
using System.IO;

namespace MFR.Objects.Replacers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the <see cref="T:MFR.Objects.SaveConfigurationToFileCommand"/> class.
    /// </summary>
    /// <remarks>This class enables callers to provide a filename and a configuration object reference, bundled together inside a File System Entry POCO, and it is serialized to disk.</remarks>
    [TestFixture]
    public class SaveConfigurationToFileCommandTests
    {
        /// <summary>
        /// File in the root of the C: drive where the data is to be saved.
        /// </summary>
        private const string FILE_PATH = @"C:\config.json";

        /// <summary>
        /// Empty configuration object for testing.
        /// </summary>
        private static IConfiguration CONFIGURATION_DATA {
            get;
        } = new Configuration.Configuration();

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_SaveConfigurationToFile_Works_ForvalidInputs()
        {
            if (File.Exists(FILE_PATH))
                File.Delete(FILE_PATH);

            Assert.DoesNotThrow(
                () => GetCommand
                      .For<IFileSystemEntry>(
                          MessageType.SaveConfigurationToFile
                      )
                      .WithInput(
                          MakeNewFileSystemEntry.ForPath(FILE_PATH)
                                                .AndHavingUserState(
                                                    CONFIGURATION_DATA
                                                )
                      )
                      .Execute()
            );

            Assert.That(File.Exists(FILE_PATH));
        }
    }
}
