using MFR.Matchers.Factories.Interfaces;
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
    /// Files in Folder type of operation, for the various combinations of Match
    /// Case and Match Exact Word.
    /// </summary>
    public class RenameFilesInFolderStringMatcherFactory : IStringMatcherFactory
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RenameFilesInFolderStringMatcherFactory() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RenameFilesInFolderStringMatcherFactory() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
        /// interface that creates string matcher objects to be used in order to assist the
        /// application with renaming files in a folder that match a specific
        /// text-replacement pattern.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IStringMatcherFactory Instance
        {
            get;
        } = new RenameFilesInFolderStringMatcherFactory();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public OperationType OperationType
            { get; } = OperationType.RenameFilesInFolder;

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IStringMatcher" />
        /// interface and
        /// returns a reference to it for the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// value
        /// that is specified by the <paramref name="matchingConfig" /> parameter.
        /// </summary>
        /// <param name="matchingConfig">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values
        /// that specifies which type of matching is being done.
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
                    matcher = MatchCaseOnlyFileNameStringMatcher.Instance;
                    break;

                case TextMatchingConfiguration.MatchExactWordOnly:
                    matcher = MatchExactWordOnlyFileNameStringMatcher.Instance;
                    break;

                case TextMatchingConfiguration.MatchCaseAndExactWord:
                    matcher = MatchCaseAndExactWordFileNameStringMatcher
                        .Instance;
                    break;

                case TextMatchingConfiguration.NeitherMatchCaseNorExactWord:
                    matcher = NeitherMatchCaseNorExactWordFileNameStringMatcher
                        .Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(matchingConfig), matchingConfig,
                        $"There are no string matcher objects defined for the Rename Files in Folder operation type that support the '{matchingConfig}' matching config."
                    );
            }

            return matcher;
        }
    }
}