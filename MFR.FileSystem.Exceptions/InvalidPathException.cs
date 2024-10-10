using System;

namespace MFR.FileSystem.Exceptions
{
    /// <summary>
    /// Class that encapsulates a custom type of exception that allows us to
    /// tell the developer that a variable contains an invalid pathname, i.e., a
    /// pathname that does not satisfy operating-system rules.
    /// </summary>
    public class InvalidPathException : ArgumentException
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.FileSystem.Exceptions.InvalidPathException"/> and returns
        /// a reference to it.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="path">
        /// String containing the pathname that ended up being found to be invalid.
        /// </param>
        public InvalidPathException(string message, string path) : base(message)
        {
            InitializePath(path);
        }

        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.FileSystem.Exceptions.InvalidPathException"/> and returns
        /// a reference to it.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="paramName">
        /// The name of the parameter that caused the current exception.
        /// </param>
        /// <param name="path">
        /// String containing the pathname that ended up being found to be invalid.
        /// </param>
        public InvalidPathException(string message, string path,
            string paramName) : base(message, paramName)
        {
            InitializePath(path);
        }

        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.FileSystem.Exceptions.InvalidPathException"/> and returns
        /// a reference to it.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="path">
        /// String containing the pathname that ended up being found to be invalid.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception. If the
        /// <paramref name="innerException"/> parameter is not a null reference,
        /// the current exception is raised in a <see langword="catch"/> block
        /// that handles the inner exception.
        /// </param>
        public InvalidPathException(string message, string path,
            Exception innerException) : base(message, innerException)
        {
            InitializePath(path);
        }

        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.FileSystem.Exceptions.InvalidPathException"/> and returns
        /// a reference to it.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="path">
        /// String containing the pathname that ended up being found to be invalid.
        /// </param>
        /// <param name="paramName">
        /// The name of the parameter that caused the current exception.
        /// </param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception. If the
        /// <paramref name="innerException"/> parameter is not a null reference,
        /// the current exception is raised in a <see langword="catch"/> block
        /// that handles the inner exception.
        /// </param>
        public InvalidPathException(string message, string path,
            string paramName, Exception innerException) : base(
            message, paramName, innerException
        )
        {
            InitializePath(path);
        }

        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.FileSystem.Exceptions.InvalidPathException"/> and returns
        /// a reference to it.
        /// </summary>
        /// <remarks>
        /// This constructor overload is protected, meaning that callers of this
        /// class are forced to use one of the other constructor overloads that
        /// take parameters.
        /// </remarks>
        protected InvalidPathException()
        {
        }

        /// <summary>
        /// Gets a string containing the pathname that failed to meet operating
        /// system rules.
        /// </summary>
        public string Path
        {
            get;
            private set;
        }

        private void InitializePath(string path)
        {
            Path = path;
        }
    }
}