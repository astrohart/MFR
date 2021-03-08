using System;
using System.Text.RegularExpressions;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Replaces text in a file. Here, we represent the file's contents as
    /// simply the source string of methods.
    /// </summary>
    public class TextInFileReplacementEngine : TextReplacementEngineBase
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MassFileRenamer.Objects.TextInFileReplacementEngine"/> and
        /// returns a reference to it.
        /// </summary>
        public TextInFileReplacementEngine()
        {
            // TODO: Add default object initialization here
        }

        /// <summary> Constructs a new instance of <see
        /// cref="T:MassFileRenamer.Objects.TextReplacementEngineBase" /> and
        /// returns a reference to it. </summary> (Required.) Reference to an
        /// instance of an object that implements the <see
        /// cref="T:MassFileRenamer.Objects.IConfiguration" /> interface that
        /// holds settings that are specified by the user. </param> <exception
        /// cref="T:System.ArgumentNullException"> Thrown if the required
        /// parameter, <paramref name="configuration" />, is passed a
        /// <c>null</c> value. </exception>
        public TextInFileReplacementEngine(IConfiguration configuration) : base(
            configuration
        )
        {
        }

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="expression"/>. Returns a string
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
        /// String containing the new data. If the <paramref name="source"/>
        /// </returns>
        /// <remarks>
        /// Here, the <paramref name="dest"/> parameter may be blank or null; if
        /// the <paramref name="source"/> parameter is <c>null</c> or the empty
        /// string, then this method returns the empty string.
        /// <para/>
        /// NOTE: The <paramref name="source"/> parameter MAY contain whitespace.
        /// this is the case, then the text found by the <paramref
        /// name="pattern"/> just gets deleted, which is okay in this instance.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="pattern"/>, is
        /// passed either the empty or <c>null</c> string for a value.
        /// <para/>
        /// This makes logical sense; if the <paramref name="pattern"/> is
        /// blank, then we have nothing to search against!
        /// <para/>
        /// NOTE: This parameter MAY have whitespace characters since these can
        ///       be matched inside the content of a text file, which is what we
        ///       expect to be passed for the <paramref name="source"/> parameter.
        /// </exception>
        public override string Replace(string source, string pattern,
            string dest = "")
        {
            // return the empty string if no text to be replaced is provided.
            if (string.IsNullOrEmpty(source))
                return string.Empty;    

            if (string.IsNullOrWhiteSpace(pattern))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(pattern)
                );

            if (!Configuration.MatchWholeWord)
                return Configuration.MatchCase
                    ? source.Replace(pattern, dest)
                    : source.ReplaceNoCase(pattern, dest);

            return Configuration.MatchCase
                ? source.RegexReplaceWithCase($@"\b({Regex.Escape(pattern)})\b", dest)
                : source.RegexReplaceNoCase($@"\b({Regex.Escape(pattern)})\b", dest);
        }
    }
}