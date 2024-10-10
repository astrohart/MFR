using PostSharp.Patterns.Threading;
using MFR.FileSystem.Enumerators;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace MFR.FileSystem.Win32.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.FileSystem.Win32.NativeMethods" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class NativeMethodsTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_PathCompactPathEx_For_ABunchOfPaths()
        {
            var files = Enumerate.Files(
                                     Environment.GetFolderPath(
                                         Environment.SpecialFolder.MyDocuments
                                     ), "*", SearchOption.TopDirectoryOnly
                                 )
                                 .ToList();
            Assert.That(files, Is.Not.Null);
            Assert.That(files, Is.Not.Empty);

            foreach (var file in files)
            {
                Console.WriteLine(file + " -> ");
                Console.WriteLine(NativeMethods.PathCompactPathEx(file));
            }
        }
    }
}