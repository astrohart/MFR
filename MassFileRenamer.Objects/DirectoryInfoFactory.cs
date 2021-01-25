using System.IO;

namespace MassFileRenamer.Objects
{
   public static class DirectoryInfoFactory
   {
      public static DirectoryInfo Make(string path)
      {
         DirectoryInfo rootFolder;

         try
         {
            rootFolder = new DirectoryInfo(path);
         }
         catch
         {
            return null;
         }

         return rootFolder;
      }
   }
}