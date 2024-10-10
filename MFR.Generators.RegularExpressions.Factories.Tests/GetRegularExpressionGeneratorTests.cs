using PostSharp.Patterns.Threading;
using MFR.Generators.RegularExpressions.Constants;
using MFR.Generators.RegularExpressions.Interfaces;
using MFR.Tests.Common;
using NUnit.Framework;

namespace MFR.Generators.RegularExpressions.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Generators.RegularExpressions.Factories.GetRegularExpressionGenerator" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class GetRegularExpressionGeneratorTests
    {
        /// <summary>
        /// Asserts that the return value of the
        /// <see
        ///     cref="M:MFR.Generators.RegularExpressions.Factories.GetRegularExpressionGenerator.For" />
        /// method implements the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator" />
        /// interface and is an instance of the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator" />
        /// class, when the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Constants.RegularExpressionType.MatchExactWordOnly" />
        /// value is passed for its parameter.
        /// </summary>
        [Test]
        public void
            Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_GeneratesCorrectRegExp()
        {
            var generator = CreateNewRegularExpressionGeneratorFor(RegularExpressionType.MatchExactWordOnly);
            Assert.That(
                generator, Is.InstanceOf<IRegularExpressionGenerator>()
            );
            Assert.That(
                generator,
                Is.InstanceOf<MatchExactWordOnlyRegularExpressionGenerator>()
            );

            Assert.That(
                StringConstants
                    .FAKE_PROJECT_NAME_WITH_DOTS_EXACT_WORD_MATCH_REGEX,
                Is.EqualTo(
                    generator.Generate(
                        StringConstants.FAKE_PROJECT_NAME_WITH_DOTS
                    )
                )
            );
        }

        /// <summary>
        /// Asserts that the return value of the
        /// <see
        ///     cref="M:MFR.Generators.RegularExpressions.Factories.GetRegularExpressionGenerator.For" />
        /// method implements the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator" />
        /// interface when the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Constants.RegularExpressionType.MatchExactWordOnly" />
        /// value is passed for its parameter.
        /// </summary>
        [Test]
        public void
            Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_Implements_IRegularExpressionGenerator()
        {
            var generator = CreateNewRegularExpressionGeneratorFor(RegularExpressionType.MatchExactWordOnly);
            Assert.That(
                generator, Is.InstanceOf<IRegularExpressionGenerator>()
            );
        }

        /// <summary>
        /// Asserts that the return value of the
        /// <see
        ///     cref="M:MFR.Generators.RegularExpressions.Factories.GetRegularExpressionGenerator.For" />
        /// method implements the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator" />
        /// interface and is an instance of the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator" />
        /// class, when the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Constants.RegularExpressionType.MatchExactWordOnly" />
        /// value is passed for its parameter.
        /// </summary>
        [Test]
        public void
            Test_GetRegularExpression_For_RegularExpressionGeneratorType_ReturnValue_IsCorrectConcreteType()
        {
            var generator = CreateNewRegularExpressionGeneratorFor(RegularExpressionType.MatchExactWordOnly);
            Assert.That(
                generator, Is.InstanceOf<IRegularExpressionGenerator>()
            );
            Assert.That(
                generator,
                Is.InstanceOf<MatchExactWordOnlyRegularExpressionGenerator>()
            );
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Generators.RegularExpressions.Interfaces.IRegularExpressionGenerator" />
        /// interface.
        /// </returns>
        private static IRegularExpressionGenerator
            CreateNewRegularExpressionGeneratorFor(RegularExpressionType type)
        {
            IRegularExpressionGenerator generator = null;

            Assert.DoesNotThrow(
                () => generator = GetRegularExpressionGenerator.For(
                    type
                )
            );
            Assert.That(generator, Is.Not.Null);
            return generator;
        }
    }
}