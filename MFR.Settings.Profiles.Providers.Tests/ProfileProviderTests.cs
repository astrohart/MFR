using Alphaleonis.Win32.Filesystem;
using MFR.Settings.Profiles.Factories;
using MFR.Settings.Profiles.Providers.Factories;
using MFR.Settings.Profiles.Providers.Interfaces;
using MFR.Tests;
using MFR.Tests.Common;
using NUnit.Framework;
using System;

namespace MFR.Settings.Profiles.Providers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see cref="T:MFR.Settings.Profiles.Providers.ProfileProvider" /> class.
    /// </summary>
    [TestFixture]
    public class ProfileProviderTests : DebuggableTestFixture
    {
        /// <summary>
        /// Method that sets up the logging infrastructure for use with a child test
        /// fixture.
        /// <para />
        /// Child classes may override this method to run additional
        /// set-up logic.
        /// </summary>
        [SetUp]
        public override void Initialize()
            => base.Initialize();

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
            var currentProfileCount = ProfileProvider.Profiles.Count;

            /*
             * If the profile list file is found, then currentProfileCount
             * should be greater than zero.  Otherwise, it should be zero.
             */

            Assert.That(
                File.Exists(ProfileProvider.ProfileCollectionFilePath)
                    ? currentProfileCount > 0
                    : currentProfileCount == 0
            );

            /*
             * Add three Profiles with random names.
             */
            ProfileProvider.Profiles.Add(
                MakeNewProfile.FromScratch()
                              .HavingName(
                                  Guid.NewGuid()
                                      .ToString("B")
                              )
            );
            ProfileProvider.Profiles.Add(
                MakeNewProfile.FromScratch()
                              .HavingName(
                                  Guid.NewGuid()
                                      .ToString("B")
                              )
            );
            ProfileProvider.Profiles.Add(
                MakeNewProfile.FromScratch()
                              .HavingName(
                                  Guid.NewGuid()
                                      .ToString("B")
                              )
            );

            /*
             * Get the new count of profile entries.
             */
            var profileCountAfterAdding = ProfileProvider.Profiles.Count;

            /*
             * Assert that the delta in the count of Profile objects in the
             * Profiles collection is +3.
             */

            Assert.That(
                profileCountAfterAdding - currentProfileCount, Is.EqualTo(3)
            );

            /*
             * Now, save the Profiles to the disk.
             */

            ProfileProvider.Save();

            /*
             * Assert that the profile list file with the default
             * path is present.
             */

            Assert.That(File.Exists(ProfileProvider.ProfileCollectionFilePath));
        }

        /// <summary>
        /// Asserts that the
        /// <see cref="M:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.Load" />
        /// method works even when we pass it the empty string for the pathname of the file
        /// to be loaded.
        /// <para />
        /// In this circumstance, the profile
        /// provider object should attempt to read the path to load from, from the system
        /// Registry, or use the default.
        /// </summary>
        [Test]
        public void Test_Load_Method_Works_When_PassedStringEmpty()

            // This is the value that the Load method will utilize because we
            // pass in the empty string.
            => Assert.DoesNotThrow(
                () => ProfileProvider.Load(
                    /*
                     * This method could also be called with zero parameters passed,
                     * since the default parameter value  is the empty string.  However,
                     * we are being explicit here, for clarity.
                     */
                    StringConstants.EMPTY_STRING
                )
            );
    }
}