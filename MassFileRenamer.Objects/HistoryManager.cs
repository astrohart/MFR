using MassFileRenamer.Objects.Properties;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Manages the configuration history on behalf of the application.
    /// </summary>
    public class HistoryManager : IHistoryManager
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
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object provides access to configuration information.
        /// </remarks>
        private IConfiguration _configuration;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.HistoryManager" />
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
        /// , is passed a <c>null</c> value.
        /// </exception>
        public HistoryManager(IWin32Window messageBoxParentWindow)
        {
            _messageBoxParentWindow = messageBoxParentWindow ??
                                      throw new ArgumentNullException(
                                          nameof(messageBoxParentWindow)
                                      );
        }

        /// <summary>
        /// Clears all the history objects in a configuration object.
        /// </summary>
        public void ClearAll()
        {
            if (!CanClearAll())
                return;

            // Since this configuration object may have god knows how many
            // history list properties, just use reflection to find and iterate
            // through all of them, invoking the System.Collections.IList.Clear
            // method on each one.
            var historyLists = _configuration.GetType()
                                             .GetProperties()
                                             .Where(
                                                 x => x.PropertyType
                                                         .GetActualType() !=
                                                     x.PropertyType &&
                                                     x.Name.Contains("History")
                                             )
                                             .Select(
                                                 p => p.GetValue(
                                                     _configuration
                                                 ) as IList
                                             )
                                             .ToArray();
            if (!historyLists.Any())
                return;

            foreach (var list in historyLists)
                list.Clear();

            // Finally, clear out all the current values of the form. This is
            // basically like a "Reset Form" button on a website.
            _configuration.StartingFolder = _configuration.FindWhat =
                _configuration.ReplaceWith = string.Empty;
        }

        /// <summary>
        /// Fluent-builder method to associate this History Manager object with
        /// a configuration object.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration" />
        /// interface. This object represents the settings chosen by the user to
        /// change the behavior of this app.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        public IHistoryManager AttachConfig(IConfiguration configuration)
        {
            _configuration = configuration ??
                             throw new ArgumentNullException(
                                 nameof(configuration)
                             );

            return this;
        }

        /// <summary>
        /// Gets a value indicating whether we can clear all the history objects
        /// or not.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the user confirms that all the history can be
        /// cleared; <c>false</c> otherwise.
        /// </returns>
        /// <remarks>
        /// This method does nothing but return <c>false</c> if all the history
        /// lists are already clear, since, in that event, this means that there
        /// is nothing to do.
        /// </remarks>
        private bool CanClearAll()
        {
            if (!_configuration.StartingFolderHistory.Any() &&
                !_configuration.FindWhatHistory.Any() &&
                !_configuration.ReplaceWithHistory.Any())
                return false;

            return DialogResult.Yes == MessageBox.Show(
                _messageBoxParentWindow, Resources.Confirm_ClearAllHistory,
                Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2
            );
        }
    }
}