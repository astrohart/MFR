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

using Alphaleonis.Win32.Filesystem;
using MFR.GUI.Models.Interfaces;
using MFR.Settings.Configuration.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MFR.Settings.Configuration.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
    /// interface, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewProjectFileRenamerConfig
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.FindWhat" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) A <see cref="T:System.String" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig AndFindWhat(
            this IProjectFileRenamerConfig self,
            string findWhat
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));
            if (!string.IsNullOrWhiteSpace(self.FindWhat) &&
                string.IsNullOrWhiteSpace(findWhat)) return self;

            self.FindWhat = findWhat;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.FindWhatHistory" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="findWhatHistory">
        /// (Required.) Reference to an instance of an enumerable collection of instances
        /// of <see cref="T:System.String" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig AndFindWhatHistory(
            this IProjectFileRenamerConfig self,
            List<string> findWhatHistory
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.FindWhatHistory = findWhatHistory;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.IsFolded" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="isFolded">
        /// (Required.) A <see cref="T:System.Boolean" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig AndIsFolded(
            this IProjectFileRenamerConfig self,
            bool isFolded
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.IsFolded = isFolded;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.MatchCase" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="matchCase">
        /// (Required.) A <see cref="T:System.Boolean" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig AndMatchCase(
            this IProjectFileRenamerConfig self,
            bool matchCase
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.MatchCase = matchCase;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.MatchExactWord" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="matchExactWord">
        /// (Required.) A <see cref="T:System.Boolean" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig AndMatchExactWord(
            this IProjectFileRenamerConfig self,
            bool matchExactWord
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.MatchExactWord = matchExactWord;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReplaceWith" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) A <see cref="T:System.String" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig AndReplaceWith(
            this IProjectFileRenamerConfig self,
            string replaceWith
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));
            if (!string.IsNullOrWhiteSpace(self.ReplaceWith) &&
                string.IsNullOrWhiteSpace(replaceWith)) return self;

            self.ReplaceWith = replaceWith;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReplaceWithHistory" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="replaceWithHistory">
        /// (Required.) Reference to an instance of an enumerable collection of instances
        /// of <see cref="T:System.String" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig AndReplaceWithHistory(
            this IProjectFileRenamerConfig self,
            List<string> replaceWithHistory
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReplaceWithHistory = replaceWithHistory;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.SelectedOptionTab" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="selectedOptionTab">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:System.Int32" /> interface.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig AndSelectedOptionTab(
            this IProjectFileRenamerConfig self,
            int selectedOptionTab
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.SelectedOptionTab = selectedOptionTab;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.RenameSolutionFolders" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="renameSolutionFolders">
        /// (Required.) A <see cref="T:System.Boolean" /> value that indicates whether the
        /// application should process the <c>Rename Folder(s) that Contain Solution(s)</c>
        /// operation.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig
            AndShouldRenameSolutionFolders(
                this IProjectFileRenamerConfig self,
                bool renameSolutionFolders
            )
        {
            if (self == null)
                throw new ArgumentNullException(nameof(self));

            self.RenameSolutionFolders = renameSolutionFolders;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.RenameSubFolders" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="renameSubFolders">
        /// (Required.) A <see cref="T:System.Boolean" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig
            AndShouldRenameSubFolders(
                this IProjectFileRenamerConfig self,
                bool renameSubFolders
            )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.RenameSubFolders = renameSubFolders;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReOpenSolution" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="reOpenSolution">
        /// (Required.) Value indicating whether any currently-loaded Solution in the
        /// target directory should be re-loaded when the operation(s) are completed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig AndShouldReOpenSolution(
            this IProjectFileRenamerConfig self,
            bool? reOpenSolution
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));
            if (reOpenSolution == null)
                return self;

            self.ReOpenSolution = reOpenSolution.Value;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ReplaceTextInFiles" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="replaceTextInFiles">
        /// (Required.) A <see cref="T:System.Boolean" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig
            AndShouldReplaceTextInFiles(
                this IProjectFileRenamerConfig self,
                bool replaceTextInFiles
            )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReplaceTextInFiles = replaceTextInFiles;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.StartingFolderHistory" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="startingFolderHistory">
        /// (Required.) Reference to an instance of an enumerable collection of instances
        /// of <see cref="T:System.String" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig AndStartingFolderHistory(
            this IProjectFileRenamerConfig self,
            List<string> startingFolderHistory
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.StartingFolderHistory = startingFolderHistory;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.StartingFolder" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="startingFolder">
        /// (Required.) A <see cref="T:System.String" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig ForStartingFolder(
            this IProjectFileRenamerConfig self,
            string startingFolder
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));
            if (string.IsNullOrWhiteSpace(startingFolder)) return self;
            if (!Directory.Exists(startingFolder)) return self;

            self.StartingFolder = startingFolder;
            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </returns>
        public static IProjectFileRenamerConfig FromScratch()
            => new ProjectFileRenamerConfig();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.InvokableOperations" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="operationsToPerform">
        /// (Required.) Reference to an instance of an enumerable collection of instances
        /// of <see cref="T:MFR.GUI.Models.OperationTypeInfo" /> that contains the desired
        /// value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig
            HavingInvokableOperations(
                this IProjectFileRenamerConfig self,
                IList<IOperationTypeInfo> operationsToPerform
            )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            if (self.InvokableOperations != null &&
                self.InvokableOperations.Any())
                self.InvokableOperations.Clear();

            self.InvokableOperations = operationsToPerform;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.IsFromCommandLine" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="isFromCommandLine">
        /// (Required.)
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig SetIsFromCommandLine(
            this IProjectFileRenamerConfig self,
            bool isFromCommandLine
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.IsFromCommandLine = isFromCommandLine;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.AutoStart" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="autoStart">
        /// (Required.) Sets a value indicating whether the specified operation(s) should
        /// be automatically processed when the application starts.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig ShouldAutoStart(
            this IProjectFileRenamerConfig self,
            bool autoStart
        )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.AutoStart = autoStart;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ShouldCommitPendingChanges" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="shouldCommitPendingChanges">
        /// (Required.) A <see cref="T:System.Boolean" /> value indicating whether the
        /// user's pending changes are to be committed prior to the start of the selected
        /// rename operation(s).
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig
            ShouldCommitPendingChanges(
                this IProjectFileRenamerConfig self,
                bool? shouldCommitPendingChanges
            )
        {
            if (self == null)
                throw new ArgumentNullException(nameof(self));
            if (!shouldCommitPendingChanges.HasValue) return self;
            
            self.ShouldCommitPendingChanges = (bool)shouldCommitPendingChanges;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.ShouldCommitPostOperationChanges" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="shouldCommitPostOperationChanges">
        /// (Required.) A <see cref="T:System.Boolean" /> value that indicates whether the
        /// changes that this application makes are to be committed to the local Git
        /// repository when the selected renaming operation(s) have completed their
        /// execution.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig
            ShouldCommitPostOperationChanges(
                this IProjectFileRenamerConfig self,
                bool? shouldCommitPostOperationChanges
            )
        {
            if (self == null)
                throw new ArgumentNullException(nameof(self));
            if (!shouldCommitPostOperationChanges.HasValue) return self;

            self.ShouldCommitPostOperationChanges =
                (bool)shouldCommitPostOperationChanges;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig.RenameFilesInFolder" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </param>
        /// <param name="renameFiles">
        /// (Required.) A <see cref="T:System.Boolean" /> that contains the desired value.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IProjectFileRenamerConfig
            ShouldRenameFilesInFolder(
                this IProjectFileRenamerConfig self,
                bool renameFiles
            )
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.RenameFilesInFolder = renameFiles;
            return self;
        }
    }
}