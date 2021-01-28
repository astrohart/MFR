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

            new FileRenamer(rootDir).ProcessAll("PortfolioMonitor.Loaders.Config", "PortfolioMonitor.Serializers.Config");
            Console.ReadKey();
         }
         catch (Exception e)
         {
            Console.WriteLine(e);
         }
      }
   }
}