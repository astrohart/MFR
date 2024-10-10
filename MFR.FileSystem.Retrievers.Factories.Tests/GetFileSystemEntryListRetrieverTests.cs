using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using NUnit.Framework;
using System;

namespace MFR.FileSystem.Retrievers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.GetFileSystemEntryListRetriever" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class GetFileSystemEntryListRetrieverTests
    {


        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFilesToRenameRetriever_For_RenameFilesInFolder_OperationType()
            => Assert.That(
                GetFileSystemEntryListRetriever.For(
                    OperationType.RenameFilesInFolder
                ) is FilesToRenameRetriever
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFolderToRenameRetriever_For_RenameSubFolders_OperationType()
            => Assert.That(
                GetFileSystemEntryListRetriever.For(
                    OperationType.RenameSubFolders
                ) is FolderToRenameRetriever
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsTextInFilesRetriever_For_ReplaceTextInFiles_OperationType()
            => Assert.That(
                GetFileSystemEntryListRetriever.For(
                    OperationType.ReplaceTextInFiles
                ) is TextInFilesRetriever
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetFileSystemEntryListRetriever.For(
                    OperationType.CloseActiveSolutions
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetFileSystemEntryListRetriever.For(
                    OperationType.FindVisualStudio
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CalculateListOfFilesToBeRenamed_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetFileSystemEntryListRetriever.For(
                    OperationType.CalculateListOfFilesToBeRenamed
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetFileSystemEntryListRetriever.For(
                    OperationType.OpenActiveSolutions
                )
            );
    }
}