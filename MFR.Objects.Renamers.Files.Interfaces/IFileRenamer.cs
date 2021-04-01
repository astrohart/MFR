using MFR.GUI.Events;
using MFR.Objects.Configuration.Interfaces;
using MFR.Objects.Events;
using MFR.Objects.Events.Common;
using MFR.Objects.Operations.Events;
using System;

namespace MFR.Objects.Renamers.Files.Interfaces
{
    public interface IFileRenamer : IConfigurationComposedObject
    {
        /// <summary>
        /// Occurs when an exception is thrown from an operation.
        /// </summary>
        event ExceptionRaisedEventHandler ExceptionRaised;

        /// <summary>
        /// Occurs when files to be renamed have been counted.
        /// </summary>
        event FilesOrFoldersCountedEventHandler FilesToBeRenamedCounted;

        /// <summary>
        /// Occurs when files to have text replaced in them have been counted.
        /// </summary>
        event FilesOrFoldersCountedEventHandler FilesToHaveTextReplacedCounted;

        /// <summary>
        /// Occurs when a file system entry (e.g., a file or a folder) does not
        /// meet the criteria for being included in an operation.
        /// </summary>
        event FileSystemEntrySkippedEventHandler FileSystemEntrySkipped;

        /// <summary>
        /// Occurs when the processing is completely finished.
        /// </summary>
        event EventHandler Finished;

        /// <summary>
        /// Occurs when an operation has completed.
        /// </summary>
        event OperationFinishedEventHandler OperationFinished;

        /// <summary>
        /// Occurs when an operation has commenced.
        /// </summary>
        event OperationStartedEventHandler OperationStarted;

        /// <summary>
        /// Occurs when an operation is about to be processed for a file or a folder.
        /// </summary>
        event ProcessingOperationEventHandler ProcessingOperation;

        /// <summary>
        /// Occurs when the processing has started.
        /// </summary>
        event EventHandler Started;

        /// <summary>
        /// Occurs when a textual status message is available for display.
        /// </summary>
        event StatusUpdateEventHandler StatusUpdate;

        /// <summary>
        /// Occurs when subfolders to be renamed have been counted.
        /// </summary>
        event FilesOrFoldersCountedEventHandler SubfoldersToBeRenamedCounted;

        /// <summary>
        /// Gets a string containing the full pathname of the folder where all
        /// operations start.
        /// </summary>
        string RootDirectoryPath
        {
            get;
        }

        /// <summary>
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname stored in the <see
        /// cref="P:MFR.Objects.FileRenamer.RootDirectoryPath"/> property.
        /// </summary>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat"/> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file should be
        /// included in the operation or <see langword="false" /> otherwise.
        /// <para/>
        /// This parameter is <see langword="null" /> by default. This method should return
        /// <see langword="true" /> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other
        /// inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null" />, no path filtering
        /// is done.
        /// </param>
        void ProcessAll(string findWhat, string replaceWith,
            Predicate<string> pathFilter = null);

        /// <summary>
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname specified by the <paramref name="rootDirectoryPath"/> parameter.
        /// </summary>
        /// <param name="rootDirectoryPath">
        /// Path to the recursion root.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat"/> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file should be
        /// included in the operation or <see langword="false" /> otherwise.
        /// <para/>
        /// This parameter is <see langword="null" /> by default. This method should return
        /// <see langword="true" /> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other
        /// inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null" />, no path filtering
        /// is done.
        /// </param>
        void ProcessAll(string rootDirectoryPath, string findWhat,
            string replaceWith, Predicate<string> pathFilter = null);

        /// <summary>
        /// Renames all the files in the all the subfolders etc., recursively,
        /// of the folder whose pathname is specified by the <paramref
        /// name="rootFolderPath"/> parameter.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) String containing the full pathname of an existing
        /// directory on the computer that is to be where the operation is started.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat"/> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file should be
        /// included in the operation or <see langword="false" /> otherwise.
        /// <para/>
        /// This parameter is <see langword="null" /> by default. This method should return
        /// <see langword="true" /> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other
        /// inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null" />, no path filtering
        /// is done.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath"/>, <paramref
        /// name="findWhat"/> , or <paramref name="replaceWith"/> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the <paramref
        /// name="rootFolderPath"/> does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        void RenameFilesInFolder(string rootFolderPath, string findWhat,
            string replaceWith, Predicate<string> pathFilter = null);

        /// <summary>
        /// Recursively renames all the subfolders in the folder having a
        /// pathname specified by <paramref name="rootFolderPath"/>, replacing
        /// any occurrences of the text in the <paramref name="findWhat"/>
        /// parameter with the values in the <paramref name="replaceWith"/> parameter.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) String containing the full pathname of an existing
        /// directory on the computer that is to be where the operation is started.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat"/> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file should be
        /// included in the operation or <see langword="false" /> otherwise.
        /// <para/>
        /// This parameter is <see langword="null" /> by default. This method should return
        /// <see langword="true" /> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other
        /// inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null" />, no path filtering
        /// is done.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath"/>, <paramref
        /// name="findWhat"/> , or <paramref name="replaceWith"/> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the <paramref
        /// name="rootFolderPath"/> does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        void RenameSubFoldersOf(string rootFolderPath, string findWhat,
            string replaceWith, Predicate<string> pathFilter = null);

        /// <summary>
        /// Iterates recursively through a directory tree, starting at the
        /// folder with pathname <paramref name="rootFolderPath"/> and replacing
        /// every occurrence of the text specified by the <paramref
        /// name="findWhat"/> parameter with the text specified by the <paramref
        /// name="replaceWith"/> parameter. A case-sensitive, not-in-exact-word
        /// search is performed.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) Pathname of the folder where the operation is to start.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) Text to be found in each file contained in the directory tree.
        /// </param>
        /// <param name="replaceWith">
        /// (Optional.) Text to replace all the instances of <paramref
        /// name="findWhat"/> with. If this parameter is blank (the default),
        /// then the text is deleted.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file should be
        /// included in the operation or <see langword="false" /> otherwise.
        /// <para/>
        /// This parameter is <see langword="null" /> by default. This method should return
        /// <see langword="true" /> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other
        /// inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null" />, no path filtering
        /// is done.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath"/> or the
        /// <paramref name="findWhat"/> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the <paramref
        /// name="rootFolderPath"/> does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        void ReplaceTextInFiles(string rootFolderPath, string findWhat,
            string replaceWith, Predicate<string> pathFilter = null);

        /// <summary>
        /// Sets a flag requesting the currently-executing operation to abort as
        /// soon as possible.
        /// </summary>
        void RequestAbort();

        /// <summary>
        /// Initializes the value of the <see
        /// cref="P:MFR.Objects.Renamers.Files.Interfaces.IFileRenamer.RootDirectoryPath"/>
        /// property to the value specified in the <paramref
        /// name="rootDirectoryPath"/> parameter.
        /// <para/>
        /// The value is the starting location of the search operations.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        IFileRenamer StartingFrom(string rootDirectoryPath);
    }
}