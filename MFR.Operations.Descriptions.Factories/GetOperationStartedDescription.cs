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

using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Obtains references to instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
    /// interface that change depending on the strategy desired.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetOperationStartedDescription
    {
        /// <summary>
        /// Obtains a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
        /// interface which corresponds to the specified meeting <paramref name="type" />.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see cref="T:MFR.Operations.Constants.OperationType" /> enumeration values that
        /// describes the type of operation that is to be performed by the application..
        /// </param>
        /// <returns>
        /// Reference to the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
        /// interface which corresponds to the specific enumeration value that is specified
        /// for the argument of the <paramref name="type" /> parameter.
        /// </returns>
        /// <remarks>
        /// This method will throw an exception if there are no types implemented
        /// that correspond to the enumeration value passed for the argument of the
        /// <paramref name="type" /> parameter.
        /// </remarks>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if there is no corresponding concrete type defined that implements the
        /// <see
        ///     cref="T:MFR.Operations.Descriptions.Interfaces.IOperationStartedDescription" />
        /// interface and which corresponds to the specific enumeration value that was
        /// passed for the argument of the <paramref name="type" /> parameter, if it is not
        /// supported.
        /// </exception>
        public static IOperationStartedDescription For(OperationType type)
        {
            IOperationStartedDescription result;

            switch (type)
            {
                case OperationType.CalculateListOfFilesToBeRenamed:
                    result =
                        GetCalculateListOfFilesToBeRenamedOperationStartedDescription
                            .SoleInstance();
                    break;

                case OperationType.CheckingWhetherChosenFolderContainsSolutions:
                    result =
                        GetCheckingWhetherChosenFolderContainsSolutionsOperationStartedDescription
                            .SoleInstance();
                    break;

                case OperationType.CleanFiles:
                    result = GetCleanFilesOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.CloseActiveSolutions:
                    result = GetCloseActiveSolutionOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.CommitPendingChanges:
                    result = GetCommitPendingChangesOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.CommitResultsToGit:
                    result = GetCommitResultsToGitOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.FindVisualStudio:
                    result = GetFindVisualStudioOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.InitializeApplication:
                    result = GetInitializeApplicationOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.OpenActiveSolutions:
                    result = GetOpenActiveSolutionOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.RenameFilesInFolder:
                    result = GetRenameFilesInFolderOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.RenameSolutionFolders:
                    result = GetRenameSolutionFoldersOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.RenameSubFolders:
                    result = GetRenameSubFoldersOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.ReplaceTextInFiles:
                    result = GetReplaceTextInFilesOperationStartedDescription
                        .SoleInstance();
                    break;

                case OperationType.ScanDirectoryTreeForSolutionFiles:
                    result =
                        GetScanDirectoryTreeForSolutionFilesOperationStartedDescription
                            .SoleInstance();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"The type of operation to be performed, '{type}', is not supported."
                    );
            }

            return result;
        }
    }
}