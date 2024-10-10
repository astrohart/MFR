using MFR.GUI.Models.Constants.Factories;
using MFR.GUI.Models.Interfaces;
using PostSharp.Patterns.Diagnostics;
using MFR.Operations.Constants;
using System;

namespace MFR.GUI.Models.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" /> interface, and
    /// returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewOperationTypeInfo
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" /> interface.
        /// </returns>
        public static IOperationTypeInfo FromScratch()
            => new OperationTypeInfo();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Models.Interfaces.IOperationTypeInfo.PROPNAME" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" />
        /// interface.
        /// </param>
        /// <param name="type">
        /// (Required.) An <see cref="T:MFR.Operations.Constants.OperationType" /> value
        /// that corresponds to the type of operation to be performed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IOperationTypeInfo HavingOperationType(
            this IOperationTypeInfo self, OperationType type)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.OperationType = type;
            self.Name = GetOperationName.For(type);

            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Models.Interfaces.IOperationTypeInfo.Enabled" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Models.Interfaces.IOperationTypeInfo" />
        /// interface.
        /// </param>
        /// <param name="enabled">
        /// (Required.) A value that indicates whether the user wants to perform the type
        /// of operation that is specified by the value of the
        /// <see cref="P:MFR.GUI.Models.Interfaces.IOperationTypeInfo.OperationType" />
        /// property.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IOperationTypeInfo AndSetEnabledFlag(
            this IOperationTypeInfo self, bool enabled = true)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Enabled = enabled;
            return self;
        }
    }
}