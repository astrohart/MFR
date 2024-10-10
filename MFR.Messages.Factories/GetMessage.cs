using MFR.Messages.Constants;
using MFR.Messages.Interfaces;
using System;

namespace MFR.Messages.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.IMessage" />
    /// interface.
    /// </summary>
    public static class GetMessage
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IMessage" />
        /// interface and returns a
        /// reference to it.
        /// </summary>
        /// <remarks>The current implementation of this method throws <see cref="T:System.NotImplementedException"/>.</remarks>
        public static IMessage For(MessageType type)
            => throw new NotImplementedException();

        //IMessage message = null;
        /*
            switch (type)
            {
                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"There is no message available that corresponds to the type '{type}'."
                    );
            }
            */
        //return message
    }
}