using MFR.TextValues.Retrievers.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.TextValues.Retrievers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever" />
    /// interface for obtaining the pathname of a folder.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetFolderTextValueRetriever
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever" />
        /// interface, and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.TextValues.Retrievers.Interfaces.ITextValueRetriever" />
        /// interface for obtaining the pathname of a folder.
        /// </returns>
        public static ITextValueRetriever SoleInstance()
            => FolderTextValueRetriever.Instance;
    }
}