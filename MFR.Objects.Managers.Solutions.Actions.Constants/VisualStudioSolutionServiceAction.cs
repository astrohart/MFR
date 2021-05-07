using MFR.Objects.Messages.Constants;
using System;

namespace MFR.Objects.Managers.Solutions.Actions.Constants
{
    /// <summary>
    /// Defines names for the types of actions that can be performed on
    /// <c>Visual Studio Solution Service</c> objects.
    /// </summary>
    public class VisualStudioSolutionServiceAction : ActionType
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.Managers.Solutions.Actions.Constants.VisualStudioSolutionAction" />
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