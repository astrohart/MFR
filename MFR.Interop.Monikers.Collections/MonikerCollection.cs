using MFR.Interop.Monikers.Collections.Interfaces;
using MFR.Interop.Monikers.Wrappers.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace MFR.Interop.Monikers.Collections
{
    /// <summary>
    /// Collection that represents an operating-system defined table of COM
    /// object monikers.
    /// </summary>
    /// <remarks>
    /// This object must be associated with an instance of an object that
    /// implements the
    /// <see
    ///     cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" />
    /// interface.
    /// </remarks>
    public class MonikerCollection : IMonikerEnumerable
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
        private IEnumMoniker _monikerEnumerator;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />
        /// interface.
        /// </summary>
        private IRunningObjectTable _runningObjectTable;

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:MFR.IMonikerEnumerator" />
        /// interface and which provides COM object moniker enumeration services.
        /// </summary>
        private IMonikerEnumerator Enumerator
        {
            get;
        } = new MonikerEnumerator();

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
        public IMonikerEnumerable AndAttachOperatingSystemEnumerator(
            IEnumMoniker monikerEnumerator)
        {
            _monikerEnumerator = monikerEnumerator ??
                                 throw new ArgumentNullException(
                                     nameof(monikerEnumerator)
                                 );

            Enumerator.AttachOperatingSystemEnumerator(_monikerEnumerator);

            return this;
        }

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
        public IMonikerEnumerable AndBindContext(IBindCtx bindContext)
        {
            _bindContext = bindContext ??
                           throw new ArgumentNullException(nameof(bindContext));

            Enumerator.AttachBindContext(_bindContext);

            return this;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<IMonikerWrapper> GetEnumerator()
            => Enumerator;

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be
        /// used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();

        /// <summary>
        /// Associates an instance of an operating-system-provided object that
        /// implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />
        /// interface with this object.
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
        public IMonikerEnumerable AndRunningObjectTable(
            IRunningObjectTable runningObjectTable)
        {
            _runningObjectTable = runningObjectTable ??
                                  throw new ArgumentNullException(
                                      nameof(runningObjectTable)
                                  );

            Enumerator.AttachRunningObjectTable(_runningObjectTable);

            return this;
        }
    }
}