using MFR.Managers.History.Interfaces;
using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Extensions;

namespace MFR.Managers.History
{
    /// <summary>
    /// Manages the config history on behalf of the application.
    /// </summary>
    public class HistoryManager : ConfigurationComposedObjectBase,
        IHistoryManager
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:System.Windows.Forms.IWin32Window" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This field is supposed to be filled with a reference to an object
        /// that represents the main window of the application.
        /// </remarks>
        private readonly IWin32Window _messageBoxParentWindow;

        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Managers.History.HistoryManager" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static HistoryManager() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.HistoryManager" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="messageBoxParentWindow">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:System.Windows.Forms.IWin32Window" /> interface and
        /// which will serve as the parent window for any message boxes
        /// displayed by this object.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="messageBoxParentWindow" />
        /// , is passed a <see langword="null" /> value.
        /// </exception>
        [Log(AttributeExclude = true)]
        public HistoryManager(IWin32Window messageBoxParentWindow)
        {
            _messageBoxParentWindow = messageBoxParentWindow ??
                                      throw new ArgumentNullException(
                                          nameof(messageBoxParentWindow)
                                      );
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user config and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigProvider
            ConfigProvider
            => GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        public override IProjectFileRenamerConfig CurrentConfiguration
        {
            get;
            set;
        } = ConfigProvider.CurrentConfiguration;

        /// <summary>
        /// Clears all the history objects in a config object.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the Clear operation was carried out
        /// successfully; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public bool ClearAll()
        {
            if (!CanClearAll())
                return false;

            // Since this config object may have god knows how many
            // history list properties, just use reflection to find and iterate
            // through all of them, invoking the System.Collections.IList.Clear
            // method on each one.
            var historyLists = CurrentConfiguration.GetType()
                                                   .GetProperties()
                                                   .Where(
                                                       x => x.PropertyType
                                                               .GetActualType() !=
                                                           x.PropertyType &&
                                                           x.Name.Contains(
                                                               "History"
                                                           )
                                                   )
                                                   .Select(
                                                       p => p.GetValue(
                                                           CurrentConfiguration
                                                       ) as IList
                                                   )
                                                   .ToArray();
            if (!historyLists.Any())
                return false;

            foreach (var list in historyLists)
                list.Clear();

            // Finally, clear out all the current values of the form. This
            // basically like a "Reset Form" button on a website.
            CurrentConfiguration.StartingFolder =
                CurrentConfiguration.FindWhat =
                    CurrentConfiguration.ReplaceWith = string.Empty;

            return true; // success
        }

        /// <summary>
        /// Gets a value indicating whether we can clear all the history objects
        /// or not.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the user confirms that all the history can
        /// be cleared; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// This method does nothing but return <see langword="false" /> if all
        /// the history lists are already clear, since, in that event, this
        /// means that there is nothing to do.
        /// </remarks>
        private bool CanClearAll()
        {
            if (!CurrentConfiguration.StartingFolderHistory.Any() &&
                !CurrentConfiguration.FindWhatHistory.Any() &&
                !CurrentConfiguration.ReplaceWithHistory.Any())
                return false;

            return DialogResult.Yes == MessageBox.Show(
                _messageBoxParentWindow,
                "Are you sure you want to erase all the items from your search history?\n\nThis action cannot be undone.",
                Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2
            );
        }
    }
}