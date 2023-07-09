using MFR.GUI.Windows.Actions;
using MFR.GUI.Windows.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.UI.Dark.Forms;

namespace MFR.GUI.Windows
{
    /// <summary>
    /// This class is designed to be inherited from when you need a Windows Form to
    /// look the same on monitors of different resolutions.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class ResponsiveFormBase : DarkForm
    {
        /// <summary>
        /// Reference to an instance of <see cref="T:MFR.GUI.Windows.Actions.Responsive" />
        /// that supports this form's functionality.
        /// </summary>
        private readonly Responsive _responsiveObj;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Windows.ResponsiveFormBase" /> and returns a reference to
        /// it.
        /// </summary>
        protected ResponsiveFormBase()
        {
            _responsiveObj = new Responsive(
                Get.ReferenceScreenBounds()
            );
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
            if (!Screen.AllScreens.Any() || Screen.AllScreens.Length <= 1)
            {
                // do not have to worry about responsive metrics in this case
                StartPosition = ParentForm == null
                    ? FormStartPosition.CenterScreen
                    : FormStartPosition.CenterParent;
                return;
            }

            Location = Screen.AllScreens[1]
                             .WorkingArea.Location;

            // Form width and height set up.
            Width = _responsiveObj.GetSizeMetrics(
                Width, ScalingDirection.Width
            ); 
            Height = _responsiveObj.GetSizeMetrics(Height, 
                ScalingDirection.Height
            );

            StartPosition = previousStartPosition;

            InstallMetrics(Controls);
        }

        /// <summary>
        /// Called to recursively adjust the width and height of controls according to the
        /// current screen metrics.
        /// </summary>
        /// <param name="controls">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Collections.ICollection" /> interface, and which represents
        /// the collection of <see cref="T:System.Windows.Forms.Control" /> instances on
        /// which to act.
        /// </param>
        private void InstallMetrics(ICollection controls)
        {
            if (controls == null || controls.Count == 0) return;

            foreach (var control in controls.Cast<Control>())
            {
                control.Width = _responsiveObj.GetSizeMetrics(
                    control.Width, ScalingDirection.Width
                );
                control.Height = _responsiveObj.GetSizeMetrics(
                    control.Height, ScalingDirection.Height
                );

                InstallMetrics(
                    control.Controls
                ); // recurse through entire control tree
            }
        }
    }
}