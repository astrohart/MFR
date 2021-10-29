using MFR.GUI.Models.Interfaces;
using MFR.Operations.Constants;
using Newtonsoft.Json;

namespace MFR.GUI.Models
{
    /// <summary>
    /// Information about a type of operation to perform to indicate whether the user
    /// wants to perform the operation.
    /// <para />
    /// Provides a model for a particular item in the CheckedListBox in the Operations
    /// tab of the GUI.
    /// </summary>
    public class OperationTypeInfo : IOperationTypeInfo
    {
        /// <summary>
        /// One of the <see cref="T:MFR.Operations.Constants.OperationType" /> values that
        /// corresponds to the type of operation to perform.
        /// </summary>
        private OperationType _operationType;

        /// <summary>
        /// Gets or sets a value that indicates whether the user wants to perform the
        /// operation.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the operation type.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="T:MFR.Operations.Constants.OperationType" /> value
        /// that corresponds to the type of operation to perform.
        /// </summary>
        [JsonProperty("operationType")]
        public OperationType OperationType
        {
            get => _operationType;
            set {
                _operationType = value;

                Name = ConvertOperationType.ToString(value);
            }
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        /// <remarks>
        /// This method returns the value of the
        /// <see cref="P:MFR.GUI.Models.OperationTypeInfo.Name" /> property.
        /// </remarks>
        public override string ToString()
            => Name;
    }
}