/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */using MFR.GUI.Windows.Constants;
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