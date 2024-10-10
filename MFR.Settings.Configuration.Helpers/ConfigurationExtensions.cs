using MFR.GUI.Controls.Interfaces;
using MFR.Settings.Configuration.Constants;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Profiles.Factories;
using MFR.Settings.Profiles.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Settings.Configuration.Helpers
{
    /// <summary>
    /// Extension methods for objects implementing the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// Allows us to work with the specified <paramref name="config" /> object
        /// as if it were a Profile.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object
        /// that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Interfaces.IProfile" /> interface that
        /// represents the specified <paramref name="config" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="config" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        public static IProfile AsProfile(this IProjectFileRenamerConfig config)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            return config is IProfile profile
                ? profile
                : config.ToProfile(
                    "tmp" + Guid.NewGuid()
                                 .ToString("B")
                                 .ToUpperInvariant()
                );
        }

        /// <summary>
        /// Gets the <see cref="T:MFR.TextMatchingConfiguration" /> value
        /// that corresponds to the values set in the config object, a
        /// reference to which is passed by the <paramref name="config" /> parameter.
        /// </summary>
        /// <param name="config">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <returns>
        /// The <see cref="T:MFR.TextMatchingConfiguration" /> value that
        /// corresponds to the values of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfigurationMatchCase" />
        /// and
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfigurationMatchExactWord" />
        /// properties.
        /// </returns>
        public static TextMatchingConfiguration GetTextMatchingConfiguration(
            this IProjectFileRenamerConfig config)
        {
            TextMatchingConfiguration result;

            switch (config.MatchCase)
            {
                case true when !config.MatchExactWord:
                    result = TextMatchingConfiguration.MatchCaseOnly;
                    break;

                case false when config.MatchExactWord:
                    result = TextMatchingConfiguration.MatchExactWordOnly;
                    break;

                case true when config.MatchExactWord:
                    result = TextMatchingConfiguration.MatchCaseAndExactWord;
                    break;

                default:
                    result = TextMatchingConfiguration
                        .NeitherMatchCaseNorExactWord;
                    break;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <paramref name="config" /> actually
        /// refers to a bona fide <c>Profile</c> or whether it was simply transformed into
        /// a temporary <c>Profile</c> object (having a name beginning with <c>tmp</c>).
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object
        /// that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="config" /> is merely a temporary <c>Profile</c> object;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool IsTemporaryProfile(this IProjectFileRenamerConfig config)
        {
            var result = false;

            try
            {
                if (config == null) return result;

                var correspondingProfile = config.AsProfile();
                if (correspondingProfile == null) return result;

                result = string.IsNullOrWhiteSpace(correspondingProfile.Name) ||
                         correspondingProfile.Name.StartsWith("tmp");
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Saves the currently-selected Find What text item and the history to
        /// the config.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface and which
        /// allows access to the config data.
        /// </param>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" />
        /// interface that is the control displaying the Find What content to the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="config" />
        /// or <paramref name="comboBox" />, are passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        public static void SaveCurrentFindWhatAndHistory(
            this IProjectFileRenamerConfig config, IEntryRespectingComboBox comboBox)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            config.FindWhat = comboBox.EnteredText;
            config.FindWhatHistory.Clear();
            if (comboBox.Items.Count > 0)
                config.FindWhatHistory.AddRange(comboBox.Items.Cast<string>());
        }

        /// <summary>
        /// Saves the currently-selected Replace With text item and the history
        /// to the config.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface and which
        /// allows access to the config data.
        /// </param>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" />
        /// interface that is the control displaying the Replace With content to the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="config" />
        /// or <paramref name="comboBox" />, are passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        public static void SaveCurrentReplaceWithAndHistory(
            this IProjectFileRenamerConfig config, IEntryRespectingComboBox comboBox)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            config.ReplaceWith = comboBox.EnteredText;
            config.ReplaceWithHistory.Clear();
            if (comboBox.Items.Count > 0)
                config.ReplaceWithHistory.AddRange(
                    comboBox.Items.Cast<string>()
                );
        }

        /// <summary>
        /// Saves the currently-selected Starting Folder text item and the
        /// history to the config.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface and which
        /// allows access to the config data.
        /// </param>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.GUI.Controls.Interfaces.IEntryRespectingComboBox" />
        /// interface that is the control displaying the Starting Folder
        /// content to the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="config" />
        /// or <paramref name="comboBox" />, are passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        public static void SaveCurrentStartingFolderAndHistory(
            this IProjectFileRenamerConfig config, IEntryRespectingComboBox comboBox)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            config.StartingFolder = comboBox.EnteredText;
            config.StartingFolderHistory.Clear();
            if (comboBox.Items.Count > 0)
                config.StartingFolderHistory.AddRange(
                    comboBox.Items.Cast<string>()
                );
        }
    }
}