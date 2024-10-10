using MFR.Expressions.Registry.Interfaces;

namespace MFR.Expressions.Registry.Validators.Interfaces
{
    /// <summary>
    /// Validates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.IRegQueryExpression{T}" />
    /// interface.
    /// </summary>
    /// <typeparam name="T">
    /// (Required.) Name of the data type of the information that
    /// to be accessed.
    /// </typeparam>
    public interface IRegQueryExpressionValidator<T> where T : class
    {
        /// <summary>
        /// Gets the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.IRegQueryExpression" />
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
        ///     cref="P:MFR.IRegQueryExpressionValidator.Expression" />
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
        /// Validates the data.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the value of the
        /// <see
        ///     cref="P:MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator{T}.Expression" />
        /// property is valid; <see langword="false" /> otherwise.
        /// </returns>
        bool Validate();
    }
}