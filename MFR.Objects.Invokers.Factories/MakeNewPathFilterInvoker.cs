using MFR.Objects.FileSystem.Interfaces;
using MFR.Objects.Invokers.Interfaces;

namespace MFR.Objects.Invokers.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.Invokers.Interfaces.IPathFilterInvoker" />
    /// interface
    /// and initializes them.
    /// </summary>
    public static class MakeNewPathFilterInvoker
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.Invokers.Interfaces.IPathFilterInvoker" />
        /// interface and initializes it with the instance of an object that
        /// implements the
        /// <see
        ///     cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface that is supplied by the <paramref name="entry" /> parameter.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.Invokers.Interfaces.IPathFilterInvoker" />
        /// interface that is initialized with the value of the
        /// <see
        ///     cref="P:MFR.Objects.FileSystem.Interfaces.IFileSystemEntry.Path" />
        /// property of the <paramref name="entry" /> parameter.
        /// </returns>
        public static IPathFilterInvoker For(IFileSystemEntry entry)
            => PathFilterInvokerBase.Instance.AndPath(entry?.Path);

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.Invokers.Interfaces.IPathFilterInvoker" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.Invokers.Interfaces.IPathFilterInvoker" />
        /// interface.
        /// </returns>
        public static IPathFilterInvoker FromScratch()
            => PathFilterInvokerBase.Instance;
    }
}