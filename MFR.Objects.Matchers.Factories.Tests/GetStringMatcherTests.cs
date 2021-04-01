using NUnit.Framework;

namespace MFR.Objects.Matchers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.GetStringMatcher" />
    /// class.
    /// </summary>
    [TestFixture]
    public class GetStringMatcherTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.GetStringMatcher.For" />
        /// method
        /// returns a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Objects.IStringMatcherFactory" />
        /// interface when the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.RenameFilesInFolder" />
        /// value is passed for its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType()
            => Assert.That(
                GetStringMatcher.For(OperationType.RenameFilesInFolder),
                Is.InstanceOf<IStringMatcherFactory>()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.GetStringMatcher.For" />
        /// method
        /// returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.Objects.RenameFilesInFolderStringMatcherFactory" />
        /// when the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.RenameFilesInFolder" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType()
            => Assert.IsInstanceOf<RenameFilesInFolderStringMatcherFactory>(
                GetStringMatcher.For(OperationType.RenameFilesInFolder)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.GetStringMatcher.For" />
        /// method
        /// returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.Objects.RenameSubFoldersStringMatcherFactory" />
        /// when the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.RenameSubFolders" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType()
            => Assert.IsInstanceOf<RenameSubFoldersStringMatcherFactory>(
                GetStringMatcher.For(OperationType.RenameSubFolders)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.GetStringMatcher.For" />
        /// method
        /// returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.Objects.ReplaceTextInFilesStringMatcherFactory" />
        /// when the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.ReplaceTextInFiles" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType()
            => Assert.IsInstanceOf<ReplaceTextInFilesStringMatcherFactory>(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
            );

    }
}