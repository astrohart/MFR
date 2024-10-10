using PostSharp.Patterns.Threading;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Validators.Factories;
using MFR.Operations.Constants;
using NUnit.Framework;
using Alphaleonis.Win32.Filesystem;
using System;

namespace MFR.FileSystem.Helpers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.DirectoryInfoExtensions" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class DirectoryInfoExtensionsTests
    {
        /// <summary>
        /// String containing the fully-qualified pathname of the folder after a rename operation is carried out.
        /// </summary>
        private static readonly string DEST_FOLDER = GeneratedTempFolderPath;

        /// <summary>
        /// String containing the fully-qualified pathname of the folder before a rename operation proceeds.
        /// </summary>
        private static readonly string SOURCE_FOLDER = GeneratedTempFolderPath;

        /// <summary>
        /// Gets a string containing the fully-qualified pathname of a subfolder of the user's Temp folder that is named after a GUID.
        /// </summary>
        private static string GeneratedTempFolderPath
            => Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("B").ToUpperInvariant());

        /// <summary>
        /// Asserts that the <see cref="F:MFR.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests.SOURCE_FOLDER"/> value is not the same string as the <see cref="F:MFR.FileSystem.Helpers.Tests.DirectoryInfoExtensionsTests.DEST_FOLDER"/>.
        /// </summary>
        [Test]
        public void Test_SourceFolder_DoesNotHave_SameNameAs_SourceFolder()
        {
            // Dump the variable SOURCE_FOLDER to the console
            Console.WriteLine( $"SOURCE_FOLDER = '{SOURCE_FOLDER}'");
            
            // Dump the variable DEST_FOLDER to the console
            Console.WriteLine( $"DEST_FOLDER = '{DEST_FOLDER}'");

            Assert.That(SOURCE_FOLDER, Is.Not.EqualTo(DEST_FOLDER));
        }

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.DirectoryInfoExtensions.RenameTo" />
        /// method renames a directory successfully when passed proper pathnames.
        /// </summary>
        [Test]
        public void Test_Directory_RenamedSuccessfully()
        {
            

            Assert.DoesNotThrow(
                () => new DirectoryInfo(SOURCE_FOLDER).RenameTo(DEST_FOLDER)
            );

            Assert.That(!
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .DoesExist(
                                               MakeNewFileSystemEntry.ForPath(
                                                   SOURCE_FOLDER
                                               )
                                           )
            );
            Assert.That(
                GetFileSystemEntryValidator.For(OperationType.RenameSubFolders)
                                           .DoesExist(
                                               MakeNewFileSystemEntry.ForPath(
                                                   DEST_FOLDER
                                               )
                                           )
            );
        }
    }
}