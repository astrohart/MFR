using System;
using System.Runtime.InteropServices.ComTypes;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates and initializes instances of objects that implement the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IMonikerWrapper" />
    /// interface and returns
    /// references to them.
    /// </summary>
    public static class MakeNewMonikerWrapper
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IMonikerWrapper" />
        /// interface, given
        /// the provided <paramref name="bindContext" />,
        /// <paramref
        ///     name="runningObjectTable" />
        /// , and <paramref name="currentMoniker" />
        /// references that are provided in the corresponding arguments.
        /// </summary>
        /// <param name="bindContext">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
        /// interface.
        /// </param>
        /// <param name="runningObjectTable">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IRunningObjectTable" />
        /// interface.
        /// </param>
        /// <param name="PARM">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Runtime.InteropServices.ComTypes.IMoniker" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IMonikerWrapper" />
        /// interface, with
        /// its properties initialized.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if any of the required parameters,
        /// <paramref
        ///     name="bindContext" />
        /// , <paramref name="runningObjectTable" />, or
        /// <paramref name="currentMoniker" /> are passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        public static IMonikerWrapper From(IBindCtx bindContext,
            IRunningObjectTable runningObjectTable, IMoniker currentMoniker)
        {
            if (bindContext == null)
                throw new ArgumentNullException(nameof(bindContext));
            if (runningObjectTable == null)
                throw new ArgumentNullException(nameof(runningObjectTable));
            if (currentMoniker == null)
                throw new ArgumentNullException(nameof(currentMoniker));

            return new MonikerWrapper {
                Moniker = currentMoniker,
                DisplayName = GetOperatingSystemObjectDisplayName.Instance
                    .FromMoniker(currentMoniker)
                    .UsingBindContext(bindContext),
                ComObject = GetRunningOperatingSystemObject.Instance
                    .FromMoniker(currentMoniker)
                    .AndRunningObjectTable(runningObjectTable)
            };
        }
    }
}