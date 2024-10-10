using PostSharp.Patterns.Threading;
using MFR.FileSystem.Retrievers.Factories;
using MFR.Operations.Constants;
using MFR.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using Path = Alphaleonis.Win32.Filesystem.Path;

namespace MFR.FileSystem.Retrievers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.FileSystem.Retrievers.SolutionFilePathRetriever" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class SolutionFilePathRetrieverTests
    {
        /// <summary>
        /// String containing the path to the root folder to use for the search.
        /// </summary>
        private static readonly string ROOT_FOLDER = Path.Combine(
            Environment.ExpandEnvironmentVariables("%USERPROFILE%"),
            @"source\repos\astrohart"
        );

        /// <summary>
        /// Unit test to ensure that the object used to retrieve solution file pathnames
        /// works correctly.
        /// </summary>
        [Test]
        public void Test_Retriever_Works()
        {
            Assert.That(!string.IsNullOrWhiteSpace(ROOT_FOLDER));

            Assert.That(Directory.Exists(ROOT_FOLDER));

            /*
             * Have the retriever scan the ROOT_FOLDER for the pathnames
             * of all *.sln files within, including sub-folders. Then,
             * write them all out to the console.
             */
            var paths = new List<string>();

            Assert.DoesNotThrow(
                () => paths = GetFileSystemEntryListRetriever.For(
                        OperationType.ScanDirectoryTreeForSolutionFiles
                    )
                    .WithSearchOption(SearchOption.AllDirectories)
                    .GetMatchingFileSystemPaths(ROOT_FOLDER)
                    .Select(fse => fse.Path)
                    .ToList()
            );

            /*
             * Ensure that the paths variable does not have a null reference.
             * The call above should have worked and given us a list of
             * pathnames.
             */
            Assert.That(paths, Is.Not.Null);

            /*
             * Check that more than zero pathnames were returned.
             */
            Assert.That(paths.Any());

            /*
             * Check that all the pathnames end with the .sln file
             * extension.
             */

            Assert.That(
                paths.All(s => ".sln".Equals(Path.GetExtension(s)))
            );

            this.DumpStringsToConsole(paths);
        }
    }
}