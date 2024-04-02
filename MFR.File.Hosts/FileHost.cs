using MFR.File.Hosts.Interfaces;
using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using xyLOGIX.Files.Actions;

namespace MFR.File.Hosts
{
    /// <summary>
    /// Hosts a file during the <c>Replace Text in File</c> process.
    /// </summary>
    public class FileHost : IFileHost
    {
        /// <summary>
        /// A <see cref="T:System.String" /> containing the fully-qualified pathname of the
        /// file to which this object refers.
        /// </summary>
        private readonly string _path;

        /// <summary>
        /// Reference to an instance of <see cref="T:System.IO.Stream" /> that refers to a
        /// currently-open file stream.
        /// </summary>
        private readonly Stream _stream;

        /// <summary>
        /// Reference to an instance of
        /// <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedViewAccessor" /> that is
        /// used to provide a read/write, random-access view of the block of memory
        /// containing the contents of a file on the file system whose fully-qualified
        /// pathname is given by the value of the
        /// <see cref="P:MFR.File.Hosts.FileHost.Path" /> property.
        /// </summary>
        private MemoryMappedViewAccessor _accessor;

        /// <summary>
        /// Reference to an instance of
        /// <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFile" /> that represents a
        /// block of memory having the same contents as the file on the file system
        /// referred to by the value of the <see cref="P:MFR.File.Hosts.FileHost.Path" />
        /// property.
        /// </summary>
        private MemoryMappedFile _mmf;

        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.File.Hosts.FileHost.FileHost" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file on the file system.
        /// </param>
        /// <param name="stream">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.IO.Stream" /> that represents a currently-open file stream.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if either of the parameters,
        /// <paramref name="path" /> or <paramref name="stream" /> are passed a
        /// <see langword="null" /> reference as an argument.
        /// </exception>
        /// <exception cref="FileNotFoundException">
        /// Thrown if the value of the
        /// <paramref name="path" /> parameter refers to a file that does not currently
        /// exist on the file system.
        /// </exception>
        public FileHost(string path, Stream stream)
        {
            _path = path ?? throw new ArgumentNullException(nameof(path));
            if (!Does.FileExist(path))
                throw new FileNotFoundException(
                    $"The system could not find the file '{path}'.", path
                );
            _stream = stream ?? throw new ArgumentNullException(nameof(stream));
            OriginalLength = stream.Length;
        }

        /// <summary>
        /// Gets a reference to an instance of
        /// <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedViewAccessor" /> that
        /// exposes a read/write, random-access view of the block of memory containing the
        /// contents of a file on the file system whose fully-qualified pathname is given
        /// by the value of the <see cref="P:MFR.File.Hosts.FileHost.Path" /> property.
        /// </summary>
        public MemoryMappedViewAccessor Accessor
        {
            get => _accessor;
            private set {
                var changed = value != null && !value.Equals(_accessor);
                _accessor = value;
                if (changed) OnAccessorChanged();
            }
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
        public MemoryMappedFile MemoryMappedData
        {
            get => _mmf;
            private set {
                var changed = value != null && !value.Equals(_mmf);
                _mmf = value;
                if (changed) OnMemoryMappedDataChanged();
            }
        }

        /// <summary>
        /// The original length of the file
        /// <see cref="F:MFR.File.Hosts.FileHost._stream" /> as originally passed to the
        /// constructor of this class.
        /// </summary>
        public long OriginalLength
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the fully-qualified pathname
        /// of the file to which this object refers.
        /// </summary>
        public string Path
            => _path;

        /// <summary>
        /// Gets a reference to an instance of <see cref="T:System.IO.Stream" /> that
        /// refers to a file stream that is currently opened to the file having the
        /// fully-qualified pathname <see cref="P:MFR.File.Hosts.FileHost.Path" />.
        /// </summary>
        public Stream Stream
            => _stream;

        /// <summary>
        /// Occurs when the value of the <see cref="P:MFR.File.Hosts.FileHost.Accessor" />
        /// property is updated.
        /// </summary>
        public event EventHandler AccessorChanged;

        /// <summary>
        /// Raised when the value of the
        /// <see cref="P:MFR.File.Hosts.FileHost.MemoryMappedData" /> property is updated.
        /// </summary>
        public event EventHandler MemoryMappedDataChanged;

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing,
        /// or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            _accessor?.Dispose();
            _mmf?.Dispose();
            _stream?.Dispose();
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.File.Hosts.FileHost.AccessorChanged" /> event.
        /// </summary>
        /// <remarks>
        /// This event is raised when the value of the
        /// <see cref="P:MFR.File.Hosts.FileHost.Accessor" /> property is updated.
        /// </remarks>
        protected virtual void OnAccessorChanged()
            => AccessorChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MFR.File.Hosts.FileHost.MemoryMappedDataChanged" />
        /// event.
        /// </summary>
        /// <remarks>
        /// This event is raised by the
        /// <see cref="P:MFR.File.Hosts.FileHost.MemoryMappedData" /> property when its
        /// value is updated.
        /// </remarks>
        protected virtual void OnMemoryMappedDataChanged()
            => MemoryMappedDataChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Updates the value of the <see cref="P:MFR.File.Hosts.FileHost.Accessor" />
        /// property.
        /// </summary>
        /// <param name="accessor">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedViewAccessor" /> that is
        /// to be made the new value of the
        /// <see cref="P:MFR.File.Hosts.FileHost.Accessor" /> property.
        /// <para />
        /// The default value of this parameter is a <see langword="null" /> reference.
        /// </param>
        /// <remarks>
        /// If the value of the <see cref="P:MFR.File.Hosts.FileHost.Accessor" />
        /// property is updated by this method, then the
        /// <see cref="E:MFR.File.Hosts.FileHost.AccessorChanged" /> event is raised.
        /// </remarks>
        protected void SetAccessor(MemoryMappedViewAccessor accessor = default)
            => Accessor = accessor;

        /// <summary>
        /// Updates the value of the
        /// <see cref="P:MFR.File.Hosts.FileHost.MemoryMappedData" /> property with the
        /// specified memory-mapped <paramref name="file" />.
        /// </summary>
        /// <param name="file">
        /// (Required.) Reference to an instance of
        /// <see cref="T:System.IO.MemoryMappedFiles.MemoryMappedFile" /> that refers to
        /// the contents of a block of memory that is mapped to a file on the file system.
        /// <para />
        /// The default value of this parameter is a <see langword="null" /> reference.
        /// </param>
        /// <remarks>
        /// If the value of the
        /// <see cref="P:MFR.File.Hosts.FileHost.MemoryMappedData" /> property is updated
        /// by this method, then the
        /// <see cref="E:MFR.File.Hosts.FileHost.MemoryMappedDataChanged" /> event is
        /// raised.
        /// </remarks>
        protected void SetMemoryMappedData(MemoryMappedFile file = default)
            => MemoryMappedData = file;
    }
}