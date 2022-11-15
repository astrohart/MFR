using Alphaleonis.Win32.Filesystem;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using MFR.Engines.Replacement.Factories;
using MFR.Engines.Replacement.Intefaces;
using MFR.Expressions.Matches.Factories;
using MFR.Expressions.Matches.Interfaces;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Creators;
using MFR.Operations.Constants;
using MFR.Tests.Common;
using MFR.TextValues.Retrievers.Factories;
using NUnit.Framework;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.FileSystem.Helpers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods in the
    /// <see
    ///     cref="T:MFR.FileInfoExtensions" />
    /// class.
    /// </summary>
    [TestFixture]
    public class FileInfoExtensionsTests
    {
        /// <summary>
        /// Called to both clean up after this test fixture's tests have run.
        /// </summary>
        /// <remarks>
        /// The current implementation of this method simply removes all files
        /// and folders (that it can) from the user's TEMP folder.
        /// </remarks>
        [TearDown]
        public void Cleanup()

            // before we run and before we exit, clean up any leftover temporary files
            => DebugFileAndFolderHelper.ClearTempFileDir();

        /// <summary>
        /// Prepares this test fixture for test execution.
        /// </summary>
        /// <remarks>
        /// The current implementation of this method clears files and folders
        /// from the user's TEMP folder, and then fills a file with random junk.
        /// </remarks>
        [SetUp]
        public void Initialize()
        {
            DebugFileAndFolderHelper.ClearTempFileDir();
            FileHelpers.FillTextFileWithJunk(StringConstants.EXISTING_TEMP_FILE);
        }

        /// <summary>
        /// Serves as a test bed to run the entire algorithm of renaming
        /// projects without having to invoke the GUI.
        /// </summary>
        [Test]
        public void MainTestBed()
        {
            Assert.Pass();

            /*
            var configuration =
                ConfigurationBuilder.BuildConfigurationForUseCase(
                    true, /* match case
                    true
                ); /* match whole word
            */

            ConfigurationProvider.Load();

            IFileSystemEntry newFileSystemEntry = MakeNewFileSystemEntry
                                                  .ForPath(
                                                      @"C:\Users\Administrator\source\junk\MyJunkSolution\FizzBuzz\FizzBuzz.csproj"
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
                                         .AndAttachConfiguration(ConfigurationProvider.CurrentConfiguration)
                                         .ForTextValue(textValue)
                                         .ToFindWhat("FizzBuzz");
            IMatchExpression expression = matchExpressionFactory
                .AndReplaceItWith("FizzBlazzle");
            ITextReplacementEngine engine = GetTextReplacementEngine
                                            .For(
                                                OperationType
                                                    .RenameFilesInFolder
                                            )
                                            .AndAttachConfiguration(
                                                ConfigurationProvider.CurrentConfiguration
                                            );
            Console.WriteLine(expression);
            Console.WriteLine(engine);

            var result = engine.Replace(expression);

            Assert.AreEqual("FizzBlazzle.csproj", result);

            Console.WriteLine(result); // FizzBlazzle.csproj

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
                           .RenameTo(
                               newFileSystemEntry.Path
                           ); // restore the file for more testing
            Assert.IsTrue(File.Exists(newFileSystemEntry.Path));
            Assert.IsFalse(File.Exists(result));
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user configuration and the actions
        /// associated with it.
        /// </remarks>
        private static IConfigurationProvider ConfigurationProvider
            => GetConfigurationProvider.SoleInstance();

        /// <summary>
        /// Serves as a test bed to run the entire algorithm of renaming
        /// projects without having to invoke the GUI.
        /// </summary>
        /// <remarks>
        /// This method is different from the
        /// <see
        ///     cref="M:MFR.FileSystem.Helpers.Tests.FileInfoExtensionsTests.MainTestBed" />
        /// method in that it uses the fluent composition of objects -- rather
        /// than initializing individual variables with the results -- to test
        /// how the algorithms work when methods are called as they are in the
        /// production code, i.e., in a fluent manner.
        /// </remarks>
        [Test]
        public void MainTestBed_WithAllMethodCallsComposed()
        {
            Assert.Pass();

            /*
             * OKAY, so now we have to glue back on, the pathname of the parent folder of the original file.
             * The RenameTo() method will only accept a fully-qualified pathname for the destination file.
             */

            Assert.IsFalse(
                string.IsNullOrWhiteSpace(
                    Path.GetDirectoryName(
                        ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                            )
                            .AndOperationType(
                                OperationType.RenameFilesInFolder
                            )).Path
                    ) ?? string.Empty
                )
            );
            Assert.IsTrue(
                Path.Combine(
                        Path.GetDirectoryName(
                            ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                )
                                .AndOperationType(
                                    OperationType.RenameFilesInFolder
                                )).Path
                        ) ?? string.Empty,
                        ((ITextReplacementEngine)GetTextReplacementEngine
                                                 .For(
                                                     OperationType
                                                         .RenameFilesInFolder
                                                 )
                                                 .AndAttachConfiguration(
                                                     ConfigurationBuilder
                                                         .BuildConfigurationForUseCase(
                                                             false, false
                                                         )
                                                 )).Replace(
                            (IMatchExpression)GetMatchExpressionFactory
                                              .For(
                                                  OperationType
                                                      .RenameFilesInFolder
                                              )
                                              .AndAttachConfiguration(
                                                  ConfigurationBuilder
                                                      .BuildConfigurationForUseCase(
                                                          false, false
                                                      )
                                              )
                                              .ForTextValue(
                                                  GetTextValueRetriever
                                                      .For(
                                                          OperationType
                                                              .RenameFilesInFolder
                                                      )
                                                      .GetTextValue(
                                                          (IFileSystemEntry)
                                                          MakeNewFileSystemEntry
                                                              .ForPath(
                                                                  @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                                              )
                                                              .AndOperationType(
                                                                  OperationType
                                                                      .RenameFilesInFolder
                                                              )
                                                      )
                                              )
                                              .ToFindWhat("MFR.Directories.Validators.Constants.Generators")
                                              .AndReplaceItWith("Bar")
                        )
                    )
                    .IsAbsolutePath()
            );
            ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                        @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                    )
                    .AndOperationType(OperationType.RenameFilesInFolder))
                .ToFileInfo()
                .RenameTo(
                    Path.Combine(
                        Path.GetDirectoryName(
                            ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                )
                                .AndOperationType(
                                    OperationType.RenameFilesInFolder
                                )).Path
                        ) ?? string.Empty,
                        ((ITextReplacementEngine)GetTextReplacementEngine
                                                 .For(
                                                     OperationType
                                                         .RenameFilesInFolder
                                                 )
                                                 .AndAttachConfiguration(
                                                     ConfigurationBuilder
                                                         .BuildConfigurationForUseCase(
                                                             false, false
                                                         )
                                                 )).Replace(
                            (IMatchExpression)GetMatchExpressionFactory
                                              .For(
                                                  OperationType
                                                      .RenameFilesInFolder
                                              )
                                              .AndAttachConfiguration(
                                                  ConfigurationBuilder
                                                      .BuildConfigurationForUseCase(
                                                          false, false
                                                      )
                                              )
                                              .ForTextValue(
                                                  GetTextValueRetriever
                                                      .For(
                                                          OperationType
                                                              .RenameFilesInFolder
                                                      )
                                                      .GetTextValue(
                                                          (IFileSystemEntry)
                                                          MakeNewFileSystemEntry
                                                              .ForPath(
                                                                  @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                                              )
                                                              .AndOperationType(
                                                                  OperationType
                                                                      .RenameFilesInFolder
                                                              )
                                                      )
                                              )
                                              .ToFindWhat("MFR.Directories.Validators.Constants.Generators")
                                              .AndReplaceItWith("Bar")
                        )
                    )
                );
            Assert.IsFalse(
                File.Exists(
                    ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                        )
                        .AndOperationType(OperationType.RenameFilesInFolder))
                    .Path
                )
            );
            Assert.IsTrue(
                File.Exists(
                    Path.Combine(
                        Path.GetDirectoryName(
                            ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                )
                                .AndOperationType(
                                    OperationType.RenameFilesInFolder
                                )).Path
                        ) ?? string.Empty,
                        ((ITextReplacementEngine)GetTextReplacementEngine
                                                 .For(
                                                     OperationType
                                                         .RenameFilesInFolder
                                                 )
                                                 .AndAttachConfiguration(
                                                     ConfigurationBuilder
                                                         .BuildConfigurationForUseCase(
                                                             false, false
                                                         )
                                                 )).Replace(
                            (IMatchExpression)GetMatchExpressionFactory
                                              .For(
                                                  OperationType
                                                      .RenameFilesInFolder
                                              )
                                              .AndAttachConfiguration(
                                                  ConfigurationBuilder
                                                      .BuildConfigurationForUseCase(
                                                          false, false
                                                      )
                                              )
                                              .ForTextValue(
                                                  GetTextValueRetriever
                                                      .For(
                                                          OperationType
                                                              .RenameFilesInFolder
                                                      )
                                                      .GetTextValue(
                                                          (IFileSystemEntry)
                                                          MakeNewFileSystemEntry
                                                              .ForPath(
                                                                  @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                                              )
                                                              .AndOperationType(
                                                                  OperationType
                                                                      .RenameFilesInFolder
                                                              )
                                                      )
                                              )
                                              .ToFindWhat("MFR.Directories.Validators.Constants.Generators")
                                              .AndReplaceItWith("Bar")
                        )
                    )
                )
            );
            MakeNewFileInfo.ForPath(
                               Path.Combine(
                                   Path.GetDirectoryName(
                                       ((IFileSystemEntry)MakeNewFileSystemEntry
                                           .ForPath(
                                               @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                           )
                                           .AndOperationType(
                                               OperationType.RenameFilesInFolder
                                           )).Path
                                   ) ?? string.Empty,
                                   ((ITextReplacementEngine)
                                       GetTextReplacementEngine.For(
                                               OperationType.RenameFilesInFolder
                                           )
                                           .AndAttachConfiguration(
                                               ConfigurationBuilder
                                                   .BuildConfigurationForUseCase(
                                                       false, false
                                                   )
                                           )).Replace(
                                       (IMatchExpression)
                                       GetMatchExpressionFactory.For(
                                               OperationType.RenameFilesInFolder
                                           )
                                           .AndAttachConfiguration(
                                               ConfigurationBuilder
                                                   .BuildConfigurationForUseCase(
                                                       false, false
                                                   )
                                           )
                                           .ForTextValue(
                                               GetTextValueRetriever.For(
                                                       OperationType
                                                           .RenameFilesInFolder
                                                   )
                                                   .GetTextValue(
                                                       (IFileSystemEntry)
                                                       MakeNewFileSystemEntry
                                                           .ForPath(
                                                               @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                                           )
                                                           .AndOperationType(
                                                               OperationType
                                                                   .RenameFilesInFolder
                                                           )
                                                   )
                                           )
                                           .ToFindWhat("MFR.Directories.Validators.Constants.Generators")
                                           .AndReplaceItWith("Bar")
                                   )
                               )
                           )
                           .RenameTo(
                               ((IFileSystemEntry)MakeNewFileSystemEntry
                                                  .ForPath(
                                                      @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                                  )
                                                  .AndOperationType(
                                                      OperationType
                                                          .RenameFilesInFolder
                                                  )).Path
                           ); // restore the file for more testing
            Assert.IsTrue(
                File.Exists(
                    ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                        )
                        .AndOperationType(OperationType.RenameFilesInFolder))
                    .Path
                )
            );
            Assert.IsFalse(
                File.Exists(
                    Path.Combine(
                        Path.GetDirectoryName(
                            ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                )
                                .AndOperationType(
                                    OperationType.RenameFilesInFolder
                                )).Path
                        ) ?? string.Empty,
                        ((ITextReplacementEngine)GetTextReplacementEngine
                                                 .For(
                                                     OperationType
                                                         .RenameFilesInFolder
                                                 )
                                                 .AndAttachConfiguration(
                                                     ConfigurationBuilder
                                                         .BuildConfigurationForUseCase(
                                                             false, false
                                                         )
                                                 )).Replace(
                            (IMatchExpression)GetMatchExpressionFactory
                                              .For(
                                                  OperationType
                                                      .RenameFilesInFolder
                                              )
                                              .AndAttachConfiguration(
                                                  ConfigurationBuilder
                                                      .BuildConfigurationForUseCase(
                                                          false, false
                                                      )
                                              )
                                              .ForTextValue(
                                                  GetTextValueRetriever
                                                      .For(
                                                          OperationType
                                                              .RenameFilesInFolder
                                                      )
                                                      .GetTextValue(
                                                          (IFileSystemEntry)
                                                          MakeNewFileSystemEntry
                                                              .ForPath(
                                                                  @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\MFR.Directories.Validators.Constants.Generators\MFR.Directories.Validators.Constants.Generators.csproj"
                                                              )
                                                              .AndOperationType(
                                                                  OperationType
                                                                      .RenameFilesInFolder
                                                              )
                                                      )
                                              )
                                              .ToFindWhat("MFR.Directories.Validators.Constants.Generators")
                                              .AndReplaceItWith("Bar")
                        )
                    )
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Helpers.FileInfoExtensions.IsZeroLengthFile" />
        /// method returns <see langword="false" /> when fed the path to the
        /// Windows Notepad utility --- which we know not to be a zero-length
        /// file, since it's a Windows Application.
        /// </summary>
        [Test]
        public void Test_IsZeroLengthFile_ReturnsFalse_ForPathOfNotepadApp()
        {
            Assert.IsTrue(File.Exists(StringConstants.NOTEPAD_PATH));
            Assert.IsFalse(
                MakeNewFileInfo.ForPath(StringConstants.NOTEPAD_PATH)
                               .IsZeroLengthFile()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Helpers.FileInfoExtensions.IsZeroLengthFile" />
        /// method returns <see langword="true" /> when fed the value of the
        /// <see
        ///     cref="F:MFR.Tests.Common.StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE" />
        /// constant as a parameter (this constant having as its value, the path
        /// to a zero-length file).
        /// </summary>
        [Test]
        public void
            Test_IsZeroLengthFile_ReturnsTrue_ForXUDLFile_From_PortfolioMonitor()
            => Assert.IsTrue(
                MakeNewFileInfo
                    .ForPath(StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE)
                    .IsZeroLengthFile()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Helpers.FileInfoExtensions.RenameTo" />
        /// method will not work when provided only with a filename, not a
        /// fully-qualified path.
        /// </summary>
        /// <remarks>
        /// By "does not work" we mean, "returns <see langword="false" /> and
        /// doesn't carry out the file-rename operation."
        /// </remarks>
        [Test]
        public void
            Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName()
        {
            Assert.IsFalse(
                StringConstants.NEW_TEMP_FILE_FILENAME_ONLY.IsAbsolutePath()
            );

            Assert.IsFalse(
                MakeNewFileInfo.ForPath(StringConstants.EXISTING_TEMP_FILE)
                               .RenameTo(
                                   StringConstants.NEW_TEMP_FILE_FILENAME_ONLY
                               )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Helpers.FileInfoExtensions.RenameTo" />
        /// method works (i.e., returns <see langword="true" /> and performs the
        /// correct operations) when we give it the fully-qualified pathname of
        /// a temporary file that actually exists.
        /// </summary>
        [Test]
        public void Test_RenameTo_Works_On_ExistingTempFile()
        {
            var source = StringConstants.EXISTING_TEMP_FILE;
            var dest = StringConstants.NEW_TEMP_FILE;

            DoFileRename(source, dest);
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Helpers.FileInfoExtensions.RenameTo" />
        /// method works (i.e., returns <see langword="true" /> and performs the
        /// correct operations) when we give it the fully-qualified pathname of
        /// two files that have vastly different locations.
        /// </summary>
        [Test]
        public void Test_RenameTo_Works_On_VastlyDifferentFileNames()
        {
            var source = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.UserProfile
                ), $"{Guid.NewGuid():N}.txt"
            );
            FileHelpers.FillTextFileWithJunk(source);

            var dest = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments
                ) + $@"\{Guid.NewGuid():N}\Dest Folder\Sub Folder",
                $"{Guid.NewGuid():N}.txt"
            );

            var destFolder = Path.GetDirectoryName(dest);
            Assert.IsFalse(Directory.Exists(destFolder));

            if (!Directory.Exists(destFolder))
                Create.Folder(destFolder);

            DoFileRename(source, dest);

            Assert.IsFalse(File.Exists(source));
            Assert.IsTrue(File.Exists(dest));

            if (File.Exists(dest))
            {
                var folderToDelete =
                    new DirectoryInfo(destFolder).Parent.Parent;
                folderToDelete.Delete(true, true, true);
            }
        }

        private static void DoFileRename(string source, string dest)
        {
            Assert.IsTrue(File.Exists(source));

            /* fill the temp file with trash data */
            FileHelpers.FillTextFileWithJunk(source);

            Assert.IsTrue(new FileInfo(source).RenameTo(dest));
            Assert.IsFalse(File.Exists(source));
            Assert.IsTrue(File.Exists(dest));
        }
    }
}
