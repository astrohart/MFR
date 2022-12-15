<a name='assembly'></a>
# MFR.GUI.Processors.Interfaces

## Contents

- [ICommandLineProcessor](#T-MFR-GUI-Processors-Interfaces-ICommandLineProcessor 'MFR.GUI.Processors.Interfaces.ICommandLineProcessor')
  - [Type](#P-MFR-GUI-Processors-Interfaces-ICommandLineProcessor-Type 'MFR.GUI.Processors.Interfaces.ICommandLineProcessor.Type')
  - [Process()](#M-MFR-GUI-Processors-Interfaces-ICommandLineProcessor-Process 'MFR.GUI.Processors.Interfaces.ICommandLineProcessor.Process')
- [Resources](#T-MFR-GUI-Processors-Interfaces-Properties-Resources 'MFR.GUI.Processors.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-GUI-Processors-Interfaces-Properties-Resources-Culture 'MFR.GUI.Processors.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Processors-Interfaces-Properties-Resources-ResourceManager 'MFR.GUI.Processors.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Processors-Interfaces-ICommandLineProcessor'></a>
## ICommandLineProcessor `type`

##### Namespace

MFR.GUI.Processors.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a command-line processor object.

<a name='P-MFR-GUI-Processors-Interfaces-ICommandLineProcessor-Type'></a>
### Type `property`

##### Summary

Gets a [CommandLineProcessorType](#T-MFR-GUI-Processors-Constants-CommandLineProcessorType 'MFR.GUI.Processors.Constants.CommandLineProcessorType')
enumeration value that identifies the type of processing this processor does.

<a name='M-MFR-GUI-Processors-Interfaces-ICommandLineProcessor-Process'></a>
### Process() `method`

##### Summary

Executes the processing specified by this processor type.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Processors-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Processors.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Processors-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Processors-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
