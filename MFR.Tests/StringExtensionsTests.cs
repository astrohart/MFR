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

using PostSharp.Patterns.Threading;
using MFR.Tests.Common;
using NUnit.Framework;
using Alphaleonis.Win32.Filesystem;
using xyLOGIX.Core.Extensions;

namespace MFR.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:xyLOGIX.Core.Extensions.StringExtensions" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class StringExtensionsTests
    {
        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> for the case where it is only
        /// passed a filename (such as NOTEPAD.EXE) and not a complete, absolute pathname.
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly()
            => Assert.That(
                !StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY
                               .IsAbsolutePath()
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> for the case where it is only
        /// passed a filename (such as
        /// LICENSE) that does not have a file extension, and not a complete,
        /// absolute pathname.
        /// </summary>
        [Test]
        public void
            Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension()
            => Assert.That(!StringConstants
                            .FILE_GUARANTEED_TO_EXIST_FILENAME_WITHOUT_EXTENSION
                            .IsAbsolutePath()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> in the event that the
        /// relative pathname, e.g., .\NOTEPAD.EXE, is passed.
        /// </summary>
        [Test]
        public void
            Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName()
            => Assert.That(
                !$@".\{StringConstants.FILE_GUARANTEED_TO_EXIST}"
                    .IsAbsolutePath()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> when it is passed a blank value.
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput()
            => Assert.That(!StringConstants.EMPTY_STRING.IsAbsolutePath());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> when passed
        /// <see
        ///     langword="null" />
        /// as input.
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput()
            => Assert.That(

                // ReSharper disable once InvokeAsExtensionMethod
                !StringExtensions.IsAbsolutePath(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> when passed whitespace for input.
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace()
            => Assert.That(!StringConstants.WHITESPACE.IsAbsolutePath());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="true" /> when passed a fully-qualified
        /// pathname of a file, even if the file does not exist.
        /// </summary>
        [Test]
        public void
            Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists()
        {
            Assert.That(!File.Exists(StringConstants.NONEXISTENT_FILE));
            Assert.That(StringConstants.NONEXISTENT_FILE.IsAbsolutePath());
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="true" /> when it is passed a
        /// fully-qualified pathname of a file that is guaranteed to exist.
        /// </summary>
        [Test]
        public void
            Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist()
        {
            Assert.That(
                File.Exists(StringConstants.FILE_GUARANTEED_TO_EXIST)
            );
            Assert.That(
                StringConstants.FILE_GUARANTEED_TO_EXIST.IsAbsolutePath()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when supplied with the empty
        /// string as input.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForBlankInput()
            => Assert.That(!StringConstants.EMPTY_STRING.IsFolderPath());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when provided only the name
        /// and extension of a file that is otherwise known to exist.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForFilenameOnly()
            => Assert.That(
                !StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY
                               .IsFolderPath()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when provided the name of a
        /// file that exists, but without the extension.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension()
            => Assert.That(
                !StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY
                               .IsFolderPath()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when passed the pathname of a
        /// file that is known not to exist.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist()
        {
            Assert.That(!File.Exists(StringConstants.NONEXISTENT_FILE));
            Assert.That(!StringConstants.NONEXISTENT_FILE.IsFolderPath());
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> for the event in which it is
        /// passed the fully-qualified pathname of a file that is known to exist.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForFileThatExists()
        {
            Assert.That(
                File.Exists(StringConstants.FILE_GUARANTEED_TO_EXIST)
            );
            Assert.That(
                StringConstants.FILE_GUARANTEED_TO_EXIST.IsAbsolutePath()
            );
            Assert.That(!
                StringConstants.FILE_GUARANTEED_TO_EXIST.IsFolderPath()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when passed the
        /// fully-qualified pathname of a folder that is known not to exist.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist()
        {
            Assert.That(!
                Directory.Exists(StringConstants.NONEXISTENT_FOLDER)
            );
            Assert.That(!StringConstants.NONEXISTENT_FOLDER.IsFolderPath());
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when supplied with the
        /// <see
        ///     langword="null" />
        /// string as input.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForNullInput()
            => Assert.That(!StringConstants.NULL_STRING.IsFolderPath());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when supplied with whitespace
        /// as an input.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput()
            => Assert.That(!StringConstants.WHITESPACE.IsFolderPath());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="true" /> when passed the
        /// fully-qualified pathname of a folder that is known to exist.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsTrue_ForFolderThatExists()
        {
            Assert.That(
                Directory.Exists(
                    StringConstants.FOLDER_THAT_IS_GUARANTEED_TO_EXIST
                )
            );
            Assert.That(
                StringConstants.FOLDER_THAT_IS_GUARANTEED_TO_EXIST
                               .IsFolderPath()
            );
        }
    }
}