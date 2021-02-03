using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace MassFileRenamer.GUI
{
   public static class ConvertConfiguration
   {
      public static readonly JsonSerializerSettings Settings =
         new JsonSerializerSettings
         {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
               new IsoDateTimeConverter
               {
                  DateTimeStyles = DateTimeStyles.AssumeUniversal
               }
            }
         };

      public static IConfiguration FromJson(string json)
         => JsonConvert.DeserializeObject<Configuration>(json, Settings);

      public static string ToJson(IConfiguration configuration)
         => JsonConvert.SerializeObject(configuration as Configuration, Settings);
   }
}