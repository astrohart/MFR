using MFR.GUI.Windows.Constants;
using System;
using System.Configuration;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Windows.Actions
{
    /// <summary>
    /// Exposes static methods to obtain various quantities.
    /// </summary>
    public static class Get
    {
        /// <summary>
        /// Attempts to load the value of the <c>DESIGN_TIME_SCREEN_HEIGHT</c> metric from
        /// the <c>app.config</c> file.
        /// </summary>
        /// <returns>
        /// If successful, the value of the <c>DESIGN_TIME_SCREEN_HEIGHT</c>
        /// metric from the <c>app.config</c> file; otherwise zero..
        /// </returns>
        public static float DesignTimeScreenHeight()
        {
            var result = 0F;

            try
            {
                if (ConfigurationManager.AppSettings == null) return result;
                if (!ConfigurationManager.AppSettings.HasKeys()) return result;
                if (!ConfigurationManager.AppSettings.AllKeys.Contains(
                        DesignTimeScreenMetric.Height
                    ))
                    return result;

                var heightValue = ConfigurationManager.AppSettings[
                    DesignTimeScreenMetric.Height];

                // Dump the variable heightValue to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"Get.DesignTimeScreenHeight: heightValue = '{heightValue}'"
                );

                if (string.IsNullOrWhiteSpace(heightValue)) return result;

                result = (float)Convert.ToDouble(heightValue);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = 0F;
            }

            return result;
        }

        /// <summary>
        /// Attempts to load the value of the <c>DESIGN_TIME_SCREEN_WIDTH</c> metric from
        /// the <c>app.config</c> file.
        /// </summary>
        /// <returns>
        /// If successful, the value of the <c>DESIGN_TIME_SCREEN_WIDTH</c>
        /// metric from the <c>app.config</c> file; otherwise zero..
        /// </returns>
        public static float DesignTimeScreenWidth()
        {
            var result = 0F;

            try
            {
                if (ConfigurationManager.AppSettings == null) return result;
                if (!ConfigurationManager.AppSettings.HasKeys()) return result;
                if (!ConfigurationManager.AppSettings.AllKeys.Contains(
                        DesignTimeScreenMetric.Width
                    ))
                    return result;

                var widthValue = ConfigurationManager.AppSettings[
                    DesignTimeScreenMetric.Width];

                // Dump the variable heightValue to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"Get.DesignTimeScreenWidth: widthValue = '{widthValue}'"
                );

                if (string.IsNullOrWhiteSpace(widthValue)) return result;

                result = (float)Convert.ToDouble(widthValue);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = 0F;
            }

            return result;
        }
    }
}