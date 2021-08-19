using MFR.Objects.Messages.Requests.Intefaces;
using System.Threading.Tasks;

namespace MFR.Objects.Messages.Requests
{
    /// <summary>
    /// Defines the methods, properties, events, and functionality that all
    /// configuration-request objects share.
    /// </summary>
    public abstract class
        RequestBase<TResult> : FixedMessageTypeSpecificObjectBase,
            IRequest<TResult> where TResult : class
    {
        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// A <typeparamref name="TResult" /> instance containing data from the
        /// result of executing the message.
        /// </returns>
        public TResult Execute()
            => CommonExecute();

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// A <typeparamref name="TResult" /> instance containing data from the
        /// result of executing the message.
        /// </returns>
        public Task<TResult> ExecuteAsync()
            => Task.Run(CommonExecute);

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