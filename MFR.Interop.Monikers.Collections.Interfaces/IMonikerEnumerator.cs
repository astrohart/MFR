using MFR.Objects.Interop.Monikers.Wrappers.Interfaces;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace MFR.Objects.Interop.Monikers.Collections.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an enumerable
    /// collection of COM object monikers.
    /// </summary>
    public interface IMonikerEnumerator : IEnumerator<IMonikerWrapper>
    {
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
        IMonikerEnumerator AttachBindContext(IBindCtx bindContext);

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
        IMonikerEnumerator AttachOperatingSystemEnumerator(
            IEnumMoniker monikerEnumerator);

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
        IMonikerEnumerator AttachRunningObjectTable(
            IRunningObjectTable runningObjectTable);
    }
}