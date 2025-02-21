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

using MFR.Events;
using MFR.Events.Common;
using MFR.Operations.Events;
using MFR.Renamers.Files.Events;
using MFR.Settings.Configuration.Interfaces;
using System;
using System.Collections.Generic;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Renamers.Files.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a
    /// <c>
    /// File
    /// Renamer
    /// </c>
    /// object. Such an object is directly responsible for
    /// processing the file operations of this application.
    /// </summary>
    public interface IFileRenamer : IConfigurationComposedObject
    {
        /// <summary>
        /// Gets a value that indicates whether this component is currently processing
        /// operation(s).
        /// </summary>
        bool IsStarted
        {
            get;
        }

        /// <summary>
        /// Gets or sets the path to the folder in which last Visual Studio Solution that
        /// we have worked with most recently resides.
        /// </summary>
        string LastSolutionFolderPath
        {
            get;
        }

        /// <summary>
        /// Gets a reference to a collection, each element of which implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// Each element of the collection represents a Visual Studio Solution (*.sln) that
        /// is loaded in a running instance of Visual Studio.
        /// </remarks>
        IList<IVisualStudioSolution> LoadedSolutions
        {
            get;
        }

        /// <summary>
        /// Gets a string containing the full pathname of the folder where all
        /// operations start.
        /// </summary>
        string RootDirectoryPath
        {
            get;
        }

        /// <summary>
        /// Gets a value determining whether the currently-open solution
        /// in Visual Studio should be closed and then re-opened at the
        /// completion of the operation.
        /// </summary>
        bool ShouldReOpenSolutions
        {
            get;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.Renamers.Files.FileRenamer.CurrentOperation" /> property is
        /// updated.
        /// </summary>
        event CurrentOperationChangedEventHandler CurrentOperationChanged;

        /// <summary>
        /// Occurs when an exception is thrown from an operation.
        /// </summary>
        event ExceptionRaisedEventHandler ExceptionRaised;

        /// <summary>
        /// Occurs when a file has been renamed.
        /// </summary>
        event FileRenamedEventHandler FileRenamed;

        /// <summary>
        /// Occurs when files to be renamed have been counted.
        /// </summary>
        event FilesOrFoldersCountedEventHandler FilesToBeRenamedCounted;

        /// <summary>
        /// Occurs when files to have text replaced in them have been counted.
        /// </summary>
        event FilesOrFoldersCountedEventHandler FilesToHaveTextReplacedCounted;

        /// <summary>
        /// Occurs when the processing is completely finished.
        /// </summary>
        event EventHandler Finished;

        /// <summary>
        /// Occurs when a folder has been renamed.
        /// </summary>
        event FolderRenamedEventHandler FolderRenamed;

        /// <summary>
        /// Occurs when an operation has completed.
        /// </summary>
        event OperationFinishedEventHandler OperationFinished;

        /// <summary>
        /// Occurs when an operation has commenced.
        /// </summary>
        event OperationStartedEventHandler OperationStarted;

        /// <summary>
        /// Occurs when the pending changes to be committed to Git have been counted.
        /// </summary>
        event FilesOrFoldersCountedEventHandler
            PendingChangesToBeCommittedCounted;

        /// <summary>
        /// Occurs when the results that are to be committed to Git have been counted.
        /// </summary>
        event FilesOrFoldersCountedEventHandler
            ResultsToBeCommittedToGitCounted;

        /// <summary>
        /// Occurs when an operation is about to be processed for a file or a folder.
        /// </summary>
        event ProcessingOperationEventHandler ProcessingOperation;

        /// <summary>
        /// Occurs if the value of the
        /// <see cref="P:MFR.Renamers.Files.FileRenamer.RootDirectoryPath" /> property is
        /// changed.
        /// </summary>
        event RootDirectoryPathChangedEventHandler RootDirectoryPathChanged;

        /// <summary>
        /// Occurs when an attempt to close a Visual Studio Solution (<c>*.sln</c>)  that
        /// has been loaded into a running instance of Visual Studio has failed.
        /// </summary>
        event SolutionCloseFailedEventHandler SolutionCloseFailed;

        /// <summary>
        /// Occurs when a folder that contains a Visual Studio Solution (<c>*.sln</c>) file
        /// has been renamed.
        /// </summary>
        event FolderRenamedEventHandler SolutionFolderRenamed;

        /// <summary>
        /// Occurs when an attempt to open a Visual Studio Solution (<c>*.sln</c>) file in
        /// a running instance of Visual Studio has failed.
        /// </summary>
        event SolutionOpenFailedEventHandler SolutionOpenFailed;

        /// <summary>
        /// Occurs when the processing has started.
        /// </summary>
        event EventHandler Started;

        /// <summary>
        /// Occurs just before the processing has started.
        /// </summary>
        event EventHandler Starting;

        /// <summary>
        /// Occurs when a textual status message is available for display.
        /// </summary>
        event StatusUpdateEventHandler StatusUpdate;

        /// <summary>
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname stored in the
        /// <see
        ///     cref="P:MFR.FileRenamer.RootDirectoryPath" />
        /// property.
        /// </summary>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operations succeeded;
        /// <see langword="false" /> otherwise.
        /// </returns>
        bool ProcessAll(
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
        );

        /// <summary>
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname specified by the <paramref name="rootDirectoryPath" /> parameter.
        /// </summary>
        /// <param name="rootDirectoryPath">
        /// FullName to the recursion root.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        void ProcessAll(
            string rootDirectoryPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
        );

        /// <summary>
        /// Renames all the files in the all the subfolders etc., recursively,
        /// of the folder whose pathname is specified by the
        /// <paramref
        ///     name="rootFolderPath" />
        /// parameter.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) String containing the full pathname of an existing
        /// directory on the computer that is to be where the operation is started.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation was successful;
        /// <see langword="false" /> if the operation failed or if the user cancelled the
        /// operation.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath" />,
        /// <paramref
        ///     name="findWhat" />
        /// , or <paramref name="replaceWith" /> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the
        /// <paramref
        ///     name="rootFolderPath" />
        /// does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        bool RenameFilesInFolder(
            string rootFolderPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
        );

        /// <summary>
        /// Iterates through the directory tree that is topped by the folder having the
        /// specified <paramref name="rootFolderPath" />, and, for all Visual Studio
        /// Solution (<c>*.sln</c>) file(s) found in the directory tree, renames them
        /// according to the text-replacement pattern specified by the arguments of the
        /// <paramref name="findWhat" /> and <paramref name="replaceWith" /> parameters.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder in which the operation is to start.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) Text to be found in each file contained in the directory tree.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) A <see cref="T:System.String" /> containing the text that the text
        /// specified by the argument of the <paramref name="findWhat" /> parameter is to
        /// be replaced with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation succeeded;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath" /> or the
        /// <paramref name="findWhat" /> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the
        /// <paramref
        ///     name="rootFolderPath" />
        /// does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        bool RenameSolutionFolders(
            string rootFolderPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
        );

        /// <summary>
        /// Recursively renames all the subfolders in the folder having a
        /// pathname specified by <paramref name="rootFolderPath" />, replacing
        /// any occurrences of the text in the <paramref name="findWhat" />
        /// parameter with the values in the <paramref name="replaceWith" /> parameter.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) String containing the full pathname of an existing
        /// directory on the computer that is to be where the operation is started.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation succeeded;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath" />,
        /// <paramref
        ///     name="findWhat" />
        /// , or <paramref name="replaceWith" /> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the
        /// <paramref
        ///     name="rootFolderPath" />
        /// does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        bool RenameSubFoldersOf(
            string rootFolderPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
        );

        /// <summary>
        /// Iterates recursively through a directory tree, starting at the
        /// folder with pathname <paramref name="rootFolderPath" /> and replacing
        /// every occurrence of the text specified by the <paramref name="findWhat" /> and
        /// <paramref name="replaceWith" /> parameters' arguments.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) Pathname of the folder where the operation is to start.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) Text to be found in each file contained in the directory tree.
        /// </param>
        /// <param name="replaceWith">
        /// (Optional.) Text to replace all the instances of
        /// <paramref
        ///     name="findWhat" />
        /// with. If this parameter is blank (the default),
        /// then the text is deleted.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation succeeded;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath" /> or the
        /// <paramref name="findWhat" /> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the
        /// <paramref
        ///     name="rootFolderPath" />
        /// does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        bool ReplaceTextInFiles(
            string rootFolderPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
        );

        /// <summary>
        /// Called to ask the <c>File Renamer</c> object to stop operations.
        /// </summary>
        void RequestAbort();

        /// <summary>
        /// Sets the new root directory path from which searches should be started.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of the folder from
        /// which searches should be started.
        /// <para />
        /// The fully-qualified pathname passed must reference a folder that currently
        /// exists on the file system; otherwise,
        /// <see cref="T:System.IO.DirectoryNotFoundException" /> is thrown.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="path" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder whose fully-qualified pathname is passed in the
        /// <paramref name="path" /> parameter cannot be located on the file system.
        /// </exception>
        /// <remarks>
        /// Upon successful validation of the fully-qualified folder pathname that is
        /// specified as the value of the <paramref name="path" /> parameter, assigns the
        /// value to the <see cref="P:MFR.Renamers.Files.FileRenamer.RootDirectoryPath" />
        /// property.
        /// </remarks>
        IFileRenamer StartingFrom(string path);
    }
}