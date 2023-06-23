<a name='assembly'></a>
# MFR.Constants

## Contents

- [ConfigFile](#T-MFR-Constants-ConfigFile 'MFR.Constants.ConfigFile')
  - [DefaultFilename](#F-MFR-Constants-ConfigFile-DefaultFilename 'MFR.Constants.ConfigFile.DefaultFilename')
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
