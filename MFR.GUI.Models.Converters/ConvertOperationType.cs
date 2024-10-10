using PostSharp.Patterns.Threading;
using MFR.GUI.Models.Constants.Factories;
using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Models.Converters
{
    /// <summary>
    /// Methods for converting <see cref="T:MFR.Operations.Constants.OperationType" />
    /// values to descriptive strings.
    /// </summary>
    [Log(AttributeExclude = true)]
    [ExplicitlySynchronized]
    public static class ConvertOperationType
    {
        /// <summary>
        /// Converts the specified <see cref="T:MFR.Operations.Constants.OperationType" />
        /// value into a descriptive string, e.g., for display in a GUI.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the supported
        /// <see cref="T:MFR.Operations.Constants.OperationType" /> values.
        /// </param>
        /// <returns>
        /// If a supported <see cref="T:MFR.Operations.Constants.OperationType" />
        /// value is passed for the <paramref name="type" /> parameter, then a descriptive
        /// string corresponding to it is returned.
        /// <para />
        /// Otherwise, the return value is the <see cref="F:System.String.Empty" /> value.
        /// </returns>
        public static string ToString(OperationType type)
        {
            var result = string.Empty;

            try
            {
                result = GetOperationName.For(type);
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