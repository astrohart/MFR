using MFR.Messages.Interfaces;
using System.Threading.Tasks;

namespace MFR.Messages.Requests.Intefaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that
    /// implements requests that can be performed on behalf of the application.
    /// <para />
    /// In our vocabulary, a <c>request</c> is a command that only has a result;
    /// i.e., it does not take any inputs.
    /// </summary>
    /// <typeparam name="TResult">
    /// Name of the class that will receive results of the operation.
    /// </typeparam>
    /// <remarks>
    /// Defines a request. Requests differ from messages in that requests do not
    /// have any input parameters.
    /// <para />
    /// To make a request that does not return an output, compose this object
    /// with <see cref="T:System.Void" />.
    /// </remarks>
    public interface IRequest<TResult> : IFixedMessageTypeSpecificObject
        where TResult : class
    {
        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// A <typeparamref name="TResult" /> instance containing data from the
        /// result of executing the message.
        /// </returns>
        TResult Execute();

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// A <typeparamref name="TResult" /> instance containing data from the
        /// result of executing the message.
        /// </returns>
        Task<TResult> ExecuteAsync();
    }
}