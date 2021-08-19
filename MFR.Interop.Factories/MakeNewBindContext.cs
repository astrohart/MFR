using MFR.Win32;
using System;
using System.Runtime.InteropServices.ComTypes;
using xyLOGIX.Core.Debug;

namespace MFR.Interop.Factories
{
    /// <summary>
    /// Instructs the operating system to create instances of objects that
    /// implement the
    /// <see
    ///     cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
    /// interface.
    /// </summary>
    public static class MakeNewBindContext
    {
        /// <summary>
        /// Instructs the operating system to create an instance of an object
        /// that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
        /// interface, or <see langword="null" /> if the operating system failed
        /// to carry out the requested operation.
        /// </returns>
        /// <remarks>
        /// <b>NOTE:</b> There is no guarantee that this method will work. If an
        /// error occurs in the operating system during the object creation
        /// process, this method will return <see langword="null" />.
        /// <para />
        /// Callers of this method <i>must</i> validate the return value before proceeding.
        /// </remarks>
        public static IBindCtx FromScratch()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In MakeNewBindContext.FromScratch"
            );

            IBindCtx result;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "MakeNewBindContext.FromScratch: Instructing the operating system to create a new bind context object..."
                );

                NativeMethods.CreateBindCtx(0, out result);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            if (result != null)
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** New bind context object created."
                );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "MakeNewBindContext.FromScratch: Done."
            );

            return result;
        }
    }
}