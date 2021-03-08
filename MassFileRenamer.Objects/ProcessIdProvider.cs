using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Provides the Process IDs (PIDs) of programs that are running on the
    /// local machine.
    /// </summary>
    public class ProcessIdProvider : IProcessIdProvider
    {
        /// <summary>
        /// Gets a collection of integers representing the process IDs of all
        /// the currently-executing instances of the .exe file with the
        /// specified <paramref name="path" />.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the filename or fully-qualified
        /// pathname, of hte .exe file that you think is currently a running process.
        /// </param>
        /// <returns>
        /// </returns>
        public IEnumerable<int> GetAllProcessIDsOf(string path)
        {
            var result = new List<int>();

            if (string.IsNullOrWhiteSpace(path)) return result;

            try
            {
                result = Process
                         .GetProcessesByName(
                             Path.GetFileNameWithoutExtension(path)
                         )
                         .Select(p => p.Id)
                         .ToList();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = new List<int>();
            }

            return result;
        }

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
        public int GetProcessIDOf(string path)
        {
            var result = -1;

            if (string.IsNullOrWhiteSpace(path)) return result;

            try
            {
                var procs = Process.GetProcessesByName(
                    Path.GetFileNameWithoutExtension(path)
                );
                if (!procs.Any()) return result;

                result = procs.First()
                              .Id;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = -1;
            }

            return result;
        }
    }
}