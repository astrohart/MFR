using NUnit.Framework;
using System.Runtime.InteropServices.ComTypes;

namespace MFR.Interop.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Interop.Factories.MakeNewBindContext" />
    /// class.
    /// </summary>
    [TestFixture]
    public class MakeNewBindContextTests
    {
        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.MakeNewBindContext.FromScratch" />
        /// method returns a valid object reference.
        /// </summary>
        [Test]
        public void Test_FromScratchMethod_Works()
        {
            var result = MakeNewBindContext.FromScratch();

            Assert.IsNotNull(result);

            Assert.IsInstanceOf<IBindCtx>(result);
        }
    }
}