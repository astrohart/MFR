using NUnit.Framework;

namespace MFR.Objects.Replacers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.ReplaceTextInFilesStringReplacerFactory" />
    /// class.
    /// </summary>
    [TestFixture]
    public class ReplaceTextInFilesStringReplacerFactoryTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration" />
        /// method returns an instance of the correct concrete type that
        /// corresponds to the particular
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration" />
        /// value that
        /// is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_AndTextMatchingConfiguration_Returns_AppropriateReplacer_ForEach_TextMatchingConfigurationValue()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseOnly
                                 ),
                Is.InstanceOf<MatchCaseOnlyTextInFilesStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchExactWordOnly
                                 ),
                Is.InstanceOf<MatchExactWordOnlyTextInFilesStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseAndExactWord
                                 ),
                Is.InstanceOf<MatchCaseAndExactWordTextInFilesStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration
                                         .NeitherMatchCaseNorExactWord
                                 ),
                Is.InstanceOf<NeitherMatchCaseNorExactWordTextInFilesStringReplacer
                >()
            );
        }

        /// <summary>
        /// Asserts that each object reference returned by the
        /// <see
        ///     cref="M:MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration" />
        /// method for the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.ReplaceTextInFiles" />
        /// value implements the
        /// <see
        ///     cref="T:MFR.Objects.IStringReplacer" />
        /// interface.
        /// </summary>
        [Test]
        public void
            Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringReplacer()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseOnly
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchExactWordOnly
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseAndExactWord
                                 ), Is.InstanceOf<IStringReplacer>()
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration
                                         .NeitherMatchCaseNorExactWord
                                 ), Is.InstanceOf<IStringReplacer>()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="P:MFR.Objects.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration" />
        /// property of each of the concrete types returned by the
        /// <see
        ///     cref="M:MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration" />
        /// method has the same value as was supplied to the method.
        /// </summary>
        [Test]
        public void
            Test_TextMatchingConfiguration_OfEachConcreteReplacerType_HasCorrectValue()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseOnly
                                 )
                                 .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchCaseOnly)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchExactWordOnly
                                 )
                                 .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchExactWordOnly)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseAndExactWord
                                 )
                                 .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchCaseAndExactWord)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
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
        ///     cref="P:MFR.Objects.IFixedOperationTypeSpecificObject.OperationType" />
        /// property of each of the objects returned by the
        /// <see
        ///     cref="M:MFR.Objects.IStringReplacerFactory.AndTextMatchingConfiguration" />
        /// method for each
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration" />
        /// value, and
        /// for the
        /// <see
        ///     cref="T:MFR.Objects.OperationType.ReplaceTextInFiles" />
        /// value, is set to that value.
        /// </summary>
        [Test]
        public void Test_OperationType_Property_IsSetTo_ReplaceTextInFiles()
        {
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseOnly
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.ReplaceTextInFiles)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchExactWordOnly
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.ReplaceTextInFiles)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseAndExactWord
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.ReplaceTextInFiles)
            );
            Assert.That(
                GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration
                                         .NeitherMatchCaseNorExactWord
                                 )
                                 .OperationType,
                Is.EqualTo(OperationType.ReplaceTextInFiles)
            );
        }
    }
}