using Microsoft.Win32;
using NUnit.Framework;

namespace MFR.Registry.Helpers.Tests
{
    /// <summary>
    /// Provides unit tests for the methods, properties, and events of the
    /// <see
    ///     cref="T:MFR.RegistryHiveExtensions" />
    /// class.
    /// </summary>
    [TestFixture]
    public class RegistryHiveExtensionsTests
    {
        /// <summary>
        /// String containing the name of the <c>HKEY_CLASSES_ROOT</c> Registry hive.
        /// </summary>
        private const string CLASSES_ROOT_HIVE_NAME = "HKEY_CLASSES_ROOT";

        /// <summary>
        /// String containing the name of the <c>HKEY_CURRENT_CONFIG</c>
        /// Registry hive.
        /// </summary>
        private const string CURRENT_CONFIG_HIVE_NAME = "HKEY_CURRENT_CONFIG";

        /// <summary>
        /// String containing the name of the <c>HKEY_CURRENT_USER</c> Registry hive.
        /// </summary>
        private const string CURRENT_USER_HIVE_NAME = "HKEY_CURRENT_USER";

        /// <summary>
        /// String containing the name of the <c>HKEY_DYN_DATA</c> Registry hive.
        /// </summary>
        private const string DYN_DATA_HIVE_NAME = "HKEY_DYN_DATA";

        /// <summary>
        /// String containing the path to a fake key in the system Registry.
        /// </summary>
        private const string FAKE_KEY_PATH =
            @"HKEY_CURRENT_USER\Software\SharpCrafters\StrongName\Verification\*,*";

        /// <summary>
        /// String containing the name of the <c>HKEY_LOCAL_MACHINE</c> Registry hive.
        /// </summary>
        private const string LOCAL_MACHINE_HIVE_NAME = "HKEY_LOCAL_MACHINE";

        /// <summary>
        /// String containing the name of the <c>HKEY_PERFORMANCE_DATA</c>
        /// Registry hive.
        /// </summary>
        private const string PERFORMANCE_DATA_HIVE_NAME =
            "HKEY_PERFORMANCE_DATA";

        /// <summary>
        /// String containing the name of the <c>HKEY_USERS</c> Registry hive.
        /// </summary>
        private const string USERS_HIVE_NAME = "HKEY_USERS";

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.RegistryHiveExtensions.RemoveHiveName" />
        /// method correctly strips the hive name from a fake path to a Registry
        /// key under HKEY_CURRENT_USER.
        /// </summary>
        [Test]
        public void Test_RemoveRegistryHive_Method_Works()
            => Assert.That(
                FAKE_KEY_PATH.RemoveHiveName(),
                Does.Not.Contain(CURRENT_USER_HIVE_NAME)
            );

        /// <summary>
        /// Asserts that the
        /// <see
        ///     cref="M:MFR.RegistryHiveExtensions.ToRegistryHive" />
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
                    CLASSES_ROOT_HIVE_NAME.ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.CurrentConfig,
                    CURRENT_CONFIG_HIVE_NAME.ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.CurrentUser,
                    CURRENT_USER_HIVE_NAME.ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.DynData, DYN_DATA_HIVE_NAME.ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.LocalMachine,
                    LOCAL_MACHINE_HIVE_NAME.ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.PerformanceData,
                    PERFORMANCE_DATA_HIVE_NAME.ToRegistryHive()
                )
            );
            Assert.DoesNotThrow(
                () => Assert.AreEqual(
                    RegistryHive.Users, USERS_HIVE_NAME.ToRegistryHive()
                )
            );
        }
    }
}