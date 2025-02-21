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
 */using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using xyLOGIX.Core.Debug;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// Exposes static methods to determine whether certain actions should be taken.
    /// </summary>
    public static class Should
    {
        /// <summary>
        /// Determines whether one or more of the entries in the
        /// <paramref name="previouslyLoadedSolutions" /> list has a value of its
        /// <see
        ///     cref="P:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution.ShouldReopen" />
        /// property that is <see langword="true" />.
        /// </summary>
        /// ///
        /// <param name="previouslyLoadedSolutions">
        /// (Required.) Reference to an instance of a collection of instances of objects
        /// that implement the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </param>
        /// <remarks>
        /// This method returns <see langword="false" /> if the argument of the
        /// <paramref name="previouslyLoadedSolutions" /> parameter is a
        /// <see langword="null" /> reference.
        /// <para />
        /// This method also returns <see langword="false" /> if the count of items in the
        /// <paramref name="previouslyLoadedSolutions" /> collection is zero.
        /// <para />
        /// If an error occurs while searching the
        /// <paramref name="previouslyLoadedSolutions" /> collection, then this method
        /// returns <see langword="false" />.
        /// </remarks>
        /// <returns>
        /// <see langword="true" /> if at least one of the
        /// <paramref name="previouslyLoadedSolutions" /> should be reopened;
        /// <see langword="false" /> otherwise.
        /// </returns>
        public static bool AnyPreviouslyLoadedSolutionsBeReopened(
            [NotLogged] IList<IVisualStudioSolution> previouslyLoadedSolutions
        )
        {
            var result = false;

            try
            {
                if (previouslyLoadedSolutions == null) return result;
                if (previouslyLoadedSolutions.Count == 0) return result;

                var found = 0;

                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (var solution in previouslyLoadedSolutions)
                {
                    if (!solution.ShouldReopen) continue;

                    found++;
                    break; /* we do not care how many; just one is enough */
                }

                result = found > 0;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(DebugLevel.Debug, $"Should.AnyPreviouslyLoadedSolutionsBeReopened: Result = {result}");

            return result;
        }
    }
}