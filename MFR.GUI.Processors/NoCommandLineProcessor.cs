using MFR.GUI.Processors.Constants;
using MFR.GUI.Processors.Interfaces;
using MFR.GUI.Windows.Factories;
using PostSharp.Patterns.Diagnostics;
using System.Windows.Forms;

namespace MFR.GUI.Processors
{
    /// <summary>
    /// Processes operations that occur when the user launches the application with
    /// nothing specified on the command line.
    /// </summary>
    public class NoCommandLineProcessor : CommandLineProcessorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static NoCommandLineProcessor() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected NoCommandLineProcessor() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.GUI.Processors.Interfaces.ICommandLineProcessor" /> interface
        /// and which represents the processor that supports the use case when the user
        /// supplies nothing on the application's command line at launch.
        /// </summary>
        public static ICommandLineProcessor Instance
        {
            get;
        } = new NoCommandLineProcessor();

        /// <summary>
        /// Gets a <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" />
        /// enumeration value that identifies the type of processing this processor does.
        /// </summary>
        public override CommandLineProcessorType Type
            => CommandLineProcessorType.NoCommandLine;

        /// <summary>
        /// Executes the processing specified by this processor type.
        /// </summary>
        public override void Process()
            => Application.Run((Form)GetMainWindow.SoleInstance());
    }
}