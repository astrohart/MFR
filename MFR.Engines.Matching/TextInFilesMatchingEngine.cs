using MFR.Engines.Matching.Actions;
using MFR.Operations.Constants;
using MFR.Settings.Configuration.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Engines.Matching
{
    /// <summary>
    /// Matches text in a file that is to be (eventually) replaced.
    /// </summary>
    public class TextInFilesMatchingEngine : TextExpressionMatchingEngineBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Engines.Matching.TextExpressionMatchingEngineBase" />
        /// and returns a reference to it.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref name="config" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public TextInFilesMatchingEngine(
            IProjectFileRenamerConfig config) : base(
            config
        ) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.TextInFileMatchingEngine" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <remarks>
        /// NOTE: This constructor is marked as <c>internal</c>. This to
        /// limit the scope of invocation to abstract factories only.
        /// <para />
        /// Clients who want to new up an instance of this class directly must
        /// use the <c>public</c> constructor.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public TextInFilesMatchingEngine()
        {
            // TODO: Add default object initialization code here
        }

        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
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
        /// <param name="replaceWith">
        /// (Optional.) String containing the data to replace all occurrences of
        /// <paramref name="findWhat" /> with in the <paramref name="value" />.
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
            [NotLogged]
            string value, /* data from a file, encoded as a string of bytes */
            [NotLogged]
            string findWhat, /* the pattern to search against, which may contain whitespace chars */
            [NotLogged] string replaceWith =
                "" /* optional replacement value; blank erases text. */
        )
        {
            var result = base.IsMatch(value, findWhat, replaceWith);

            try
            {
                // can't match if there is no data against which to search. BUT if
                // the file whose content is being passed in the 'source' parameter
                // contains only whitespace, then this OK to match against.
                if (string.IsNullOrEmpty(value))
                    return result;

                if (string.IsNullOrEmpty(findWhat))
                    return result;

                var matcher = Get.StringMatcherForOperation(
                    OperationType, CurrentConfiguration
                );
                if (matcher == null) return result;

                /*
                 * Ask the matcher if the search criteria are a match or not.
                 */

                result = matcher.IsMatch(value, findWhat, replaceWith);
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