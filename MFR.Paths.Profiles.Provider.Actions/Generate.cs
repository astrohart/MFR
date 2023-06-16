using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using MFR.Expressions.Registry.Factories;
using MFR.Expressions.Registry.Interfaces;
using MFR.Expressions.Registry.Validators.Factories;
using MFR.Expressions.Registry.Validators.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Metadata.Registry.Validators.Factories;
using MFR.Metadata.Registry.Validators.Interfaces;
using MFR.Paths.Profiles.Provider.Constants;
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Actions.Factories;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Profiles.Provider.Actions
{
    /// <summary>
    /// Exposes static methods for generating data values.
    /// </summary>
    public static class Generate
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator
        /// 
        /// 
        /// 
        /// <T>" /> interface.
        /// </summary>
        private static IRegOperationMetadataValidator<string>
            AccessTheRegOperationMetadataValidator
        {
            get;
        } = GetRegOperationMetadataValidator<string>.SoleInstance();


        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator{T}" /> interface.
        /// </summary>
        private static IRegQueryExpressionValidator<string>
            AccessTheRegQueryExpressionValidator
        {
            get;
        } = GetRegistryExpressionValidator<string>.SoleInstance();

        /// <summary>
        /// Generates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}" />
        /// interface for the purpose of searching the system Registry for the pathname of
        /// the <c>profiles.json</c> file.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> containing the company name that
        /// is associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> containing the product name that
        /// is associated with the application.
        /// </param>
        /// <param name="defaultValue">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains a default value that is to be returned in case nothing can be
        /// successfully read from the system Registry.
        /// </param>
        /// <returns>
        /// Reference to an instance of a Registry query expression object that
        /// can be used to search the system Registry for the fully-qualified pathname of
        /// the <c>profiles.json</c> file.
        /// </returns>
        public static IRegQueryExpression<string> ProfilePathRegQueryExpression(
            string companyName,
            string productName,
            string defaultValue
        )
        {
            IRegQueryExpression<string> result = default;

            try
            {
                // Get the fully-qualified Registry key pathname of the Registry key
                // under which the path to the profiles.json file is to be stored.
                var profileFilePathRegistryKeyPathname =
                    Formulate.ProfileFilePathRegistryKeyPathname(
                        companyName, productName
                    );
                if (string.IsNullOrWhiteSpace(
                        profileFilePathRegistryKeyPathname
                    ))
                    return result;

                result = MakeNewRegQueryExpression.FromScatch<string>()
                                                  .ForKeyPath(
                                                      profileFilePathRegistryKeyPathname
                                                  )
                                                  .AndValueName(
                                                      ProfilePathRegistry
                                                          .ValueName
                                                  )
                                                  .WithDefaultValue(
                                                      /*
                                                       * This is the default fully-qualified pathname
                                                       * of the file that is to be utilized if the value
                                                       * that is supposed to be stored in the system
                                                       * Registry cannot be found.
                                                       */
                                                      defaultValue
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

        /// <summary>
        /// Creates and configures a reference to an instance of an <c>Action</c> object
        /// that, when executed, retrieves the fully-qualified pathname of the
        /// <c>profiles.json</c> file that is supposed to be stored in the system Registry.
        /// </summary>
        /// <param name="expression">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Expressions.Registry.Interfaces.IRegQueryExpression{System.String}" />
        /// interface that represents the query object to be used for searching the system
        /// Registry.
        /// <para />
        /// This query can be initialized with the
        /// <see
        ///     cref="M:MFR.Settings.Profiles.Providers.Actions.Generate.ProfilePathRegQueryExpression" />
        /// method.
        /// </param>
        /// <returns>
        /// Reference to an instance of an <c>Action</c> object that, when executed,
        /// retrieves the fully-qualified pathname of the <c>profiles.json</c> file that is
        /// supposed to be stored in the system Registry.
        /// executed,
        /// </returns>
        public static IAction<IRegQueryExpression<string>, IFileSystemEntry>
            RetrieveProfileCollectionPathnameFromRegistryAction(
                IRegQueryExpression<string> expression
            )
        {
            IAction<IRegQueryExpression<string>, IFileSystemEntry> result =
                default;

            try
            {
                if (expression == null) return result;

                /*
                 * OKAY, only use the Registry query expression object that has been
                 * passed to this method if its fields and properties contain valid
                 * settings.
                 */

                if (!AccessTheRegQueryExpressionValidator
                     .ForRegQueryExpression(expression)
                     .Validate())
                    return result;

                var action =
                    GetProfileCollectionAction
                        .For<IRegQueryExpression<string>, IFileSystemEntry>(
                            ProfileCollectionActionType.LoadStringFromRegistry
                        );
                if (action == null)
                    return result; // failed to get action object

                // initialize the action object by setting its input, before
                // returning the reference to it to the caller of this method.
                result = action.WithInput(expression);
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