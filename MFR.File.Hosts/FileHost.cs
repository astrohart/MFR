using MFR.File.Hosts.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;
using xyLOGIX.Core.Debug;

namespace MFR.File.Hosts
{
    /// <summary>
    /// Hosts a file during the <c>Replace Text in File</c> process.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class FileHost : IFileHost
    {
        /// <summary>
        /// Reference to an instance of <see cref="T:System.IO.Stream" /> that is a
        /// currently-open file stream.
        /// </summary>
        private Stream _stream;

        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.File.Hosts.FileHost" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file for which this object is to be initialized.
        /// </param>
        public FileHost(string path)
        {
            Path = path;
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
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Text.Encoding" /> value that describes the
        /// encoding of the file.
        /// </summary>
        public Encoding Encoding
        {
            get;
            set;
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
            get;
            private set;
        }

        /// <summary>
        /// The original length of the file
        /// <see cref="F:MFR.File.Hosts.FileHost._stream" /> as originally passed to the
        /// constructor of this class.
        /// </summary>
        public long OriginalLength
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the fully-qualified pathname
        /// of the file to which this object refers.
        /// </summary>
        public string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to an instance of <see cref="T:System.IO.Stream" /> that
        /// refers to a file stream that is currently opened to the file having the
        /// fully-qualified pathname <see cref="P:MFR.File.Hosts.FileHost.Path" />.
        /// </summary>
        public Stream Stream
        {
            get => _stream;
            set {
                var changed = value != null && !value.Equals(_stream);
                _stream = value;
                if (changed)
                    OnStreamChanged(); // calculates the length of the stream
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing,
        /// or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            try
            {
                Accessor?.Dispose();
                MemoryMappedData?.Dispose();
                Stream?.Dispose();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Called when the value of the <see cref="P:MFR.File.Hosts.FileHost.Stream" />
        /// property is updated.
        /// </summary>
        protected virtual void OnStreamChanged()
        {
            try
            {
                if (Stream == null) return;
                if (Stream.Null.Equals(Stream)) return;
                if (!Stream.CanSeek) return;

                if (!(Stream is FileStream fileStream)) return;

                OriginalLength = fileStream.Length;
                if (OriginalLength <= 0L) return;

                MemoryMappedData = MemoryMappedFile.CreateFromFile(
                    fileStream, null, OriginalLength,
                    MemoryMappedFileAccess.ReadWrite, HandleInheritability.None,
                    false
                );
                if (MemoryMappedData == null) return;

                Accessor = MemoryMappedData.CreateViewAccessor(
                    0, OriginalLength, MemoryMappedFileAccess.ReadWrite
                );

                // let the system catch up
                Thread.Sleep(50);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}