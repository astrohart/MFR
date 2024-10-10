using PostSharp.Patterns.Threading;
using Alphaleonis.Win32.Filesystem;
using MFR.Engines.Matching.Factories;
using MFR.Engines.Matching.Interfaces;
using MFR.FileSystem.Helpers;
using MFR.Operations.Constants;
using MFR.Tests.Common;
using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Engines.Matching.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Engines.Matching.TextInFilesMatchingEngine" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class TextInFilesMatchingEngineTests
    {
        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Log(AttributeExclude = true)]
        [Test]
        public void Test_Match_WithCaseAndNotExactWords_Found_InCsProjFile()
        {
            // ignore this test if the target files does not exist.
            if (!File.Exists(
                StringConstants
                    .JUNK_SOLUTION_PROCESSORS_FACTORIES_CSPROJ_FILE_PATH
            ))
                Assert.Pass();  

            ITextExpressionMatchingEngine engine =
                GetTextExpressionMatchingEngine
                    .For(OperationType.ReplaceTextInFiles)
                    .AndAttachConfiguration(
                        ConfigurationBuilder.Instance.SetMatchCase()
                                            .AndSetMatchExactWord(false)
                                            .Build()
                    );
            Assert.That(engine, Is.Not.Null);

            Assert.That(
                engine.IsMatch(
                    FileHelpers.GetTextContent(
                        StringConstants
                            .JUNK_SOLUTION_PROCESSORS_FACTORIES_CSPROJ_FILE_PATH
                    ), "Displayer", "Processor"
                )
            );
        }
    }
}