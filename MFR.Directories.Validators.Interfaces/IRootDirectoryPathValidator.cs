using MFR.Directories.Validators.Events;
using MFR.Validators.Interfaces;

namespace MFR.Directories.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that
    /// validates the pathnames of root directories; i.e., the folder where the
    /// project-rename operation starts..
    /// </summary>
    public interface  IRootDirectoryPathValidator : IValidator
    {
        /// <summary>
        /// Occurs when validation rules have determined that the value of the
        /// <see
        ///     cref="P:MFR.CommandLine.CommandLineInfo.RootDirectory" />
        /// property is invalid.
        /// </summary>
        event RootDirectoryInvalidEventHandler RootDirectoryInvalid;

        /// <summary>
        /// Gets a value that determines whether the specified
        /// <paramref
        ///     name="rootDirectory" />
        /// is valid or not.
        /// <para />
        /// A "root directory" is defined to be the starting folder of a
        /// project-rename operation.
        /// <para />
        /// It must exist on the file system, and it must contain a Visual Studio
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
        ///     cref="E:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator.RootDirectoryInvalid" />
        /// event.
        /// </remarks>
        bool Validate(string rootDirectory);
    }
}