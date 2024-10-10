using PostSharp.Patterns.Threading;
using MFR.Settings.Configuration.Constants;
using MFR.Matchers.Interfaces;
using MFR.Operations.Constants;
using NUnit.Framework;

namespace MFR.Matchers.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.RenameSubFoldersStringMatcherFactory" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class RenameSubFoldersStringMatcherFactoryTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.IStringMatcherFactory.AndTextMatchingConfiguration" />
        /// method returns an instance of the correct concrete type that
        /// corresponds to the particular
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// value that
        /// is passed as its argument.
        /// </summary>
        [Test]
        public void
            Test_AndTextMatchingConfiguration_Returns_AppropriateMatcher_ForEach_TextMatchingConfigurationValue()
        {
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseOnly
                                ),
                Is.InstanceOf<MatchCaseOnlyFolderNameStringMatcher>()
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchExactWordOnly
                                ),
                Is.InstanceOf<MatchExactWordOnlyFolderNameStringMatcher>()
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseAndExactWord
                                ),
                Is.InstanceOf<MatchCaseAndExactWordFolderNameStringMatcher>()
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration
                                        .NeitherMatchCaseNorExactWord
                                ),
                Is.InstanceOf<NeitherMatchCaseNorExactWordFolderNameStringMatcher
                >()
            );
        }

        /// <summary>
        /// Asserts that each object reference returned by the
        /// <see
        ///     cref="M:MFR.IStringMatcherFactory.AndTextMatchingConfiguration" />
        /// method for the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.RenameSubFolders" />
        /// value implements the
        /// <see
        ///     cref="T:MFR.IStringMatcher" />
        /// interface.
        /// </summary>
        [Test]
        public void
            Test_AndTextMatchingConfiguration_Returns_ImplementerOf_IStringMatcher()
        {
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseOnly
                                ), Is.InstanceOf<IStringMatcher>()
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchExactWordOnly
                                ), Is.InstanceOf<IStringMatcher>()
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseAndExactWord
                                ), Is.InstanceOf<IStringMatcher>()
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration
                                        .NeitherMatchCaseNorExactWord
                                ), Is.InstanceOf<IStringMatcher>()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="P:MFR.IFixedTextMatchingConfigurationSpecificObject.TextMatchingConfiguration" />
        /// property of each of the concrete types returned by the
        /// <see
        ///     cref="M:MFR.IStringMatcherFactory.AndTextMatchingConfiguration" />
        /// method has the same value as was supplied to the method.
        /// </summary>
        [Test]
        public void
            Test_TextMatchingConfiguration_OfEachConcreteMatcherType_HasCorrectValue()
        {
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseOnly
                                )
                                .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchCaseOnly)
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchExactWordOnly
                                )
                                .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchExactWordOnly)
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseAndExactWord
                                )
                                .TextMatchingConfiguration,
                Is.EqualTo(TextMatchingConfiguration.MatchCaseAndExactWord)
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
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
        ///     cref="M:MFR.IStringMatcherFactory.AndTextMatchingConfiguration" />
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
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseOnly
                                )
                                .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchExactWordOnly
                                )
                                .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
                                .AndTextMatchingConfiguration(
                                    TextMatchingConfiguration.MatchCaseAndExactWord
                                )
                                .OperationType,
                Is.EqualTo(OperationType.RenameSubFolders)
            );
            Assert.That(
                GetStringMatcherFactory.For(OperationType.RenameSubFolders)
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