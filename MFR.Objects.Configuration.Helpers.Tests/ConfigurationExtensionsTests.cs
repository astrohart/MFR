using MFR.Objects.Configuration.Constants;
using MFR.Objects.Tests.Common;
using NUnit.Framework;

namespace MFR.Objects.Configuration.Helpers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.ConfigurationExtensions" />
    /// class.
    /// </summary>
    [TestFixture]
    public class ConfigurationExtensionsTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration.MatchCaseAndExactWord" />
        /// enum value for a configuration object whose
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Interfaces.IConfigurationMatchCase" />
        /// property is set to
        /// <see langword="true" /> and whose
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Interfaces.IConfigurationMatchExactWord" />
        /// property is set
        /// to <see langword="true" />.
        /// </summary>
        [Test]
        public void
            Test_GetTextMatchingConfiguration_ReturnsMatchCaseAndExactWord_WhenBothMatchCaseAndMatchExactWordAreTrue()
            => Assert.IsTrue(
                TextMatchingConfiguration.MatchCaseAndExactWord ==
                ConfigurationBuilder.Instance.SetMatchCase()
                                    .AndSetMatchExactWord()
                                    .Build()
                                    .GetTextMatchingConfiguration()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration.MatchCaseOnly" />
        /// enum
        /// value for a configuration object whose
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Interfaces.IConfigurationMatchCase" />
        /// property is set to
        /// <see langword="true" /> and whose
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Interfaces.IConfigurationMatchExactWord" />
        /// property is set
        /// to <see langword="false" />.
        /// </summary>
        [Test]
        public void
            Test_GetTextMatchingConfiguration_ReturnsMatchCaseOnly_WhenOnlyMatchCaseIsTrue()
            => Assert.IsTrue(
                TextMatchingConfiguration.MatchCaseOnly == ConfigurationBuilder
                    .Instance.SetMatchCase()
                    .AndSetMatchExactWord(false)
                    .Build()
                    .GetTextMatchingConfiguration()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration.MatchExactWordOnly" />
        /// enum value for a configuration object whose
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Interfaces.IConfigurationMatchCase" />
        /// property is set to
        /// <see langword="false" /> and whose
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Interfaces.IConfigurationMatchExactWord" />
        /// property is set
        /// to <see langword="true" />.
        /// </summary>
        [Test]
        public void
            Test_GetTextMatchingConfiguration_ReturnsMatchExactWordOnly_WhenOnlyMatchExactWordIsTrue()
            => Assert.IsTrue(
                TextMatchingConfiguration.MatchExactWordOnly ==
                ConfigurationBuilder.Instance.SetMatchCase(false)
                                    .AndSetMatchExactWord()
                                    .Build()
                                    .GetTextMatchingConfiguration()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration.NeitherMatchCaseNorExactWord" />
        /// enum value for a configuration object whose
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Interfaces.IConfigurationMatchCase" />
        /// property is set to
        /// <see langword="false" /> and whose
        /// <see
        ///     cref="P:MFR.Objects.Configuration.Interfaces.IConfigurationMatchExactWord" />
        /// property is set
        /// to <see langword="false" />.
        /// </summary>
        [Test]
        public void
            Test_GetTextMatchingConfiguration_ReturnsNeitherMatchCaseNorExactWord_WhenBothMatchCaseAndMatchExactWordAreFalse()
            => Assert.IsTrue(
                TextMatchingConfiguration.NeitherMatchCaseNorExactWord ==
                ConfigurationBuilder.Instance.SetMatchCase(false)
                                    .AndSetMatchExactWord(false)
                                    .Build()
                                    .GetTextMatchingConfiguration()
            );
    }
}