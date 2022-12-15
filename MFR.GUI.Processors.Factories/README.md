<a name='assembly'></a>
# MFR.GUI.Processors.Factories

## Contents

- [GetCommandLineProcessor](#T-MFR-GUI-Processors-Factories-GetCommandLineProcessor 'MFR.GUI.Processors.Factories.GetCommandLineProcessor')
  - [OfType(type)](#M-MFR-GUI-Processors-Factories-GetCommandLineProcessor-OfType-MFR-GUI-Processors-Constants-CommandLineProcessorType- 'MFR.GUI.Processors.Factories.GetCommandLineProcessor.OfType(MFR.GUI.Processors.Constants.CommandLineProcessorType)')
- [Resources](#T-MFR-GUI-Processors-Factories-Properties-Resources 'MFR.GUI.Processors.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Processors-Factories-Properties-Resources-Culture 'MFR.GUI.Processors.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Processors-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Processors.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Processors-Factories-GetCommandLineProcessor'></a>
## GetCommandLineProcessor `type`

##### Namespace

MFR.GUI.Processors.Factories

##### Summary

Creates instances of objects that implement the
[ICommandLineProcessor](#T-MFR-GUI-Processors-Factories-ICommandLineProcessor 'MFR.GUI.Processors.Factories.ICommandLineProcessor') interface.

<a name='M-MFR-GUI-Processors-Factories-GetCommandLineProcessor-OfType-MFR-GUI-Processors-Constants-CommandLineProcessorType-'></a>
### OfType(type) `method`

##### Summary

Creates an instance of an object implementing the
[ICommandLineProcessor](#T-MFR-GUI-Processors-Factories-ICommandLineProcessor 'MFR.GUI.Processors.Factories.ICommandLineProcessor') interface
which corresponds to the value specified in `type`, and
returns a reference to it.

##### Returns

A reference to the instance of the object that implements the
[ICommandLineProcessor](#T-MFR-GUI-Processors-Factories-ICommandLineProcessor 'MFR.GUI.Processors.Factories.ICommandLineProcessor') interface
which corresponds to the value specified in `type`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.GUI.Processors.Constants.CommandLineProcessorType](#T-MFR-GUI-Processors-Constants-CommandLineProcessorType 'MFR.GUI.Processors.Constants.CommandLineProcessorType') | One of the
[CommandLineProcessorType](#T-MFR-GUI-Processors-Factories-CommandLineProcessorType 'MFR.GUI.Processors.Factories.CommandLineProcessorType') values
that describes what type of object you want. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if there is no
corresponding concrete type defined that implements the
[ICommandLineProcessor](#T-MFR-GUI-Processors-Factories-ICommandLineProcessor 'MFR.GUI.Processors.Factories.ICommandLineProcessor') interface
and which corresponds to the value passed in the `type`
parameter. |

##### Remarks

This method will throw an exception if there are no types implemented
that correspond to the value of `type`.

<a name='T-MFR-GUI-Processors-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Processors.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Processors-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Processors-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
