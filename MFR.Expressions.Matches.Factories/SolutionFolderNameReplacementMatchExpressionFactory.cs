using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Expressions.Matches.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Expressions.Matches.Interfaces.IMatchExpression" />
    /// interface that correspond to the
    /// <see
    ///     cref="T:MFR.Operations.Constants.OperationType.RenameSolutionFolders" />
    /// operation type.
    /// </summary>
    public class
        SolutionFolderNameReplacementMatchExpressionFactory :
            FileAndFolderMatchExpressionFactoryBase
    {
        /// <summary>
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override OperationType OperationType
        { get; } = OperationType.RenameSolutionFolders;
    }
}