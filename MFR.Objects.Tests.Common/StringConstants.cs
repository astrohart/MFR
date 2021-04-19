using Alphaleonis.Win32.Filesystem;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Text.RegularExpressions;

namespace MFR.Objects.Tests.Common
{
    /// <summary>
    /// Common string constants for use in unit tests.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class StringConstants
    {
        /// <summary>
        /// The executable filename of the DevEnv (Visual Studio) application.
        /// </summary>
        public const string DEVENV_FILENAME = "devenv.exe";

        /// <summary>
        /// String that contains a fake project name.
        /// </summary>
        public const string FAKE_PROJECT_NAME_WITH_DOTS = "Foo.Bar.Baz.Boid";

        /// <summary>
        /// String containing the fully-qualified pathname of a file that
        /// matches the criteria for operating upon.
        /// </summary>
        public const string FILE_MATCHING_OPERATIONAL_CRITERIA =
            @"C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Interop.LibGit2Sharp\Foo\Foo.csproj";

        /// <summary>
        /// String containing the path of a folder that the RenameSubFolder
        /// operation would consider fair game for acting upon.
        /// </summary>
        public const string FOLDER_MATCHING_OPERATION_CRITIERIA =
            @"C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Interop.LibGit2Sharp\Foo";

        /// <summary>
        /// String consisting of complete gibberish.
        /// </summary>
        public const string GIBBERISH = "kjfsadjlksdfajlksdfkjldf";

        /// <summary>
        /// String containing the path to a .csproj file in the Junk Solution
        /// that has factory objects.
        /// </summary>
        public const string
            JUNK_SOLUTION_PROCESSORS_FACTORIES_CSPROJ_FILE_PATH =
                @"C:\Users\Administrator\source\junk\MyJunkSolution\MyJunkSolution.Processors.Factories\MyJunkSolution.Processors.Factories.csproj";

        /// <summary>
        /// String containing the path to the .sln file for the Mass File
        /// Renamer project.
        /// </summary>
        public const string MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH =
            @"C:\Users\Administrator\source\repos\astrohart\MFR\MFR.sln";

        /// <summary>
        /// String containing the fully-qualified pathname of a file that is in
        /// a <c>bin\</c> folder of a particular project.
        /// </summary>
        public const string PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\MassFileRenamer\MFR.Objects.Tests\bin\x86\Release\Newtonsoft.Json.dll";

        /// <summary>
        /// String containing the fully-qualified pathname of one of the index
        /// files that are commonly found in a Git repository's <c>.git</c> dotfolder.
        /// </summary>
        public const string PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Interop.LibGit2Sharp\.git\ORIG_HEAD";

        /// <summary>
        /// String containing the path to the file <c>x.udl</c> under the
        /// Portfolio Monitor solution folder.
        /// </summary>
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
            @"C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Interop.LibGit2Sharp\.git\info";

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
            @"C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Interop.LibGit2Sharp\packages\EntityFramework.6.4.4";

        /// <summary>
        /// String consisting of the path to a subfolder of a solution's '\.vs' dotfolder.
        /// </summary>
        public const string SUBFOLDER_OF_VS_DOTFOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Interop.LibGit2Sharp\.vs\xyLOGIX.Interop.LibGit2Sharp";

        /// <summary>
        /// Constant containing whitespace (three spaces and a tab character).
        /// </summary>
        public const string WHITESPACE = "   \t";

        /// <summary>
        /// String containing the fully-qualified pathname of a file that is
        /// inside the <c>obj\</c> folder of a project.
        /// </summary>
        public const string PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Interop.LibGit2Sharp\xyLOGIX.Interop.LibGit2Sharp\obj\x64\Debug\xyLOGIX.Interop.LibGit2Sharp.csprojAssemblyReference.cache";

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
        /// String consisting of the same value as the
        /// <see
        ///     cref="F:MFR.Objects.Tests.Common.StringConstants.EXISTING_TEMP_FILE" />
        /// constant, but only containing the filename and extension of the file
        /// instead of the full path.
        /// </summary>
        public static readonly string EXISTING_TEMP_FILE_FILENAME_ONLY =
            Path.GetFileName(EXISTING_TEMP_FILE);

        /// <summary>
        /// String containing a regex searching for the
        /// <see
        ///     cref="F:MFR.Objects.Tests.Common.StringConstants.FAKE_PROJECT_NAME_WITH_DOTS" />
        /// constant's value as an exact-word match.
        /// </summary>
        public static readonly string
            FAKE_PROJECT_NAME_WITH_DOTS_EXACT_WORD_MATCH_REGEX =
                $@"(?<![\w]){Regex.Escape(FAKE_PROJECT_NAME_WITH_DOTS)}(?(?=\S)(?=[a-z.]*[^A-Z.])|(?![\w]))";

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

        /// <summary>
        /// String consisting of the same text as the
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
        /// String containing the path to a folder that is guaranteed to exist.
        /// </summary>
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
        /// String consisting of the path to a folder that we can guarantee will
        /// not exist on the system.
        /// </summary>
        public static readonly string NONEXISTENT_FOLDER = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Windows), Guid
                .NewGuid()
                .ToString("N")
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

        /// <summary>
        /// String containing the fully-qualified pathname of a file that is
        /// located within the <c>packages</c> subfolder of a solution.
        /// </summary>
        public const string PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER =
            @"C:\Users\Administrator\source\repos\astrohart\xyLOGIX.Interop.LibGit2Sharp\packages\log4net.2.0.12\log4net.2.0.12.nupkg";
    }
}