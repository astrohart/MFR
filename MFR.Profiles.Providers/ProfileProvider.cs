using Alphaleonis.Win32.Filesystem;
using MFR.Objects.Expressions.Registry.Factories;
using MFR.Objects.Expressions.Registry.Interfaces;
using MFR.Objects.FileSystem.Factories;
using MFR.Objects.FileSystem.Interfaces;
using MFR.Objects.Messages.Actions.Interfaces;
using MFR.Profiles.Actions.Constants;
using MFR.Profiles.Actions.Factories;
using MFR.Profiles.Collections;
using MFR.Profiles.Collections.Interfaces;
using MFR.Profiles.Commands.Factories;
using MFR.Profiles.Constants;
using MFR.Profiles.Providers.Interfaces;
using System;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;

namespace MFR.Profiles.Providers
{
    /// <summary>
    /// Provides access to the collection of profiles for the current user.
    /// </summary>
    public class ProfileProvider : IProfileProvider
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static ProfileProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected ProfileProvider()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Profiles.Providers.ProfileProvider" />.
        /// </summary>
        public static ProfileProvider Instance
        {
            get;
        } = new ProfileProvider();

        /// <summary>
        /// Gets the default folder for the profile list file.
        /// </summary>
        /// <remarks>
        /// We store the profile list file, by default, in a folder
        /// under the current user's AppData folder.
        /// </remarks>
        public string DefaultProfileListDir
        {
            get;
        } = Path.Combine(
        Path.Combine(
        Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData
            ), Application.CompanyName
        ), $@"{Application.ProductName}\Config"
        );

        /// <summary>
        /// Gets a string whose value is the pathname of the profile list file.
        /// </summary>
        public string ProfileListFilePath
        {
            get
                => LoadProfileListPathAction.Execute()
                                            .Path;
            set {
                GetSaveProfileListPathCommand.ForPath(
                                            ProfileListPathKeyName,
                                            ProfileListPathValueName, value
                                        )
                                        .Execute();

                /* Clear out the cache of previously-loaded paths
                 for this same operation. */
                LoadProfileListPathAction.AsCachedResultAction()
                                         .ClearResultCache();
            }
        }

        /// <summary>
        /// Gets the default filename for the profile list file.
        /// </summary>
        public string DefaultProfileListPath
            => "profiles.json";

        private IAction<IRegQueryExpression<string>, IFileSystemEntry>
            LoadProfileListPathAction
            => GetProfileListAction
               .For<IRegQueryExpression<string>, IFileSystemEntry>(
                   ProfileListAction.LoadStringFromRegistry
               )
               .WithInput(
                   MakeNewRegQueryExpression.FromScatch<string>()
                                            .ForKeyPath(ProfileListPathKeyName)
                                            .AndValueName(
                                                ProfileListPathValueName
                                            )
                                            .WithDefaultValue(
                                                Path.Combine(
                                                    DefaultProfileListDir,
                                                    DefaultProfileListPath
                                                )
                                            )
               );

        /// <summary>
        /// Gets a string whose value is the pathname of the system Registry key
        /// in which Profile settings are stored.
        /// </summary>
        public string ProfileListPathKeyName
            => ProfilePathRegistry.KeyName;

        /// <summary>
        /// Gets a string whose value is the Registry value under which we store
        /// the path to the profile list file.
        /// </summary>
        public string ProfileListPathValueName
            => ProfilePathRegistry.ValueName;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Profiles.Collections.Interfaces.IProfileCollection" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// The object to which a reference is returned by this properties
        /// allows access to the set of profiles defined by the user.
        /// </remarks>
        public IProfileCollection ProfileCollection
        {
            get;
            protected set;  // to enable to be set by members of this class only
        } = new ProfileCollection();

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
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In ProfileProvider.Load"
            );

            if (!File.Exists(pathname)) // oops! just use the default value of the ProfileCollection property
                return;

            try
            {
                ProfileCollection = GetProfileListAction
                                .For<IFileSystemEntry, IProfileCollection>(
                                    ProfileListAction.LoadProfileListFromFile)
                                .WithInput(
                                    MakeNewFileSystemEntry.ForPath(
                                        pathname
                                    )
                                )
                                .Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                // just make a new, blank profile collection in case an error occurs.
                ProfileCollection = new ProfileCollection();
            }

            if (ProfileCollection != null)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info, "*** SUCCESS *** Profile list loaded."
                );

                // store the pathname in the pathname parameter into the ProfileListFilePath property
                ProfileListFilePath = pathname;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug, "ProfileProvider.Load: Done."
            );
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
        ///     cref="P:MFR.Profiles.Providers.Interfaces.IProfileProvider.ProfileListFilePath" />
        /// property.
        /// </param>
        /// <remarks>
        /// If the
        /// <see
        ///     cref="P:MFR.Profiles.Providers.Interfaces.IProfileProvider.ProfileListFilePath" />
        /// property is blank, then this method does nothing.
        /// </remarks>
        public void Save(string pathname = "")
            => throw new NotImplementedException();
    }
}