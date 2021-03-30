using MFR.Objects.Interop.Interfaces;
using System.Runtime.InteropServices.ComTypes;

namespace MFR.Objects.Interop
{
    /// <summary>
    /// POCO that encapsulates the information from the moniker table provided
    /// by the operating system.
    /// </summary>
    public class MonikerWrapper : IMonikerWrapper
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.Interop.MonikerWrapper" />
        /// and returns a
        /// reference to it.
        /// </summary>
        public MonikerWrapper()
        {
            ComObject = null;
            DisplayName = string.Empty;
            Moniker = null;
        }

        /// <summary>
        /// Gets a reference to an instance of the COM object that corresponds
        /// to the moniker.
        /// </summary>
        public object ComObject
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a string that contains the object's display name.
        /// </summary>
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:System.Runtime.InteropServices.ComTypes.IMoniker" /> interface.
        /// </summary>
        public IMoniker Moniker
        {
            get;
            set;
        }
    }
}