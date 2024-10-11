using PostSharp.Patterns.Diagnostics;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// TODO: Add class XML documentation here
    /// </summary>
    public static class Stop
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Renamers.Files.Actions.Stop" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Stop()
        {
        }
    }
}