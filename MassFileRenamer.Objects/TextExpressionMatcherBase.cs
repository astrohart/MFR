﻿using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Implements functionality common to all text-expression matcher objects.
    /// </summary>
    public abstract class
        TextExpressionMatcherBase : ConfigurationComposedObjectBase,
            ITextExpressionMatcher
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextExpressionMatcherBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        protected TextExpressionMatcherBase()
        {
            // TODO: Add default object-initialization code here.
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextExpressionMatcherBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration" /> interface
        /// that holds settings that are specified by the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        protected TextExpressionMatcherBase(IConfiguration configuration) :
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
        /// <c>null</c> string for values.
        /// </exception>
        /// <returns>
        /// Returns <c>true</c> if the <paramref name="value" /> is a match
        /// against the provided <paramref name="findWhat" />; <c>false</c> if no
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
        ///     cref="P:MassFileRenamer.Objects.ITextExpressionMatcher.Configuration" />
        /// property.
        /// </summary>
        /// <param name="expression">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IMatchExpression" />
        /// interface and whose properties contain the match and pattern data.
        /// </param>
        /// <returns>
        /// <c>true</c> if more than zero matches are found; <c>false</c> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <c>null</c> value.
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
    }
}