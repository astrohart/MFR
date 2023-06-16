using MFR.Operations.Constants;
using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all classes that
    /// provide text describing the description of an operation.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class OperationDescriptionBase : IOperationDescription
    {
        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public abstract OperationType OperationType
        {
            get;
        }

        /// <summary>
        /// Gets a string to be displayed to the user, that corresponds to the
        /// current type of operation that is currently being performed.
        /// </summary>
        /// <remarks>
        /// It is up to the implementers of this interface to supply the proper text.
        /// </remarks>
        public abstract string Text
        {
            get;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
            => Text;
    }
}