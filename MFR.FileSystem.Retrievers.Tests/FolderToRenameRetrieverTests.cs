using PostSharp.Patterns.Threading;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Retrievers.Factories;
using MFR.FileSystem.Retrievers.Interfaces;
using MFR.Operations.Constants;
using MFR.Tests.Common;
using NUnit.Framework;
using System.Collections.Generic;
using Alphaleonis.Win32.Filesystem;
using System.IO;
using System.Linq;

namespace MFR.FileSystem.Retrievers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.FolderToRenameRetriever" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class FolderToRenameRetrieverTests
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public void Initialize()
            => Assert.That(Retriever is FolderToRenameRetriever);

        private const string FIND_WHAT =
            @"PortfolioMonitor.ExchangeDirection.Constants";

        private const string REPLACE_WITH =
            @"PortfolioMonitor.Exchanges.Constants";

        private const string ROOT_FOLDER_PATH =
            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor";

        /// <summary>
        /// Gets a reference to an instance of the object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntryListRetriever" />
        /// interface for renaming folders.
        /// </summary>
        private IFileSystemEntryListRetriever Retriever
            => GetFileSystemEntryListRetriever.For(
                OperationType.RenameSubFolders
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_DoGetMatchingFileSystemPaths_ReturnsNonzeroEntries_ForValidSearch()
            => Assert.That(
                ((IEnumerable<IFileSystemEntry>)Retriever
                                                .AndAttachConfiguration(
                                                    ConfigurationBuilder
                                                        .Instance.SetMatchCase()
                                                        .AndSetMatchExactWord(
                                                            false
                                                        )
                                                        .Build()
                                                )
                                                .UsingSearchPattern("*")
                                                .WithSearchOption(
                                                    SearchOption.AllDirectories
                                                )
                                                .ToFindWhat(REPLACE_WITH)
                                                .AndReplaceItWith(FIND_WHAT)
                                                .GetMatchingFileSystemPaths(
                                                    ROOT_FOLDER_PATH
                                                )).Any()
            );
    }
}