using MFR.Messages.Constants;
using System;

namespace MFR.Renamers.Folders.Actions.Constants
{
    /// <summary>
    /// Available actions for use when renaming folders.
    /// </summary>
    public class FolderRenameActionType : ActionType
    {
        /// <summary>
        /// Creates a new, named profile that can be added to the list.
        /// </summary>
        public static readonly FolderRenameActionType RenameSolutionFolder =
            new FolderRenameActionType(
                Guid.NewGuid(), nameof(RenameSolutionFolder)
            );

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Renamers.Folders.Actions.Constants.FolderRenameActionType" />
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
        public FolderRenameActionType(Guid messageId, string description) :
            base(messageId, description) { }
    }
}