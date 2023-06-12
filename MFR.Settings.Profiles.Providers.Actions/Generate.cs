using Alphaleonis.Win32.Filesystem;
using MFR.Expressions.Registry.Factories;
using MFR.Expressions.Registry.Interfaces;
using MFR.Expressions.Registry.Validators.Factories;
using MFR.Expressions.Registry.Validators.Interfaces;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Actions.Factories;
using MFR.Settings.Profiles.Providers.Constants;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
    /// <summary>
    /// Exposes static methods for generating data values.
    /// </summary>
    public static class Generate
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator
        /// 
        /// 
        /// 
        /// 
        /// 
        /// <T>" /> interface.
        /// </summary>
        private static IRegQueryExpressionValidator<string>
            AccessTheRegQueryExpressionValidator
        {
            get;
        } = GetRegistryExpressionValidator<string>.SoleInstance();

        /// <summary>
        /// Attempts to formulate a default value for the <c>profiles.json</c> file that
        /// contains the user's previously-saved configuration profiles.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <param name="currentPathname">
        /// (Optional.) A <see cref="T:System.String" /> that
        /// serves as a default return value for this method in case a failure mode is
        /// otherwise hit (blank input, missing file, missing Registry value, etc.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> that contains the
        /// default fully-qualified pathname of the <c>profiles.json</c> value that should
        /// be used as a fallback in the event that a <c>profiles.json</c> file cannot be
        /// located either on the disk or in the system Registry.
        /// </returns>
        /// <remarks>
        /// Configuration profiles let the user save a set of their previously-used
        /// settings to easily recall for later use.
        /// <para />
        /// If an error occurred, or if required information is missing, during the
        /// operation, then this method returns the <see cref="F:System.String.Empty" />
        /// value.
        /// </remarks>
        public static string DefaultProfileCollectionPathname(
            string companyName,
            string productName,
            string currentPathname = ""
        )
        {
            var result = currentPathname;

            try
            {
                if (string.IsNullOrWhiteSpace(companyName)) return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;

                var localAppDataFolderPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                );
                if (string.IsNullOrWhiteSpace(localAppDataFolderPath))
                    return result;

                var companyProgramDataFolderPath = Path.Combine(
                    localAppDataFolderPath, companyName
                );
                if (string.IsNullOrWhiteSpace(companyProgramDataFolderPath))
                    return result;

                var profileCollectionFileFolder = Path.Combine(
                    companyProgramDataFolderPath, $@"{productName}\Config"
                );
                if (string.IsNullOrWhiteSpace(profileCollectionFileFolder))
                    return result;

                result = Path.Combine(
                    profileCollectionFileFolder, ProfileFile.DefaultFilename
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

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