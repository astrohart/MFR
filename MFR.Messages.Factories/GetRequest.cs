using MFR.Messages.Constants;
using MFR.Messages.Requests.Intefaces;
using System;

namespace MFR.Messages.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.IRequest" />
    /// interface.
    /// </summary>
    public static class GetRequest
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IRequest" />
        /// interface and returns a reference to
        /// it.
        /// <typeparam name="TResult">
        /// Name of the class or primitive data
        /// type that the result of the request will consist of.
        /// </typeparam>
        /// </summary>
        /// <param name="type">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.Messages.Constants.MessageType" />
        /// value that
        /// indicates what request to execute.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Messages.Requests.Interfaces.IRequest" />
        /// interface that corresponds to the specified
        /// <see cref="T:MFR.Messages.Constants.MessageType" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if no request object is available that corresponds to the
        /// <see cref="T:MFR.Messages.Constants.MessageType" /> value
        /// provided in the <paramref name="type" /> parameter.
        /// </exception>
        /// <remarks>
        /// The current implementation of this method does nothing but throw
        /// <see cref="T:System.NotImplementedException" />.
        /// </remarks>
        public static IRequest<TResult> For<TResult>(MessageType type)
            where TResult : class
            => throw new NotImplementedException();

        //IRequest<TResult> request = null;
        /*
            switch (type)
            {
                // Add factory method implementation here
                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no request object available for the message type '{type}'."
                    );
            }
            */
        //return configurationRequest;
    }
}