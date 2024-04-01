using MFR.Operations.Constants;
using MFR.Replacers.Interfaces;
using MFR.Settings.Configuration.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Replacers
{
    /// <summary>
    /// Defines the methods, properties, and events that all String Replacer
    /// objects for the Rename Files in Folder operation type have in common.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class ReplaceTextInfilesStringReplacerBase : IStringReplacer
    {
        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public OperationType OperationType
            { get; } = OperationType.ReplaceTextInFiles;

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public abstract TextMatchingConfiguration TextMatchingConfiguration
        {
            get;
        }

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="value" />. Returns a string
        /// </summary>
        /// <param name="value">
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
        ///     name="value" />
        /// , <paramref name="pattern" />, or
        /// <paramref
        ///     name="dest" />
        /// , are passed blank or <see langword="null" /> string
        /// for values.
        /// </exception>
        [return: NotLogged]
        public abstract string Replace([NotLogged] string value,
            [NotLogged] string pattern, [NotLogged] string dest = "");
    }
}