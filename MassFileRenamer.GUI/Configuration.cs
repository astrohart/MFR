using Newtonsoft.Json;

namespace MassFileRenamer.GUI
{
   public class Configuration : IConfiguration
   {
      [JsonProperty("startingFolder")]
      public string StartingFolder { get; set; }

      [JsonProperty("findWhat")]
      public string FindWhat { get; set; }

      [JsonProperty("replaceWith")]
      public string ReplaceWith { get; set; }

      [JsonProperty("matchCase")]
      public bool MatchCase { get; set; }

      [JsonProperty("matchWholeWord")]
      public bool MatchWholeWord { get; set; }
   }
}