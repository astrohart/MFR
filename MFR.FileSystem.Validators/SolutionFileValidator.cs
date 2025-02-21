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
using MFR.FileSystem.Factories;
using MFR.FileSystem.Helpers;
using MFR.FileSystem.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.FileSystem.Validators
{
    /// <summary>
    /// Defines an object that validates the paths of Visual Studio Solution (those
    /// whose names have the extension <c>.sln</c>) files.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class SolutionFileValidator : FileSystemEntryValidatorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static SolutionFileValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected SolutionFileValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.FileSystem.Validators.Interfaces.IFileSystemEntryValidator" />
        /// interface and which validates the pathnames of Visual Studio Solution (*.sln)
        /// files.
        /// </summary>
        public static IFileSystemEntryValidator Instance
        {
            get;
        } = new SolutionFileValidator();

        /// <summary>
        /// Determines whether the file-system entry with the specified
        /// <paramref name="path" /> should be skipped during an operation.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the pathname on the file system of the
        /// file-system entry that is to potentially be skipped.
        /// </param>
        /// <returns>
        /// <see langword="true" /> is returned by this method if the file-system
        /// entry with the specified <paramref name="path" /> is to be skipped by
        /// the operation; otherwise, <see langword="false" />.
        /// </returns>
        public override bool ShouldSkip(string path)
        {
            var result = true;

            try
            {
                // Should skip the file if its fully-qualified pathname is blank.
                if (string.IsNullOrWhiteSpace(path)) return result;

                // Should skip the file if its filename extension is not '.sln'.
                if (!Path.GetExtension(path)
                         .IsAnyOf(".sln")) return result;

                // Should skip the file if the base class says so
                if (base.ShouldSkip(path)) return result;

                // Should skip the file if the fully-qualified pathname of the file has no filename extension.
                if (string.IsNullOrWhiteSpace(Path.GetExtension(path)))
                    return result;

                // Skip the file if the file is a zero-length file.
                result = MakeNewFileInfo.ForPath(path)
                                        .IsZeroLengthFile();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = true; // skip the file if an error occurred
            }

            return result;
        }
    }
}