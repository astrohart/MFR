using System;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Windows.Actions
{
    /// <summary>
    /// Exposes static methods to compute the value of certain quantities.
    /// </summary>
    public static class Compute
    {
        /// <summary>
        /// Computes the scaled value for a form's width or height.
        /// </summary>
        /// <param name="componentValue">(Required.) The value to be scaled.</param>
        /// <param name="multiplicationFactor">(Required.) The scaling factor to be used.</param>
        /// <returns>
        /// A <see cref="T:System.Int32" /> value that is set to the mathematical
        /// floor of the product of <paramref name="componentValue" /> and
        /// <paramref name="multiplicationFactor" />.
        /// </returns>
        public static int ScaledComponentValue(
            int componentValue,
            float multiplicationFactor
        )
        {
            int result;

            try
            {
                result = (int)Math.Floor(componentValue * multiplicationFactor);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = 0;
            }

            return result;
        }
    }
}