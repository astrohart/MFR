﻿using PostSharp.Patterns.Diagnostics;
using System;

namespace MassFileRenamer.Objects
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
        /// <see cref="T:MassFileRenamer.Objects.RegQueryExpressionValidator" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IRegQueryExpressionValidator<T> Instance
        {
            get;
        } = new RegQueryExpressionValidator<T>();

        /// <summary>
        /// Gets the instance of the object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IRegQueryExpression" />
        /// interface
        /// that is being validated.
        /// </summary>
        public IRegQueryExpression<T> Expression
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes the value of the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.IRegQueryExpressionValidator.Expression" />
        /// property to refer to the data that is to be validated.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="expression" />, is
        /// passed a <c>null</c> value.
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
            if (string.IsNullOrWhiteSpace(Expression.KeyPath))
                throw new InvalidOperationException(
                    "The specified expression's Registry key path is invalid."
                );

            if (!Expression.KeyPath.StartsWithValidHiveName())
                throw new InvalidOperationException(
                    "The specified expression's Registry key path must be the fully-qualified path, including the Registry hive (HKEY_CLASSES_ROOT etc)."
                );
        }
    }
}