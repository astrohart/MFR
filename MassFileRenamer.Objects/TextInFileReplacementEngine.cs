using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Replaces text in a file. Here, we represent the file's contents as
    /// simply the source string of methods.
    /// </summary>
    public class TextInFileReplacementEngine : TextReplacementEngineBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextInFileReplacementEngine" />
        /// and
        /// returns a reference to it.
        /// </summary>
        public TextInFileReplacementEngine()
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
        public TextInFileReplacementEngine(IConfiguration configuration) : base(
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
        /// or <paramref name="pattern" />, are passed blank or
        /// <c>null</c> string for values.
        /// </exception>
        /// <remarks>
        /// Here, the <paramref name="dest" /> parameter may be blank or null; if
        /// this is the case, then the text found by the
        /// <paramref
        ///     name="pattern" />
        /// just gets deleted, which is okay in this instance.
        /// </remarks>
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

            if (!Configuration.MatchWholeWord)
                return Configuration.MatchCase
                    ? source.Replace(pattern, dest)
                    : source.ReplaceNoCase(pattern, dest);

            return Configuration.MatchCase
                ? source.RegexReplaceWithCase($@"\b({pattern})\b", dest)
                : source.RegexReplaceNoCase($@"\b({pattern})\b", dest);
        }
    }
}