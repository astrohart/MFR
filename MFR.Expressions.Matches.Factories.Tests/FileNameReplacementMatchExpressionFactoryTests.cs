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
 */using MFR.Expressions.Matches.Factories.Interfaces;
using MFR.Operations.Constants;
using MFR.Settings.Configuration.Interfaces;
using MFR.Tests.Common;
using NUnit.Framework;
using PostSharp.Patterns.Threading;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Expressions.Matches.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.FileNameReplacementMatchExpressionFactory" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class FileNameReplacementMatchExpressionFactoryTests
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public void Initialize()

            // try really hard to clear the temp files folder to avoid a large
            // buildup of files from these unit tests.
            => DebugFileAndFolderHelper.ClearTempFileDir();

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, false
                        )
                    )
                    .ForTextValue(StringConstants.EMPTY_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, true
                        )
                    )
                    .ForTextValue(StringConstants.EMPTY_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, false
                        )
                    )
                    .ForTextValue(StringConstants.EMPTY_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, true
                        )
                    )
                    .ForTextValue(StringConstants.EMPTY_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, false
                        )
                    )
                    .ForTextValue(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, true
                        )
                    )
                    .ForTextValue(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, false
                        )
                    )
                    .ForTextValue(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, true
                        )
                    )
                    .ForTextValue(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, false
                        )
                    )
                    .ForTextValue(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, true
                        )
                    )
                    .ForTextValue(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, false
                        )
                    )
                    .ForTextValue(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, true
                        )
                    )
                    .ForTextValue(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordFalse()
            => Assert.That(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY,
                Is.EqualTo(
                    GetMatchExpressionFactoryConfiguredAccordingTo(
                            ConfigurationBuilder.BuildConfigurationForUseCase(
                                false, false
                            )
                        )
                        .ForTextValue(StringConstants.FILE_GUARANTEED_TO_EXIST)
                        .Value
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordTrue()
            => Assert.That(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY,
                Is.EqualTo(
                    GetMatchExpressionFactoryConfiguredAccordingTo(
                            ConfigurationBuilder.BuildConfigurationForUseCase(
                                false, true
                            )
                        )
                        .ForTextValue(StringConstants.FILE_GUARANTEED_TO_EXIST)
                        .Value
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordFalse()
            => Assert.That(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY,
                Is.EqualTo(
                    GetMatchExpressionFactoryConfiguredAccordingTo(
                            ConfigurationBuilder.BuildConfigurationForUseCase(
                                true, false
                            )
                        )
                        .ForTextValue(StringConstants.FILE_GUARANTEED_TO_EXIST)
                        .Value
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordTrue()
            => Assert.That(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY,
                Is.EqualTo(
                    GetMatchExpressionFactoryConfiguredAccordingTo(
                            ConfigurationBuilder.BuildConfigurationForUseCase(
                                true, true
                            )
                        )
                        .ForTextValue(StringConstants.FILE_GUARANTEED_TO_EXIST)
                        .Value
                )
            );

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.IMatchExpressionFactory" />
        /// interface and that is configured according to the
        /// <paramref
        ///     name="config" />
        /// instance specified.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IMatchExpressionFactory" />
        /// interface
        /// that has the specified <paramref name="config" /> attached.
        /// </returns>
        /// <remarks>
        /// The specific match-expression factory in use is that which is keyed
        /// to the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.RenameFilesInFolder" />
        /// operation type.
        /// </remarks>
        private static IMatchExpressionFactory
            GetMatchExpressionFactoryConfiguredAccordingTo(
                IProjectFileRenamerConfig config
            )
            => GetMatchExpressionFactory.For(OperationType.RenameFilesInFolder)
                                        .AndAttachConfiguration(config);
    }
}