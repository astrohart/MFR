using NUnit.Framework;
using System;
using System.IO;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods in the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.FileInfoExtensions" />
    /// class.
    /// </summary>
    [TestFixture]
    public class FileInfoExtensionsTests
    {
        [TearDown]
        public void CleanupAndInitialize()

            // before we run and before we exit, clean up any leftover temporary files
            => DebugFileAndFolderHelper.ClearTempFileDir();

        [SetUp]
        public void Initialize()
        {
            DebugFileAndFolderHelper.ClearTempFileDir();
            FileHelpers.FillWithJunk(StringConstants.EXISTING_TEMP_FILE);
        }

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void MainTestBed()
        {
            var configuration =
                ConfigurationBuilder.BuildConfigurationForUseCase(false, false);

            IFileSystemEntry newFileSystemEntry = MakeNewFileSystemEntry
                                                  .ForPath(
                                                      @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
                                                  )
                                                  .AndOperationType(
                                                      OperationType
                                                          .RenameFilesInFolder
                                                  );
            var textValueRetriever = GetTextValueRetriever.For(
                OperationType.RenameFilesInFolder
            );
            var textValue = textValueRetriever.GetTextValue(newFileSystemEntry);
            var matchExpressionFactory = GetMatchExpressionFactory
                                         .For(OperationType.RenameFilesInFolder)
                                         .AndAttachConfiguration(configuration)
                                         .ForTextValue(textValue)
                                         .ToFindWhat("Foo");
            IMatchExpression expression = matchExpressionFactory
                .AndReplaceItWith("Bar");
            ITextReplacementEngine engine = GetTextReplacementEngine
                                            .For(
                                                OperationType
                                                    .RenameFilesInFolder
                                            )
                                            .AndAttachConfiguration(
                                                configuration
                                            );
            Console.WriteLine(expression);
            Console.WriteLine(engine);

            var result = engine.Replace(expression);

            Assert.AreEqual("Bar.csproj", result);

            Console.WriteLine(result);  // Bar.csproj

            /*
             * OKAY, so now we have to glue back on, the pathname of the parent folder of the original file.
             * The RenameTo() method will only accept a fully-qualified pathname for the destination file.
             */

            var parentFolder = Path.GetDirectoryName(textValue) ?? string.Empty;
            Assert.IsFalse(string.IsNullOrWhiteSpace(parentFolder));
            result = Path.Combine(parentFolder, result);
            Assert.IsTrue(result.IsAbsolutePath());
            newFileSystemEntry.ToFileInfo()
                              .RenameTo(result);
            Assert.IsFalse(File.Exists(newFileSystemEntry.Path));
            Assert.IsTrue(File.Exists(result));
            MakeNewFileInfo.ForPath(result)
                           .RenameTo(newFileSystemEntry.Path);  // restore the file for more testing
            Assert.IsTrue(File.Exists(newFileSystemEntry.Path));
            Assert.IsFalse(File.Exists(result));
        }

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void MainTestBed_WithAllMethodCallsComposed()
        {
            var configuration =
                ConfigurationBuilder.BuildConfigurationForUseCase(false, false);

            IFileSystemEntry newFileSystemEntry = MakeNewFileSystemEntry
                                                  .ForPath(
                                                      @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
                                                  )
                                                  .AndOperationType(
                                                      OperationType
                                                          .RenameFilesInFolder
                                                  );
            var textValueRetriever = GetTextValueRetriever.For(
                OperationType.RenameFilesInFolder
            );
            var textValue = textValueRetriever.GetTextValue(newFileSystemEntry);
            var matchExpressionFactory = GetMatchExpressionFactory
                                         .For(OperationType.RenameFilesInFolder)
                                         .AndAttachConfiguration(configuration)
                                         .ForTextValue(textValue)
                                         .ToFindWhat("Foo");
            IMatchExpression expression = matchExpressionFactory
                .AndReplaceItWith("Bar");
            ITextReplacementEngine engine = GetTextReplacementEngine
                                            .For(
                                                OperationType
                                                    .RenameFilesInFolder
                                            )
                                            .AndAttachConfiguration(
                                                configuration
                                            );
            Console.WriteLine(expression);
            Console.WriteLine(engine);

            /*
             * OKAY, so now we have to glue back on, the pathname of the parent folder of the original file.
             * The RenameTo() method will only accept a fully-qualified pathname for the destination file.
             */

            Assert.IsFalse(string.IsNullOrWhiteSpace(Path.GetDirectoryName(newFileSystemEntry.Path) ?? string.Empty));
            Assert.IsTrue(Path.Combine(Path.GetDirectoryName(newFileSystemEntry.Path) ?? string.Empty, engine.Replace(expression)).IsAbsolutePath());
            newFileSystemEntry.ToFileInfo()
                              .RenameTo(Path.Combine(Path.GetDirectoryName(newFileSystemEntry.Path) ?? string.Empty, engine.Replace(expression)));
            Assert.IsFalse(File.Exists(newFileSystemEntry.Path));
            Assert.IsTrue(File.Exists(Path.Combine(Path.GetDirectoryName(newFileSystemEntry.Path) ?? string.Empty, engine.Replace(expression))));
            MakeNewFileInfo.ForPath(Path.Combine(Path.GetDirectoryName(newFileSystemEntry.Path) ?? string.Empty, engine.Replace(expression)))
                           .RenameTo(newFileSystemEntry.Path);  // restore the file for more testing
            Assert.IsTrue(File.Exists(newFileSystemEntry.Path));
            Assert.IsFalse(File.Exists(Path.Combine(Path.GetDirectoryName(newFileSystemEntry.Path) ?? string.Empty, engine.Replace(expression))));
        }

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName()
            => Assert.IsFalse(
                MakeNewFileInfo.ForPath(StringConstants.EXISTING_TEMP_FILE)
                               .RenameTo(
                                   StringConstants.NEW_TEMP_FILE_FILENAME_ONLY
                               )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_RenameTo_Works_On_ExistingTempFile()
        {
            // rename a .csproj file into a GUID and then back again
            Assert.IsTrue(File.Exists(StringConstants.EXISTING_TEMP_FILE));
            Assert.IsTrue(
                new FileInfo(StringConstants.EXISTING_TEMP_FILE).RenameTo(
                    StringConstants.NEW_TEMP_FILE
                )
            );
            Assert.IsFalse(File.Exists(StringConstants.EXISTING_TEMP_FILE));
            Assert.IsTrue(File.Exists(StringConstants.NEW_TEMP_FILE));
        }
    }
}