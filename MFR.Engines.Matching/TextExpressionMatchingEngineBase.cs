using MFR.Engines.Matching.Interfaces;
using MFR.Expressions.Matches.Interfaces;
using MFR.Matchers.Factories;
using MFR.Matchers.Interfaces;
using MFR.Operations.Constants;
using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Helpers;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Engines.Matching
{
    /// <summary>
    /// Implements functionality common to all text-expression matcher objects.
    /// </summary>
    public abstract class TextExpressionMatchingEngineBase :
        ConfigurationComposedObjectBase, ITextExpressionMatchingEngine
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.Engines.Matching.TextExpressionMatchingEngineBase" />
        /// and returns a reference to it.
        /// </summary>
        protected TextExpressionMatchingEngineBase()
        {
            // TODO: Add default object-initialization code here.
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MFR.TextExpressionMatchingEngineBase" />
        /// and returns
        /// a reference to it.
        /// </summary>
        /// <param name="configuration">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface that holds
        /// settings that are specified by the user.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter,
        /// <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        protected TextExpressionMatchingEngineBase(
            IProjectFileRenamerConfiguration configuration) :
            base(configuration) { }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user configuration and the
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
        /// Gets one of the <see cref="T:MFR.Operations.Constants.OperationType" /> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public abstract OperationType OperationType
        {
            get;
        }

        /// <summary>
        /// Determines whether a <paramref name="value" /> string is a match
        /// against a <paramref name="findWhat" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <param name="replaceWith">
        /// (Optional.) String containing the value to be substituted for the
        /// found text in <paramref name="value" />.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// or <paramref name="findWhat" />, are passed blank or
        /// <see langword="null" /> string for values.
        /// </exception>
        /// <returns>
        /// Returns <see langword="true" /> if the <paramref name="value" /> is a
        /// match against the provided <paramref name="findWhat" />;
        /// <see
        ///     langword="false" />
        /// if no matches are found.
        /// </returns>
        /// <remarks>
        /// NOTE: Implementers of this object must override this method and the
        /// override must start by calling the base class.
        /// </remarks>
        public virtual bool IsMatch([NotLogged] string value,
            [NotLogged] string findWhat, [NotLogged] string replaceWith = "")
        {
            VerifyConfigurationAttached();

            return default;
        }

        /// <summary>
        /// Determines whether data and a search patterned, bound up together in
        /// the form of the <paramref name="expression" /> provided, contain a
        /// data match according to rules specified by the user in the object, a
        /// reference to which is specified in the
        /// <see
        ///     cref="P:MFR.ITextExpressionMatchingEngine.ProjectFileRenamerConfiguration" />
        /// property.
        /// </summary>
        /// <param name="expression">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MFR.IMatchExpression" /> interface and whose
        /// properties contain the match and pattern data.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if more than zero matches are found;
        /// <see
        ///     langword="false" />
        /// otherwise.
        /// </returns>
        public bool IsMatch(IMatchExpression expression)
        {
            var result = false;

            try
            {
                if (expression == null) return result;

                // delegate to the other overload of this method
                result = IsMatch(
                    expression.Value, expression.FindWhat, expression.ReplaceWith
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Attempts to obtain a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface for the
        /// current operation.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface that
        /// corresponds to the current operation and matching configuration.
        /// </returns>
        protected IStringMatcher GetOperationMatcher()
        {
            IStringMatcher result = default;

            try
            {
                result = GetStringMatcherFactory.For(OperationType)
                                         .AndTextMatchingConfiguration(
                                             CurrentConfiguration
                                                 .GetTextMatchingConfiguration()
                                         );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }
    }
}