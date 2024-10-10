using PostSharp.Patterns.Threading;
using MFR.Tests.Common;
using NUnit.Framework;
using System;
using System.IO;
using File = Alphaleonis.Win32.Filesystem.File;
using FileInfo = Alphaleonis.Win32.Filesystem.FileInfo;

namespace MFR.FileSystem.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.MakeNewFileInfo" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class MakeNewFileInfoTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ForPath_ReturnsValidFileInfo_ForFileThatExists()
        {
            FileInfo fileInfo = default;

            Assert.DoesNotThrow(
                () => fileInfo =
                    MakeNewFileInfo.ForPath(StringConstants.FILE_GUARANTEED_TO_EXIST)
            );
            Assert.That(fileInfo, Is.Not.Null);
            Assert.That(fileInfo, Is.InstanceOf<FileInfo>());
        }

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ForPath_ThrowsArgumentException_ForBlankFilename()
            => Assert.Throws<ArgumentException>(
                () => MakeNewFileInfo.ForPath(StringConstants.EMPTY_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ForPath_ThrowsArgumentException_ForNullFilename()
            => Assert.Throws<ArgumentException>(
                () => MakeNewFileInfo.ForPath(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_ForPath_ThrowsArgumentException_ForWhitespaceFilename()
            => Assert.Throws<ArgumentException>(
                () => MakeNewFileInfo.ForPath(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForPath_ThrowsFileNotFoundException_ForNonexistentFile()
        {
            Assert.That(!File.Exists(StringConstants.NONEXISTENT_FILE));
            Assert.Throws<FileNotFoundException>(
                () => MakeNewFileInfo.ForPath(StringConstants.NONEXISTENT_FILE)
            );
        }
    }
}