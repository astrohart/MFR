using Alphaleonis.Win32.Filesystem;
using MFR.GUI.Constants;
using MFR.Settings.Profiles.Collections.Interfaces;
using MFR.Settings.Profiles.Factories;
using MFR.Settings.Profiles.Providers.Factories;
using MFR.Settings.Profiles.Providers.Interfaces;
using NUnit.Framework;
using PostSharp.Patterns.Threading;
using System;
using xyLOGIX.Core.Assemblies.Info;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Settings.Profiles.Providers.ProfileProvider" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class ProfileProviderTests
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Settings.Profiles.Providers.Tests.ProfileProviderTests" /> and
        /// returns a reference to it.
        /// </summary>
        /// <remarks>
        /// This constructor sets up the production of a log file for this test fixture.
        /// </remarks>
        public ProfileProviderTests()
        {
            ProgramText.CompanyName = "xyLOGIX, LLC";
            ProgramText.ProductName = "xyLOGIX Project File Renamer";

            LogFileManager.InitializeLogging(
                muteConsole: false,
                infrastructureType: LoggingInfrastructureType.PostSharp,
                logFileName: Get.LogFilePath(),
                applicationName: Get.ApplicationProductName()
            );
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the file containing the collection of user-defined
        /// config-setting profiles.
        /// <para />
        /// This pathname is loaded from, and saved to, the system Registry.
        /// </summary>
        private static string ProfileCollectionFilePath
            => ProfileProvider.ProfileCollectionFilePath;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        private static IProfileProvider ProfileProvider
        {
            get;
        } = GetProfileProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface that represents the collection of config-setting profiles
        /// we're working with.
        /// </summary>
        private static IProfileCollection Profiles
            => ProfileProvider.Profiles;

        /// <summary>
        /// Asserts that the workflow of Profiles, i.e., loading them from disk, adding new
        /// fake profiles to the list, and then saving the results to disk, works.
        /// </summary>
        [Test]
        public void Test_Load_Add_And_Save_Workflow()
        {
            Assert.DoesNotThrow(() => ProfileProvider.Load());

            /*
             * Get a count of the current number of profiles, to
             * check whether the Add operations done below are successful.
             */
            var currentProfileCount = GetProfileCount();

            /*
             * Add three Profiles with random names.
             */
            Assert.DoesNotThrow(
                () => ProfileProvider.Profiles.Add(
                    MakeNewProfile.FromScratch()
                                  .HavingName(
                                      Guid.NewGuid()
                                          .ToString("B")
                                  )
                )
            );
            Assert.DoesNotThrow(
                () => Profiles.Add(
                    MakeNewProfile.FromScratch()
                                  .HavingName(
                                      Guid.NewGuid()
                                          .ToString("B")
                                  )
                )
            );
            Assert.DoesNotThrow(
                () => ProfileProvider.Profiles.Add(
                    MakeNewProfile.FromScratch()
                                  .HavingName(
                                      Guid.NewGuid()
                                          .ToString("B")
                                  )
                )
            );

            /*
             * Get the new count of profile entries.
             */
            var profileCountAfterAdding = GetProfileCount();

            /*
             * Assert that the delta in the count of Profile objects in the
             * Profiles collection is +3.
             */

            var countAfterAdding = profileCountAfterAdding - currentProfileCount;

            Assert.That(countAfterAdding, Is.EqualTo(3));

            /*
             * Now, save the Profiles to the file system. Assert that no exceptions
             * are thrown during the course of the operation.
             */

            Assert.DoesNotThrow(() => ProfileProvider.Save());

            /*
             * Assert that the profile list file with the default
             * path is present.
             */

            FileInfo profileCollectionFile = default;

            Assert.DoesNotThrow(
                () => profileCollectionFile =
                    new FileInfo(ProfileCollectionFilePath)
            );
            Assert.That(profileCollectionFile, Is.Not.Null);

            Assert.That(
                profileCollectionFile.Exists && profileCollectionFile.Length > 0
            );
        }

        /// <summary>
        /// Gets the count of user-defined config-setting profiles.
        /// </summary>
        /// <returns>Count of user-defined config-setting profiles.</returns>
        private static int GetProfileCount()
            => Profiles.Count;

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