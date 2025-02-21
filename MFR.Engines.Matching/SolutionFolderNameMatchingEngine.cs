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

using MFR.Engines.Matching.Actions;
using MFR.Operations.Constants;
using MFR.Settings.Configuration.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Engines.Matching
{
    /// <summary>
    /// Searches for matches to textual-search criteria patterns and regexes in the
    /// pathnames of folders that contain Visual Studio Solution (<c>*.sln</c>) files,
    /// according to rules specified by config settings.
    /// </summary>
    public class
        SolutionFolderNameMatchingEngine : TextExpressionMatchingEngineBase

    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Engines.Matching.TextExpressionMatchingEngineBase" />
        /// and returns a reference to it.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref name="config" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public SolutionFolderNameMatchingEngine(
            IProjectFileRenamerConfig config) : base(
            config
        ) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Engines.Matching.SolutionFolderNameMatchingEngine" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <remarks>
        /// NOTE: This constructor is marked as <c>internal</c>. This to
        /// limit the scope of invocation to abstract factories only.
        /// <para />
        /// Clients who want to new up an instance of this class directly must
        /// use the <c>public</c> constructor.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public SolutionFolderNameMatchingEngine() { }

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
        {
            get;
        } = OperationType.RenameSolutionFolders;

        /// <summary>
        /// Determines whether a <paramref name="value" /> string is a match
        /// against a <paramref name="findWhat" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the value that the found text is to be
        /// replaced with. Cannot be blank.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// , <paramref name="findWhat" />, or
        /// <paramref
        ///     name="replaceWith" />
        /// are passed blank or <see langword="null" />
        /// string for values.
        /// </exception>
        /// <returns>
        /// Returns <see langword="true" /> if the <paramref name="value" /> is a
        /// match against the provided <paramref name="findWhat" />;
        /// <see
        ///     langword="false" />
        /// if no matches are found.
        /// </returns>
        public override bool IsMatch([NotLogged] string value,
            [NotLogged] string findWhat, [NotLogged] string replaceWith = "")
        {
            var result = base.IsMatch(value, findWhat, replaceWith);

            try
            {
                if (string.IsNullOrWhiteSpace(value)) return result;
                if (string.IsNullOrWhiteSpace(findWhat))
                    return result;
                if (string.IsNullOrWhiteSpace(replaceWith))
                    return result;

                var matcher = Get.StringMatcherForOperation(
                    OperationType, CurrentConfig
                );
                if (matcher == null) return result;

                result = matcher.IsMatch(value, findWhat, replaceWith);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}