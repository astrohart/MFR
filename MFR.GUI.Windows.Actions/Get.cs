using MFR.GUI.Windows.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MFR.GUI.Windows.Actions
{
    /// <summary>
    /// Exposes static methods to obtain various quantities.
    /// </summary>
    [Log(AttributeExclude = true)]
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

        /// <summary>
        /// Gets a <see cref="T:System.Drawing.Rectangle" /> that expresses the bounds of
        /// the first element of the
        /// <see cref="P:System.Windows.Forms.Screen.AllScreens" /> list --- which, itself,
        /// represents the set of all monitors that the user has connected to this machine.
        /// </summary>
        /// <param name="control">
        /// (Optional.) A <see cref="T:System.Windows.Forms.Control" /> that is on the
        /// screen that you wish to get the bounds for.
        /// <para />
        /// The default value of this property is <see langword="null" />.  In that event,
        /// then the method finds the first screen in the list, and returns its bounds.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.Drawing.Rectangle" /> that expresses the
        /// bounds of the first element of the
        /// <see cref="P:System.Windows.Forms.Screen.AllScreens" /> list --- which, itself,
        /// represents the set of all monitors that the user has connected to this machine;
        /// otherwise, the <see cref="F:System.Drawing.Rectangle.Empty" /> value.
        /// </returns>
        public static Rectangle ReferenceScreenBounds(Control control = null)
        {
            var result = Rectangle.Empty;

            try
            {
                if (!Screen.AllScreens.Any()) return result;

                /*
                result = control == null
                    ? Screen.AllScreens[0]
                            .Bounds
                    : Screen.FromControl(control)
                            .Bounds;
                */

                result = Screen.AllScreens.First()
                               .Bounds;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Rectangle.Empty;
            }

            return result;
        }
    }
}