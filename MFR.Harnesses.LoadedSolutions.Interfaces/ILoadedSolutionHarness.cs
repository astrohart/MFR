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

using System;
using System.ComponentModel;
using System.Diagnostics;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Harnesses.LoadedSolutions.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed events, methods and properties of an object that
    /// serves as a <c>harness</c> for a Visual Studio Solution (<c>*.sln</c>) file
    /// that is loaded in a currently-running instance of Visual Studio..
    /// </summary>
    public interface ILoadedSolutionHarness
    {
        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the folder that the target Solution is located in.
        /// </summary>
        /// <remarks>
        /// This property returns the <see cref="F:System.String.Empty" /> value
        /// in the case that the value cannot be determined.
        /// </remarks>
        string ContainingFolder
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        string FullName
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the Visual Studio Solution (
        /// <c>*.sln</c>) file managed by the target instance of Visual Studio is in the
        /// directory tree of the current Project File Renamer operation or not.
        /// </summary>
        /// <remarks>
        /// This important because it may very well be the case that there may be
        /// running instances of Visual Studio lying about, that have Visual Studio
        /// Solution (<c>*.sln</c>) file(s) loaded, and these particular files are not
        /// underneath the starting folder selected by the user in the Project File
        /// Renamer.
        /// </remarks>
        bool IsInRootDirectoryTree
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Gets a value that indicates whether the target Visual Studio Solution (
        /// <c>*.sln</c>) file is loaded in a running instance of Visual Studio.
        /// </summary>
        bool IsLoaded
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// Such an object is utilized to automate the instance of Visual Studio that
        /// controls the particular Visual Studio Solution (<c>*.sln</c>) file.
        /// <para />
        /// When the value of this property is updated, the
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolutionChanged" />
        /// event is raised.
        /// </remarks>
        IVisualStudioSolution TargetSolution
        {
            [DebuggerStepThrough] get;
            [DebuggerStepThrough] set;
        }

        /// <summary>
        /// Opens the target Visual Studio Solution (<c>*.sln</c>) file in the target
        /// running instance of Visual Studio.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the operation completed successfully;
        /// <see langword="false" /> otherwise or if the value of the
        /// <see
        ///     cref="P:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.TargetSolution" />
        /// property is <see langword="null" />.
        /// </returns>
        bool Load();

        /// <summary>
        /// Occurs when the target running instance of Visual Studio has finished loading
        /// the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        event EventHandler Loaded;

        /// <summary>
        /// Occurs when the target running instance of Visual Studio is about to begin
        /// loading the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        /// <remarks>
        /// The handler can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventHandler.Cancel" /> property to
        /// <see langword="true" /> to prevent the operation from being carried out.
        /// </remarks>
        event CancelEventHandler Loading;

        /// <summary>
        /// Exits the running instance of Visual Studio that has the target Visual Studio
        /// Solution (<c>*.sln</c>) file open.
        /// </summary>
        void Quit();

        /// <summary>
        /// Occurs when the target running instance of Visual Studio has been exited.
        /// </summary>
        event EventHandler Quitted;

        /// <summary>
        /// Occurs when we are about to shut down the target running instance of Visual
        /// Studio.
        /// </summary>
        /// The handler can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventHandler.Cancel" />
        /// property to
        /// <see langword="true" />
        /// to prevent the operation from being carried out.
        /// </remarks>
        event CancelEventHandler Quitting;

        /// <summary>
        /// Open the target Visual Studio Solution (<c>*.sln</c>) file (if it exists) using
        /// the Windows Shell.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the operation succeeded;
        /// <see langword="false" /> otherwise, or if the operation is cancelled.
        /// </returns>
        /// <remarks>
        /// The
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.ShellOpening" />
        /// event is raised before the operation is carried out.  Handlers have a chance to
        /// request that the operation be cancelled.
        /// <para />
        /// The
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.ShellOpened" />
        /// event is raised when this method has completed executing the requested
        /// operations.
        /// </remarks>
        bool ShellOpen();

        /// <summary>
        /// Occurs when the target Visual Studio Solution (<c>*.sln</c>) file has been
        /// opened using the Windows Shell.
        /// </summary>
        event EventHandler ShellOpened;

        /// <summary>
        /// Occurs when we are about to open the target Visual Studio Solution (
        /// <c>*.sln</c>) file using the Windows Shell.
        /// </summary>
        /// The handler can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventHandler.Cancel" />
        /// property to
        /// <see langword="true" />
        /// to prevent the operation from being carried out.
        /// </remarks>
        event CancelEventHandler ShellOpening;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolution" />
        /// property is changed.
        /// </summary>
        event EventHandler TargetSolutionChanged;

        /// <summary>
        /// Unloads the target Visual Studio Solution (<c>*.sln</c>) file from the running
        /// instance of Visual Studio that has it open.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the operation completed successfully;
        /// <see langword="false" /> otherwise or if the value of the
        /// <see
        ///     cref="P:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.TargetSolution" />
        /// property is <see langword="null" />.
        /// </returns>
        /// <remarks>
        /// The
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.Unloading" />
        /// event is raised before the operation is carried out.  Handlers have a chance to
        /// request that the operation be cancelled.
        /// <para />
        /// The
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.Unloaded" />
        /// event is raised when this method has completed executing the requested
        /// operations.
        /// </remarks>
        bool Unload();

        /// <summary>
        /// Occurs when the target Visual Studio Solution (<c>*.sln</c>) file has been
        /// unloaded from the target running instance of Visual Studio.
        /// </summary>
        event EventHandler Unloaded;

        /// <summary>
        /// Occurs when we are about to unload the target Visual Studio Solution (
        /// <c>*.sln</c>) file from the target running instance of Visual Studio.
        /// </summary>
        /// The handler can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventHandler.Cancel" />
        /// property to
        /// <see langword="true" />
        /// to prevent the operation from being carried out.
        /// </remarks>
        event CancelEventHandler Unloading;
    }
}