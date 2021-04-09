using System;
using System.IO;

namespace MFR.Objects.Tests.Common
{
    /// <summary>
    /// Common string constants for use in unit tests.
    /// </summary>
    public static class StringConstants
    {
        /// <summary>
        /// The executable filename of the DevEnv (Visual Studio) application.
        /// </summary>
        public const string DEVENV_FILENAME = "devenv.exe";

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
        /// String containing the path to the .sln file for the Mass File
        /// Renamer project.
        /// </summary>
        public const string MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH =
            @"C:\Users\Administrator\source\repos\astrohart\MFR\MFR.sln";

        public const string PORTFOLIO_MONITOR_X_UDL_FILE =
            @"C:\Users\Administrator\source\repos\astrohart\PortfolioMonitor\x.udl";

        /// <summary>
        /// String consisting of the path to a subfolder of a project's \bin folder.
        /// </summary>
        public const string SUBFOLDER_OF_BIN_DIR =
            @"C:\Users\Administrator\source\repos\astrohart\MFR\MFR.Objects.Tests\bin\x86\Release";

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
            @"C:\Users\Administrator\source\repos\astrohart\MFR\MFR.Objects.Tests\obj\x86\Release";

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
        /// String containing the path to a 'dotfolder' -- i.e., a folder whose
        /// name starts with a dot.
        /// </summary>
        /// <remarks>
        /// Here, we pass the location of the .android folder, which is
        /// guaranteed to be exist under the %USERPROFILE% folder since the
        /// Visual Studio IDE is installed.
        /// </remarks>
        public static readonly string DOTFOLDER_PATH_KNOWN_TO_EXIST =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.UserProfile
                ), ".android"
            );

        /// <summary>
        /// Constant whose value is the empty string.
        /// </summary>
        public static readonly string EMPTY_STRING = string.Empty;

        /// <summary>
        /// String consisting of the fully-qualified pathname of a
        /// randomly-created, zero-length temporary file.
        /// </summary>
        public static readonly string EXISTING_TEMP_FILE =
            Path.GetTempFileName();

        /// <summary>
        /// String consisting of the path to a file that is guaranteed to exist
        /// on the local machine.
        /// </summary>
        /// <remarks>
        /// We started by making this constant equal to the path to NOTEPAD.EXE.
        /// </remarks>
        public static readonly string FILE_GUARANTEED_TO_EXIST = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.System),
            "NOTEPAD.EXE"
        );

        /// <summary String consisting of the same text as the
        /// <see
        ///     cref="F:MFR.Objects.Tests.Common.StringConstants.FILE_GUARANTEED_TO_EXIST" />
        /// constant, but with just a filename and extension.
        /// </summary>
        public static readonly string FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY =
            Path.GetFileName(FILE_GUARANTEED_TO_EXIST);

        /// <summary>
        /// String consisting of the filename and extension only of the
        /// <see
        ///     cref="F:MFR.Objects.Tests.Common.StringConstants.FILE_GUARANTEED_TO_EXIST" />
        /// constant.
        /// </summary>
        public static readonly string
            FILE_GUARANTEED_TO_EXIST_FILENAME_WITHOUT_EXTENSION =
                Path.GetFileNameWithoutExtension(FILE_GUARANTEED_TO_EXIST);

        /// <summary>
        /// String consisting of the path to a folder that we can guarantee will
        /// not exist on the system.
        /// </summary>
        public static readonly string NONEXISTENT_FOLDER =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Windows),
                Guid.NewGuid()
                    .ToString("N")
            );

        public static readonly string FOLDER_THAT_IS_GUARANTEED_TO_EXIST =
            Environment.GetFolderPath(Environment.SpecialFolder.Windows);

        /// <summary>
        /// String consisting of the fully-qualified pathname of a
        /// randomly-created, zero-length temporary file that is to be used in a
        /// file-rename operation test.
        /// </summary>
        public static readonly string NEW_TEMP_FILE = Path.GetTempFileName();

        /// <summary>
        /// String consisting of the same value as the
        /// <see
        ///     cref="F:MFR.Objects.Tests.Common.StringConstants.NEW_TEMP_FILE" />
        /// constant, but only containing the filename and extension of the file
        /// instead of the full path.
        /// </summary>
        public static readonly string NEW_TEMP_FILE_FILENAME_ONLY =
            Path.GetFileName(NEW_TEMP_FILE);

        /// <summary>
        /// String consisting of the path to a file. The path contains only
        /// gibberish, so the file referenced is, more or less, guaranteed not
        /// to exist on the disk.
        /// </summary>
        public static readonly string NONEXISTENT_FILE =
            @"C:\jkldasklopwmas\alwfvowlf\alrfn.sklj";

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

        /// <summary>
        /// String consisting of the same value as the
        /// <see
        ///     cref="F:MFR.Objects.Tests.Common.StringConstants.EXISTING_TEMP_FILE" />
        /// constant, but only containing the filename and extension of the file
        /// instead of the full path.
        /// </summary>
        private static readonly string EXISTING_TEMP_FILE_FILENAME_ONLY =
            Path.GetFileName(EXISTING_TEMP_FILE);
    }
}