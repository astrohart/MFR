using PostSharp.Patterns.Diagnostics;
using System;
using System.Runtime.InteropServices.ComTypes;
using xyLOGIX.Core.Debug;

namespace MFR.Interop.Monikers.Wrappers.Factories
{
    /// <summary>
    /// Obtains the display names of objects from the operating-system-provided
    /// Running Object Table (ROT) for the local workstation.
    /// </summary>
    public class GetOperatingSystemObjectDisplayName
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
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IMoniker" />
        /// interface.
        /// </summary>
        private IMoniker _moniker;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static GetOperatingSystemObjectDisplayName() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected GetOperatingSystemObjectDisplayName() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.GetDisplayName" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static GetOperatingSystemObjectDisplayName Instance
        {
            get;
        } = new GetOperatingSystemObjectDisplayName();

        /// <summary>
        /// Associates a reference to an instance of an
        /// operating-system-provided object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IMoniker" />
        /// interface with this factory.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="moniker" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public GetOperatingSystemObjectDisplayName FromMoniker(IMoniker moniker)
        {
            _moniker = moniker ??
                       throw new ArgumentNullException(nameof(moniker));

            return this;
        }

        /// <summary>
        /// Associates a reference to an instance of an
        /// operating-system-provided object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
        /// interface with this factory and, using it and the
        /// <see
        ///     cref="F:MFR.GetDisplayName._moniker" />
        /// field's
        /// value, attempts to obtain the moniker's display name from the
        /// operating system.
        /// </summary>
        /// <param name="bindContext">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
        /// interface.
        /// </param>
        /// <returns>
        /// String containing the display name, or blank if the display name
        /// could not be obtained from the operating system.
        /// </returns>
        /// <remarks>
        /// Clients of this class must call the
        /// <see
        ///     cref="M:MFR.GetOperatingSystemObjectDisplayName.FromMoniker" />
        /// method prior to calling this method. If that has not been done, then
        /// this method will throw
        /// <see
        ///     cref="T:System.InvalidOperationException" />
        /// .
        /// <b>
        /// NOTE: This method is not guaranteed to work. Callers must check the
        /// return value of this method for blank, and give up the current
        /// operation if it is so.
        /// <para />
        /// No further operating-system error information will be returned.
        /// </b>
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="bindContext" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if this method has been called without calling the
        /// <see
        ///     cref="M:MFR.GetOperatingSystemObjectDisplayName.FromMoniker" />
        /// method first.
        /// </exception>
        public string UsingBindContext(IBindCtx bindContext)
        {
            _bindContext = bindContext ??
                           throw new ArgumentNullException(nameof(bindContext));

            if (_moniker == null)
                throw new InvalidOperationException(
                    "You must call the FromMoniker method prior to calling the UsingBindContext method."
                );

            string result;

            try
            {
                _moniker.GetDisplayName(_bindContext, null, out result);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}