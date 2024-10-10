using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Interfaces
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that is
    /// tagged with one of the
    /// <see
    ///     cref="T:MFR.Operations.Constants.OperationType" />
    /// values.
    /// </summary>
    /// <remarks>
    /// This interface represents an object for which the operation type is immutable.
    /// </remarks>
    public interface IFixedOperationTypeSpecificObject
    {
        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)] OperationType OperationType
        {
            get;
        }
    }
}