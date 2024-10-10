using PostSharp.Patterns.Threading;
using MFR.Settings.Configuration.Constants;
using MFR.Operations.Constants;
using MFR.Replacers.Factories;
using NUnit.Framework;
using System;

namespace MFR.Replacers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.MatchCaseAndExactWordFolderNameStringReplacer" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class MatchCaseAndExactWordFolderNameStringReplacerTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.IStringReplacer.Replace" />
        /// method,
        /// when the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration.MatchCaseAndExactWord" />
        /// matching config is used, properly does replacement in folder
        /// names using an exact-word match.
        /// </summary>
        [Test]
        public void Test_Replace_Works()
        {
            Assert.That(
                "MFR.Directories.Validators.Constants.Generators.Bim.Baz", Is.EqualTo(
                    GetStringReplacer.For(OperationType.RenameSubFolders)
                                     .AndTextMatchingConfiguration(
                                         TextMatchingConfiguration
                                             .MatchCaseAndExactWord
                                     )
                                     .Replace(
                                         "MFR.Directories.Validators.Constants.Generators.Bar.Baz", "MFR.Directories.Validators.Constants.Generators.Bar.Baz",
                                         "MFR.Directories.Validators.Constants.Generators.Bim.Baz"
                                     )
                )
            );
            Assert.That(
                "MFR.Directories.Validators.Constants.Generators.Bim.Baz", Is.Not.EqualTo(
                    GetStringReplacer.For(OperationType.RenameSubFolders)
                                     .AndTextMatchingConfiguration(
                                         TextMatchingConfiguration
                                             .MatchCaseAndExactWord
                                     )
                                     .Replace("MFR.Directories.Validators.Constants.Generators.Bar.Baz", "Bar", "Bim")
                )
            );
            Assert.That(
                "PortfolioMonitor.Factories.Assets.Providers", Is.EqualTo(
                    GetStringReplacer.For(OperationType.RenameSubFolders)
                                     .AndTextMatchingConfiguration(
                                         TextMatchingConfiguration
                                             .MatchCaseAndExactWord
                                     )
                                     .Replace(
                                         "PortfolioMonitor.Factories.Assets",
                                         "PortfolioMonitor.Factories.Assets",
                                         "PortfolioMonitor.Factories.Assets.Providers"
                                     )
                )
            );
            Assert.That(
                "PortfolioMonitor.Factories.Assets.Providers.Interfaces",
                Is.Not.EqualTo(
                    GetStringReplacer.For(OperationType.RenameSubFolders)
                                     .AndTextMatchingConfiguration(
                                         TextMatchingConfiguration
                                             .MatchCaseAndExactWord
                                     )
                                     .Replace(
                                         "PortfolioMonitor.Factories.Assets.Interfaces",
                                         "PortfolioMonitor.Factories.Assets",
                                         "PortfolioMonitor.Factories.Assets.Providers"
                                     )
                )
            );

            Console.WriteLine(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration
                                         .MatchCaseAndExactWord
                                 )
                                 .Replace(
                                     "MFR.Directories.Validators.Constants.Generators.Bar.Baz", "MFR.Directories.Validators.Constants.Generators.Bar.Baz", "MFR.Directories.Validators.Constants.Generators.Bim.Baz"
                                 )
            );
            Console.WriteLine(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration
                                         .MatchCaseAndExactWord
                                 )
                                 .Replace("MFR.Directories.Validators.Constants.Generators.Bar.Baz", "Bar", "Bim")
            );
        }
    }
}