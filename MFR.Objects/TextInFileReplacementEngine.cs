using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Objects
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
        ///     cref="T:MFR.Objects.TextInFileReplacementEngine" />
        /// and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        public TextInFileReplacementEngine()
        {
            // TODO: Add default object initialization here
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.TextReplacementEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// (Required.) Reference to an
        /// instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IConfiguration" />
        /// interface that
        /// holds settings that are specified by the user.
        /// </param>
        /// <exception
        ///     cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="configuration" />, is passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public TextInFileReplacementEngine(IConfiguration configuration) : base(
            configuration
        ) { }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
        {
            get;
        } = OperationType.ReplaceTextInFiles;

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
        /// String containing the new data. If the <paramref name="source" />
        /// </returns>
        /// <remarks>
        /// Here, the <paramref name="dest" /> parameter may be blank or null; if
        /// the <paramref name="source" /> parameter is <see langword="null" /> or
        /// the empty string, then this method returns the empty string.
        /// <para />
        /// NOTE: The <paramref name="source" /> parameter MAY contain whitespace.
        /// this is the case, then the text found by the
        /// <paramref
        ///     name="pattern" />
        /// just gets deleted, which is okay in this instance.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="pattern" />, is
        /// passed either the empty or <see langword="null" /> string for a value.
        /// <para />
        /// This makes logical sense; if the <paramref name="pattern" /> is
        /// blank, then we have nothing to search against!
        /// <para />
        /// NOTE: This parameter MAY have whitespace characters since these can
        /// be matched inside the content of a text file, which is what we
        /// expect to be passed for the <paramref name="source" /> parameter.
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

            var result = source; // no replacement if error

            try
            {
                result = GetStringReplacer.For(OperationType.ReplaceTextInFiles)
                                          .AndTextMatchingConfiguration(
                                              Configuration
                                                  .GetTextMatchingConfiguration()
                                          )
                                          .Replace(source, pattern, dest);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = source;
            }

            return result;
        }
    }
}