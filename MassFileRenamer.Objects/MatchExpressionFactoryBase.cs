namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines methods and properties that all implementations of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.IMatchExpressionFactory" />
    /// interface
    /// have in common.
    /// </summary>
    public abstract class
        MatchExpressionFactoryBase : ConfigurationComposedObjectBase,
            IMatchExpressionFactory
    {
        /// <summary>
        /// Gets or sets a string containing the pattern to be utilized as
        /// search criteria.
        /// </summary>
        protected string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the text that all occurrences of
        /// the pattern in the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.MatchExpressionFactoryBase.FindWhat" />
        /// property get replaced with in the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.MatchExpressionFactoryBase.Value" />
        /// property.
        /// </summary>
        protected string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the text data to be searched.
        /// </summary>
        protected string Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public abstract OperationType OperationType
        {
            get;
        }

        /// <summary>
        /// Initializes the value that text matching the pattern specified by
        /// the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IMatchExpressionFactory.ToFindWhat" />
        /// method will be replaced with.
        /// <para />
        /// Whitespace or the empty string is only allowed for the Replace in
        /// Files operation type.
        /// </summary>
        /// <param name="replaceWith">
        /// (Optional for Replace in Files only.) String containing the text
        /// that all occurrences of text matching the pattern are to be replaced with.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IMatchExpression" />
        /// interface.
        /// </returns>
        /// <remarks>
        /// This method is the final method in the fluent-build chain,
        /// outputting an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IMatchExpression" />
        /// interface as a result.
        /// <para />
        /// It is required to provide a non-blank, non-whitespace value for
        /// <paramref name="replaceWith" /> except for the Replace Text in Files operation.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="replaceWith" />, is
        /// passed a blank or <c>null</c> string for a value, EXCEPT for the
        /// Replace Text in Files operation type.
        /// </exception>
        public abstract IMatchExpression AndReplaceItWith(string replaceWith);

        /// <summary>
        /// Sets the text data to be searched for a pattern.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data to be searched for a pattern.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="value" />, is
        /// passed a blank or <c>null</c> string for a value.
        /// </exception>
        /// <remarks>
        /// Among the fluent-builder methods of this class, this one must be
        /// invoked first.
        /// <para />
        /// However, prior to even invoking this method, the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IConfigurationComposedObject.AndAttachConfiguration" />
        /// method must be invoked; otherwise, a
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ConfigurationNotAttachedException" />
        /// will be thrown. It is incumbent upon invokers of this method to
        /// first weed out any possible elements of the source value set that
        /// may make the <paramref name="value" /> parameter get passed a blank string.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="value" />, is
        /// passed either the empty or <c>null</c> string for a value.
        /// Whitespace is allowed ONLY for the Replace Text in Files operation type.
        /// </exception>
        public abstract IMatchExpressionFactory ForTextValue(string value);

        /// <summary>
        /// Initializes the match expression with the pattern to be found in the
        /// value data.
        /// </summary>
        /// <param name="findWhat">
        /// (Required.) String containing the pattern to search the value data for.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="findWhat" />, is
        /// passed a blank or <c>null</c> string for a value.
        /// </exception>
        /// <remarks>
        /// It is recommended to call this method after calling the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IMatchExpressionFactory.ForTextValue" />
        /// method.
        /// <para />
        /// It is incumbent upon invokers of this method to first weed out any
        /// possible elements of the source value set that may make the
        /// <paramref name="value" /> parameter get passed a blank string.
        /// </remarks>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="findWhat" />, is
        /// passed either the empty string or <c>null</c> string for a value.
        /// Whitespace is allowed, but ONLY for the Replace Text in Files
        /// operation type.
        /// </exception>
        public abstract IMatchExpressionFactory ToFindWhat(string findWhat);
    }
}