using MFR.Operations.Descriptions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
    /// interface and which provides user-friendly text that describes that the
    /// operation of replacing the text in the individual files that are contained
    /// within a given folder is proceeding.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetReplaceTextInFilesOperationDescription
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface, and returns
        /// a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Operations.Descriptions.Interfaces.IOperationDescription" />
        /// interface and which provides user-friendly text that describes that the
        /// operation of replacing the text in the individual files that are contained
        /// within a given folder is proceeding.
        /// </returns>
        public static IOperationDescription SoleInstance()
            => ReplaceTextInFilesOperationDescription.Instance;
    }
}