using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace MFR.Objects.Interop
{
    /// <summary>
    /// Contains methods that instruct the operating system to provide us with
    /// access to the instance of the Running Object Table (ROT) on the local
    /// workstation.
    /// </summary>
    public static class GetRunningObjectTable
    {
        /// <summary>
        /// Instructs the operating system to provide a reference to an instance
        /// of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />
        /// interface.
        /// <para />
        /// Such an object provides access to the local table of OLE objects
        /// that are currently running on the local workstation.
        /// </summary>
        /// <param name="ctx">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />
        /// interface that represents the local running object table.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="ctx" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        /// <remarks>
        /// <b>NOTE:</b> There is no guarantee that this method will work. If an
        /// error occurs in the operating system during the operation, then this
        /// method will return <see langword="null" />.
        /// <para />
        /// Callers of this method <i>must</i> validate the return value before proceeding.
        /// </remarks>
        public static IRunningObjectTable FromBindContext(IBindCtx ctx)
        {
            if (ctx == null) throw new ArgumentNullException(nameof(ctx));

            IRunningObjectTable result;

            try
            {
                ctx.GetRunningObjectTable(out result);
            }
            catch (COMException ex)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "GetRunningObjectTable.FromBindContext: COM operation failed."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    $"GetRunningObjectTable.FromBindContext: {ex.Message}"
                );

                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = null;
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
                    "*** SUCCESS *** Reference to the Running Object Table (ROT) obtained successfully."
                );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "GetRunningObjectTable.FromBindContext: Done."
            );

            return result;
        }
    }
}