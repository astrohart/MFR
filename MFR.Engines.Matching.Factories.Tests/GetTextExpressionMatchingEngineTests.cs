using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using NUnit.Framework;
using System;

namespace MFR.Engines.Matching.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.GetTextExpressionMatchingEngine" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class GetTextExpressionMatchingEngineTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method, when passed the
        /// <see cref="T:MFR.Operations.Constants.OperationType.RenameFilesInFolder" />
        /// value, returns an instance of
        /// <see cref="T:MFR.Engines.Matching.FileNameMatchingEngine" />.
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFileNameMatchingEngine_For_RenameFilesInFolder_OperationType()
            => Assert.That(
                GetTextExpressionMatchingEngine.For(
                    OperationType.RenameFilesInFolder
                ) is FileNameMatchingEngine
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method, when passed the
        /// <see cref="T:MFR.Operations.Constants.OperationType.RenameSubFolders" />
        /// value, returns an instance of
        /// <see cref="T:MFR.Engines.Matching.FolderNameMatchingEngine" />.
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFolderNameMatchingEngine_For_RenameSubFolders_OperationType()
            => Assert.That(
                GetTextExpressionMatchingEngine.For(
                    OperationType.RenameSubFolders
                ) is FolderNameMatchingEngine
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method, when passed the
        /// <see cref="T:MFR.Operations.Constants.OperationType.ReplaceTextInFiles" />
        /// value, returns an instance of
        /// <see cref="T:MFR.Engines.Matching.TextInFilesMatchingEngine" />.
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsTextInFileMatchingEngine_For_ReplaceTextInFiles_OperationType()
            => Assert.That(
                GetTextExpressionMatchingEngine.For(
                    OperationType.ReplaceTextInFiles
                ) is TextInFilesMatchingEngine
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method throws <see cref="T:System.ArgumentOutOfRangeException" /> when supplied
        /// with the
        /// <see cref="T:MFR.Operations.Constants.OperationType.CloseActiveSolutions" />
        /// value,
        /// as this not one of the values that a text-expression matcher object is
        /// available for.
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.CloseActiveSolutions
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method throws <see cref="T:System.ArgumentOutOfRangeException" /> when supplied
        /// with the
        /// <see cref="T:MFR.Operations.Constants.OperationType.FindVisualStudio" /> value,
        /// as this not one of the values that a text-expression matcher object is
        /// available for.
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
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method throws <see cref="T:System.ArgumentOutOfRangeException" /> when supplied
        /// with the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.CalculateListOfFilesToBeRenamed" />
        /// value,
        /// as this not one of the values that a text-expression matcher object is
        /// available for.
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CalculateListOfFilesToBeRenamed_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.CalculateListOfFilesToBeRenamed
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method throws <see cref="T:System.ArgumentOutOfRangeException" /> when supplied
        /// with the
        /// <see cref="T:MFR.Operations.Constants.OperationType.OpenActiveSolutions" />
        /// value,
        /// as this not one of the values that a text-expression matcher object is
        /// available for.
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.OpenActiveSolutions
                )
            );
    }
}
