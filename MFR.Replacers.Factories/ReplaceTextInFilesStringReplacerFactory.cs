using MFR.Operations.Constants;
using MFR.Replacers.Factories.Interfaces;
using MFR.Replacers.Interfaces;
using MFR.Settings.Configuration.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;

namespace MFR.Replacers.Factories
{
    /// <summary>
    /// Factory object that creates string replacers, specific to the Replace
    /// Text in Files type of operation, for the various combinations of Match
    /// Case and Match Exact Word.
    /// </summary>
    public class
        ReplaceTextInFilesStringReplacerFactory : IStringReplacerFactory
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ReplaceTextInFilesStringReplacerFactory() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ReplaceTextInFilesStringReplacerFactory() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Replacers.Factories.Interfaces.IStringReplacerFactory" />
        /// interface that creates objects which are responsible for replacing text in the
        /// contents of files within a specific directory tree based on a text-replacement
        /// pattern specified by the user.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IStringReplacerFactory Instance
        {
            get;
        } = new ReplaceTextInFilesStringReplacerFactory();

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
        ///     cref="T:MFR.IStringReplacer" />
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
        ///     cref="T:MFR.IStringReplacer" />
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
        /// Thrown if a string replacer object is not defined for the Replace
        /// Text in Files operation type that supports the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// value
        /// passed in the <paramref name="matchingConfig" /> parameter.
        /// </exception>
        public IStringReplacer AndTextMatchingConfiguration(
            TextMatchingConfiguration matchingConfig)
        {
            if (!Enum.IsDefined(
                    typeof(TextMatchingConfiguration), matchingConfig
                ))
                throw new InvalidEnumArgumentException(
                    nameof(matchingConfig), (int)matchingConfig,
                    typeof(TextMatchingConfiguration)
                );

            IStringReplacer replacer;

            switch (matchingConfig)
            {
                case TextMatchingConfiguration.MatchCaseOnly:
                    replacer = MatchCaseOnlyTextInFilesStringReplacer.Instance;
                    break;

                case TextMatchingConfiguration.MatchExactWordOnly:
                    replacer = MatchExactWordOnlyTextInFilesStringReplacer
                        .Instance;
                    break;

                case TextMatchingConfiguration.MatchCaseAndExactWord:
                    replacer = MatchCaseAndExactWordTextInFilesStringReplacer
                        .Instance;
                    break;

                case TextMatchingConfiguration.NeitherMatchCaseNorExactWord:
                    replacer =
                        NeitherMatchCaseNorExactWordTextInFilesStringReplacer
                            .Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(matchingConfig), matchingConfig,
                        $"There are no string replacer objects defined for the Replace Text in Files operation type that support the '{matchingConfig}' matching config."
                    );
            }

            return replacer;
        }
    }
}