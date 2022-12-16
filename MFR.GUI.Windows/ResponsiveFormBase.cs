using MFR.GUI.Windows.Actions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MFR.GUI.Windows
{
    public class ResponsiveFormBase : Form
    {
        private readonly Responsive _responsiveObj;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Windows.ResponsiveFormBase" /> and returns a reference to
        /// it.
        /// </summary>
        protected ResponsiveFormBase()
        {
            _responsiveObj = new Responsive(
                Screen.AllScreens[0]
                      .Bounds
            );
            _responsiveObj.SetMultiplicationFactor();
        }

        /// <summary>Raises the <see cref="E:System.Windows.Forms.Form.Load" /> event.</summary>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var previousStartPosition = StartPosition;

            StartPosition = FormStartPosition.Manual;

            Location = Screen.AllScreens[1]
                             .WorkingArea.Location;

            Width = _responsiveObj.GetMetrics(
                Width, "Width"
            ); // Form width and height set up.
            Height = _responsiveObj.GetMetrics(Height, "Height");

            StartPosition = previousStartPosition;

            InstallMetrics(Controls);
        }

        private void InstallMetrics(ICollection controls)
        {
            if (controls == null || controls.Count == 0) return;

            foreach (var control in controls.Cast<Control>())
            {
                //control.Font = new Font(
                //    control.Font.FontFamily,
                //    _responsiveObj.GetMetrics((int)control.Font.Size), control.Font.Style
                //);
                
                control.Width = _responsiveObj.GetMetrics(control.Width, "Width");
                control.Height = _responsiveObj.GetMetrics(control.Height, "Height");
                //control.Top = _responsiveObj.GetMetrics(control.Top, "Top");
                //control.Left = _responsiveObj.GetMetrics(control.Left, "Left");

                InstallMetrics(control.Controls);   // recurse through entire control tree
            }
        }
    }
}