using MFR.Expressions.Registry.Interfaces;
using MFR.Expressions.Registry.Validators.Factories;
using MFR.Expressions.Registry.Validators.Interfaces;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions;
using MFR.Messages.Actions.Interfaces;
using MFR.Messages.Constants;
using MFR.Registry.Loaders.Factories;
using MFR.Settings.Configuration.Actions.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Actions
{
    /// <summary>
    /// Accesses a key and value in the system Registry to load the pathname of
    /// the master config file.
    /// </summary>
    public class LoadConfigurationFilePathFromRegistryAction :
        CachedResultActionBase<IRegQueryExpression<string>, IFileSystemEntry>,
        ICachedResultAction<IRegQueryExpression<string>, IFileSystemEntry>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LoadConfigurationFilePathFromRegistryAction() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected LoadConfigurationFilePathFromRegistryAction() { }

        /// <summary>
        /// Gets the one and only instance of the Registry query expression validator that
        /// read <see cref="T:System.String" /> values  from the system Registry.
        /// </summary>
        private static IRegQueryExpressionValidator<string>
            AccessTheRegueryExpressionValidator
        {
            get;
        } = GetRegistryExpressionValidator<string>.SoleInstance();

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Actions.LoadConfigurationFilePathFromRegistryAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static
            ICachedResultAction<IRegQueryExpression<string>, IFileSystemEntry>
            Instance
        {
            get;
        } = new LoadConfigurationFilePathFromRegistryAction();

        /// <summary>
        /// Gets the <see cref="T:MFR.MessageType" /> that is being used
        /// to identify which message this.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => ConfigActionType.LoadConfigFilePathFromRegistry;

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
                // Run validation on the properties of the input registry query
                // expression object. This method throws exceptions if data is not valid.
                if (!AccessTheRegueryExpressionValidator
                     .ForRegQueryExpression(Input)
                     .Validate())
                    return result;

                var pathname = Load.String.FromRegistry(
                                       Input.KeyPath, Input.ValueName,
                                       Input.DefaultValue
                                   )
                                   .Replace("\"", string.Empty);

                /*
                 * All we care about is reading a fucking path from the system
                 * Registry.  We do not care, here, whether or not it exists.
                 */

                result = MakeNewFileSystemEntry.ForPath(pathname);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"LoadConfigurationFilePathFromRegistryAction.ExecuteOperationIfNotCached: Result = '{result}'"
            );

            return result;
        }
    }
}