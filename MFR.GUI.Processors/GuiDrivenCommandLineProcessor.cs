using MFR.CommandLine.Translators;
using MFR.GUI.Processors.Constants;
using MFR.GUI.Windows.Factories;
using System.Windows.Forms;

namespace MFR.GUI.Processors
{
    /// <summary>
    /// Processes the command line, filling in form fields on the GUI with values
    /// supplied by the user on the command line but otherwise does not run automated
    /// operations.
    /// </summary>
    public class GuiDrivenCommandLineProcessor : CommandLineProcessorBase
    {
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
            CurrentConfiguration = CommandLineInfo.ToConfiguration();

            Application.Run((Form)GetMainWIndow.SoleInstance());
        }
    }
}