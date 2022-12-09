<a name='assembly'></a>
# MFR.Engines.Interfaces

## Contents

- [IOperationEngine](#T-MFR-Engines-Interfaces-IOperationEngine 'MFR.Engines.Interfaces.IOperationEngine')
  - [Type](#P-MFR-Engines-Interfaces-IOperationEngine-Type 'MFR.Engines.Interfaces.IOperationEngine.Type')
- [Resources](#T-MFR-Engines-Interfaces-Properties-Resources 'MFR.Engines.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Engines-Interfaces-Properties-Resources-Culture 'MFR.Engines.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Interfaces-Properties-Resources-ResourceManager 'MFR.Engines.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Interfaces-IOperationEngine'></a>
## IOperationEngine `type`

##### Namespace

MFR.Engines.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that runs the
File Renamer in a sandbox that provides either GUI or console services, say,
for example.

##### Remarks

This is meant to be kind of an "adapter pattern" on the File Renamer
component so that it can be more easily used in a wide variety of modes (GUI,
console, automatic GUI meaning, MFR GUI is called on the command line so we
don't have to display the main window, etc.).

<a name='P-MFR-Engines-Interfaces-IOperationEngine-Type'></a>
### Type `property`

##### Summary

Gets a [OperationEngineType](#T-MFR-Engines-Constants-OperationEngineType 'MFR.Engines.Constants.OperationEngineType') enumeration
value that describes what type of operation engine this is.

<a name='T-MFR-Engines-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
