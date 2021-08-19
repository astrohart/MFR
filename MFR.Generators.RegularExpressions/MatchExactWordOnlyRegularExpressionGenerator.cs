using MFR.Generators.RegularExpressions.Constants;
using MFR.Generators.RegularExpressions.Properties;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Text.RegularExpressions;

namespace MFR.Generators.RegularExpressions
{
    /// <summary>
    /// Generator of regular expressions for exact-word matches.
    /// </summary>
    public class
        MatchExactWordOnlyRegularExpressionGenerator :
            RegularExpressionGeneratorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchExactWordOnlyRegularExpressionGenerator()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchExactWordOnlyRegularExpressionGenerator()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see
        /// cref="T:MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator"/> .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchExactWordOnlyRegularExpressionGenerator Instance
        {
            get;
        } = new MatchExactWordOnlyRegularExpressionGenerator();

        /// <summary>
        /// Gets the <see
        /// cref="T:MFR.Generators.RegularExpressions.Constants.RegularExpressionType"/>
        /// value that uniquely identifies which type of regular expressions
        /// that this object handles.
        /// </summary>
        public override RegularExpressionType RegularExpressionType
            => RegularExpressionType.MatchExactWordOnly;

        /// <summary>
        /// Transforms the input <paramref name="value"/> into the output value.
        /// </summary>
        /// <param name="value">
        /// (Required.) The <see cref="T:System.String"/> that is to be transformed.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String"/> whose value is the result of the transformation.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="value"/>, is
        /// passed a blank or <see langword="null"/> string for a value.
        /// </exception>
        public override string Generate(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(value)
                );

            return string.Format(
                RegexFormats.MatchExactWord, Regex.Escape(value)
            );
        }
    }
}