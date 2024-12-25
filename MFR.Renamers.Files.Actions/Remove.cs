using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Interop.Processes.Actions;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// Exposes static methods to remove data from data sources or the file system.
    /// </summary>
    public static class Remove
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Renamers.Files.Actions.Remove" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static Remove() { }

        /// <summary>
        /// Attempts to remove the directory having the specified
        /// <paramref name="pathname" />, and all of its contents, from the file system.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the directory that is to be removed.
        /// </param>
        public static void Directory(string pathname)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return;

                Run.SystemCommand($"RD /S /Q \"{pathname}\"", "", true);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}