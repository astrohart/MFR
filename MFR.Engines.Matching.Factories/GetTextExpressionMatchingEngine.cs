using MFR.Engines.Matching.Interfaces;
using MFR.Operations.Constants;
using System;

namespace MFR.Engines.Matching.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.ITextExpressionMatchingEngine" />
    /// interface and
    /// returns references to them.
    /// </summary>
    public static class GetTextExpressionMatchingEngine
    {
        /// <summary>
        /// Creates instances of objects that implement the
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// interface
        /// and returns references to them.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.OperationType" />
        /// values that
        /// specifies the operation currently being performed.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that
        /// implements the
        /// <see
        ///     cref="T:MFR.ITextExpressionMatchingEngine" />
        /// interface
        /// that can tell if data matches a value.
        /// </returns>
        /// <remarks>
        /// After calling this method, callers must
        /// then invoke the fluent
        /// <see
        ///     cref="M:MFR.ITextExpressionMatchingEngine.WithConfiguration" />
        /// method on the result of this method in order to attach an object
        /// that implements the
        /// <see
        ///     cref="T:MFR.IConfiguration" />
        /// interface to the
        /// new object instance.
        /// </remarks>
        public static ITextExpressionMatchingEngine For(OperationType type)
        {
            ITextExpressionMatchingEngine matcher;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    matcher = new FileNameMatchingEngine();
                    break;

                case OperationType.RenameSubFolders:
                    matcher = new FolderNameMatchingEngine();
                    break;

                case OperationType.ReplaceTextInFiles:
                    matcher = new TextInFilesMatchingEngine();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type, null
                    );
            }

            return matcher;
        }
    }
}