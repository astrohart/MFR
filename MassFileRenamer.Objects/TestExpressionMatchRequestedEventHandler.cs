namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Contains the method signature for a handler of a FileNameRequested event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see
    ///     cref="T:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs" />
    /// that contains the event data.
    /// </param>
    public delegate void TestExpressionMatchRequestedEventHandler(object sender,
        TestExpressionMatchRequestedEventArgs e);
}