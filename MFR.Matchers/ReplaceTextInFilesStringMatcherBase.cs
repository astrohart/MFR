using MFR.Settings.Configuration.Constants;
using MFR.Matchers.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Matchers
{
    /// <summary>
    /// Defines the methods, properties, and events that all String Matcher
    /// objects for the Replace Text in Files operation type have in common.
    /// </summary>
    public abstract class ReplaceTextInFilesStringMatcherBase : IStringMatcher
    {
        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public OperationType OperationType
            { get; } = OperationType.ReplaceTextInFiles;

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public abstract TextMatchingConfiguration TextMatchingConfiguration
        {
            get;
        }

        /// <summary>
        /// Determines whether a <paramref name="value" /> string is a match
        /// against a <paramref name="findWhat" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="findWhat">
        /// (Optional.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the data that all instances of
        /// <paramref name="findWhat" /> in <paramref name="value" /> are to be
        /// replaced with.
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
        /// <remarks>
        /// The base class method contains default input-validation logic and
        /// overriders should call the base class method while ignoring its
        /// return value.
        /// </remarks>
        public virtual bool IsMatch(
            [NotLogged] string value, 
            string findWhat,
            string replaceWith = "")
        {
            if (string.IsNullOrEmpty(value))
                return false; // if we have a zero-byte input file, then stop.

            if (string.IsNullOrEmpty(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or the empty string.  It CAN be whitespace, however.",
                    nameof(findWhat)
                );

            return false; /* this return value should not be used. */
        }
    }
}