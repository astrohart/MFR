using Microsoft.Win32;
using NUnit.Framework;

namespace MassFileRenamer.Objects.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MassFileRenamer.Objects.RegistryHiveExtensions" />
    /// class.
    /// </summary>
    [TestFixture]
    public class RegistryHiveExtensionsTests
    {
        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.RegistryHiveExtensions.ToRegistryHive" />
        /// string extension method returns the correct
        /// <see
        ///     cref="T:Microsoft.Win32.RegistryHive" />
        /// enumeration value for the
        /// string it is given as valid input.
        /// </summary>
        [Test]
        public void
            Test_ToRegistryHive_Method_ReturnsCorrectValue_ForAllValidInputs()
        {
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.ClassesRoot,
                    "HKEY_CLASSES_ROOT".ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.CurrentConfig,
                    "HKEY_CURRENT_CONFIG".ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.CurrentUser,
                    "HKEY_CURRENT_USER".ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.DynData, "HKEY_DYN_DATA".ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.LocalMachine,
                    "HKEY_LOCAL_MACHINE".ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.PerformanceData,
                    "HKEY_PERFORMANCE_DATA".ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.Users, "HKEY_USERS".ToRegistryHive()
                )
            );
        }
    }
}