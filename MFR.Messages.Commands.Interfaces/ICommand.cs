using MFR.Messages.Interfaces;

namespace MFR.Messages.Commands.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a command object.
    /// <para />
    /// In our vocabulary, a <c>command</c> object is an object that performs an
    /// operation but only accepts input and never returns any output.
    /// </summary>
    public interface ICommand<TInput> : IMessage
        where TInput : class
    {
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
        ICommand<TInput> WithInput(TInput input);
    }
}