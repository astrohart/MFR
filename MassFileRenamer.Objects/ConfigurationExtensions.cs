using System;
using System.Linq;
using System.Windows.Forms;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Extension methods for objects implementing the <see
    /// cref="T:MassFileRenamer.GUI.IConfiguration"/> interface.
    /// </summary>
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// Saves the currently-selected Find What text item and the history to
        /// the configuration.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration"/> interface
        /// and which allows access to the configuration data.
        /// </param>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of <see
        /// cref="T:System.Windows.Forms.ComboBox"/> that is the control
        /// displaying the Find What content to the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the required parameters, <paramref
        /// name="config"/> or <paramref name="comboBox"/>, are passed a
        /// <c>null</c> value.
        /// </exception>
        public static void SaveCurrentFindWhatAndHistory(
            this IConfiguration config, ComboBox comboBox)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            config.FindWhat = comboBox.Text;
            config.FindWhatHistory.Clear();
            if (comboBox.Items.Count > 0)
                config.FindWhatHistory.AddRange(comboBox.Items.Cast<string>());
        }

        /// <summary>
        /// Saves the currently-selected Replace With text item and the history
        /// to the configuration.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration"/> interface
        /// and which allows access to the configuration data.
        /// </param>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of <see
        /// cref="T:System.Windows.Forms.ComboBox"/> that is the control
        /// displaying the Replace With content to the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the required parameters, <paramref
        /// name="config"/> or <paramref name="comboBox"/>, are passed a
        /// <c>null</c> value.
        /// </exception>
        public static void SaveCurrentReplaceWithAndHistory(
            this IConfiguration config, ComboBox comboBox)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            config.ReplaceWith = comboBox.Text;
            config.ReplaceWithHistory.Clear();
            if (comboBox.Items.Count > 0)
                config.ReplaceWithHistory.AddRange(
                    comboBox.Items.Cast<string>()
                );
        }

        /// <summary>
        /// Saves the currently-selected Starting Folder text item and the
        /// history to the configuration.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration"/> interface
        /// and which allows access to the configuration data.
        /// </param>
        /// <param name="comboBox">
        /// (Required.) Reference to an instance of <see
        /// cref="T:System.Windows.Forms.ComboBox"/> that is the control
        /// displaying the Starting Folder content to the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if either of the required parameters, <paramref
        /// name="config"/> or <paramref name="comboBox"/>, are passed a
        /// <c>null</c> value.
        /// </exception>
        public static void SaveCurrentStartingFolderAndHistory(
            this IConfiguration config, ComboBox comboBox)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            if (comboBox == null)
                throw new ArgumentNullException(nameof(comboBox));

            config.StartingFolder = comboBox.Text;
            config.StartingFolderHistory.Clear();
            if (comboBox.Items.Count > 0)
                config.StartingFolderHistory.AddRange(
                    comboBox.Items.Cast<string>()
                );
        }
    }
}