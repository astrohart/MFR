using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Caches the results of repeated operations using the same inputs in order
    /// to improve performance.
    /// </summary>
    /// <typeparam name="TInput">
    /// Data type of the input of the action.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// Data type of the result of the action.
    /// </typeparam>
    /// <remarks>
    /// Implementations should inherit from this class when it is believed that
    /// calling an action with the same input will always yield the same result.
    /// <para />
    /// Such caching is designed to enhance application performance.
    /// <para />
    /// This parent class is especially useful for actions that need to query a
    /// data source whose data rarely changes, but for which access poses a
    /// non-negligible reduction in performance.
    /// </remarks>
    public abstract class
        CachedResultActionBase<TInput, TResult> : ActionBase<TInput, TResult>,
            ICachedResultAction<TInput, TResult> where TInput : class
        where TResult : class
    {
        /// <summary>
        /// Returns a reference to this same object, but cast to the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ICachedResultAction" />
        /// interface.
        /// </summary>
        /// <returns>
        /// Reference to the same object instance as that which invoked this
        /// method, cast to the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ICachedResultAction" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.InvalidCastException">
        /// Thrown if the implementing object does not also implement the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ICachedResultAction" />
        /// interface.
        /// </exception>
        /// <remarks>
        /// Overriders of this method must not call the base class.
        /// </remarks>
        public override ICachedResultAction<TInput, TResult>
            AsCachedResultAction()
            => this;

        public virtual void ClearResultCache(
            Action<TInput, TResult> elementAction = null)
            => ActionCacheProvider<TInput, TResult>.Clear(elementAction);

        /// <summary>
        /// Allows an object to try to free resources and perform other cleanup
        /// operations before it is reclaimed by garbage collection.
        /// </summary>
        [Log(AttributeExclude = true)]
        ~CachedResultActionBase()
        {
            // Upon disposal of this object, clear the result cache first.
            ClearResultCache();
        }

        /// <summary>
        /// Associates a reference to the <paramref name="resultToAdd" /> to the
        /// current value of the
        /// <see
        ///     cref="F:MassFileRenamer.Objects.ActionBase._input" />
        /// field. using
        /// the internal result cache dictionary.
        /// </summary>
        /// <param name="resultToAdd">
        /// Reference to an instance of <typeparamref name="TResult" /> that is
        /// to be associated with the current input value.
        /// </param>
        protected virtual void AddResultToCache(TResult resultToAdd)
            => ActionCacheProvider<TInput, TResult>.Add(_input, resultToAdd);

        /// <summary>
        /// Executes this message.
        /// </summary>
        /// <returns>
        /// A <typeparamref name="TResult" /> instance containing data from the
        /// result of executing the message.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// </remarks>
        protected sealed override TResult CommonExecute()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In CachedActionBase.CommonExecute"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the _input field has a null reference for a value..."
            );

            var result = default(TResult);

            // Check to see if the required field, _input, is null. If it is,
            // send an error to the log file and quit.
            if (_input == default(TInput))
            {
                // the field _input is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The _input field has a null reference.  This field is required."
                );

                // log the result
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"CachedActionBase.CommonExecute: Result = {result}"
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The _input field has a valid object reference for its value."
            );

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Checking whether the result is in the result cache..."
                );

                if (TryGetCachedResult(out result) && result != null)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "*** SUCCESS *** Found the result in the cache.  Using the value retrieved as the return value of this method."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        "CachedActionBase.CommonExecute: Done."
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: The cache did not contain the current input, so we are needing to perform the operation regardless..."
                );

                result = ExecuteOperationIfNotCached();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
            }

            if (result != null)
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** Successfully obtained the result."
                );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "CachedActionBase.CommonExecute: Done."
            );

            return result;
        }

        /// <summary>
        /// Performs this action's operation if the result could not located in
        /// the result cache.
        /// </summary>
        /// <returns>
        /// Reference to an instance of <typeparamref name="TResult" /> that
        /// corresponds to the current input or <c>null</c> if an issue occurred.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// <para />
        /// This is a template method, the call to which is wrapped in a robust
        /// and fault-tolerant override of the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ActionBase.CommonExecute" />
        /// method.
        /// <para />
        /// The parent method override (a) validates that the _input field is
        /// not null, (b) checks for thrown exceptions, and(c) checks the result
        /// cache first to see if data corresponding to the input is there.
        /// </remarks>
        protected abstract TResult ExecuteOperationIfNotCached();

        /// <summary>
        /// Attempts to access the result cache dictionary using the current
        /// value of the
        /// <see
        ///     cref="F:MassFileRenamer.Objects.ActionBase._input" />
        /// field, and asks
        /// whether it is present in the cache.
        /// </summary>
        /// <param name="result">
        /// Reference to a memory location that will receive a reference to an
        /// instance of <typeparamref name="TResult" /> if one is found in the
        /// result cache; otherwise, will be assigned the <c>null</c> reference.
        /// </param>
        /// <returns>
        /// If the current value of the
        /// <see
        ///     cref="F:MassFileRenamer.Objects.ActionBase._input" />
        /// field is
        /// present in the result cache dictionary and associated with a
        /// corresponding result, then the <paramref name="result" /> parameter
        /// is filled with the corresponding value, and this method returns
        /// <c>true</c>; otherwise, the method returns <c>false</c> and the
        /// <paramref name="result" /> parameter is assigned a <c>null</c> reference.
        /// </returns>
        /// <remarks>
        /// This method really is merely an alias for the
        /// <see
        ///     cref="M:System.Collections.Generic.IDictionary.TryGetValue" />
        /// method.
        /// <para />
        /// <b>NOTE:</b> Child classes may override this method in order to
        /// provide additional processing; however, it is mandatory to begin the
        /// override's code with a call to the base class.
        /// </remarks>
        protected virtual bool TryGetCachedResult(out TResult result)
            => ActionCacheProvider<TInput, TResult>.ResultCache.TryGetValue(
                _input, out result
            );
    }
}