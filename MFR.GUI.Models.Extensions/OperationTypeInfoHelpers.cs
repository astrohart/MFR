using MFR.GUI.Models.Interfaces;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Models.Extensions
{
    /// <summary>
    /// Exposes static methods that extend the
    /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> class.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class OperationTypeInfoHelpers
    {
        /// <summary>
        /// Determines if the collection coming from the specified
        /// <paramref name="source" /> has more than zero elements.
        /// </summary>
        /// <param name="source">
        /// (Required.) A collection of instances of
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> instances.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the <paramref name="source" /> has more
        /// than zero elements; <see langword="false" /> otherwise.
        /// </returns>
        public static bool HasAnyOperations(
            this IList<IOperationTypeInfo> source)
        {
            var result = false;

            try
            {
                result = source != null && source.Any();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="operationTypeInfo" />
        /// represents state for the specified <paramref name="operationType" />.
        /// </summary>
        /// <param name="operationTypeInfo">
        /// (Required.) An
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> that specifies the, e.g.,
        /// enabled/disabled state for the specified operation.
        /// </param>
        /// <param name="operationType">
        /// (Required.) One of the
        /// <see cref="T:MFR.Operations.Constants.OperationType" /> enumeration values that
        /// explains what type of operation this object represents.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> instance corresponds to the
        /// specified <paramref name="operationType" />; <see langword="false" />
        /// otherwise.
        /// </returns>
        /// <remarks>
        /// This method also returns <see langword="false" /> in the event that the
        /// <paramref name="operationTypeInfo" /> is passed <see langword="null" /> for its
        /// argument.
        /// </remarks>
        public static bool IsOfType(this IOperationTypeInfo operationTypeInfo,
            OperationType operationType)
            => operationTypeInfo != null &&
               operationType.Equals(operationTypeInfo.OperationType);
    }
}