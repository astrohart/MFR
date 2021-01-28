using System;
using MassFileRenamer.Objects;

namespace MassFileRenamer
{
   public static class Program
   {
      public static void Main()
      {
         try
         {
            const string rootDir = @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor";


            var renamer = new FileRenamer(rootDir);

            renamer.FilesCounted += OnFileRenamerCountedFiles;

            renamer.ProcessAll("PortfolioMonitor.Loaders.Config", "PortfolioMonitor.Serializers.Config");
            Console.ReadKey();
         }
         catch (Exception e)
         {
            Console.WriteLine(e);
         }
      }

      private static void OnFileRenamerCountedFiles(object sender, FilesCountedEventArgs e)
      {
         switch (e.OperationType)
         {
            case OperationType.ReplaceTextInFiles:
               Console.WriteLine($"Replace Text in Files: {e.Count} files to be processed.");
               break;
         }
      }
   }
}