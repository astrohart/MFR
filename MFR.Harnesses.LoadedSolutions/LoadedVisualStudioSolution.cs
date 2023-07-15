using MFR.Harnesses.LoadedSolutions.Interfaces;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Harnesses.LoadedSolutions
{
    public class LoadedSolutionHarness : ILoadedSolutionHarness
    {
        /// <summary>
        /// Gets or sets a value that indicates whether the Visual Studio Solution (
        /// <c>*.sln</c>) file managed by the target instance of Visual Studio is in the
        /// directory tree of the current Project File Renamer operation or not.
        /// </summary>
        /// <remarks>
        /// This is important because it may very well be the case that there may be
        /// running instances of Visual Studio lying about, that have Visual Studio
        /// Solution (<c>*.sln</c>) file(s) loaded, and these particular files are not
        /// underneath the starting folder selected by the user in the Project File
        /// Renamer.
        /// </remarks>
        public bool IsInRootDirectoryTree
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// Such an object is utilized to automate the instance of Visual Studio that
        /// controls the particular Visual Studio Solution (<c>*.sln</c>) file.
        /// </remarks>
        public IVisualStudioSolution SolutionObject
        {
            get;
            set;
        }
    }
}