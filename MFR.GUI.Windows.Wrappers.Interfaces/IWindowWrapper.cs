using System;
using System.Windows.Forms;

namespace MFR.GUI.Windows.Wrappers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a window-wrapper object.
    /// </summary>
    public interface IWindowWrapper : IWin32Window
    {
        /// <summary>
        /// Specifies the window handle to be wrapped by this object.
        /// </summary>
        /// <param name="handle">
        /// (Required.) Reference to an instance of
        /// <see
        ///     cref="T:System.IntPtr" />
        /// that specifies the handle of the window
        /// that is to be wrapped by this object.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IWindowWrapper ForWindowHandle(IntPtr handle);
    }
}