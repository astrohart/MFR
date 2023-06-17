using MFR.Settings.Configuration.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Actions
{
    public static class Is
    {
        /// <summary>
        /// Determines whether the specified <paramref name="configuration" /> is blank or
        /// not.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="configuration" /> is the blank application configuration or if
        /// a <see langword="null" /> reference is passed as the argument of the
        /// <paramref name="configuration" /> parameter; <see langword="false" />
        /// otherwise.
        /// </returns>
        public static bool ConfigurationBlankOrNull(
            IProjectFileRenamerConfiguration configuration
        )
        {
            var result = true;

            try
            {
                if (configuration == null) return result;

                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = true;
            }

            return result;
        }
    }
}