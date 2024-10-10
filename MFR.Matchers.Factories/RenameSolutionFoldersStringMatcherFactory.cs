using MFR.GUI.Models.Converters;
using MFR.Matchers.Factories.Interfaces;
using MFR.Matchers.Factories.Properties;
using MFR.Matchers.Interfaces;
using MFR.Operations.Constants;
using MFR.Settings.Configuration.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;

namespace MFR.Matchers.Factories
{
    /// <summary>
    /// Factory object that creates string matchers, specific to the Rename
    /// Sub Folders type of operation, for the various combinations of
    /// Match Case and Match Exact Word.
    /// </summary>
    public class
        RenameSolutionFoldersStringMatcherFactory : IStringMatcherFactory
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RenameSolutionFoldersStringMatcherFactory() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RenameSolutionFoldersStringMatcherFactory() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
        /// interface that creates string matcher objects used in order to assist the
        /// application with carrying out the operation of renaming folders containing
        /// Visual Studio Solution (<c>*.sln</c>) file(s)  in a directory tree according to
        /// a text-replacement pattern that is specified by the user.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IStringMatcherFactory Instance
        {
            get;
        } = new RenameSolutionFoldersStringMatcherFactory();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public OperationType OperationType
        {
            get;
        } = OperationType.RenameSolutionFolders;

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringMatcher" />
        /// interface and
        /// returns a reference to it for the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// value that
        /// is specified by the <paramref name="matchingConfig" /> parameter.
        /// </summary>
        /// <param name="matchingConfig">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values that
        /// specifies which type of matching is being done.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringMatcher" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown if the value passed in the <paramref name="matchingConfig" />
        /// is not one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if a string matcher object is not defined for the Rename
        /// Files in Folder operation type that supports the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// value
        /// passed in the <paramref name="matchingConfig" /> parameter.
        /// </exception>
        public IStringMatcher AndTextMatchingConfiguration(
            TextMatchingConfiguration matchingConfig)
        {
            if (!Enum.IsDefined(
                    typeof(TextMatchingConfiguration), matchingConfig
                ))
                throw new InvalidEnumArgumentException(
                    nameof(matchingConfig), (int)matchingConfig,
                    typeof(TextMatchingConfiguration)
                );

            IStringMatcher matcher;

            switch (matchingConfig)
            {
                case TextMatchingConfiguration.MatchCaseOnly:
                    matcher = GetMatchCaseOnlyFolderNameStringMatcher
                        .SoleInstance();
                    break;

                case TextMatchingConfiguration.MatchExactWordOnly:
                    matcher = GetMatchExactWordOnlyFolderNameStringMatcher
                        .SoleInstance();
                    break;

                case TextMatchingConfiguration.MatchCaseAndExactWord:
                    matcher = GetMatchCaseAndExactWordFolderNameStringMatcher
                        .SoleInstance();
                    break;

                case TextMatchingConfiguration.NeitherMatchCaseNorExactWord:
                    matcher =
                        GetNeitherMatchCaseNorExactWordFolderNameStringMatcher
                            .SoleInstance();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(matchingConfig), matchingConfig,
                        string.Format(
                            Resources.Error_NoStringMatcherDefinedForOperation,
                            ConvertOperationType.ToString(OperationType),
                            matchingConfig
                        )
                    );
            }

            return matcher;
        }
    }
}