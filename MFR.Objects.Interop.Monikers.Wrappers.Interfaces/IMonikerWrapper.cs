using System.Runtime.InteropServices.ComTypes;

namespace MFR.Objects.Interop.Monikers.Wrappers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object wraps
    /// an instance of an object that implements the
    /// <see
    ///     cref="T:System.Runtime.InteropServices.ComTypes.IMoniker" />
    /// interface.
    /// </summary>
    public interface IMonikerWrapper
    {
        /// <summary>
        /// Gets a reference to an instance of the COM object that corresponds
        /// to the moniker.
        /// </summary>
        object ComObject
        {
            get;
        }

        /// <summary>
        /// Gets a string that contains the object's display name.
        /// </summary>
        string DisplayName
        {
            get;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:System.Runtime.InteropServices.ComTypes.IMoniker" /> interface.
        /// </summary>
        IMoniker Moniker
        {
            get;
        }
    }
}