using Fclp;
using MFR.CommandLine.Constants;
using MFR.CommandLine.Models;
using MFR.CommandLine.Models.Factroies;
using MFR.CommandLine.Models.Interfaces;
using MFR.CommandLine.Parsers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;

namespace MFR.CommandLine.Parsers
{
    /// <summary>
    /// Manages the parsing and validation of the command line of the application.
    /// </summary>
    public class CommandLineParser : ICommandLineParser
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CommandLineParser() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CommandLineParser() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.CommandLine.Parsers.CommandLineParser" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static ICommandLineParser Instance
        {
            get;
        } = new CommandLineParser();

        /// <summary>
        /// Parses the application's command-line arguments and sets the properties of a
        /// new instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// accordingly.
        /// </summary>
        /// <param name="args">
        /// (Required.) Array containing the command-line arguments passed to this
        /// application.
        /// </param>
        public ICommandLineInfo Parse(string[] args)
        {
            var result = MakeNewCommandLineInfo.FromScratch();
            if (args == null || !args.Any())
                return result;

            var p = new FluentCommandLineParser<CommandLineInfo>();

            try
            {
                p.Setup(arg => arg.RootDirectory)
                 .As('r', "root")
                 .WithDescription(
                     "Sets the directory that this application begins in."
                 )
                 .SetDefault(Directories.MyDocuments);

                p.Setup(arg => arg.FindWhat)
                 .As("findWhat")
                 .WithDescription(
                     "Sets the string to be found in file system entries."
                 )
                 .SetDefault(string.Empty);

                p.Setup(arg => arg.ReplaceWith)
                 .As("replaceWith")
                 .WithDescription(
                     "Sets the string to be substituted in file system entry names."
                 )
                 .SetDefault(string.Empty);

                p.Setup(arg => arg.RenameFiles)
                 .As("renameFiles")
                 .WithDescription("Indicates that files should be renamed.")
                 .SetDefault(true);

                p.Setup(arg => arg.RenameSubFolders)
                 .As("renameSubFolders")
                 .WithDescription("Indicates that folders should be renamed.")
                 .SetDefault(true);

                p.Setup(arg => arg.ReplaceinFiles)
                 .As("replaceInFiles")
                 .WithDescription("Indicates that text should be replaced in files.")
                 .SetDefault(true);

                p.Setup(arg => arg.MatchCase)
                 .As("replaceInFiles")
                 .WithDescription("Indicates that a case-sensitive search should be performed.")
                 .SetDefault(true);

                p.Setup(arg => arg.MatchWholeWord)
                 .As("replaceInFiles")
                 .WithDescription("Indicates that a case-sensitive search should be performed.")
                 .SetDefault(true);

                p.SetupHelp("?", "help")
                 .Callback(text => Console.WriteLine(text));

                var parsingResult = p.Parse(args);
                if (parsingResult.HasErrors)
                    throw new InvalidOperationException(
                        "ERROR: Failed to parse command line."
                    );

                result = p.Object;
            }
            catch
            {
                if (p != null && p.Options.Any())
                    p.HelpOption.ShowHelp(p.Options);

                Environment.Exit(-1);
            }

            return result;
        }
    }
}