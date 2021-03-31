using MFR.Objects.Configuration;
using MFR.Objects.Configuration.Interfaces;
using MFR.Objects.Engines.Matching.Interfaces;
using MFR.Objects.Expressions.Matches.Interfaces;
using MFR.Objects.Operations.Constants;
using System;

namespace MFR.Objects.Engines.Matching
{
    /// <summary>
    /// Implements functionality common to all text-expression matcher objects.
    /// </summary>
    public abstract class
        TextExpressionMatchingEngineBase : ConfigurationComposedObjectBase,
            ITextExpressionMatchingEngine
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.Engines.Matching.TextExpressionMatchingEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        protected TextExpressionMatchingEngineBase()
        {
            // TODO: Add default object-initialization code here.
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Objects.TextExpressionMatchingEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.IConfiguration" /> interface
        /// that holds settings that are specified by the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        protected TextExpressionMatchingEngineBase(IConfiguration configuration) :
            base(configuration) { }

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
        /// Returns <see langword="true" /> if the <paramref name="value" /> is a match
        /// against the provided <paramref name="findWhat" />; <see langword="false" /> if no
        /// matches are found.
        /// </returns>
        /// <remarks>
        /// NOTE: Implementers of this object must override this method and the
        /// override must start by calling the base class.
        /// </remarks>
        public virtual bool IsMatch(string value, string findWhat,
            string replaceWith = "")
        {
            VerifyConfigurationAttached();

            return default;
        }

        /// <summary>
        /// Determines whether data and a search patterned, bound up together in
        /// the form of the <paramref name="expression" /> provided, contain a
        /// data match according to rules specified by the user in the object, a
        /// reference to which is specified in the
        /// <see
        ///     cref="P:MFR.Objects.ITextExpressionMatchingEngine.Configuration" />
        /// property.
        /// </summary>
        /// <param name="expression">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Objects.IMatchExpression" />
        /// interface and whose properties contain the match and pattern data.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if more than zero matches are found; <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public bool IsMatch(IMatchExpression expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

            // delegate to the other overload of this method
            return IsMatch(
                expression.Value, expression.FindWhat, expression.ReplaceWith
            );
        }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public abstract OperationType OperationType
        {
            get;
        }
    }
}