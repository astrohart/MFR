using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using NUnit.Framework;
using System;

namespace MFR.Expressions.Matches.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.GetMatchExpressionFactory" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class GetMatchExpressionFactoryTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFileNameReplacementMatchExpressionFactory_For_RenameFilesInFolder_OperationType()
            => Assert.That(
                GetMatchExpressionFactory.For(OperationType.RenameFilesInFolder)
                    is FileNameReplacementMatchExpressionFactory
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFolderNameReplacementMatchExpressionFactory_For_RenameSubFolders_OperationType()
            => Assert.That(
                GetMatchExpressionFactory.For(OperationType.RenameSubFolders) is
                    FolderNameReplacementMatchExpressionFactory
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsReplaceTextInFileMatchExpressionFactory_For_ReplaceTextInFiles_OperationType()
            => Assert.That(
                GetMatchExpressionFactory.For(OperationType.ReplaceTextInFiles)
                    is ReplaceTextInFileMatchExpressionFactory
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetMatchExpressionFactory.For(
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
                () => GetMatchExpressionFactory.For(
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
                () => GetMatchExpressionFactory.For(
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
                () => GetMatchExpressionFactory.For(
                    OperationType.OpenActiveSolutions
                )
            );
    }
}