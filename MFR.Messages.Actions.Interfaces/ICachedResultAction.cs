using System;

namespace MFR.Messages.Actions.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an <c>action</c>
    /// object that caches the results from the prior times that its operation
    /// has been invoked for the same input..
    /// </summary>
    public interface
        ICachedResultAction<TInput, TResult> : IAction<TInput, TResult>
        where TInput : class where TResult : class
    {
        /// <summary>
        /// Clears all entries that are currently stored in the result cache.
        /// <para />
        /// Optionally invokes a delegate for each element of the result cache
        /// prior to performing the clear operation.
        /// </summary>
        /// <param name="elementAction">
        /// (Optional.) Reference to an instance of an instance of a
        /// <see
        ///     cref="T:System.Action{TInput, TResult}" />
        /// delegate.
        /// <para />
        /// If this parameter is not a <see langword="null" /> reference, then the code
        /// referenced by this delegate is invoked for every element of the
        /// result cache, prior to the cache being cleared.
        /// <para />
        /// This parameter can be useful should callers, say, need to run
        /// cleanup code to properly release system resources consumed by
        /// elements of the cache, prior to the cache itself being emptied.
        /// </param>
        void ClearResultCache(
            Action<TInput, TResult> elementAction = null);
    }
}