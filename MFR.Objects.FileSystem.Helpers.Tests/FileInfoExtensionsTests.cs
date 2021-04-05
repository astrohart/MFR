using MFR.Objects.Engines.Replacement.Factories;
using MFR.Objects.Engines.Replacement.Intefaces;
using MFR.Objects.Expressions.Matches.Factories;
using MFR.Objects.Expressions.Matches.Interfaces;
using MFR.Objects.FileSystem.Factories;
using MFR.Objects.FileSystem.Helpers;
using MFR.Objects.FileSystem.Interfaces;
using MFR.Objects.FileSystem.Retrievers.Factories;
using MFR.Objects.Operations.Constants;
using MFR.Objects.Tests.Common;
using NUnit.Framework;
using System;
using System.IO;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Objects.FileSystem.Helpers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods in the
    /// <see
    ///     cref="T:MFR.Objects.FileInfoExtensions" />
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
            Assert.Pass();

            var configuration =
                ConfigurationBuilder.BuildConfigurationForUseCase(
                    true, /* match case */
                    true
                ); /* match whole word */

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
                                         .AndAttachConfiguration(configuration)
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
                                                configuration
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
            FileSystemEntryExtensions.ToFileInfo(newFileSystemEntry)
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
        /// TODO: Add unit test documentation here
        /// </summary>
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
                                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
                            )
                            .AndOperationType(
                                OperationType.RenameFilesInFolder
                            )).Path
                    ) ?? string.Empty
                )
            );
            Assert.IsTrue(
                (bool) Path.Combine(
                               Path.GetDirectoryName(
                                   ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                                           @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
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
                                                           @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
                                                       )
                                                       .AndOperationType(
                                                           OperationType
                                                               .RenameFilesInFolder
                                                       )
                                               )
                                       )
                                       .ToFindWhat("Foo")
                                       .AndReplaceItWith("Bar")
                               )
                           )
                           .IsAbsolutePath()
            );
            ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                        @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
                    )
                    .AndOperationType(OperationType.RenameFilesInFolder))
                .ToFileInfo()
                .RenameTo(
                    Path.Combine(
                        Path.GetDirectoryName(
                            ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
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
                                                                  @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
                                                              )
                                                              .AndOperationType(
                                                                  OperationType
                                                                      .RenameFilesInFolder
                                                              )
                                                      )
                                              )
                                              .ToFindWhat("Foo")
                                              .AndReplaceItWith("Bar")
                        )
                    )
                );
            Assert.IsFalse(
                File.Exists(
                    ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
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
                                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
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
                                                                  @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
                                                              )
                                                              .AndOperationType(
                                                                  OperationType
                                                                      .RenameFilesInFolder
                                                              )
                                                      )
                                              )
                                              .ToFindWhat("Foo")
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
                                               @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
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
                                                               @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
                                                           )
                                                           .AndOperationType(
                                                               OperationType
                                                                   .RenameFilesInFolder
                                                           )
                                                   )
                                           )
                                           .ToFindWhat("Foo")
                                           .AndReplaceItWith("Bar")
                                   )
                               )
                           )
                           .RenameTo(
                               ((IFileSystemEntry)MakeNewFileSystemEntry
                                                  .ForPath(
                                                      @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
                                                  )
                                                  .AndOperationType(
                                                      OperationType
                                                          .RenameFilesInFolder
                                                  )).Path
                           ); // restore the file for more testing
            Assert.IsTrue(
                File.Exists(
                    ((IFileSystemEntry)MakeNewFileSystemEntry.ForPath(
                            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
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
                                    @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
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
                                                                  @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\Foo\Foo.csproj"
                                                              )
                                                              .AndOperationType(
                                                                  OperationType
                                                                      .RenameFilesInFolder
                                                              )
                                                      )
                                              )
                                              .ToFindWhat("Foo")
                                              .AndReplaceItWith("Bar")
                        )
                    )
                )
            );
        }

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_RenameTo_RefusesToWork_WhenNewFilePath_IsJustAFileName()
            => Assert.IsFalse(
                (bool) MakeNewFileInfo.ForPath(StringConstants.EXISTING_TEMP_FILE)
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
                (bool) new FileInfo(StringConstants.EXISTING_TEMP_FILE).RenameTo(
                    StringConstants.NEW_TEMP_FILE
                )
            );
            Assert.IsFalse(File.Exists(StringConstants.EXISTING_TEMP_FILE));
            Assert.IsTrue(File.Exists(StringConstants.NEW_TEMP_FILE));
        }
    }
}