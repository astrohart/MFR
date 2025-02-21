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
using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Validators.Interfaces;
using MFR.Tests.Common;
using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;

namespace MFR.FileSystem.Validators.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.FileSystem.Validators.ProjectFileValidator" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    [Log(AttributeExclude = true)]
    public class ProjectFileValidatorTests
    {
        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.FileSystem.Validators.ProjectFileValidator" />.
        /// </summary>
        /// <remarks>
        /// This property is meant for fluent use.
        /// </remarks>
        private static IFileSystemEntryValidator ThatTheProjectFileValidatorSays
            => ProjectFileValidator.Instance;

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="false" /> in the event that it's passed
        /// the pathname of a file that matches the operational criteria.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsFalse_ForAllowedFile()
        {
            Assert.That(
                File.Exists(StringConstants.FILE_MATCHING_OPERATIONAL_CRITERIA)
            );
            Assert.That(!
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.FILE_MATCHING_OPERATIONAL_CRITERIA
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> in the case that it's passed
        /// the blank/empty string as an argument.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForBlankPath()
            => Assert.That(ThatTheProjectFileValidatorSays.ShouldSkip(string.Empty));

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the fully
        /// qualified pathname of a dotfile.
        /// <para />
        /// A dotfile is defined as a file whose name begins with a period (.).
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForDotfile()
        {
            Assert.That(File.Exists(StringConstants.PATHNAME_OF_DOTFILE));
            Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_DOTFILE
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the
        /// fully-qualified pathname of a file that is found in the <c>bin\</c>
        /// subfolder of a given project's directory.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInBinDir()
        {
            Assert.That(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER
                )
            );
            Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that exists within the <c>.git</c> dotfolder of a Git repository.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInGitDir()
        {
            Assert.That(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER
                )
            );
            Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when the pathname of a file
        /// that is inside the <c>obj\</c> subfolder of a project is passed to it.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInObjDir()
        {
            Assert.That(
                File.Exists(
                    StringConstants
                        .PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER
                )
            );
            Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants
                        .PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when provided the pathname of
        /// a file under the <c>packages\</c> folder of a solution as its input.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInPackagesDir()
        {
            Assert.That(
                File.Exists(
                    StringConstants
                        .PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER
                )
            );
            Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants
                        .PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file located under the <c>.vs\</c> subfolder of a solution.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForFileInVsDir()
        {
            Assert.That(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_VS_DOTFOLDER
                )
            );
            Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_FILE_LOCATED_IN_VS_DOTFOLDER
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the
        /// <see
        ///     langword="null" />
        /// string for its argument.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForNullInput()
            => Assert.That(ThatTheProjectFileValidatorSays.ShouldSkip(null));

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that is guaranteed not to exist on the file system.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForPathOfNonExistentFile()
        {
            Assert.That(!File.Exists(StringConstants.NONEXISTENT_FILE));
            Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.NONEXISTENT_FILE
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that has no extension.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForPathWithNoFileExtension()
        {
            Assert.That(
                File.Exists(
                    StringConstants.PATHNAME_OF_FILE_HAVING_NO_EXTENSION
                )
            );
            Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PATHNAME_OF_FILE_HAVING_NO_EXTENSION
                )
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that has zero length.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile()
            => Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(Path.GetTempFileName())
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.FileSystem.Validators.ProjectFileValidator.ShouldSkip" />
        /// method returns <see langword="true" /> when passed the pathname of a
        /// file that has zero length.
        /// </summary>
        [Test]
        public void Test_ShouldSkip_ReturnsTrue_ForZeroLengthFile2()
        {
            Assert.That(
                File.Exists(StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE)
            );
            Assert.That(
                ThatTheProjectFileValidatorSays.ShouldSkip(
                    StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE
                )
            );
        }
    }
}