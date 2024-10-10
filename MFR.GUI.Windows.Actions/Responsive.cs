using MFR.GUI.Windows.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Drawing;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.GUI.Windows.Actions
{
    /// <summary>
    /// Exposes methods and properties to support design of responsive forms, i.e.,
    /// Windows Forms that automatically resize and rescale themselves when they are
    /// dragged from a monitor with one screen resolution to another monitor having a
    /// different screen resolution.
    /// </summary>
    [Log(AttributeExclude = true)]
    public class Responsive
    {
        /// <summary>
        /// A <see cref="T:System.Single" /> value that contains the value of the
        /// <c>DESIGN_TIME_SCREEN_HEIGHT</c> metric from the <c>app.config</c> file, or
        /// zero if not found.
        /// </summary>
        private readonly float _designTimeHeight = Get.DesignTimeScreenHeight();

        /// <summary>
        /// A <see cref="T:System.Single" /> value that contains the value of the
        /// <c>DESIGN_TIME_SCREEN_WIDTH</c> metric from the <c>app.config</c> file, or
        /// zero if not found.
        /// </summary>
        private readonly float _designTimeWidth = Get.DesignTimeScreenWidth();

        /// <summary>
        /// A <see cref="T:System.Single" /> value that contains the multiplication factor
        /// for responsive heights.
        /// </summary>
        private float _heightMultiplicationFactor;

        /// <summary>
        /// A <see cref="T:System.Single" /> value that contains the multiplication factor
        /// for responsive widths.
        /// </summary>
        private float _widthMultiplicationFactor;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Windows.Actions.Responsive" /> and returns a reference to
        /// it.
        /// </summary>
        public Responsive(Rectangle resolution)
        {
            Resolution = resolution;
            SetMultiplicationFactors();
        }

        /// <summary>
        /// Gets a <see cref="T:System.Drawing.Rectangle" /> that displays the resolution
        /// of the current monitor.
        /// </summary>
        public Rectangle Resolution
        {
            get;
        }

        public int GetSizeMetrics(
            int componentValue,
            ScalingDirection direction
        )
        {
            var result = componentValue;

            try
            {
                if (!Enum.IsDefined(typeof(ScalingDirection), direction))
                    return result;
                if (ScalingDirection.Unknown == direction) return result;
                if (componentValue <= 0) return result;

                if (direction.IsAnyOf(
                        ScalingDirection.Width, ScalingDirection.Left
                    ))
                    result = Compute.ScaledComponentValue(
                        componentValue, _widthMultiplicationFactor
                    );
                else if (direction.IsAnyOf(
                             ScalingDirection.Height, ScalingDirection.Top
                         ))
                    result = Compute.ScaledComponentValue(
                        componentValue, _heightMultiplicationFactor
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = componentValue;
            }

            return result;
        }

        private void SetMultiplicationFactors()
        {
            try
            {
                _widthMultiplicationFactor =
                    Resolution.Width / _designTimeWidth;

                _heightMultiplicationFactor =
                    Resolution.Height / _designTimeHeight;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}