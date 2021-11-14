using MFR.CommandLine.Constants;
using MFR.CommandLine.Models.Interfaces;
using System;
using System.Linq;

namespace MFR.CommandLine.Models
{
    /// <summary>
    /// Encapsulates this application's command line arguments.
    /// </summary>
    /// <remarks>
    /// This class depends on the <c>FluentCommandLineParser</c> NuGet package.
    /// </remarks>
    public class CommandLineInfo : ICommandLineInfo
    {
        /// <summary>
        /// Gets or sets a string that contains the starting folder.
        /// </summary>
        public string RootDirectory
        {
            get;
            set;
        } = Directories.MyDocuments;
    }
}