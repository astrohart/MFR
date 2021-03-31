using MFR.Objects.Messages.Constants;
using MFR.Objects.Messages.Interfaces;
using System;

namespace MFR.Objects.Messages.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.IRequest" />
    /// interface.
    /// </summary
    public static class GetRequest
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IRequest" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <typeparam name="TResult">
        /// Name of the class or primitive data type that the result of the
        /// request will consist of.
        /// </typeparam>
        public static IRequest<TResult> For<TResult>(
            MessageType type) where TResult : class
        {
            throw new NotImplementedException();

            //IRequest<TResult> request = null;

            switch (type)
            {
                // TODO: Add factory method implementation here
                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no request object available for the message type '{type}'."
                    );
            }


            //return configurationRequest;
        }
    }


}