using MFR.Engines.Replacement.Intefaces;
using MFR.Expressions.Matches.Interfaces;
using MFR.Operations.Constants;
using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Engines.Replacement
{
    /// <summary>
    /// Defines the methods, properties, and events that are common to all
    /// text-replacement engine object implementations.
    /// </summary>
    public abstract class
        TextReplacementEngineBase : ConfigurationComposedObjectBase,
            ITextReplacementEngine
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Engines.Replacement.TextReplacementEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected TextReplacementEngineBase()
        {
            // TODO: Add default object-initialization code here.
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.TextReplacementEngineBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="projectFileRenamerConfiguration">
        /// (Required.) Reference to an
        /// instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface that
        /// holds settings that are specified by the user.
        /// </param>
        /// <exception
        ///     cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="projectFileRenamerConfiguration" />, is passed a
        /// <see
        ///     langword="null" />
        /// value.
        /// </exception>
        [Log(AttributeExclude = true)]
        protected TextReplacementEngineBase(
            IProjectFileRenamerConfiguration projectFileRenamerConfiguration) :
            base(projectFileRenamerConfiguration) { }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user projectFileRenamerConfiguration and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigurationProvider
            ConfigurationProvider
            => GetProjectFileRenamerConfigurationProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </summary>
        public override IProjectFileRenamerConfiguration CurrentConfiguration
        {
            get;
            set;
        } = ConfigurationProvider.CurrentConfiguration;

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public abstract OperationType OperationType
        {
            get;
        }

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="value" />. Returns a string
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data upon which the replacement
        /// operation is to be carried out.
        /// </param>
        /// <param name="pattern">
        /// (Required.) String containing the pattern that allows us to match
        /// the data to be replaced.
        /// </param>
        /// <param name="dest">
        /// (Optional.) Default is blank. String containing the new data that
        /// should be substituted for the replaced text.
        /// </param>
        /// <returns>
        /// String containing the new data.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// or <paramref name="pattern" />, are passed blank or
        /// <see langword="null" /> string for values.
        /// </exception>
        public abstract string Replace(string value, string pattern,
            string dest = "");

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="expression" />. Returns a string
        /// containing the results.
        /// </summary>
        /// <param name="expression">
        /// (Required.) A
        /// <see
        ///     cref="T:MFR.MatchExpression" />
        /// that contains the
        /// replacement data.
        /// </param>
        /// <returns>
        /// String containing the new data.
        /// </returns>
        public string Replace(IMatchExpression expression)
        {
            var result = string.Empty;

            try
            {
                if (expression == null) return result;

                result = Replace(
                    expression.Value, expression.FindWhat, expression.ReplaceWith
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}