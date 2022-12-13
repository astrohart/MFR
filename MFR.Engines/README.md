<a name='assembly'></a>
# MFR.Engines

## Contents

- [AutomatedGuiOperationEngine](#T-MFR-Engines-AutomatedGuiOperationEngine 'MFR.Engines.AutomatedGuiOperationEngine')
  - [#ctor()](#M-MFR-Engines-AutomatedGuiOperationEngine-#ctor 'MFR.Engines.AutomatedGuiOperationEngine.#ctor')
  - [Instance](#P-MFR-Engines-AutomatedGuiOperationEngine-Instance 'MFR.Engines.AutomatedGuiOperationEngine.Instance')
  - [Type](#P-MFR-Engines-AutomatedGuiOperationEngine-Type 'MFR.Engines.AutomatedGuiOperationEngine.Type')
  - [#cctor()](#M-MFR-Engines-AutomatedGuiOperationEngine-#cctor 'MFR.Engines.AutomatedGuiOperationEngine.#cctor')
- [ConsoleOperationEngine](#T-MFR-Engines-ConsoleOperationEngine 'MFR.Engines.ConsoleOperationEngine')
  - [#ctor()](#M-MFR-Engines-ConsoleOperationEngine-#ctor 'MFR.Engines.ConsoleOperationEngine.#ctor')
  - [Instance](#P-MFR-Engines-ConsoleOperationEngine-Instance 'MFR.Engines.ConsoleOperationEngine.Instance')
  - [Type](#P-MFR-Engines-ConsoleOperationEngine-Type 'MFR.Engines.ConsoleOperationEngine.Type')
  - [#cctor()](#M-MFR-Engines-ConsoleOperationEngine-#cctor 'MFR.Engines.ConsoleOperationEngine.#cctor')
- [FullGuiOperationEngine](#T-MFR-Engines-FullGuiOperationEngine 'MFR.Engines.FullGuiOperationEngine')
  - [#ctor()](#M-MFR-Engines-FullGuiOperationEngine-#ctor 'MFR.Engines.FullGuiOperationEngine.#ctor')
  - [_cancellableProgressDialog](#F-MFR-Engines-FullGuiOperationEngine-_cancellableProgressDialog 'MFR.Engines.FullGuiOperationEngine._cancellableProgressDialog')
  - [Instance](#P-MFR-Engines-FullGuiOperationEngine-Instance 'MFR.Engines.FullGuiOperationEngine.Instance')
  - [Type](#P-MFR-Engines-FullGuiOperationEngine-Type 'MFR.Engines.FullGuiOperationEngine.Type')
  - [#cctor()](#M-MFR-Engines-FullGuiOperationEngine-#cctor 'MFR.Engines.FullGuiOperationEngine.#cctor')
  - [CloseProgressDialog()](#M-MFR-Engines-FullGuiOperationEngine-CloseProgressDialog 'MFR.Engines.FullGuiOperationEngine.CloseProgressDialog')
  - [OnCancellableProgressDialogRequestedCancel(sender,e)](#M-MFR-Engines-FullGuiOperationEngine-OnCancellableProgressDialogRequestedCancel-System-Object,System-EventArgs- 'MFR.Engines.FullGuiOperationEngine.OnCancellableProgressDialogRequestedCancel(System.Object,System.EventArgs)')
  - [ReinitializeProgressDialog()](#M-MFR-Engines-FullGuiOperationEngine-ReinitializeProgressDialog 'MFR.Engines.FullGuiOperationEngine.ReinitializeProgressDialog')
  - [ResetProgressBar()](#M-MFR-Engines-FullGuiOperationEngine-ResetProgressBar 'MFR.Engines.FullGuiOperationEngine.ResetProgressBar')
  - [ShowCalculatingProgressBar(text,canCancel)](#M-MFR-Engines-FullGuiOperationEngine-ShowCalculatingProgressBar-System-String,System-Boolean- 'MFR.Engines.FullGuiOperationEngine.ShowCalculatingProgressBar(System.String,System.Boolean)')
- [OperationEngine](#T-MFR-Engines-OperationEngine 'MFR.Engines.OperationEngine')
- [OperationEngineBase](#T-MFR-Engines-OperationEngineBase 'MFR.Engines.OperationEngineBase')
  - [FileRenamer](#P-MFR-Engines-OperationEngineBase-FileRenamer 'MFR.Engines.OperationEngineBase.FileRenamer')
  - [Type](#P-MFR-Engines-OperationEngineBase-Type 'MFR.Engines.OperationEngineBase.Type')
  - [OnEngineOperationFinished()](#M-MFR-Engines-OperationEngineBase-OnEngineOperationFinished 'MFR.Engines.OperationEngineBase.OnEngineOperationFinished')
- [Resources](#T-MFR-Engines-Properties-Resources 'MFR.Engines.Properties.Resources')
  - [Culture](#P-MFR-Engines-Properties-Resources-Culture 'MFR.Engines.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-Engines-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.Engines.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-Engines-Properties-Resources-ResourceManager 'MFR.Engines.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-AutomatedGuiOperationEngine'></a>
## AutomatedGuiOperationEngine `type`

##### Namespace

MFR.Engines

##### Summary

Coordinates the operation of the `File Renamer` component when the
application is invoked for automated execution from the command line (i.e., the
`--autoStart` command-line flag is applied).

<a name='M-MFR-Engines-AutomatedGuiOperationEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Engines-AutomatedGuiOperationEngine-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Interfaces.IFullGuiOperationEngine') interface.

<a name='P-MFR-Engines-AutomatedGuiOperationEngine-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this is.

##### Remarks

Child classes must implement this property.

<a name='M-MFR-Engines-AutomatedGuiOperationEngine-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-ConsoleOperationEngine'></a>
## ConsoleOperationEngine `type`

##### Namespace

MFR.Engines

##### Summary

Coordinates the operation of the `File Renamer` component when the
application is invoked as a console app.

<a name='M-MFR-Engines-ConsoleOperationEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Engines-ConsoleOperationEngine-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Interfaces.IFullGuiOperationEngine') interface.

<a name='P-MFR-Engines-ConsoleOperationEngine-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this is.

##### Remarks

Child classes must implement this property.

<a name='M-MFR-Engines-ConsoleOperationEngine-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-FullGuiOperationEngine'></a>
## FullGuiOperationEngine `type`

##### Namespace

MFR.Engines

##### Summary

Coordinates the operation of the `File Renamer` component inadmidst the
full graphical user interface of the application.

<a name='M-MFR-Engines-FullGuiOperationEngine-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Engines-FullGuiOperationEngine-_cancellableProgressDialog'></a>
### _cancellableProgressDialog `constants`

##### Summary

Reference to an instance of an object that implements the
[ICancellableProgressDialog](#T-MFR-GUI-Dialogs-Interfaces-ICancellableProgressDialog 'MFR.GUI.Dialogs.Interfaces.ICancellableProgressDialog')
interface.

<a name='P-MFR-Engines-FullGuiOperationEngine-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IFullGuiOperationEngine](#T-MFR-Engines-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Interfaces.IFullGuiOperationEngine') interface.

<a name='P-MFR-Engines-FullGuiOperationEngine-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this is.

##### Remarks

Child classes must implement this property.

<a name='M-MFR-Engines-FullGuiOperationEngine-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-CloseProgressDialog'></a>
### CloseProgressDialog() `method`

##### Summary

Dismisses the progress dialog.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-OnCancellableProgressDialogRequestedCancel-System-Object,System-EventArgs-'></a>
### OnCancellableProgressDialogRequestedCancel(sender,e) `method`

##### Summary

Handles the [](#E-MFR-GUI-ICancellableProgressDialog-CancelRequested 'MFR.GUI.ICancellableProgressDialog.CancelRequested')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method handles the situation in which the user has clicked the
Cancel button on the progress dialog. The message taken by this
method is to tell the File Renamer Object to attempt to abort.

<a name='M-MFR-Engines-FullGuiOperationEngine-ReinitializeProgressDialog'></a>
### ReinitializeProgressDialog() `method`

##### Summary

Sets the progress dialog and/or reinitializes it from prior use.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-ResetProgressBar'></a>
### ResetProgressBar() `method`

##### Summary

Resets the progress bar back to the beginning.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-FullGuiOperationEngine-ShowCalculatingProgressBar-System-String,System-Boolean-'></a>
### ShowCalculatingProgressBar(text,canCancel) `method`

##### Summary

Shows a marquee progress bar that indicates the application is
performing work but of an indeterminate length, such as calculating
the amount of files to process.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to display in the progress dialog. |
| canCancel | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) `true` to show a button in
the progress dialog; `false` to hide it. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `text`, is passed
a blank or `null` string for a value. |

<a name='T-MFR-Engines-OperationEngine'></a>
## OperationEngine `type`

##### Namespace

MFR.Engines

##### Summary

Wraps the file-renaming component in an object that adapts it for use at any
place in this software system.

##### Remarks

There is a part of me that feels like this class may be redundant.

<a name='T-MFR-Engines-OperationEngineBase'></a>
## OperationEngineBase `type`

##### Namespace

MFR.Engines

##### Summary

Defines the events, methods, properties, and behaviors for all operation
engines.

<a name='P-MFR-Engines-OperationEngineBase-FileRenamer'></a>
### FileRenamer `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileRenamer](#T-MFR-Renamers-Files-Interfaces-IFileRenamer 'MFR.Renamers.Files.Interfaces.IFileRenamer') interface.

##### Remarks

This object provides access to the file- and folder-processing functionality of
the application.



It is marked as `protected` in the source code, allowing access to
children of the [OperationEngineBase](#T-MFR-Engines-OperationEngineBase 'MFR.Engines.OperationEngineBase') class.

<a name='P-MFR-Engines-OperationEngineBase-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this is.

##### Remarks

Child classes must implement this property.

<a name='M-MFR-Engines-OperationEngineBase-OnEngineOperationFinished'></a>
### OnEngineOperationFinished() `method`

##### Summary

Raises the
[](#E-MFR-Engines-OperationEngineBase-EngineOperationFinished 'MFR.Engines.OperationEngineBase.EngineOperationFinished') event.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-Engines-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
