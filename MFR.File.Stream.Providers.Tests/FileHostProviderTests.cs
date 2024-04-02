using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using MFR.FileSystem.Enumerators;
using NUnit.Framework;
using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Threading;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using Directory = Alphaleonis.Win32.Filesystem.Directory;
using Does = xyLOGIX.Files.Actions.Does;
using Path = Alphaleonis.Win32.Filesystem.Path;

namespace MFR.File.Stream.Providers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.File.Stream.Providers.FileHostProvider" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class FileHostProviderTests
    {
        /// <summary>
        /// Cleans up/releases system resources after each unit test has completed.
        /// </summary>
        [TearDown]
        public void Cleanup()
            => FileHostProvider.DisposeAll();

        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public void Initialize() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.File.Stream.Providers.Tests.FileHostProviderTests" /> and
        /// returns a reference to it.
        /// </summary>
        public FileHostProviderTests()
        {
            LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );
        }

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
        [Test]
        public void Test_Open_FilesInFolder()
        {
            Assert.That(FileHostProvider, Is.Not.Null);

            const string testingFolder = @"C:\temp";
            Assert.That(!string.IsNullOrWhiteSpace(testingFolder));
            Assert.That(Directory.Exists(testingFolder));

            var fileList = Enumerate.Files(
                                        testingFolder, "*",
                                        SearchOption.AllDirectories
                                    )
                                    .AsParallel();
            Assert.That(fileList, Is.Not.Null);
            Assert.That(fileList.Any());

            var totalFiles = fileList.Count();
            Assert.That(totalFiles > 0);

            var filesOpened = 0;
            var filesRead = 0;
            var tickets = new AdvisableCollection<Guid>();

            foreach (var file in fileList.ToArray())
            {
                if (!Does.FileExist(file)) continue;

                if (file.Contains(@"\.git\")) continue;
                if (file.Contains(@"\.vs\")) continue;
                if (file.Contains(@"\packages\")) continue;
                if (file.Contains(@"\bin\")) continue;
                if (file.Contains(@"\obj\")) continue;
                if (!Path.GetExtension(file)
                         .IsAnyOf(
                             ".txt", ".cs", ".resx", ".config", ".json",
                             ".csproj", ".settings", ".md"
                         ))
                    continue;

                var ticket = FileHostProvider.OpenStreamFor(file);
                if (ticket.IsZero()) continue;

                tickets.Add(ticket);

                Interlocked.Increment(ref filesOpened);
            }
            
            Assert.That(tickets, Is.Not.Null);
            Assert.That(tickets.Any());

            Thread.Sleep(500);

            var currentFileContent = "";
            foreach (var ticket in tickets)
            {
                var fileHost = FileHostProvider.Redeem(ticket);
                if (fileHost.OriginalLength <= 0L) continue;

                var filePath = fileHost.Path;


                Assert.That(fileHost, Is.Not.Null);
                Assert.That(fileHost.Stream, Is.Not.Null);
                Assert.That(fileHost.OriginalLength > 0L);
                Assert.That(fileHost.Stream is FileStream);
                Assert.That(fileHost.MemoryMappedData, Is.Not.Null);
                Assert.That(fileHost.Accessor, Is.Not.Null);

                Console.WriteLine(filePath);

                Assert.DoesNotThrow(
                    () => currentFileContent = ReadTextFromMemory(
                        fileHost.Encoding, fileHost.Accessor,
                        fileHost.OriginalLength
                    )
                );

                Assert.That(currentFileContent, Is.Not.Empty);

                Interlocked.Increment(ref filesRead);
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"Out of {totalFiles} file(s), {filesOpened} file(s) opened, and {filesRead} file(s) read.");

            FileHostProvider.BatchDispose(tickets);

            Assert.That(FileHostProvider, Is.Not.Null);
            Assert.That(FileHostProvider.Count == 0);
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
        [Log(AttributeExclude = true)]
        private string ReadTextFromMemory(
            Encoding encoding,
            UnmanagedMemoryAccessor accessor,
            long length
        )
        {
            var result = string.Empty;

            try
            {
                var bytes = new byte[length];
                accessor.ReadArray(0, bytes, 0, (int)length);
                result = encoding.GetString(bytes);
            }
            catch (Exception ex ) 
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Exposes static methods to obtain data from various data sources.
        /// </summary>
        private static class Get
        {
            /// <summary>
            /// A <see cref="T:System.String" /> containing the final piece of the path of the
            /// log file.
            /// </summary>
            private static readonly string LOG_FILE_PATH_TERMINATOR =
                $@"{AssemblyCompany}\{AssemblyProduct}\Logs\{AssemblyTitle}_log.txt";

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains the product name defined
            /// for this application.
            /// </summary>
            /// <remarks>
            /// This property is really an alias for the
            /// <see cref="P:AssemblyMetadata.AssemblyCompany" /> property.
            /// </remarks>
            private static string AssemblyCompany
                => AssemblyMetadata.AssemblyCompany;

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains the product name defined
            /// for this application.
            /// </summary>
            /// <remarks>
            /// This property is really an alias for the
            /// <see cref="P:AssemblyMetadata.AssemblyProduct" /> property.
            /// </remarks>
            private static string AssemblyProduct
                => AssemblyMetadata.AssemblyProduct.Replace(
                    "xyLOGIX ", string.Empty
                );

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains the assembly title defined
            /// for this application.
            /// </summary>
            /// <remarks>
            /// This property is really an alias for the
            /// <see cref="P:AssemblyMetadata.AssemblyTitle" /> property.
            /// </remarks>
            private static string AssemblyTitle
                => AssemblyMetadata.AssemblyTitle.Replace(" ", "_");

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains a user-friendly name for
            /// the software product of which this application or class library is a part.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String" /> that contains a user-friendly name
            /// for the software product of which this application or class library is a part.
            /// </returns>
            public static string ApplicationProductName()
            {
                string result;

                try
                {
                    result = AssemblyProduct;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = string.Empty;
                }

                return result;
            }

            /// <summary>
            /// Obtains a <see cref="T:System.String" /> that contains the fully-qualified
            /// pathname of the file that should be used for logging messages.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String" /> that contains the fully-qualified
            /// pathname of the file that should be used for logging messages.
            /// </returns>
            public static string LogFilePath()
                => Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.CommonApplicationData
                    ), LOG_FILE_PATH_TERMINATOR
                );
        }
    }
}