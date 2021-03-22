using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Factory object that creates string replacers, specific to the Replace
    /// Text in Files type of operation, for the various combinations of Match
    /// Case and Match Whole Word.
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
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ReplaceTextInFilesStringReplacerFactory" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static ReplaceTextInFilesStringReplacerFactory Instance
        {
            get;
        } = new ReplaceTextInFilesStringReplacerFactory();

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
        } = OperationType.ReplaceTextInFiles;

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IStringReplacer" />
        /// interface and
        /// returns a reference to it for the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration" />
        /// value that
        /// is specified by the <paramref name="matchingConfig" /> parameter.
        /// </summary>
        /// <param name="matchingConfig">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration" />
        /// values that
        /// specifies which type of matching is being done.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IStringReplacer" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// Thrown if the value passed in the <paramref name="matchingConfig" />
        /// is not one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration" />
        /// values.
        /// </exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if a string replacer object is not defined for the Replace
        /// Text in Files operation type that supports the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration" />
        /// value
        /// passed in the <paramref name="matchingConfig" /> parameter.
        /// </exception>
        public IStringReplacer AndMatchingConfiguration(
            MatchingConfiguration matchingConfig)
        {
            if (!Enum.IsDefined(typeof(MatchingConfiguration), matchingConfig))
                throw new InvalidEnumArgumentException(
                    nameof(matchingConfig), (int)matchingConfig,
                    typeof(MatchingConfiguration)
                );

            IStringReplacer replacer;

            switch (matchingConfig)
            {
                case MatchingConfiguration.MatchCaseOnly:
                    replacer = MatchCaseOnlyTextInFilesStringReplacer.Instance;
                    break;

                case MatchingConfiguration.MatchWholeWordOnly:
                    replacer = MatchWholeWordOnlyTextInFilesStringReplacer
                        .Instance;
                    break;

                case MatchingConfiguration.MatchCaseAndWholeWord:
                    replacer = MatchCaseAndWholeWordTextInFilesStringReplacer
                        .Instance;
                    break;

                case MatchingConfiguration.NeitherMatchCaseNorWholeWord:
                    replacer =
                        NeitherMatchCaseNorWholeWordTextInFilesStringReplacer
                            .Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(matchingConfig), matchingConfig,
                        $"There are no string replacer objects defined for the Replace Text in Files operation type that support the '{matchingConfig}' matching configuration."
                    );
            }

            return replacer;
        }
    }
}