using MFR.Settings.Configuration.Mappers.Constants;
using MFR.Settings.Configuration.Mappers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Mappers
{
    /// <summary>
    /// Maps values that are user-configured for replacement parameters in a default
    /// commit message to format specifiers for the actual message value.
    /// </summary>
    public class CommitMessageMapper : MapperBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static CommitMessageMapper() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected CommitMessageMapper() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper" />
        /// interface that represents a configuration string mapper object that is meant to
        /// act on replacement parameters that are found in detailed commit messages.
        /// </summary>
        public static IConfigurationStringMapper Instance
        {
            get;
        } = new CommitMessageMapper();

        /// <summary>
        /// Gets or sets a value that indicates whether this mapper replaces <c>\r\n</c>
        /// with <c>\n</c> in strings that it receives.
        /// </summary>
        public override bool ReplaceCRLFWithNewline
        {
            get;
        } = true;

        /// <summary>
        /// One of the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType" />
        /// enumeration values that defines what type of mapper object this.
        /// </summary>
        public override ConfigurationStringMapperType Type
        {
            get;
        } = ConfigurationStringMapperType.CommitMessage;

        /// <summary>
        /// Called to initialize the mapping dictionary for the replacement parameters.
        /// </summary>
        protected override void OnInitializeMapping()
        {
            try
            {
                InternalMappingDictionary.Add(
                    CommitMessageReplacementParameter.ShortTime, "{0}"
                );
                InternalMappingDictionary.Add(
                    CommitMessageReplacementParameter.ShortDate, "{1}"
                );
                InternalMappingDictionary.Add(
                    CommitMessageReplacementParameter.FindWhat, "{2}"
                );
                InternalMappingDictionary.Add(
                    CommitMessageReplacementParameter.ReplaceWith, "{3}"
                );
                InternalMappingDictionary.Add(
                    CommitMessageReplacementParameter.RootDir, "{4}"
                );
                InternalMappingDictionary.Add(
                    CommitMessageReplacementParameter.Timezone, "{5}"
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}