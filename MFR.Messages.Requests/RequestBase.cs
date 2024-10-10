using MFR.Messages.Requests.Intefaces;
using PostSharp.Patterns.Diagnostics;
using System.Threading.Tasks;

namespace MFR.Messages.Requests
{
    /// <summary>
    /// Defines the methods, properties, events, and functionality that all
    /// configuration-request objects share.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class
        RequestBase<TResult> : FixedMessageTypeSpecificObjectBase,
            IRequest<TResult> where TResult : class
    {
        /// <summary>
        /// Gets a reference to an instance of an object of type
        /// <typeparamref name="TResult" /> that contains the results of executing this
        /// <c>Request</c>.
        /// </summary>
        public TResult Result
        {
            get;
            protected set;
        }

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// A <typeparamref name="TResult" /> instance containing data from the
        /// result of executing the message.
        /// </returns>
        public TResult Execute()
        {
            Result = CommonExecute();
            return Result;
        }

        /// <summary>
        /// Executes this message asynchronously.
        /// </summary>
        /// <returns>
        /// A <typeparamref name="TResult" /> instance containing data from the
        /// result of executing the message.
        /// </returns>
        public async Task<TResult> ExecuteAsync()
        {
            await Task.Run(()=>Result = CommonExecute());
            return Result;
        }

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
        protected abstract TResult CommonExecute();
    }
}