using MFR.Objects.Invokers.Factories;
using MFR.Objects.Invokers.Interfaces;
using NUnit.Framework;

namespace MFR.Objects.Invokers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.PathFilterInvokerBase" />
    /// class.
    /// </summary>
    [TestFixture]
    public class PathFilterInvokerBaseTests
    {
        /// <summary>
        /// Reference to an instance of an object that implements the <see cref="T:MFR.Objects.Invokers.Interfaces.IPathFilterInvoker" /> interface.
        /// </summary>
        private static IPathFilterInvoker Invoker
            => MakeNewPathFilterInvoker.FromScratch();

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.Objects.Invokers.Interfaces.IPathFilterInvoker.Passes" />
        /// method returns <see langword="true" /> when passed
        /// <see
        ///     langword="null" />
        /// for its parameter.
        /// </summary>
        [Test]
        public void Test_Pass_ReturnsTrue_ForNullPathFilter()
            => Assert.IsTrue(Invoker.Passes(null));
    }
}