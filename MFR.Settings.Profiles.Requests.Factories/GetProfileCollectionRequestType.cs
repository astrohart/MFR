using MFR.Messages.Requests.Intefaces;
using MFR.Settings.Profiles.Requests.Constants;
using System;

namespace MFR.Settings.Profiles.Requests.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Messages.Requests.Intefaces.IRequest" />
    /// interface, in order to carry out requests on the list of profiles.
    /// </summary>
    /// <remarks>
    /// In our parlance, an Request is a process that has both an input and an output.
    /// </remarks>
    public static class GetProfileCollectionRequestType
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Messages.Requests.Intefaces.IRequest" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <param name="requestType">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.Messages.Constants.MessageType" />
        /// value that
        /// indicates what request to carry out.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Messages.Requests.Interfaces.IRequest" />
        /// interface
        /// that corresponds to the specified
        /// <see cref="T:MFR.Messages.Constants.MessageType" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if no request is available that corresponds to the
        /// <see
        ///     cref="T:MFR.Messages.Constants.MessageType" />
        /// value provided
        /// in the <paramref name="requestType" /> parameter.
        /// </exception>
        public static IRequest<TResult>
            For<TResult>(ProfileCollectionRequestType requestType)
            where TResult : class
        {
            IRequest<TResult> request;

            switch (requestType)
            {
                case var _ when requestType ==
                                ProfileCollectionRequestType.CreateNewBlankProfile:
                    request =
                        (IRequest<TResult>)
                        CreateNewBlankProfileRequest.Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(requestType), requestType,
                        $"There is no message available that corresponds to the type '{requestType}'."
                    );
            }

            return request;
        }
    }
}