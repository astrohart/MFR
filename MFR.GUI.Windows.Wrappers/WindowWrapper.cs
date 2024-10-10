using MFR.GUI.Windows.Wrappers.Interfaces;
using System;

namespace MFR.GUI.Windows.Wrappers
{
    /// <summary>
    /// Creates IWin32Window around an IntPtr
    /// </summary>
    public class WindowWrapper : IWindowWrapper
    {
        /// <summary>
        /// Reference to an instance of <see cref="T:System.IntPtr" /> that
        /// stores the window handle.
        /// </summary>
        private IntPtr _handle;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Windows.Wrappers.WindowWrapper" />
        /// and returns a
        /// reference to it.
        /// </summary>
        public WindowWrapper()
        {
            _handle = IntPtr.Zero;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.GUI.Windows.Wrappers.WindowWrapper" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="handle">
        /// Reference to an instance of <see cref="T:System.IntPtr" /> that
        /// provides the window handle to be wrapped by this object.
        /// </param>
        public WindowWrapper(IntPtr handle)
        {
            _handle = handle;
        }

        /// <summary>
        /// Gets the handle to the window represented by the implementer.
        /// </summary>
        /// <returns>
        /// A handle to the window represented by the implementer.
        /// </returns>
        public IntPtr Handle
            => _handle;

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
        public IWindowWrapper ForWindowHandle(IntPtr handle)
        {
            if (IntPtr.Zero == handle)
                throw new ArgumentException(
                    "You must pass a non-zero value for the 'handle' parameter."
                );

            _handle = handle;

            return this;
        }
    }
}