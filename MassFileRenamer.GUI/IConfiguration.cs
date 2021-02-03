using System.Collections.Generic;

namespace MassFileRenamer.GUI
{
   public interface IConfiguration
   {
      string FindWhat { get; set; }
      List<string> FindWhatHistory { get; set; }
      bool MatchCase { get; set; }
      bool MatchWholeWord { get; set; }
      string ReplaceWith { get; set; }
      List<string> ReplaceWithHistory { get; set; }
      string StartingFolder { get; set; }
      List<string> StartingFolderHistory { get; set; }
   }
}