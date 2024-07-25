using MFR.GUI.Models.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.GUI.Models.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface, and
    /// returns references to them.
    /// </summary>
    public static class MakeNewErrantProcessInfo
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed
        /// once only for the
        /// <see cref="T:MFR.GUI.Models.Factories.MakeNewErrantProcessInfo" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance
        /// being created or before any static members are referenced.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MakeNewErrantProcessInfo() { }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to create a new object for.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="pathname" />, is passed a blank or <see langword="null" />
        /// string for a value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file having the specified <paramref name="pathname" /> cannot be
        /// located on the file system.
        /// </exception>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IErrantProcessInfo" /> interface.
        /// </returns>
        public static IErrantProcessInfo ForFile(string pathname)
            => new ErrantProcessInfo(pathname);
    }
}