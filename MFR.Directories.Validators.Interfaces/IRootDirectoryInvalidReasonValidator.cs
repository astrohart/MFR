using MFR.Directories.Validators.Constants;

namespace MFR.Directories.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// validates data variables whose values are purported to fall within the defined
    /// value set of the
    /// <see cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
    /// enumeration..
    /// </summary>
    public interface IRootDirectoryInvalidReasonValidator
    {
        /// <summary>
        /// Determines whether the specified <paramref name="reason" /> is actually within
        /// the defined value set of the
        /// <see cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// enumeration.
        /// </summary>
        /// <param name="reason">
        /// (Required.) One of the
        /// <see cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// enumeration value(s) that is to be examined.
        /// </param>
        /// <remarks>
        /// If
        /// <see
        ///     cref="F:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason.Unknown" />
        /// is the value of the <paramref name="reason" /> parameter, then this method
        /// returns <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="reason" /> is
        /// within the defined value set of the
        /// <see cref="T:MFR.Directories.Validators.Constants.RootDirectoryInvalidReason" />
        /// enumeration; <see langword="false" /> otherwise.
        /// </returns>
        bool IsValid(RootDirectoryInvalidReason reason);
    }
}