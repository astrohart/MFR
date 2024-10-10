using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Obtains text strings for the operations that this application performs, that
    /// indicate that the desired operation is about to begin.
    /// <para />
    /// Such messages are useful, e.g., for display on the console or in progress
    /// indicators.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetOperationStartedDescriptionText
    {
        /// <summary>
        /// Obtains text <see cref="T:System.String" />s that indicate that the operation
        /// of the specified <paramref name="type" /> is about to begin.
        /// </summary>
        /// <param name="type">(Required.) </param>
        /// <returns></returns>
        public static string For(OperationType type)
        {
            var result = string.Empty;

            try
            {
                var operationStartedDescription =
                    GetOperationStartedDescription.For(type);
                if (operationStartedDescription == null) return result;

                result = operationStartedDescription.Text;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}