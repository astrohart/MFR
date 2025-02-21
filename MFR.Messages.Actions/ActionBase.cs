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

using MFR.Messages.Actions.Interfaces;
using MFR.Messages.Requests;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Messages.Actions
{
    /// <summary>
    /// Defines the methods, properties, events, and other functionality that is
    /// shared among all message objects.
    /// </summary>
    /// <typeparam name="TInput">
    /// Name of the class or data type that contains information used to execute
    /// the message.
    /// <para />
    /// This object is composed with the message object at runtime.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// Name of the class or data type that will carry user state information
    /// about the results of the message.
    /// </typeparam>
    [Log(AttributeExclude = true)]
    public abstract class ActionBase<TInput, TResult> : RequestBase<TResult>,
        IAction<TInput, TResult> where TInput : class where TResult : class
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.ActionBase" />
        /// and returns a
        /// reference to it.
        /// </summary>
        protected ActionBase()
        {
            Input = null;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.ActionBase" />
        /// and returns a
        /// reference to it.
        /// </summary>
        protected ActionBase(TInput input)
        {
            Input = input;
        }

        /// <summary>
        /// Gets a reference to an instance of an object of type
        /// <typeparamref name="TInput" /> that
        /// contains the input data for this <c>Action</c>.
        /// </summary>
        public TInput Input
        {
            get;
            protected set;
        }

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
        public virtual ICachedResultAction<TInput, TResult>
            AsCachedResultAction()
            => throw new InvalidCastException();

        /// <summary>
        /// Composes this object's <paramref name="input" /> with it.
        /// </summary>
        /// <param name="input">
        /// (Required.) Reference to an instance of
        /// <typeparamref
        ///     name="TInput" />
        /// that contains data to be provided to the message.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        public IAction<TInput, TResult> WithInput(TInput input)
        {
            Input = input ?? throw new ArgumentNullException(nameof(input));

            return this;
        }
    }
}