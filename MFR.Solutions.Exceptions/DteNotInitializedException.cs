using System;

namespace MFR.Solutions.Exceptions
{
    /// <summary>
    /// Thrown when a variable designed to hold a reference to an instance of an
    /// object that implements the <see cref="T:EnvDTE.DTE" /> interface and
    /// which is needed for the current operation has not yet been initialized.
    /// </summary>
    public class DteNotInitializedException : Exception
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Solutions.Exceptions.DteNotInitializedException" />
        /// and returns a reference to it.
        /// </summary>
        public DteNotInitializedException() : base(
            "Please ensure the required DTE variable has been initialized."
        ) { }
    }
}