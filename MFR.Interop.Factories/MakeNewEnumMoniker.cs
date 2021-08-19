using System;
using System.Runtime.InteropServices.ComTypes;
using xyLOGIX.Core.Debug;

namespace MFR.Interop.Factories
{
    /// <summary>
    /// Instructs the operating system to create instances of objects that
    /// implement the
    /// <see
    ///     cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" />
    /// interface given a reference to an instance of an object that implements
    /// other interfaces.
    /// </summary>
    public static class MakeNewEnumMoniker
    {
        /// <summary>
        /// Given a reference to an instance of an operating-system-provided
        /// object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />
        /// interface, instructs the operating system to give us access to an
        /// instance of an object, that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" />
        /// interface, which provides access to enumerating the entries of the
        /// Running Object Table (ROT) on the local workstation.
        /// </summary>
        /// <param name="runningObjectTable">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" />
        /// interface, or <see langword="null" /> if the operating system was
        /// unable to provide the application with the requested access.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="runningObjectTable" />
        /// , is passed a <see langword="null" /> value.
        /// </exception>
        /// <remarks>
        /// <b>NOTE:</b> This method is not guaranteed to work. If the operating
        /// system is unable to allow the application access to the requested
        /// object, or another internal error occurs, this method returns
        /// <see
        ///     langword="null" />
        /// . Callers of this method should check for a
        /// <see
        ///     langword="null" />
        /// result prior to proceeding.
        /// </remarks>
        public static IEnumMoniker From(IRunningObjectTable runningObjectTable)
        {
            if (runningObjectTable == null)
                throw new ArgumentNullException(nameof(runningObjectTable));

            IEnumMoniker result;

            try
            {
                runningObjectTable.EnumRunning(out result);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null; // reset the result to null
            }

            return result;
        }
    }
}