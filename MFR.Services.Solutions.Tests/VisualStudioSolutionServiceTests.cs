using Alphaleonis.Win32.Filesystem;
using MFR.Services.Solutions.Factories;
using MFR.Tests.Common;
using NUnit.Framework;
using PostSharp.Patterns.Threading;
using Does = MFR.Services.Solutions.Factories.Actions.Does;

namespace MFR.Services.Solutions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Services.Solutions.VisualStudioSolutionService" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class VisualStudioSolutionServiceTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Services.Solutions.VisualStudioSolutionService.ContainsLoadedSolutions" />
        /// method returns <see langword="true" /> when it's asked to scan for loaded
        /// solutions from the folder in which this solution is being executed.
        /// </summary>
        [Test]
        public void Test_ContainsLoadedSolutions_ForMFRFolder_ReturnsTrue()

        {
            Assert.That(
                Directory.Exists(
                    StringConstants
                        .MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_FOLDER
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

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService.ContainLoadedSolutions" />
        /// method returns <see langword="true" /> when passed the path of a folder that is
        /// known to exist and contain <c>.sln</c> files.
        /// </summary>
        [Test]
        public void
            Test_ContainsLoadedSolutions_Works_If_FolderToSearch_Property_IsSet()
        {
            Assert.That(
                Directory.Exists(
                    StringConstants
                        .MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_FOLDER
                )
            );

            Assert.That(
                Does.Folder(
                        StringConstants
                            .MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_FOLDER
                    )
                    .ContainLoadedSolutions()
            );
        }
    }
}