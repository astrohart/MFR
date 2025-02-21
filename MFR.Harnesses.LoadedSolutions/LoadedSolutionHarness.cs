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
 */using Alphaleonis.Win32.Filesystem;
using MFR.Harnesses.LoadedSolutions.Interfaces;
using System;
using System.ComponentModel;
using System.Diagnostics;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Harnesses.LoadedSolutions
{
    /// <summary>
    /// Provides a <c>harness</c> that links a Visual Studio Solution (<c>*.sln</c>)
    /// file together with the additional parameters and properties that enable the
    /// application to work with it.
    /// </summary>
    /// <remarks>
    /// A <c>harness</c> object to associate a Visual Studio Solution (<c>*.sln</c>)
    /// file that
    /// is loaded in a target running instance of Visual Studio with additional
    /// parameters and options that make ti possible for the Project File Renamer
    /// application to effectively manage it, regardless of whether the Visual Studio
    /// Solution (<c>*.sln</c>) in question is in or out of the directory tree of the
    /// root directory (i.e., the folder that the user has chosen to start the Project
    /// File Renamer operations in).
    /// </remarks>
    public class LoadedSolutionHarness : ILoadedSolutionHarness
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represents the Visual Studio Solution (<c>*.sln</c>) that is
        /// targeted by this harness.
        /// </summary>
        private IVisualStudioSolution _targetSolution;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness" /> and
        /// returns a reference to it.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="targetSolution" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        public LoadedSolutionHarness(IVisualStudioSolution targetSolution)
        {
            TargetSolution = targetSolution ??
                             throw new ArgumentNullException(
                                 nameof(targetSolution)
                             );
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the folder that the target Solution is located in.
        /// </summary>
        /// <remarks>
        /// This property returns the <see cref="F:System.String.Empty" /> value
        /// in the case that the value cannot be determined.
        /// </remarks>
        public string ContainingFolder
        {
            get {
                var result = string.Empty;

                try
                {
                    if (TargetSolution == null) return result;
                    if (!Does.FolderExist(TargetSolution.ContainingFolder))
                        return result;

                    result = TargetSolution.ContainingFolder;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = string.Empty;
                }

                return result;
            }
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        public string FullName
        {
            get {
                var result = string.Empty;

                try
                {
                    if (TargetSolution == null) return result;
                    if (!Does.FileExist(TargetSolution.FullName)) return result;

                    result = TargetSolution.FullName;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = string.Empty;
                }

                return result;
            }
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
        public bool IsInRootDirectoryTree
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value that indicates whether the target Visual Studio Solution (
        /// <c>*.sln</c>) file is loaded in a running instance of Visual Studio.
        /// </summary>
        public bool IsLoaded
        {
            get {
                var result = false;

                try
                {
                    if (TargetSolution == null) return result;
                    if (string.IsNullOrWhiteSpace(TargetSolution.FullName))
                        return result;
                    if (!Does.FileExist(TargetSolution.FullName)) return result;

                    result = TargetSolution.IsLoaded;
                }
                catch (Exception ex)
                {
                    // dump all the exception info to the log
                    DebugUtils.LogException(ex);

                    result = false;
                }

                return result;
            }
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
        public IVisualStudioSolution TargetSolution
        {
            get => _targetSolution;
            set {
                var changed = _targetSolution != value;
                _targetSolution = value;
                if (changed) OnTargetSolutionChanged();
            }
        }

        /// <summary>
        /// Opens the target Visual Studio Solution (<c>*.sln</c>) file in the target
        /// running instance of Visual Studio.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the operation completed successfully;
        /// <see langword="false" /> otherwise or if the value of the
        /// <see
        ///     cref="P:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolution" />
        /// property is <see langword="null" />.
        /// </returns>
        /// <remarks>
        /// The
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Loading" />
        /// event is raised before the operation is carried out.  Handlers have a chance to
        /// request that the operation be cancelled.
        /// <para />
        /// The
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Loaded" />
        /// event is raised when this method has completed executing the requested
        /// operations.
        /// </remarks>
        public bool Load()
        {
            var result = false;

            try
            {
                if (TargetSolution == null) return result;

                var ce = new CancelEventArgs();
                OnLoading(ce);
                if (ce.Cancel) return result;

                result = TargetSolution.Load();

                if (result) OnLoaded();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Occurs when the target running instance of Visual Studio has finished loading
        /// the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        public event EventHandler Loaded;

        /// <summary>
        /// Occurs when the target running instance of Visual Studio is about to begin
        /// loading the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        /// <remarks>
        /// The handler can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventHandler.Cancel" /> property to
        /// <see langword="true" /> to prevent the operation from being carried out.
        /// </remarks>
        public event CancelEventHandler Loading;

        /// <summary>
        /// Exits the running instance of Visual Studio that has the target Visual Studio
        /// Solution (<c>*.sln</c>) file open.
        /// </summary>
        public void Quit()
        {
            try
            {
                if (TargetSolution == null) return;

                var ce = new CancelEventArgs();
                OnQuitting(ce);
                if (ce.Cancel) return;

                TargetSolution.Quit();

                OnQuitted();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Occurs when the target running instance of Visual Studio has been exited.
        /// </summary>
        public event EventHandler Quitted;

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
        public event CancelEventHandler Quitting;

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
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.ShellOpening" />
        /// event is raised before the operation is carried out.  Handlers have a chance to
        /// request that the operation be cancelled.
        /// <para />
        /// The
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.ShellOpened" />
        /// event is raised when this method has completed executing the requested
        /// operations.
        /// </remarks>
        public bool ShellOpen()
        {
            var result = false;

            try
            {
                if (!Does.FileExist(FullName)) return result;
                if (!".sln".Equals(Path.GetExtension(FullName))) return result;

                var ce = new CancelEventArgs();
                OnShellOpening(ce);
                if (ce.Cancel) return result;

                var proc = Process.Start(FullName);

                result = proc != null;

                OnShellOpened();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Occurs when the target Visual Studio Solution (<c>*.sln</c>) file has been
        /// opened using the Windows Shell.
        /// </summary>
        public event EventHandler ShellOpened;

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
        public event CancelEventHandler ShellOpening;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolution" />
        /// property is changed.
        /// </summary>
        public event EventHandler TargetSolutionChanged;

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
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Unloading" />
        /// event is raised before the operation is carried out.  Handlers have a chance to
        /// request that the operation be cancelled.
        /// <para />
        /// The
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Unloaded" />
        /// event is raised when this method has completed executing the requested
        /// operations.
        /// </remarks>
        public bool Unload()
        {
            var result = false;

            try
            {
                if (TargetSolution == null) return result;

                var ce = new CancelEventArgs();
                OnUnloading(ce);
                if (ce.Cancel) return result;

                if (!IsLoaded) return true; // already unloaded

                result = TargetSolution.Unload();

                OnUnloaded();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        /// <summary>
        /// Occurs when the target Visual Studio Solution (<c>*.sln</c>) file has been
        /// unloaded from the target running instance of Visual Studio.
        /// </summary>
        public event EventHandler Unloaded;

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
        public event CancelEventHandler Unloading;

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Loaded" />
        /// event.
        /// </summary>
        protected virtual void OnLoaded()
            => Loaded?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Loading" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnLoading(CancelEventArgs e)
            => Loading?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Quitted" />
        /// event.
        /// </summary>
        protected virtual void OnQuitted()
            => Quitted?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Quitting" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnQuitting(CancelEventArgs e)
            => Quitting?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.ShellOpened" />
        /// event.
        /// </summary>
        protected virtual void OnShellOpened()
            => ShellOpened?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.ShellOpening" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnShellOpening(CancelEventArgs e)
            => ShellOpening?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolutionChanged" />
        /// event.
        /// </summary>
        protected virtual void OnTargetSolutionChanged()
            => TargetSolutionChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Unloaded" />
        /// event.
        /// </summary>
        protected virtual void OnUnloaded()
            => Unloaded?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.Unloading" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnUnloading(CancelEventArgs e)
            => Unloading?.Invoke(this, e);
    }
}