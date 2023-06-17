using MFR.File.Stream.Providers.Events;
using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using MFR.FileSystem.Enumerators;
using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;
using Directory = Alphaleonis.Win32.Filesystem.Directory;
using Path = Alphaleonis.Win32.Filesystem.Path;

namespace MFR.File.Stream.Providers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.File.Stream.Providers.FileStreamProvider" /> class.
    /// </summary>
    [TestFixture]
    public class FileStreamProviderTests
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.File.Stream.Providers.Tests.FileStreamProviderTests" /> and
        /// returns a reference to it.
        /// </summary>
        public FileStreamProviderTests()
        {
            LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );

            FileStreamProvider.FileStreamDisposed += OnFileStreamDisposed;
            FileStreamProvider.FileStreamOpened += OnFileStreamOpened;
            FileStreamProvider.FileStreamOpening += OnFileStreamOpening;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
        /// interface.
        /// </summary>
        private static IFileStreamProvider FileStreamProvider
        {
            get;
        } = GetFileStreamProvider.SoleInstance();

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_Open_FilesInFolder()
        {
            Assert.IsNotNull(FileStreamProvider);

            var executingAssembly = Assembly.GetExecutingAssembly();
            Assert.IsNotNull(executingAssembly);

            var executingAssemblyPathname = executingAssembly.Location;
            Assert.That(!string.IsNullOrWhiteSpace(executingAssemblyPathname));
            Assert.That(
                Alphaleonis.Win32.Filesystem.File.Exists(
                    executingAssemblyPathname
                )
            );

            var executingAssemblyFolder =
                Path.GetDirectoryName(executingAssemblyPathname);
            Assert.That(!string.IsNullOrWhiteSpace(executingAssemblyFolder));
            Assert.That(Directory.Exists(executingAssemblyFolder));

            var fileList = Enumerate.Files(
                                        executingAssemblyFolder, "*",
                                        SearchOption.AllDirectories
                                    )
                                    .AsParallel()
                                    .ToList();
            Assert.IsNotNull(fileList);
            Assert.That(fileList.Any());

            var tickets = FileStreamProvider.BatchOpenStreams(fileList);
            Assert.IsNotNull(tickets);
            Assert.That(tickets.Any());

            Thread.Sleep(500);

            FileStreamProvider.BatchDispose(tickets);

            Assert.IsNotNull(FileStreamProvider);
            Assert.That(FileStreamProvider.Count == 0);
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.FileStreamDisposed" />
        /// event raised by the file stream provider object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileStreamDisposedEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by writing a logging message explaining that a
        /// file stream opened on a specific file was disposed.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private static void OnFileStreamDisposed(
            object sender,
            FileStreamDisposedEventArgs e
        )
            => DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: File stream for file '{e.Pathname}' has been disposed."
            );

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.FileStreamOpened" />
        /// event raised by the file stream provider object..
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileStreamOpenedEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by writing the fully-qualified pathname of the
        /// file on which the new stream was opened, to the log file.
        /// </remarks>
        [Log(AttributeExclude = true)]
        private static void OnFileStreamOpened(
            object sender,
            FileStreamOpenedEventArgs e
        )
            => DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** SUCCESS *** A file stream has been opened on the file '{e.Pathname}'."
            );

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider.FileStreamOpening" />
        /// event raised by the DESC.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.File.Stream.Providers.Events.FileStreamOpeningEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by writing a message to the debugging log stating
        /// that we are attempting to open a <c>FileStream</c> upon a particular file.
        /// </remarks>
        private static void OnFileStreamOpening(
            object sender,
            FileStreamOpeningEventArgs e
        )
            => DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: Attempting to open a FileStream upon the file '{e.Pathname}'..."
            );

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