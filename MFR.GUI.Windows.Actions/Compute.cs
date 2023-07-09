using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Windows.Actions
{
    /// <summary>
    /// Exposes static methods to compute the value of certain quantities.
    /// </summary>
    [Log(AttributeExclude = true)]
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
            var result = componentValue;

            try
            {
                var product = componentValue * multiplicationFactor;

                result = int.MinValue.Equals((int)Math.Floor(product))
                    ? componentValue
                    : (int)Math.Floor(product);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = componentValue;
            }

            return result;
        }
    }
}