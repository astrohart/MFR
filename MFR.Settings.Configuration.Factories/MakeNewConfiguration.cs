using MFR.GUI.Models;
using MFR.Settings.Configuration.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;

namespace MFR.Settings.Configuration.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
    /// interface, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewConfiguration
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.FindWhat" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndFindWhat(this IProjectFileRenamerConfiguration self,
            string findWhat)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.FindWhat = findWhat;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.FindWhatHistory" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndFindWhatHistory(
            this IProjectFileRenamerConfiguration self, List<string> findWhatHistory)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.FindWhatHistory = findWhatHistory;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.IsFolded" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndIsFolded(this IProjectFileRenamerConfiguration self,
            bool isFolded)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.IsFolded = isFolded;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.MatchCase" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndMatchCase(this IProjectFileRenamerConfiguration self,
            bool matchCase)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.MatchCase = matchCase;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.MatchExactWord" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndMatchExactWord(this IProjectFileRenamerConfiguration self,
            bool matchExactWord)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.MatchExactWord = matchExactWord;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.OperationsToPerform" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndOperationsToPerform(
            this IProjectFileRenamerConfiguration self,
            List<OperationTypeInfo> operationsToPerform)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.OperationsToPerform = operationsToPerform;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.ReOpenSolution" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </param>
        /// <param name="reOpenSolution">
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
        public static IProjectFileRenamerConfiguration AndReOpenSolution(this IProjectFileRenamerConfiguration self,
            bool reOpenSolution)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReOpenSolution = reOpenSolution;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.ReplaceWith" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndReplaceWith(this IProjectFileRenamerConfiguration self,
            string replaceWith)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReplaceWith = replaceWith;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.ReplaceWithHistory" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndReplaceWithHistory(
            this IProjectFileRenamerConfiguration self, List<string> replaceWithHistory)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReplaceWithHistory = replaceWithHistory;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.SelectedOptionTab" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndSelectedOptionTab(
            this IProjectFileRenamerConfiguration self, int selectedOptionTab)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.SelectedOptionTab = selectedOptionTab;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.RenameSubFolders" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndSetRenameSubFoldersTo(
            this IProjectFileRenamerConfiguration self, bool renameSubFolders)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.RenameSubFolders = renameSubFolders;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.ReplaceTextInFiles" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndSetReplaceTextInFilesTo(
            this IProjectFileRenamerConfiguration self, bool replaceTextInFiles)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReplaceTextInFiles = replaceTextInFiles;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.ReOpenSolution" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndShouldReOpenSolution(
            this IProjectFileRenamerConfiguration self, bool reOpenSolution)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReOpenSolution = reOpenSolution;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.StartingFolderHistory" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration AndStartingFolderHistory(
            this IProjectFileRenamerConfiguration self, List<string> startingFolderHistory)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.StartingFolderHistory = startingFolderHistory;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.StartingFolder" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration ForStartingFolder(this IProjectFileRenamerConfiguration self,
            string startingFolder)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.StartingFolder = startingFolder;
            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" /> interface
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </returns>
        public static IProjectFileRenamerConfiguration FromScratch()
            => new ProjectFileRenamerProjectFileRenamerConfiguration();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.IsFromCommandLine" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration SetIsFromCommandLine(
            this IProjectFileRenamerConfiguration self, bool isFromCommandLine)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.IsFromCommandLine = isFromCommandLine;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.RenameFiles" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration SetRenameFilesTo(this IProjectFileRenamerConfiguration self,
            bool renameFiles)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.RenameFiles = renameFiles;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.ProjectFileRenamerConfiguration.Interfaces.IProjectFileRenamerConfiguration.AutoStart" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
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
        public static IProjectFileRenamerConfiguration ShouldAutoStart(this IProjectFileRenamerConfiguration self,
            bool autoStart)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.AutoStart = autoStart;
            return self;
        }
    }
}