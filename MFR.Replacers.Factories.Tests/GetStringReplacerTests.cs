using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using MFR.Replacers.Factories.Interfaces;
using NUnit.Framework;

namespace MFR.Replacers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.GetStringReplacer" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class GetStringReplacerTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.GetStringReplacer.For" />
        /// method
        /// returns a reference to an instance of an object that implements the
        /// <see cref="T:MFR.IStringReplacerFactory" />
        /// interface when the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.RenameFilesInFolder" />
        /// value is passed for its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_ImplementerOf_IStringReplacerFactory_When_RenameFilesInFolder_IsOperationType()
            => Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder),
                Is.InstanceOf<IStringReplacerFactory>()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.GetStringReplacer.For" />
        /// method
        /// returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.RenameFilesInFolderStringReplacerFactory" />
        /// when the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.RenameFilesInFolder" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType()
            => Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
            , Is.InstanceOf<RenameFilesInFolderStringReplacerFactory>());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.GetStringReplacer.For" />
        /// method
        /// returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.RenameSubFoldersStringReplacerFactory" />
        /// when the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.RenameSubFolders" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType()
            => Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
            , Is.InstanceOf<RenameSubFoldersStringReplacerFactory>());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.GetStringReplacer.For" />
        /// method
        /// returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.ReplaceTextInFilesStringReplacerFactory" />
        /// when the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.ReplaceTextInFiles" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType()
            => Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
            , Is.InstanceOf<ReplaceTextInFilesStringReplacerFactory>());
    }
}