using MFR.Expressions.Matches.Factories.Interfaces;
using MFR.Operations.Constants;
using MFR.Settings.Configuration.Interfaces;
using MFR.Tests.Common;
using NUnit.Framework;
using PostSharp.Patterns.Threading;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Expressions.Matches.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.FileNameReplacementMatchExpressionFactory" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class FileNameReplacementMatchExpressionFactoryTests
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public void Initialize()

            // try really hard to clear the temp files folder to avoid a large
            // buildup of files from these unit tests.
            => DebugFileAndFolderHelper.ClearTempFileDir();

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, false
                        )
                    )
                    .ForTextValue(StringConstants.EMPTY_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseFalse_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, true
                        )
                    )
                    .ForTextValue(StringConstants.EMPTY_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, false
                        )
                    )
                    .ForTextValue(StringConstants.EMPTY_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForBlankInput_WhenMatchCaseTrue_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, true
                        )
                    )
                    .ForTextValue(StringConstants.EMPTY_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, false
                        )
                    )
                    .ForTextValue(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseFalse_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, true
                        )
                    )
                    .ForTextValue(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, false
                        )
                    )
                    .ForTextValue(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForNullInput_WhenMatchCaseTrue_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, true
                        )
                    )
                    .ForTextValue(StringConstants.NULL_STRING)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, false
                        )
                    )
                    .ForTextValue(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseFalse_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            false, true
                        )
                    )
                    .ForTextValue(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordFalse()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, false
                        )
                    )
                    .ForTextValue(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_ThrowsArgumentException_ForWhitespaceInput_WhenMatchCaseTrue_And_MatchExactWordTrue()
            => Assert.Throws<ArgumentException>(
                () => GetMatchExpressionFactoryConfiguredAccordingTo(
                        ConfigurationBuilder.BuildConfigurationForUseCase(
                            true, true
                        )
                    )
                    .ForTextValue(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordFalse()
            => Assert.That(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY,
                Is.EqualTo(
                    GetMatchExpressionFactoryConfiguredAccordingTo(
                            ConfigurationBuilder.BuildConfigurationForUseCase(
                                false, false
                            )
                        )
                        .ForTextValue(StringConstants.FILE_GUARANTEED_TO_EXIST)
                        .Value
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseFalse_And_MatchExactWordTrue()
            => Assert.That(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY,
                Is.EqualTo(
                    GetMatchExpressionFactoryConfiguredAccordingTo(
                            ConfigurationBuilder.BuildConfigurationForUseCase(
                                false, true
                            )
                        )
                        .ForTextValue(StringConstants.FILE_GUARANTEED_TO_EXIST)
                        .Value
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordFalse()
            => Assert.That(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY,
                Is.EqualTo(
                    GetMatchExpressionFactoryConfiguredAccordingTo(
                            ConfigurationBuilder.BuildConfigurationForUseCase(
                                true, false
                            )
                        )
                        .ForTextValue(StringConstants.FILE_GUARANTEED_TO_EXIST)
                        .Value
                )
            );

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void
            Test_ForTextValueMethod_WorksAsExpected_ForValidInput_WhenMatchCaseTrue_And_MatchExactWordTrue()
            => Assert.That(
                StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY,
                Is.EqualTo(
                    GetMatchExpressionFactoryConfiguredAccordingTo(
                            ConfigurationBuilder.BuildConfigurationForUseCase(
                                true, true
                            )
                        )
                        .ForTextValue(StringConstants.FILE_GUARANTEED_TO_EXIST)
                        .Value
                )
            );

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.IMatchExpressionFactory" />
        /// interface and that is configured according to the
        /// <paramref
        ///     name="config" />
        /// instance specified.
        /// </summary>
        /// <param name="config">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.IMatchExpressionFactory" />
        /// interface
        /// that has the specified <paramref name="config" /> attached.
        /// </returns>
        /// <remarks>
        /// The specific match-expression factory in use is that which is keyed
        /// to the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType.RenameFilesInFolder" />
        /// operation type.
        /// </remarks>
        private static IMatchExpressionFactory
            GetMatchExpressionFactoryConfiguredAccordingTo(
                IProjectFileRenamerConfig config
            )
            => GetMatchExpressionFactory.For(OperationType.RenameFilesInFolder)
                                        .AndAttachConfiguration(config);
    }
}