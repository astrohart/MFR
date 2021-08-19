<a name='assembly'></a>
# MFR.Configuration.Actions

## Contents

- [LoadConfigurationFromFileAction](#T-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction 'MFR.Configuration.Actions.LoadConfigurationFromFileAction')
  - [#ctor()](#M-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction-#ctor 'MFR.Configuration.Actions.LoadConfigurationFromFileAction.#ctor')
  - [Instance](#P-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction-Instance 'MFR.Configuration.Actions.LoadConfigurationFromFileAction.Instance')
  - [MessageType](#P-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction-MessageType 'MFR.Configuration.Actions.LoadConfigurationFromFileAction.MessageType')
  - [#cctor()](#M-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction-#cctor 'MFR.Configuration.Actions.LoadConfigurationFromFileAction.#cctor')
  - [CommonExecute()](#M-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction-CommonExecute 'MFR.Configuration.Actions.LoadConfigurationFromFileAction.CommonExecute')
- [LoadStringFromRegistryAction](#T-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction 'MFR.Configuration.Actions.LoadStringFromRegistryAction')
  - [#ctor()](#M-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction-#ctor 'MFR.Configuration.Actions.LoadStringFromRegistryAction.#ctor')
  - [Instance](#P-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction-Instance 'MFR.Configuration.Actions.LoadStringFromRegistryAction.Instance')
  - [MessageType](#P-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction-MessageType 'MFR.Configuration.Actions.LoadStringFromRegistryAction.MessageType')
  - [#cctor()](#M-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction-#cctor 'MFR.Configuration.Actions.LoadStringFromRegistryAction.#cctor')
  - [ExecuteOperationIfNotCached()](#M-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction-ExecuteOperationIfNotCached 'MFR.Configuration.Actions.LoadStringFromRegistryAction.ExecuteOperationIfNotCached')
- [Resources](#T-MFR-Objects-Configuration-Actions-Properties-Resources 'MFR.Configuration.Actions.Properties.Resources')
  - [Culture](#P-MFR-Objects-Configuration-Actions-Properties-Resources-Culture 'MFR.Configuration.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Configuration-Actions-Properties-Resources-ResourceManager 'MFR.Configuration.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction'></a>
## LoadConfigurationFromFileAction `type`

##### Namespace

MFR.Configuration.Actions

##### Summary

Accesses a key and value in the system Registry to load the pathname of
the master configuration file.

<a name='M-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[LoadConfigurationFromFileAction](#T-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction 'MFR.Configuration.Actions.LoadConfigurationFromFileAction')
.

<a name='P-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-Objects-MessageType 'MFR.MessageType') that is being used
to identify which message this is.

<a name='M-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Configuration-Actions-LoadConfigurationFromFileAction-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this message.

##### Returns

Reference to an instance of an object that implements the
[IConfiguration](#T-MFR-Objects-Configuration-Interfaces-IConfiguration 'MFR.Configuration.Interfaces.IConfiguration')
interface that is initialized with the values read in from the
specified file.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the [_input](#F-MFR-Objects-ActionBase-_input 'MFR.ActionBase._input') field is
blank or `null`. |

##### Remarks

Implementers shall override this method to provide the functionality
of the request.

<a name='T-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction'></a>
## LoadStringFromRegistryAction `type`

##### Namespace

MFR.Configuration.Actions

##### Summary

Accesses a key and value in the system Registry to load the pathname of
the master configuration file.

<a name='M-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [LoadStringFromRegistryAction](#T-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction 'MFR.Configuration.Actions.LoadStringFromRegistryAction') .

<a name='P-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-Objects-MessageType 'MFR.MessageType') that is being used
to identify which message this is.

<a name='M-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Configuration-Actions-LoadStringFromRegistryAction-ExecuteOperationIfNotCached'></a>
### ExecuteOperationIfNotCached() `method`

##### Summary

Performs this action's operation if the result could not located in
the result cache.

##### Returns

Reference to an instance of an object that implements the [IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that corresponds to the result of executing the action.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.



This is a template method, the call to which is wrapped in a robust
and fault-tolerant override of the [CommonExecute](#M-MFR-Objects-ActionBase-CommonExecute 'MFR.ActionBase.CommonExecute') method.



The parent method override (a) validates that the _input field is
not null, (b) checks for thrown exceptions, and(c) checks the result
cache first to see if data corresponding to the input is there.

<a name='T-MFR-Objects-Configuration-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Configuration.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Configuration-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Configuration-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
