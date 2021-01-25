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
            const string rootDir = @"C:\temp\nomics";

            new FileRenamer(rootDir).ProcessAll("IO.Swagger", "Foo");
            Console.ReadKey();
         }
         catch (Exception e)
         {
            Console.WriteLine(e);
         }
      }
   }
}