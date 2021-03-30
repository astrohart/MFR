using MFR.Objects.Tests.Common;
using NUnit.Framework;
using System;

namespace MFR.Objects.Tests
{
    /// <summary>
    /// Provides default implementations for unit tests and abstract methods for
    /// mandatory implementation details.
    /// </summary>
    [TestFixture]
    public abstract class TextExpressionMatchingEngineTestBase
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IConfiguration" />
        /// interface.
        /// </summary>
        protected IConfiguration _configuration;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
        /// interface.
        /// </summary>
        protected ITextExpressionMatchingEngine _matcher;

        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        public virtual void Initialize()
        {
            _configuration = ConfigurationBuilder.Instance.SetMatchCase(false)
                                                 .AndSetMatchExactWord(false)
                                                 .Build();

            Assert.IsNotNull(_configuration);
            Assert.IsFalse(_configuration.MatchCase);
            Assert.IsFalse(_configuration.MatchExactWord);
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for all three of its parameters.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_NotThrown_If_AllThreeParams_Of_IsMatch_Method_AreNonBlank()
            => Assert.DoesNotThrow(() => _matcher.IsMatch("Foo", "Bar", "Baz"));

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for all three of its parameters.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.EMPTY_STRING, StringConstants.EMPTY_STRING,
                    StringConstants.EMPTY_STRING
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if strings
        /// containing whitespace are passed for all three of its parameters.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(null, null, null)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if strings
        /// containing whitespace are passed for all three of its parameters.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_AllThreeParams_Of_IsMatch_Method_AreWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.WHITESPACE, StringConstants.WHITESPACE,
                    StringConstants.WHITESPACE
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for its first and second parameters, with a
        /// non-blank string passed in the third.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.EMPTY_STRING, StringConstants.EMPTY_STRING,
                    "Foo"
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for its first and second parameters, with a
        /// non-blank string passed in the third.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(null, null, "Foo")
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for its first and second parameters, with a
        /// non-blank string passed in the third.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.WHITESPACE, StringConstants.WHITESPACE,
                    "Foo"
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for its first and third parameters, with a
        /// non-blank string passed in the second.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.EMPTY_STRING, "Foo",
                    StringConstants.EMPTY_STRING
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for its first and third parameters, with a
        /// non-blank string passed in the second.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(null, "Foo", null)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for its first and third parameters, with a
        /// non-blank string passed in the second.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.WHITESPACE, "Foo",
                    StringConstants.WHITESPACE
                )
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if only the
        /// first parameter is the empty string.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
        /// do not
        /// require the first parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.EMPTY_STRING, "Foo", "Bar"
                )
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if only the
        /// first parameter is <see langword="null" />.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
        /// do not
        /// require the first parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(null, "Foo", "Bar")
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if only the
        /// first parameter is whitespace.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
        /// do not
        /// require the first parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(StringConstants.WHITESPACE, "Foo", "Bar")
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if only the
        /// second parameter is the empty string.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
        /// do not
        /// require the second parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    "Foo", StringConstants.EMPTY_STRING, "Bar"
                )
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if only the
        /// second parameter is <see langword="null" />.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
        /// do not
        /// require the second parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("Foo", null, "Bar")
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if only the
        /// second parameter is whitespace.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
        /// do not
        /// require the second parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("Foo", StringConstants.WHITESPACE, "Bar")
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if only the
        /// third parameter is the empty string.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
        /// do not
        /// require the third parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    "Foo", "Bar", StringConstants.EMPTY_STRING
                )
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if only the
        /// third parameter is <see langword="null" />.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
        /// do not
        /// require the third parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("Foo", "Bar", null)
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if only the
        /// third parameter is whitespace.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
        /// do not
        /// require the third parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("Foo", "Bar", StringConstants.WHITESPACE)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for its second and third parameters, with a
        /// non-blank string passed in the first.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    "Foo", StringConstants.EMPTY_STRING,
                    StringConstants.EMPTY_STRING
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for its second and third parameters, with a
        /// non-blank string passed in the first.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("Foo", null, null)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method throws <see cref="T:System.ArgumentException" /> if the empty
        /// string is passed for its second and third parameters, with a
        /// non-blank string passed in the first.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    "Foo", StringConstants.WHITESPACE,
                    StringConstants.WHITESPACE
                )
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="false" /> in the event that (a) MatchCase = true
        /// and MatchExactWord
        /// = false in the configuration, (b) the source string contains the
        /// pattern string as a substring, but (c) the cases do not match in
        /// neither the first sub-case nor in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = true, MatchExactWord = false
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Foo", "Bar"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "foo", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="false" /> in the event that (a) MatchCase = false
        /// and MatchExactWord
        /// = true in the configuration, (b) the source string contains the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case but the cases match in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = false, MatchExactWord = true
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Foo", "Bar"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Foo", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="false" /> in the event that (a) MatchCase = MatchExactWord
        /// = false in the configuration, (b) the source string does not contain the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = false, MatchExactWord = false
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Bar", "Baz"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Bar", "Baz"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="false" /> in the event that (a) MatchCase = true
        /// and MatchExactWord
        /// = false in the configuration, (b) the source string does not contain the
        /// pattern string as a substring, and even if (c) the cases do not
        /// match in the first sub-case but the cases match in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = true, MatchExactWord = false
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "bar", "baz"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Bar", "Baz"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="false" /> in the event that (a) MatchCase = true
        /// and MatchExactWord
        /// = false in the configuration, (b) the source string does not contain the
        /// pattern string as a substring, but (c) the cases do not match in
        /// neither the first sub-case nor in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = true, MatchExactWord = false
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Bar", "Baz"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "bar", "baz"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="false" /> in the event that (a) MatchCase = true
        /// and MatchExactWord
        /// = false in the configuration, (b) the source string does not contain the
        /// pattern string as a substring, but (c) the cases match in both the
        /// first sub-case and in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesMatch()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = true, MatchExactWord = false
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "bar", "baz"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Bar", "Baz"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="true" /> in the event that (a) MatchCase = false
        /// and MatchExactWord
        /// = true in the configuration, (b) the source string exactly matches the
        /// pattern string, and (c) the cases do not match in the first sub-case
        /// but the cases match in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceExactlyMatchesPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = false, MatchExactWord = true
            };
            Assert.IsTrue(_matcher.IsMatch("foo", "Foo", "Bar"));
            Assert.IsTrue(_matcher.IsMatch("Foo", "Foo", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="false" /> in the event that (a) MatchCase = MatchExactWord
        /// = true in the configuration, (b) the source string does not exactly
        /// match the pattern string as a substring, and if (c) the cases do not
        /// match in the first sub-case.
        /// </summary>
        [Test]
        public void
            Test_FalseReturnedIfCaseDoesNotMatch_AndFalseReturnedWhenCaseDoesMatch_IfSourceDoesNotExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn()
        {
            _matcher.Configuration =
                new Configuration {MatchCase = true, MatchExactWord = true};
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Bar", "Baz"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Bar", "Baz"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="true" /> in the event that (a) MatchCase = MatchExactWord
        /// = true in the configuration, (b) the source string exactly matches the
        /// pattern string as a substring, except if (c) the cases do not match
        /// in the first sub-case.
        /// </summary>
        [Test]
        public void
            Test_FalseReturnedIfCaseDoesNotMatch_AndTrueReturnedWhenCaseDoesMatch_IfSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn()
        {
            _matcher.Configuration =
                new Configuration {MatchCase = true, MatchExactWord = true};
            Assert.IsFalse(
                _matcher.IsMatch("foo.tests", "Foo.Tests", "Bar.Tests")
            );
            Assert.IsTrue(
                _matcher.IsMatch("Foo.Tests", "Foo.Tests", "Bar.Tests")
            );
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="true" /> in the event that (a) MatchCase = MatchExactWord
        /// = false in the configuration, (b) the source string contains the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case.
        /// </summary>
        [Test]
        public void
            Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = false, MatchExactWord = false
            };
            Assert.IsTrue(_matcher.IsMatch("foo.tests", "Foo", "Bar"));
            Assert.IsTrue(_matcher.IsMatch("Foo.Tests", "Foo", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="true" /> in the event that (a) MatchCase = true
        /// and MatchExactWord
        /// = false in the configuration, (b) the source string contains the
        /// pattern string as a substring, and if (c) the cases match in the
        /// first sub-case and in the second.
        /// </summary>
        [Test]
        public void
            Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = true, MatchExactWord = false
            };
            Assert.IsTrue(_matcher.IsMatch("foo.tests", "foo", "Bar"));
            Assert.IsTrue(_matcher.IsMatch("Foo.Tests", "Foo", "Bar"));
        }

        /// -- STOPPED HERE -- *
        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="true" /> in the event that (a) MatchCase = MatchExactWord
        /// = true in the configuration, and (b) the source string exactly
        /// matches the pattern string as a substring (including case).
        /// </summary>
        [Test]
        public void
            Test_TrueReturned_WhenSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn()
        {
            _matcher.Configuration =
                new Configuration {MatchCase = true, MatchExactWord = true};
            Assert.IsTrue(
                _matcher.IsMatch("Foo.Tests", "Foo.Tests", "Bar.Tests")
            );
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.ITextExpressionMatchingEngine.IsMatch" />
        /// method returns <see langword="false" /> in the event that (a) MatchCase = MatchExactWord
        /// = true in the configuration, (b) the source string does contain the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case.
        /// </summary>
        [Test]
        public void
            Test_WhenMatchCaseOn_AndMatchExactWordOn_FalseReturned_IfSourceContainsPattern()
        {
            _matcher.Configuration =
                new Configuration {MatchCase = true, MatchExactWord = true};
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Foo", "Bar"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Foo", "Bar"));
        }

        /// <summary>
        /// Creates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.ITextExpressionMatchingEngine" />
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
        protected void CreateMatchingEngineFor(OperationType type)
            => _matcher = GetTextExpressionMatchingEngine.For(type)
                                                  .AndAttachConfiguration(
                                                      _configuration
                                                  ) as ITextExpressionMatchingEngine;
    }
}