﻿using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Replaces strings only for the case where neither Match Case nor Match
    /// Whole Word is set to <see langword="true" />, for the Rename Files in
    /// Folder operation type.
    /// </summary>
    public class
        NeitherMatchCaseNorWholeWordFileNameStringReplacer :
            RenameFilesInFolderStringReplacerBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static NeitherMatchCaseNorWholeWordFileNameStringReplacer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected NeitherMatchCaseNorWholeWordFileNameStringReplacer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.NeitherMatchCaseNorWholeWordFileNameStringReplacer" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static NeitherMatchCaseNorWholeWordFileNameStringReplacer
            Instance
        {
            get;
        } = new NeitherMatchCaseNorWholeWordFileNameStringReplacer();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MatchingConfiguration MatchingConfiguration
        {
            get;
        } = MatchingConfiguration.NeitherMatchCaseNorWholeWord;

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="expression" />. Returns a string
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the data upon which the replacement
        /// operation is to be carried out.
        /// </param>
        /// <param name="pattern">
        /// (Required.) String containing the pattern that allows us to match
        /// the data to be replaced.
        /// </param>
        /// <param name="dest">
        /// (Required.) String containing the new data that should be
        /// substituted for the replaced text.
        /// </param>
        /// <returns>
        /// String containing the new data.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="source" />
        /// , <paramref name="pattern" />, or
        /// <paramref
        ///     name="dest" />
        /// , are passed blank or <see langword="null" /> string
        /// for values.
        /// </exception>
        public override string Replace(string source, string pattern,
            string dest = "")
        {
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(source)
                );
            if (string.IsNullOrWhiteSpace(pattern))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(pattern)
                );

            /*
             * Normally, the 'dest' parameter is optional for this method.
             * However, in the case of replacing text in the names of files,
             * it's mandatory.  This is because, if 'dest' is blank or the
             * empty string, we run the risk of trying to create a file that
             * has no name, which is in violation of OS rules.  Therefore,
             * we enforce that the dest parameter should have a value.
             */

            if (string.IsNullOrWhiteSpace(dest))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(dest)
                );

            string result;

            try
            {
                result = source.ToLowerInvariant()
                               .Replace(pattern.ToLowerInvariant(), dest);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                // If an exception by some chance is thrown by the try block,
                // then this method will just return the empty string.
                result = string.Empty;
            }

            return result;
        }
    }
}