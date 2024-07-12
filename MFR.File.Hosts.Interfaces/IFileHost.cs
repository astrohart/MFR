using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace MFR.File.Hosts.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// hosts a file during the <c>Replace Text in File</c> process.
    /// </summary>
    public interface IFileHost : IDisposable
    {
        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedViewAccessor" /> that
        /// exposes a read/write, random-access view of the block of memory containing the
        /// contents of a file on the file system whose fully-qualified pathname is given
        /// by the value of the <see cref="P:MFR.File.Hosts.FileHost.Path" /> property.
        /// </summary>
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
        /// <see cref="E:MFR.File.Hosts.FileHost.MemoryMappedDataChanged" /> event is
        /// raised.
        /// </remarks>
        MemoryMappedFile MemoryMappedData
        {
            get;
        }

        /// <summary>
        /// The original length of the file
        /// <see cref="F:MFR.File.Hosts.FileHost._stream" /> as originally passed to the
        /// constructor of this class.
        /// </summary>
        long OriginalLength
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the fully-qualified pathname
        /// of the file to which this object refers.
        /// </summary>
        string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of <see cref="T:System.IO.Stream" /> that
        /// refers to a file stream that is currently opened to the file having the
        /// fully-qualified pathname <see cref="P:MFR.File.Hosts.FileHost.Path" />.
        /// </summary>
        Stream Stream
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Text.Encoding"/> value that describes the encoding of the file.
        /// </summary>
        Encoding Encoding { get; set; }
    }
}