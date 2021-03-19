using NUnit.Framework;
using System;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.GetTextExpressionMatcher" />
    /// class.
    /// </summary>
    [TestFixture]
    public class GetTextExpressionMatcherTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFileNameMatcher_For_RenameFilesInFolder_OperationType()
            => Assert.IsTrue(
                GetTextExpressionMatcher.For(OperationType.RenameFilesInFolder)
                    is FileNameMatcher
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFolderNameMatcher_For_RenameSubFolders_OperationType()
            => Assert.IsTrue(
                GetTextExpressionMatcher.For(OperationType.RenameSubFolders) is
                    FolderNameMatcher
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsTextInFileMatcher_For_ReplaceTextInFiles_OperationType()
            => Assert.IsTrue(
                GetTextExpressionMatcher.For(OperationType.ReplaceTextInFiles)
                    is TextInFileMatcher
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatcher.For(
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
                () => GetTextExpressionMatcher.For(
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
                () => GetTextExpressionMatcher.For(
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
                () => GetTextExpressionMatcher.For(
                    OperationType.OpenActiveSolution
                )
            );
    }
}