using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.ReplaceTextInFilesStringMatcherFactory" />
    /// class.
    /// </summary>
    [TestFixture]
    public class ReplaceTextInFilesStringMatcherFactoryTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IStringMatcherFactory.AndTextMatchingConfiguration" />
        /// method returns an instance of the correct concrete type that
        /// corresponds to the particular
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration" />
        /// value that
        /// is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue()
        {
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseOnly
                                ),
                Is.InstanceOf<MatchCaseOnlyTextInFilesStringMatcher>()
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchExactWordOnly
                                ),
                Is.InstanceOf<MatchExactWordOnlyTextInFilesStringMatcher>()
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseAndExactWord
                                ),
                Is.InstanceOf<MatchCaseAndExactWordTextInFilesStringMatcher>()
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration
                                        .NeitherMatchCaseNorExactWord
                                ),
                Is.InstanceOf<NeitherMatchCaseNorExactWordTextInFilesStringMatcher
                >()
            );
        }

        /// <summary>
        /// Asserts that each object reference returned by the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IStringMatcherFactory.AndTextMatchingConfiguration" />
        /// method for the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType.ReplaceTextInFiles" />
        /// value implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IStringMatcher" />
        /// interface.
        /// </summary>
        [Test]
        public void
            Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher()
        {
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseOnly
                                ), Is.InstanceOf<IStringMatcher>()
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchExactWordOnly
                                ), Is.InstanceOf<IStringMatcher>()
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseAndExactWord
                                ), Is.InstanceOf<IStringMatcher>()
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration
                                        .NeitherMatchCaseNorExactWord
                                ), Is.InstanceOf<IStringMatcher>()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration" />
        /// property of each of the concrete types returned by the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IStringMatcherFactory.AndTextMatchingConfiguration" />
        /// method has the same value as was supplied to the method.
        /// </summary>
        [Test]
        public void
            Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue()
        {
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseOnly
                                )
                                .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchCaseOnly)
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchExactWordOnly
                                )
                                .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchExactWordOnly)
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseAndExactWord
                                )
                                .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchCaseAndExactWord)
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
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
        ///     cref="P:MassFileRenamer.Objects.IFixedOperationTypeSpecificObject.OperationType" />
        /// property of each of the objects returned by the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IStringMatcherFactory.AndTextMatchingConfiguration" />
        /// method for each
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration" />
        /// value, and
        /// for the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType.ReplaceTextInFiles" />
        /// value, is set to that value.
        /// </summary>
        [Test]
        public void Test_OperationType_Property_IsSetTo_ReplaceTextInFiles()
        {
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseOnly
                                )
                                .OperationType,
                Is.EqualTo(OperationType.ReplaceTextInFiles)
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchExactWordOnly
                                )
                                .OperationType,
                Is.EqualTo(OperationType.ReplaceTextInFiles)
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseAndExactWord
                                )
                                .OperationType,
                Is.EqualTo(OperationType.ReplaceTextInFiles)
            );
            Assert.That(
                GetStringMatcher.For(OperationType.ReplaceTextInFiles)
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