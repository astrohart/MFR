using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.ProcessIdProvider" />
    /// class.
    /// </summary>
    [TestFixture]
    public class ProcessIdProviderTests
    {
        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        [SetUp]
        public void Initialize()
        {
            _processIdProvider = MakeNewProcessIdProvider.FromScratch();
            Assert.IsNotNull(_processIdProvider);
        }

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IProcessIdProvider" />
        /// interface.
        /// </summary>
        private IProcessIdProvider _processIdProvider;

        /// <summary>
        /// Gets a reference to the empty enumerable of integers.
        /// </summary>
        private static IEnumerable<int> EmptyIntegerCollection
            => Enumerable.Empty<int>();

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IProcessIdProvider.GetAllProcessIDsOf" />
        /// method returns the empty collection when it is passed the empty
        /// string as input.
        /// </summary>
        [Test]
        public void Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsBlank()
            => Assert.AreEqual(
                EmptyIntegerCollection,
                _processIdProvider.GetAllProcessIDsOf(string.Empty)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IProcessIdProvider.GetAllProcessIDsOf" />
        /// method returns nonzero items when passed the filename of
        /// <c>devenv.exe</c> as input.
        /// </summary>
        /// <remarks>
        /// This test makes the assumption that a test runner is being utilized
        /// that interfaces with Visual Studio; therefore, we are guaranteed
        /// that at least one instance of <c>devenv.exe</c> must be running.
        /// </remarks>
        [Test]
        public void
            Test_GetAllProcessIDsOf_ReturnsNonEmptySet_WhenInputIsDevEnvFilename()
            => Assert.IsTrue(
                _processIdProvider.GetAllProcessIDsOf(StringConstants.DEVENV_FILENAME)
                                  .Any()
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IProcessIdProvider.GetAllProcessIDsOf" />
        /// method returns the empty collection when it is passed gibberish as input.
        /// </summary>
        [Test]
        public void
            Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsGibberish()
            => Assert.AreEqual(
                EmptyIntegerCollection,
                _processIdProvider.GetAllProcessIDsOf(StringConstants.GIBBERISH)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IProcessIdProvider.GetAllProcessIDsOf" />
        /// method returns the empty collection when it is passed the
        /// <see langword="null" /> string as input.
        /// </summary>
        [Test]
        public void Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsNull()
            => Assert.AreEqual(
                EmptyIntegerCollection,
                _processIdProvider.GetAllProcessIDsOf(null)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IProcessIdProvider.GetAllProcessIDsOf" />
        /// method returns the empty collection when it is passed whitespace as input.
        /// </summary>
        [Test]
        public void
            Test_GetAllProcessIDsOf_ReturnsEmptySet_WhenInputIsWhitespace()
            => Assert.AreEqual(
                EmptyIntegerCollection,
                _processIdProvider.GetAllProcessIDsOf(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IProcessIdProvider.GetProcessIDOf" />
        /// method returns <c>-1</c> for the process ID when passed the empty
        /// string as input.
        /// </summary>
        [Test]
        public void Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsBlank()
            => Assert.AreEqual(
                -1, _processIdProvider.GetProcessIDOf(StringConstants.EMPTY_STRING)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IProcessIdProvider.GetProcessIDOf" />
        /// method returns <c>-1</c> for the process ID when passed gibberish
        /// for input.
        /// </summary>
        public void Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsGibberish()
            => Assert.AreEqual(
                -1, _processIdProvider.GetProcessIDOf(StringConstants.GIBBERISH)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IProcessIdProvider.GetProcessIDOf" />
        /// method returns <c>-1</c> for the process ID when passed the
        /// <see langword="null" /> string as input.
        /// </summary>
        [Test]
        public void Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsNull()
            => Assert.AreEqual(-1, _processIdProvider.GetProcessIDOf(null));

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IProcessIdProvider.GetProcessIDOf" />
        /// method returns <c>-1</c> for the process ID when passed the empty
        /// string as input.
        /// </summary>
        [Test]
        public void Test_GetProcessIDOf_ReturnsMinusOne_WhenInputIsWhiteSpace()
            => Assert.AreEqual(
                -1, _processIdProvider.GetProcessIDOf(StringConstants.WHITESPACE)
            );

        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.IProcessIdProvider.GetProcessIDOf" /> method
        /// always returns a positive integer for the process ID when searching
        /// on <c>devenv.exe</c>.
        /// </summary>
        /// <remarks>
        /// We assume that, if this unit test is being run, then it is most
        /// likely being run by a test runner launched by an instance of Visual
        /// Studio; therefore, Visual Studio must have at least one instance open.
        /// </remarks>
        [Test]
        public void Test_GetProcessIDOf_ReturnsPositiveInteger_WhenInputIsDevEnvFilename()
            => Assert.IsTrue(
                _processIdProvider.GetProcessIDOf(StringConstants.DEVENV_FILENAME) > 0
            );
    }
}