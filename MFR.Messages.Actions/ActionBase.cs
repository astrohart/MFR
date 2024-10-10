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