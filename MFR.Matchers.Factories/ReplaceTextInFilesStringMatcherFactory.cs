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
    /// Sub Folders type of operation, for the various combinations of
    /// Match Case and Match Exact Word.
    /// </summary>
    public class ReplaceTextInFilesStringMatcherFactory : IStringMatcherFactory
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ReplaceTextInFilesStringMatcherFactory() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ReplaceTextInFilesStringMatcherFactory() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Factories.Interfaces.IStringMatcherFactory" />
        /// interface that creates string matcher objects used in order to assist the
        /// application with replacing text in the files in a folder according to a
        /// text-replacement pattern that is specified by the user.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IStringMatcherFactory Instance
        {
            get;
        } = new ReplaceTextInFilesStringMatcherFactory();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public OperationType OperationType
            { get; } = OperationType.ReplaceTextInFiles;

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
                    matcher = MatchCaseOnlyTextInFilesStringMatcher.Instance;
                    break;

                case TextMatchingConfiguration.MatchExactWordOnly:
                    matcher = MatchExactWordOnlyTextInFilesStringMatcher
                        .Instance;
                    break;

                case TextMatchingConfiguration.MatchCaseAndExactWord:
                    matcher = MatchCaseAndExactWordTextInFilesStringMatcher
                        .Instance;
                    break;

                case TextMatchingConfiguration.NeitherMatchCaseNorExactWord:
                    matcher =
                        NeitherMatchCaseNorExactWordTextInFilesStringMatcher
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