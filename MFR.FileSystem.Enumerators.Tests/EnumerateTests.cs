using PostSharp.Patterns.Threading;
using MFR.FileSystem.Enumerators.Tests.Constants;
using NUnit.Framework;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MFR.FileSystem.Enumerators.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.FileSystem.Enumerators.Enumerate" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class EnumerateTests
    {
        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Enumerators.Enumerate.Directories" /> method
        /// returns the empty collection when passed whitespace as input for the root
        /// folder.
        /// </summary>
        [Test]
        public void
            Test_Directories_Method_ThrowsArgumentException_WhenWhitespaceIsPassed()
            => Assert.That(
                Enumerate.Directories(
                    UnitTestStringConstants.WHITESPACE, "*",
                    SearchOption.TopDirectoryOnly
                ), Is.Empty
            );

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Enumerators.Enumerate.Directories" /> method
        /// returns the empty collection when passed a reference to the
        /// <see cref="F:System.String.Empty" /> field as input for the root folder.
        /// </summary>
        [Test]
        public void
            Test_Directories_Method_ThrowsArgumentException_WithBlankInput()
            => Assert.That(
                Enumerate.Directories(
                    UnitTestStringConstants.BLANK, "*",
                    SearchOption.TopDirectoryOnly
                ), Is.Empty
            );

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Enumerators.Enumerate.Directories" /> method
        /// returns the empty collection when passed <see langword="null" /> as input for
        /// them  root folder.
        /// </summary>
        [Test]
        public void
            Test_Directories_Method_ThrowsArgumentException_WithNullInput()
            => Assert.That(
                Enumerate.Directories(
                    UnitTestStringConstants.NULL, "*",
                    SearchOption.TopDirectoryOnly
                ), Is.Empty
            );

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Enumerators.Enumerate.Directories" /> method works
        /// and lists all the top level subfolders of the testing directory.
        /// </summary>
        [Test]
        public void Test_Directories_Method_Works_TopDirectoryOnly()
        {
            var folders = new ConcurrentBag<string>();

            Assert.DoesNotThrow(
                () =>
                {
                    var folderSet = Enumerate.Directories(
                        UnitTestStringConstants
                            .FOLDER_TO_TEST, "*",
                        SearchOption.TopDirectoryOnly
                    );

                    Parallel.ForEach(
                        folderSet, path =>
                        {
                            folders.Add(path);
                        }
                    );
                }
            );

            Assert.That(folders.ToArray().Length > 0);

            foreach (var folder in folders)
                Console.WriteLine(folder);
        }

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Enumerators.Enumerate.Files" /> method works
        /// and lists all the top level subfolders of the testing directory.
        /// </summary>
        [Test]
        public void Test_Files_Method_Works_TopDirectoryOnly()
        {
            var folders = new List<string>();

            Assert.DoesNotThrow(
                () => folders = Enumerate.Files(
                                             UnitTestStringConstants
                                                 .FOLDER_TO_TEST, "*",
                                             SearchOption.TopDirectoryOnly
                                         )
                                         .ToList()
            );

            Assert.That(folders.Any());

            foreach (var folder in folders)
                Console.WriteLine(folder);
        }

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Enumerators.Enumerate.Files" /> method
        /// returns the empty collection when passed whitespace as input for the root
        /// folder.
        /// </summary>
        [Test]
        public void
            Test_Files_Method_ThrowsArgumentException_WhenWhitespaceIsPassed()
            => Assert.That(
                Enumerate.Files(
                    UnitTestStringConstants.WHITESPACE, "*",
                    SearchOption.TopDirectoryOnly
                ), Is.Empty
            );

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Enumerators.Enumerate.Files" /> method
        /// returns the empty collection when passed a reference to the
        /// <see cref="F:System.String.Empty" /> field as input for the root folder.
        /// </summary>
        [Test]
        public void Test_Files_Method_ThrowsArgumentException_WithBlankInput()
            => Assert.That(
                Enumerate.Files(
                    UnitTestStringConstants.BLANK, "*",
                    SearchOption.TopDirectoryOnly
                ), Is.Empty
            );

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.FileSystem.Enumerators.Enumerate.Files" /> method
        /// returns the empty collection when passed <see langword="null" /> as input for
        /// them  root folder.
        /// </summary>
        [Test]
        public void Test_Files_Method_ThrowsArgumentException_WithNullInput()
            => Assert.That(
                Enumerate.Files(
                    UnitTestStringConstants.NULL, "*",
                    SearchOption.TopDirectoryOnly
                ), Is.Empty
            );
    }
}
