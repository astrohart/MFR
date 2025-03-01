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

using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Threading;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
using xyLOGIX.Interop.Processes.Factories;
using xyLOGIX.Interop.Processes.Interfaces;

namespace MFR.FileSystem.Helpers
{
    /// <summary>
    /// Helper methods for working with instances of
    /// <see cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo" />.
    /// </summary>
    public static class DirectoryInfoExtensions
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.FileSystem.Helpers.DirectoryInfoExtensions" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static DirectoryInfoExtensions() { }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.Processes.Interfaces.IProcessProvider" />
        /// interface.
        /// </summary>
        private static IProcessProvider ProcessProvider
        {
            get;
        } = GetProcessProvider.SoleInstance();

        /// <summary>
        /// Renames a folder.
        /// </summary>
        /// <param name="folderToBeRenamed">
        /// A <see cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo" /> describing the
        /// folder to
        /// be renamed.
        /// </param>
        /// <param name="newSubFolderPath">
        /// String containing the pathname of the renamed folder.
        /// </param>
        /// <param name="maxRetries">
        /// (Optional.) Set to the maximum retries before giving up. Default is 5.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the rename operation is successful;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// A <paramref name="maxRetries" /> parameter is necessary since, during
        /// rename operations, random exceptions keep popping up. Therefore, we
        /// retry the operation until either (a) the operation succeeded, or (b)
        /// the max number of retries has been hit.
        /// </remarks>
        public static bool RenameTo(
            this DirectoryInfo folderToBeRenamed,
            string newSubFolderPath,
            int maxRetries = 5
        )
        {
            // write the name of the current class and method we are now
            var result = false;

            try
            {
                // Dump the parameter, 'folderToBeRenamed', to the log.
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.RenameTo: folderToBeRenamed = '{folderToBeRenamed.FullName}'"
                );

                // Dump the argument of the parameter, newSubFolderPath, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.RenameTo: newSubFolderPath = '{newSubFolderPath}'"
                );

                // Dump the variable maxRetries to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.RenameTo: maxRetries = {maxRetries}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DirectoryInfoExtensions.RenameTo: Checking whether the 'folderToBeRenamed' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, folderToBeRenamed, is null. If it is, send an
                // error to the log file and quit, returning the default return value of this
                // method.
                if (folderToBeRenamed == null)
                {
                    // The parameter, 'folderToBeRenamed', is required and is not supposed to have a NULL value.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "DirectoryInfoExtensions.RenameTo: *** ERROR *** A null reference was passed for the 'folderToBeRenamed' method parameter.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** DirectoryInfoExtensions.RenameTo: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DirectoryInfoExtensions.RenameTo: *** SUCCESS *** We have been passed a valid object reference for the 'folderToBeRenamed' method parameter.  Proceeding..."
                );

