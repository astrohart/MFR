using MFR.Objects.Configuration.Interfaces;
using MFR.Objects.Operations.Constants;
using System;

namespace MFR.Objects.Engines.Matching
{
    public class TextInFilesMatchingEngine : TextExpressionMatchingEngineBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.Engines.Matching.TextExpressionMatchingEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        public TextInFilesMatchingEngine(IConfiguration configuration) : base(
            configuration
        ) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.TextInFileMatchingEngine" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <remarks>
        /// NOTE: This constructor is marked as <c>internal</c>. This is to
        /// limit the scope of invocation to abstract factories only.
        /// <para />
        /// Clients who want to new up an instance of this class directly must
        /// use the <c>public</c> constructor.
        /// </remarks>
        internal TextInFilesMatchingEngine()
        {
            // TODO: Add default object initialization code here
        }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
        {
            get;
        } = OperationType.ReplaceTextInFiles;

        /// <summary>
        /// Determines whether a <paramref name="value" /> string is a match
        /// against a <paramref name="findWhat" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the pattern that specifies the search criteria.
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
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="findWhat" />, is
        /// passed either the empty or <see langword="null" /> string for a value.
        /// <para />
        /// This makes logical sense; if the <paramref name="findWhat" /> is
        /// blank, then we have nothing to search against!
        /// <para />
        /// NOTE: This parameter MAY have whitespace characters since these can
        /// be matched inside the content of a text file, which is what we
        /// expect to be passed for the <paramref name="value" /> parameter.
        /// </exception>
        /// <remarks>
        /// It is expected that the <paramref name="value" /> parameter has the
        /// contents of the file. Sometimes, files contain zero bytes of data.
        /// <para />
        /// If this is the case, then this method does nothing and returns the
        /// default result of <see langword="false" />.
        /// </remarks>
        public override bool IsMatch(
            string value, /* data from a file, encoded as a string of bytes */
            string findWhat, /* the pattern to search against, which may contain whitespace chars */
            string replaceWith =
                "" /* optional replacement value; blank erases text. */
        )
        {
            base.IsMatch(value, findWhat, replaceWith);

            // can't match if there is no data against which to search. BUT if
            // the file whose content is being passed in the 'source' parameter
            // contains only whitespace, then this is OK to match against.
            if (string.IsNullOrEmpty(value))
                return false;

            if (string.IsNullOrEmpty(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or the empty string. It CAN be whitespace, however.",
                    nameof(findWhat)
                );

            bool result;

            try
            {
                result = GetStringMatcher.For(OperationType.ReplaceTextInFiles)
                                         .AndTextMatchingConfiguration(
                                             Configuration
                                                 .GetTextMatchingConfiguration()
                                         )
                                         .IsMatch(value, findWhat, replaceWith);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}