using Newtonsoft.Json;
using System.Collections.Generic;

namespace MassFileRenamer.GUI
{
   public class Configuration : IConfiguration
   {
      [JsonProperty("findWhat")] public string FindWhat { get; set; }

      [JsonProperty("findWhatHistory")]
      public List<string> FindWhatHistory { get; set; } = new List<string>();

      [JsonProperty("matchCase")] public bool MatchCase { get; set; }

      [JsonProperty("matchWholeWord")] public bool MatchWholeWord { get; set; }

      [JsonProperty("replaceWith")] public string ReplaceWith { get; set; }

      [JsonProperty("replaceWithHistory")]
      public List<string> ReplaceWithHistory { get; set; } = new List<string>();

      [JsonProperty("startingFolder")]
      public string StartingFolder { get; set; }

      [JsonProperty("startingFolderHistory")]
      public List<string> StartingFolderHistory { get; set; } =
         new List<string>();
   }
}