using MFR.Expressions.Registry.Interfaces;
using MFR.Expressions.Registry.Validators.Factories;
using MFR.Expressions.Registry.Validators.Interfaces;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions;
using MFR.Messages.Actions.Interfaces;
using MFR.Messages.Constants;
using MFR.Registry.Loaders.Factories;
using MFR.Settings.Profiles.Actions.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Settings.Profiles.Actions
{
    /// <summary>
    /// Accesses a key and value in the system Registry to load the pathname of
    /// the master config file.
    /// </summary>
    public class LoadProfileCollectionFilePathFromRegistryAction :
        CachedResultActionBase<IRegQueryExpression<string>, IFileSystemEntry>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LoadProfileCollectionFilePathFromRegistryAction() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected LoadProfileCollectionFilePathFromRegistryAction() { }

        /// <summary>
        /// Accesses a Registry query expression validator object that decides whether
        /// Registry query expression objects for <c>REG_SZ</c> values are initialized
        /// properly.
        /// </summary>
        private static IRegQueryExpressionValidator<string>
            AccessRegQueryExpressionValidator
        {
            get;
        } = GetRegistryExpressionValidator<string>.SoleInstance();

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Actions.LoadProfileCollectionFilePathFromRegistryAction" />
        /// .
        /// </summary>
        public static IAction<IRegQueryExpression<string>, IFileSystemEntry> Instance
        {
            get;
        } = new LoadProfileCollectionFilePathFromRegistryAction();

        /// <summary>
        /// Gets the <see cref="T:MFR.MessageType" /> that is being used
        /// to identify which message this.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
        {
            get;
        } = ProfileCollectionActionType.LoadStringFromRegistry;

        /// <summary>
        /// Performs this action's operation if the result could not located in
        /// the result cache.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" />
        /// interface that corresponds to the result of executing the action.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// <para />
        /// This a template method, the call to which is wrapped in a robust
        /// and fault-tolerant override of the
        /// <see
        ///     cref="M:MFR.ActionBase.CommonExecute" />
        /// method.
        /// <para />
        /// The parent method override (a) validates that the _input field is
        /// not null, (b) checks for thrown exceptions, and(c) checks the result
        /// cache first to see if data corresponding to the input is there.
        /// </remarks>
        protected override IFileSystemEntry ExecuteOperationIfNotCached()
        {
            IFileSystemEntry result = default;

            try
            {
                if (Input == null) return result;

                // Run validation on the properties of the input registry query
                // expression object.  Stop if validation fails.
                if (!AccessRegQueryExpressionValidator.ForRegQueryExpression(Input)
                                                 .Validate())
                    return result;

                var loadedValue = Load.String.FromRegistry(
                    Input.KeyPath, Input.ValueName, Input.DefaultValue
                );
                if (string.IsNullOrWhiteSpace(loadedValue)) return result;

                result = MakeNewFileSystemEntry.ForPath(
                    loadedValue.RemoveTrailingBackslashes()
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}