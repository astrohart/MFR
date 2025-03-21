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

using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Configuration.Actions.Constants;
using MFR.Settings.Configuration.Actions.Factories;
using MFR.Settings.Configuration.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Providers.Actions
{
    public static class Generate
    {
        /// <summary>
        /// Given the specified <paramref name="pathname" /> of a <c>config.json</c> file,
        /// manufactures and returns a reference to an instance of an object that
        /// implements the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface for that <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>config.json</c> file.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of an object that implements
        /// the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface for
        /// that <paramref name="pathname" />; otherwise, <see langword="null" />.
        /// </returns>
        /// <remarks>
        /// This method checks whether the file having the specified
        /// <paramref name="pathname" /> exists on the file system or not, and has the filename
        /// <c>config.json</c> before creating a new file system entry object.
        /// </remarks>
        public static IFileSystemEntry FileSystemEntryForConfiguration(
            string pathname
        )
        {
            IFileSystemEntry result = default;

            try
            {
                if (!Determine.IsConfigPathValid(pathname))
                    return result;

                result = MakeNewFileSystemEntry.ForPath(pathname);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }

        /// <summary>
        /// Generates a new <c>Action</c> object that loads the config data from a
        /// file on the file system.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface that
        /// contains the fully-qualified pathname of a file on the file system that contains
        /// application config data.
        /// </param>
        /// <returns>
        /// A new <c>Action</c> object that loads the config data from a
        /// file on the file system.
        /// </returns>
        public static
            IAction<IFileSystemEntry, IProjectFileRenamerConfig>
            LoadConfigFromFileAction(IFileSystemEntry entry)
        {
            IAction<IFileSystemEntry, IProjectFileRenamerConfig> result =
                default;

            try
            {
                /*
                 * OKAY, only use the pathname provided to this method as
                 * input for the load config from file action if it
                 * contains the fully-qualified pathname of a file that actually
                 * exists on the file system and has a filename of config.json.
                 */

                if (entry == null) return result;
                if (!Determine.IsConfigPathValid(entry.Path))
                    return result;

                var action = GetConfigAction
                    .For<IFileSystemEntry, IProjectFileRenamerConfig>(
                        ConfigActionType.LoadConfigFromFile
                    );

                /*
                 * OKAY, we have frequently encountered exceptions or
                 * null values at this step.  Check the output of the call
                 * above before we proceed further.
                 */

                if (action == null)
                    return result; // failed to get action object

                // initialize the action object by setting its input, before
                // returning the reference to it to the caller of this method.
                result = action.WithInput(entry);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}