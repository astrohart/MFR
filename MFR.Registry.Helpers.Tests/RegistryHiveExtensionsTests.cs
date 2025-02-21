/*71b451a5-ec2a-4538-a74d-a520fd3c98ef
 * # xyLOGIX Project File Renamer License
 * 
 * This software and associated documentation files (the "Software") are the exclusive property of xyLOGIX, LLC ("xyLOGIX"), a Tennessee Limited Liability Company. Copyright © 2025 by 
 * xyLOGIX, LLC.  All rights reserved.
 * 
 * ## License Grant
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this Software, to use the Software solely for the purpose of evaluating its functionality and performance.
 * This license does not grant the right to modify, distribute, sublicense, or sell copies of the Software, nor to use the Software for any commercial purpose.
 * 
 * ## Restrictions
 * 
 * 1.  No Distribution: You may not distribute, sublicense, or sell copies of the Software, in whole or in part, to any third party.
 * 2.  No Modification:  You may not modify, adapt, or create derivative works of the Software.
 * 3.  No Reverse Engineering:  You may not reverse engineer, decompile, or disassemble the Software.
 * 4.  No Commercial Use:  You may not use the Software for any commercial purpose without the prior written consent of xyLOGIX.
 * 5.  No Removal of Notices:  You may not remove or alter any proprietary notices, labels, or marks on the Software.
 * 
 * ## Intellectual Property Rights
 * 
 * All intellectual property rights, including but not limited to copyrights, patents, trademarks, and trade secrets, in and to the Software are and shall remain the exclusive property of xyLOGIX.
 * This license does not transfer any ownership rights in the Software to you.
 * 
 * ## Disclaimer of Warranty
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM, OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE 
 * OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 * ## Limitation of Liability
 * 
 * IN NO EVENT SHALL XYLOGIX BE LIABLE FOR ANY INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
 * PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THE SOFTWARE
 * EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 * 
 * ## Termination
 * 
 * This license is effective until terminated.  Your rights under this license will terminate automatically without notice from xyLOGIX if you fail to comply with any term(s) of this license. Upon termination, you must
 * cease all use of the Software and destroy all copies, full or partial, of the Software.
 * 
 * ## Governing Law
 *
 * This license shall be governed by and construed in accordance with the laws of the State of Washington, without regard to its conflict of laws principles and without regard to the principle of contra proferentem.
 *
 * ## Contact Information
 *
 * For inquiries regarding this license, please contact:
 *
 * xyLOGIX, LLC
 * info@xylogix.net
 */

using PostSharp.Patterns.Threading;
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
    [TestFixture, ExplicitlySynchronized]
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
                () => Assert.That(
                    RegistryHive.ClassesRoot,
                    Is.EqualTo(CLASSES_ROOT_HIVE_NAME.ToRegistryHive()
                ))
            );
            Assert.DoesNotThrow(
                () => Assert.That(
                    RegistryHive.CurrentConfig,
                    Is.EqualTo(CURRENT_CONFIG_HIVE_NAME.ToRegistryHive()
                ))
            );
            Assert.DoesNotThrow(
                () => Assert.That(
                    RegistryHive.CurrentUser,
                    Is.EqualTo(CURRENT_USER_HIVE_NAME.ToRegistryHive()
                ))
            );
            Assert.DoesNotThrow(
                () => Assert.That(
                    RegistryHive.DynData, 
                    Is.EqualTo(DYN_DATA_HIVE_NAME.ToRegistryHive())
                )
            );
            Assert.DoesNotThrow(
                () => Assert.That(
                    RegistryHive.LocalMachine,
                    Is.EqualTo(Is.EqualTo(LOCAL_MACHINE_HIVE_NAME.ToRegistryHive()
                ))
            ));
            Assert.DoesNotThrow(
                () => Assert.That(
                    RegistryHive.PerformanceData,
                    Is.EqualTo(PERFORMANCE_DATA_HIVE_NAME.ToRegistryHive()
                ))
            );
            Assert.DoesNotThrow(
                () => Assert.That(
                    RegistryHive.Users, Is.EqualTo(USERS_HIVE_NAME.ToRegistryHive())
                )
            );
        }
    }
}