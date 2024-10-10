using MFR.Settings.Configuration.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Actions
{
    public static class Is
    {
        /// <summary>
        /// Determines whether the specified <paramref name="config" /> is blank or
        /// not.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified
        /// <paramref name="config" /> is the blank application config or if
        /// a <see langword="null" /> reference is passed as the argument of the
        /// <paramref name="config" /> parameter; <see langword="false" />
        /// otherwise.
        /// </returns>
        public static bool ConfigurationBlankOrNull(
            IProjectFileRenamerConfig config
        )
        {
            var result = true;

            try
            {
                if (config == null) return result;

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