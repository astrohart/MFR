using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.RenameFilesInFolderStringReplacerFactory" />
    /// class.
    /// </summary>
    [TestFixture]
    public class RenameFilesInFolderStringReplacerFactoryTests
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
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseOnly
                                 ),
                Is.InstanceOf<MatchCaseOnlyFileNameStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchWholeWordOnly
                                 ),
                Is.InstanceOf<MatchWholeWordOnlyFileNameStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseAndWholeWord
                                 ),
                Is.InstanceOf<MatchCaseAndWholeWordFileNameStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration
                                         .NeitherMatchCaseNorWholeWord
                                 ),
                Is.InstanceOf<NeitherMatchCaseNorWholeWordFileNameStringReplacer
                >()
            );
        }

        /// <summary>
        /// Asserts that each object reference returned by the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IStringReplacerFactory.AndMatchingConfiguration" />
        /// method for the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType.RenameFilesInFolder" />
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
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseOnly
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchWholeWordOnly
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseAndWholeWord
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
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
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseOnly
                                 )
                                 .MatchingConfiguration,
                Is.EqualTo(MatchingConfiguration.MatchCaseOnly)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchWholeWordOnly
                                 )
                                 .MatchingConfiguration,
                Is.EqualTo(MatchingConfiguration.MatchWholeWordOnly)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseAndWholeWord
                                 )
                                 .MatchingConfiguration,
                Is.EqualTo(MatchingConfiguration.MatchCaseAndWholeWord)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
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
        ///     cref="T:MassFileRenamer.Objects.OperationType.RenameFilesInFolder" />
        /// value, is set to that value.
        /// </summary>
        [Test]
        public void Test_OperationType_Property_IsSetTo_RenameFilesInFolder()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseOnly
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameFilesInFolder)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchWholeWordOnly
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameFilesInFolder)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration.MatchCaseAndWholeWord
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameFilesInFolder)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameFilesInFolder)
                                 .AndMatchingConfiguration(
                                     MatchingConfiguration
                                         .NeitherMatchCaseNorWholeWord
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameFilesInFolder)
            );
        }
    }
}