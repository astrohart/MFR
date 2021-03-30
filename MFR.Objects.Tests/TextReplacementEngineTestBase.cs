using NUnit.Framework;

namespace MFR.Objects.Tests
{
    /// <summary>
    /// Provides default implementations for unit tests and abstract methods for
    /// mandatory implementation details.
    /// </summary>
    [TestFixture]
    public abstract class TextReplacementEngineTestBase
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IConfiguration" />
        /// interface.
        /// </summary>
        protected IConfiguration Configuration
        {
            get;
            set;
        }

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.ITextReplacementEngine" />
        /// interface.
        /// </summary>
        protected ITextReplacementEngine Replacer
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        public virtual void Initialize()
        {
            Configuration = ConfigurationBuilder.Instance.SetMatchCase(false)
                                                .AndSetMatchExactWord(false)
                                                .Build();

            Assert.IsNotNull(Configuration);
            Assert.IsFalse(Configuration.MatchCase);
            Assert.IsFalse(Configuration.MatchExactWord);
        }

        /// <summary>
        /// Creates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.ITextReplacementEngine" />
        /// interface
        /// for the specified operation <paramref name="type" />.
        /// </summary>
        /// <param name="type">
        /// One of the
        /// <see
        ///     cref="T:MFR.Objects.OperationType" />
        /// values that
        /// specifies which operation to create a data-matcher object for.
        /// </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException" />
        /// Thrown if the
        /// <paramref name="type" />
        /// parameter is not set to a
        /// value that the factory supports.
        /// </exception>
        protected void CreateReplacementEngineFor(OperationType type)
            => Replacer = GetTextReplacementEngine.For(type)
                                                  .AndAttachConfiguration(
                                                      Configuration
                                                  ) as ITextReplacementEngine;
    }
}