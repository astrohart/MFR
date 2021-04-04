using MFR.Objects.Operations.Constants;
using MFR.Objects.Replacers.Factories.Interfaces;
using NUnit.Framework;

namespace MFR.Objects.Replacers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.GetStringReplacer" />
    /// class.
    /// </summary>
    [TestFixture]
    public class GetStringReplacerTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.GetStringReplacer.For" />
        /// method
        /// returns a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Objects.IStringReplacerFactory" />
        /// interface when the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.RenameFilesInFolder" />
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
        ///     cref="M:MFR.Objects.GetStringReplacer.For" />
        /// method
        /// returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.Objects.RenameFilesInFolderStringReplacerFactory" />
        /// when the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.RenameFilesInFolder" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType()
            => Assert.IsInstanceOf<RenameFilesInFolderStringReplacerFactory>(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.GetStringReplacer.For" />
        /// method
        /// returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.Objects.RenameSubFoldersStringReplacerFactory" />
        /// when the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.RenameSubFolders" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_RenameSubFoldersStringReplacerFactory_When_RenameSubFolders_IsOperationType()
            => Assert.IsInstanceOf<RenameSubFoldersStringReplacerFactory>(
                GetStringReplacer.For(OperationType.RenameSubFolders)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.GetStringReplacer.For" />
        /// method
        /// returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.Objects.ReplaceTextInFilesStringReplacerFactory" />
        /// when the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.ReplaceTextInFiles" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_ReplaceTextInFilesStringReplacerFactory_When_ReplaceTextInFiles_IsOperationType()
            => Assert.IsInstanceOf<ReplaceTextInFilesStringReplacerFactory>(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
            );
    }
}