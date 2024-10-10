<a name='assembly'></a>
# MFR.GUI.Actions

## Contents

- [Get](#T-MFR-GUI-Actions-Get 'MFR.GUI.Actions.Get')
  - [LOG_FILE_PATH_TERMINATOR](#F-MFR-GUI-Actions-Get-LOG_FILE_PATH_TERMINATOR 'MFR.GUI.Actions.Get.LOG_FILE_PATH_TERMINATOR')
  - [AssemblyCompany](#P-MFR-GUI-Actions-Get-AssemblyCompany 'MFR.GUI.Actions.Get.AssemblyCompany')
  - [AssemblyProduct](#P-MFR-GUI-Actions-Get-AssemblyProduct 'MFR.GUI.Actions.Get.AssemblyProduct')
  - [AssemblyTitle](#P-MFR-GUI-Actions-Get-AssemblyTitle 'MFR.GUI.Actions.Get.AssemblyTitle')
  - [#cctor()](#M-MFR-GUI-Actions-Get-#cctor 'MFR.GUI.Actions.Get.#cctor')
  - [ApplicationProductName()](#M-MFR-GUI-Actions-Get-ApplicationProductName 'MFR.GUI.Actions.Get.ApplicationProductName')
  - [CommandLineProcessorType(commandLineSpecified,autoStart)](#M-MFR-GUI-Actions-Get-CommandLineProcessorType-System-Boolean,System-Boolean- 'MFR.GUI.Actions.Get.CommandLineProcessorType(System.Boolean,System.Boolean)')
  - [LogFilePath()](#M-MFR-GUI-Actions-Get-LogFilePath 'MFR.GUI.Actions.Get.LogFilePath')
- [Resources](#T-MFR-GUI-Actions-Properties-Resources 'MFR.GUI.Actions.Properties.Resources')
  - [Culture](#P-MFR-GUI-Actions-Properties-Resources-Culture 'MFR.GUI.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Actions-Properties-Resources-ResourceManager 'MFR.GUI.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Actions-Get'></a>
## Get `type`

##### Namespace

MFR.GUI.Actions

##### Summary

Exposes static methods to obtain information from sources of data.

<a name='F-MFR-GUI-Actions-Get-LOG_FILE_PATH_TERMINATOR'></a>
### LOG_FILE_PATH_TERMINATOR `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the final piece of the path of the
log file.

<a name='P-MFR-GUI-Actions-Get-AssemblyCompany'></a>
### AssemblyCompany `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyCompany](#P-AssemblyMetadata-AssemblyCompany 'AssemblyMetadata.AssemblyCompany') property.

<a name='P-MFR-GUI-Actions-Get-AssemblyProduct'></a>
### AssemblyProduct `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the product name defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyProduct](#P-AssemblyMetadata-AssemblyProduct 'AssemblyMetadata.AssemblyProduct') property.

<a name='P-MFR-GUI-Actions-Get-AssemblyTitle'></a>
### AssemblyTitle `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the assembly title defined
for this application.

##### Remarks

This property is really an alias for the
[AssemblyTitle](#P-AssemblyMetadata-AssemblyTitle 'AssemblyMetadata.AssemblyTitle') property.

<a name='M-MFR-GUI-Actions-Get-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [Get](#T-MFR-GUI-Actions-Get 'MFR.GUI.Actions.Get') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='M-MFR-GUI-Actions-Get-ApplicationProductName'></a>
### ApplicationProductName() `method`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name for
the software product of which this application or class library is a part.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a user-friendly name
for the software product of which this application or class library is a part.

##### Parameters

This method has no parameters.

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

<a name='M-MFR-GUI-Actions-Get-LogFilePath'></a>
### LogFilePath() `method`

##### Summary

Obtains a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of the file that should be used for logging messages.

##### Parameters

This method has no parameters.

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
