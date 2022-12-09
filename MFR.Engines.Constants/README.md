<a name='assembly'></a>
# MFR.Engines.Constants

## Contents

- [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType')
  - [AutomatedGUI](#F-MFR-Engines-Constants-OperationEngineType-AutomatedGUI 'MFR.Engines.Constants.OperationEngineType.AutomatedGUI')
  - [Console](#F-MFR-Engines-Constants-OperationEngineType-Console 'MFR.Engines.Constants.OperationEngineType.Console')
  - [FullGUI](#F-MFR-Engines-Constants-OperationEngineType-FullGUI 'MFR.Engines.Constants.OperationEngineType.FullGUI')
  - [Unknown](#F-MFR-Engines-Constants-OperationEngineType-Unknown 'MFR.Engines.Constants.OperationEngineType.Unknown')
- [Resources](#T-MFR-Engines-Constants-Properties-Resources 'MFR.Engines.Constants.Properties.Resources')
  - [Culture](#P-MFR-Engines-Constants-Properties-Resources-Culture 'MFR.Engines.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Constants-Properties-Resources-ResourceManager 'MFR.Engines.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Constants-OperationEngineType'></a>
## OperationEngineType `type`

##### Namespace

MFR.Engines.Constants

##### Summary

Values that describe the type of operation engine -- e.g., full GUI, automated GUI (called from command line) or console app, which which we are working.

<a name='F-MFR-Engines-Constants-OperationEngineType-AutomatedGUI'></a>
### AutomatedGUI `constants`

##### Summary

The GUI was brought up by the user, with the `--autoStart` flag passed on the command line.

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
