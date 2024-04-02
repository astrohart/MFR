using System;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace MFR.File.Hosts.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// hosts a file during the <c>Replace Text in File</c> process..
    /// </summary>
    public interface IFileHost : IDisposable
    {
        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedViewAccessor" /> that
        /// exposes a read/write, random-access view of the block of memory containing the
        /// contents of a file on the file system whose fully-qualified pathname is given
        /// by the value of the <see cref="P:MFR.File.Hosts.Interfaces.IFileHost.Path" />
        /// property.
        /// </summary>
        /// <remarks>
        /// When the value of this property is updated, the
        /// <see cref="E:MFR.File.Hosts.Interfaces.IFileHost.AccessorChanged" /> event is
        /// raised.
        /// </remarks>
        MemoryMappedViewAccessor Accessor
        {
            get;
        }

        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFile" />
        /// </summary>
        /// <remarks>
        /// If the value of this property is updated, then the
        /// <see cref="E:MFR.File.Hosts.Interfaces.IFileHost.MemoryMappedDataChanged" />
        /// event is raised.
        /// </remarks>
        MemoryMappedFile MemoryMappedData
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the fully-qualified pathname
        /// of the file to which this object refers.
        /// </summary>
        string Path
        {
            get;
        }

        /// <summary>
        /// Gets a reference to an instance of <see cref="T:System.IO.Stream" /> that
        /// refers to a file stream that is currently opened to the file having the
        /// fully-qualified pathname
        /// <see cref="P:MFR.File.Hosts.Interfaces.IFileHost.Path" />.
        /// </summary>
        Stream Stream
        {
            get;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.File.Hosts.Interfaces.IFileHost.Accessor" />
        /// property is updated.
        /// </summary>
        event EventHandler AccessorChanged;

        /// <summary>
        /// Raised when the value of the
        /// <see cref="P:MFR.File.Hosts.Interfaces.IFileHost.MemoryMappedData" /> property
        /// is updated.
        /// </summary>
        event EventHandler MemoryMappedDataChanged;
    }
}