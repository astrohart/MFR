using MFR.Tests.Common;
using NUnit.Framework;
using Alphaleonis.Win32.Filesystem;
using xyLOGIX.Core.Extensions;

namespace MFR.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:xyLOGIX.Core.Extensions.StringExtensions" />
    /// class.
    /// </summary>
    [TestFixture]
    public class StringExtensionsTests
    {
        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> for the case where it is only
        /// passed a filename (such as NOTEPAD.EXE) and not a complete, absolute pathname.
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly()
            => Assert.IsFalse(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY
                               .IsAbsolutePath()
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> for the case where it is only
        /// passed a filename (such as
        /// LICENSE) that does not have a file extension, and not a complete,
        /// absolute pathname.
        /// </summary>
        [Test]
        public void
            Test_IsAbsolutePath_ReturnsFalse_ForFileNameWithoutExtension()
            => Assert.IsFalse(
                StringConstants
                    .FILE_GUARANTEED_TO_EXIST_FILENAME_WITHOUT_EXTENSION
                    .IsAbsolutePath()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> in the event that the
        /// relative pathname, e.g., .\NOTEPAD.EXE, is passed.
        /// </summary>
        [Test]
        public void
            Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName()
            => Assert.IsFalse(
                $@".\{StringConstants.FILE_GUARANTEED_TO_EXIST}"
                    .IsAbsolutePath()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> when it is passed a blank value.
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput()
            => Assert.IsFalse(StringConstants.EMPTY_STRING.IsAbsolutePath());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> when passed
        /// <see
        ///     langword="null" />
        /// as input.
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput()
            => Assert.IsFalse(

                // ReSharper disable once InvokeAsExtensionMethod
                StringExtensions.IsAbsolutePath(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="false" /> when passed whitespace for input.
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace()
            => Assert.IsFalse(StringConstants.WHITESPACE.IsAbsolutePath());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="true" /> when passed a fully-qualified
        /// pathname of a file, even if the file does not exist.
        /// </summary>
        [Test]
        public void
            Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists()
        {
            Assert.IsFalse(File.Exists(StringConstants.NONEXISTENT_FILE));
            Assert.IsTrue(StringConstants.NONEXISTENT_FILE.IsAbsolutePath());
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsAbsolutePath" />
        /// method returns <see langword="true" /> when it is passed a
        /// fully-qualified pathname of a file that is guaranteed to exist.
        /// </summary>
        [Test]
        public void
            Test_IsAbsolutePath_ReturnsTrue_ForFullPathnameOfFileGauranteedToExist()
        {
            Assert.IsTrue(
                File.Exists(StringConstants.FILE_GUARANTEED_TO_EXIST)
            );
            Assert.IsTrue(
                StringConstants.FILE_GUARANTEED_TO_EXIST.IsAbsolutePath()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when supplied with the empty
        /// string as input.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForBlankInput()
            => Assert.IsFalse(StringConstants.EMPTY_STRING.IsFolderPath());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when provided only the name
        /// and extension of a file that is otherwise known to exist.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForFilenameOnly()
            => Assert.IsFalse(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY
                               .IsFolderPath()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when provided the name of a
        /// file that exists, but without the extension.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForFilenameWithNoExtension()
            => Assert.IsFalse(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY
                               .IsFolderPath()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when passed the pathname of a
        /// file that is known not to exist.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForFileThatDoesNotExist()
        {
            Assert.IsFalse(File.Exists(StringConstants.NONEXISTENT_FILE));
            Assert.IsFalse(StringConstants.NONEXISTENT_FILE.IsFolderPath());
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> for the event in which it is
        /// passed the fully-qualified pathname of a file that is known to exist.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForFileThatExists()
        {
            Assert.IsTrue(
                File.Exists(StringConstants.FILE_GUARANTEED_TO_EXIST)
            );
            Assert.IsTrue(
                StringConstants.FILE_GUARANTEED_TO_EXIST.IsAbsolutePath()
            );
            Assert.IsFalse(
                StringConstants.FILE_GUARANTEED_TO_EXIST.IsFolderPath()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when passed the
        /// fully-qualified pathname of a folder that is known not to exist.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForFolderThatDoesNotExist()
        {
            Assert.IsFalse(
                Directory.Exists(StringConstants.NONEXISTENT_FOLDER)
            );
            Assert.IsFalse(StringConstants.NONEXISTENT_FOLDER.IsFolderPath());
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when supplied with the
        /// <see
        ///     langword="null" />
        /// string as input.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForNullInput()
            => Assert.IsFalse(StringConstants.NULL_STRING.IsFolderPath());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="false" /> when supplied with whitespace
        /// as an input.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsFalse_ForWhitespaceInput()
            => Assert.IsFalse(StringConstants.WHITESPACE.IsFolderPath());

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:xyLOGIX.Core.Extensions.StringExtensions.IsFolderPath" />
        /// method returns <see langword="true" /> when passed the
        /// fully-qualified pathname of a folder that is known to exist.
        /// </summary>
        [Test]
        public void Test_IsFolderPath_ReturnsTrue_ForFolderThatExists()
        {
            Assert.IsTrue(
                Directory.Exists(
                    StringConstants.FOLDER_THAT_IS_GUARANTEED_TO_EXIST
                )
            );
            Assert.IsTrue(
                StringConstants.FOLDER_THAT_IS_GUARANTEED_TO_EXIST
                               .IsFolderPath()
            );
        }
    }
}
