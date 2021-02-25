using NUnit.Framework;
using System;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.TextExpressionMatcher" />
    /// class.
    /// </summary>
    [TestFixture]
    public class TextExpressionMatcherTests
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            _configuration =
                new Configuration {MatchWholeWord = true, MatchCase = true};
            _matcher = new TextExpressionMatcher(_configuration);
        }

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// interface.
        /// </summary>
        private IConfiguration _configuration;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ITextExpressionMatcher" />
        /// interface.
        /// </summary>
        private ITextExpressionMatcher _matcher;

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for both of its parameters.
        /// </summary>
        [Test]
        public void
            Test_ArgumentException_Thrown_If_BothParams_Of_IsMatch_Method_AreBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(string.Empty, string.Empty)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if strings
        /// containing whitespace are passed for both of its parameters.
        /// </summary>
        [Test]
        public void
            Test_ArgumentException_Thrown_If_BothParams_Of_IsMatch_Method_AreNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(null, null)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if strings
        /// containing whitespace are passed for both of its parameters.
        /// </summary>
        [Test]
        public void
            Test_ArgumentException_Thrown_If_BothParams_Of_IsMatch_Method_AreWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("   \t", "   \t")
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its first parameter, with a non-blank string passed in
        /// the second.
        /// </summary>
        [Test]
        public void
            Test_ArgumentException_Thrown_If_FirstParam_Of_IsMatch_Method_IsBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(string.Empty, "Foo")
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if a <c>null</c>
        /// value is passed for its first parameter, with a non-blank string
        /// passed in the second.
        /// </summary>
        [Test]
        public void
            Test_ArgumentException_Thrown_If_FirstParam_Of_IsMatch_Method_IsNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(null, "Foo")
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if a string
        /// containing whitespace is passed for the first parameter, with a
        /// non-blank string being passed for the second.
        /// </summary>
        [Test]
        public void
            Test_ArgumentException_Thrown_If_FirstParam_Of_IsMatch_Method_IsWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("   \t", "Foo")
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its second parameter, with a non-blank string passed
        /// in the first.
        /// </summary>
        [Test]
        public void
            Test_ArgumentException_Thrown_If_SecondParam_Of_IsMatch_Method_IsBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("Foo", string.Empty)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the <c>null</c>
        /// string is passed for the second parameter.
        /// </summary>
        [Test]
        public void
            Test_ArgumentException_Thrown_If_SecondParam_Of_IsMatch_Method_IsNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("Foo", null)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if a string
        /// containing whitespace is passed for the second parameter, with a
        /// non-blank string being passed for the first.
        /// </summary>
        [Test]
        public void
            Test_ArgumentException_Thrown_If_SecondParam_Of_IsMatch_Method_IsWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("Foo", "   \t")
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>false</c> in the event that (a) MatchCase = MatchWholeWord
        /// = true in the configuration, (b) the source string does contain the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceContainsPattern_WhenMatchWholeWord_And_MatchCase_AreTurnedOn()
        {
            _matcher.Configuration =
                new Configuration {MatchCase = true, MatchWholeWord = true};
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Foo"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Foo"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>false</c> in the event that (a) MatchCase = false and MatchWholeWord
        /// = true in the configuration, (b) the source string contains the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case but the cases match in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceContainsPattern_WhenMatchWholeWord_IsTurnedOn_And_MatchCase_IsTurnedOff()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = false, MatchWholeWord = true
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Foo"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Foo"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>false</c> in the event that (a) MatchCase = true and MatchWholeWord
        /// = false in the configuration, (b) the source string does not contain the
        /// pattern string as a substring, and even if (c) the cases do not match in the
        /// first sub-case but the cases match in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchWholeWord_IsTurnedOff_And_MatchCase_IsTurnedOn()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = true, MatchWholeWord = false
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "bar"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>true</c> in the event that (a) MatchCase = true and MatchWholeWord
        /// = false in the configuration, (b) the source string contains the
        /// pattern string as a substring, and if (c) the cases match in the
        /// first sub-case and in the second.
        /// </summary>
        [Test]
        public void
            Test_TrueReturned_IfSourceContainsPattern_WhenMatchWholeWord_IsTurnedOff_And_MatchCase_IsTurnedOn()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = true, MatchWholeWord = false
            };
            Assert.IsTrue(_matcher.IsMatch("foo.tests", "foo"));
            Assert.IsTrue(_matcher.IsMatch("Foo.Tests", "Foo"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>false</c> in the event that (a) MatchCase = true and MatchWholeWord
        /// = false in the configuration, (b) the source string contains the
        /// pattern string as a substring, but (c) the cases do not match in neither the
        /// first sub-case nor in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceContainsPattern_WhenMatchWholeWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = true, MatchWholeWord = false
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Foo"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "foo"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>false</c> in the event that (a) MatchCase = true and MatchWholeWord
        /// = false in the configuration, (b) the source string does not contain the
        /// pattern string as a substring, but (c) the cases do not match in neither the
        /// first sub-case nor in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchWholeWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = true, MatchWholeWord = false
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Bar"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>false</c> in the event that (a) MatchCase = true and MatchWholeWord
        /// = false in the configuration, (b) the source string does not contain the
        /// pattern string as a substring, but (c) the cases match in both the
        /// first sub-case and in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchWholeWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesMatch()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = true, MatchWholeWord = false
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "bar"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Bar"));
        }

        /** -- STOPPED HERE -- **/

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>false</c> in the event that (a) MatchCase = MatchWholeWord
        /// = false in the configuration, (b) the source string does not contain the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchWholeWord_And_MatchCase_AreTurnedOff()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = false, MatchWholeWord = false
            };
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Bar"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>true</c> in the event that (a) MatchCase = false and MatchWholeWord
        /// = true in the configuration, (b) the source string exactly matches the
        /// pattern string, and (c) the cases do not match in the first sub-case
        /// but the cases match in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceExactlyMatchesPattern_WhenMatchWholeWord_IsTurnedOn_And_MatchCase_IsTurnedOff()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = false, MatchWholeWord = true
            };
            Assert.IsTrue(_matcher.IsMatch("foo", "Foo"));
            Assert.IsTrue(_matcher.IsMatch("Foo", "Foo"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>true</c> in the event that (a) MatchCase = MatchWholeWord
        /// = true in the configuration, (b) the source string exactly matches the
        /// pattern string as a substring, except if (c) the cases do not match
        /// in the first sub-case.
        /// </summary>
        [Test]
        public void
            Test_FalseReturnedIfCaseDoesNotMatch_AndTrueReturnedWhenCaseDoesMatch_IfSourceExactlyMatchesPattern_WhenMatchWholeWord_And_MatchCase_AreTurnedOn()
        {
            _matcher.Configuration =
                new Configuration {MatchCase = true, MatchWholeWord = true};
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Foo.Tests"));
            Assert.IsTrue(_matcher.IsMatch("Foo.Tests", "Foo.Tests"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>true</c> in the event that (a) MatchCase = MatchWholeWord
        /// = true in the configuration, and (b) the source string exactly matches the
        /// pattern string as a substring (including case).
        /// </summary>
        [Test]
        public void
            Test_TrueReturned_WhenSourceExactlyMatchesPattern_WhenMatchWholeWord_And_MatchCase_AreTurnedOn()
        {
            _matcher.Configuration =
                new Configuration {MatchCase = true, MatchWholeWord = true};
            Assert.IsTrue(_matcher.IsMatch("Foo.Tests", "Foo.Tests"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>false</c> in the event that (a) MatchCase = MatchWholeWord
        /// = true in the configuration, (b) the source string does not exactly match the
        /// pattern string as a substring, and if (c) the cases do not match
        /// in the first sub-case.
        /// </summary>
        [Test]
        public void
            Test_FalseReturnedIfCaseDoesNotMatch_AndFalseReturnedWhenCaseDoesMatch_IfSourceDoesNotExactlyMatchesPattern_WhenMatchWholeWord_And_MatchCase_AreTurnedOn()
        {
            _matcher.Configuration =
                new Configuration {MatchCase = true, MatchWholeWord = true};
            Assert.IsFalse(_matcher.IsMatch("foo.tests", "Bar"));
            Assert.IsFalse(_matcher.IsMatch("Foo.Tests", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// does not throw any exception if it is passed non-blank strings for
        /// each of its respective parameters.
        /// </summary>
        [Test]
        public void
            Test_NoException_Thrown_If_BothParams_OfIsMatch_Method_AreNonBlank()
            => Assert.DoesNotThrow(() => _matcher.IsMatch("Foo", "Bar"));

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.IsMatch" />
        /// method
        /// returns <c>true</c> in the event that (a) MatchCase = MatchWholeWord
        /// = false in the configuration, (b) the source string contains the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case.
        /// </summary>
        [Test]
        public void
            Test_TrueReturned_IfSourceContainsPattern_WhenMatchWholeWord_And_MatchCase_AreTurnedOff()
        {
            _matcher.Configuration = new Configuration {
                MatchCase = false, MatchWholeWord = false
            };
            Assert.IsTrue(_matcher.IsMatch("foo.tests", "Foo"));
            Assert.IsTrue(_matcher.IsMatch("Foo.Tests", "Foo"));
        }
    }
}