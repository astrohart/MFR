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
 */using MFR.Settings.Configuration.Helpers;
using MFR.Settings.Configuration.Interfaces;
using MFR.Operations.Constants;
using MFR.Replacers.Factories;
using PostSharp.Patterns.Diagnostics;
using System;
using Alphaleonis.Win32.Filesystem;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Engines.Replacement
{
    /// <summary>
    /// Contains rules to replace text in the pathnames of folders.
    /// </summary>
    public class FolderNameReplacementEngine : TextReplacementEngineBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Engines.Replacement.FolderNameReplacementEngine" />
        /// and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public FolderNameReplacementEngine()
        {
            // TODO: Add default object initialization here
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.TextReplacementEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an
        /// instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that
        /// holds settings that are specified by the user.
        /// </param>
        /// <exception
        ///     cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="config" />, is passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public FolderNameReplacementEngine(IProjectFileRenamerConfig config) : base(
            config
        ) { }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
            { get; } = OperationType.RenameSubFolders;

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="value" />. Returns a string
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data upon which the replacement
        /// operation is to be carried out.
        /// </param>
        /// <param name="pattern">
        /// (Required.) String containing the pattern that allows us to match
        /// the data to be replaced.
        /// </param>
        /// <param name="dest">
        /// (Optional.) Default is blank. String containing the new data that
        /// should be substituted for the replaced text.
        /// </param>
        /// <returns>
        /// String containing the new data.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// , <paramref name="pattern" />, or
        /// <paramref
        ///     name="dest" />
        /// , are passed blank or <see langword="null" /> string
        /// for values.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the <paramref name="value" /> parameter does not contain
        /// the fully-qualified, absolute pathname to a folder.
        /// </exception>
        [return: NotLogged]
        public override string Replace(
            [NotLogged] string value,
            [NotLogged] string pattern,
            [NotLogged] string dest = "")
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );
            if (string.IsNullOrWhiteSpace(pattern))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(pattern)
                );

            /*
             * Normally, the 'dest' parameter is optional for this method.
             * However, in the case of replacing text in the names of folders,
             * it's mandatory.  This is because, if 'dest' is blank or the
             * empty string, we run the risk of trying to create a folder that
             * has no name, which is in violation of OS rules.  Therefore,
             * we enforce that the dest parameter should have a value.
             */

            if (string.IsNullOrWhiteSpace(dest))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(dest)
                );

            /*
             * If the source parameter does not contain an absolute path,
             * then we cannot operate.
             */
            if (!value.IsAbsolutePath())
                throw new InvalidOperationException(
                    "You must pass an absolute (fully-qualified) pathname to a folder in the 'source' parameter."
                );

            /*
             * In this method, we make the following assumptions:
             *
             * (1) The 'source' parameter contains the full pathname of
             * an existing folder, and that said pathname is fully valid;
             * (2) The 'pattern' parameter contains the pattern to be
             * found in the name of the immediate child folder;
             * (3) The 'dest' parameter contains the text that should
             * be used instead of the matching text in 'source', and
             * (4) That all 3 of the parameters passed to this method
             * are never blank.  Moreover,
             * (5) The only part of the folder path that should have the
             * replacement done on it is the name of the folder that is
             * lowest-level in the directory tree.
             */

            var result =
                value; // no replacement is to occur if an exception is thrown

            try
            {
                var parentFolder = Path.GetDirectoryName(value);
                if (string.IsNullOrWhiteSpace(parentFolder)) return result;

                var folderName = Path.GetFileName(value);
                if (string.IsNullOrWhiteSpace(folderName)) return result;

                result = Path.Combine(
                    parentFolder,
                    /* only search and replace on the name of the lowest-
                     level folder in the pathname */
                    GetStringReplacer.For(OperationType)
                                     .AndTextMatchingConfiguration(
                                         CurrentConfig
                                             .GetTextMatchingConfiguration()
                                     )
                                     .Replace(folderName, pattern, dest)
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value;
            }

            return result;
        }
    }
}