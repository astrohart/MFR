using MFR.Expressions.Registry.Interfaces;
using MFR.Expressions.Registry.Validators.Interfaces;
using MFR.Expressions.Registry.Validators.Properties;
using MFR.Registry.Helpers;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Expressions.Registry.Validators
{
    /// <summary>
    /// Validates the data in the properties of instances of objects that
    /// implement the
    /// <see
    ///     cref="T:MFR.Expressions.Registry.Interfaces.IRegQueryExpression" />
    /// interface.
    /// </summary>
    /// <typeparam name="T">
    /// Name of the type of data that is being fetched from, or written to, the
    /// system Registry.
    /// </typeparam>
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
        /// Gets the instance of the object that implements the
        /// <see
        ///     cref="T:MFR.IRegQueryExpression" />
        /// interface that is being validated.
        /// </summary>
        [Log(AttributeExclude = true)]
        public IRegQueryExpression<T> Expression
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.RegQueryExpressionValidator" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IRegQueryExpressionValidator<T> Instance
        {
            get;
        } = new RegQueryExpressionValidator<T>();

        /// <summary>
        /// Initializes the value of the
        /// <see
        ///     cref="P:MFR.IRegQueryExpressionValidator.Metadata" />
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
        /// Validates the data.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the value of the
        /// <see
        ///     cref="P:MFR.Expressions.Registry.Validators.Interfaces.IRegQueryExpressionValidator{T}.Metadata" />
        /// property is valid; <see langword="false" /> otherwise.
        /// </returns>
        public bool Validate()
        {
            var result = true;

            try
            {
                if (Expression == null)
                    throw new InvalidOperationException(
                        Resources.Error_ExpressionPropertyIsNull
                    );

                if (string.IsNullOrWhiteSpace(Expression.KeyPath))
                    throw new InvalidOperationException(
                        Resources.Error_RegistryKeyPathnameBlank
                    );

                if (!Expression.KeyPath.StartsWithValidHiveName())
                    throw new InvalidOperationException(
                        Resources
                            .Error_RegistryKeyPathnameDoesNotStartWithValidHive
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            /*
             * OKAY, if we are here, then our validation rules have been passed.
             */

            return result;
        }
    }
}