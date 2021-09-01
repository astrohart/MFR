using MFR.Expressions.Registry.Interfaces;
using MFR.Expressions.Registry.Validators.Factories;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions;
using MFR.Messages.Constants;
using MFR.System;
using MFR.Settings.Profiles.Actions.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Settings.Profiles.Actions
{
    /// <summary>
    /// Accesses a key and value in the system Registry to load the pathname of
    /// the master configuration file.
    /// </summary>
    public class LoadProfileListFilePathFromRegistryAction : CachedResultActionBase<
        IRegQueryExpression<string>, IFileSystemEntry>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LoadProfileListFilePathFromRegistryAction()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected LoadProfileListFilePathFromRegistryAction()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see
        /// cref="T:MFR.Settings.Profiles.Actions.LoadProfileListFilePathFromRegistryAction"/> .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static LoadProfileListFilePathFromRegistryAction Instance
        {
            get;
        } = new LoadProfileListFilePathFromRegistryAction();

        /// <summary>
        /// Gets the <see cref="T:MFR.MessageType"/> that is being used
        /// to identify which message this is.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => ProfileListAction.LoadStringFromRegistry;

        /// <summary>
        /// Performs this action's operation if the result could not located in
        /// the result cache.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the <see
        /// cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry"/>
        /// interface that corresponds to the result of executing the action.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// <para/>
        /// This is a template method, the call to which is wrapped in a robust
        /// and fault-tolerant override of the <see
        /// cref="M:MFR.ActionBase.CommonExecute"/> method.
        /// <para/>
        /// The parent method override (a) validates that the _input field is
        /// not null, (b) checks for thrown exceptions, and(c) checks the result
        /// cache first to see if data corresponding to the input is there.
        /// </remarks>
        protected override IFileSystemEntry ExecuteOperationIfNotCached()
        {
            // Run validation on the properties of the input registry query
            // expression object. This method throws exceptions if data is not valid.
            GetRegistryExpressionValidator<string>.Instance()
                                                  .ForRegQueryExpression(Input)
                                                  .Validate();

            return MakeNewFileSystemEntry.ForPath(
                SystemPreparer.GetRegistryString(
                                  Input.KeyPath, Input.ValueName,
                                  Input.DefaultValue
                              )
                              .Replace("\"", string.Empty)
            );
        }
    }
}