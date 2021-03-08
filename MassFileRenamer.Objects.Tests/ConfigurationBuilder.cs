namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Builds instances of fake
    /// <see
    ///     cref="T:MassFileRenamer.Objects.Configuration" />
    /// objects in a fluent
    /// manner, initialized for unit tests.
    /// </summary>
    public class ConfigurationBuilder
    {
        /// <summmary>
        /// Determines whether the case should be matched during a
        /// search for a string. </summary>
        private bool _matchCase;

        /// <summmary>
        /// Determines whether a whole word should be matched when
        /// searching for a string value. </summary>
        private bool _matchWholeWord;

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
        /// <see cref="T:MassFileRenamer.Objects.Tests.ConfigurationBuilder" />.
        /// </summary>
        public static ConfigurationBuilder Instance
        {
            get;
        } = new ConfigurationBuilder();

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// interface.
        /// </returns>
        /// <remarks>
        /// The new instance's properties are initialized with the values
        /// provided to this class' other methods.
        /// </remarks>
        public IConfiguration Build()
            => new Configuration {
                MatchCase = _matchCase, MatchWholeWord = _matchWholeWord
            };

        /// <summary>
        /// Sets the value of the
        /// <see
        ///     cref="F:MassFileRenamer.Objects.Tests.ConfigurationBuilder._matchCase" />
        /// field to the value of the <paramref name="matchCase"/> parameter.
        /// </summary>
        /// <param name="matchCase">
        /// (Optional.) New value for the
        /// <see
        ///     cref="F:MassFileRenamer.Objects.Tests.ConfigurationBuilder._matchCase" />
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

        /// <summary>
        /// Sets the value of the
        /// <see
        ///     cref="F:MassFileRenamer.Objects.Tests.ConfigurationBuilder._matchWholeWord" />
        /// field to the value of the <paramref name="matchWholeWord" /> parameter.
        /// </summary>
        /// <param name="matchWholeWord">
        /// (Optional.) New value for the
        /// <see
        ///     cref="F:MassFileRenamer.Objects.Tests.ConfigurationBuilder._matchWholeWord" />
        /// field. Default is <c>true</c>.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public ConfigurationBuilder AndSetMatchWholeWord(
            bool matchWholeWord = true)

        {
            _matchWholeWord = matchWholeWord;

            return this;
        }
    }
}