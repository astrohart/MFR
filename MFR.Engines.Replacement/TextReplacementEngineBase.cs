using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Interfaces;
using MFR.Engines.Replacement.Intefaces;
using MFR.Expressions.Matches.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Engines.Replacement
{
    /// <summary>
    /// Defines the methods, properties, and events that are common to all
    /// text-replacement engine object implementations.
    /// </summary>
    public abstract class
        TextReplacementEngineBase : ConfigurationComposedObjectBase,
            ITextReplacementEngine
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Engines.Replacement.TextReplacementEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected TextReplacementEngineBase()
        {
            // TODO: Add default object-initialization code here.
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.TextReplacementEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an
        /// instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        protected TextReplacementEngineBase(IConfiguration configuration) :
            base(configuration) { }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public abstract OperationType OperationType
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
        /// or <paramref name="pattern" />, are passed blank or
        /// <see langword="null" /> string for values.
        /// </exception>
        public abstract string Replace(string value, string pattern,
            string dest = "");

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="expression" />. Returns a string
        /// containing the results.
        /// </summary>
        /// <param name="expression">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.MatchExpression" />
        /// that contains the
        /// replacement data.
        /// </param>
        /// <returns>
        /// String containing the new data.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public string Replace(IMatchExpression expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

            return Replace(
                expression.Value, expression.FindWhat, expression.ReplaceWith
            );
        }
    }
}
