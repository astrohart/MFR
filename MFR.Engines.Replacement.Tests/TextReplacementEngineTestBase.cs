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

using MFR.Settings.Configuration.Interfaces;
using MFR.Engines.Replacement.Factories;
using MFR.Engines.Replacement.Intefaces;
using MFR.Operations.Constants;
using MFR.Tests.Common;
using NUnit.Framework;

namespace MFR.Engines.Replacement.Tests
{
    /// <summary>
    /// Provides default implementations for unit tests and abstract methods for
    /// mandatory implementation details.
    /// </summary>
    [TestFixture]
    public abstract class TextReplacementEngineTestBase
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        protected IProjectFileRenamerConfig ProjectFileRenamerConfig
        {
            get;
            set;
        }

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.ITextReplacementEngine" />
        /// interface.
        /// </summary>
        protected ITextReplacementEngine Replacer
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes the state of this fixture for every unit test session.
        /// </summary>
        public virtual void Initialize()
        {
            ProjectFileRenamerConfig = ConfigurationBuilder.Instance.SetMatchCase(false)
                                                .AndSetMatchExactWord(false)
                                                .Build();

            Assert.That(ProjectFileRenamerConfig, Is.Not.Null);
            Assert.That(!ProjectFileRenamerConfig.MatchCase);
            Assert.That(!ProjectFileRenamerConfig.MatchExactWord);
        }

        /// <summary>
        /// Creates an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.ITextReplacementEngine" />
        /// interface for the
        /// specified operation <paramref name="type" />.
        /// </summary>
        /// <param name="type">
        /// One of the <see cref="T:MFR.Operations.Constants.OperationType" /> values that
        /// specifies which operation to create a data-matcher object for.
        /// </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the <paramref name="type" /> parameter is not set to a
        /// value that the factory supports.
        /// </exception>
        protected void CreateReplacementEngineFor(OperationType type)
            => Replacer = GetTextReplacementEngine.For(type)
                                                  .AndAttachConfiguration(
                                                      ProjectFileRenamerConfig
                                                  ) as ITextReplacementEngine;
    }
}