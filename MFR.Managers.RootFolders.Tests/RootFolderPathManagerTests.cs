using MFR.FileSystem.Enumerators;
using MFR.FileSystem.Validators.Factories;
using MFR.Managers.RootFolders.Events;
using MFR.Managers.RootFolders.Factories;
using MFR.Managers.RootFolders.Interfaces;
using MFR.Operations.Constants;
using MFR.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.Managers.RootFolders.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Managers.RootFolders.RootFolderPathManager" /> class.
    /// </summary>
    [TestFixture]
    public class RootFolderPathManagerTests : DebuggableTestFixture
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public override void Initialize()
        {
            base.Initialize();

            RootFolderPathManager.RootFolderAdded +=
                OnRootFolderPathManagerRootFolderAdded;
        }

        /// <summary>
        /// String containing the path to a dummy folder.
        /// </summary>
        public static readonly string DUMMY_FOLDER =
            Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Documents");

        /// <summary>
        /// String containing the path to a dummy folder that is guaranteed to contain only
        /// a single solution.
        /// </summary>
        public static readonly string
            DUMMY_FOLDER_THAT_CONTAINS_A_SINGLE_SOLUTION =
                Environment.ExpandEnvironmentVariables(
                    @"%USERPROFILE%\source\repos\astrohart\xyLOGIXCheckedListBoxTester"
                );

        /// <summary>
        /// String containing the path to a dummy folder.
        /// </summary>
        public static readonly string
            DUMMY_FOLDER_THAT_CONTAINS_SOLUTION_FOLDERS =
                Environment.ExpandEnvironmentVariables(
                    @"%USERPROFILE%\source\repos\astrohart"
                );

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager" />
        /// interface.
        /// </summary>
        private static IRootFolderPathManager RootFolderPathManager
            => GetRootFolderPathManager.SoleInstance();

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.AddFolderIfItContainsASolution" />
        /// method correctly adds the folder having the path
        /// <see
        ///     cref="F:MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.DUMMY_FOLDER_THAT_CONTAINS_A_SINGLE_SOLUTION" />
        /// because it is known to contain a <c>.sln</c> file.
        /// </summary>
        [Test]
        public void Test_AddFolderIfItContainsASolution_Method_Works()
        {
            var expectedCount = 1;

            Assert.That(expectedCount, Is.EqualTo(1));
            Assert.That(
                Directory.Exists(DUMMY_FOLDER_THAT_CONTAINS_A_SINGLE_SOLUTION)
            );

            var actualCount = 0;

            Assert.DoesNotThrow(
                () => actualCount =
                    RootFolderPathManager.AddFolderIfItContainsASolution(
                        DUMMY_FOLDER_THAT_CONTAINS_A_SINGLE_SOLUTION
                    )
            );

            Assert.That(actualCount, Is.EqualTo(expectedCount));
            Assert.That(RootFolderPathManager.Count, Is.EqualTo(actualCount));

            RootFolderPathManager.Clear();
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.AddSolutionSubFoldersOf" />
        /// method works properly.
        /// </summary>
        [Test]
        [Obsolete]
        public void Test_AddSolutionSubFoldersOf_Method_Works()
        {
            Assert.That(
                Directory.Exists(DUMMY_FOLDER_THAT_CONTAINS_SOLUTION_FOLDERS)
            );

            var expectedCount =
                GetAllSubFoldersThatContainSolutionsIn(
                        DUMMY_FOLDER_THAT_CONTAINS_SOLUTION_FOLDERS
                    )
                    .Count();
            Assert.That(expectedCount > 0);

            var actualCount = 0;

            Assert.DoesNotThrow(
                () => actualCount =
                    RootFolderPathManager.AddSolutionSubFoldersOf(
                        DUMMY_FOLDER_THAT_CONTAINS_SOLUTION_FOLDERS
                    )
            );

            Assert.That(actualCount > 0);
            Assert.That(actualCount, Is.EqualTo(expectedCount));
            Assert.That(RootFolderPathManager.Count, Is.EqualTo(actualCount));

            RootFolderPathManager.Clear();

            expectedCount = GetAllSubFoldersThatContainSolutionsIn(DUMMY_FOLDER)
                .Count();

            Assert.That(expectedCount, Is.EqualTo(0));

            actualCount = 0;

            Assert.DoesNotThrow(
                () => actualCount =
                    RootFolderPathManager.AddSolutionSubFoldersOf(DUMMY_FOLDER)
            );

            Assert.That(actualCount, Is.EqualTo(0));
            Assert.That(actualCount, Is.EqualTo(expectedCount));
            Assert.That(RootFolderPathManager.Count, Is.EqualTo(actualCount));

            RootFolderPathManager.Clear();
        }

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.Managers.RootFolders.RootFolderPathManager.AddSubFoldersOf" />
        /// method works properly.
        /// <para />
        /// In this case, that it adds all the top-level folders of the
        /// <see
        ///     cref="F:MFR.Managers.RootFolders.Tests.RootFolderPathManagerTests.DUMMY_FOLDER" />
        /// to the list maintained by the
        /// <see cref="T:MFR.Managers.RootFolders.RootFolderPathManager" /> object.
        /// </summary>
        [Test]
        public void Test_AddSubFoldersOf_Method_Works()
        {
            Assert.That(Directory.Exists(DUMMY_FOLDER));

            var expectedCount = GetSubFoldersOf(DUMMY_FOLDER)
                .Count();
            Assert.That(expectedCount > 0);

            var actualCount = 0;

            Assert.DoesNotThrow(
                () => actualCount =
                    RootFolderPathManager.AddSubFoldersOf(DUMMY_FOLDER)
            );

            Assert.That(actualCount > 0);
            Assert.That(actualCount, Is.EqualTo(expectedCount));
            Assert.That(RootFolderPathManager.Count, Is.EqualTo(expectedCount));
        }

        /// <summary>
        /// Retrieves a list of the top-level folders of the folder having the specified
        /// <paramref name="path" />, the criteria for being in the set of returned strings
        /// being that the folder must contain a file whose name ends with the <c>.sln</c>
        /// extension.
        /// </summary>
        /// <param name="path">
        /// (Required.) (Required.) String containing the
        /// fully-qualified pathname of the folder whose subfolers are to be enumerated.
        /// </param>
        /// <returns>
        /// Collection of strings containing the fully-qualified pathnames of all
        /// top-level subfolders of the folder having the specified
        /// <paramref name="path" /> that contain at least one file whose name has the
        /// extension <c>.sln</c>.
        /// </returns>
        [Obsolete]
        private static IEnumerable<string>
            GetAllSubFoldersThatContainSolutionsIn(string path)
        {
            var result = Enumerable.Empty<string>();

            if (string.IsNullOrWhiteSpace(path)) return result;

            try
            {
                result = GetSubFoldersOf(path)
                    .Where(
                        s => Enumerate.Files(
                                          s, "*.sln",
                                          SearchOption.AllDirectories
                                      )
                                      .Any()
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Enumerable.Empty<string>();
            }

            return result;
        }

        /// <summary>
        /// Obtains a reference to a collection of strings that are the fully-qualified
        /// pathnames of the subfolders of the folder having the specified
        /// <paramref name="path" />, to the first level down only.
        /// </summary>
        /// <param name="path">
        /// (Required.) (Required.) String containing the
        /// fully-qualified pathname of the folder to start searching in.
        /// </param>
        /// <returns>
        /// Collection of strings; this collection is the empty set if an error
        /// occurs or the <paramref name="path" /> parameter is blank, or whose value
        /// refers to a folder that does not exist on the disk; otherwise, a collection of
        /// strings containing the pathnames of all of the top-level subfolders of the
        /// folder having the specified <paramref name="path" /> is returned.
        /// <para />
        /// The empty collection is also returned if an I/O or other operating-system error
        /// occurs during the execution of the search.
        /// </returns>
        private static IEnumerable<string> GetSubFoldersOf(string path)
        {
            var result = Enumerable.Empty<string>();

            if (string.IsNullOrWhiteSpace(path)) return result;

            try
            {
                if (!Directory.Exists(path))
                    return result;

                result = Enumerate.Directories(
                                      path, "*", SearchOption.TopDirectoryOnly
                                  )
                                  .Where(
                                      s => GetFileSystemEntryValidator.For(
                                              OperationType
                                                  .GetTopLevelSubFolders
                                          )
                                          .ShouldNotSkip(s)
                                  );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = Enumerable.Empty<string>();
            }

            return result;
        }

        /// <summary>
        /// Handles the
        /// <see
        ///     cref="E:MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager.RootFolderAdded" />
        /// event raised by the Root Folder Path Manager object.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.Managers.RootFolders.Events.RootFolderAddedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// This method responds by writing the pathname of the folder that has
        /// been added to the manager's collection, to the console output.
        /// </remarks>
        private void OnRootFolderPathManagerRootFolderAdded(object sender,
            RootFolderAddedEventArgs e)
            => Console.WriteLine(e.Path);
    }
}