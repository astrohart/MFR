using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using xyLOGIX.Core.Debug;

namespace MFR.Messages.Actions
{
    /// <summary>
    /// Helper methods and properties to deal with the result cache.
    /// </summary>
    /// <typeparam name="TInput">
    /// Data type of the input of the action.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// Data type of the result of the action.
    /// </typeparam>
    public static class ActionCacheProvider<TInput, TResult>
        where TInput : class where TResult : class
    {
        /// <summary>
        /// Cache of already-processed results.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IDictionary<TInput, TResult> ResultCache
        {
            get;
        } = new Dictionary<TInput, TResult>();

        /// <summary>
        /// Adds an entry to the cache of previous results of this action.
        /// </summary>
        /// <param name="input">(Required.) Instance of an object of type <typeparamref name="TInput"/>.</param>
        /// <param name="result">(Required.) Instance of an object of type <typeparamref name="TResult"/>.</param>
        /// <remarks>If either of <paramref name="input"/> or <paramref name="result"/> are <see langword="null" />, then this method does nothing.</remarks>
        public static void Add(TInput input, TResult result)
        {
            // write the name of the current class and method we are now
            // Check to see if the required parameter, input, is null. If it is,
            if (input == null)
            {
                // the parameter input is required.
                // stop.
                return;
            }
            // Check to see if the required parameter, result, is null. If it
            if (result == null)
            {
                // the parameter result is required.
                // stop.
                return;
            }
            try
            {
                ResultCache[input] = result;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

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
        /// delegate that is run for
        /// each element of the cache, just prior to the cache being cleared.
        /// <para />
        /// If this parameter is not a <see langword="null" /> reference, then
        /// the code referenced by this delegate is invoked for every element of
        /// the result cache, prior to the cache being cleared.
        /// <para />
        /// This parameter can be useful should callers, say, need to run
        /// cleanup code to properly release system resources consumed by
        /// elements of the cache, prior to the cache itself being emptied.
        /// </param>
        [Log(AttributeExclude = true)]
        public static void Clear(Action<TInput, TResult> elementAction = null)
        {
            if (IsNullOrEmpty()) return; // nothing to do

            foreach (var element in ResultCache)
                elementAction?.Invoke(element.Key, element.Value);

            ResultCache.Clear();
        }

        /// <summary>
        /// Gets a value specifying whether the result cache is a
        /// <see
        ///     langword="null" />
        /// reference or if it contains zero items.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the result cache is <see langword="null" />
        /// or contains zero items; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public static bool IsNullOrEmpty()
            => ResultCache == null || ResultCache.Count == 0;
    }
}