using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Interfaces;
using NUnit.Framework;

namespace MFR.Tests.Common
{
    /// <summary>
    /// Builds instances of fake
    /// <see
    ///     cref="T:MFR.Settings.Configuration.ProjectFileRenamerConfig" />
    /// objects in a fluent
    /// manner, initialized for unit tests.
    /// </summary>
    public class ConfigurationBuilder
    {
        /// <summary>
        /// Determines whether the case should be matched during a search for a string.
        /// </summary>
        private bool _matchCase;

        /// <summary>
        /// Determines whether a whole word should be matched when searching for
        /// a string value.
        /// </summary>
        private bool _matchExactWord;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ConfigurationBuilder() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ConfigurationBuilder() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Tests.Common.ConfigurationBuilder" />.
        /// </summary>
        public static ConfigurationBuilder Instance
        {
            get;
        } = new ConfigurationBuilder();

        /// <summary>
        /// Provides an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Interfaces.IProfile" />
        /// interface with its
        /// <paramref
        ///     name="matchCase" />
        /// and <paramref name="matchExactWord" /> settings
        /// configured as specified for the current use case.
        /// </summary>
        /// <param name="matchCase">
        /// (Required.) Specifies whether the case is matched when searching and replacing.
        /// </param>
        /// <param name="matchExactWord">
        /// (Required.) Specifies whether search text must be a part of another
        /// word or pattern or can only be matched if it consists of a whole word.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Interfaces.IProfile" />
        /// interface whose
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfigurationMatchCase" />
        /// and
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfigurationMatchExactWord" />
        /// properties are set to the same values as were passed for the
        /// <paramref name="matchCase" /> and <paramref name="matchExactWord" />
        /// parameters.
        /// </returns>
        public static IProjectFileRenamerConfig BuildConfigurationForUseCase(
            bool matchCase, bool matchExactWord)
        {
            var configuration = Instance.SetMatchCase(matchCase)
                                        .AndSetMatchExactWord(matchExactWord)
                                        .Build();

            Assert.That(configuration, Is.Not.Null);
            Assert.That(matchCase, Is.EqualTo(configuration.MatchCase));
            Assert.That(matchExactWord, Is.EqualTo(configuration.MatchExactWord));

            return configuration;
        }

        /// <summary>
        /// Sets the value of the
        /// <see
        ///     cref="F:MFR.Tests.Common.ConfigurationBuilder._matchExactWord" />
        /// field to the value of the <paramref name="matchExactWord" /> parameter.
        /// </summary>
        /// <param name="matchExactWord">
        /// (Optional.) New value for the
        /// <see
        ///     cref="F:MFR.Tests.Common.ConfigurationBuilder._matchExactWord" />
        /// field. Default is <see langword="true" />.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public ConfigurationBuilder AndSetMatchExactWord(
            bool matchExactWord = true)

        {
            _matchExactWord = matchExactWord;

            return this;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Interfaces.IProfile" />
        /// interface and returns a
        /// reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Interfaces.IProfile" />
        /// interface.
        /// </returns>
        /// <remarks>
        /// The new instance's properties are initialized with the values
        /// provided to this class' other methods.
        /// </remarks>
        public IProjectFileRenamerConfig Build()
            => new ProjectFileRenamerConfig {
                MatchCase = _matchCase, MatchExactWord = _matchExactWord
            };

        /// <summary>
        /// Sets the value of the
        /// <see
        ///     cref="F:MFR.Tests.Common.ConfigurationBuilder._matchCase" />
        /// field to the value of the <paramref name="matchCase" /> parameter.
        /// </summary>
        /// <param name="matchCase">
        /// (Optional.) New value for the
        /// <see
        ///     cref="F:MFR.Tests.Common.ConfigurationBuilder._matchCase" />
        /// field. Default is <c>true.</c>
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public ConfigurationBuilder SetMatchCase(bool matchCase = true)
        {
            _matchCase = matchCase;

            return this;
        }
    }
}