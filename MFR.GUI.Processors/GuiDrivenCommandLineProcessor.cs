using MFR.CommandLine.Translators;
using MFR.GUI.Processors.Constants;
using MFR.GUI.Processors.Interfaces;
using MFR.GUI.Windows.Factories;
using MFR.GUI.Windows.Interfaces;
using System.Diagnostics;
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
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static GuiDrivenCommandLineProcessor()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected GuiDrivenCommandLineProcessor()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.GUI.Processors.Interfaces.ICommandLineProcessor" /> interface
        /// and which represents the processor that allows the application's user interface
        /// to be shown, but with command-line argument values specifying the settings of
        /// the controls.
        /// </summary>
        public static ICommandLineProcessor Instance
        {
            [DebuggerStepThrough]
            get;
        } = new GuiDrivenCommandLineProcessor();

        /// <summary>
        /// Gets a <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" />
        /// enumeration value that identifies the type of processing this processor does.
        /// </summary>
        public override CommandLineProcessorType Type
            => CommandLineProcessorType.GuiDriven;

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.GUI.Windows.Interfaces.IMainWindow" /> interface that
        /// represents the main window of the application.
        /// </summary>
        private static IMainWindow MainWindow
        {
            [DebuggerStepThrough]
            get;
        } = GetMainWindow.SoleInstance();

        /// <summary>
        /// Executes the processing specified by this processor type.
        /// </summary>
        public override void Process()
        {
            // Set the current configuration to the one specified on the command line.
            CurrentConfig = CommandLineInfo.ToConfig();

            MainWindow.AttachCommandLineInfo(CommandLineInfo);

            Application.Run((Form)MainWindow);
        }
    }
}