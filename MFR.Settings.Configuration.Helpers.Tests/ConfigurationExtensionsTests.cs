using MFR.Settings.Configuration.Constants;
using MFR.Tests.Common;
using NUnit.Framework;

namespace MFR.Settings.Configuration.Helpers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Settings.ConfigurationExtensions" />
    /// class.
    /// </summary>
    [TestFixture]
    public class ConfigurationExtensionsTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration.MatchCaseAndExactWord" />
        /// enum value for a projectFileRenamerConfiguration object whose
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchCase" />
        /// property is set to
        /// <see langword="true" /> and whose
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchExactWord" />
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
        ///     cref="M:MFR.Settings.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration.MatchCaseOnly" />
        /// enum
        /// value for a projectFileRenamerConfiguration object whose
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchCase" />
        /// property is set to
        /// <see langword="true" /> and whose
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchExactWord" />
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
        ///     cref="M:MFR.Settings.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration.MatchExactWordOnly" />
        /// enum value for a projectFileRenamerConfiguration object whose
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchCase" />
        /// property is set to
        /// <see langword="false" /> and whose
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchExactWord" />
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
        ///     cref="M:MFR.Settings.ConfigurationExtensions.GetTextMatchingConfiguration" />
        /// method returns the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration.NeitherMatchCaseNorExactWord" />
        /// enum value for a projectFileRenamerConfiguration object whose
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchCase" />
        /// property is set to
        /// <see langword="false" /> and whose
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IConfigurationMatchExactWord" />
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
