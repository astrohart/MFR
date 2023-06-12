using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.GUI.Constants;
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Actions.Factories;
using MFR.Settings.Profiles.Collections.Factories;
using MFR.Settings.Profiles.Collections.Interfaces;
using MFR.Settings.Profiles.Commands.Constants;
using MFR.Settings.Profiles.Commands.Factories;
using MFR.Settings.Profiles.Constants;
using MFR.Settings.Profiles.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers
{
    /// <summary>
    /// Provides access to the collection of profiles for the current user.
    /// </summary>
    public class ProfileProvider : IProfileProvider
    {
        /// <summary>
        /// Gets the default JSON file name of the profile list path.
        /// </summary>
        public const string DEFAULT_PROFILE_LIST_FILENAME = "profiles.json";

        /// <summary>
        /// A <see cref="T:System.String" /> that holds the path the JSON file that stores
        /// profiles.
        /// </summary>
        private string _profileCollectionFilePath;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ProfileProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ProfileProvider() { }

        /// <summary>
        /// Gets the default folder for the profile list file.
        /// </summary>
        /// <remarks>
        /// We store the profile list file, by default, in a folder
        /// under the current user's AppData folder.
        /// </remarks>
        public string DefaultProfileCollectionDir
        {
            get;
        } = Path.Combine(
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                ), ProgramText.CompanyName
            ), $@"{ProgramText.ProductNameWithoutCompany}\Config"
        );

        /// <summary>
        /// Gets the default fully-qualified pathname of the profile list file.
        /// </summary>
        public string DefaultProfileCollectionPath
            => Path.Combine(
                DefaultProfileCollectionDir, DEFAULT_PROFILE_LIST_FILENAME
            );

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Settings.Profiles.Providers.ProfileProvider" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static ProfileProvider Instance
        {
            get;
        } = new ProfileProvider();

        /// <summary>
        /// Gets a string whose value is the fully-qualified pathname of the profile list
        /// file.
        /// </summary>
        public string ProfileCollectionFilePath
        {
            get {
                var result = string.Empty;

                try
                {
                    /*
                     * OKAY, if the value of the _profileCollectionFilePath field
                     * is non blank, check whether it contains the pathname of a
                     * profiles.json file and check whether the file exists.
                     *
                     * If yes to both of the above, then simply return the value of
                     * the _profileCollectionFilePath.  Otherwise, attempt to load
                     * the value of the field  from the system Registry.
                     */
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = string.Empty;
                }

                return result;
            }
            set {
                _profileCollectionFilePath = value;

                GetSaveProfileCollectionPathCommand.ForPath(
                                                       ProfileCollectionPathKeyName,
                                                       ProfileCollectionPathValueName,
                                                       _profileCollectionFilePath
                                                   )
                                                   .Execute();
            }
        }

        /// <summary>
        /// Gets a string whose value is the pathname of the system Registry key
        /// in which Profile settings are stored.
        /// </summary>
        public string ProfileCollectionPathKeyName
            => ProfilePathRegistry.KeyName;

        /// <summary>
        /// Gets a string whose value is the Registry value under which we store
        /// the path to the profile list file.
        /// </summary>
        public string ProfileCollectionPathValueName
            => ProfilePathRegistry.ValueName;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// The object to which a reference is returned by this properties
        /// allows access to the set of profiles defined by the user.
        /// </remarks>
        public IProfileCollection Profiles
        {
            get;
            protected set; // to enable to be set by members of this class only
        } = MakeNewProfileCollection.FromScratch();

        /// <summary>
        /// Loads the profiles from the profile list file.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) String containing the pathname of the file from which to
        /// load the profiles.
        /// </param>
        /// <remarks>
        /// The file whose pathname is passed must not be the actual
        /// configuration file, but a separate file.
        /// </remarks>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// Thrown if the file whose pathname is passed in the
        /// <paramref
        ///     name="pathname" />
        /// parameter cannot be found on the disk.
        /// </exception>
        public void Load(string pathname = "")
        {
            // write the name of the current class and method we are now
            if (string.IsNullOrWhiteSpace(pathname) ||
                !File.Exists(
                    pathname
                )) // oops! just use the default value of the Profiles property
            {
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"ProfileProvider.Load: The file '{pathname}' could not be found."
                );
                pathname = ProfileCollectionFilePath;

                if (!File.Exists(ProfileCollectionFilePath))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"ProfileProvider.Load: The file located at '{ProfileCollectionFilePath}' does not exist.  Loading the empty profile collection."
                    );

                    /*
                     * If we just cannot locate a file anywhere on the disk
                     * from which to read the profile list, then just create a new,
                     * blank list and then stop the load process here.
                     */

                    Profiles = MakeNewProfileCollection.FromScratch();

                    return;
                }
            }

            try

            {
                Profiles = GetProfileCollectionAction
                           .For<IFileSystemEntry, IProfileCollection>(
                               ProfileCollectionActionType
                                   .LoadProfileCollectionFromFile
                           )
                           .WithInput(MakeNewFileSystemEntry.ForPath(pathname))
                           .Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                // just make a new, blank profile collection in case an error occurs.
                Profiles = MakeNewProfileCollection.FromScratch();
            }

            if (Profiles != null)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info, "*** SUCCESS *** Profile list loaded."
                );

                // store the pathname in the pathname parameter into the ProfileCollectionFilePath property
                ProfileCollectionFilePath = pathname;
            }
        }

        /// <summary>
        /// Saves profile list data to a file on the disk having path
        /// <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Optional.) String containing the path to where the data should be
        /// saved in JSON format.
        /// <para />
        /// If this parameter is blank, then the data is saved to the path that
        /// is stored in the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider.ProfileCollectionFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        public void Save(string pathname = "")
        {
            /*
             * If the pathname parameter is blank, then use the
             * default profile list file path.
             */
            if (string.IsNullOrWhiteSpace(pathname))
            {
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    "ProfileProvider.Save: The 'pathname' parameter is blank.  Using the value of the 'ProfileCollectionFilePath' property..."
                );
                pathname = ProfileCollectionFilePath;
            }

            // Check to see if the required property, Profiles, is null. If
            if (Profiles == null)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "ProfileProvider.Save: The Profiles property is null.  Stopping."
                );
                return;
            }
            /*
             * Scan the Profiles collection for any elements with a Name property
             * starting with 'tmp_'.  If such entries are found, remove them from
             * the collection first.  NOTE: We check whether the collection has ANY
             * elements first; it's not worth the bother otherwise.
             */

            if (Profiles.Any())
                for (var i = Profiles.Count - 1; i >= 0; i--)
                    if (Profiles[i]
                        .Name.StartsWith("tmp_"))
                        Profiles.Remove(Profiles[i]);
            ;
            try
            {
                GetProfileCollectionCommandType.For<IFileSystemEntry>(
                                                   ProfileCollectionCommandType
                                                       .SaveProfileCollectionToFile
                                               )
                                               .WithInput(
                                                   MakeNewFileSystemEntry
                                                       .ForPath(
                                                           /*
                                                            * Path to the file that
                                                            * is to be written to the
                                                            * disk.
                                                            */
                                                           pathname
                                                       )
                                                       .SetUserState(
                                                           /*
                                                            * What needs to be saved?
                                                            * The list of profiles, which
                                                            * is the Profiles property.
                                                            */
                                                           Profiles
                                                       )
                                               )
                                               .Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}