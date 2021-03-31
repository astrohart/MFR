using MFR.Objects.Operations.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Objects.Expressions.Matches.Factories
{
    public class FolderNameReplacementMatchExpressionFactory : FileAndFolderMatchExpressionFactoryBase
    {
        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)] public override OperationType OperationType
            => OperationType.RenameSubFolders;
    }
}