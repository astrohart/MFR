using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.ConfigurationExtensions" />
    /// class.
    /// </summary>
    [TestFixture]
    public class ConfigurationExtensionsTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ConfigurationExtensions.GetMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration.MatchCaseAndWholeWord" />
        /// enum value for a configuration object whose
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IConfiguration.MatchCase" />
        /// property
        /// is set to <see langword="true" /> and whose
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IConfiguration.MatchWholeWord" />
        /// property is set to <see langword="true" />.
        /// </summary>
        [Test]
        public void
            Test_GetMatchingConfiguration_ReturnsMatchCaseAndWholeWord_WhenBothMatchCaseAndMatchWholeWordAreTrue()
            => Assert.IsTrue(
                MatchingConfiguration.MatchCaseAndWholeWord ==
                ConfigurationBuilder.Instance.SetMatchCase()
                                    .AndSetMatchWholeWord()
                                    .Build()
                                    .GetMatchingConfiguration()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ConfigurationExtensions.GetMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration.MatchCaseOnly" />
        /// enum value for a configuration object whose
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IConfiguration.MatchCase" />
        /// property
        /// is set to <see langword="true" /> and whose
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IConfiguration.MatchWholeWord" />
        /// property is set to <see langword="false" />.
        /// </summary>
        [Test]
        public void
            Test_GetMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue()
            => Assert.IsTrue(
                MatchingConfiguration.MatchCaseOnly == ConfigurationBuilder
                    .Instance.SetMatchCase()
                    .AndSetMatchWholeWord(false)
                    .Build()
                    .GetMatchingConfiguration()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ConfigurationExtensions.GetMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration.MatchWholeWordOnly" />
        /// enum value for a configuration object whose
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IConfiguration.MatchCase" />
        /// property
        /// is set to <see langword="false" /> and whose
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IConfiguration.MatchWholeWord" />
        /// property is set to <see langword="true" />.
        /// </summary>
        [Test]
        public void
            Test_GetMatchingConfiguration_ReturnsMatchWholeWordOnly_WhenOnlyMatchWholeWordIsTrue()
            => Assert.IsTrue(
                MatchingConfiguration.MatchWholeWordOnly == ConfigurationBuilder
                    .Instance.SetMatchCase(false)
                    .AndSetMatchWholeWord()
                    .Build()
                    .GetMatchingConfiguration()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ConfigurationExtensions.GetMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration.NeitherMatchCaseNorWholeWord" />
        /// enum value for a configuration object whose
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IConfiguration.MatchCase" />
        /// property
        /// is set to <see langword="false" /> and whose
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IConfiguration.MatchWholeWord" />
        /// property is set to <see langword="false" />.
        /// </summary>
        [Test]
        public void
            Test_GetMatchingConfiguration_ReturnsNeitherMatchCaseNorWholeWord_WhenBothMatchCaseAndMatchWholeWordAreFalse()
            => Assert.IsTrue(
                MatchingConfiguration.NeitherMatchCaseNorWholeWord ==
                ConfigurationBuilder.Instance.SetMatchCase(false)
                                    .AndSetMatchWholeWord(false)
                                    .Build()
                                    .GetMatchingConfiguration()
            );
    }
}