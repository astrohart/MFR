using MFR.File.Hosts.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Text;

namespace MFR.File.Hosts.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.File.Hosts.Interfaces.IFileHost" /> interface, and returns
    /// references to them.
    /// </summary>
    public static class MakeNewFileHost
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed
        /// once only for the <see cref="T:MFR.File.Hosts.Factories.MakeNewFileHost" />
        /// class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MakeNewFileHost() { }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.File.Hosts.Interfaces.IFileHost.Stream" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.File.Hosts.Interfaces.IFileHost" />
        /// interface.
        /// </param>
        /// <param name="stream">
        /// (Required.) Reference to an instance of <see cref="T:System.IO.Stream" /> that
        /// is currently open on the file having the path specified.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IFileHost AndStream(this IFileHost self, Stream stream)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Stream = stream;
            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.File.Hosts.Interfaces.IFileHost" /> interface and returns a
        /// reference to it.
        /// </summary>
        /// <param name="path">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file for which the new object is to be initialized.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Hosts.Interfaces.IFileHost" /> interface.
        /// </returns>
        public static IFileHost ForPath(string path)
            => new FileHost(path);

        /// <summary>
        /// Builder extension method that initializes the <see cref="P:MFR.File.Hosts.Interfaces.IFileHost.Encoding" /> property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.File.Hosts.Interfaces.IFileHost" />
        /// interface.
        /// </param>
        /// <param name="encoding">
        /// (Required.) A <see cref="T:System.Text.Encoding"/> value specifying the text encoding of the file.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IFileHost HavingEncoding(
            this IFileHost self,
            Encoding encoding
        )
        {
            if (self == null)
                throw new ArgumentNullException(nameof(self));

            self.Encoding = encoding;
            return self;
        }
    }
}