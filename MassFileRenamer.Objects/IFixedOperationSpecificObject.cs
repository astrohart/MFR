namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that is
    /// tagged with one of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.OperationType" />
    /// values.
    /// </summary>
    /// <remarks>
    /// This interface represents an object for which the operation type is immutable.
    /// </remarks>
    public interface IFixedOperationSpecificObject
    {
        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        OperationType OperationType
        {
            get;
        }
    }
}