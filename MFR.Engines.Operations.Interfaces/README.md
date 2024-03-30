<a name='assembly'></a>
# MFR.Engines.Operations.Interfaces

## Contents

- [IFullGuiOperationEngine](#T-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine')
  - [DialogOwner](#P-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-DialogOwner 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine.DialogOwner')
  - [CloseProgressDialog()](#M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-CloseProgressDialog 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine.CloseProgressDialog')
  - [SetDialogOwner(owner)](#M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-SetDialogOwner-System-Windows-Forms-IWin32Window- 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine.SetDialogOwner(System.Windows.Forms.IWin32Window)')
  - [ShowCalculatingProgressBar(text,canCancel)](#M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-ShowCalculatingProgressBar-System-String,System-Boolean- 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine.ShowCalculatingProgressBar(System.String,System.Boolean)')
  - [ShowProgressDialog(canCancel)](#M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-ShowProgressDialog-System-Boolean- 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine.ShowProgressDialog(System.Boolean)')
  - [ShowProgressDialog(owner)](#M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window- 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine.ShowProgressDialog(System.Windows.Forms.IWin32Window)')
  - [ShowProgressDialog(owner,canCancel)](#M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window,System-Boolean- 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine.ShowProgressDialog(System.Windows.Forms.IWin32Window,System.Boolean)')
  - [ShowProgressDialog()](#M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-ShowProgressDialog 'MFR.Engines.Operations.Interfaces.IFullGuiOperationEngine.ShowProgressDialog')
- [IOperationEngine](#T-MFR-Engines-Operations-Interfaces-IOperationEngine 'MFR.Engines.Operations.Interfaces.IOperationEngine')
  - [Type](#P-MFR-Engines-Operations-Interfaces-IOperationEngine-Type 'MFR.Engines.Operations.Interfaces.IOperationEngine.Type')
  - [ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter)](#M-MFR-Engines-Operations-Interfaces-IOperationEngine-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}- 'MFR.Engines.Operations.Interfaces.IOperationEngine.ProcessAll(System.String,System.String,System.String,System.Predicate{System.String})')
- [Resources](#T-MFR-Engines-Operations-Interfaces-Properties-Resources 'MFR.Engines.Operations.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Engines-Operations-Interfaces-Properties-Resources-Culture 'MFR.Engines.Operations.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Operations-Interfaces-Properties-Resources-ResourceManager 'MFR.Engines.Operations.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine'></a>
## IFullGuiOperationEngine `type`

##### Namespace

MFR.Engines.Operations.Interfaces

<a name='P-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-DialogOwner'></a>
### DialogOwner `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface that represents
the parent window of the progress dialog.

<a name='M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-CloseProgressDialog'></a>
### CloseProgressDialog() `method`

##### Summary

Dismisses the progress dialog.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-SetDialogOwner-System-Windows-Forms-IWin32Window-'></a>
### SetDialogOwner(owner) `method`

##### Summary

Sets the owner window of all dialog boxes displayed by this component.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface that represents
the new owner window. |

##### Remarks

Typically, this method would be called by passing a reference to the
main window of the application.

<a name='M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-ShowCalculatingProgressBar-System-String,System-Boolean-'></a>
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

<a name='M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-ShowProgressDialog-System-Boolean-'></a>
### ShowProgressDialog(canCancel) `method`

##### Summary

Shows the progress window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| canCancel | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that controls whether the
button is displayed by the dialog box.



Set this parameter to `true` to display the button;
`false` to hide it. |

<a name='M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window-'></a>
### ShowProgressDialog(owner) `method`

##### Summary

Shows the progress window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



This object plays the role of the parent window of the dialog box. |

<a name='M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-ShowProgressDialog-System-Windows-Forms-IWin32Window,System-Boolean-'></a>
### ShowProgressDialog(owner,canCancel) `method`

##### Summary

Shows the progress window.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| owner | [System.Windows.Forms.IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') | (Required.) Reference to an instance of an object that implements the
[IWin32Window](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Forms.IWin32Window 'System.Windows.Forms.IWin32Window') interface.



This object plays the role of the parent window of the dialog box. |
| canCancel | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) A [Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') that controls whether the
button is displayed by the dialog box.



Set this parameter to `true` to display the button;
`false` to hide it. |

<a name='M-MFR-Engines-Operations-Interfaces-IFullGuiOperationEngine-ShowProgressDialog'></a>
### ShowProgressDialog() `method`

##### Summary

Shows the progress window.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Operations-Interfaces-IOperationEngine'></a>
## IOperationEngine `type`

##### Namespace

MFR.Engines.Operations.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that runs the
File Renamer in a sandbox that provides either GUI or console services, say,
for example.

##### Remarks

This meant to be kind of an "adapter pattern" on the File Renamer
component so that it can be more easily used in a wide variety of modes (GUI,
console, automatic GUI meaning, MFR GUI is called on the command line so we
don't have to display the main window, etc.).

<a name='P-MFR-Engines-Operations-Interfaces-IOperationEngine-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this.

<a name='M-MFR-Engines-Operations-Interfaces-IOperationEngine-ProcessAll-System-String,System-String,System-String,System-Predicate{System-String}-'></a>
### ProcessAll(rootDirectoryPath,findWhat,replaceWith,pathFilter) `method`

##### Summary

Executes the Rename Subfolders, Rename Files, and Replace Text in
Files operation on all the folders and files in the root folder with
the pathname specified by the `rootDirectoryPath` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Path to the recursion root. |
| findWhat | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to search for. |
| replaceWith | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text to replace the text specified
by `findWhat` with. |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | (Optional.) Reference to an instance of [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func')
that points to a delegate, accepting the current file or folder's
path as an argument, that returns `true` if the file
should be included in the operation or `false` otherwise.



This parameter is `null` by default. This method
should return `true` to specify that a given
file-system entry is to be included in the output collection --
barring other inclusion/exclusion criteria.



In the event that this parameter is `null`, no path
filtering is done. |

<a name='T-MFR-Engines-Operations-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Operations.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Operations-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Operations-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
