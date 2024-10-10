using MFR.Expressions.Registry.Factories;
using MFR.Expressions.Registry.Interfaces;
using MFR.Expressions.Registry.Validators.Factories;
using MFR.Expressions.Registry.Validators.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Messages.Commands.Interfaces;
using MFR.Metadata.Registry.Factories;
using MFR.Metadata.Registry.Interfaces;
using MFR.Metadata.Registry.Validators.Factories;
using MFR.Metadata.Registry.Validators.Interfaces;
using MFR.Paths.Profiles.Provider.Constants;
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Actions.Factories;
using MFR.Settings.Profiles.Commands.Constants;
using MFR.Settings.Profiles.Commands.Factories;
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
        ///     cref="T:MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator{T}" />
        /// interface that represents an object that validates the metadata used for
        /// performing Registry operations.
        /// </summary>
        private static IRegOperationMetadataValidator<string>
            AccessTheRegOperationMetadataValidator
        {
            get;
        } = GetRegOperationMetadataValidator<string>.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator{T}" />
        /// interface.
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
                                                       * This the default fully-qualified pathname
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
        /// Generates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}" />
        /// interface that is to be used for storing the specified
        /// <paramref name="pathnameToSave" /> under the specified
        /// <paramref name="regKeyPathname" />.
        /// </summary>
        /// <param name="pathnameToSave">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file that is to be saved on the hard disk.
        /// </param>
        /// <param name="regKeyPathname">
        /// (Required.) A fully-qualified Registry key
        /// pathname under which the fully-qualified pathname of the <c>profiles.json</c>
        /// file indicated by the <paramref name="pathnameToSave" /> parameter is to be
        /// stored.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{System.String}" />
        /// interface that can be used for saving the specified
        /// <paramref name="pathnameToSave" /> to the Registry key having the specified
        /// <paramref name="regKeyPathname" />.
        /// </returns>
        /// <remarks>
        /// The file indicated in the <paramref name="pathnameToSave" /> parameter must
        /// have the filename <c>profiles.json</c> in order to be saved to the system
        /// Registry.
        /// <para />
        /// Moreover, the <paramref name="regKeyPathname" /> parameter must not have a
        /// blank argument.
        /// <para />
        /// If either of these conditions aren't met, then this method returns a
        /// <see langword="null" /> reference.
        /// </remarks>
        public static IRegOperationMetadata<string>
            RegOperationMetadataForSavingProfileCollectionPath(
                string regKeyPathname,
                string pathnameToSave
            )
        {
            IRegOperationMetadata<string> result = default;

            try
            {
                result = MakeNewRegOperationMetadata.FromScatch<string>()
                                                    .ForKeyPath(regKeyPathname)
                                                    .AndValueName(
                                                        ProfilePathRegistry
                                                            .ValueName
                                                    )
                                                    .WithValue(pathnameToSave);
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

        /// <summary>
        /// Generates a new <c>Command</c> object (an object that sends an application
        /// message that has an input value but no output) for saving the pathname of the
        /// file containing the user's saved configuration-setting profiles to the system
        /// Registry.
        /// </summary>
        /// <param name="metadata">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Metadata.Registry.Interfaces.IRegOperationMetadata{T}" />
        /// interface.
        /// <para />
        /// This object specifies the information that tells the code under which Registry
        /// key and value should the pathname be written.
        /// </param>
        /// <returns>
        /// A new <c>Command</c> object (an object that sends an application
        /// message that has an input value but no output) for saving the pathname of the
        /// file containing the user's saved configuration-setting profiles to the system
        /// Registry.
        /// </returns>
        public static ICommand<IRegOperationMetadata<string>>
            SaveProfilePathToRegistryCommand(
                IRegOperationMetadata<string> metadata
            )
        {
            ICommand<IRegOperationMetadata<string>> result = default;

            try
            {
                if (metadata == null) return result;

                /*
                 * OKAY, only use the Registry operation metadata object that has been
                 * passed to this method if its fields and properties contain valid
                 * settings.
                 */

                if (!AccessTheRegOperationMetadataValidator
                     .ForRegOperationMetadata(metadata)
                     .Validate())
                    return result;

                result =
                    GetProfileCollectionCommand
                        .For<IRegOperationMetadata<string>>(
                            ProfileCollectionCommandType
                                .SaveProfileCollectionPathToRegistry
                        );
                if (result == null)
                    return result; // failed to get command object

                // initialize the command object by setting its input, before
                // returning the reference to it to the caller of this method.
                result = result.WithInput(metadata);
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