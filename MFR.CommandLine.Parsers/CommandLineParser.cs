using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFR.CommandLine.Parsers
{
    /// <summary>
    /// Manages the parsing and validation of the command line of the application.
    /// </summary>
    public class CommandLineParser
    {
        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MFR.CommandLine.Parsers.CommandLineParser"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static CommandLineParser Instance
        {
            get;
        } = new CommandLineParser();

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
    }
}