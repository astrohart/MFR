namespace MassFileRenamer.GUI
{
   public interface IConfiguration
   {
      string FindWhat { get; set; }
      bool MatchCase { get; set; }
      bool MatchWholeWord { get; set; }
      string ReplaceWith { get; set; }
      string StartingFolder { get; set; }
   }
}