<a name='assembly'></a>
# MFR.Settings.Configuration.Actions

## Contents

- [Is](#T-MFR-Settings-Configuration-Actions-Is 'MFR.Settings.Configuration.Actions.Is')
  - [ConfigurationBlankOrNull(config)](#M-MFR-Settings-Configuration-Actions-Is-ConfigurationBlankOrNull-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig- 'MFR.Settings.Configuration.Actions.Is.ConfigurationBlankOrNull(MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig)')
- [LoadConfigurationFilePathFromRegistryAction](#T-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction 'MFR.Settings.Configuration.Actions.LoadConfigurationFilePathFromRegistryAction')
  - [#ctor()](#M-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-#ctor 'MFR.Settings.Configuration.Actions.LoadConfigurationFilePathFromRegistryAction.#ctor')
  - [AccessTheRegueryExpressionValidator](#P-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-AccessTheRegueryExpressionValidator 'MFR.Settings.Configuration.Actions.LoadConfigurationFilePathFromRegistryAction.AccessTheRegueryExpressionValidator')
  - [Instance](#P-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-Instance 'MFR.Settings.Configuration.Actions.LoadConfigurationFilePathFromRegistryAction.Instance')
  - [MessageType](#P-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-MessageType 'MFR.Settings.Configuration.Actions.LoadConfigurationFilePathFromRegistryAction.MessageType')
  - [#cctor()](#M-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-#cctor 'MFR.Settings.Configuration.Actions.LoadConfigurationFilePathFromRegistryAction.#cctor')
  - [ExecuteOperationIfNotCached()](#M-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-ExecuteOperationIfNotCached 'MFR.Settings.Configuration.Actions.LoadConfigurationFilePathFromRegistryAction.ExecuteOperationIfNotCached')
- [LoadConfigurationFromFileAction](#T-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction 'MFR.Settings.Configuration.Actions.LoadConfigurationFromFileAction')
  - [#ctor()](#M-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction-#ctor 'MFR.Settings.Configuration.Actions.LoadConfigurationFromFileAction.#ctor')
  - [Instance](#P-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction-Instance 'MFR.Settings.Configuration.Actions.LoadConfigurationFromFileAction.Instance')
  - [MessageType](#P-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction-MessageType 'MFR.Settings.Configuration.Actions.LoadConfigurationFromFileAction.MessageType')
  - [#cctor()](#M-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction-#cctor 'MFR.Settings.Configuration.Actions.LoadConfigurationFromFileAction.#cctor')
  - [CommonExecute()](#M-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction-CommonExecute 'MFR.Settings.Configuration.Actions.LoadConfigurationFromFileAction.CommonExecute')
- [Resources](#T-MFR-Settings-Configuration-Actions-Properties-Resources 'MFR.Settings.Configuration.Actions.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Actions-Properties-Resources-Culture 'MFR.Settings.Configuration.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Actions-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Configuration-Actions-Is'></a>
## Is `type`

##### Namespace

MFR.Settings.Configuration.Actions

<a name='M-MFR-Settings-Configuration-Actions-Is-ConfigurationBlankOrNull-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig-'></a>
### ConfigurationBlankOrNull(config) `method`

##### Summary

Determines whether the specified `config` is blank or
not.

##### Returns

`true` if the specified
`config` is the blank application config or if
a `null` reference is passed as the argument of the
`config` parameter; `false`
otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig') | (Required.) Reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface. |

<a name='T-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction'></a>
## LoadConfigurationFilePathFromRegistryAction `type`

##### Namespace

MFR.Settings.Configuration.Actions

##### Summary

Accesses a key and value in the system Registry to load the pathname of
the master config file.

<a name='M-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-AccessTheRegueryExpressionValidator'></a>
### AccessTheRegueryExpressionValidator `property`

##### Summary

Gets the one and only instance of the Registry query expression validator that
read [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') values  from the system Registry.

<a name='P-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[LoadConfigurationFilePathFromRegistryAction](#T-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction 'MFR.Settings.Configuration.Actions.LoadConfigurationFilePathFromRegistryAction')
.

<a name='P-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-MessageType 'MFR.MessageType') that is being used
to identify which message this.

<a name='M-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Actions-LoadConfigurationFilePathFromRegistryAction-ExecuteOperationIfNotCached'></a>
### ExecuteOperationIfNotCached() `method`

##### Summary

Performs this action's operation if the result could not located in
the result cache.

##### Returns

Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that corresponds to the result of executing the action.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.



This a template method, the call to which is wrapped in a robust
and fault-tolerant override of the
[CommonExecute](#M-MFR-ActionBase-CommonExecute 'MFR.ActionBase.CommonExecute')
method.



The parent method override (a) validates that the _input field is
not null, (b) checks for thrown exceptions, and(c) checks the result
cache first to see if data corresponding to the input is there.

<a name='T-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction'></a>
## LoadConfigurationFromFileAction `type`

##### Namespace

MFR.Settings.Configuration.Actions

##### Summary

Accesses a key and value in the system Registry to load the pathname of
the master config file.

<a name='M-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[LoadConfigurationFromFileAction](#T-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction 'MFR.Settings.Configuration.Actions.LoadConfigurationFromFileAction')
.

<a name='P-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-MessageType 'MFR.MessageType') that is being used
to identify which message this.

<a name='M-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Settings-Configuration-Actions-LoadConfigurationFromFileAction-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this message.

##### Returns

Reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface that is initialized with the values read in from the
specified file.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the [_input](#F-MFR-ActionBase-_input 'MFR.ActionBase._input') field is
blank or `null`. |

##### Remarks

Implementers shall override this method to provide the functionality
of the request.

<a name='T-MFR-Settings-Configuration-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