                if (string.IsNullOrWhiteSpace(newSubFolderPath))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "DirectoryInfoExtensions.RenameTo: Blank value passed for the 'newSubFolderPath' parameter. This parameter is required."
                    );
                    return result;
                }

                if (maxRetries <= 0)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "DirectoryInfoExtensions.RenameTo: The 'maxRetries' parameter can only be 1 or greater.  It's not.  Stopping."
                    );
                    return result;
                }

                if (!Directory.Exists(folderToBeRenamed.FullName))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The system could not locate the folder having the path '{folderToBeRenamed.FullName}' on the file system.  This folder is required to exist in order for us to proceed."
                    );
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"DirectoryInfoExtensions.RenameTo: Checking whether the destination folder, '{newSubFolderPath}', already exists..."
                );

                // if the destination already exists, then delete it recursively
                if (Directory.Exists(newSubFolderPath))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Warning,
                        $"*** WARNING: The folder, '{newSubFolderPath}', was found to already exist.  Attempting to delete it..."
                    );

                    Directory.Delete(newSubFolderPath, true);

                    DebugUtils.WriteLine(
                        !Directory.Exists(newSubFolderPath)
                            ? DebugLevel.Info
                            : DebugLevel.Warning,
                        !Directory.Exists(newSubFolderPath)
                            ? $"*** SUCCESS *** The destination folder, '{newSubFolderPath}', has been deleted.  Proceeding..."
                            : $"*** WARNING: Failed to delete the folder, '{newSubFolderPath}'.  Perhaps it is in use by another process."
                    );
                }

                var attempts = 0;

                while (attempts < maxRetries)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"*** INFO: On attempt #{attempts + 1}..."
                    );

                    attempts++;

                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"DirectoryInfoExtensions.RenameTo: Attempting to rename the folder, '{folderToBeRenamed.FullName}', to '{newSubFolderPath}'..."
                    );

                    if (TryRenameFolder(folderToBeRenamed, newSubFolderPath))
                    {
                        DebugUtils.WriteLine(
                            DebugLevel.Info,
                            "*** SUCCESS *** The rename operation succeeded."
                        );

                        break;
                    }

                    Thread.Sleep(
                        500
                    ); // rest for 500 milliseconds interval between retries
                }

                result = Directory.Exists(newSubFolderPath);

                DebugUtils.WriteLine(
                    result ? DebugLevel.Info : DebugLevel.Error,
                    result
                        ? $"*** SUCCESS *** The folder, '{folderToBeRenamed.FullName}', has been renamed to '{newSubFolderPath}'.  Proceeding..."
                        : $"*** ERROR *** FAILED to rename the folder, '{folderToBeRenamed.FullName}', to '{newSubFolderPath}'.  Stopping..."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"DirectoryInfoExtensions.RenameTo: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Attempts to perform the folder rename operation.
        /// </summary>
        /// <param name="folderToBeRenamed">
        /// (Required.) Reference to an instance of
        /// <see
        ///     cref="T:Alphaleonis.Win32.Filesystem.DirectoryInfo" />
        /// that represents the folder to be renamed.
        /// </param>
        /// <param name="newSubFolderPath">
        /// (Required.) String containing the new path of the renamed folder.
        /// </param>
        /// <returns>
        /// </returns>
        private static bool TryRenameFolder(
            DirectoryInfo folderToBeRenamed,
            string newSubFolderPath
        )
        {
            // write the name of the current class and method we are now
            var result = false;

            // Dump the parameter, 'folderToBeRenamed', to the log.
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"DirectoryInfoExtensions.TryRenameFolder: folderToBeRenamed = '{folderToBeRenamed.FullName}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"DirectoryInfoExtensions.TryRenameFolder: newSubFolderPath = '{newSubFolderPath}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "DirectoryInfoExtensions.TryRenameFolder: Checking whether the 'folderToBeRenamed' method parameter has a null reference for a value..."
            );

            // Check to see if the required parameter, folderToBeRenamed, is null. If it is, send an
            // error to the log file and quit, returning the default return value of this
            // method.
            if (folderToBeRenamed == null)
            {
                // The parameter, 'folderToBeRenamed', is required and is not supposed to have a NULL value.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "DirectoryInfoExtensions.TryRenameFolder: *** ERROR *** A null reference was passed for the 'folderToBeRenamed' method parameter.  Stopping..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"*** DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "DirectoryInfoExtensions.TryRenameFolder: *** SUCCESS *** We have been passed a valid object reference for the 'folderToBeRenamed' method parameter.  Proceeding..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"DirectoryInfoExtensions.TryRenameFolder: Checking whether the folder to be renamed, '{folderToBeRenamed.FullName}', exists on the file system..."
            );

            // Check whether the folder to be renamed exists on the file system (it should.)  If this is not
            // the case, then write an error message to the log file, and then terminate the execution of this
            // method.
            if (!Directory.Exists(folderToBeRenamed.FullName))
            {
                // The system could not locate the folder having the path 'folderToBeRenamed.FullName' on the file system.  This is not desirable.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"*** ERROR *** The system could not locate the folder having the path '{folderToBeRenamed.FullName}' on the file system.  This folder is required to exist in order for us to proceed."
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"DirectoryInfoExtensions.TryRenameFolder: *** SUCCESS *** The folder to be renamed, '{folderToBeRenamed.FullName}', was indeed found on the file system.  Proceeding..."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "DirectoryInfoExtensions.TryRenameFolder *** INFO: Checking whether the value of the 'newSubFolderPath' parameter is blank..."
            );

            // Check whether the value of the parameter, 'newSubFolderPath', is blank.
            // If this is so, then emit an error message to the log file, and
            // then terminate the execution of this method.
            if (string.IsNullOrWhiteSpace(newSubFolderPath))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "DirectoryInfoExtensions.TryRenameFolder: Blank value passed for the 'newSubFolderPath' parameter. Stopping..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The parameter 'newSubFolderPath' is not blank.  Proceeding..."
            );

            try
            {
                var sourceFolderPath = folderToBeRenamed.FullName;

                // Dump the variable sourceFolderPath to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.TryRenameFolder: sourceFolderPath = '{sourceFolderPath}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** DirectoryInfoExtensions.TryRenameFolder: Checking whether the source folder, '{sourceFolderPath}', exists on the file system..."
                );

                // Check to see whether the source folder exists on the file system.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (!Does.FolderExist(sourceFolderPath))
                {
                    // The source folder does NOT exist on the file system.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The source folder does NOT exist on the file system.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DirectoryInfoExtensions.TryRenameFolder: *** SUCCESS *** The source folder exists on the file system.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DirectoryInfoExtensions.TryRenameFolder: Formulating the pathname of an intermediate location for the folder to go..."
                );

                // Formulate the pathname to which to temporarily move the
                // folder from the source, and then to the destination.
                var tempFolderLocation = Path.Combine(
                    Path.GetTempPath(), Guid.NewGuid()
                                            .ToString("N")
                );

                // Dump the variable tempFolderLocation to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"DirectoryInfoExtensions.TryRenameFolder: tempFolderLocation = '{tempFolderLocation}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"DirectoryInfoExtensions.TryRenameFolder: Checking whether the temporary folder, '{tempFolderLocation}', does NOT already exist on the file system..."
                );

                // Check to see whether the temporary folder already exists on the file system.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (Does.FolderExist(tempFolderLocation))
                {
                    // The temporary folder already exists on the file system.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The temporary folder, '{tempFolderLocation}', already exists on the file system.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"DirectoryInfoExtensions.TryRenameFolder: *** SUCCESS *** The temporary folder, '{tempFolderLocation}', does NOT already exist on the file system.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"DirectoryInfoExtensions.TryRenameFolder: Attempting to rename '{sourceFolderPath}' -> '{newSubFolderPath}'..."
                );
                
                Directory.Move(
                    sourceFolderPath, newSubFolderPath
                );

                //// Delay to let the system catch up
                //DebugUtils.WriteLine(
                //    DebugLevel.Info,
                //    "DirectoryInfoExtensions.TryRenameFolder: Delaying to let the system catch up..."
                //);

                //Thread.Sleep(50);

                //DebugUtils.WriteLine(
                //    DebugLevel.Info,
                //    "DirectoryInfoExtensions.TryRenameFolder: Verifying the move operation succeeded..."
                //);

                //DebugUtils.WriteLine(
                //    DebugLevel.Info,
                //    $"*** DirectoryInfoExtensions.TryRenameFolder: Checking whether the temporary folder, '{tempFolderLocation}', exists on the file system..."
                //);

                //// Check to see whether the temporary folder exists on the file system.
                //// If this is not the case, then write an error message to the log file,
                //// and then terminate the execution of this method.
                //if (!Does.FolderExist(tempFolderLocation))
                //{
                //    // The temporary folder does NOT exist on the file system.  This is not desirable.
                //    DebugUtils.WriteLine(
                //        DebugLevel.Error,
                //        $"*** ERROR *** The temporary folder, '{tempFolderLocation}', does NOT exist on the file system.  Stopping..."
                //    );

                //    DebugUtils.WriteLine(
                //        DebugLevel.Debug,
                //        $"*** DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
                //    );

                //    // stop.
                //    return result;
                //}

                //DebugUtils.WriteLine(
                //    DebugLevel.Info,
                //    $"DirectoryInfoExtensions.TryRenameFolder: *** SUCCESS *** The temporary folder, '{tempFolderLocation}', exists on the file system.  Proceeding..."
                //);

                //DebugUtils.WriteLine(
                //    DebugLevel.Info,
                //    $"DirectoryInfoExtensions.TryRenameFolder: Now attempting to move the folder, '{tempFolderLocation}', to the new path, which is '{newSubFolderPath}'."
                //);

                //Directory.Move(
                //    tempFolderLocation, newSubFolderPath,
                //    MoveOptions.CopyAllowed | MoveOptions.ReplaceExisting |
                //    MoveOptions.WriteThrough, PathFormat.FullPath
                //);

                // Delay to let the system catch up
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DirectoryInfoExtensions.TryRenameFolder: Delaying to let the system catch up..."
                );

                Thread.Sleep(50);

                /*
                 * At this point in the execution of this method, the folder should now have
                 * been moved to the newSubFolderPath.  Confirm this.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DirectoryInfoExtensions.TryRenameFolder: Checking whether the temporary folder does NOT still exist..."
                );

                // Check to see whether the temporary folder does NOT still exist.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (Does.FolderExist(tempFolderLocation))
                {
                    // The temporary folder still exists.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The temporary folder still exists.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DirectoryInfoExtensions.TryRenameFolder: *** SUCCESS *** The temporary folder does NOT still exist.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** DirectoryInfoExtensions.TryRenameFolder: Checking whether the destination folder exists on the file system..."
                );

                // Check to see whether the destination folder exists on the file system.
                // If this is not the case, then write an error message to the log file,
                // and then terminate the execution of this method.
                if (!Does.FolderExist(newSubFolderPath))
                {
                    // The destination folder does NOT exist on the file system.  This is not desirable.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The destination folder does NOT exist on the file system.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DirectoryInfoExtensions.TryRenameFolder: *** SUCCESS *** The destination folder exists on the file system.  Proceeding..."
                );

                result = Does.FolderExist(newSubFolderPath);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }
            finally
            {
                // Delay to let the system catch up -- one last, final time
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "DirectoryInfoExtensions.TryRenameFolder: Delaying to let the system catch up..."
                );

                Thread.Sleep(50);
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"DirectoryInfoExtensions.TryRenameFolder: Result = {result}"
            );

            return result;
        }
    }
}