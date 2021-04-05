using MFR.Objects.Configuration.Constants;
using MFR.Objects.Matchers.Factories.Interfaces;
using MFR.Objects.Matchers.Interfaces;
using MFR.Objects.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;

namespace MFR.Objects.Matchers.Factories
{
    /// <summary>
    /// Factory object that creates string matchers, specific to the Rename
    /// Sub Folders type of operation, for the various combinations of
    /// Match Case and Match Exact Word.
    /// </summary>
    public class
        RenameSubFoldersStringMatcherFactory : IStringMatcherFactory
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RenameSubFoldersStringMatcherFactory() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RenameSubFoldersStringMatcherFactory() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Objects.Matchers.Factories.RenameSubFoldersStringMatcherFactory" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static RenameSubFoldersStringMatcherFactory Instance
        {
            get;
        } = new RenameSubFoldersStringMatcherFactory();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public OperationType OperationType
        {
            get;
        } = OperationType.RenameSubFolders;

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IStringMatcher" />
        /// interface and
        /// returns a reference to it for the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration" />
        /// value that
        /// is specified by the <paramref name="matchingConfig" /> parameter.
        /// </summary>
        /// <param name="matchingConfig">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration" />
        /// values that
        /// specifies which type of matching is being done.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IStringMatcher" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown if the value passed in the <paramref name="matchingConfig" />
        /// is not one of the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration" />
        /// values.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if a string matcher object is not defined for the Rename
        /// Files in Folder operation type that supports the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration" />
        /// value
        /// passed in the <paramref name="matchingConfig" /> parameter.
        /// </exception>
        public IStringMatcher AndTextMatchingConfiguration(
            TextMatchingConfiguration matchingConfig)
        {
            if (!Enum.IsDefined(typeof(TextMatchingConfiguration), matchingConfig))
                throw new InvalidEnumArgumentException(
                    nameof(matchingConfig), (int)matchingConfig,
                    typeof(TextMatchingConfiguration)
                );

            IStringMatcher matcher;

            switch (matchingConfig)
            {
                case TextMatchingConfiguration.MatchCaseOnly:
                    matcher = MatchCaseOnlyFolderNameStringMatcher.Instance;
                    break;

                case TextMatchingConfiguration.MatchExactWordOnly:
                    matcher = MatchExactWordOnlyFolderNameStringMatcher
                        .Instance;
                    break;

                case TextMatchingConfiguration.MatchCaseAndExactWord:
                    matcher = MatchCaseAndExactWordFolderNameStringMatcher
                        .Instance;
                    break;

                case TextMatchingConfiguration.NeitherMatchCaseNorExactWord:
                    matcher =
                        NeitherMatchCaseNorExactWordFolderNameStringMatcher
                            .Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(matchingConfig), matchingConfig,
                        $"There are no string matcher objects defined for the Rename Files in Folder operation type that support the '{matchingConfig}' matching configuration."
                    );
            }

            return matcher;
        }
    }
}