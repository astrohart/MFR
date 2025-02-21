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
 */namespace MFR.Operations.Constants
{
    /// <summary>
    /// Specifies the type of operation now being performed.
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// The list of file system entries to be renamed is being retrieved.
        /// </summary>
        CalculateListOfFilesToBeRenamed = 8,

        /// <summary>
        /// Checking the starting folder that has been selected to ensure that it or one or
        /// more of its subfolders contain Visual Studio Solution (*.sln) files.
        /// </summary>
        CheckingWhetherChosenFolderContainsSolutions = 12,

        /// <summary>
        /// Iterates over the root directory's files and removes <c>NUL</c> character(s)
        /// that may be present in any of the text file(s) touched by this application.
        /// </summary>
        CleanFiles = 16,

        /// <summary>
        /// Closes the active solution in Visual Studio.
        /// </summary>
        /// <remarks>
        /// The "active" solution is defined as that which exists as a
        /// <c>.sln</c> file in the starting (root) folder.
        /// </remarks>
        CloseActiveSolutions = 5,

        /// <summary>
        /// Commits the user's existing pending changes to the user's local Git repository
        /// (if one is present in the starting folder) prior to the commencement of
        /// operation processing.
        /// </summary>
        CommitPendingChanges = 6,

        /// <summary>
        /// Commits the results of the processing of operations to the user's local Git
        /// repository (if one is present in the starting folder) prior to the commencement
        /// of operations.
        /// </summary>
        CommitResultsToGit = 15,

        /// <summary>
        /// Finds the instance of Visual Studio that has the solution open.
        /// </summary>
        /// <remarks>
        /// The particular solution is that which exists in the starting (root) folder.
        /// </remarks>
        FindVisualStudio = 7,

        /// <summary>
        /// The application is loading configuration and profiles and such.
        /// </summary>
        InitializeApplication = 13,

        /// <summary>
        /// Gathering a list of the top-level subfolders of the current folder.
        /// </summary>
        ListTopLevelSubFolders = 11,

        /// <summary>
        /// Searches a specified folder for the paths of all the <c>*.sln</c> files within
        /// it.
        /// <para />
        /// For each <c>*.sln</c> file found, opens it in its own separate instance of
        /// Visual Studio.
        /// </summary>
        LoadAllSolutionsInFolder = 14,

        /// <summary>
        /// Unloads all <c>*.sln</c> files in a given folder, that are currently loaded
        /// in running instances of Visual Studio.
        /// </summary>
        UnloadAllSolutionsInFolder = 4,

        /// <summary>
        /// Open the solution back up in Visual Studio.
        /// </summary>
        /// <remarks>
        /// The "active" solution is defined as that which exists as a
        /// <c>.sln</c> file in the starting (root) folder.
        /// </remarks>
        OpenActiveSolutions = 9,

        /// <summary>
        /// We are replacing text values in the names of files.
        /// </summary>
        RenameFilesInFolder = 0,

        /// <summary>
        /// We are replacing text in the content of the files.
        /// </summary>
        ReplaceTextInFiles = 2,

        /// <summary>
        /// We are replacing text in the names of folders.
        /// </summary>
        RenameSubFolders = 1,

        /// <summary>
        /// The folder in which the containing Solution is itself being renamed.
        /// </summary>
        RenameSolutionFolders = 3,

        /// <summary>
        /// We are searching for ALL files with the extension *.sln in a specific directory
        /// tree.
        /// </summary>
        ScanDirectoryTreeForSolutionFiles = 10,

        /// <summary>
        /// Unknown operation type.
        /// </summary>
        Unknown = -1
    }
}