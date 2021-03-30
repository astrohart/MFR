using NUnit.Framework;
using System;

namespace MFR.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.GetTextExpressionMatchingEngine" />
    /// class.
    /// </summary>
    [TestFixture]
    public class GetTextExpressionMatchingEngineTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFileNameMatchingEngine_For_RenameFilesInFolder_OperationType()
            => Assert.IsTrue(
                GetTextExpressionMatchingEngine.For(OperationType.RenameFilesInFolder)
                    is FileNameMatchingEngine
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFolderNameMatchingEngine_For_RenameSubFolders_OperationType()
            => Assert.IsTrue(
                GetTextExpressionMatchingEngine.For(OperationType.RenameSubFolders) is
                    FolderNameMatchingEngine
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsTextInFileMatchingEngine_For_ReplaceTextInFiles_OperationType()
            => Assert.IsTrue(
                GetTextExpressionMatchingEngine.For(OperationType.ReplaceTextInFiles)
                    is TextInFilesMatchingEngine
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.CloseActiveSolution
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.FindVisualStudio
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_GettingListOfFilesToBeRenamed_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.GettingListOfFilesToBeRenamed
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.OpenActiveSolution
                )
            );
    }
}