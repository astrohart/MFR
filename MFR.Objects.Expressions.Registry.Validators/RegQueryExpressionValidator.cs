using System;

namespace MFR.Objects.Expressions.Registry.Validators
{
    public class
        RegQueryExpressionValidator<T> : IRegQueryExpressionValidator<T>
        where T : class
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RegQueryExpressionValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RegQueryExpressionValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Objects.RegQueryExpressionValidator" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IRegQueryExpressionValidator<T> Instance
        {
            get;
        } = new RegQueryExpressionValidator<T>();

        /// <summary>
        /// Gets the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Objects.IRegQueryExpression" />
        /// interface
        /// that is being validated.
        /// </summary>
        [Log(AttributeExclude = true)]
        public IRegQueryExpression<T> Expression
        {
            get;
            private set;
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
        public IRegQueryExpressionValidator<T> ForRegQueryExpression(
            IRegQueryExpression<T> expression)
        {
            Expression = expression ??
                         throw new ArgumentNullException(nameof(expression));

            return this;
        }

        /// <summary>
        /// Validates the data. An
        /// <see
        ///     cref="T:System.InvalidOperationException" />
        /// is thrown if the data is
        /// invalid. No exception means valid.
        /// </summary>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the data is not valid.
        /// </exception>
        public void Validate()
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In RegQueryExpressionValidator.Validate"
            );

            if (string.IsNullOrWhiteSpace(Expression.KeyPath))
                throw new InvalidOperationException(
                    "The specified expression's Registry key path is invalid."
                );

            if (!Expression.KeyPath.StartsWithValidHiveName())
                throw new InvalidOperationException(
                    "The specified expression's Registry key path must be the fully-qualified path, including the Registry hive (HKEY_CLASSES_ROOT etc)."
                );

            /*
             * OKAY, if we are here, then our validation rules have been passed.
             */

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** The registry query expression has passed validation."
            );
        }
    }
}