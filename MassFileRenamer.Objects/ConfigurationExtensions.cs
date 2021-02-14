using System;
using System.Linq;
using System.Windows.Forms;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Extension methods for objects implementing the
    /// <see
    ///     cref="T:MassFileRenamer.GUI.IConfiguration" />
    /// interface.
    /// </summary>
    public static class ConfigurationExtensions
    {
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