using MFR.Settings.Configuration.Helpers;
using MFR.Settings.Configuration.Interfaces;
using MFR.Matchers.Factories;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Engines.Matching
{
    /// <summary>
    /// Searches for matches to textual-search criteria patterns and regexes in
    /// the pathnames of folders, according to rules specified by projectFileRenamerConfiguration
    /// settings.
    /// </summary>
    public class FolderNameMatchingEngine : TextExpressionMatchingEngineBase

    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Engines.Matching.TextExpressionMatchingEngineBase" />
        /// and returns a reference to it.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="projectFileRenamerConfiguration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public FolderNameMatchingEngine(IProjectFileRenamerConfiguration projectFileRenamerConfiguration) : base(
            projectFileRenamerConfiguration
        ) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Engines.Matching.FolderNameMatchingEngine" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <remarks>
        /// NOTE: This constructor is marked as <c>internal</c>. This is to
        /// limit the scope of invocation to abstract factories only.
        /// <para />
        /// Clients who want to new up an instance of this class directly must
        /// use the <c>public</c> constructor.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public FolderNameMatchingEngine()
        {
            // TODO: Add default object initialization code here
        }

        /// <summary>
        /// Gets one of the <see cref="T:MFR.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
            => OperationType.RenameSubFolders;

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
        /// (Required.) String containing the value that the found text is to be
        /// replaced with. Cannot be blank.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// , <paramref name="findWhat" />, or
        /// <paramref
        ///     name="replaceWith" />
        /// are passed blank or <see langword="null" />
        /// string for values.
        /// </exception>
        /// <returns>
        /// Returns <see langword="true" /> if the <paramref name="value" /> is a
        /// match against the provided <paramref name="findWhat" />;
        /// <see
        ///     langword="false" />
        /// if no matches are found.
        /// </returns>
        public override bool IsMatch(
            [NotLogged] string value, 
            [NotLogged] string findWhat,
            [NotLogged] string replaceWith = "")
        {
            base.IsMatch(value, findWhat, replaceWith);

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );
            if (string.IsNullOrWhiteSpace(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(findWhat)
                );
            if (string.IsNullOrWhiteSpace(replaceWith))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replaceWith)
                );

            bool result;

            try
            {
                result = GetStringMatcher.For(OperationType.RenameSubFolders)
                                         .AndTextMatchingConfiguration(
                                             CurrentConfiguration
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
