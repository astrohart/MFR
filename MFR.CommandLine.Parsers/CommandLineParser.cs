using Fclp;
using MFR.CommandLine.Constants;
using MFR.CommandLine.Models.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;

namespace MFR.CommandLine.Parsers
{
    /// <summary>
    /// Manages the parsing and validation of the command line of the application.
    /// </summary>
    public class CommandLineParser
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CommandLineParser()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CommandLineParser()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.CommandLine.Parsers.CommandLineParser"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static CommandLineParser Instance
        {
            get;
        } = new CommandLineParser();

        /// <summary>
        /// Parses the application's command-line arguments and sets the properties
        /// of a new instance of <see cref="T:UserQuery.CommandLineInfo" />
        /// accordingly.
        /// </summary>
        /// <param name="args">
        /// (Required.) Array containing the command-line arguments passed to this
        /// application.
        /// </param>
        public ICommandLineInfo ParseCommandLine(string[] args)
        {
            var result = new CommandLineInfo();
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