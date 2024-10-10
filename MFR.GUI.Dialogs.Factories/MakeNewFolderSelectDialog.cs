using MFR.GUI.Dialogs.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.GUI.Dialogs.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog" /> interface, and
    /// returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewFolderSelectDialog
    {
        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog.InitialDirectory" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog" />
        /// interface.
        /// </param>
        /// <param name="initialDirectory">
        /// (Required.) String containing the fully-qualified pathname of the directory
        /// that the dialog box should be focused on when it first opens.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IFolderSelectDialog AndInitialDirectory(
            this IFolderSelectDialog self, string initialDirectory)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.InitialDirectory = initialDirectory;
            return self;
        }

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog" /> interface.
        /// </returns>
        public static IFolderSelectDialog FromScratch()
            => new FolderSelectDialog();

        /// <summary>
        /// Builder extension method that initializes the
        /// <see
        ///     cref="P:MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog.Title" />
        /// property.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.GUI.Dialogs.Interfaces.IFolderSelectDialog" />
        /// interface.
        /// </param>
        /// <param name="title">
        /// (Required.) String containing the text that is to be displayed om the titlebar
        /// of the dialog box that is to be displayed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="self" />, is
        /// passed a <see langword="null" /> value.
        /// </exception>
        public static IFolderSelectDialog HavingTitle(
            this IFolderSelectDialog self, string title)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));

            self.Title = title;
            return self;
        }
    }
}