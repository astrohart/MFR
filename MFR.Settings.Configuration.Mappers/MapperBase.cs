using MFR.Settings.Configuration.Mappers.Constants;
using MFR.Settings.Configuration.Mappers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Configuration.Mappers
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all
    /// configuration-string mapper classes.
    /// </summary>
    public abstract class MapperBase : IConfigurationStringMapper
    {
        /// <summary>
        /// Initializes static data or performs actions that need to be performed once only
        /// for the <see cref="T:MFR.Settings.Configuration.Mappers.MapperBase" /> class.
        /// </summary>
        /// <remarks>
        /// This constructor is called automatically prior to the first instance being
        /// created or before any static members are referenced.
        /// <para />
        /// We've decorated this constructor with the <c>[Log(AttributeExclude = true)]</c>
        /// attribute in order to simplify the logging output.
        /// </remarks>
        [Log(AttributeExclude = true)]
        static MapperBase() { }

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Settings.Configuration.Mappers.MapperBase" /> and returns a
        /// reference to it.
        /// </summary>
        /// <remarks>
        /// <strong>NOTE:</strong> This constructor is marked <see langword="protected" />
        /// due to the
        /// fact that this class is marked <c>abstract</c>.
        /// </remarks>
        [Log(AttributeExclude = true)]
        protected MapperBase()
        {
            InitializeMappingDictionary();
        }

        /// <summary>
        /// Gets a reference to the replacement dictionary to be used for mapping.
        /// </summary>
        protected IDictionary<string, string> InternalMappingDictionary
        {
            get;
        } = new Dictionary<string, string>();

        /// <summary>
        /// Gets or sets a value that indicates whether this mapper replaces <c>\r\n</c>
        /// with <c>\n</c> in strings that it receives.
        /// </summary>
        public abstract bool ReplaceCRLFWithNewline
        {
            get;
        }

        /// <summary>
        /// One of the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Mappers.Constants.ConfigurationStringMapperType" />
        /// enumeration values that defines what type of mapper object this.
        /// </summary>
        public abstract ConfigurationStringMapperType Type
        {
            get;
        }

        /// <summary>
        /// Carries out the replacement as configured.
        /// </summary>
        /// <param name="input">
        /// (Required.) A <see cref="T:System.String" /> value to be
        /// mapped.
        /// </param>
        /// <returns>A <see cref="T:System.String" /> value containing the replaced values.</returns>
        [return: NotLogged]
        public virtual string Map([NotLogged] string input)
        {
            var result = input;

            try
            {
                if (string.IsNullOrWhiteSpace(input)) return result;
                if (!InternalMappingDictionary.Any()) return result;

                result = InternalMappingDictionary.Keys.Where(
                                                      key => !string
                                                          .IsNullOrWhiteSpace(
                                                              key
                                                          )
                                                  )
                                                  .Where(input.Contains)
                                                  .Aggregate(
                                                      result,
                                                      (current, key)
                                                          => current.Replace(
                                                              key,
                                                              InternalMappingDictionary
                                                                  [key]
                                                          )
                                                  );

                if (string.IsNullOrWhiteSpace(result)) return result;

                if (ReplaceCRLFWithNewline)
                    result = result.Replace("\r\n", "\n");
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = input;
            }

            return result;
        }

        /// <summary>
        /// Called to initialize the mapping dictionary for the replacement parameters.
        /// </summary>
        protected abstract void OnInitializeMapping();

        /// <summary>
        /// Called to initialize the mapping dictionary for the replacement parameters.
        /// </summary>
        private void InitializeMappingDictionary()
        {
            try
            {
                InternalMappingDictionary.Clear();

                OnInitializeMapping();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}