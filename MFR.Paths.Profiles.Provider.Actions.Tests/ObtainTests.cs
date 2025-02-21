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
 */using PostSharp.Patterns.Threading;
using Alphaleonis.Win32.Filesystem;
using NUnit.Framework;
using System;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Profiles.Provider.Actions.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Settings.Profiles.Providers.Actions.Obtain" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class ObtainTests
    {
        /// <summary>
        /// A <see cref="T:System.String" /> that contains the application's company name.
        /// </summary>
        private const string CompanyName = "xyLOGIX, LLC";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains the application's product name.
        /// </summary>
        private const string ProductNameWithoutCompany = "Project File Renamer";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains the default place we, ideally,
        /// want to store the user's profiles -- their local AppData directory.
        /// </summary>
        private static readonly string DefaultProfileCollectionPath =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                ), @"xyLOGIX, LLC\Project File Renamer\Config\profiles.json"
            );

        /// <summary>
        /// Keep this value updated with whatever is stored in the system Registry
        /// under the ProfileCollectionPath value of the
        /// Computer\HKEY_CURRENT_USER\SOFTWARE\xyLOGIX, LLC\Project File Renamer\Paths
        /// Registry key.
        /// </summary>
        private static readonly string ExpectedProfileCollectionPath =
            Read.RegistryValue(
                @"SOFTWARE\xyLOGIX, LLC\Project File Renamer\Paths",
                "ProfileCollectionFile"
            );

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Paths.Profiles.Provider.Actions.Tests.ObtainTests" /> and
        /// returns a reference to it.
        /// </summary>
        public ObtainTests()
        {
            LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="F:MFR.Paths.Profiles.Provider.Actions.Tests.ObtainTests.DefaultProfileCollectionPath" />
        /// field's value is non-blank, well-formed, and does not throw exceptions when
        /// it's computed.
        /// </summary>
        [Test]
        public void
            Test_DefaultProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions()
        {
            var hashCode = -1;
            Assert.DoesNotThrow(
                () =>
                {
                    hashCode = DefaultProfileCollectionPath.GetHashCode();
                }
            );

            // Dump the variable hashCode to the console
            Console.WriteLine($"[  DEBUG  ]  hashCode = {hashCode}");

            Assert.That(DefaultProfileCollectionPath, Is.Not.Empty);

            // Dump the variable DefaultProfileCollectionPath to the console
            Console.WriteLine(
                $"[  DEBUG  ]  DefaultProfileCollectionPath = '{DefaultProfileCollectionPath}'"
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="F:MFR.Paths.Profiles.Provider.Actions.Tests.ObtainTests.ExpectedProfileCollectionPath" />
        /// field's value is non-blank, well-formed, and does not throw exceptions when
        /// it's evaluated.
        /// </summary>
        [Test]
        public void
            Test_ExpectedProfileCollectionPath_IsWellFormed_AndDoesNotThrowExceptions()
        {
            var hashCode = -1;
            Assert.DoesNotThrow(
                () =>
                {
                    hashCode = ExpectedProfileCollectionPath.GetHashCode();
                }
            );
            Assert.That(string.IsNullOrWhiteSpace(ExpectedProfileCollectionPath));

            // Dump the variable hashCode to the console
            Console.WriteLine($"[  DEBUG  ]  hashCode = {hashCode}");

            // Dump the variable ExpectedProfileCollectionPath to the console
            Console.WriteLine(
                $"[  DEBUG  ]  ExpectedProfileCollectionPath = '{ExpectedProfileCollectionPath}'"
            );
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.Profiles.Providers.Actions.Obtain.ProfileCollectionFilePath" />
        /// method obtains a fully-qualified pathname to a file that exists, containing
        /// previously-saved configuration-setting profiles, and that the method copes
        /// with, e.g., the absence of the Registry key that contains the pathname of the
        /// <c>profiles.json</c> file and still provide a reasonable default.
        /// </summary>
        [Test]
        public void
            Test_Obtain_ProfileCollectionFilePath_Gets_PathOfFileThatIsNotBlank()
        {
            var result = string.Empty;

            Assert.DoesNotThrow(
                () =>
                {
                    result = Obtain.ProfileCollectionFilePath(
                        CompanyName, ProductNameWithoutCompany
                    );
                }
            );

            // Dump the variable result to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"ObtainTests.Test_Obtain_ProfileCollectionFilePath_Gets_PathOfFileThatIsNotBlank: result = '{result}'"
            );

            Assert.That(!string.IsNullOrWhiteSpace(result));
            Assert.That(ExpectedProfileCollectionPath, Is.Not.EqualTo(result));

            /*
             * For the purposes of this test, we do not care whether the file
             * whose pathname we obtained exists.  We just want to make sure
             * we got a non-blank value.
             */
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.Profiles.Providers.Actions.Obtain.ProfileCollectionFilePath" />
        /// method successfully obtains the fully-qualified pathname to the
        /// <c>profiles.json</c> file on the user's computer.
        /// </summary>
        [Test]
        public void
            Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_UsingDefaultValue()
        {
            Assert.That(DefaultProfileCollectionPath, Is.Not.Empty);
            Assert.That(File.Exists(DefaultProfileCollectionPath));

            var result = string.Empty;

            Assert.DoesNotThrow(
                () => result = Obtain.ProfileCollectionFilePath(
                    CompanyName, ProductNameWithoutCompany,
                    DefaultProfileCollectionPath
                )
            );

            Assert.That(result, Is.Not.Empty);
            Assert.That(DefaultProfileCollectionPath, Is.EqualTo(result));
            Assert.That(File.Exists(result));
        }

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Settings.Profiles.Providers.Actions.Obtain.ProfileCollectionFilePath" />
        /// method successfully obtains the fully-qualified pathname to the
        /// <c>profiles.json</c> file on the user's computer.
        /// <para />
        /// This unit test does not supply the pathname of a default value.
        /// </summary>
        [Test]
        public void
            Test_Obtain_ProfileCollectionFilePath_UsesInputtedFilePath_ThatExists_WithNoDefaultProvided()
        {
           var result = string.Empty;

            Assert.DoesNotThrow(
                () => result = Obtain.ProfileCollectionFilePath(
                    CompanyName, ProductNameWithoutCompany,
                    string.Empty /* being explicit */
                )
            );

            Assert.That(result, Is.Not.Empty);
            Assert.That(DefaultProfileCollectionPath, Is.EqualTo(result));
            Assert.That(File.Exists(result));
        }

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