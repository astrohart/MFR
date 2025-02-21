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

using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Constants
{
    /// <summary>
    /// Contains the identifiers to be utilized in order to tag those messages
    /// sent by the File Renamer object.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class FileRenamerMessages
    {
        /// <summary>
        /// Unique identifier for a message that indicates that the operation that is
        /// currently being executed by the application has changed.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_CURRENT_OPERATION_CHANGED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_CURRENT_OPERATION_CHANGED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates an exception has been
        /// raised by the File Renamer component.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_EXCEPTION_RAISED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_EXCEPTION_RAISED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that a file has been renamed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_FILE_RENAMED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_FILE_RENAMED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates a file system entry
        /// (file or folder) has been skipped by the current operation.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_FILE_SYSTEM_ENTRY_SKIPPED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_FILE_SYSTEM_ENTRY_SKIPPED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the number of
        /// files that are to be renamed has been counted.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_FILES_TO_BE_RENAMED_COUNTED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_FILES_TO_BE_RENAMED_COUNTED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the number of
        /// files to have text within them replaced has been counted.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has completed all of the requested operations.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_FINISHED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_FINISHED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that a folder has been renamed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_FOLDER_RENAMED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_FINISHED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that a particular
        /// File Renamer component operation has been completed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_OPERATION_FINISHED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_OPERATION_FINISHED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that a particular
        /// File Renamer component operation has been started.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_OPERATION_STARTED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_OPERATION_STARTED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the operation to commit
        /// pending changes before processing the renaming operations has counted the
        /// number of local Git repos that are to be processed.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_PENDING_CHANGES_TO_BE_COMMITTED_COUNTED =
                new FileRenamerMessageId {
                    MessageId = Guid.NewGuid(),
                    Name = "FRM_PENDING_CHANGES_TO_BE_COMMITTED_COUNTED"
                };

        /// <summary>
        /// Unique identifier for a message that indicates that the current
        /// operation is being processed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_PROCESSING_OPERATION =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_PROCESSING_OPERATION"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the operation to commit the
        /// results of processing the renaming operations has counted the number of local
        /// Git repo actions that are to be performed.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_RESULTS_TO_BE_COMMITTED_TO_GIT_COUNTED =
                new FileRenamerMessageId {
                    MessageId = Guid.NewGuid(),
                    Name = "FRM_RESULTS_TO_BE_COMMITTED_TO_GIT_COUNTED"
                };

        /// <summary>
        /// Unique identifier for a message that indicates that the root directory, i.e.,
        /// the starting directory, of the File Renamer component has been altered.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_ROOT_DIRECTORY_PATH_CHANGED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_ROOT_DIRECTORY_PATH_CHANGED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that aa attempt to close a
        /// Visual Studio Solution (<c>*.sln</c>) file loaded into a running instance of
        /// Visual Studio has failed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_SOLUTION_CLOSE_FAILED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_SOLUTION_CLOSE_FAILED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that a folder has been renamed.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_SOLUTION_FOLDER_RENAMED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_SOLUTION_FOLDER_RENAMED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has determined the number of subfolders that need to be
        /// operated on.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED =
                new FileRenamerMessageId {
                    MessageId = Guid.NewGuid(),
                    Name = "FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED"
                };

        /// <summary>
        /// Unique identifier for a message that indicates that aa attempt to close a
        /// Visual Studio Solution (<c>*.sln</c>) file loaded into a running instance of
        /// Visual Studio has failed.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_SOLUTION_OPEN_FAILED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_SOLUTION_OPEN_FAILED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the set of all
        /// requested File Renamer operations has started.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_STARTED =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_STARTED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the set of all
        /// requested File Renamer operations are about to begin.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_STARTING =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_STARTED"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has a status update available that should be displayed to
        /// the user.
        /// </summary>
        public static readonly FileRenamerMessageId FRM_STATUS_UPDATE =
            new FileRenamerMessageId {
                MessageId = Guid.NewGuid(), Name = "FRM_STATUS_UPDATE"
            };

        /// <summary>
        /// Unique identifier for a message that indicates that the File Renamer
        /// component has determined the number of subfolders that need to be
        /// operated on.
        /// </summary>
        public static readonly FileRenamerMessageId
            FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED = new FileRenamerMessageId {
                MessageId = Guid.NewGuid(),
                Name = "FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED"
            };
    }
}