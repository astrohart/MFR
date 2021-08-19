namespace MFR.Objects.Solutions.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a Visual Studio
    /// solution.
    /// </summary>
    /// <remarks>
    /// Objects that are expected to be implementers of this interface are
    /// little more than <c>POCO</c> s.
    /// </remarks>
    public interface IVisualStudioSolution
    {
        /// <summary>
        /// Gets a string containing the path to the folder that contains the solution.
        /// </summary>
        string ContainingFolder
        {
            get;
        }

        /// <summary>
        /// Gets a value that indicates whether this solution file is currently
        /// loaded in a running instance of Visual Studio.
        /// </summary>
        bool IsLoaded
        {
            get;
        }

        /// <summary>
        /// Gets a string that contains the fully-qualified pathname of the
        /// Visual Studio Solution (*.sln) file.
        /// </summary>
        string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that specifies whether the solution should be
        /// closed and then reopened during an operation. <see langword="true" />
        /// by default.
        /// </summary>
        bool ShouldReopen
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
        bool Load();

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
        bool Unload();
    }
}