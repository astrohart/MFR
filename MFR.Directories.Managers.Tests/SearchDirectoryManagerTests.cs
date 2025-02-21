/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */

using PostSharp.Patterns.Threading;
using Alphaleonis.Win32.Filesystem;
using MFR.Directories.Managers.Factories;
using MFR.Directories.Managers.Interfaces;
using NUnit.Framework;
using System;
using System.Diagnostics;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;

namespace MFR.Directories.Managers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Directories.Managers.SearchDirectoryManager" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class SearchDirectoryManagerTests
    {
        private readonly Stopwatch _stopwatch;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Directories.Managers.Tests.SearchDirectoryManagerTests" /> and
        /// returns a reference to it.
        /// </summary>
        public SearchDirectoryManagerTests()
        {
            LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );

            _stopwatch = new Stopwatch();
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager" />
        /// interface.
        /// </summary>
        private static ISearchDirectoryManager SearchDirectoryManager
        {
            get;
        } = GetSearchDirectoryManager.SoleInstance();

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager.Search" />
        /// method finds all the folders containing Visual Studio Solution (<c>*.sln</c>)
        /// files in the <c>C:\Users\Brian Hart\source\repos\astrohart</c> top-level
        /// folder, which is known to contain folders.
        /// </summary>
        [Test]
        public void
            Test_GetSearchDirectories_Works_ForAllRepos_InAstrohart_Folder()
        {
            StartStopwatch();

            Assert.DoesNotThrow(
                () => SearchDirectoryManager.Search(
                    Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.UserProfile
                        ), @"source\repos\astrohart"
                    )
                )
            );
            Assert.That(SearchDirectoryManager.SearchDirectories, Is.Not.Null);
            Assert.That(SearchDirectoryManager.SearchDirectories, Is.Not.Empty);

            foreach (var directory in SearchDirectoryManager.SearchDirectories)
                Console.WriteLine(directory);

            ReportElapsedTime();
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager.Search" />
        /// method finds all the folders containing Visual Studio Solution (<c>*.sln</c>)
        /// files in the <c>C:\Users\Brian Hart\source\repos\astrohart</c> top-level
        /// folder, which is known to contain folders.
        /// </summary>
        [Test]
        public void Test_GetSearchDirectories_Works_ForAllRepos_InMFR_Folder()
        {
            StartStopwatch();

            Assert.DoesNotThrow(
                () => SearchDirectoryManager.Search(
                    Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.UserProfile
                        ), @"source\repos\astrohart\MFR"
                    )
                )
            );
            Assert.That(SearchDirectoryManager.SearchDirectories, Is.Not.Null);
            Assert.That(SearchDirectoryManager.SearchDirectories, Is.Not.Empty);

            foreach (var directory in SearchDirectoryManager.SearchDirectories)
                Console.WriteLine(directory);

            ReportElapsedTime();
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager.Search" />
        /// method finds all the folders containing Visual Studio Solution (<c>*.sln</c>)
        /// files in the <c>C:\Users\Brian Hart\source\repos\astrohart</c> top-level
        /// folder, which is known to contain folders.
        /// </summary>
        [Test]
        public void
            Test_GetSearchDirectories_Works_ForAllRepos_IPortfolioMonitor_Folder()
        {
            StartStopwatch();

            Assert.DoesNotThrow(
                () => SearchDirectoryManager.Search(
                    Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.UserProfile
                        ), @"source\repos\astrohart\PortfolioMonitor"
                    )
                )
            );
            Assert.That(SearchDirectoryManager.SearchDirectories, Is.Not.Null);
            Assert.That(SearchDirectoryManager.SearchDirectories, Is.Not.Empty);

            foreach (var directory in SearchDirectoryManager.SearchDirectories)
                Console.WriteLine(directory);

            ReportElapsedTime();
        }

        private void ReportElapsedTime()
        {
            try
            {
                if (_stopwatch == null) return;
                if (!_stopwatch.IsRunning) return;

                StopStopwatch();

                var timeSpan = _stopwatch.Elapsed;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** SUCCESS *** Elapsed Time is {0:00} hour(s), {1:00} minute(s), and {2:00}.{3} second(s)",
                    timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds,
                    timeSpan.Milliseconds
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Starts the stopwatch.
        /// </summary>
        private void StartStopwatch()
            => _stopwatch?.Start();

        /// <summary>
        /// Stops the stopwatch.
        /// </summary>
        private void StopStopwatch()
            => _stopwatch?.Stop();

        /// <summary>
        /// Exposes static methods to obtain data from various data sources.
        /// </summary>
        private static class Get
        {
            /// <summary>
            /// A <see cref="T:System.String" /> containing the final piece of the path of the
            /// log file.
            /// </summary>
            private static readonly string LOG_FILE_PATH_TERMINATOR =
                $@"{AssemblyCompany}\{AssemblyProduct}\Logs\{AssemblyTitle}_log.txt";

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains the product name defined
            /// for this application.
            /// </summary>
            /// <remarks>
            /// This property is really an alias for the
            /// <see cref="P:AssemblyMetadata.AssemblyCompany" /> property.
            /// </remarks>
            private static string AssemblyCompany
                => AssemblyMetadata.AssemblyCompany;

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains the product name defined
            /// for this application.
            /// </summary>
            /// <remarks>
            /// This property is really an alias for the
            /// <see cref="P:AssemblyMetadata.AssemblyProduct" /> property.
            /// </remarks>
            private static string AssemblyProduct
                => AssemblyMetadata.AssemblyProduct.Replace(
                    "xyLOGIX ", string.Empty
                );

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains the assembly title defined
            /// for this application.
            /// </summary>
            /// <remarks>
            /// This property is really an alias for the
            /// <see cref="P:AssemblyMetadata.AssemblyTitle" /> property.
            /// </remarks>
            private static string AssemblyTitle
                => AssemblyMetadata.AssemblyTitle.Replace(" ", "_");

            /// <summary>
            /// Gets a <see cref="T:System.String" /> that contains a user-friendly name for
            /// the software product of which this application or class library is a part.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String" /> that contains a user-friendly name
            /// for the software product of which this application or class library is a part.
            /// </returns>
            public static string ApplicationProductName()
            {
                string result;

                try
                {
                    result = AssemblyProduct;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = string.Empty;
                }

                return result;
            }

            /// <summary>
            /// Obtains a <see cref="T:System.String" /> that contains the fully-qualified
            /// pathname of the file that should be used for logging messages.
            /// </summary>
            /// <returns>
            /// A <see cref="T:System.String" /> that contains the fully-qualified
            /// pathname of the file that should be used for logging messages.
            /// </returns>
            public static string LogFilePath()
                => Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.CommonApplicationData
                    ), LOG_FILE_PATH_TERMINATOR
                );
        }
    }
}