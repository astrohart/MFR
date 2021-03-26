using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.MakeNewMonikerCollection" />
    /// class.
    /// </summary>
    [TestFixture]
    public class MakeNewMonikerCollectionTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.MakeNewMonikerCollection.FromScratch" />
        /// method returns a reference to an instance of an object that
        /// implements the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.IMonikerEnumerable" />
        /// interface.
        /// </summary>
        [Test]
        public void Test_FromScratchMethod_Works()
            => Assert.IsInstanceOf<IMonikerEnumerable>(
                MakeNewMonikerCollection.FromScratch()
            );
    }
}