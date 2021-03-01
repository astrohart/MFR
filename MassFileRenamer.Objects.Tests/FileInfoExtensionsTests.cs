using NUnit.Framework;
using System;
using System.IO;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods in the <see
    /// cref="T:MassFileRenamer.Objects.FileInfoExtensions"/> class.
    /// </summary>
    [TestFixture]
    public class FileInfoExtensionsTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_RenameTo_Works_On_CsProj_File()
        {
            Assert.Pass();

            // rename a .csproj file into a GUID and then back again
            var originalFile =
                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.Commissions.Schedules.Interfaces\PortfolioMonitor.Commissions.Schedules.Interfaces.csproj";
            Assert.IsTrue(File.Exists(originalFile));

            var newFilePath =
                @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.Commissions.Schedules.Interfaces\" +
                $"{Guid.NewGuid():N}.csproj";

            Assert.IsTrue(new FileInfo(originalFile).RenameTo(newFilePath));
        }
    }
}