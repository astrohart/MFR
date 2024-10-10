using MFR.Messages.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Services.Solutions.Actions.Constants
{
    /// <summary>
    /// Defines names for the types of actions that can be performed on
    /// <c>Visual Studio Solution Service</c> objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class VisualStudioSolutionServiceActionType : ActionType
    {
        /// <summary>
        /// Loads all the <c>*.sln</c> files in a given folder into separate instances
        /// of Visual Studio.
        /// </summary>
        public static readonly VisualStudioSolutionServiceActionType
            LoadAllSolutionsInFolder =
                new VisualStudioSolutionServiceActionType(
                    Guid.NewGuid(), nameof(LoadAllSolutionsInFolder)
                );

        /// <summary>
        /// Unknown action.
        /// </summary>
        public static readonly VisualStudioSolutionServiceActionType Unknown =
            new VisualStudioSolutionServiceActionType(
                Guid.Empty, nameof(Unknown)
            );

        /// <summary>
        /// Unloads all the <c>*.sln</c> files in a given folder that also happen to be
        /// loaded in instances of Visual Studio.
        /// </summary>
        public static readonly VisualStudioSolutionServiceActionType
            UnloadAllSolutionsInFolder =
                new VisualStudioSolutionServiceActionType(
                    Guid.NewGuid(), nameof(UnloadAllSolutionsInFolder)
                );

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Services.Solutions.Actions.Constants.VisualStudioSolutionAction" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public VisualStudioSolutionServiceActionType(Guid messageId) : base(
            messageId
        ) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Services.Solutions.Actions.Constants.VisualStudioSolutionServiceActionType" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="description">
        /// (Required.) A <see cref="T:System.String" /> containing a user-friendly
        /// descriptive name for this message type.
        /// </param>
        /// <param name="messageId">
        /// (Required.) Reference to an instance of <see cref="T:System.Guid" />
        /// that provides a unique identifier to be associated with this instance.
        /// </param>
        public VisualStudioSolutionServiceActionType(Guid messageId,
            string description) : base(messageId, description) { }
    }
}