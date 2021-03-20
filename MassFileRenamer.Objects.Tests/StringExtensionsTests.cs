using NUnit.Framework;
using System.IO;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.StringExtensions" />
    /// class.
    /// </summary>
    [TestFixture]
    public class StringExtensionsTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_ForFileNameOnly()
            => Assert.IsFalse(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY
                               .IsAbsolutePath()
            );

        /// <summary>
        /// TODO: Add unit test documentation here
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
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_IsAbsolutePath_ReturnsFalse_WhenPassed_RelativePathName()
            => Assert.IsFalse(
                $@".\{StringConstants.FILE_GUARANTEED_TO_EXIST}"
                    .IsAbsolutePath()
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_WhenPassedBlankInput()
            => Assert.IsFalse(StringConstants.EMPTY_STRING.IsAbsolutePath());

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_WhenPassedNullInput()
            => Assert.IsFalse(

                // ReSharper disable once InvokeAsExtensionMethod
                StringExtensions.IsAbsolutePath(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_IsAbsolutePath_ReturnsFalse_WhenPassedWhitespace()
            => Assert.IsFalse(StringConstants.WHITESPACE.IsAbsolutePath());

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_IsAbsolutePath_ReturnsTrue_ForAbsolutePath_EvenIfTheFileNotExists()
        {
            Assert.IsFalse(File.Exists(StringConstants.NONEXISTENT_FILE));
            Assert.IsTrue(StringConstants.NONEXISTENT_FILE.IsAbsolutePath());
        }

        /// <summary>
        /// TODO: Add unit test documentation here
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
    }
}