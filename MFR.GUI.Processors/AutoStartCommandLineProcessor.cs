using MFR.CommandLine.Translators;
using MFR.GUI.Dialogs.Factories;
using MFR.GUI.Processors.Constants;
using MFR.GUI.Processors.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System.Windows.Forms;

namespace MFR.GUI.Processors
{
    /// <summary>
    /// Processes the command line of the application in the event the application is
    /// auto-started; i.e., it is configured and ran on the command line by another
    /// tool as part of a pipeline or workflow.
    /// </summary>
    public class AutoStartCommandLineProcessor : CommandLineProcessorBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static AutoStartCommandLineProcessor() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected AutoStartCommandLineProcessor() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.GUI.Processors.Interfaces.ICommandLineProcessor" /> interface
        /// and that represents the command-line processor that acts when the user
        /// specifies the <c>--autoStart</c> flag on the command line.
        /// </summary>
        public static ICommandLineProcessor Instance
        {
            get;
        } = new AutoStartCommandLineProcessor();

        /// <summary>
        /// Gets a <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" />
        /// enumeration value that identifies the type of processing this processor does.
        /// </summary>
        public override CommandLineProcessorType Type
            => CommandLineProcessorType.AutoStart;

        /// <summary>
        /// Executes the processing specified by this processor type.
        /// </summary>
        public override void Process()
        {
            // Set the current configuration to the one specified on the command line.
            CurrentConfig = CommandLineInfo.ToConfig();

            Application.Run(
                (Form)GetAutoStartCancellableProgressDialog.SoleInstance()
            );
        }
    }
}