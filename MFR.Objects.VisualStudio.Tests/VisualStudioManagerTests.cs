using EnvDTE;
using MFR.Objects.Tests.Common;
using NUnit.Framework;
using Alphaleonis.Win32.Filesystem;

namespace MFR.Objects.VisualStudio.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.VisualStudioManager" />
    /// class.
    /// </summary>
    [TestFixture]
    public class VisualStudioManagerTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_GetVsProcessHavingSolutionOpened_Method_Works()
        {
            Assert.That(
                File.Exists(
                    StringConstants
                        .MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH
                )
            );

            /*
             * OKAY, the method called below looks at all the instances
             * of devenv.exe that are currently running on the local
             * machine.  It then asks each of these, if any are found,
             * if they have the solution with path
             * MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH open.  If
             * this is so, then an instance of an object that implements
             * the EnvDTE.DTE interface is returned.
             *
             * In this unit test, we know that this method should always
             * work as expected.  This is because, in order to run this
             * test, the solution having the path
             * MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH  must be open
             * in the first place, in a running instance of devenv.exe.
             */

            Assert.IsInstanceOf<DTE>(
                VisualStudioManager.GetVsProcessHavingSolutionOpened(
                    StringConstants
                        .MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH
                )
            );
        }
    }
}