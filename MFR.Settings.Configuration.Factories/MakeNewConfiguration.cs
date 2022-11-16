using MFR.GUI.Models;
using MFR.Settings.Configuration.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;

namespace MFR.Settings.Configuration.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
    /// interface, and returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewConfiguration
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.FindWhat" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndFindWhat(this IConfiguration self,
            string findWhat)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.FindWhat = findWhat;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.FindWhatHistory" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndFindWhatHistory(
            this IConfiguration self, List<string> findWhatHistory)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.FindWhatHistory = findWhatHistory;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.IsFolded" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndIsFolded(this IConfiguration self,
            bool isFolded)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.IsFolded = isFolded;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.MatchCase" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndMatchCase(this IConfiguration self,
            bool matchCase)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.MatchCase = matchCase;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.MatchExactWord" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndMatchExactWord(this IConfiguration self,
            bool matchExactWord)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.MatchExactWord = matchExactWord;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.OperationsToPerform" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndOperationsToPerform(
            this IConfiguration self,
            List<OperationTypeInfo> operationsToPerform)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.OperationsToPerform = operationsToPerform;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.ReOpenSolution" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndReOpenSolution(this IConfiguration self,
            bool reOpenSolution)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReOpenSolution = reOpenSolution;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.ReplaceWith" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndReplaceWith(this IConfiguration self,
            string replaceWith)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReplaceWith = replaceWith;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.ReplaceWithHistory" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndReplaceWithHistory(
            this IConfiguration self, List<string> replaceWithHistory)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReplaceWithHistory = replaceWithHistory;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.SelectedOptionTab" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndSelectedOptionTab(
            this IConfiguration self, int selectedOptionTab)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.SelectedOptionTab = selectedOptionTab;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.RenameSubFolders" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndSetRenameSubFoldersTo(
            this IConfiguration self, bool renameSubFolders)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.RenameSubFolders = renameSubFolders;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.ReplaceTextInFiles" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndSetReplaceTextInFilesTo(
            this IConfiguration self, bool replaceTextInFiles)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReplaceTextInFiles = replaceTextInFiles;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.ReOpenSolution" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndShouldReOpenSolution(
            this IConfiguration self, bool reOpenSolution)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.ReOpenSolution = reOpenSolution;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.StartingFolderHistory" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration AndStartingFolderHistory(
            this IConfiguration self, List<string> startingFolderHistory)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.StartingFolderHistory = startingFolderHistory;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.StartingFolder" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration ForStartingFolder(this IConfiguration self,
            string startingFolder)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.StartingFolder = startingFolder;
            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" /> interface
        /// and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
        /// interface.
        /// </returns>
        public static IConfiguration FromScratch()
            => new Configuration();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.IsFromCommandLine" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration SetIsFromCommandLine(
            this IConfiguration self, bool isFromCommandLine)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.IsFromCommandLine = isFromCommandLine;
            return self;
        }

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.Interfaces.IConfiguration.RenameFiles" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
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
        public static IConfiguration SetRenameFilesTo(this IConfiguration self,
            bool renameFiles)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.RenameFiles = renameFiles;
            return self;
        }
    }
}