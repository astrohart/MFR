using MFR.Objects.Interop.Factories;
using NUnit.Framework;
using System.Runtime.InteropServices.ComTypes;

namespace MFR.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.Objects.GetRunningObjectTable" />
    /// class.
    /// </summary>
    [TestFixture]
    public class GetRunningObjectTableTests
    {
        /// <summary>
        /// Asserts the
        /// <see
        ///     cref="M:MFR.Objects.MakeNewBindContext.FromScratch" />
        /// method returns
        /// a valid object reference.
        /// </summary>
        [Test]
        public void Test_FromBindContextMethod_Works()
        {
            IRunningObjectTable result = default;

            Assert.DoesNotThrow(
                () => result =
                    GetRunningObjectTable.FromBindContext(GetNewBindContext())
            );

            Assert.IsNotNull(result);

            Assert.IsInstanceOf<IRunningObjectTable>(result);
        }

        /// <summary>
        /// Attempts to instruct the operating system to allocate a new instance
        /// of an object that implements the
        /// <see
        ///     cref="T:System.Runtime.InteropServices.ComTypes.IBindCtx" />
        /// interface.
        /// <para />
        /// If the operation is not successful, assertion exceptions will stop
        /// the unit test that this method is called from.
        /// </summary>
        /// <returns>
        /// </returns>
        private static IBindCtx GetNewBindContext()
        {
            var bindContext = MakeNewBindContext.FromScratch();

            Assert.IsNotNull(bindContext);
            Assert.IsInstanceOf<IBindCtx>(bindContext);
            return bindContext;
        }
    }
}