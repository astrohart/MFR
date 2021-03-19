using System;
using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the <see cref="T:MassFileRenamer.Objects.PathFilterInvokerBase"/> class.
    /// </summary>
    [TestFixture]
    public class PathFilterInvokerBaseTests
    {
        private static IPathFilterInvoker Invoker
            => DoesPathFilterInvoker.FromScratch();

        /// <summary>
        /// TODO: Add unit test documentation here
        /// </summary>
        [Test]
        public void Test_Pass_ReturnsTrue_ForNullPathFilter()
            => Assert.IsTrue(Invoker.Pass(null));
    }
}