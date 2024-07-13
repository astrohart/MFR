using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using MFR.FileSystem.Enumerators;
using NUnit.Framework;
using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Tests.Logging;
using Does = xyLOGIX.Files.Actions.Does;

namespace MFR.File.Stream.Providers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.File.Stream.Providers.FileHostProvider" /> class.
    /// </summary>
    [TestFixture, Synchronized]
    public class FileHostProviderTests : LoggingTestBase
    {
        /// <summary>
        /// Cleans up/releases system resources after each unit test has completed.
        /// </summary>
        [TearDown]
        public void Cleanup()
            => FileHostProvider.DisposeAll();

        /// <summary>
        /// Executes logic that is to be run after all unit testing is finished.
        /// </summary>
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            try
            {
                if (FileHostProvider == null) return;

                FileHostProvider.Dispose();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Static <see cref="T:System.String" /> array that contains parts of file
        /// pathnames whose presence in a file's pathname indicates that the file having
        /// that pathname is to be skipped.
        /// </summary>
        private static readonly string[] TheBadFilePathParts =
        {
            @"\.git\",
            @"\.vs\",
            @"\packages\",
            @"\bin\",
            @"\obj\"
        };

        /// <summary>
        /// Static <see cref="T:System.String" /> array that contains parts of file
        /// pathnames whose presence in a file's pathname indicates that the file is to be
        /// included as part of an operation.
        /// </summary>
        private static readonly string[] TheGoodFilenameExtensions =
        {
            ".txt",
            ".cs",
            ".resx",
            ".config",
            ".json",
            ".csproj",
            ".settings",
            ".md",
            ".sln"
        };

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileHostProvider" />
        /// interface.
        /// </summary>
        private static IFileHostProvider FileHostProvider
        {
            get;
        } = GetFileHostProvider.SoleInstance();

        /// <summary>
        /// An integration test of opening file streams on a number of files in the
        /// execution folder of this unit test, and then disposing of the streams.
        /// </summary>
        [Test,
         TestCase(@"C:\Users\Brian Hart\source\repos\astrohart\PortfolioGPT")]
        public void Test_Open_FilesInFolder(string testingFolder)
        {
            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileHostProviderTests.Test_Open_FilesInFolder: Checking whether the File Host Provider is set to a null reference..."
                );

                Assert.That(
                    FileHostProvider, Is.Not.Null,
                    "*** ERROR *** The FileHostProvider property is set to a NULL reference.  Stopping..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileHostProviderTests.Test_Open_FilesInFolder: *** SUCCESS *** The FileHostProvider property is set to a valid object reference.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: Checking whether the testing folder, '{testingFolder}', exists on the file system..."
                );

                Assert.That(
                    Does.FolderExist(testingFolder),
                    $"*** ERROR *** Could not locate the testing folder, '{testingFolder}', on the file system.  Stopping..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: *** SUCCESS *** The testing folder, '{testingFolder}', exists on the file system.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: Enumerating the files in the testing folder, '{testingFolder}'..."
                );

                var fileEnumerationStopwatch = new Stopwatch();
                fileEnumerationStopwatch.Start();

                var fileList = Enumerate.Files(
                    testingFolder, "*", SearchOption.AllDirectories
                );
                fileEnumerationStopwatch.Stop();

                Assert.That(
                    fileList, Is.Not.Null,
                    "*** ERROR *** A null reference was returned for the fileList variable.  Stopping..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: File enumeration completed in {fileEnumerationStopwatch.ElapsedMilliseconds} milliseconds."
                );

                var numFilesInList = 0;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileHostProviderTests.Test_Open_FilesInFolder: Checking that there are greater than zero elements in the file list..."
                );

                var checkStopwatch = new Stopwatch();
                checkStopwatch.Start();

                Parallel.ForEach(
                    fileList, (file, state) =>
                    {
                        Interlocked.Increment(ref numFilesInList);
                        if (numFilesInList <= 0) return;

                        state.Stop();
                        return;
                    }
                );

                checkStopwatch.Stop();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: Checking took {checkStopwatch.ElapsedMilliseconds} millisecond(s)."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileHostProviderTests.Test_Open_FilesInFolder: Checking whether greater than zero file entry(ies) were found..."
                );

                Assert.That(
                    numFilesInList > 0,
                    $"*** ERROR *** Zero file(s) were found in the testing folder, '{testingFolder}'.  Stopping..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: Counting the files in the testing folder, '{testingFolder}'..."
                );

                var countingStopwatch = new Stopwatch();
                countingStopwatch.Start();

                var totalFiles = fileList.AsParallel()
                                         .Count();
                countingStopwatch.Stop();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: Counting the file(s) in the testing folder, '{testingFolder}', took {countingStopwatch.ElapsedMilliseconds} millisecond(s)."
                );

                Assert.That(
                    totalFiles > 0,
                    $"*** ERROR *** Zero file(s) were found in the testing folder, '{testingFolder}'.  Stopping..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: *** SUCCESS *** {totalFiles} file(s) were found in the testing folder, '{testingFolder}'.  Proceeding..."
                );

                var numFilesOpened = 0;
                var numFilesRead = 0;
                var tickets = new AdvisableCollection<Guid>();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: Opening streams on the file(s) present in the testing folder, '{testingFolder}'..."
                );

                var openFileStreamStopwatch = new Stopwatch();
                openFileStreamStopwatch.Start();

                var loopResult = Parallel.ForEach(
                    fileList, (file, state) =>
                    {
                        if (ShouldSkip(file)) return;

                        var ticket = FileHostProvider.OpenStreamFor(file);
                        if (ticket.IsZero()) return;

                        tickets.Add(ticket);

                        Interlocked.Increment(ref numFilesOpened);
                    }
                );

                openFileStreamStopwatch.Stop();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: Opening file streams took {openFileStreamStopwatch.ElapsedMilliseconds} millisecond(s)."
                );

                Assert.That(
                    loopResult.IsCompleted,
                    "*** ERROR *** Failed to complete the loop to open file streams."
                );

                Assert.That(
                    tickets, Is.Not.Null,
                    "*** ERROR *** The 'tickets' collection has a null reference."
                );

                Assert.That(
                    tickets.ToArray()
                           .Length > 0,
                    "*** ERROR *** Zero file(s) had streams opened for them."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileHostProviderTests.Test_Open_FilesInFolder: Delaying 500 milliseconds..."
                );
                Thread.Sleep(500);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileHostProviderTests.Test_Open_FilesInFolder: Instrumenting the process of reading the contents of all the files..."
                );

                var fileReadStopwatch = new Stopwatch();
                fileReadStopwatch.Start();

                Parallel.ForEach(
                    tickets, ticket =>
                    {
                        var fileHost = FileHostProvider.Redeem(ticket);
                        if (fileHost == null) return;
                        if (fileHost.OriginalLength <= 0L) return;

                        Assert.That(
                            !string.IsNullOrWhiteSpace(fileHost.Path),
                            "*** ERROR *** A null, blank, or whitespace string has been detected for the pathname of the FileHost.  Stopping..."
                        );
                        Assert.That(
                            fileHost.Stream, Is.Not.Null,
                            "*** ERROR *** The current file stream has a null reference.  Stopping..."
                        );
                        Assert.That(
                            fileHost.Stream is FileStream,
                            "*** ERROR *** The current file stream isn't of type FileStream.  Stopping..."
                        );
                        Assert.That(
                            fileHost.MemoryMappedData, Is.Not.Null,
                            "*** ERROR *** No memory-mapped data is present for the current FileHost.  Stopping..."
                        );
                        Assert.That(
                            fileHost.Accessor, Is.Not.Null,
                            "*** ERROR *** The current FileHost does not have a View accessor open on the file.  Stopping..."
                        );

                        var currentFileContent = string.Empty;

                        Assert.DoesNotThrow(
                            () => currentFileContent = ReadTextFromMemory(
                                fileHost.Encoding, fileHost.Accessor,
                                fileHost.OriginalLength
                            )
                        );

                        Assert.That(
                            !string.IsNullOrWhiteSpace(currentFileContent)
                        );
                        Interlocked.Increment(ref numFilesRead);
                        currentFileContent =
                            string.Empty; // throw the content away
                    }
                );

                fileReadStopwatch.Stop();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Out of {totalFiles} file(s), {numFilesOpened} file(s) opened, and {numFilesRead} file(s) read."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: Opening file streams took {openFileStreamStopwatch.Elapsed:g}."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileHostProviderTests.Test_Open_FilesInFolder: Reading file contents took {fileReadStopwatch.Elapsed:g}."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                throw;
            }
        }

        /// <summary>
        /// Determines whether the file having the specified <paramref name="pathname" />
        /// should be skipped in an operation.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file that is to be evaluated.
        /// </param>
        /// <remarks>
        /// Logging is suppressed for this method due to the fact it may be called
        /// very frequently and numerous times.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the file is to be skipped;
        /// <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true), EntryPoint]
        private static bool ShouldSkip(string pathname)
        {
            var result = true;

            try
            {
                result = !Does.FileExist(pathname) ||
                         pathname.ContainsAnyOf(TheBadFilePathParts) ||
                         !pathname.HasAnyOfTheseExtensions(
                             TheGoodFilenameExtensions
                         );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = true;
            }

            return result;
        }

        /// <summary>
        /// Reads text from a memory-mapped file accessor.
        /// </summary>
        /// <param name="accessor">The memory-mapped file accessor.</param>
        /// <param name="length">The length of the text to read.</param>
        /// <returns>The text read from memory.</returns>
        /// <remarks>
        /// This method reads text from a memory-mapped file accessor and returns it as a
        /// string.
        /// It reads the specified length of bytes from the accessor and decodes them using
        /// UTF-8 encoding.
        /// </remarks>
        [Log(AttributeExclude = true), EntryPoint]
        private string ReadTextFromMemory(
            Encoding encoding,
            UnmanagedMemoryAccessor accessor,
            long length
        )
        {
            var result = string.Empty;

            try
            {
                if (length <= 0) return result;

                var bytes = new byte[length];
                accessor.ReadArray(0, bytes, 0, (int)length);
                result = encoding.GetString(bytes);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}