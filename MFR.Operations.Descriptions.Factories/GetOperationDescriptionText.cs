using MFR.Operations.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Operations.Descriptions.Factories
{
    /// <summary>
    /// Obtains descriptive text <see cref="T:System.String" /> values that explain the
    /// type of operation that is now being performed by the application.
    /// </summary>
    public static class GetOperationDescriptionText
    {
        /// <summary>
        /// Gets a text <see cref="T:System.String" /> value that contains user-friendly
        /// text to describe that the application is now performing the operation of the
        /// specified <paramref name="type" />.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see cref="T:MFR.Operations.Constants.OperationType" /> enumeration values that
        /// describes what type of operation the application is performing.
        /// </param>
        /// <returns></returns>
        /// <remarks>
        /// If the specified <paramref name="type" /> of operation is not supported, then
        /// this method returns <see cref="F:System.String.Empty" />.
        /// </remarks>
        public static string For(OperationType type)
        {
            var result = string.Empty;

            try
            {
                var operationDescription = GetOperationDescription.For(type);
                if (operationDescription == null) return result;

                result = operationDescription.Text;
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