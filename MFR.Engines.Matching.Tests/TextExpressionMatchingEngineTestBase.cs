/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */

using MFR.Settings.Configuration.Interfaces;
using MFR.Engines.Matching.Factories;
using MFR.Engines.Matching.Interfaces;
using MFR.Operations.Constants;
using MFR.Settings.Configuration;
using MFR.Tests.Common;
using NUnit.Framework;
using System;

namespace MFR.Engines.Matching.Tests
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
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        protected IProjectFileRenamerConfig ProjectFileRenamerConfig;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// interface.
        /// </summary>
        protected ITextExpressionMatchingEngine _matcher;

        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        public virtual void Initialize()
        {
            ProjectFileRenamerConfig = ConfigurationBuilder.Instance.SetMatchCase(false)
                                                 .AndSetMatchExactWord(false)
                                                 .Build();

            Assert.That(ProjectFileRenamerConfig, Is.Not.Null);
            Assert.That(!ProjectFileRenamerConfig.MatchCase);
            Assert.That(!ProjectFileRenamerConfig.MatchExactWord);
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for all three of its parameters.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_NotThrown_If_AllThreeParams_Of_IsMatch_Method_AreNonBlank()
            => Assert.DoesNotThrow(() => _matcher.IsMatch("MFR.Directories.Validators.Constants.Generators", "Bar", "Baz"));

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for all three of its parameters.
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
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if strings
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
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if strings
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
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its first and second parameters, with a non-blank
        /// string passed in the third.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.EMPTY_STRING, StringConstants.EMPTY_STRING,
                    "MFR.Directories.Validators.Constants.Generators"
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its first and second parameters, with a non-blank
        /// string passed in the third.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(null, null, "MFR.Directories.Validators.Constants.Generators")
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its first and second parameters, with a non-blank
        /// string passed in the third.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndSecondParams_Of_IsMatch_Method_AreWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.WHITESPACE, StringConstants.WHITESPACE,
                    "MFR.Directories.Validators.Constants.Generators"
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its first and third parameters, with a non-blank
        /// string passed in the second.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.EMPTY_STRING, "MFR.Directories.Validators.Constants.Generators",
                    StringConstants.EMPTY_STRING
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its first and third parameters, with a non-blank
        /// string passed in the second.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(null, "MFR.Directories.Validators.Constants.Generators", null)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its first and third parameters, with a non-blank
        /// string passed in the second.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_FirstAndThirdParams_Of_IsMatch_Method_AreWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.WHITESPACE, "MFR.Directories.Validators.Constants.Generators",
                    StringConstants.WHITESPACE
                )
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if only the first
        /// parameter is the empty string.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// do not require
        /// the first parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    StringConstants.EMPTY_STRING, "MFR.Directories.Validators.Constants.Generators", "Bar"
                )
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if only the first
        /// parameter is <see langword="null" />.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// do not require
        /// the first parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(null, "MFR.Directories.Validators.Constants.Generators", "Bar")
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if only the first
        /// parameter is whitespace.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// do not require
        /// the first parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyFirstParam_Of_IsMatch_Method_IsWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(StringConstants.WHITESPACE, "MFR.Directories.Validators.Constants.Generators", "Bar")
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if only the second
        /// parameter is the empty string.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// do not require
        /// the second parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    "MFR.Directories.Validators.Constants.Generators", StringConstants.EMPTY_STRING, "Bar"
                )
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if only the second
        /// parameter is <see langword="null" />.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// do not require
        /// the second parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("MFR.Directories.Validators.Constants.Generators", null, "Bar")
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if only the second
        /// parameter is whitespace.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// do not require
        /// the second parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlySecondParam_Of_IsMatch_Method_IsWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("MFR.Directories.Validators.Constants.Generators", StringConstants.WHITESPACE, "Bar")
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if only the third
        /// parameter is the empty string.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// do not require
        /// the third parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    "MFR.Directories.Validators.Constants.Generators", "Bar", StringConstants.EMPTY_STRING
                )
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if only the third
        /// parameter is <see langword="null" />.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// do not require
        /// the third parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("MFR.Directories.Validators.Constants.Generators", "Bar", null)
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if only the third
        /// parameter is whitespace.
        /// </summary>
        /// <remarks>
        /// This test method is marked <c>virtual</c> so that it can be
        /// overriden for the case where implementations of
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// do not require
        /// the third parameter.
        /// </remarks>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_OnlyThirdParam_Of_IsMatch_Method_IsWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("MFR.Directories.Validators.Constants.Generators", "Bar", StringConstants.WHITESPACE)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its second and third parameters, with a non-blank
        /// string passed in the first.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreBlank()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    "MFR.Directories.Validators.Constants.Generators", StringConstants.EMPTY_STRING,
                    StringConstants.EMPTY_STRING
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its second and third parameters, with a non-blank
        /// string passed in the first.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreNull()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch("MFR.Directories.Validators.Constants.Generators", null, null)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// throws <see cref="T:System.ArgumentException" /> if the empty string
        /// is passed for its second and third parameters, with a non-blank
        /// string passed in the first.
        /// </summary>
        [Test]
        public virtual void
            Test_ArgumentException_Thrown_If_SecondAndThirdParams_Of_IsMatch_Method_AreWhitespace()
            => Assert.Throws<ArgumentException>(
                () => _matcher.IsMatch(
                    "MFR.Directories.Validators.Constants.Generators", StringConstants.WHITESPACE,
                    StringConstants.WHITESPACE
                )
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="false" /> in the event that (a) MatchCase =
        /// true and MatchExactWord
        /// = false in the config, (b) the source string contains the
        /// pattern string as a substring, but (c) the cases do not match in
        /// neither the first sub-case nor in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = true, MatchExactWord = false
                };
            Assert.That(!_matcher.IsMatch("foo.tests", "MFR.Directories.Validators.Constants.Generators", "Bar"));
            Assert.That(!_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "foo", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="false" /> in the event that (a) MatchCase =
        /// false and MatchExactWord
        /// = true in the config, (b) the source string contains the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case but the cases match in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = false, MatchExactWord = true
                };
            Assert.That(!_matcher.IsMatch("foo.tests", "MFR.Directories.Validators.Constants.Generators", "Bar"));
            Assert.That(!_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "MFR.Directories.Validators.Constants.Generators", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="false" /> in the event that (a) MatchCase =
        /// MatchExactWord
        /// = false in the config, (b) the source string does not contain the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = false, MatchExactWord = false
                };
            Assert.That(!_matcher.IsMatch("foo.tests", "Bar", "Baz"));
            Assert.That(!_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "Bar", "Baz"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="false" /> in the event that (a) MatchCase =
        /// true and MatchExactWord
        /// = false in the config, (b) the source string does not contain the
        /// pattern string as a substring, and even if (c) the cases do not
        /// match in the first sub-case but the cases match in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = true, MatchExactWord = false
                };
            Assert.That(!_matcher.IsMatch("foo.tests", "bar", "baz"));
            Assert.That(!_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "Bar", "Baz"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="false" /> in the event that (a) MatchCase =
        /// true and MatchExactWord
        /// = false in the config, (b) the source string does not contain the
        /// pattern string as a substring, but (c) the cases do not match in
        /// neither the first sub-case nor in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesDoNotMatch()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = true, MatchExactWord = false
                };
            Assert.That(!_matcher.IsMatch("foo.tests", "Bar", "Baz"));
            Assert.That(!_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "bar", "baz"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="false" /> in the event that (a) MatchCase =
        /// true and MatchExactWord
        /// = false in the config, (b) the source string does not contain the
        /// pattern string as a substring, but (c) the cases match in both the
        /// first sub-case and in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceDoesNotContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn_AndCasesMatch()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = true, MatchExactWord = false
                };
            Assert.That(!_matcher.IsMatch("foo.tests", "bar", "baz"));
            Assert.That(!_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "Bar", "Baz"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="true" /> in the event that (a) MatchCase =
        /// false and MatchExactWord
        /// = true in the config, (b) the source string exactly matches the
        /// pattern string, and (c) the cases do not match in the first sub-case
        /// but the cases match in the second.
        /// </summary>
        [Test]
        public void
            Test_FalseReturned_IfSourceExactlyMatchesPattern_WhenMatchExactWord_IsTurnedOn_And_MatchCase_IsTurnedOff()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = false, MatchExactWord = true
                };
            Assert.That(_matcher.IsMatch("foo", "MFR.Directories.Validators.Constants.Generators", "Bar"));
            Assert.That(_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators", "MFR.Directories.Validators.Constants.Generators", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="false" /> in the event that (a) MatchCase =
        /// MatchExactWord
        /// = true in the config, (b) the source string does not exactly
        /// match the pattern string as a substring, and if (c) the cases do not
        /// match in the first sub-case.
        /// </summary>
        [Test]
        public void
            Test_FalseReturnedIfCaseDoesNotMatch_AndFalseReturnedWhenCaseDoesMatch_IfSourceDoesNotExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = true, MatchExactWord = true
                };
            Assert.That(!_matcher.IsMatch("foo.tests", "Bar", "Baz"));
            Assert.That(!_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "Bar", "Baz"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="true" /> in the event that (a) MatchCase =
        /// MatchExactWord
        /// = true in the config, (b) the source string exactly matches the
        /// pattern string as a substring, except if (c) the cases do not match
        /// in the first sub-case.
        /// </summary>
        [Test]
        public void
            Test_FalseReturnedIfCaseDoesNotMatch_AndTrueReturnedWhenCaseDoesMatch_IfSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn()
        {
            _matcher.CurrentConfig = ConfigurationBuilder.Instance
                .SetMatchCase()
                .AndSetMatchExactWord()
                .Build();
            Assert.That(!
                _matcher.IsMatch("foo.tests", "MFR.Directories.Validators.Constants.Generators.Tests", "Bar.Tests")
            );
            Assert.That(
                _matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "MFR.Directories.Validators.Constants.Generators.Tests", "Bar.Tests")
            );
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="true" /> in the event that (a) MatchCase =
        /// MatchExactWord
        /// = false in the config, (b) the source string contains the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case.
        /// </summary>
        [Test]
        public void
            Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOff()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = false, MatchExactWord = false
                };
            Assert.That(_matcher.IsMatch("foo.tests", "MFR.Directories.Validators.Constants.Generators", "Bar"));
            Assert.That(_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "MFR.Directories.Validators.Constants.Generators", "Bar"));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="true" /> in the event that (a) MatchCase =
        /// true and MatchExactWord
        /// = false in the config, (b) the source string contains the
        /// pattern string as a substring, and if (c) the cases match in the
        /// first sub-case and in the second.
        /// </summary>
        [Test]
        public void
            Test_TrueReturned_IfSourceContainsPattern_WhenMatchExactWord_IsTurnedOff_And_MatchCase_IsTurnedOn()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = true, MatchExactWord = false
                };
            Assert.That(_matcher.IsMatch("foo.tests", "foo", "Bar"));
            Assert.That(_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "MFR.Directories.Validators.Constants.Generators", "Bar"));
        }

        /// -- STOPPED HERE -- *
        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="true" /> in the event that (a) MatchCase =
        /// MatchExactWord
        /// = true in the config, and (b) the source string exactly
        /// matches the pattern string as a substring (including case).
        /// </summary>
        [Test]
        public void
            Test_TrueReturned_WhenSourceExactlyMatchesPattern_WhenMatchExactWord_And_MatchCase_AreTurnedOn()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = true, MatchExactWord = true
                };
            Assert.That(
                _matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "MFR.Directories.Validators.Constants.Generators.Tests", "Bar.Tests")
            );
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.IsMatch" />
        /// method
        /// returns <see langword="false" /> in the event that (a) MatchCase =
        /// MatchExactWord
        /// = true in the config, (b) the source string does contain the
        /// pattern string as a substring, and (c) the cases do not match in the
        /// first sub-case.
        /// </summary>
        [Test]
        public void
            Test_WhenMatchCaseOn_AndMatchExactWordOn_FalseReturned_IfSourceContainsPattern()
        {
            _matcher.CurrentConfig =
                new ProjectFileRenamerConfig {
                    MatchCase = true, MatchExactWord = true
                };
            Assert.That(!_matcher.IsMatch("foo.tests", "MFR.Directories.Validators.Constants.Generators", "Bar"));
            Assert.That(!_matcher.IsMatch("MFR.Directories.Validators.Constants.Generators.Tests", "MFR.Directories.Validators.Constants.Generators", "Bar"));
        }

        /// <summary>
        /// Creates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// interface for
        /// the specified operation <paramref name="type" />.
        /// </summary>
        /// <param
        ///     name="type">
        /// One of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// values that specifies which operation to create a data-matcher
        /// object for.
        /// </param>
        /// <exception
        ///     cref="T:System.ArgumentOutOfRangeException" >
        /// Thrown if the
        /// <paramref name="type" />
        /// parameter is not set to a value that the
        /// factory supports.
        /// </exception>
        protected void CreateMatchingEngineFor(OperationType type)
            => _matcher = GetTextExpressionMatchingEngine.For(type)
                    .AndAttachConfiguration(ProjectFileRenamerConfig) as
                ITextExpressionMatchingEngine;
    }
}