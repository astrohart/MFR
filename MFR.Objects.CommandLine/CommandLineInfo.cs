using Fclp;
using MFR.Objects.CommandLine.Constants;
using System;
using System.Linq;

namespace MFR.Objects.CommandLine
{
    /// <summary>
    /// Encapsulates this application's command line arguments.
    /// </summary>
    /// <remarks>
    /// This class depends on the <c>FluentCommandLineParser</c> NuGet package.
    /// </remarks>
    public class CommandLineInfo
    {
        /// <summary>
        /// Gets or sets a string that contains the starting folder.
        /// </summary>
        public string RootDirectory
        {
            get;
            set;
        } = Directories.MyDocuments;

        /// <summary>
        /// Parses the application's command-line arguments and sets the properties
        /// of a new instance of <see cref="T:UserQuery.CommandLineInfo" /> 
        /// accordingly.
        /// </summary>
        /// <param name="args">
        /// (Required.) Array containing the command-line arguments passed to this application.
        /// </param>
        public static CommandLineInfo ParseCommandLine(string[] args)
        {
            var result = new CommandLineInfo();
            if (args == null || !args.Any())
                return result;

            var p = new FluentCommandLineParser<CommandLineInfo>();

            try
            {
                p.Setup(arg => arg.RootDirectory)
                 .As('r', "root")
                 .WithDescription($"Sets the directory that this application begins in.")
                 .SetDefault(Directories.MyDocuments);

                p.SetupHelp("?", "help")
                 .Callback(text => Console.WriteLine(text));

                var parsingResult = p.Parse(args);
                if (parsingResult.HasErrors)
                    throw new InvalidOperationException("ERROR: Failed to parse command line.");

                result = p.Object;
            }
            catch
            {
                if (p != null && p.Options.Any()) p.HelpOption.ShowHelp(p.Options);

                Environment.Exit(-1);
            }

            return result;
        }
    }
}