using PostSharp.Patterns.Threading;
using MFR.FileSystem.Filters.Factories;
using NUnit.Framework;
using System;

namespace MFR.FileSystem.Filters.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.FileSystem.Filters.FolderFilter" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class FolderFilterTests
    {
        private static readonly string SEARCH_PATH =
            Environment.ExpandEnvironmentVariables("%WINDIR%");

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Filters.Interfaces.IFolderFilter.Folder" /> method
        /// correctly states tha the C:\WINDOWS folder contains the C:\WINDOWS\System32
        /// folder.
        /// </summary>
        [Test]
        public void
            Test_Contains_Folder_Method_ReturnsTrue_For_Folder_KnownToBeContained_Inside_AnotherFolder()
            => Assert.That(
                Folder.HavingPath(SEARCH_PATH)
                      .Contains.Folder("System32")
            );
    }
}