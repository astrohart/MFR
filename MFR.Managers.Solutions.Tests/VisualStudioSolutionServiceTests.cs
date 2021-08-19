using Alphaleonis.Win32.Filesystem;
using MFR.Objects.Managers.Solutions.Factories;
using MFR.Objects.Tests.Common;
using NUnit.Framework;

namespace MFR.Objects.Managers.Solutions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.Managers.Solutions.VisualStudioSolutionService" />
    /// class.
    /// </summary>
    [TestFixture]
    public class VisualStudioSolutionServiceTests
    {
        /// <summary>
        /// Asserts that the <see cref="M:MFR.Objects.Managers.Solutions.VisualStudioSolutionService.ContainsLoadedSolutions"/> method returns <see langword="true" /> when it's asked to scan for loaded solutions from the folder in which this solution is being executed.
        /// </summary>
        [Test]
        public void Test_ContainsLoadedSolutions_ForMFRFolder_ReturnsTrue()

        {
            Assert.That(
                Directory.Exists(
                    StringConstants.MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_FOLDER
                    )
                );

            // If we are running this test, in all likelihood it's being done in the 
            // Visual Studio instance that has the MFR project solution already loaded.
            // So we scan the .sln files in the MFR project folder to test that the method
            // works.

            Assert.That(
                GetVisualStudioSolutionService.SoleInstance()
                                              .ContainsLoadedSolutions(
                                                  StringConstants
                                                      .MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_FOLDER
                                              )
            );
        }
    }
}