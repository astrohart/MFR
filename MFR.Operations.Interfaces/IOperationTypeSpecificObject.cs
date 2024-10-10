using MFR.Operations.Constants;

namespace MFR.Operations.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object whose
    /// behavior varies depending on the type of operation being performed.
    /// </summary>
    public interface IOperationTypeSpecificObject : IFixedOperationTypeSpecificObject
    {
        /// <summary>
        /// Initializes the
        /// <see
        ///     cref="P:MFR.IOperationSpecificObject.OperationType" />
        /// property with the specific
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// value that
        /// corresponds to the type of operation being performed.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// specifies the type of operation being performed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        dynamic AndOperationType(OperationType type);
    }
}