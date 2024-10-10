using PostSharp.Patterns.Threading;
using MFR.Matchers.Factories.Interfaces;
using MFR.Operations.Constants;
using NUnit.Framework;

namespace MFR.Matchers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.GetStringMatcherFactory" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class GetStringMatcherFactoryTests
    {
        /// <summary>
        /// Asserts that the <see cref="M:MFR.GetStringMatcherFactory.For" />
        /// method returns a reference to an instance of an object that
        /// implements the <see cref="T:MFR.IStringMatcherFactory" />
        /// interface when the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.RenameFilesInFolder" />
        /// value is
        /// passed for its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_ImplementerOf_IStringMatcherFactory_When_RenameFilesInFolder_IsOperationType()
            => Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameFilesInFolder),
                Is.InstanceOf<IStringMatcherFactory>()
            );

        /// <summary>
        /// Asserts that the <see cref="M:MFR.GetStringMatcherFactory.For" />
        /// method returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.RenameFilesInFolderStringMatcherFactory" />
        /// when
        /// the <see cref="T:MFR.Operations.Constants.OperationType.RenameFilesInFolder" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_RenameFilesInFolderStringMatcherFactory_When_RenameFilesInFolder_IsOperationType()
            => Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameFilesInFolder)
            , Is.InstanceOf<RenameFilesInFolderStringMatcherFactory>());

        /// <summary>
        /// Asserts that the <see cref="M:MFR.GetStringMatcherFactory.For" />
        /// method returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.RenameSubFoldersStringMatcherFactory" />
        /// when the
        /// <see cref="T:MFR.Operations.Constants.OperationType.RenameSubFolders" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_RenameSubFoldersStringMatcherFactory_When_RenameSubFolders_IsOperationType()
            => Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
            , Is.InstanceOf<RenameSubFoldersStringMatcherFactory>());

        /// <summary>
        /// Asserts that the <see cref="M:MFR.GetStringMatcherFactory.For" />
        /// method returns a reference to an instance of
        /// <see
        ///     cref="T:MFR.ReplaceTextInFilesStringMatcherFactory" />
        /// when
        /// the <see cref="T:MFR.Operations.Constants.OperationType.ReplaceTextInFiles" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_ReplaceTextInFilesStringMatcherFactory_When_ReplaceTextInFiles_IsOperationType()
            => Assert.That(
                GetStringMatcherFactory.For(OperationType.ReplaceTextInFiles)
            , Is.InstanceOf<ReplaceTextInFilesStringMatcherFactory>());
    }
}