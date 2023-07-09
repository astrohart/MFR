<a name='assembly'></a>
# MFR.Constants

## Contents

- [ConfigFile](#T-MFR-Constants-ConfigFile 'MFR.Constants.ConfigFile')
  - [DefaultFilename](#F-MFR-Constants-ConfigFile-DefaultFilename 'MFR.Constants.ConfigFile.DefaultFilename')
- [FileRenamerMessageId](#T-MFR-Constants-FileRenamerMessageId 'MFR.Constants.FileRenamerMessageId')
  - [MessageId](#P-MFR-Constants-FileRenamerMessageId-MessageId 'MFR.Constants.FileRenamerMessageId.MessageId')
  - [Name](#P-MFR-Constants-FileRenamerMessageId-Name 'MFR.Constants.FileRenamerMessageId.Name')
  - [IsZero()](#M-MFR-Constants-FileRenamerMessageId-IsZero 'MFR.Constants.FileRenamerMessageId.IsZero')
  - [ToString()](#M-MFR-Constants-FileRenamerMessageId-ToString 'MFR.Constants.FileRenamerMessageId.ToString')
  - [op_Implicit(id)](#M-MFR-Constants-FileRenamerMessageId-op_Implicit-MFR-Constants-FileRenamerMessageId-~System-Guid 'MFR.Constants.FileRenamerMessageId.op_Implicit(MFR.Constants.FileRenamerMessageId)~System.Guid')
- [FileRenamerMessages](#T-MFR-Constants-FileRenamerMessages 'MFR.Constants.FileRenamerMessages')
  - [FRM_CURRENT_OPERATION_CHANGED](#F-MFR-Constants-FileRenamerMessages-FRM_CURRENT_OPERATION_CHANGED 'MFR.Constants.FileRenamerMessages.FRM_CURRENT_OPERATION_CHANGED')
  - [FRM_EXCEPTION_RAISED](#F-MFR-Constants-FileRenamerMessages-FRM_EXCEPTION_RAISED 'MFR.Constants.FileRenamerMessages.FRM_EXCEPTION_RAISED')
  - [FRM_FILES_TO_BE_RENAMED_COUNTED](#F-MFR-Constants-FileRenamerMessages-FRM_FILES_TO_BE_RENAMED_COUNTED 'MFR.Constants.FileRenamerMessages.FRM_FILES_TO_BE_RENAMED_COUNTED')
  - [FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED](#F-MFR-Constants-FileRenamerMessages-FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED 'MFR.Constants.FileRenamerMessages.FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED')
  - [FRM_FILE_RENAMED](#F-MFR-Constants-FileRenamerMessages-FRM_FILE_RENAMED 'MFR.Constants.FileRenamerMessages.FRM_FILE_RENAMED')
  - [FRM_FILE_SYSTEM_ENTRY_SKIPPED](#F-MFR-Constants-FileRenamerMessages-FRM_FILE_SYSTEM_ENTRY_SKIPPED 'MFR.Constants.FileRenamerMessages.FRM_FILE_SYSTEM_ENTRY_SKIPPED')
  - [FRM_FINISHED](#F-MFR-Constants-FileRenamerMessages-FRM_FINISHED 'MFR.Constants.FileRenamerMessages.FRM_FINISHED')
  - [FRM_FOLDER_RENAMED](#F-MFR-Constants-FileRenamerMessages-FRM_FOLDER_RENAMED 'MFR.Constants.FileRenamerMessages.FRM_FOLDER_RENAMED')
  - [FRM_OPERATION_FINISHED](#F-MFR-Constants-FileRenamerMessages-FRM_OPERATION_FINISHED 'MFR.Constants.FileRenamerMessages.FRM_OPERATION_FINISHED')
  - [FRM_OPERATION_STARTED](#F-MFR-Constants-FileRenamerMessages-FRM_OPERATION_STARTED 'MFR.Constants.FileRenamerMessages.FRM_OPERATION_STARTED')
  - [FRM_PROCESSING_OPERATION](#F-MFR-Constants-FileRenamerMessages-FRM_PROCESSING_OPERATION 'MFR.Constants.FileRenamerMessages.FRM_PROCESSING_OPERATION')
  - [FRM_ROOT_DIRECTORY_PATH_CHANGED](#F-MFR-Constants-FileRenamerMessages-FRM_ROOT_DIRECTORY_PATH_CHANGED 'MFR.Constants.FileRenamerMessages.FRM_ROOT_DIRECTORY_PATH_CHANGED')
  - [FRM_SOLUTION_CLOSE_FAILED](#F-MFR-Constants-FileRenamerMessages-FRM_SOLUTION_CLOSE_FAILED 'MFR.Constants.FileRenamerMessages.FRM_SOLUTION_CLOSE_FAILED')
  - [FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED](#F-MFR-Constants-FileRenamerMessages-FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED 'MFR.Constants.FileRenamerMessages.FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED')
  - [FRM_SOLUTION_FOLDER_RENAMED](#F-MFR-Constants-FileRenamerMessages-FRM_SOLUTION_FOLDER_RENAMED 'MFR.Constants.FileRenamerMessages.FRM_SOLUTION_FOLDER_RENAMED')
  - [FRM_SOLUTION_OPEN_FAILED](#F-MFR-Constants-FileRenamerMessages-FRM_SOLUTION_OPEN_FAILED 'MFR.Constants.FileRenamerMessages.FRM_SOLUTION_OPEN_FAILED')
  - [FRM_STARTED](#F-MFR-Constants-FileRenamerMessages-FRM_STARTED 'MFR.Constants.FileRenamerMessages.FRM_STARTED')
  - [FRM_STARTING](#F-MFR-Constants-FileRenamerMessages-FRM_STARTING 'MFR.Constants.FileRenamerMessages.FRM_STARTING')
  - [FRM_STATUS_UPDATE](#F-MFR-Constants-FileRenamerMessages-FRM_STATUS_UPDATE 'MFR.Constants.FileRenamerMessages.FRM_STATUS_UPDATE')
  - [FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED](#F-MFR-Constants-FileRenamerMessages-FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED 'MFR.Constants.FileRenamerMessages.FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED')
- [ProfileFile](#T-MFR-Constants-ProfileFile 'MFR.Constants.ProfileFile')
  - [DefaultFilename](#F-MFR-Constants-ProfileFile-DefaultFilename 'MFR.Constants.ProfileFile.DefaultFilename')
- [Resources](#T-MFR-Constants-Properties-Resources 'MFR.Constants.Properties.Resources')
  - [Culture](#P-MFR-Constants-Properties-Resources-Culture 'MFR.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Constants-Properties-Resources-ResourceManager 'MFR.Constants.Properties.Resources.ResourceManager')
  - [StatusUpdate_AttemptingToRenameSolutionFolders](#P-MFR-Constants-Properties-Resources-StatusUpdate_AttemptingToRenameSolutionFolders 'MFR.Constants.Properties.Resources.StatusUpdate_AttemptingToRenameSolutionFolders')

<a name='T-MFR-Constants-ConfigFile'></a>
## ConfigFile `type`

##### Namespace

MFR.Constants

##### Summary

String constants for the default names of files and folders relating to the
application configuration.

<a name='F-MFR-Constants-ConfigFile-DefaultFilename'></a>
### DefaultFilename `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the default filename to be used
for the file containing the application configuration, `config.json`.

<a name='T-MFR-Constants-FileRenamerMessageId'></a>
## FileRenamerMessageId `type`

##### Namespace

MFR.Constants

##### Summary

Encapsulates a unique identifier for a message, as well as its name.

<a name='P-MFR-Constants-FileRenamerMessageId-MessageId'></a>
### MessageId `property`

##### Summary

Gets or sets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that uniquely identifies the
message.

<a name='P-MFR-Constants-FileRenamerMessageId-Name'></a>
### Name `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that names this message
identifier.

<a name='M-MFR-Constants-FileRenamerMessageId-IsZero'></a>
### IsZero() `method`

##### Summary

Determines whether the value of the
[MessageId](#P-MFR-Constants-FileRenamerMessageId-MessageId 'MFR.Constants.FileRenamerMessageId.MessageId') property is set
to the Zero GUID.

##### Returns

`true` if the value of the
[MessageId](#P-MFR-Constants-FileRenamerMessageId-MessageId 'MFR.Constants.FileRenamerMessageId.MessageId') property is set
to the Zero GUID; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='M-MFR-Constants-FileRenamerMessageId-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='M-MFR-Constants-FileRenamerMessageId-op_Implicit-MFR-Constants-FileRenamerMessageId-~System-Guid'></a>
### op_Implicit(id) `method`

##### Summary

s
Allows us to pass instances of this class to methods that accept a
[Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') as an input parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [MFR.Constants.FileRenamerMessageId)~System.Guid](#T-MFR-Constants-FileRenamerMessageId-~System-Guid 'MFR.Constants.FileRenamerMessageId)~System.Guid') | (Required.) Reference to an instance of
[FileRenamerMessageId](#T-MFR-Constants-FileRenamerMessageId 'MFR.Constants.FileRenamerMessageId') to be converted. |

<a name='T-MFR-Constants-FileRenamerMessages'></a>
## FileRenamerMessages `type`

##### Namespace

MFR.Constants

##### Summary

Contains the identifiers to be utilized in order to tag those messages
sent by the File Renamer object.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_CURRENT_OPERATION_CHANGED'></a>
### FRM_CURRENT_OPERATION_CHANGED `constants`

##### Summary

Unique identifier for a message that indicates that the operation that is
currently being executed by the application has changed.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_EXCEPTION_RAISED'></a>
### FRM_EXCEPTION_RAISED `constants`

##### Summary

Unique identifier for a message that indicates an exception has been
raised by the File Renamer component.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_FILES_TO_BE_RENAMED_COUNTED'></a>
### FRM_FILES_TO_BE_RENAMED_COUNTED `constants`

##### Summary

Unique identifier for a message that indicates that the number of
files that are to be renamed has been counted.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED'></a>
### FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED `constants`

##### Summary

Unique identifier for a message that indicates that the number of
files to have text within them replaced has been counted.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_FILE_RENAMED'></a>
### FRM_FILE_RENAMED `constants`

##### Summary

Unique identifier for a message that indicates that a file has been renamed.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_FILE_SYSTEM_ENTRY_SKIPPED'></a>
### FRM_FILE_SYSTEM_ENTRY_SKIPPED `constants`

##### Summary

Unique identifier for a message that indicates a file system entry
(file or folder) has been skipped by the current operation.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_FINISHED'></a>
### FRM_FINISHED `constants`

##### Summary

Unique identifier for a message that indicates that the File Renamer
component has completed all of the requested operations.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_FOLDER_RENAMED'></a>
### FRM_FOLDER_RENAMED `constants`

##### Summary

Unique identifier for a message that indicates that a folder has been renamed.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_OPERATION_FINISHED'></a>
### FRM_OPERATION_FINISHED `constants`

##### Summary

Unique identifier for a message that indicates that a particular
File Renamer component operation has been completed.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_OPERATION_STARTED'></a>
### FRM_OPERATION_STARTED `constants`

##### Summary

Unique identifier for a message that indicates that a particular
File Renamer component operation has been started.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_PROCESSING_OPERATION'></a>
### FRM_PROCESSING_OPERATION `constants`

##### Summary

Unique identifier for a message that indicates that the current
operation is being processed.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_ROOT_DIRECTORY_PATH_CHANGED'></a>
### FRM_ROOT_DIRECTORY_PATH_CHANGED `constants`

##### Summary

Unique identifier for a message that indicates that the root directory, i.e.,
the starting directory, of the File Renamer component has been altered.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_SOLUTION_CLOSE_FAILED'></a>
### FRM_SOLUTION_CLOSE_FAILED `constants`

##### Summary

Unique identifier for a message that indicates that aa attempt to close a
Visual Studio Solution (`*.sln`) file loaded into a running instance of
Visual Studio has failed.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED'></a>
### FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED `constants`

##### Summary

Unique identifier for a message that indicates that the File Renamer
component has determined the number of subfolders that need to be
operated on.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_SOLUTION_FOLDER_RENAMED'></a>
### FRM_SOLUTION_FOLDER_RENAMED `constants`

##### Summary

Unique identifier for a message that indicates that a folder has been renamed.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_SOLUTION_OPEN_FAILED'></a>
### FRM_SOLUTION_OPEN_FAILED `constants`

##### Summary

Unique identifier for a message that indicates that aa attempt to close a
Visual Studio Solution (`*.sln`) file loaded into a running instance of
Visual Studio has failed.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_STARTED'></a>
### FRM_STARTED `constants`

##### Summary

Unique identifier for a message that indicates that the set of all
requested File Renamer operations has started.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_STARTING'></a>
### FRM_STARTING `constants`

##### Summary

Unique identifier for a message that indicates that the set of all
requested File Renamer operations are about to begin.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_STATUS_UPDATE'></a>
### FRM_STATUS_UPDATE `constants`

##### Summary

Unique identifier for a message that indicates that the File Renamer
component has a status update available that should be displayed to
the user.

<a name='F-MFR-Constants-FileRenamerMessages-FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED'></a>
### FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED `constants`

##### Summary

Unique identifier for a message that indicates that the File Renamer
component has determined the number of subfolders that need to be
operated on.

<a name='T-MFR-Constants-ProfileFile'></a>
## ProfileFile `type`

##### Namespace

MFR.Constants

##### Summary

String constants for the default names of files and folders relating to the
user's saved configuration profiles.

<a name='F-MFR-Constants-ProfileFile-DefaultFilename'></a>
### DefaultFilename `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the default filename to be used
for the file containing the saved collection of the user's previously-saved
configuration setting profiles, `profiles.json`.

<a name='T-MFR-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-MFR-Constants-Properties-Resources-StatusUpdate_AttemptingToRenameSolutionFolders'></a>
### StatusUpdate_AttemptingToRenameSolutionFolders `property`

##### Summary

Looks up a localized string similar to Attempting to rename the folder(s) in the '{0}' folder that contain Visual Studio Solution (*.sln) file(s) to match the name(s) of those Solution(s)... .
