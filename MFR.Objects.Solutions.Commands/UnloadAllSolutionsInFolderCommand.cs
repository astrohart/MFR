using Alphaleonis.Win32.Filesystem;
using MFR.Objects.Managers.Solutions.Factories;
using MFR.Objects.Messages.Commands;
using MFR.Objects.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System.Linq;

namespace MFR.Objects.Solutions.Commands
{
    /// <summary>
    /// Command object that carries out the action of unloading all opened
    /// Visual Studio solutions that are in a given folder.
    /// </summary>
    public class UnloadAllSolutionsInFolderCommand : CommandBase<string>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static UnloadAllSolutionsInFolderCommand() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected UnloadAllSolutionsInFolderCommand() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Objects.Solutions.Commands.UnloadAllSolutionsInFolderCommand" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static UnloadAllSolutionsInFolderCommand Instance
        {
            get;
        } = new UnloadAllSolutionsInFolderCommand();

        /// <summary>
        /// Gets the <see cref="T:MFR.Objects.MessageType" /> that is being used
        /// to identify which message this is.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => MessageType.UnloadAllSolutionsInFolder;

        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        /// <remarks>
        /// Implementers must override this method in order to return this
        /// object's functionality.
        /// </remarks>
        protected override void CommonExecute()
        {
            if (string.IsNullOrWhiteSpace(Input) ||
                !Directory.Exists(Input)) return;

            var openSolutions = GetVisualStudioSolutionService.SoleInstance()
                .GetLoadedSolutionsInFolder(Input);
            if (openSolutions == null || !openSolutions.Any())
                return;

            GetVisualStudioSolutionService.SoleInstance()
                                          .UnloadAll(openSolutions);
        }
    }
}