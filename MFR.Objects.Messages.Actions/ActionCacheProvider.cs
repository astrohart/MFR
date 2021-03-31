using System;
using System.Collections.Generic;

namespace MFR.Objects.Messages.Actions
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
        public static IDictionary<TInput, TResult> ResultCache
        {
            get;
        } = new Dictionary<TInput, TResult>();

        public static void Add(TInput input, TResult result)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In ActionCacheProvider.Add"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "ActionCacheProvider.Add: Checking whether the 'input' method parameter has a null reference for a value..."
            );

            // Check to see if the required parameter, input, is null. If it is,
            // send an error to the log file and quit, returning from this method.
            if (input == null)
            {
                // the parameter input is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "ActionCacheProvider.Add: A null reference was passed for the 'input' method parameter."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "ActionCacheProvider.Add: This method parameter is required to have a valid object reference."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "ActionCacheProvider.Add: Done."
                );

                // stop.
                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "ActionCacheProvider.Add: We have been passed a valid object reference for the 'input' method parameter."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "ActionCacheProvider.Add: Checking whether the 'result' method parameter has a null reference for a value..."
            );

            // Check to see if the required parameter, result, is null. If it
            // is, send an error to the log file and quit, returning from this method.
            if (result == null)
            {
                // the parameter result is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "ActionCacheProvider.Add: A null reference was passed for the 'result' method parameter."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "ActionCacheProvider.Add: This method parameter is required to have a valid object reference."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Debug, "ActionCacheProvider.Add: Done."
                );

                // stop.
                return;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "ActionCacheProvider.Add: We have been passed a valid object reference for the 'result' method parameter."
            );

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "ActionCacheProvider.Add: Associating the most-recently returned result with the input parameters..."
                );

                ResultCache[input] = result;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** The cache has been updated."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug, "ActionCacheProvider.Add: Done."
            );
        }

        /// <summary>
            /// Clears all entries that are currently stored in the result cache.
            /// <para/>
            /// Optionally invokes a delegate for each element of the result
            /// cache prior to performing the clear operation.
            /// </summary>
            /// <param name="elementAction">
            /// (Optional.) Reference to an instance of an instance of a <see
            /// cref="T:System.Action{TInput, TResult}"/> delegate that is run
            /// for each element of the cache, just prior to the cache being cleared.
            /// <para/>
            /// If this parameter is not a <see langword="null" /> reference, then the code
            /// referenced by this delegate is invoked for every element of the
            /// result cache, prior to the cache being cleared.
            /// <para/>
            /// This parameter can be useful should callers, say, need to run
            /// cleanup code to properly release system resources consumed by
            /// elements of the cache, prior to the cache itself being emptied.
            /// </param>
            public static void Clear(
                Action<TInput, TResult> elementAction = null)
            {
                if (IsNullOrEmpty()) return; // nothing to do

                foreach (var element in ResultCache)
                    elementAction?.Invoke(element.Key, element.Value);

                ResultCache.Clear();
            }

            /// <summary>
            /// Gets a value specifying whether the result cache is a
            /// <see langword="null" /> reference or if it contains zero items.
            /// </summary>
            /// <returns>
            /// <see langword="true" /> if the result cache is <see langword="null" /> or contains zero
            /// items; <see langword="false" /> otherwise.
            /// </returns>
            public static bool IsNullOrEmpty()
                => ResultCache == null || ResultCache.Count == 0;
        }
    }