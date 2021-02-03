using System.IO;

namespace MassFileRenamer.GUI
{
   public static class ConfigurationSerializer
   {
      public static IConfiguration Load(string pathname)
      {
         if (!File.Exists(pathname))
            return null;

         var content = File.ReadAllText(pathname);
         return ConvertConfiguration.FromJson(content);
      }

      public static void Save(string pathname, IConfiguration configuration)
      {
         if (string.IsNullOrWhiteSpace(pathname))
            return;

         if (configuration == null)
            return;

         var content = ConvertConfiguration.ToJson(configuration);

         if (string.IsNullOrWhiteSpace(content))
            return;

         if (File.Exists(pathname))
            File.Delete(pathname);

         File.WriteAllText(pathname, content);
      }
   }
}