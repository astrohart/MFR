using System.Collections.Generic;

namespace MassFileRenamer.Objects
{
   /// <summary>
   /// Defines the public-exposed methods and properties of a configuration object.
   /// </summary>
   public interface IConfiguration
   {
      /// <summary>
      /// Gets or sets the text to be found that was most-recently specified by
      /// the user.
      /// </summary>
      string FindWhat { get; set; }

      /// <summary>
      /// Gets or sets a collection of strings consisting of the most-recently
      /// utilized values for Find What.
      /// </summary>
      List<string> FindWhatHistory { get; set; }

      /// <summary>
      /// Gets or sets a value indicating whether we should match the case on
      /// found text.
      /// </summary>
      bool MatchCase { get; set; }

      /// <summary>
      /// Gets or sets a value indicating whether we should match the whole word
      /// on found text.
      /// </summary>
      bool MatchWholeWord { get; set; }

      /// <summary>
      /// Gets or sets the text that found text should be replaced with.
      /// </summary>
      string ReplaceWith { get; set; }

      /// <summary>
      /// Gets or sets a collection of strings that correspond to the
      /// most-recently-used values for Replace With.
      /// </summary>
      List<string> ReplaceWithHistory { get; set; }

      /// <summary>
      /// Gets or sets a string containing the path to the starting folder of
      /// the search.
      /// </summary>
      string StartingFolder { get; set; }

      /// <summary>
      /// Gets or sets a collection of strings that correspond to the
      /// most-recently-used values for Starting Folder.
      /// </summary>
      List<string> StartingFolderHistory { get; set; }
   }
}