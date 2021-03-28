using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Matches strings only for the case where Match Case is set to
    /// <see
    ///     langword="true" />
    /// but Match Exact Word is set to
    /// <see
    ///     langword="false" />
    /// , for the case when a Rename Files in Folder operation
    /// is being performed.
    /// </summary>
    public class
        MatchCaseOnlyFileNameStringMatcher :
            RenameFilesInFolderStringMatcherBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchCaseOnlyFileNameStringMatcher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchCaseOnlyFileNameStringMatcher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MassFileRenamer.Objects.MatchCaseOnlyFileNameStringMatcher" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchCaseOnlyFileNameStringMatcher Instance
        {
            get;
        } = new MatchCaseOnlyFileNameStringMatcher();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration" />
        /// values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public override TextMatchingConfiguration TextMatchingConfiguration
        {
            get;
        } = TextMatchingConfiguration.MatchCaseOnly;

        /// <summary>
        /// Determines whether a <paramref name="value" /> string is a match
        /// against a <paramref name="findWhat" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="findWhat">
        /// (Optional.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the data that all instances of
        /// <paramref name="findWhat" /> in <paramref name="value" /> are to be
        /// replaced with.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// or <paramref name="findWhat" />, are passed blank or
        /// <see langword="null" /> string for values.
        /// </exception>
        /// <returns>
        /// Returns <see langword="true" /> if the <paramref name="value" /> is a
        /// match against the provided <paramref name="findWhat" />;
        /// <see
        ///     langword="false" />
        /// if no matches are found.
        /// </returns>
        public override bool IsMatch(string value, string findWhat,
            string replaceWith = "")
            => throw new NotImplementedException();
    }

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
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.RenameFilesInFolderStringMatcherFactory" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static RenameFilesInFolderStringMatcherFactory Instance
        {
            get;
        } = new RenameFilesInFolderStringMatcherFactory();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public OperationType OperationType
        {
            get;
        } = OperationType.RenameFilesInFolder;

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IStringMatcher" />
        /// interface and
        /// returns a reference to it for the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration" />
        /// value
        /// that is specified by the <paramref name="matchingConfig" /> parameter.
        /// </summary>
        /// <param name="matchingConfig">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration" />
        /// values
        /// that specifies which type of matching is being done.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IStringMatcher" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown if the value passed in the <paramref name="matchingConfig" />
        /// is not one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration" />
        /// values.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if a string matcher object is not defined for the Rename
        /// Files in Folder operation type that supports the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration" />
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
                        $"There are no string matcher objects defined for the Rename Files in Folder operation type that support the '{matchingConfig}' matching configuration."
                    );
            }

            return matcher;
        }
    }
}