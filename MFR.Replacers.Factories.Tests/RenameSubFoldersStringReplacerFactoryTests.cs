using PostSharp.Patterns.Threading;
using MFR.Settings.Configuration.Constants;
using MFR.Operations.Constants;
using MFR.Replacers.Interfaces;
using NUnit.Framework;

namespace MFR.Replacers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.RenameSubFoldersStringReplacerFactory" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class RenameSubFoldersStringReplacerFactoryTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.IStringReplacerFactory.AndTextMatchingConfiguration" />
        /// method returns an instance of the correct concrete type that
        /// corresponds to the particular
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// value that
        /// is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseOnly
                                 ),
                Is.InstanceOf<MatchCaseOnlyFolderNameStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchExactWordOnly
                                 ),
                Is.InstanceOf<MatchExactWordOnlyFolderNameStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseAndExactWord
                                 ),
                Is.InstanceOf<MatchCaseAndExactWordFolderNameStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration
                                         .NeitherMatchCaseNorExactWord
                                 ),
                Is.InstanceOf<NeitherMatchCaseNorExactWordFolderNameStringReplacer
                >()
            );
        }

        /// <summary>
        /// Asserts that each object reference returned by the
        /// <see
        ///     cref="M:MFR.IStringReplacerFactory.AndTextMatchingConfiguration" />
        /// method for the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.RenameSubFolders" />
        /// value implements the
        /// <see
        ///     cref="T:MFR.IStringReplacer" />
        /// interface.
        /// </summary>
        [Test]
        public void
            Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseOnly
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchExactWordOnly
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseAndExactWord
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration
                                         .NeitherMatchCaseNorExactWord
                                 ), Is.InstanceOf<IStringReplacer>()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="P:MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration" />
        /// property of each of the concrete types returned by the
        /// <see
        ///     cref="M:MFR.IStringReplacerFactory.AndTextMatchingConfiguration" />
        /// method has the same value as was supplied to the method.
        /// </summary>
        [Test]
        public void
            Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseOnly
                                 )
                                 .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchCaseOnly)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchExactWordOnly
                                 )
                                 .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchExactWordOnly)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseAndExactWord
                                 )
                                 .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchCaseAndExactWord)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration
                                         .NeitherMatchCaseNorExactWord
                                 )
                                 .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.NeitherMatchCaseNorExactWord)
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="P:MFR.IFixedOperationTypeSpecificObject.OperationType" />
        /// property of each of the objects returned by the
        /// <see
        ///     cref="M:MFR.IStringReplacerFactory.AndTextMatchingConfiguration" />
        /// method for each
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// value, and
        /// for the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.RenameSubFolders" />
        /// value, is set to that value.
        /// </summary>
        [Test]
        public void Test_OperationType_Property_IsSetTo_RenameSubFolders()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseOnly
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchExactWordOnly
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseAndExactWord
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration
                                         .NeitherMatchCaseNorExactWord
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
        }
    }
}
