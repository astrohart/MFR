using PostSharp.Patterns.Diagnostics;
using System;
using System.Configuration;
using System.Drawing;
using xyLOGIX.Core.Debug;

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
        private readonly float _designTimeWidth = (float)Convert.ToDouble(
            ConfigurationManager.AppSettings["DESIGN_TIME_SCREEN_WIDTH"]
        );

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
        }

        /// <summary>
        /// Gets a <see cref="T:System.Drawing.Rectangle" /> that displays the resolution
        /// of the current monitor.
        /// </summary>
        public Rectangle Resolution
        {
            get;
        }

        public int GetMetrics(int ComponentValue)
            => (int)Math.Floor(ComponentValue * _widthMultiplicationFactor);

        public int GetMetrics(int ComponentValue, string Direction)
        {
            if (Direction.Equals("Width") || Direction.Equals("Left"))
                return (int)Math.Floor(
                    ComponentValue * _widthMultiplicationFactor
                );
            if (Direction.Equals("Height") || Direction.Equals("Top"))
                return (int)Math.Floor(
                    ComponentValue * _heightMultiplicationFactor
                );
            return 1;
        }

        public void SetMultiplicationFactor()
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In Responsive.SetMultiplicationFactor"
            );

            // Dump the variable Resolution.Width to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Responsive.SetMultiplicationFactor: Resolution.Width = {Resolution.Width}"
            );

            // Dump the variable _designTimeWidth to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Responsive.SetMultiplicationFactor: _designTimeWidth = {_designTimeWidth}"
            );

            _widthMultiplicationFactor = Resolution.Width / _designTimeWidth;

            // Dump the variable _widthMultiplicationFactor to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Responsive.SetMultiplicationFactor: _widthMultiplicationFactor = {_widthMultiplicationFactor}"
            );

            // Dump the variable Resolution.Height to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Responsive.SetMultiplicationFactor: Resolution.Height = {Resolution.Height}"
            );

            // Dump the variable _designTimeHeight to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Responsive.SetMultiplicationFactor: _designTimeHeight = {_designTimeHeight}"
            );

            _heightMultiplicationFactor = Resolution.Height / _designTimeHeight;

            // Dump the variable _heightMultiplicationFactor to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"Responsive.SetMultiplicationFactor: _heightMultiplicationFactor = {_heightMultiplicationFactor}"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "Responsive.SetMultiplicationFactor: Done."
            );
        }
    }
}