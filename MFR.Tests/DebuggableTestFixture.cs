using xyLOGIX.Core.Debug;

namespace MFR.Tests
{
    /// <summary>
    /// Base class for a test fixture that can use the standard
    /// <see cref="T:xyLOGIX.Core.Debug.DebugUtils" />-based infrastructure to write
    /// messages to the console.
    /// </summary>
    public abstract class DebuggableTestFixture
    {
        /// <summary>
        /// Method that sets up the logging infrastructure for use with a child test
        /// fixture.
        /// <para />
        /// Child classes may override this method to run additional
        /// set-up logic.
        /// </summary>
        public virtual void Initialize()
        {
            LogFileManager.SetUpDebugUtils(false, true, true);

            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In DebuggableTestFixture.Initialize"
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "DebuggableTestFixture.Initialize: Done."
            );
        }
    }
}