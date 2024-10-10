namespace MFR.Operations.Descriptions.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an Operation
    /// Started Description object. This text is displayed as an operation is
    /// just being commenced.
    /// </summary>
    /// <remarks>
    /// It is up to the implementers of this interface to supply the proper text.
    /// </remarks>
    public interface IOperationStartedDescription : IOperationDescription
    {
    }
}