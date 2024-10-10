using MFR.Matchers.Factories;
using MFR.Matchers.Interfaces;
using MFR.Operations.Constants;
using MFR.Settings.Configuration.Helpers;
using MFR.Settings.Configuration.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Engines.Matching.Actions
{
    /// <summary>
    /// Exposes static methods to get references to objects that perform
    /// <see cref="T:System.String" /> pattern-matching based on the current operation
    /// being performed and the current application config settings.
    /// </summary>
    public static class Get
    {
        /// <summary>
        /// Attempts to obtain a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface for the
        /// current operation.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface that
        /// corresponds to the current operation and matching config.
        /// </returns>
        public static IStringMatcher StringMatcherForOperation(
            OperationType operation,
            IProjectFileRenamerConfig config)
        {
            IStringMatcher result = default;

            try
            {
                result = GetStringMatcherFactory.For(operation)
                                                .AndTextMatchingConfiguration(
                                                    config
                                                        .GetTextMatchingConfiguration()
                                                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = default;
            }

            return result;
        }
    }
}