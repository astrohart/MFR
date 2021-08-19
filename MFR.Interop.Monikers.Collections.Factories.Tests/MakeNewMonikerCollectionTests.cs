using MFR.Interop.Monikers.Collections.Interfaces;
using NUnit.Framework;

namespace MFR.Interop.Monikers.Collections.Factories.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.MakeNewMonikerCollection" />
    /// class.
    /// </summary>
    [TestFixture]
    public class MakeNewMonikerCollectionTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.MakeNewMonikerCollection.FromScratch" />
        /// method returns a reference to an instance of an object that
        /// implements the
        /// <see
        ///     cref="T:MFR.IMonikerEnumerable" />
        /// interface.
        /// </summary>
        [Test]
        public void Test_FromScratchMethod_Works()
            => Assert.IsInstanceOf<IMonikerEnumerable>(
                MakeNewMonikerCollection.FromScratch()
            );
    }
}