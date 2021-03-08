using System.Collections.Generic;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Defines the public-exposed methods and properties of an object that
    /// provides the process ID (PID) of a running process.
    /// </summary>
    public interface IProcessIdProvider
    {
        /// <summary>
        /// Gets the Process ID (PID) of the running process with the .exe file
        /// with the <paramref name="path" /> specified.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the filename or fully-qualified
        /// pathname, of hte .exe file that you think is currently a running process.
        /// </param>
        /// <returns>
        /// Integer whose value is set to the ID of the first process whose .exe
        /// filename matches the specified <paramref name="path" />; <c>-1</c> if
        /// no matches can be found. Process IDs are always positive integers.
        /// </returns>
        int GetProcessIDOf(string path);

        /// <summary>
        /// Gets a collection of integers representing the process IDs of all the currently-executing instances of the .exe file with the specified <paramref name="path"/>.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the filename or fully-qualified
        /// pathname, of hte .exe file that you think is currently a running process.
        /// </param>
        /// <returns></returns>
        IEnumerable<int> GetAllProcessIDsOf(string path);
    }
}