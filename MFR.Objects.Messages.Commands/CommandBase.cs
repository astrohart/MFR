using MFR.Objects.Messages.Commands.Interfaces;
using System;
using System.Threading.Tasks;

namespace MFR.Objects.Messages.Commands
{
    /// <summary>
    /// Defines the methods, properties, events, and other functionality that is
    /// shared among all command objects.
    /// <para />
    /// In our vocabulary, a <c>command</c> object is an object that performs an
    /// operation but only accepts input and never returns any output.
    /// </summary>
    /// <typeparam name="TInput">
    /// Name of the class or data type that contains information used to execute
    /// the message.
    /// <para />
    /// This object is composed with the message object at runtime.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// Name of the class or data type that will carry user state information
    /// about the results of the operation.
    /// </typeparam>
    public abstract class CommandBase<TInput> : FixedMessageTypeSpecificObjectBase,
        ICommand<TInput> where TInput : class
    {
        /// <summary>
        /// Reference to an instance of <typeparamref name="TInput" /> that
        /// contains the input data.
        /// </summary>
        protected TInput _input;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.ActionBase" />
        /// and returns a
        /// reference to it.
        /// </summary>
        protected CommandBase()
        {
            _input = null;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.ActionBase" />
        /// and returns a
        /// reference to it.
        /// </summary>
        protected CommandBase(TInput input)
        {
            _input = input;
        }

        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        public void Execute()
            => CommonExecute();

        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        public Task ExecuteAsync()
            => Task.Run(CommonExecute);

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
        public ICommand<TInput> WithInput(TInput input)
        {
            _input = input ?? throw new ArgumentNullException(nameof(input));

            return this;
        }

        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        /// <remarks>
        /// Implementers must override this method in order to return this
        /// object's functionality.
        /// </remarks>
        protected abstract void CommonExecute();
    }
}