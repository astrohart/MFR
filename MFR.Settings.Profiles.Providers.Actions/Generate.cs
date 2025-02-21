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
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Actions.Factories;
using MFR.Settings.Profiles.Collections.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to generate references to data.
    /// </summary>
    public static class Generate
    {
        /// <summary>
        /// Generates a reference to an instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface, given
        /// the specified <paramref name="pathname" /> of a <c>profiles.json</c> file.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>profiles.json</c> file.
        /// </param>
        /// <returns>
        /// If the <paramref name="pathname" /> refers to a <c>profiles.json</c>
        /// file that exists on the file system, then a new reference to an instance of an object
        /// that implements the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface is returned; <see langword="null" /> is returned otherwise.
        /// </returns>
        public static IFileSystemEntry FileSystemEntryForProfileCollection(
            string pathname
        )
        {
            IFileSystemEntry result = default;

            try
            {
                if (!Determine.WhetherProfileListPathIsValid(pathname))
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
        /// Generates a reference to an instance of an <c>Action</c> object that is
        /// responsible for executing the operation of loading the user's
        /// config-setting profiles from the file system.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface that refers to the <c>profiles.json</c> file from which profiles are
        /// to be loaded.
        /// </param>
        /// <returns>
        /// If successful, a reference to an instance of an <c>Action</c> object
        /// that is responsible for executing the operation of loading the user's
        /// config-setting profiles from the file system; <see langword="null" />
        /// otherwise.
        /// </returns>
        public static IAction<IFileSystemEntry, IProfileCollection>
            LoadProfileCollectionFromFileAction(IFileSystemEntry entry)
        {
            IAction<IFileSystemEntry, IProfileCollection> result = default;

            try
            {
                /*
                 * OKAY, only use the pathname provided to this method as
                 * input for the load profile list from file action if it
                 * contains the fully-qualified pathname of a file that actually
                 * exists on the file system and has a filename of profiles.json.
                 */

                if (entry == null) return result;
                if (!Determine.WhetherProfileListPathIsValid(entry.Path))
                    return result;

                var action =
                    GetProfileCollectionAction
                        .For<IFileSystemEntry, IProfileCollection>(
                            ProfileCollectionActionType
                                .LoadProfileCollectionFromFile
                        );

                /*
                 * OKAY, we have frequently encountered exceptions or
                 * null values at this step.  Check the output of the call
                 * above before we proceed further.
                 */

                if (action == null)
                    return result; // failed to create action

                // initialize the action object by setting its input, before
                // returning the reference to it to the caller of this method.
                result = action.WithInput(entry); // add the input
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