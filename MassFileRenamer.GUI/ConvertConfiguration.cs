using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace MassFileRenamer.GUI
{
   /// <summary>
   /// Converts JSON-formatted text to and from instances of C# objects that
   /// implement the <see cref="T:MassFileRenamer.GUI.IConfiguration" /> interface.
   /// </summary>
   public static class ConvertConfiguration
   {
      /// <summary>
      /// Reference to a <see cref="T:Newtonsoft.Json.JsonSerializerSettings" />
      /// that specifies how to serialize objects.
      /// </summary>
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

      /// <summary>
      /// Converts a string containing JSON-formatted text into an instance of
      /// an object that implements the
      /// <see
      ///    cref="T:MassFileRenamer.GUI.IConfiguration" />
      /// interface and returns a
      /// reference to it.
      /// </summary>
      /// <param name="json">
      /// (Required.) String containing the JSON to convert.
      /// </param>
      /// <returns>
      /// reference to an instance of an object that implements the
      /// <see
      ///    cref="T:MassFileRenamer.GUI.IConfiguration" />
      /// object whose properties
      /// are initialized to the data values read in from the JSON text.
      /// </returns>
      public static IConfiguration FromJson(string json)
         => JsonConvert.DeserializeObject<Configuration>(json, Settings);

      /// <summary>
      /// Converts an instance of an object that implements the
      /// <see
      ///    cref="T:MassFileRenamer.GUI.IConfiguration" />
      /// interface into a
      /// JSON-formatted string and returns the resultant string.
      /// </summary>
      /// <param name="configuration">
      /// (Required.) Reference to an instance of an object that implements the
      /// <see cref="T:MassFileRenamer.GUI.IConfiguration" /> interface.
      /// </param>
      /// <returns>
      /// String containing the JSON equivalent of the
      /// <paramref
      ///    name="configuration" />
      /// object fed in.
      /// </returns>
      public static string ToJson(IConfiguration configuration)
         => JsonConvert.SerializeObject(
            configuration as Configuration, Settings
         );
   }
}