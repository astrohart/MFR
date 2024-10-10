using MFR.Engines.Matching.Factories.Properties;
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
        ///     cref="T:MFR.Operations.Constants.OperationType" />
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
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface to the
        /// new object instance.
        /// </remarks>
        public static ITextExpressionMatchingEngine For(OperationType type)
        {
            ITextExpressionMatchingEngine result;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    result = MakeNewFileNameMatchingEngine.FromScratch();
                    break;

                case OperationType.RenameSubFolders:
                    result = MakeNewFolderNameMatchingEngine.FromScratch();
                    break;

                case OperationType.ReplaceTextInFiles:
                    result = MakeNewTextInFilesMatchingEngine.FromScratch();
                    break;

                case OperationType.RenameSolutionFolders:
                    result =
                        MakeNewSolutionFolderNameMatchingEngine.FromScratch();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        string.Format(
                            Resources.Exception_OperationTypeNotSupported, type
                        )
                    );
            }

            return result;
        }
    }
}