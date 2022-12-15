using MFR.CommandLine.Translators;
using MFR.Engines.Constants;
using MFR.Engines.Factories;
using MFR.Engines.Interfaces;
using MFR.GUI.Processors.Constants;

namespace MFR.GUI.Processors
{
    public class AutoStartCommandLineProcessor : CommandLineProcessorBase
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

            IFullGuiOperationEngine engine = GetOperationEngine
                                             .OfType<IFullGuiOperationEngine>(
                                                 OperationEngineType.FullGUI
                                             )
                                             .AndAttachConfiguration(
                                                 CurrentConfiguration
                                             );

            engine.ProcessAll(
                CurrentConfiguration.StartingFolder,
                CurrentConfiguration.FindWhat, CurrentConfiguration.ReplaceWith
            );
        }
    }
}