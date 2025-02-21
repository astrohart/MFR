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
 */using MFR.TextValues.Retrievers.Synchronization.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MFR.TextValues.Retrievers.Synchronization
{
    /// <summary>
    /// Allows the caller to put a mutex or critical section around calls to
    /// asynchronous methods.
    /// </summary>
    public class SemaphoreLocker : ISemaphoreLocker
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static SemaphoreLocker() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected SemaphoreLocker()
        {
            Semaphore = new SemaphoreSlim(1, 1);
        }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see
        ///     cref="T:MFR.TextValues.Retrievers.Synchronization.Interfaces.ISemaphoreLocker" />
        /// interface.
        /// </summary>
        public static ISemaphoreLocker Instance
        {
            get;
        } = new SemaphoreLocker();

        /// <summary>
        /// Gets a to an instance of <see cref="T:System.Threading.SemaphoreSlim" />
        /// that provides a semaphore to be used for asynchronous thread synchronization.
        /// </summary>
        private SemaphoreSlim Semaphore
        {
            get;
        }

        /// <summary>
        /// Uses a semaphore instead of a critical section to ensure that only one thread
        /// at a time runs an asynchronous operation.
        /// </summary>
        /// <param name="worker">(Required.) Thread that must be synchronized.</param>
        /// <returns>An awaitable <see cref="T:System.Threading.Tasks.Task" />.</returns>
        public async Task LockAsync(Func<Task> worker)
        {
            var isTaken = false;
            try
            {
                do
                    try { }
                    finally
                    {
                        isTaken =
                            await Semaphore.WaitAsync(TimeSpan.FromSeconds(1));
                    }
                while (!isTaken);

                await worker();
            }
            finally
            {
                if (isTaken) Semaphore.Release();
            }
        }

        /// <summary>
        /// Uses a semaphore instead of a critical section to ensure that only one thread
        /// at a time runs an asynchronous operation.
        /// </summary>
        /// <typeparam name="T">
        /// (Required.) Data type of the return value of the specified
        /// <paramref name="worker" /> thread.
        /// </typeparam>
        /// <param name="worker">(Required.) Thread that must be synchronized.</param>
        /// <returns>An awaitable <see cref="T:System.Threading.Tasks.Task" />.</returns>
        public async Task<T> LockAsync<T>(Func<Task<T>> worker)
        {
            var isTaken = false;
            try
            {
                do
                    try { }
                    finally
                    {
                        isTaken =
                            await Semaphore.WaitAsync(TimeSpan.FromSeconds(1));
                    }
                while (!isTaken);

                return await worker();
            }
            finally
            {
                if (isTaken) Semaphore.Release();
            }
        }
    }
}