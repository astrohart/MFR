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
 */using MFR.GUI.Models.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Models.Extensions
{
    /// <summary>
    /// Exposes static methods that extend the
    /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> class.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class OperationTypeInfoHelpers
    {
        /// <summary>
        /// Determines if the collection coming from the specified
        /// <paramref name="source" /> has more than zero elements.
        /// </summary>
        /// <param name="source">
        /// (Required.) A collection of instances of
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> instances.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="source" /> has more
        /// than zero elements; <see langword="false" /> otherwise.
        /// </returns>
        public static bool HasAnyOperations(
            this IList<IOperationTypeInfo> source)
        {
            var result = false;

            try
            {
                result = source != null && source.Any();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="operationTypeInfo" />
        /// represents state for the specified <paramref name="operationType" />.
        /// </summary>
        /// <param name="operationTypeInfo">
        /// (Required.) An
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> that specifies the, e.g.,
        /// enabled/disabled state for the specified operation.
        /// </param>
        /// <param name="operationType">
        /// (Required.) One of the
        /// <see cref="T:MFR.Operations.Constants.OperationType" /> enumeration values that
        /// explains what type of operation this object represents.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> instance corresponds to the
        /// specified <paramref name="operationType" />; <see langword="false" />
        /// otherwise.
        /// </returns>
        /// <remarks>
        /// This method also returns <see langword="false" /> in the event that the
        /// <paramref name="operationTypeInfo" /> is passed <see langword="null" /> for its
        /// argument.
        /// </remarks>
        public static bool IsOfType(this IOperationTypeInfo operationTypeInfo,
            OperationType operationType)
            => operationTypeInfo != null &&
               operationType.Equals(operationTypeInfo.OperationType);
    }
}