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
        ///     cref="M:MassFileRenamer.Objects.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration.MatchCaseAndWholeWord" />
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
            Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndWholeWord_WhenBothMatchCaseAndMatchWholeWordAreTrue()
            => Assert.IsTrue(
                TextMatchingConfiguration.MatchCaseAndWholeWord ==
                ConfigurationBuilder.Instance.SetMatchCase()
                                    .AndSetMatchWholeWord()
                                    .Build()
                                    .GetTextMatchingConfiguration()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration.MatchCaseOnly" />
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
            Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue()
            => Assert.IsTrue(
                TextMatchingConfiguration.MatchCaseOnly == ConfigurationBuilder
                    .Instance.SetMatchCase()
                    .AndSetMatchWholeWord(false)
                    .Build()
                    .GetTextMatchingConfiguration()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration.MatchWholeWordOnly" />
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
            Test_GetTextMatchingConfiguration_ReturnsMatchWholeWordOnly_WhenOnlyMatchWholeWordIsTrue()
            => Assert.IsTrue(
                TextMatchingConfiguration.MatchWholeWordOnly == ConfigurationBuilder
                    .Instance.SetMatchCase(false)
                    .AndSetMatchWholeWord()
                    .Build()
                    .GetTextMatchingConfiguration()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration.NeitherMatchCaseNorWholeWord" />
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
            Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorWholeWord_WhenBothMatchCaseAndMatchWholeWordAreFalse()
            => Assert.IsTrue(
                TextMatchingConfiguration.NeitherMatchCaseNorWholeWord ==
                ConfigurationBuilder.Instance.SetMatchCase(false)
                                    .AndSetMatchWholeWord(false)
                                    .Build()
                                    .GetTextMatchingConfiguration()
            );
    }
}