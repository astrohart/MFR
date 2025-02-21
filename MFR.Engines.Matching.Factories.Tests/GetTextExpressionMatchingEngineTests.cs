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
 */using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using NUnit.Framework;
using System;

namespace MFR.Engines.Matching.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.GetTextExpressionMatchingEngine" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class GetTextExpressionMatchingEngineTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method, when passed the
        /// <see cref="T:MFR.Operations.Constants.OperationType.RenameFilesInFolder" />
        /// value, returns an instance of
        /// <see cref="T:MFR.Engines.Matching.FileNameMatchingEngine" />.
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFileNameMatchingEngine_For_RenameFilesInFolder_OperationType()
            => Assert.That(
                GetTextExpressionMatchingEngine.For(
                    OperationType.RenameFilesInFolder
                ) is FileNameMatchingEngine
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method, when passed the
        /// <see cref="T:MFR.Operations.Constants.OperationType.RenameSubFolders" />
        /// value, returns an instance of
        /// <see cref="T:MFR.Engines.Matching.FolderNameMatchingEngine" />.
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsFolderNameMatchingEngine_For_RenameSubFolders_OperationType()
            => Assert.That(
                GetTextExpressionMatchingEngine.For(
                    OperationType.RenameSubFolders
                ) is FolderNameMatchingEngine
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method, when passed the
        /// <see cref="T:MFR.Operations.Constants.OperationType.ReplaceTextInFiles" />
        /// value, returns an instance of
        /// <see cref="T:MFR.Engines.Matching.TextInFilesMatchingEngine" />.
        /// </summary>
        [Test]
        public void
            Test_For_ReturnsTextInFileMatchingEngine_For_ReplaceTextInFiles_OperationType()
            => Assert.That(
                GetTextExpressionMatchingEngine.For(
                    OperationType.ReplaceTextInFiles
                ) is TextInFilesMatchingEngine
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method throws <see cref="T:System.ArgumentOutOfRangeException" /> when supplied
        /// with the
        /// <see cref="T:MFR.Operations.Constants.OperationType.CloseActiveSolutions" />
        /// value,
        /// as this not one of the values that a text-expression matcher object is
        /// available for.
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CloseActiveSolution_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.CloseActiveSolutions
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method throws <see cref="T:System.ArgumentOutOfRangeException" /> when supplied
        /// with the
        /// <see cref="T:MFR.Operations.Constants.OperationType.FindVisualStudio" /> value,
        /// as this not one of the values that a text-expression matcher object is
        /// available for.
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_FindVisualStudio_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.FindVisualStudio
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method throws <see cref="T:System.ArgumentOutOfRangeException" /> when supplied
        /// with the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.CalculateListOfFilesToBeRenamed" />
        /// value,
        /// as this not one of the values that a text-expression matcher object is
        /// available for.
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_CalculateListOfFilesToBeRenamed_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.CalculateListOfFilesToBeRenamed
                )
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Engines.Matching.Factories.GetTextExpressionMatchingEngine.For" />
        /// method throws <see cref="T:System.ArgumentOutOfRangeException" /> when supplied
        /// with the
        /// <see cref="T:MFR.Operations.Constants.OperationType.OpenActiveSolutions" />
        /// value,
        /// as this not one of the values that a text-expression matcher object is
        /// available for.
        /// </summary>
        [Test]
        public void
            Test_For_ThrowsArgumentOutOfRangeException_For_OpenActiveSolution_OperationType()
            => Assert.Throws<ArgumentOutOfRangeException>(
                () => GetTextExpressionMatchingEngine.For(
                    OperationType.OpenActiveSolutions
                )
            );
    }
}