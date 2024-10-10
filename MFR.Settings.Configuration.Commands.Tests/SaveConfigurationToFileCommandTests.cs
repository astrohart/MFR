using PostSharp.Patterns.Threading;
using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Settings.Configuration.Commands.Constants;
using MFR.Settings.Configuration.Commands.Factories;
using MFR.Settings.Configuration.Factories;
using MFR.Settings.Configuration.Interfaces;
using NUnit.Framework;

namespace MFR.Settings.Configuration.Commands.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.SaveConfigurationToFileCommand" />
    /// class.
    /// </summary>
    /// <remarks>
    /// This class enables callers to provide a filename and a config
    /// object reference, bundled together inside a File System Entry POCO, and
    /// it is serialized to disk.
    /// </remarks>
    [TestFixture, ExplicitlySynchronized]
    public class SaveConfigurationToFileCommandTests
    {
        /// <summary>
        /// File in the root of the C: drive where the data is to be saved.
        /// </summary>
        private const string FILE_PATH = @"C:\config.json";

        /// <summary>
        /// Empty config object for testing.
        /// </summary>
        private static IProjectFileRenamerConfig BlankConfig
        {
            get;
        } = GetBlankProjectFileRenamerConfig.SoleInstance();

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_SaveConfigurationToFile_Works_ForvalidInputs()
        {
            if (File.Exists(FILE_PATH))
                File.Delete(FILE_PATH);

            Assert.DoesNotThrow(
                () =>
                {
                    var fileSystemEntry = MakeNewFileSystemEntry
                                          .ForPath(FILE_PATH)
                                          .SetUserState(BlankConfig);
                    if (fileSystemEntry == null) return;

                    var saveConfigurationFileCommand = GetConfigurationCommand
                        .For<IFileSystemEntry>(
                            ConfigurationCommandType.SaveConfigurationToFile
                        )
                        .WithInput(fileSystemEntry);
                    if (saveConfigurationFileCommand == null) return;

                    saveConfigurationFileCommand.Execute();
                }
            );

            Assert.That(File.Exists(FILE_PATH));
        }
    }
}