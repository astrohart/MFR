using MFR.Operations.Constants;

namespace MFR.GUI.Models.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a POCO that encodes
    /// information about a type of operation.
    /// </summary>
    public interface IOperationTypeInfo
    {
        /// <summary>
        /// Gets or sets a value that indicates whether the user wants to perform the
        /// operation.
        /// </summary>
        bool Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the operation type.
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="T:MFR.Operations.Constants.OperationType" /> value
        /// that corresponds to the type of operation to perform.
        /// </summary>
        OperationType OperationType
        {
            get;
            set;
        }
    }
}