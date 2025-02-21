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
 */using System.Collections.Generic;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Services.Solutions.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a <c>Solution Service</c> object.
    /// </summary>
    /// <remarks>
    /// <c>Solution Service</c> objects allow management of Visual Studio Solution
    /// (*.sln) files, such as scanning for them, detecting if they're loaded,
    /// and loading / unloading them in open instances of Visual Studio.
    /// </remarks>
    public interface IVisualStudioSolutionService
    {
        /// <summary>
        /// Gets or sets the fully-qualified pathname of the folder that is to be searched
        /// for <c>.sln</c> files.
        /// </summary>
        string FolderToSearch
        {
            get;
            set;
        }

        /// <summary>
        /// Determines whether the folder having path passed in the
        /// <paramref
        ///     name="folder" />
        /// parameter contains any <c>*.sln</c> files that represent
        /// solutions currently loaded by running instances of Visual Studio.
        /// </summary>
        /// <param name="folder">
        /// (Required.) String containing the fully-qualified pathname of a
        /// folder that should be scanned for <c>*.sln</c> files.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="folder" />
        /// contains <c>*.sln</c> files that are currently loaded by running instances
        /// of Visual Studio; <see langword="false" /> otherwise.
        /// </returns>
        bool ContainsLoadedSolutions(string folder);

        /// <summary>
        /// Scans the folder whose path is provided in the
        /// <paramref
        ///     name="folder" />
        /// parameter for <c>*.sln</c> files, and, for each file
        /// located, determines whether a running instance of Visual Studio has
        /// it loaded.
        /// <para />
        /// If this is so, then information about the loaded solution is
        /// returned as an element of a collection of any other such solutions.
        /// </summary>
        /// <param name="folder">
        /// (Required.) String containing the fully-qualified pathname of a
        /// folder that should be scanned for <c>*.sln</c> files.
        /// </param>
        /// <returns>
        /// Read-only list of references to instances of objects that implement
        /// the
        /// <see
        ///     cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface for each instance of Visual Studio that has that solution loaded.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref name="folder" />, is
        /// passed a blank or <see langword="null" /> string for a value.
        /// </exception>
        /// <exception cref="T:DirectoryNotFoundException">
        /// Thrown if the directory whose fully-qualified path is passed in the
        /// <paramref name="folder" /> parameter cannot be found on the file system.
        /// </exception>
        IReadOnlyList<IVisualStudioSolution> GetLoadedSolutionsInFolder(
            string folder);

        /// <summary>
        /// Instructs the appropriate currently-running instances of Visual
        /// Studio who had solutions in the specified collection open at one
        /// time, to load them again.
        /// </summary>
        /// <param name="solutions">
        /// (Required.) Reference to a collection of references to instances of
        /// objects that implement the
        /// <see
        ///     cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represent the solution(s) to be loaded.
        /// </param>
        void LoadAll(IReadOnlyList<IVisualStudioSolution> solutions);

        /// <summary>
        /// Instructs the appropriate currently-running instances of Visual
        /// Studio who had solutions in the specified collection not loaded at
        /// one time, to unload them again.
        /// </summary>
        /// <param name="solutions">
        /// (Required.) Reference to a collection of references to instances of
        /// objects that implement the
        /// <see
        ///     cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface which represent the solution(s) to be unloaded.
        /// </param>
        void UnloadAll(IReadOnlyList<IVisualStudioSolution> solutions);

        /// <summary>
        /// Alias for the
        /// <see
        ///     cref="M:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService.ContainsLoadedSolutions" />
        /// method.
        /// <para />
        /// This serves to make this class more fluent.
        /// </summary>
        /// <returns>
        /// This method returns the same value as the
        /// <see
        ///     cref="M:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService.ContainsLoadedSolutions" />
        /// method does when a blank value is passed for its input.
        /// </returns>
        bool ContainLoadedSolutions();
    }
}