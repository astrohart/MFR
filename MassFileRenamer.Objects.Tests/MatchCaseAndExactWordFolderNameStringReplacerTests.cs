using NUnit.Framework;
using System;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.MatchCaseAndExactWordFolderNameStringReplacer" />
    /// class.
    /// </summary>
    [TestFixture]
    public class MatchCaseAndExactWordFolderNameStringReplacerTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_Replace_Works()
        {
            Assert.That(
                "Foo.Bim.Baz", Is.EqualTo(
                    GetStringReplacer.For(OperationType.RenameSubFolders)
                                     .AndTextMatchingConfiguration(
                                         TextMatchingConfiguration
                                             .MatchCaseAndExactWord
                                     )
                                     .Replace(
                                         "Foo.Bar.Baz", "Foo.Bar.Baz",
                                         "Foo.Bim.Baz"
                                     )
                )
            );
            Assert.That(
                "Foo.Bim.Baz", Is.Not.EqualTo(
                    GetStringReplacer.For(OperationType.RenameSubFolders)
                                     .AndTextMatchingConfiguration(
                                         TextMatchingConfiguration
                                             .MatchCaseAndExactWord
                                     )
                                     .Replace("Foo.Bar.Baz", "Bar", "Bim")
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
                                         "PortfolioMonitor.Factories.Assets", "PortfolioMonitor.Factories.Assets",
                                         "PortfolioMonitor.Factories.Assets.Providers"
                                     )
                )
            );
            Assert.That(
                "PortfolioMonitor.Factories.Assets.Providers.Interfaces", Is.Not.EqualTo(
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
                                     TextMatchingConfiguration.MatchCaseAndExactWord
                                 )
                                 .Replace(
                                     "Foo.Bar.Baz", "Foo.Bar.Baz", "Foo.Bim.Baz"
                                 )
            );
            Console.WriteLine(
                GetStringReplacer.For(OperationType.RenameSubFolders)
                                 .AndTextMatchingConfiguration(
                                     TextMatchingConfiguration.MatchCaseAndExactWord
                                 )
                                 .Replace("Foo.Bar.Baz", "Bar", "Bim")
            );
        }
    }
}