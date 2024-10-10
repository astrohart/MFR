using MFR.Operations.Constants;
using MFR.Settings.Configuration.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Engines.Replacement
{
    /// <summary>
    /// Contains rules to replace text in the pathnames of folders.
    /// </summary>
    public class
        SolutionFolderNameReplacementEngine : FolderNameReplacementEngine
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Engines.Replacement.SolutionFolderNameReplacementEngine" />
        /// and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public SolutionFolderNameReplacementEngine() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.TextReplacementEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an
        /// instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface that
        /// holds settings that are specified by the user.
        /// </param>
        /// <exception
        ///     cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="config" />, is passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public SolutionFolderNameReplacementEngine(
            IProjectFileRenamerConfig config) : base(
            config
        ) { }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
        {
            get;
        } = OperationType.RenameSolutionFolders;
    }
}