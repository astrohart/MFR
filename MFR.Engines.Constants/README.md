<a name='assembly'></a>
# MFR.Engines.Constants

## Contents

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
