using System;
using System.IO;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Common string constants for use in unit tests.
    /// </summary>
    public static class StringConstants
    {
        public const string PORTFOLIO_MONITOR_X_UDL_FILE =
            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\x.udl";

        /// <summary>
        /// The executable filename of the DevEnv (Visual Studio) application.
        /// </summary>
        public const string DEVENV_FILENAME = "devenv.exe";

        /// <summary>
        /// String containing the path to a 'dotfolder' -- i.e., a folder whose
        /// name starts with a dot.
        /// </summary>
        public const string DOTFOLDER_PATH = @"C:\Users\Administrator\.android";

        /// <summary>
        /// String containing the path of a folder that the RenameSubFolder
        /// operation would consider fair game for acting upon.
        /// </summary>
        public const string FOLDER_MATCHING_OPERATION_CRITIERIA =
            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\PortfolioMonitor.Allocators.Interfaces";

        /// <summary>
        /// String consisting of complete gibberish.
        /// </summary>
        public const string GIBBERISH = "kjfsadjlksdfajlksdfkjldf";

        /// <summary>
        /// String consisting of the path to a subfolder of a project's \bin folder.
        /// </summary>
        public const string SUBFOLDER_OF_BIN_DIR =
            @"C:\Users\Administrator\source\repos\astrohart\MassFileRenamer\MassFileRenamer.Objects.Tests\bin\x86\Release";

        /// <summary>
        /// String consisting of the path to a subfolder of a solution's \.git
        /// repository folder.
        /// </summary>
        public const string SUBFOLDER_OF_GIT_FOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\.git\info";

        /// <summary>
        /// String consisting of the path to a subfolder of a project's \obj folder.
        /// </summary>
        public const string SUBFOLDER_OF_OBJ_FOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\MassFileRenamer\MassFileRenamer.Objects.Tests\obj\x86\Release";

        /// <summary>
        /// String consisting of the path to a subfolder of the '\packages'
        /// folder of a solution.
        /// </summary>
        public const string SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\packages\EntityFramework.6.4.4";

        /// <summary>
        /// String consisting of the path to a subfolder of a solution's '\.vs' dotfolder.
        /// </summary>
        public const string SUBFOLDER_OF_VS_DOTFOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\.vs\PortfolioMonitor";

        /// <summary>
        /// Constant containing whitespace (three spaces and a tab character).
        /// </summary>
        public const string WHITESPACE = "   \t";

        /// <summary>
        /// Constant whose value is the empty string.
        /// </summary>
        public static readonly string EMPTY_STRING = string.Empty;

        /// <summary>
        /// String consisting of the path to a file. The path contains only
        /// gibberish, so the file referenced is, more or less, guaranteed not
        /// to exist on the disk.
        /// </summary>
        public static readonly string NONEXISTENT_FILE =
            @"C:\jkldasklopwmas\alwfvowlf\alrfn.sklj";

        /// <summary>
        /// String consisting of the path to a folder that we can guarantee will
        /// not exist on the system.
        /// </summary>
        public static readonly string NONEXISTENT_FOLDER =
            $@"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\{GIBBERISH}";

        public static readonly string NOTEPAD_PATH = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.System),
            "NOTEPAD.EXE"
        );

        /// <summary>
        /// Constant whose value is the null string.
        /// </summary>
        public static readonly string NULL_STRING = null;

        /// <summary>
        /// String consisting of the path to the Windows System32 folder.
        /// </summary>
        public static readonly string WINDOWS_SYSTEM_FOLDER = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Windows),
            "System32"
        );
    }
}