using Alphaleonis.Win32.Filesystem;
using MFR.Settings.Configuration.Commands.Constants;
using MFR.Settings.Configuration.Commands.Factories;
using MFR.Settings.Configuration.Interfaces;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Constants;
using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Factories;
using NUnit.Framework;

namespace MFR.Replacers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.SaveConfigurationToFileCommand" />
    /// class.
    /// </summary>
    /// <remarks>
    /// This class enables callers to provide a filename and a projectFileRenamerConfiguration
    /// object reference, bundled together inside a File System Entry POCO, and
    /// it is serialized to disk.
    /// </remarks>
    [TestFixture]
    public class SaveConfigurationToFileCommandTests
    {
        /// <summary>
        /// File in the root of the C: drive where the data is to be saved.
        /// </summary>
        private const string FILE_PATH = @"C:\config.json";

        /// <summary>
        /// Empty projectFileRenamerConfiguration object for testing.
        /// </summary>
        private static IProjectFileRenamerConfiguration ProjectFileRenamerConfigurationData
        {
            get;
        } = MakeNewConfiguration.FromScratch();

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_SaveConfigurationToFile_Works_ForvalidInputs()
        {
            if (File.Exists(FILE_PATH))
                File.Delete(FILE_PATH);

            Assert.DoesNotThrow(
                () => GetConfigurationCommand
                      .For<IFileSystemEntry>(
                          ConfigurationCommandType.SaveConfigurationToFile
                      )
                      .WithInput(
                          MakeNewFileSystemEntry.ForPath(FILE_PATH)
                                                .AndHavingUserState(
                                                    ProjectFileRenamerConfigurationData
                                                )
                      )
                      .Execute()
            );

            Assert.That(File.Exists(FILE_PATH));
        }
    }
}
