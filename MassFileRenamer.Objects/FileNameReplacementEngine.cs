﻿using System;
using System.Text.RegularExpressions;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Replaces text in file names.
    /// </summary>
    public class FileNameReplacementEngine : TextReplacementEngineBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FileNameReplacementEngine" />
        /// and
        /// returns a reference to it.
        /// </summary>
        public FileNameReplacementEngine()
        {
            // TODO: Add default object initialization here
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextReplacementEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// (Required.) Reference to an
        /// instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// interface that
        /// holds settings that are specified by the user.
        /// </param>
        /// <exception
        ///     cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="configuration" />, is passed a
        /// <c>null</c> value.
        /// </exception>
        public FileNameReplacementEngine(IConfiguration configuration) : base(
            configuration
        ) { }

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
        /// (Optional.) Default is blank. String containing the new data that
        /// should be substituted for the replaced text.
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
        /// , are passed blank or <c>null</c> string for values.
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

            /*
             * OKAY, we can assume that the 'source', 'pattern', and
             * 'dest' parameters are already set up for us and we can
             * just go ahead and begin the replace operation.
             */

            if (Configuration.MatchWholeWord)
            {
                if (!Configuration.MatchCase)
                    return Regex.Replace(
                        source.ToLowerInvariant(),
                        $@"\b(${pattern.ToLowerInvariant()})\b", dest
                    );

                return Regex.Replace(source, $@"\b(${pattern})\b", dest);
            }

            if (!Configuration.MatchCase)
                return source.ToLowerInvariant().Replace(
                    pattern.ToLowerInvariant(), dest
                );

            return source.Replace(pattern, dest);
        }
    }
}