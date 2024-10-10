using PostSharp.Patterns.Threading;
using NUnit.Framework;

namespace MFR.Renamers.Files.Tests
{
    /// <summary>
    /// Provides unit tests for the
    /// <see
    ///     cref="T:MFR.Renamers.Files.FileRenamer" />
    /// class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class FileRenamerTests
    {
        /// <summary>
        /// Until we come up with unit tests for the class, instead just write
        /// the unit test that always passes.
        /// </summary>
        [Test]
        public void Test_That_Always_Passes()
            => Assert.That(1 == 1, Is.True);
    }
}