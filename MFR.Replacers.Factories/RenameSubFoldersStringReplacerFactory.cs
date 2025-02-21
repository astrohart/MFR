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
using MFR.Replacers.Factories.Interfaces;
using MFR.Replacers.Interfaces;
using MFR.Settings.Configuration.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;

namespace MFR.Replacers.Factories
{
    /// <summary>
    /// Factory object that creates string replacers, specific to the Rename
    /// Sub Folders type of operation, for the various combinations of
    /// Match Case and Match Exact Word.
    /// </summary>
    public class RenameSubFoldersStringReplacerFactory : IStringReplacerFactory
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RenameSubFoldersStringReplacerFactory() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RenameSubFoldersStringReplacerFactory() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
        /// interface that creates objects which are responsible for renaming file folders
        /// within a specific directory tree according to a text-replacement pattern that
        /// was specified by the user.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IStringReplacerFactory Instance
        {
            get;
        } = new RenameSubFoldersStringReplacerFactory();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public virtual OperationType OperationType
        {
            get;
        } = OperationType.RenameSubFolders;

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringReplacer" />
        /// interface and
        /// returns a reference to it for the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// value that
        /// is specified by the <paramref name="matchingConfig" /> parameter.
        /// </summary>
        /// <param name="matchingConfig">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values that
        /// specifies which type of matching is being done.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringReplacer" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown if the value passed in the <paramref name="matchingConfig" />
        /// is not one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if a string replacer object is not defined for the Rename
        /// Files in Folder operation type that supports the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// value
        /// passed in the <paramref name="matchingConfig" /> parameter.
        /// </exception>
        public virtual IStringReplacer AndTextMatchingConfiguration(
            TextMatchingConfiguration matchingConfig)
        {
            if (!Enum.IsDefined(
                    typeof(TextMatchingConfiguration), matchingConfig
                ))
                throw new InvalidEnumArgumentException(
                    nameof(matchingConfig), (int)matchingConfig,
                    typeof(TextMatchingConfiguration)
                );

            IStringReplacer replacer;

            switch (matchingConfig)
            {
                case TextMatchingConfiguration.MatchCaseOnly:
                    replacer = MatchCaseOnlyFolderNameStringReplacer.Instance;
                    break;

                case TextMatchingConfiguration.MatchExactWordOnly:
                    replacer = MatchExactWordOnlyFolderNameStringReplacer
                        .Instance;
                    break;

                case TextMatchingConfiguration.MatchCaseAndExactWord:
                    replacer = MatchCaseAndExactWordFolderNameStringReplacer
                        .Instance;
                    break;

                case TextMatchingConfiguration.NeitherMatchCaseNorExactWord:
                    replacer =
                        NeitherMatchCaseNorExactWordFolderNameStringReplacer
                            .Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(matchingConfig), matchingConfig,
                        $"There are no string replacer objects defined for the Rename Files in Folder operation type that support the '{matchingConfig}' matching config."
                    );
            }

            return replacer;
        }
    }
}