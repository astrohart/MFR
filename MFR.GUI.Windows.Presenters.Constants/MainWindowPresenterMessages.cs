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
 */using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.GUI.Windows.Presenters.Constants
{
    /// <summary>
    /// Unique identifiers for the messages that are sent by the Presenter of
    /// the main application window.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MainWindowPresenterMessages
    {
        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter when the
        /// operation of creating a new Profile has failed.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_ADD_NEW_PROFILE_FAILED = new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_ADD_NEW_PROFILE_FAILED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when the history has just been cleared.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_ALL_HISTORY_CLEARED = new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_ALL_HISTORY_CLEARED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when the configuration has just been
        /// exported to a file.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_CONFIGURATION_EXPORTED = new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_CONFIGURATION_EXPORTED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when the configuration has just been
        /// imported from a file.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_CONFIGURATION_IMPORTED = new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_CONFIGURATION_IMPORTED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for the main
        /// application window when the user has clicked the Add New Profile button.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED =
                new MainWindowPresenterMessageId {
                    MessageId = Guid.NewGuid(),
                    Name = "MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED"
                };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when a data operation error, such as
        /// accessing a file (separate from the operations that the application
        /// is designed to perform).
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_DATA_OPERATION_ERROR =
                new MainWindowPresenterMessageId {
                    MessageId = Guid.NewGuid(), Name = "MWP_DATA_OPERATION_ERROR"
                };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when a data operation, such as accessing
        /// a file (separate from the operations that the application is
        /// designed to perform), is completed.
        /// </summary>
        public static readonly Guid MWP_DATA_OPERATION_FINISHED =
            new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_DATA_OPERATION_FINISHED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter for
        /// the main application window when a data operation, such as accessing
        /// a file (separate from the operations that the application is
        /// designed to perform), is newly started.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_DATA_OPERATION_STARTED =
                new MainWindowPresenterMessageId {
                    MessageId = Guid.NewGuid(), Name = "MWP_DATA_OPERATION_STARTED"
                };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when all of the file-rename operations
        /// have finished.
        /// </summary>
        public static readonly MainWindowPresenterMessageId MWP_FINISHED =
            new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_FINISHED"
            };

        /// <summary>
        /// Unique identifier for the message that is sent by the Presenter of
        /// the main application window when one of the file-rename operations
        /// has just come to completion.
        /// </summary>
        public static readonly MainWindowPresenterMessageId
            MWP_OPERATION_FINISHED =
                new MainWindowPresenterMessageId {
                    MessageId = Guid.NewGuid(), Name = "MWP_OPERATION_FINISHED"
                };

        /// <summary>
        /// Unique identifier for the message that is sent by the main
        /// application window's Presenter when a file-rename operation is started.
        /// </summary>
        public static readonly MainWindowPresenterMessageId MWP_STARTED =
            new MainWindowPresenterMessageId {
                MessageId = Guid.NewGuid(), Name = "MWP_STARTED"
            };
    }
}