using MFR.Operations.Interfaces;

namespace MFR.Operations.Descriptions.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an operation
    /// description object.
    /// </summary>
    public interface IOperationDescription : IFixedOperationTypeSpecificObject
    {
        /// <summary>
        /// Gets a string to be displayed to the user, that corresponds to the
        /// current type of operation that is currently being performed.
        /// </summary>
        /// <remarks>
        /// It is up to the implementers of this interface to supply the proper text.
        /// </remarks>
        string Text
        {
            get;
        }
    }
}