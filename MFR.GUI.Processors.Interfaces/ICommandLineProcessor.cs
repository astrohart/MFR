using MFR.CommandLine.Models.Interfaces;
using MFR.GUI.Processors.Constants;

namespace MFR.GUI.Processors.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a command-line processor
    /// object.
    /// </summary>
    public interface ICommandLineProcessor
    {
        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.CommandLine.Models.Interfaces.ICommandLineInfo" /> interface
        /// from which settings should be read.
        /// </summary>
        ICommandLineInfo CommandLineInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a <see cref="T:MFR.GUI.Processors.Constants.CommandLineProcessorType" />
        /// enumeration value that identifies the type of processing this processor does.
        /// </summary>
        CommandLineProcessorType Type
        {
            get;
        }

        /// <summary>
        /// Executes the processing specified by this processor type.
        /// </summary>
        void Process();
    }
}