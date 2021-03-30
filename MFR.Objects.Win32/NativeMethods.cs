using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace MFR.Objects.Win32
{
    /// <summary>
    /// P/Invoke signatures of Win32 API functions and constants.
    /// </summary>
    public static class NativeMethods
    {
        /// <summary>
        /// Returns a pointer to an implementation of IBindCtx (a bind
        /// context object). This object stores information about a
        /// particular moniker-binding operation.
        /// </summary>
        /// <param name="reserved">
        /// (Required.) This parameter is reserved and must be 0.
        /// </param>
        /// <param name="ppbc">
        /// (Required.) Address of an <see cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx"/>* pointer variable that receives the interface pointer to the new bind context object.<para/>When the function is successful, the caller is responsible for calling the <see cref="M:stdole.IUnknown.Release"/> method on the bind context. A NULL value for the bind context indicates that an error occurred.
        /// </param>
        /// <returns>
        /// This function can return the standard return values <c>E_OUTOFMEMORY</c> and <c>S_OK</c>.
        /// </returns>
        [DllImport("ole32.dll")]
        public static extern int CreateBindCtx(uint reserved,
            out IBindCtx ppbc);
    }
}