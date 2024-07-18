using MFR.GUI.Models.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.IO;
using xyLOGIX.Files.Actions;

namespace MFR.GUI.Models
{
    /// <summary>
    /// Encapsulates data about an errant process that is to be forcibly terminated
    /// prior to the processing of either of the <c>Rename Files In Folder</c> or
    /// <c>Rename Sub Folder(s)</c> operations.
    /// </summary>
    public class ErrantProcessInfo : IErrantProcessInfo
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.GUI.Models.ErrantProcessInfo" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>.exe</c> file representing a process that is to be forcibly
        /// terminated.
        /// </param>
        public ErrantProcessInfo(string pathname)
        {
            Pathname = pathname;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing just the filename only, of the
        /// <c>.exe</c> file representing a process that is to be forcibly terminated.
        /// </summary>
        public string FileName
        {
            get {
                var result = string.Empty;

                try
                {
                    if (!Does.FileExist(Pathname)) return result;

                    result = Path.GetFileName(Pathname);
                }
                catch
                {
                    result = string.Empty;
                }

                return result;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>.exe</c> file that is to be forcibly terminated.
        /// </summary>
        public string Pathname
        {
            get;
            set;
        }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        [Log(AttributeExclude = true)]
        public override string ToString()
            => FileName;
    }
}