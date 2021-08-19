using EnvDTE;
using MFR.Solutions.Interfaces;
using System;
using System.IO;
using xyLOGIX.Core.Extensions;
using File = Alphaleonis.Win32.Filesystem.File;

namespace MFR.Solutions.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Solutions.Interfaces.IVisualStudioSolution" />
    /// interface, and returns references to them.
    /// </summary>
    public static class GetNewVisualStudioSolutionObject
    {
        /// <summary>
        /// Builder method that initializes the
        /// <see
        ///     cref="P:MFR.Solutions.Interfaces.IVisualStudioSolution.Path" />
        /// property with the value provided in the <paramref name="path" /> parameter.
        /// </summary>
        /// <param name="solution">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </param>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of a
        /// Visual Studio Solution (*.sln) file.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="path" />, is passed
        /// a blank or <see langword="null" /> string for a value, or if the
        /// <paramref name="path" /> parameter does not contain the
        /// fully-qualified pathname of a Visual Studio Solution (*.sln) file.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="solution" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the string passed to the <paramref name="path" /> parameter
        /// is not equal to the fully-qualified pathname of a file that exists
        /// on the disk.
        /// </exception>
        public static IVisualStudioSolution AndPath(
            this IVisualStudioSolution solution, string path)
        {
            if (solution == null)
                throw new ArgumentNullException(nameof(solution));
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

            solution.Path = path;
            return solution;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface and returns a reference to it, initialized with the
        /// reference to an instance of an object that implements the
        /// <see
        ///     cref="T:EnvDTE.DTE" />
        /// interface provided in the
        /// <paramref
        ///     name="dte" />
        /// parameter.
        /// </summary>
        /// <param name="dte">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:EnvDTE.DTE" /> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="dte" />, is passed
        /// a <see langword="null" /> value.
        /// </exception>
        public static IVisualStudioSolution ForVisualStudioInstance(DTE dte)
        {
            if (dte == null) throw new ArgumentNullException(nameof(dte));
            return new VisualStudioSolution(dte);
        }
    }
}