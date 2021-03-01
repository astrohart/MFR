using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.ITextExpressionMatcher" />
    /// interface and
    /// returns references to them.
    /// </summary>
    public static class GetTextExpressionMatcher
    {
        /// <summary>
        /// Creates instances of objects that implement the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ITextExpressionMatcher" />
        /// interface
        /// and returns references to them.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// specifies the operation currently being performed.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that
        /// implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ITextExpressionMatcher" />
        /// interface
        /// that can tell if data matches a value.
        /// </returns>
        /// <remarks>
        /// After calling this method, callers must
        /// then invoke the fluent
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ITextExpressionMatcher.WithConfiguration" />
        /// method on the result of this method in order to attach an object
        /// that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// interface to the
        /// new object instance.
        /// 
        public static ITextExpressionMatcher For(OperationType type)
        {
            ITextExpressionMatcher matcher;

            switch (type)
            {
                case OperationType.RenameFilesInFolder:
                    matcher = new FileNameMatcher();
                    break;

                case OperationType.RenameSubFolders:
                    matcher = new FolderNameMatcher();
                    break;

                case OperationType.ReplaceTextInFiles:
                    matcher = new TextInFileMatcher();
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