using Newtonsoft.Json;
using System.Collections.Generic;

namespace MassFileRenamer.Objects
{
    public class Configuration : IConfiguration
    {
        /// <summary>
        /// Gets or sets the text to be found that was most-recently specified
        /// by the user.
        /// </summary>
        [JsonProperty("findWhat")]
        public string FindWhat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings consisting of the most-recently
        /// utilized values for Find What.
        /// </summary>
        [JsonProperty("findWhatHistory")]
        public List<string> FindWhatHistory
        {
            get;
            set;
        } = new List<string>();

        /// <summary>
        /// Gets a value indicating whether the form is in the Folded state.
        /// </summary>
        /// <remarks>
        /// If this value is <c>true</c> when the form is loaded, then ensure
        /// that the form displays in the folded state.
        /// </remarks>
        [JsonProperty("isFolded")]
        public bool IsFolded
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should match the case on
        /// found text.
        /// </summary>
        [JsonProperty("matchCase")]
        public bool MatchCase
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether we should match the whole
        /// word on found text.
        /// </summary>
        [JsonProperty("matchWholeWord")]
        public bool MatchWholeWord
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename files
        /// in the folders encountered.
        /// </summary>
        [JsonProperty("renameFiles")]
        public bool RenameFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should rename subfolders.
        /// </summary>
        [JsonProperty("renameSubfolders")]
        public bool RenameSubfolders
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether we should replace text
        /// in files.
        /// </summary>
        [JsonProperty("replaceInFiles")]
        public bool ReplaceInFiles
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text that found text should be replaced with.
        /// </summary>
        [JsonProperty("replaceWith")]
        public string ReplaceWith
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Replace With.
        /// </summary>
        [JsonProperty("replaceWithHistory")]
        public List<string> ReplaceWithHistory
        {
            get;
            set;
        } = new List<string>();

        /// <summary>
        /// Gets or sets a number from 0...N, where N is the number of option
        /// tabs, of the one that is currently selected.
        /// </summary>
        [JsonProperty("selectedOptionTab")]
        public int SelectedOptionTab
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a string containing the path to the starting folder of
        /// the search.
        /// </summary>
        [JsonProperty("startingFolder")]
        public string StartingFolder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of strings that correspond to the
        /// most-recently-used values for Starting Folder.
        /// </summary>
        [JsonProperty("startingFolderHistory")]
        public List<string> StartingFolderHistory
        {
            get;
            set;
        } = new List<string>();
    }
}