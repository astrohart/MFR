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
using MFR.FileSystem.Factories;
using MFR.Tests.Common;
using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Helpers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.FileHelpers" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    [Log(AttributeExclude = true)]
    public class FileHelpersTests
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public void Initialize()
            => DebugFileAndFolderHelper.ClearTempFileDir();

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Helpers.FillTextFile.WithJunk" /> method
        /// creates a new file of nonzero length.
        /// </summary>
        [Test]
        public void Test_FilleWithJunk_Works()
        {
            FillTextFile.WithJunk(
                StringConstants.EXISTING_TEMP_FILE
            );

            VerifyResultantFile(
                MakeNewFileInfo.ForPath(StringConstants.EXISTING_TEMP_FILE)
            );
        }

        /// <summary>
        /// Asserts that the <see cref="M:MFR.FileSystem.Helpers.FileHelpers.ToTempFile"/> method dumps text to a temporary file.
        /// </summary>
        [Test]
        public void Test_DumpTextToTempFile_Works()
        {
            var result = DumpText.ToTempFile(
                "Now is the time for all good men to come to the aid of their country."
            );

            Assert.That(result, Is.Not.Empty);

            VerifyResultantFile(MakeNewFileInfo.ForPath(result));

            Assert.That(
                FileHelpers.GetTextContent(result),
                Is.EqualTo(
                    "Now is the time for all good men to come to the aid of their country."
                )
            );
        }

        /// <summary>
        /// Runs common assertions on the
        /// <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> instance specified in
        /// the <paramref name="resultantFile" /> parameter.
        /// </summary>
        /// <param name="resultantFile">
        /// (Required.) A
        /// <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> instance that contains
        /// information about the <paramref name="resultantFile" />.
        /// </param>
        /// <remarks>
        /// The <see cref="M:MFR.FileSystem.Factories.MakeNewFileInfo.ForPath" />
        /// method can be utilized to manufacture the
        /// <see cref="T:Alphaleonis.Win32.Filesystem.FileInfo" /> instance given a
        /// pathname.
        /// </remarks>
        private static void VerifyResultantFile(FileInfo resultantFile)
        {
            Assert.That(resultantFile, Is.Not.Null);
            Assert.That(resultantFile.Exists);
            Assert.That(resultantFile.Length > 0);
        }

        /// <summary>
        /// Calls the
        /// <see cref="M:MFR.FileSystem.Helpers.FillTextFile.WithJunk" /> method
        /// to fill a temporary file with random data, and then makes sure that the
        /// <see cref="M:MFR.FileSystem.Helpers.FileHelpers.GetTextContent" /> method
        /// successfully reads the data.
        /// </summary>
        [Test]
        public void Test_GetContent_Works_OnTempFileFullOfJunk()
        {
            FillTextFile.WithJunk(
                StringConstants.EXISTING_TEMP_FILE
            );

            VerifyResultantFile(
                MakeNewFileInfo.ForPath(StringConstants.EXISTING_TEMP_FILE)
            );

            Assert.That(!
                string.IsNullOrWhiteSpace(
                    FileHelpers.GetTextContent(
                        StringConstants.EXISTING_TEMP_FILE
                    )
                )
            );
        }
    }
}