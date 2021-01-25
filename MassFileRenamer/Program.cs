using MassFileRenamer.Objects;

namespace MassFileRenamer
{
   public static class Program
   {
      public static void Main()
      {
         const string rootDir = @"C:\test";

         new FileRenamer(rootDir).ProcessAll("foo", "bar");
      }
   }
}