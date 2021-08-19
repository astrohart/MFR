using MFR.CommandLine.Constants;
using MFR.CommandLine.Validators.Constants;
using MFR.CommandLine.Validators.Events;
using MFR.CommandLine.Validators.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;
using Directory = Alphaleonis.Win32.Filesystem.Directory;

namespace MFR.CommandLine.Validators
{
    /// <summary>
    /// Validates the root directory of a project-rename operation.
    /// </summary>
    public class RootDirectoryValidator : IRootDirectoryValidator
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static RootDirectoryValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected RootDirectoryValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.CommandLine.Validators.RootDirectoryValidator" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static RootDirectoryValidator Instance
        {
            get;
        } = new RootDirectoryValidator();

        /// <summary>
        /// Gets a count of validation failures that occurred the last time the
        /// <see
        ///     cref="M:MFR.CommandLine.Validators.Interfaces.ICommandLineValidator.IsValid" />
        /// method was called.
        /// </summary>
        public int ValidationFailures
        {
            get;
            private set;
        }

        /// <summary>
        /// Occurs when validation rules have determined that the value of the
        /// <see
        ///     cref="P:MFR.CommandLine.CommandLineInfo.RootDirectory" />
        /// property is invalid.
        /// </summary>
        public event RootDirectoryInvalidEventHandler RootDirectoryInvalid;

        /// <summary>
        /// Gets a value that determines whether the specified
        /// <paramref
        ///     name="rootDirectory" />
        /// is valid or not.
        /// <para />
        /// A "root directory" is defined to be the starting folder of a
        /// project-rename operation.
        /// <para />
        /// It must exist on the disk, and it must contain a Visual Studio
        /// Solution (*.sln) file.
        /// </summary>
        /// <param name="rootDirectory">
        /// (Optional.) String containing the pathname of a root directory to be validated.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the pathname specified by the
        /// <paramref
        ///     name="rootDirectory" />
        /// parameter refers to a valid directory;
        /// <see
        ///     langword="false" />
        /// otherwise.
        /// </returns>
        /// <remarks>
        /// In the event that validation fails, this method raises the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator.RootDirectoryInvalid" />
        /// event.
        /// </remarks>
        public bool IsValid(string rootDirectory)
        {
            ValidationFailures = 0;

            try
            {
                if (Directories.MyDocuments.Equals(rootDirectory))
                    return true;    // this is a dummy directory; it's always "valid"

                /*
                 * OKAY, a root directory is defined to be the path to
                 * the folder in which a project-rename operation starts.
                 * In order for the pathname to such a folder to be valid,
                 * it has to refer to the pathname of a folder that actually
                 * exists on the disk (minor detail), and one which
                 * contains at least one Visual Studio Solution (*.sln) file.
                 */

                if (!Directory.Exists(rootDirectory))
                {
                    OnRootDirectoryInvalid(
                        new RootDirectoryInvalidEventArgs(
                            RootDirectoryInvalidReason.DoesntExist,
                            rootDirectory
                        )
                    );

                    ValidationFailures++;
                }

                if (Directory.Exists(rootDirectory)
                    && !Directory.EnumerateFiles(
                                  rootDirectory, "*.sln",
                                  SearchOption.TopDirectoryOnly
                              )
                              .Any())
                {
                    OnRootDirectoryInvalid(
                        new RootDirectoryInvalidEventArgs(
                            RootDirectoryInvalidReason.DoesntContainSolution,
                            rootDirectory
                        )
                    );

                    ValidationFailures++;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnRootDirectoryInvalid(
                    new RootDirectoryInvalidEventArgs(
                        RootDirectoryInvalidReason.Unknown,
                        rootDirectory, ex
                    )
                );

                ValidationFailures++;
            }

            /*
             * OKAY, validation succeeded if the ValidationFailures property is
             * still zero when we arrive at this line of code.
             */

            return ValidationFailures == 0;
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.CommandLine.Validators.RootDirectoryValidator.RootDirectoryInvalid" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MFR.CommandLine.Validators.Events.RootDirectoryInvalidEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnRootDirectoryInvalid(
            RootDirectoryInvalidEventArgs e)
            => RootDirectoryInvalid?.Invoke(this, e);
    }
}