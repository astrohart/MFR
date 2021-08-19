using MFR.Interop.Monikers.Collections.Interfaces;
using MFR.Interop.Monikers.Wrappers.Factories;
using MFR.Interop.Monikers.Wrappers.Interfaces;
using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using xyLOGIX.Core.Debug;

namespace MFR.Interop.Monikers.Collections
{
    /// <summary>
    /// Enumerates through COM object moniker tables provided by the operating system.
    /// </summary>
    public class MonikerEnumerator : IMonikerEnumerator
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
        /// interface.
        /// </summary>
        private IBindCtx _bindContext;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object provides enumeration services.
        /// </remarks>
        private IEnumMoniker _monikerEnumerator;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />
        /// interface.
        /// </summary>
        private IRunningObjectTable _runningObjectTable;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.MonikerEnumerator" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <remarks>
        /// Callers of this constructor should then immediately call the
        /// <see
        ///     cref="M:MFR.MonikerEnumerator.AttachOperatingSystemEnumerator" />
        /// method to associate this object with an enumerator object provided
        /// by the operating system.
        /// </remarks>
        public MonikerEnumerator()
        {
            _monikerEnumerator = null;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Interop.Monikers.Collections.MonikerEnumerator" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="monikerEnumerator">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" />
        /// interface that provides enumeration services over a COM object
        /// moniker collection.
        /// </param>
        public MonikerEnumerator(IEnumMoniker monikerEnumerator)
        {
            _monikerEnumerator = monikerEnumerator;
        }

        /// <summary>
        /// Gets the element in the collection at the current position of the enumerator.
        /// </summary>
        /// <returns>
        /// The element in the collection at the current position of the enumerator.
        /// </returns>
        public IMonikerWrapper Current
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the element in the collection at the current position of the enumerator.
        /// </summary>
        /// <returns>
        /// The element in the collection at the current position of the enumerator.
        /// </returns>
        object IEnumerator.Current
            => Current;

        /// <summary>
        /// Associates an instance of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
        /// interface with this collection.
        /// </summary>
        /// <param name="bindContext">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="bindContext" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public IMonikerEnumerator AttachBindContext(IBindCtx bindContext)
        {
            _bindContext = bindContext ??
                           throw new ArgumentNullException(nameof(bindContext));

            return this;
        }

        /// <summary>
        /// Associates this object with an instance of an operating-system
        /// provided object, that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" />
        /// interface, providing enumeration services for a collection of COM
        /// object monikers.
        /// </summary>
        /// <param name="monikerEnumerator">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="monikerEnumerator" />
        /// , is passed a <see langword="null" /> value.
        /// </exception>
        public IMonikerEnumerator AttachOperatingSystemEnumerator(
            IEnumMoniker monikerEnumerator)
        {
            _monikerEnumerator = monikerEnumerator ??
                                 throw new ArgumentNullException(
                                     nameof(monikerEnumerator)
                                 );

            return this;
        }

        /// <summary>
        /// Associates an instance of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />
        /// interface with this collection.
        /// </summary>
        /// <param name="runningObjectTable">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="runningObjectTable" />
        /// , is passed a <see langword="null" /> value.
        /// </exception>
        public IMonikerEnumerator AttachRunningObjectTable(
            IRunningObjectTable runningObjectTable)
        {
            _runningObjectTable = runningObjectTable ??
                                  throw new ArgumentNullException(
                                      nameof(runningObjectTable)
                                  );

            return this;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing,
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
            => Reset();

        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the enumerator was successfully advanced
        /// to the next element; <see langword="false" /> if the enumerator has
        /// passed the end of the collection, or if the
        /// <see
        ///     cref="M:MFR.MonikerEnumerator.AttachOperatingSystemEnumerator" />
        /// method has not been called with a valid object reference to an
        /// instance of an object implementing the
        /// <see
        ///     cref="M:System.Runtime.InteropServices.ComTypes.IEnumMoniker" />
        /// method having been passed to its sole parameter first.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        /// The collection was modified after the enumerator was created.
        /// </exception>
        public bool MoveNext()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MonikerEnumerator.MoveNext"
            );

            var result = false;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the '_bindContext' field has a null reference for a value..."
            );

            // Check to see if the required field, '_bindContext', is null. If
            // it is, send an error to the log file and quit.
            if (_bindContext == null)
            {
                // the field '_bindContext' is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The '_bindContext' field has a null reference.  This field is required."
                );

                // log the result
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "MonikerEnumerator.MoveNext: Result = {0}", result
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The '_bindContext' field has a valid object reference for its value."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the '_runningObjectTable' field has a null reference for a value..."
            );

            // Check to see if the required field, '_runningObjectTable', is
            // null. If it is, send an error to the log file and quit.
            if (_runningObjectTable == null)
            {
                // the field '_runningObjectTable' is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The '_runningObjectTable' field has a null reference.  This field is required."
                );

                // log the result
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "MonikerEnumerator.MoveNext: Result = {0}", result
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The '_runningObjectTable' field has a valid object reference for its value."
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** INFO: Checking whether the '_monikerEnumerator' field has a null reference for a value..."
            );

            // Check to see if the required field, '_monikerEnumerator', is null. If it
            // is, send an error to the log file and quit.
            if (_monikerEnumerator == null)
            {
                // the field '_enumerator' is required.
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR: The '_monikerEnumerator' field has a null reference.  This field is required.  Please call the AttachOperatingSystemEnumerator method prior to calling this method."
                );

                // log the result
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "MonikerEnumerator.MoveNext: Result = {0}", result
                );

                // stop.
                return result;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The '_enumerator' field has a valid object reference for its value."
            );

            /*
             * OKAY, the operating system calls here date back from Win32 APIs,
             * so they are a little quirky.  We assume we have a valid object
             * reference in the _enumerator field.   If that is not the case, then
             * this method returns false.
             */

            var results =
                new IMoniker[1]; // array where results will be placed by the operating system

            /*
             * OKAY, we call the IEnumMoniker.Next method here, with a value of 1 to
             * request just the very next element in the list.  If the sole element of the
             * results array is NULL, then the method call failed.  If the return value of the
             * IEnumMoniker.Next method is nonzero, then the end of the sequence has been reached.
             */

            try
            {
                var numberFetched = IntPtr.Zero;
                result =
                    0 == _monikerEnumerator.Next(1, results, numberFetched) &&
                    results[0] != null;
                if (result == false)
                    return result; /* stop here */

                var currentMoniker = results[0];

                Current = MakeNewMonikerWrapper.From(
                    _bindContext, _runningObjectTable, currentMoniker
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result =
                    false; // if any type of error occurred, obviously we cannot move to the next element
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"MonikerEnumerator.MoveNext: Result = {result}"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "MonikerEnumerator.MoveNext: Done."
            );

            return result;
        }

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the
        /// first element in the collection.
        /// </summary>
        /// <exception cref="T:System.InvalidOperationException">
        /// The collection was modified after the enumerator was created.
        /// </exception>
        public void Reset()
            => _monikerEnumerator?.Reset();
    }
}