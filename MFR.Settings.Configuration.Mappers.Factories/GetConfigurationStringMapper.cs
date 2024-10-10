using MFR.Settings.Configuration.Mappers.Constants;
using MFR.Settings.Configuration.Mappers.Factories;
using MFR.Settings.Configuration.Mappers.Interfaces;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Mappers
{
    /// <summary>
    /// Obtains references to instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper" />
    /// interface for the various supported
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType" />
    /// enumeration values.
    /// </summary>
    public static class GetConfigurationStringMapper
    {
        /// <summary>
        /// Attempts to obtain a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper" />
        /// interface for the specified <paramref name="type" /> of configuration-string
        /// mapper.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType" />
        /// values that indicates the type of mapper you wish to obtain a reference to.
        /// </param>
        /// <returns>
        /// If a mapper object of the specified <paramref name="type" /> is found,
        /// then a reference to an instance of the object is returned; otherwise, a
        /// <see langword="null" /> reference is returned.
        /// </returns>
        public static IConfigurationStringMapper OfType(
            ConfigurationStringMapperType type
        )
        {
            IConfigurationStringMapper result = default;

            try
            {
                switch (type)
                {
                    case ConfigurationStringMapperType.CommitMessage:
                        result = GetCommitMessageMapper.SoleInstance();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(
                            nameof(type), type,
                            $"The specified configuration-string mapper type, '{type}', is not supported."
                        );
                }
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