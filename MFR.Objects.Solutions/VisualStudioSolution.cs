using EnvDTE;
using MFR.Objects.Solutions.Exceptions;
using MFR.Objects.Solutions.Interfaces;
using System;
using System.IO;
using xyLOGIX.Core.Extensions;
using File = Alphaleonis.Win32.Filesystem.File;

namespace MFR.Objects.Solutions
{
    /// <summary>
    /// Encapsulates the data and actions that are applicable to a Visual Studio
    /// Solution (*.sln) file.
    /// </summary>
    public class VisualStudioSolution : IVisualStudioSolution
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:EnvDTE.DTE" />
        /// interface.
        /// </summary>
        private readonly DTE _dte;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.Solutions.Solution" />
        /// and returns a reference to it.
        /// </summary>
        public VisualStudioSolution()
        {
            _dte = null;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.Solutions.Solution" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="dte">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:EnvDTE.DTE" /> interface.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="dte" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        public VisualStudioSolution(DTE dte)
        {
            _dte = dte ?? throw new ArgumentNullException(nameof(dte));
        }

        /// <summary>
        /// Gets a string containing the path to the folder that contains the solution.
        /// </summary>
        public string ContainingFolder
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets a value that indicates whether this solution file is currently
        /// loaded in a running instance of Visual Studio.
        /// </summary>
        public bool IsLoaded
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets a string that contains the fully-qualified pathname of the
        /// Visual Studio Solution (*.sln) file.
        /// </summary>
        public string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Forces either a currently-running instance of Visual Studio to load
        /// the solution, or opens the solution in a new instance of <c>devenv.exe</c>.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the operation completed successfully;
        /// <see
        ///     langword="false" />
        /// otherwise.
        /// </returns>
        /// <exception cref="T:MFR.Objects.Solutions.Exceptions.DteNotInitializedException">
        /// Thrown if the <see cref="F:MFR.Objects.Solutions.Solution._dte" />
        /// field has a <see langword="null" /> value.
        /// </exception>
        public bool Load()
            => throw new NotImplementedException();

        /// <summary>
        /// Forces the particular, and currently-running, instance of Visual
        /// Studio that currently has the solution open to unload (i.e., close) it.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the operation completed successfully;
        /// <see
        ///     langword="false" />
        /// otherwise.
        /// </returns>
        /// <exception cref="T:MFR.Objects.Solutions.Exceptions.DteNotInitializedException">
        /// Thrown if the <see cref="F:MFR.Objects.Solutions.Solution._dte" />
        /// field has a <see langword="null" /> value.
        /// </exception>
        public bool Unload()
            => throw new NotImplementedException();

        /// <summary>
        /// Initializes this object with a reference to an instance of an object
        /// that implements the <see cref="T:EnvDTE.DTE" /> interface.
        /// </summary>
        /// <param name="dte">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:EnvDTE.DTE" /> interface.
        /// </param>
        /// <param name="path">
        /// (Required.) Fully-qualified pathname of the solution (*.sln) file.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the contents of the <paramref name="path" /> parameter are
        /// not the fully-qualified path of a <c>*.sln</c> file.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="dte" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the contents of the <paramref name="path" /> parameter are
        /// no the fully-qualified pathname of a file that exists on the disk.
        /// </exception>
        /// <remarks>
        /// <b>NOTE:</b> Only call this method if you've used the default
        /// constructor to instantiate this object.
        /// </remarks>
        public static IVisualStudioSolution Initialize(DTE dte, string path)
        {
            if (dte == null) throw new ArgumentNullException(nameof(dte));
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            if (!path.IsAbsolutePath())
                throw new ArgumentException(
                    "Value must be a fully-qualified path.", nameof(path)
                );
            if (!path.ToLowerInvariant()
                     .EndsWith(".sln"))
                throw new ArgumentException(
                    "Value must be a fully-qualified path of a *.sln file.",
                    nameof(path)
                );
            if (!File.Exists(path))
                throw new FileNotFoundException(
                    $"The file '{path}' could not be found on the disk."
                );

            return new VisualStudioSolution(dte) {Path = path};
        }

        /// <summary>
        /// Asserts that the <see cref="F:MFR.Objects.Solutions.Solution._dte" />
        /// field has been set to a value other than <see langword="null" />.
        /// </summary>
        /// <exception cref="T:MFR.Objects.Solutions.Exceptions.DteNotInitializedException">
        /// Thrown if the <see cref="F:MFR.Objects.Solutions.Solution._dte" />
        /// field has a <see langword="null" /> value.
        /// </exception>
        /// <remarks>This method does nothing in the event that the <see cref="F:MFR.Objects.Solutions.Solution._dte"/> field has a value.</remarks>
        private void AssertDteInitialized()
        {
            if (_dte == null) throw new DteNotInitializedException();
        }
    }
}