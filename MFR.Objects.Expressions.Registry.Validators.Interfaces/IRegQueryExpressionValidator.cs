namespace MFR.Objects.Expressions.Registry.Validators.Interfaces
{
    /// <summary>
    /// Validates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Objects.IRegQueryExpression{T}" />
    /// interface.
    /// </summary>
    public interface IRegQueryExpressionValidator<T> where T : class
    {
        /// <summary>
        /// Gets the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IRegQueryExpression" />
        /// interface
        /// that is being validated.
        /// </summary>
        IRegQueryExpression<T> Expression
        {
            get;
        }

        /// <summary>
        /// Initializes the value of the
        /// <see
        ///     cref="P:MFR.Objects.IRegQueryExpressionValidator.Expression" />
        /// property to refer to the data that is to be validated.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        IRegQueryExpressionValidator<T> ForRegQueryExpression(
            IRegQueryExpression<T> expression);

        /// <summary>
        /// Validates the data. An exception is thrown if the data is invalid.
        /// No exception means valid.
        /// </summary>
        void Validate();
    }
}

    