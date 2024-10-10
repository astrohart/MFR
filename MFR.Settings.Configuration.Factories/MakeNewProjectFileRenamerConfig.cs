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