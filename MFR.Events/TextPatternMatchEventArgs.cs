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

using PostSharp.Patterns.Threading;
using MFR.Operations.Constants;
using MFR.Operations.Events;
using System;

namespace MFR.Events
{
    /// <summary>
    /// Base class that provides common methods and properties for all
    /// event-argument objects for text pattern matches.
    /// </summary>
[ExplicitlySynchronized]
    public class TextPatternMatchEventArgs : OperationEventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.TextPatternMatchEventArgs" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the text that is to be searched for
        /// the pattern in <paramref name="findWhat" />.
        /// <para />
        /// This typically the fully-qualified pathname of a file or folder;
        /// however, if we are doing the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.ReplaceTextInFiles" />
        /// operation, then this the text of the current file before
        /// find-and-replace has been done.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the textual criteria for the match.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the data that any occurrences of
        /// <paramref name="findWhat" /> in the <paramref name="source" /> should
        /// be replaced with.
        /// <para />
        /// NOTE: This parameter may be blank for the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.ReplaceTextInFiles" />
        /// operation type.
        /// </param>
        /// <param name="operationType">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// describes what operation is being performed.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the either of the required parameters,
        /// <paramref
        ///     name="source" />
        /// . <paramref name="findWhat" /> , or
        /// <paramref
        ///     name="replaceWith" />
        /// , are passed blank or <see langword="null" /> strings for values.
        /// </exception>
        public TextPatternMatchEventArgs(string source, string findWhat,
            string replaceWith, OperationType operationType) : base(
            operationType
        )
        {
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(source)
                );
            if (string.IsNullOrWhiteSpace(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(findWhat)
                );
            if (operationType != OperationType.ReplaceTextInFiles &&
                string.IsNullOrWhiteSpace(replaceWith))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replaceWith)
                );

            // NOTE: I removed the file-exists validation that was here. As this
            // class really should be just a class that transfers information
            // from one place to another.

            Source = source;
            FindWhat = findWhat;
            ReplaceWith = replaceWith;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.OperationEventArgs" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="operationType">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// specifies the operation being performed.
        /// </param>
        public TextPatternMatchEventArgs(OperationType operationType) : base(
            operationType
        ) { }

        /// <summary>
        /// Gets a string containing the textual criteria for determining
        /// whether the name of the file is to be targeted by a rename operation.
        /// </summary>
        public string FindWhat
        {
            get;
        }

        /// <summary>
        /// Gets the text that any found occurrences of the data in the
        /// <see
        ///     cref="P:MFR.Events.TextPatternMatchEventArgs.FindWhat" />
        /// should be replaced with.
        /// </summary>
        public string ReplaceWith
        {
            get;
        }

        /// <summary>
        /// Gets a string containing the full pathname of the file to run a
        /// match operation against.
        /// </summary>
        public string Source
        {
            get;
        }
    }
}