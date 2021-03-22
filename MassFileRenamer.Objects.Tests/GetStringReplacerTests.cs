using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.GetStringReplacer" />
    /// class.
    /// </summary>
    [TestFixture]
    public class GetStringReplacerTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.GetStringReplacer.For" />
        /// method
        /// returns a reference to an instance of an object that implements the
        /// <see cref="T:MassFileRenamer.Objects.IStringReplacerFactory" />
        /// interface when the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType.RenameFilesInFolder" />
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
        ///     cref="M:MassFileRenamer.Objects.GetStringReplacer.For" />
        /// method
        /// returns a reference to an instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.RenameFilesInFolderStringReplacerFactory" />
        /// when the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType.RenameFilesInFolder" />
        /// enumeration value is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_For_Returns_RenameFilesInFolderStringReplacerFactory_When_RenameFilesInFolder_IsOperationType()
            => Assert.IsInstanceOf<RenameFilesInFolderStringReplacerFactory>(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
            );
    }
}