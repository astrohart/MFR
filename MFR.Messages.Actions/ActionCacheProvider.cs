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
using System.Collections.Generic;
using xyLOGIX.Core.Debug;

namespace MFR.Messages.Actions
{
    /// <summary>
    /// Helper methods and properties to deal with the result cache.
    /// </summary>
    /// <typeparam name="TInput">
    /// Data type of the input of the action.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// Data type of the result of the action.
    /// </typeparam>
    public static class ActionCacheProvider<TInput, TResult>
        where TInput : class where TResult : class
    {
        /// <summary>
        /// Cache of already-processed results.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IDictionary<TInput, TResult> ResultCache
        {
            get;
        } = new Dictionary<TInput, TResult>();

        /// <summary>
        /// Adds an entry to the cache of previous results of this action.
        /// </summary>
        /// <param name="input">(Required.) Instance of an object of type <typeparamref name="TInput"/>.</param>
        /// <param name="result">(Required.) Instance of an object of type <typeparamref name="TResult"/>.</param>
        /// <remarks>If either of <paramref name="input"/> or <paramref name="result"/> are <see langword="null" />, then this method does nothing.</remarks>
        public static void Add(TInput input, TResult result)
        {
            // write the name of the current class and method we are now
            // Check to see if the required parameter, input, is null. If it is,
            if (input == null)
            {
                // the parameter input is required.
                // stop.
                return;
            }
            // Check to see if the required parameter, result, is null. If it
            if (result == null)
            {
                // the parameter result is required.
                // stop.
                return;
            }
            try
            {
                ResultCache[input] = result;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Clears all entries that are currently stored in the result cache.
        /// <para />
        /// Optionally invokes a delegate for each element of the result cache
        /// prior to performing the clear operation.
        /// </summary>
        /// <param name="elementAction">
        /// (Optional.) Reference to an instance of an instance of a
        /// <see
        ///     cref="T:System.Action{TInput, TResult}" />
        /// delegate that is run for
        /// each element of the cache, just prior to the cache being cleared.
        /// <para />
        /// If this parameter is not a <see langword="null" /> reference, then
        /// the code referenced by this delegate is invoked for every element of
        /// the result cache, prior to the cache being cleared.
        /// <para />
        /// This parameter can be useful should callers, say, need to run
        /// cleanup code to properly release system resources consumed by
        /// elements of the cache, prior to the cache itself being emptied.
        /// </param>
        [Log(AttributeExclude = true)]
        public static void Clear(Action<TInput, TResult> elementAction = null)
        {
            if (IsNullOrEmpty()) return; // nothing to do

            foreach (var element in ResultCache)
                elementAction?.Invoke(element.Key, element.Value);

            ResultCache.Clear();
        }

        /// <summary>
        /// Gets a value specifying whether the result cache is a
        /// <see
        ///     langword="null" />
        /// reference or if it contains zero items.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the result cache is <see langword="null" />
        /// or contains zero items; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsNullOrEmpty()
            => ResultCache == null || ResultCache.Count == 0;
    }
}