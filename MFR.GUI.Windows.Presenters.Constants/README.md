<a name='assembly'></a>
# MFR.GUI.Windows.Presenters.Constants

## Contents

- [MainWindowPresenterMessageId](#T-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessageId 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessageId')
  - [op_Implicit(id)](#M-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessageId-op_Implicit-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessageId-~System-Guid 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessageId.op_Implicit(MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessageId)~System.Guid')
- [MainWindowPresenterMessages](#T-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages')
  - [MWP_ADD_NEW_PROFILE_FAILED](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_ADD_NEW_PROFILE_FAILED 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_ADD_NEW_PROFILE_FAILED')
  - [MWP_ALL_HISTORY_CLEARED](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_ALL_HISTORY_CLEARED 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_ALL_HISTORY_CLEARED')
  - [MWP_CONFIGURATION_EXPORTED](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_CONFIGURATION_EXPORTED 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_CONFIGURATION_EXPORTED')
  - [MWP_CONFIGURATION_IMPORTED](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_CONFIGURATION_IMPORTED 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_CONFIGURATION_IMPORTED')
  - [MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED')
  - [MWP_DATA_OPERATION_ERROR](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_DATA_OPERATION_ERROR 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_DATA_OPERATION_ERROR')
  - [MWP_DATA_OPERATION_FINISHED](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_DATA_OPERATION_FINISHED 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_DATA_OPERATION_FINISHED')
  - [MWP_DATA_OPERATION_STARTED](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_DATA_OPERATION_STARTED 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_DATA_OPERATION_STARTED')
  - [MWP_FINISHED](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_FINISHED 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_FINISHED')
  - [MWP_OPERATION_FINISHED](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_OPERATION_FINISHED 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_OPERATION_FINISHED')
  - [MWP_STARTED](#F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_STARTED 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessages.MWP_STARTED')
- [Resources](#T-MFR-GUI-Windows-Presenters-Constants-Properties-Resources 'MFR.GUI.Windows.Presenters.Constants.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Presenters-Constants-Properties-Resources-Culture 'MFR.GUI.Windows.Presenters.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Windows-Presenters-Constants-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Presenters.Constants.Properties.Resources.ResourceManager')
- [SpecialWindowsFolders](#T-MFR-GUI-Windows-Presenters-Constants-SpecialWindowsFolders 'MFR.GUI.Windows.Presenters.Constants.SpecialWindowsFolders')
  - [QuickAccess](#F-MFR-GUI-Windows-Presenters-Constants-SpecialWindowsFolders-QuickAccess 'MFR.GUI.Windows.Presenters.Constants.SpecialWindowsFolders.QuickAccess')

<a name='T-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessageId'></a>
## MainWindowPresenterMessageId `type`

##### Namespace

MFR.GUI.Windows.Presenters.Constants

##### Summary

Encapsulates a unique identifier for a message, as well as its name.

<a name='M-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessageId-op_Implicit-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessageId-~System-Guid'></a>
### op_Implicit(id) `method`

##### Summary

s
Allows us to pass instances of this class to methods that accept a
[Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') as an input parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessageId)~System.Guid](#T-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessageId-~System-Guid 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessageId)~System.Guid') | (Required.) Reference to an instance of
[MainWindowPresenterMessageId](#T-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessageId 'MFR.GUI.Windows.Presenters.Constants.MainWindowPresenterMessageId')
to be converted. |

<a name='T-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages'></a>
## MainWindowPresenterMessages `type`

##### Namespace

MFR.GUI.Windows.Presenters.Constants

##### Summary

Unique identifiers for the messages that are sent by the Presenter of
the main application window.

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_ADD_NEW_PROFILE_FAILED'></a>
### MWP_ADD_NEW_PROFILE_FAILED `constants`

##### Summary

Unique identifier for the message that is sent by the Presenter when the
operation of creating a new Profile has failed.

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_ALL_HISTORY_CLEARED'></a>
### MWP_ALL_HISTORY_CLEARED `constants`

##### Summary

Unique identifier for the message that is sent by the Presenter for
the main application window when the history has just been cleared.

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_CONFIGURATION_EXPORTED'></a>
### MWP_CONFIGURATION_EXPORTED `constants`

##### Summary

Unique identifier for the message that is sent by the Presenter of
the main application window when the configuration has just been
exported to a file.

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_CONFIGURATION_IMPORTED'></a>
### MWP_CONFIGURATION_IMPORTED `constants`

##### Summary

Unique identifier for the message that is sent by the Presenter of
the main application window when the configuration has just been
imported from a file.

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED'></a>
### MWP_CREATE_NEW_BLANK_PROFILE_REQUESTED `constants`

##### Summary

Unique identifier for the message that is sent by the Presenter for the main
application window when the user has clicked the Add New Profile button.

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_DATA_OPERATION_ERROR'></a>
### MWP_DATA_OPERATION_ERROR `constants`

##### Summary

Unique identifier for the message that is sent by the Presenter for
the main application window when a data operation error, such as
accessing a file (separate from the operations that the application
is designed to perform).

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_DATA_OPERATION_FINISHED'></a>
### MWP_DATA_OPERATION_FINISHED `constants`

##### Summary

Unique identifier for the message that is sent by the Presenter for
the main application window when a data operation, such as accessing
a file (separate from the operations that the application is
designed to perform), is completed.

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_DATA_OPERATION_STARTED'></a>
### MWP_DATA_OPERATION_STARTED `constants`

##### Summary

Unique identifier for the message that is sent by the Presenter for
the main application window when a data operation, such as accessing
a file (separate from the operations that the application is
designed to perform), is newly started.

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_FINISHED'></a>
### MWP_FINISHED `constants`

##### Summary

Unique identifier for the message that is sent by the Presenter of
the main application window when all of the file-rename operations
have finished.

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_OPERATION_FINISHED'></a>
### MWP_OPERATION_FINISHED `constants`

##### Summary

Unique identifier for the message that is sent by the Presenter of
the main application window when one of the file-rename operations
has just come to completion.

<a name='F-MFR-GUI-Windows-Presenters-Constants-MainWindowPresenterMessages-MWP_STARTED'></a>
### MWP_STARTED `constants`

##### Summary

Unique identifier for the message that is sent by the main
application window's Presenter when a file-rename operation is started.

<a name='T-MFR-GUI-Windows-Presenters-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Presenters.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Presenters-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Presenters-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-GUI-Windows-Presenters-Constants-SpecialWindowsFolders'></a>
## SpecialWindowsFolders `type`

##### Namespace

MFR.GUI.Windows.Presenters.Constants

##### Summary

Provides string constants that allow access to special folders.

<a name='F-MFR-GUI-Windows-Presenters-Constants-SpecialWindowsFolders-QuickAccess'></a>
### QuickAccess `constants`

##### Summary

Path to the area of Windows.
