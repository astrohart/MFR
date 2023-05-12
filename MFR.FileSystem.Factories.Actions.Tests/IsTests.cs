using NUnit.Framework;
using System;
using System.IO;

namespace MFR.FileSystem.Factories.Actions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.FileSystem.Factories.Actions.Is" /> class.
    /// </summary>
    [TestFixture]
    public class IsTests
    {
        /// <summary>
        /// A <see cref="T:System.String" /> that contains the fully-qualified path of a
        /// folder, i.e., <c>C:\WINDOWS</c>, that is guaranteed to exist.
        /// </summary>
        private static readonly string DIRECTORY_THAT_EXISTS =
            Environment.GetFolderPath(Environment.SpecialFolder.Windows);

        /// <summary>
        /// A <see cref="T:System.String" /> that is guaranteed to contain the pathname of
        /// a folder that does not exist.
        /// </summary>
        private static readonly string FAKE_DIRECTORY =
            $@"C:\{Guid.NewGuid():N}";

        /// <summary>
        /// A <see cref="T:System.String" /> that holds the pathname of a file that is
        /// guaranteed not to exist.
        /// </summary>
        private static readonly string FAKE_FILE = Path.Combine(
            FAKE_DIRECTORY, Guid.NewGuid()
                                .ToString("N") + ".txt"
        );

        /// <summary>
        /// A <see cref="T:System.String" /> that holds the pathname of a file tht is
        /// guaranteed to exist.
        /// </summary>
        private static readonly string FILE_THAT_EXISTS = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Windows),
            @"System32\cmd.exe"
        );

        /// <summary>
        /// Asserts that the <see cref="M:MFR.FileSystem.Factories.Actions.Is.Folder" />
        /// method returns <see langword="false" /> for the folder whose pathname is
        /// contained within the
        /// <see
        ///     cref="F:MFR.FileSystem.Factories.Actions.Tests.IsTests.FAKE_DIRECTORY" />
        /// field.
        /// </summary>
        [Test]
        public void Test_IsFolder_ReturnsFalse_For_FakeDirectory()
        {
            Assert.IsNotEmpty(FAKE_DIRECTORY);
            Assert.IsFalse(Directory.Exists(FAKE_DIRECTORY));
            Assert.IsFalse(Is.Folder(FAKE_DIRECTORY));
        }

        /// <summary>
        /// Asserts that the <see cref="M:MFR.FileSystem.Factories.Actions.Is.Folder" />
        /// method returns <see langword="false" /> for the folder whose pathname is
        /// contained within the
        /// <see
        ///     cref="F:MFR.FileSystem.Factories.Actions.Tests.IsTests.FAKE_FILE" />
        /// field.
        /// </summary>
        [Test]
        public void Test_IsFolder_ReturnsFalse_For_FakeFile()
        {
            Assert.IsNotEmpty(FAKE_FILE);
            Assert.IsFalse(File.Exists(FAKE_FILE));
            Assert.IsFalse(Is.Folder(FAKE_FILE));
        }

        /// <summary>
        /// Asserts that the <see cref="M:MFR.FileSystem.Factories.Actions.Is.Folder" />
        /// method returns <see langword="false" /> for the folder whose pathname is
        /// contained within the
        /// <see
        ///     cref="F:MFR.FileSystem.Factories.Actions.Tests.IsTests.FILE_THAT_EXISTS" />
        /// field (as it should, since the pathname is of a file, not a folder).
        /// </summary>
        [Test]
        public void Test_IsFolder_ReturnsFalse_For_FileThatExists()
        {
            Assert.IsNotEmpty(FILE_THAT_EXISTS);
            Assert.IsTrue(File.Exists(FILE_THAT_EXISTS));
            Assert.IsFalse(Is.Folder(FILE_THAT_EXISTS));
        }

        /// <summary>
        /// Asserts that the <see cref="M:MFR.FileSystem.Factories.Actions.Is.Folder" />
        /// method returns <see langword="true" /> for the folder whose pathname is
        /// contained within the
        /// <see
        ///     cref="F:MFR.FileSystem.Factories.Actions.Tests.IsTests.DIRECTORY_THAT_EXISTS" />
        /// field.
        /// </summary>
        [Test]
        public void Test_IsFolder_ReturnsTrue_For_DirectoryThatExists()
        {
            Assert.IsNotEmpty(DIRECTORY_THAT_EXISTS);
            Assert.IsTrue(Directory.Exists(DIRECTORY_THAT_EXISTS));
            Assert.IsTrue(Is.Folder(DIRECTORY_THAT_EXISTS));
        }
    }
}