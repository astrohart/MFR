﻿using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides default implementations for unit tests and abstract methods for
    /// mandatory implementation details.
    /// </summary>
    [TestFixture]
    public abstract class TextReplacementEngineTestBase
    {
        /// <summary>
        /// Whitespace value for testing.
        /// </summary>
        protected const string WHITESPACE = "   \t";

        /// <summary>
        /// The empty string (string.Empty).
        /// </summary>
        protected static readonly string EMPTY_STRING = string.Empty;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
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
        ///     cref="T:MassFileRenamer.Objects.ITextReplacementEngine" />
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
                                                .AndSetMatchWholeWord(false)
                                                .Build();

            Assert.IsNotNull(Configuration);
            Assert.IsFalse(Configuration.MatchCase);
            Assert.IsFalse(Configuration.MatchWholeWord);
        }

        /// <summary>
        /// Creates an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ITextReplacementEngine" />
        /// interface
        /// for the specified operation <paramref name="type" />.
        /// </summary>
        /// <param name="type">
        /// One of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
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