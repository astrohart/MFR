using System;

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
        /// Determines whether a <paramref name="source" /> string is a match
        /// against a <paramref name="pattern" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="pattern">
        /// (Required.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="source" />
        /// or <paramref name="pattern" />, are passed blank or
        /// <c>null</c> string for values.
        /// </exception>
        /// <returns>
        /// Returns <c>true</c> if the <paramref name="source" /> is a match
        /// against the provided <paramref name="pattern" />; <c>false</c> if no
        /// matches are found.
        /// </returns>
        /// <remarks>
        /// NOTE: Implementers of this object must override this method and the
        /// override must start by calling the base class.
        /// </remarks>
        public virtual bool IsMatch(string source, string pattern,
            string dest = "")
        {
            if (!IsConfigurationAttached)
                throw new InvalidOperationException(
                    "This object must be composed with a IConfiguration-implementing object prior to use.  To do so, call the AttachConfiguration() method."
                );

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
        /// (Required.) A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchExpression" />
        /// containing the
        /// match and pattern data.
        /// </param>
        /// <returns>
        /// <c>true</c> if more than zero matches are found; <c>false</c> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <c>null</c> value.
        /// </exception>
        public bool IsMatch(MatchExpression expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

            // delegate to the other overload of this method
            return IsMatch(
                expression.Source, expression.Pattern,
                expression.SubstitutionDestination
            );
        }
    }
}