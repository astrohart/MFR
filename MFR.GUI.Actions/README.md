<a name='assembly'></a>
# MFR.GUI.Actions

## Contents

- [Get](#T-MFR-GUI-Actions-Get 'MFR.GUI.Actions.Get')
  - [CommandLineProcessorType(commandLineSpecified,autoStart)](#M-MFR-GUI-Actions-Get-CommandLineProcessorType-System-Boolean,System-Boolean- 'MFR.GUI.Actions.Get.CommandLineProcessorType(System.Boolean,System.Boolean)')
- [Resources](#T-MFR-GUI-Actions-Properties-Resources 'MFR.GUI.Actions.Properties.Resources')
  - [Culture](#P-MFR-GUI-Actions-Properties-Resources-Culture 'MFR.GUI.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Actions-Properties-Resources-ResourceManager 'MFR.GUI.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Actions-Get'></a>
## Get `type`

##### Namespace

MFR.GUI.Actions

##### Summary

Exposes static methods to obtain information from sources of data.

<a name='M-MFR-GUI-Actions-Get-CommandLineProcessorType-System-Boolean,System-Boolean-'></a>
### CommandLineProcessorType(commandLineSpecified,autoStart) `method`

##### Summary

Obtains the proper
[CommandLineProcessorType](#T-MFR-GUI-Processors-Constants-CommandLineProcessorType 'MFR.GUI.Processors.Constants.CommandLineProcessorType')
enumeration value that corresponds to the way that the application was
launched.

##### Returns

One of the
[CommandLineProcessorType](#T-MFR-GUI-Processors-Constants-CommandLineProcessorType 'MFR.GUI.Processors.Constants.CommandLineProcessorType')
enumeration values that specifies how the application is to behave, given how
it was launched.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandLineSpecified | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) `true` if more than zero command-line arguments
are specified when the application is launched; `false`
otherwise. |
| autoStart | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) `true` if the user specifies the
`--autoStart` flag on the command line. |

<a name='T-MFR-GUI-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
