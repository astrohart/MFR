﻿namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Contains the method signature for a handler of a TextExpressionMatchRequested event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the event.
    /// </param>
    /// <param name="e">
    /// A <see
    /// cref="T:MassFileRenamer.Objects.TextExpressionMatchRequestedEventArgs"/>
    /// that contains the event data.
    /// </param>
    public delegate void TextExpressionMatchRequestedEventHandler(object sender,
        TextExpressionMatchRequestedEventArgs e);
}