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
 */using MFR.Messages.Actions.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Messages.Actions
{
    /// <summary>
    /// Caches the results of repeated operations using the same inputs in order
    /// to improve performance.
    /// </summary>
    /// <typeparam name="TInput">
    /// Data type of the input of the action.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// Data type of the result of the action.
    /// </typeparam>
    /// <remarks>
    /// Implementations should inherit from this class when it is believed that
    /// calling an action with the same input will always yield the same result.
    /// <para />
    /// Such caching is designed to enhance application performance.
    /// <para />
    /// This parent class is especially useful for actions that need to query a
    /// data source whose data rarely changes, but for which access poses a
    /// non-negligible reduction in performance.
    /// </remarks>
    public abstract class
        CachedResultActionBase<TInput, TResult> : ActionBase<TInput, TResult>,
            ICachedResultAction<TInput, TResult> where TInput : class
        where TResult : class
    {
        /// <summary>
        /// Returns a reference to this same object, but cast to the
        /// <see
        ///     cref="T:MFR.ICachedResultAction" />
        /// interface.
        /// </summary>
        /// <returns>
        /// Reference to the same object instance as that which invoked this
        /// method, cast to the
        /// <see
        ///     cref="T:MFR.ICachedResultAction" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        /// Thrown if the implementing object does not also implement the
        /// <see
        ///     cref="T:MFR.ICachedResultAction" />
        /// interface.
        /// </exception>
        /// <remarks>
        /// Overriders of this method must not call the base class.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public override ICachedResultAction<TInput, TResult>
            AsCachedResultAction()
            => this;

        /// <summary>
        /// Clears the cache of results built up from the prior executions of this action.
        /// </summary>
        /// <param name="elementAction"></param>
        [Log(AttributeExclude = true)]
        public virtual void ClearResultCache(
            Action<TInput, TResult> elementAction = null)
            => ActionCacheProvider<TInput, TResult>.Clear(elementAction);

        /// <summary>
        /// Allows an object to try to free resources and perform other cleanup
        /// operations before it is reclaimed by garbage collection.
        /// </summary>
        [Log(AttributeExclude = true)]
        ~CachedResultActionBase()
        {
            // Upon disposal of this object, clear the result cache first.
            ClearResultCache();
        }

        /// <summary>
        /// Associates a reference to the <paramref name="resultToAdd" /> to the
        /// current value of the
        /// <see
        ///     cref="F:MFR.ActionBase._input" />
        /// field. using
        /// the internal result cache dictionary.
        /// </summary>
        /// <param name="resultToAdd">
        /// Reference to an instance of <typeparamref name="TResult" /> that is
        /// to be associated with the current input value.
        /// </param>
        [Log(AttributeExclude = true)]
        protected virtual void AddResultToCache(TResult resultToAdd)
            => ActionCacheProvider<TInput, TResult>.Add(Input, resultToAdd);

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// A <typeparamref name="TResult" /> instance containing data from the
        /// result of executing the message.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// </remarks>
        [Log(AttributeExclude = true)]
        protected sealed override TResult CommonExecute()
        {
            // write the name of the current class and method we are now
            TResult result = default;

            // Check to see if the required field, _input, is null. If it is,
            if (Input == default(TInput))

                // the field _input is required.
                // stop.
                return result;

            try
            {
                if (TryGetCachedResult(out result) && result != null)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "*** SUCCESS *** Found the result in the cache.  Using the value retrieved as the return value of this method."
                    );
                    return result;
                }

                result = ExecuteOperationIfNotCached();
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
        /// Performs this action's operation if the result could not located in
        /// the result cache.
        /// </summary>
        /// <returns>
        /// Reference to an instance of <typeparamref name="TResult" /> that
        /// corresponds to the current input or <see langword="null" /> if an issue
        /// occurred.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// <para />
        /// This a template method, the call to which is wrapped in a robust
        /// and fault-tolerant override of the
        /// <see
        ///     cref="M:MFR.ActionBase.CommonExecute" />
        /// method.
        /// <para />
        /// The parent method override (a) validates that the _input field is
        /// not null, (b) checks for thrown exceptions, and(c) checks the result
        /// cache first to see if data corresponding to the input is there.
        /// </remarks>
        protected abstract TResult ExecuteOperationIfNotCached();

        /// <summary>
        /// Attempts to access the result cache dictionary using the current
        /// value of the
        /// <see
        ///     cref="F:MFR.ActionBase._input" />
        /// field, and asks
        /// whether it is present in the cache.
        /// </summary>
        /// <param name="result">
        /// Reference to a memory location that will receive a reference to an
        /// instance of <typeparamref name="TResult" /> if one is found in the
        /// result cache; otherwise, will be assigned the <see langword="null" />
        /// reference.
        /// </param>
        /// <returns>
        /// If the current value of the
        /// <see
        ///     cref="F:MFR.ActionBase._input" />
        /// field is
        /// present in the result cache dictionary and associated with a
        /// corresponding result, then the <paramref name="result" /> parameter
        /// is filled with the corresponding value, and this method returns
        /// <see langword="true" />; otherwise, the method returns <see langword="false" />
        /// and the
        /// <paramref name="result" /> parameter is assigned a <see langword="null" />
        /// reference.
        /// </returns>
        /// <remarks>
        /// This method really is merely an alias for the
        /// <see
        ///     cref="M:System.Collections.Generic.IDictionary.TryGetValue" />
        /// method.
        /// <para />
        /// <b>NOTE:</b> Child classes may override this method in order to
        /// provide additional processing; however, it is mandatory to begin the
        /// override's code with a call to the base class.
        /// </remarks>
        [Log(AttributeExclude = true)]
        protected virtual bool TryGetCachedResult(out TResult result)
            => ActionCacheProvider<TInput, TResult>.ResultCache.TryGetValue(
                Input, out result
            );
    }
}