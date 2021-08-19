using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Managers.Solutions.Actions.Constants
{
    /// <summary>
    /// Defines names for the types of actions that can be performed on
    /// <c>Visual Studio Solution Service</c> objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class VisualStudioSolutionServiceAction : ActionType
    {
        /// <summary>
        /// Loads all the *.sln files in a given folder into separate instances
        /// of Visual Studio.
        /// </summary>
        public static readonly VisualStudioSolutionServiceAction
            LoadAllSolutionsInFolder =
                new VisualStudioSolutionServiceAction(Guid.NewGuid());

        /// <summary>
        /// Unknown action.
        /// </summary>
        public static readonly VisualStudioSolutionServiceAction Unknown =
            new VisualStudioSolutionServiceAction(Guid.Empty);

        /// <summary>
        /// Unloads all the *.sln files in a given folder that also happen to be
        /// loaded in instances of Visual Studio.
        /// </summary>
        public static readonly VisualStudioSolutionServiceAction
            UnloadAllSolutionsInFolder =
                new VisualStudioSolutionServiceAction(Guid.NewGuid());

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Managers.Solutions.Actions.Constants.VisualStudioSolutionAction" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public VisualStudioSolutionServiceAction(Guid messageId) : base(
            messageId
        ) { }
    }
}