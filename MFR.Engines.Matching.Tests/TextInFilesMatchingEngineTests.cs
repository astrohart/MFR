using Alphaleonis.Win32.Filesystem;
using MFR.Objects.Engines.Matching.Factories;
using MFR.Objects.Engines.Matching.Interfaces;
using MFR.Objects.FileSystem.Helpers;
using MFR.Objects.Operations.Constants;
using MFR.Objects.Tests.Common;
using NUnit.Framework;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Objects.Engines.Matching.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.Engines.Matching.TextInFilesMatchingEngine" />
    /// class.
    /// </summary>
    [TestFixture]
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
            Assert.IsNotNull(engine);

            Assert.IsTrue(
                engine.IsMatch(
                    FileHelpers.GetContent(
                        StringConstants
                            .JUNK_SOLUTION_PROCESSORS_FACTORIES_CSPROJ_FILE_PATH
                    ), "Displayer", "Processor"
                )
            );
        }
    }
}