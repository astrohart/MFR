<a name='assembly'></a>
# MFR.Engines.Constants

## Contents

- [OperationEngineMessageId](#T-MFR-Engines-Constants-OperationEngineMessageId 'MFR.Engines.Constants.OperationEngineMessageId')
  - [MessageId](#P-MFR-Engines-Constants-OperationEngineMessageId-MessageId 'MFR.Engines.Constants.OperationEngineMessageId.MessageId')
  - [Name](#P-MFR-Engines-Constants-OperationEngineMessageId-Name 'MFR.Engines.Constants.OperationEngineMessageId.Name')
  - [IsZero()](#M-MFR-Engines-Constants-OperationEngineMessageId-IsZero 'MFR.Engines.Constants.OperationEngineMessageId.IsZero')
  - [ToString()](#M-MFR-Engines-Constants-OperationEngineMessageId-ToString 'MFR.Engines.Constants.OperationEngineMessageId.ToString')
  - [op_Implicit(id)](#M-MFR-Engines-Constants-OperationEngineMessageId-op_Implicit-MFR-Engines-Constants-OperationEngineMessageId-~System-Guid 'MFR.Engines.Constants.OperationEngineMessageId.op_Implicit(MFR.Engines.Constants.OperationEngineMessageId)~System.Guid')
- [OperationEngineMessages](#T-MFR-Engines-Constants-OperationEngineMessages 'MFR.Engines.Constants.OperationEngineMessages')
  - [OE_OPERATION_ERROR](#F-MFR-Engines-Constants-OperationEngineMessages-OE_OPERATION_ERROR 'MFR.Engines.Constants.OperationEngineMessages.OE_OPERATION_ERROR')
  - [OE_PROCESSING_FINISHED](#F-MFR-Engines-Constants-OperationEngineMessages-OE_PROCESSING_FINISHED 'MFR.Engines.Constants.OperationEngineMessages.OE_PROCESSING_FINISHED')
  - [OE_PROCESSING_STARTED](#F-MFR-Engines-Constants-OperationEngineMessages-OE_PROCESSING_STARTED 'MFR.Engines.Constants.OperationEngineMessages.OE_PROCESSING_STARTED')
  - [OE_ROOT_DIRECTORY_PATH_UPDATED](#F-MFR-Engines-Constants-OperationEngineMessages-OE_ROOT_DIRECTORY_PATH_UPDATED 'MFR.Engines.Constants.OperationEngineMessages.OE_ROOT_DIRECTORY_PATH_UPDATED')
- [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType')
  - [Console](#F-MFR-Engines-Constants-OperationEngineType-Console 'MFR.Engines.Constants.OperationEngineType.Console')
  - [FullGUI](#F-MFR-Engines-Constants-OperationEngineType-FullGUI 'MFR.Engines.Constants.OperationEngineType.FullGUI')
  - [Unknown](#F-MFR-Engines-Constants-OperationEngineType-Unknown 'MFR.Engines.Constants.OperationEngineType.Unknown')
- [Resources](#T-MFR-Engines-Constants-Properties-Resources 'MFR.Engines.Constants.Properties.Resources')
  - [Culture](#P-MFR-Engines-Constants-Properties-Resources-Culture 'MFR.Engines.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Constants-Properties-Resources-ResourceManager 'MFR.Engines.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Constants-OperationEngineMessageId'></a>
## OperationEngineMessageId `type`

##### Namespace

MFR.Engines.Constants

##### Summary

Encapsulates a unique identifier for a message, as well as its name.

<a name='P-MFR-Engines-Constants-OperationEngineMessageId-MessageId'></a>
### MessageId `property`

##### Summary

Gets or sets a [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') value that uniquely identifies the
message.

<a name='P-MFR-Engines-Constants-OperationEngineMessageId-Name'></a>
### Name `property`

##### Summary

Gets or sets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that names this message
identifier.

<a name='M-MFR-Engines-Constants-OperationEngineMessageId-IsZero'></a>
### IsZero() `method`

##### Summary

Determines whether the value of the
[MessageId](#P-MFR-Engines-Constants-OperationEngineMessageId-MessageId 'MFR.Engines.Constants.OperationEngineMessageId.MessageId') property is set
to the Zero GUID.

##### Returns

`true` if the value of the
[MessageId](#P-MFR-Engines-Constants-OperationEngineMessageId-MessageId 'MFR.Engines.Constants.OperationEngineMessageId.MessageId') property is set
to the Zero GUID; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Constants-OperationEngineMessageId-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='M-MFR-Engines-Constants-OperationEngineMessageId-op_Implicit-MFR-Engines-Constants-OperationEngineMessageId-~System-Guid'></a>
### op_Implicit(id) `method`

##### Summary

s
Allows us to pass instances of this class to methods that accept a
[Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') as an input parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [MFR.Engines.Constants.OperationEngineMessageId)~System.Guid](#T-MFR-Engines-Constants-OperationEngineMessageId-~System-Guid 'MFR.Engines.Constants.OperationEngineMessageId)~System.Guid') | (Required.) Reference to an instance of
[OperationEngineMessageId](#T-MFR-Engines-Constants-OperationEngineMessageId 'MFR.Engines.Constants.OperationEngineMessageId') to be converted. |

<a name='T-MFR-Engines-Constants-OperationEngineMessages'></a>
## OperationEngineMessages `type`

##### Namespace

MFR.Engines.Constants

<a name='F-MFR-Engines-Constants-OperationEngineMessages-OE_OPERATION_ERROR'></a>
### OE_OPERATION_ERROR `constants`

##### Summary

Unique identifier for the message that is sent by the Operation Engine when one
of the file-renaming operations throws an exception.

<a name='F-MFR-Engines-Constants-OperationEngineMessages-OE_PROCESSING_FINISHED'></a>
### OE_PROCESSING_FINISHED `constants`

##### Summary

Unique identifier for the message that is sent by the Operation Engine when all
of the requested file-renaming operations have been completed.

<a name='F-MFR-Engines-Constants-OperationEngineMessages-OE_PROCESSING_STARTED'></a>
### OE_PROCESSING_STARTED `constants`

##### Summary

Unique identifier for the message that is sent by the Operation Engine when a
new [FileRenamer](#T-MFR-Renamers-Files-FileRenamer 'MFR.Renamers.Files.FileRenamer') job is started.

<a name='F-MFR-Engines-Constants-OperationEngineMessages-OE_ROOT_DIRECTORY_PATH_UPDATED'></a>
### OE_ROOT_DIRECTORY_PATH_UPDATED `constants`

##### Summary

Unique identifier for the message that is sent by the Operation Engine when the
root directory, i.e., the starting directory, path is changed.

<a name='T-MFR-Engines-Constants-OperationEngineType'></a>
## OperationEngineType `type`

##### Namespace

MFR.Engines.Constants

##### Summary

Values that describe the type of operation engine -- e.g., full GUI, automated GUI (called from command line) or console app, which which we are working.

<a name='F-MFR-Engines-Constants-OperationEngineType-Console'></a>
### Console `constants`

##### Summary

Application is run as a console program.

<a name='F-MFR-Engines-Constants-OperationEngineType-FullGUI'></a>
### FullGUI `constants`

##### Summary

The GUI was brought up by the user without any automated operations being requested.

<a name='F-MFR-Engines-Constants-OperationEngineType-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown operation engine type.

<a name='T-MFR-Engines-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
