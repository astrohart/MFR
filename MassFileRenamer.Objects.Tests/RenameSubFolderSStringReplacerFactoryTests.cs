using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.RenameSubFoldersStringReplacerFactory" />
    /// class.
    /// </summary>
    [TestFixture]
    public class RenameSubFoldersStringReplacerFactoryTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IStringReplacerFactory.AndMatchingConfiguration" />
        /// method returns an instance of the correct concrete type that
        /// corresponds to the particular
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration" />
        /// value that
        /// is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_AndMatchingConfiguration_Returns_AppropriateReplacer_ForEach_MatchingConfigurationValue()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseOnly
                                 ),
                Is.InstanceOf<MatchCaseOnlyFolderNameStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchWholeWordOnly
                                 ),
                Is.InstanceOf<MatchWholeWordOnlyFolderNameStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseAndWholeWord
                                 ),
                Is.InstanceOf<MatchCaseAndWholeWordFolderNameStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration
                                         .NeitherMatchCaseNorWholeWord
                                 ),
                Is.InstanceOf<NeitherMatchCaseNorWholeWordFolderNameStringReplacer
                >()
            );
        }

        /// <summary>
        /// Asserts that each object reference returned by the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IStringReplacerFactory.AndMatchingConfiguration" />
        /// method for the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType.RenameSubFolders" />
        /// value implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IStringReplacer" />
        /// interface.
        /// </summary>
        [Test]
        public void
            Test_AndMatchingConfiguration_Returns_ImplementerOf_IStringReplacer()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseOnly
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchWholeWordOnly
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseAndWholeWord
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration
                                         .NeitherMatchCaseNorWholeWord
                                 ), Is.InstanceOf<IStringReplacer>()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IFixedMatchingConfigurationSpecificObject.MatchingConfiguration" />
        /// property of each of the concrete types returned by the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IStringReplacerFactory.AndMatchingConfiguration" />
        /// method has the same value as was supplied to the method.
        /// </summary>
        [Test]
        public void
            Test_MatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseOnly
                                 )
                                 .MatchingConfiguration,
                Is.EqualTo(MatchingConfiguration.MatchCaseOnly)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchWholeWordOnly
                                 )
                                 .MatchingConfiguration,
                Is.EqualTo(MatchingConfiguration.MatchWholeWordOnly)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseAndWholeWord
                                 )
                                 .MatchingConfiguration,
                Is.EqualTo(MatchingConfiguration.MatchCaseAndWholeWord)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration
                                         .NeitherMatchCaseNorWholeWord
                                 )
                                 .MatchingConfiguration,
                Is.EqualTo(MatchingConfiguration.NeitherMatchCaseNorWholeWord)
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IFixedOperationTypeSpecificObject.OperationType" />
        /// property of each of the objects returned by the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IStringReplacerFactory.AndMatchingConfiguration" />
        /// method for each
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration" />
        /// value, and
        /// for the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType.RenameSubFolders" />
        /// value, is set to that value.
        /// </summary>
        [Test]
        public void Test_OperationType_Property_IsSetTo_RenameSubFolders()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseOnly
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchWholeWordOnly
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseAndWholeWord
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration
                                         .NeitherMatchCaseNorWholeWord
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
        }
    }
}