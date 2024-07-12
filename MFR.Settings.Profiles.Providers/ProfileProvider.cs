using MFR.Events.Common;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Interfaces;
using MFR.Paths.Profiles.Provider.Factories;
using MFR.Paths.Profiles.Provider.Interfaces;
using MFR.Settings.Profiles.Collections.Factories;
using MFR.Settings.Profiles.Collections.Interfaces;
using MFR.Settings.Profiles.Commands.Constants;
using MFR.Settings.Profiles.Commands.Factories;
using MFR.Settings.Profiles.Providers.Actions;
using MFR.Settings.Profiles.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.ComponentModel;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers
{
    /// <summary>
    /// Provides access to the collection of profiles for the current user.
    /// </summary>
    public class ProfileProvider : IProfileProvider
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static ProfileProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected ProfileProvider()
        {
            InitializeProfileListPathProvider();

            ProfileListPathProvider
                .Load(); // load the pathname of the profile file from the system Registry.
        }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IProfileProvider Instance
        {
            get;
        } = new ProfileProvider();

        /// <summary>
        /// Gets or sets the fully-qualified pathname of the <c>profiles.json</c> file.
        /// </summary>
        public string ProfileCollectionFilePath
        {
            get => ProfileListPathProvider.ProfileCollectionFilePath;
            set => ProfileListPathProvider.ProfileCollectionFilePath = value;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider" />
        /// interface.
        /// </summary>
        private IProfileListPathProvider ProfileListPathProvider
        {
            get;
        } = GetProfileListPathProvider.SoleInstance();

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
        /// Occurs when we are about to begin the process of loading the user's saved
        /// config-setting profiles from the data source.
        /// </summary>
        public event CancelEventHandler LoadingProfiles;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Settings.Profiles.Providers.ProfileProvider.ProfileCollectionFilePath" />
        /// property is updated.
        /// </summary>
        public event EventHandler ProfileCollectionFilePathChanged;

        /// <summary>
        /// Occurs when loading the collection of profiles has failed.
        /// </summary>
        public event ExceptionRaisedEventHandler ProfileLoadFailed;

        /// <summary>
        /// Occurs when saving the collection of profiles has failed.
        /// </summary>
        public event EventHandler ProfileSaveFailed;

        /// <summary>
        /// Occurs when the collection of profiles has been loaded successfully.
        /// </summary>
        public event EventHandler ProfilesLoaded;

        /// <summary>
        /// Occurs when the collection of profiles has been saved successfully.
        /// </summary>
        public event EventHandler ProfilesSaved;

        /// <summary>
        /// Occurs when we are about to begin the process of saving the user's saved
        /// config-setting profiles from the data source.
        /// </summary>
        public event CancelEventHandler SavingProfiles;

        /// <summary>
        /// Loads the profiles from the profile list file.
        /// </summary>
        public void Load()
        {
            var ce = new CancelEventArgs();
            OnLoadingProfiles(ce);
            if (ce.Cancel) return;

            try
            {
                Profiles =
                    Obtain.ProfileCollectionFromFile(ProfileCollectionFilePath);

                OnProfilesLoaded();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnProfileLoadFailed(new ExceptionRaisedEventArgs(ex));
            }
        }

        /// <summary>
        /// Saves profile list data to a file on the file system having path
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
            pathname = Determine.CorrectProfileListPathForSaving(
                ProfileCollectionFilePath, pathname
            );
            if (!Determine.IsProfileListPathValidForSaving(pathname)) return;

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
             * starting with 'tmp'.  If such entries are found, remove them from
             * the collection first.  NOTE: We check whether the collection has ANY
             * elements first; it's not worth the bother otherwise.
             */

            Remove.TemporaryProfiles(Profiles);

            try
            {
                GetProfileCollectionCommand.For<IFileSystemEntry>(
                                               ProfileCollectionCommandType
                                                   .SaveProfileCollectionToFile
                                           )
                                           .WithInput(
                                               MakeNewFileSystemEntry.ForPath(
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

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Settings.Profiles.Providers.ProfileProvider.LoadingProfiles" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnLoadingProfiles(CancelEventArgs e)
            => LoadingProfiles?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Settings.Profiles.Providers.ProfileProvider.ProfileCollectionFilePathChanged" />
        /// event.
        /// </summary>
        /// <param name="sender">(Required.) Reference to the sender of this event.</param>
        /// <param name="e">
        /// (Required.) A <see cref="T:System.EventArgs" /> that contains
        /// the event data.
        /// </param>
        protected virtual void OnProfileCollectionFilePathChanged(
            object sender,
            EventArgs e
        )
            => ProfileCollectionFilePathChanged?.Invoke(sender, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Settings.Profiles.Providers.ProfileProvider.ProfileLoadFailed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.Common.ExceptionRaisedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnProfileLoadFailed(ExceptionRaisedEventArgs e)
            => ProfileLoadFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Settings.Profiles.Providers.ProfileProvider.ProfileSaveFailed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.Common.ExceptionRaisedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnProfileSaveFailed(ExceptionRaisedEventArgs e)
            => ProfileSaveFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Settings.Profiles.Providers.ProfileProvider.ProfilesLoaded" />
        /// event.
        /// </summary>
        protected virtual void OnProfilesLoaded()
            => ProfilesLoaded?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Settings.Profiles.Providers.ProfileProvider.ProfilesSaved" />
        /// event.
        /// </summary>
        protected virtual void OnProfilesSaved()
            => ProfilesSaved?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Settings.Profiles.Providers.ProfileProvider.SavingProfiles" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnSavingProfiles(CancelEventArgs e)
            => SavingProfiles?.Invoke(this, e);

        /// <summary>
        /// Configures settings on the object reference that we retain as a dependency,
        /// that implements the
        /// <see cref="T:MFR.Paths.Profiles.Provider.Interfaces.IProfileListPathProvider" />
        /// interface.
        /// </summary>
        private void InitializeProfileListPathProvider()
            => ProfileListPathProvider.ProfileCollectionFilePathChanged +=
                OnProfileCollectionFilePathChanged;
    }
}
