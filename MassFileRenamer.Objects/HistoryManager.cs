using MassFileRenamer.Objects.Properties;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Manages the configuration history on behalf of the application.
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
        /// , is passed a <see langword="null" /> value.
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
        /// <returns>
        /// <see langword="true" /> if the Clear operation was carried out
        /// successfully; <see langword="false" /> otherwise.
        /// </returns>
        [Log(AttributeExclude = true)]
        public bool ClearAll()
        {
            if (!CanClearAll())
                return false;

            // Since this configuration object may have god knows how many
            // history list properties, just use reflection to find and iterate
            // through all of them, invoking the System.Collections.IList.Clear
            // method on each one.
            var historyLists = Configuration.GetType()
                                            .GetProperties()
                                            .Where(
                                                x => x.PropertyType
                                                        .GetActualType() !=
                                                    x.PropertyType &&
                                                    x.Name.Contains("History")
                                            )
                                            .Select(
                                                p => p.GetValue(
                                                    Configuration
                                                ) as IList
                                            )
                                            .ToArray();
            if (!historyLists.Any())
                return false;

            foreach (var list in historyLists)
                list.Clear();

            // Finally, clear out all the current values of the form. This is
            // basically like a "Reset Form" button on a website.
            Configuration.StartingFolder = Configuration.FindWhat =
                Configuration.ReplaceWith = string.Empty;

            return true;    // success
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
            if (!Configuration.StartingFolderHistory.Any() &&
                !Configuration.FindWhatHistory.Any() &&
                !Configuration.ReplaceWithHistory.Any())
                return false;

            return DialogResult.Yes == MessageBox.Show(
                _messageBoxParentWindow, Resources.Confirm_ClearAllHistory,
                Application.ProductName, MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2
            );
        }
    }
}