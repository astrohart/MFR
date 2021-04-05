using MFR.Objects.Configuration.Constants;
using MFR.Objects.Operations.Constants;
using MFR.Objects.Replacers.Factories.Interfaces;
using MFR.Objects.Replacers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;

namespace MFR.Objects.Replacers.Factories
{
    /// <summary>
    /// Factory object that creates string replacers, specific to the Rename
    /// Files in Folder type of operation, for the various combinations of
    /// Match Case and Match Exact Word.
    /// </summary>
    public class
        RenameFilesInFolderStringReplacerFactory : IStringReplacerFactory
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RenameFilesInFolderStringReplacerFactory() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RenameFilesInFolderStringReplacerFactory() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Objects.Replacers.Factories.RenameFilesInFolderStringReplacerFactory" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static RenameFilesInFolderStringReplacerFactory Instance
        {
            get;
        } = new RenameFilesInFolderStringReplacerFactory();

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
        } = OperationType.RenameFilesInFolder;

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IStringReplacer" />
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
        ///     cref="T:MFR.Objects.IStringReplacer" />
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
        /// Thrown if a string replacer object is not defined for the Rename
        /// Files in Folder operation type that supports the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration" />
        /// value
        /// passed in the <paramref name="matchingConfig" /> parameter.
        /// </exception>
        public IStringReplacer AndTextMatchingConfiguration(
            TextMatchingConfiguration matchingConfig)
        {
            if (!Enum.IsDefined(typeof(TextMatchingConfiguration), matchingConfig))
                throw new InvalidEnumArgumentException(
                    nameof(matchingConfig), (int)matchingConfig,
                    typeof(TextMatchingConfiguration)
                );

            IStringReplacer replacer;

            switch (matchingConfig)
            {
                case TextMatchingConfiguration.MatchCaseOnly:
                    replacer = MatchCaseOnlyFileNameStringReplacer.Instance;
                    break;

                case TextMatchingConfiguration.MatchExactWordOnly:
                    replacer = MatchExactWordOnlyFileNameStringReplacer
                        .Instance;
                    break;

                case TextMatchingConfiguration.MatchCaseAndExactWord:
                    replacer = MatchCaseAndExactWordFileNameStringReplacer
                        .Instance;
                    break;

                case TextMatchingConfiguration.NeitherMatchCaseNorExactWord:
                    replacer =
                        NeitherMatchCaseNorExactWordFileNameStringReplacer
                        .Instance;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(matchingConfig), matchingConfig,
                        $"There are no string replacer objects defined for the Rename Files in Folder operation type that support the '{matchingConfig}' matching configuration."
                    );
            }

            return replacer;
        }
    }
}