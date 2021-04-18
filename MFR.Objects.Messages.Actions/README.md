<a name='assembly'></a>
# MFR.Objects.Messages.Actions

## Contents

- [ActionBase\`2](#T-MFR-Objects-Messages-Actions-ActionBase`2 'MFR.Objects.Messages.Actions.ActionBase`2')
  - [#ctor()](#M-MFR-Objects-Messages-Actions-ActionBase`2-#ctor 'MFR.Objects.Messages.Actions.ActionBase`2.#ctor')
  - [#ctor()](#M-MFR-Objects-Messages-Actions-ActionBase`2-#ctor-`0- 'MFR.Objects.Messages.Actions.ActionBase`2.#ctor(`0)')
  - [_input](#F-MFR-Objects-Messages-Actions-ActionBase`2-_input 'MFR.Objects.Messages.Actions.ActionBase`2._input')
  - [AsCachedResultAction()](#M-MFR-Objects-Messages-Actions-ActionBase`2-AsCachedResultAction 'MFR.Objects.Messages.Actions.ActionBase`2.AsCachedResultAction')
  - [WithInput(input)](#M-MFR-Objects-Messages-Actions-ActionBase`2-WithInput-`0- 'MFR.Objects.Messages.Actions.ActionBase`2.WithInput(`0)')
- [ActionCacheProvider\`2](#T-MFR-Objects-Messages-Actions-ActionCacheProvider`2 'MFR.Objects.Messages.Actions.ActionCacheProvider`2')
  - [ResultCache](#P-MFR-Objects-Messages-Actions-ActionCacheProvider`2-ResultCache 'MFR.Objects.Messages.Actions.ActionCacheProvider`2.ResultCache')
  - [Add(input,result)](#M-MFR-Objects-Messages-Actions-ActionCacheProvider`2-Add-`0,`1- 'MFR.Objects.Messages.Actions.ActionCacheProvider`2.Add(`0,`1)')
  - [Clear(elementAction)](#M-MFR-Objects-Messages-Actions-ActionCacheProvider`2-Clear-System-Action{`0,`1}- 'MFR.Objects.Messages.Actions.ActionCacheProvider`2.Clear(System.Action{`0,`1})')
  - [IsNullOrEmpty()](#M-MFR-Objects-Messages-Actions-ActionCacheProvider`2-IsNullOrEmpty 'MFR.Objects.Messages.Actions.ActionCacheProvider`2.IsNullOrEmpty')
- [CachedResultActionBase\`2](#T-MFR-Objects-Messages-Actions-CachedResultActionBase`2 'MFR.Objects.Messages.Actions.CachedResultActionBase`2')
  - [AddResultToCache(resultToAdd)](#M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-AddResultToCache-`1- 'MFR.Objects.Messages.Actions.CachedResultActionBase`2.AddResultToCache(`1)')
  - [AsCachedResultAction()](#M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-AsCachedResultAction 'MFR.Objects.Messages.Actions.CachedResultActionBase`2.AsCachedResultAction')
  - [ClearResultCache(elementAction)](#M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-ClearResultCache-System-Action{`0,`1}- 'MFR.Objects.Messages.Actions.CachedResultActionBase`2.ClearResultCache(System.Action{`0,`1})')
  - [CommonExecute()](#M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-CommonExecute 'MFR.Objects.Messages.Actions.CachedResultActionBase`2.CommonExecute')
  - [ExecuteOperationIfNotCached()](#M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-ExecuteOperationIfNotCached 'MFR.Objects.Messages.Actions.CachedResultActionBase`2.ExecuteOperationIfNotCached')
  - [Finalize()](#M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-Finalize 'MFR.Objects.Messages.Actions.CachedResultActionBase`2.Finalize')
  - [TryGetCachedResult(result)](#M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-TryGetCachedResult-`1@- 'MFR.Objects.Messages.Actions.CachedResultActionBase`2.TryGetCachedResult(`1@)')
- [ConfigurationActionType](#T-MFR-Objects-Messages-Actions-ConfigurationActionType 'MFR.Objects.Messages.Actions.ConfigurationActionType')
- [ImportConfigurationFromFileAction](#T-MFR-Objects-Messages-Actions-ImportConfigurationFromFileAction 'MFR.Objects.Messages.Actions.ImportConfigurationFromFileAction')
  - [#ctor()](#M-MFR-Objects-Messages-Actions-ImportConfigurationFromFileAction-#ctor 'MFR.Objects.Messages.Actions.ImportConfigurationFromFileAction.#ctor')
  - [Instance](#P-MFR-Objects-Messages-Actions-ImportConfigurationFromFileAction-Instance 'MFR.Objects.Messages.Actions.ImportConfigurationFromFileAction.Instance')
  - [#cctor()](#M-MFR-Objects-Messages-Actions-ImportConfigurationFromFileAction-#cctor 'MFR.Objects.Messages.Actions.ImportConfigurationFromFileAction.#cctor')
- [LoadConfigurationFromFileAction](#T-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction 'MFR.Objects.Messages.Actions.LoadConfigurationFromFileAction')
  - [#ctor()](#M-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction-#ctor 'MFR.Objects.Messages.Actions.LoadConfigurationFromFileAction.#ctor')
  - [Instance](#P-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction-Instance 'MFR.Objects.Messages.Actions.LoadConfigurationFromFileAction.Instance')
  - [MessageType](#P-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction-MessageType 'MFR.Objects.Messages.Actions.LoadConfigurationFromFileAction.MessageType')
  - [#cctor()](#M-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction-#cctor 'MFR.Objects.Messages.Actions.LoadConfigurationFromFileAction.#cctor')
  - [CommonExecute()](#M-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction-CommonExecute 'MFR.Objects.Messages.Actions.LoadConfigurationFromFileAction.CommonExecute')
- [LoadStringFromRegistryAction](#T-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction 'MFR.Objects.Messages.Actions.LoadStringFromRegistryAction')
  - [#ctor()](#M-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction-#ctor 'MFR.Objects.Messages.Actions.LoadStringFromRegistryAction.#ctor')
  - [Instance](#P-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction-Instance 'MFR.Objects.Messages.Actions.LoadStringFromRegistryAction.Instance')
  - [MessageType](#P-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction-MessageType 'MFR.Objects.Messages.Actions.LoadStringFromRegistryAction.MessageType')
  - [#cctor()](#M-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction-#cctor 'MFR.Objects.Messages.Actions.LoadStringFromRegistryAction.#cctor')
  - [ExecuteOperationIfNotCached()](#M-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction-ExecuteOperationIfNotCached 'MFR.Objects.Messages.Actions.LoadStringFromRegistryAction.ExecuteOperationIfNotCached')
- [Resources](#T-MFR-Objects-Messages-Actions-Properties-Resources 'MFR.Objects.Messages.Actions.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Actions-Properties-Resources-Culture 'MFR.Objects.Messages.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Actions-Properties-Resources-ResourceManager 'MFR.Objects.Messages.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Messages-Actions-ActionBase`2'></a>
## ActionBase\`2 `type`

##### Namespace

MFR.Objects.Messages.Actions

##### Summary

Defines the methods, properties, events, and other functionality that is
shared among all message objects.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInput | Name of the class or data type that contains information used to execute
the message.



This object is composed with the message object at runtime. |
| TResult | Name of the class or data type that will carry user state information
about the results of the message. |

<a name='M-MFR-Objects-Messages-Actions-ActionBase`2-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ActionBase](#T-MFR-Objects-ActionBase 'MFR.Objects.ActionBase')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-MFR-Objects-Messages-Actions-ActionBase`2-#ctor-`0-'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[ActionBase](#T-MFR-Objects-ActionBase 'MFR.Objects.ActionBase')
and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Objects-Messages-Actions-ActionBase`2-_input'></a>
### _input `constants`

##### Summary

Reference to an instance of `TInput` that
contains the input data.

<a name='M-MFR-Objects-Messages-Actions-ActionBase`2-AsCachedResultAction'></a>
### AsCachedResultAction() `method`

##### Summary

Returns a reference to this same object, but cast to the
[ICachedResultAction](#T-MFR-Objects-ICachedResultAction 'MFR.Objects.ICachedResultAction')
interface.

##### Returns

Reference to the same object instance as that which invoked this
method, cast to the
[ICachedResultAction](#T-MFR-Objects-ICachedResultAction 'MFR.Objects.ICachedResultAction')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') | Thrown if the implementing object does not also implement the
[ICachedResultAction](#T-MFR-Objects-ICachedResultAction 'MFR.Objects.ICachedResultAction')
interface. |

##### Remarks

Overriders of this method must not call the base class.

<a name='M-MFR-Objects-Messages-Actions-ActionBase`2-WithInput-`0-'></a>
### WithInput(input) `method`

##### Summary

Composes this object's `input` with it.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [\`0](#T-`0 '`0') | (Required.) Reference to an instance of
`TInput`
that contains data to be provided to the message. |

<a name='T-MFR-Objects-Messages-Actions-ActionCacheProvider`2'></a>
## ActionCacheProvider\`2 `type`

##### Namespace

MFR.Objects.Messages.Actions

##### Summary

Helper methods and properties to deal with the result cache.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInput | Data type of the input of the action. |
| TResult | Data type of the result of the action. |

<a name='P-MFR-Objects-Messages-Actions-ActionCacheProvider`2-ResultCache'></a>
### ResultCache `property`

##### Summary

Cache of already-processed results.

<a name='M-MFR-Objects-Messages-Actions-ActionCacheProvider`2-Add-`0,`1-'></a>
### Add(input,result) `method`

##### Summary

Adds an entry to the cache of previous results of this action.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [\`0](#T-`0 '`0') | (Required.) Instance of an object of type `TInput`. |
| result | [\`1](#T-`1 '`1') | (Required.) Instance of an object of type `TResult`. |

##### Remarks

If either of `input` or `result` are `null`, then this method does nothing.

<a name='M-MFR-Objects-Messages-Actions-ActionCacheProvider`2-Clear-System-Action{`0,`1}-'></a>
### Clear(elementAction) `method`

##### Summary

Clears all entries that are currently stored in the result cache.



Optionally invokes a delegate for each element of the result cache
prior to performing the clear operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elementAction | [System.Action{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{`0,`1}') | (Optional.) Reference to an instance of an instance of a
[Action{TInput, TResult}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{TInput, TResult}')
delegate that is run for
each element of the cache, just prior to the cache being cleared.



If this parameter is not a `null` reference, then
the code referenced by this delegate is invoked for every element of
the result cache, prior to the cache being cleared.



This parameter can be useful should callers, say, need to run
cleanup code to properly release system resources consumed by
elements of the cache, prior to the cache itself being emptied. |

<a name='M-MFR-Objects-Messages-Actions-ActionCacheProvider`2-IsNullOrEmpty'></a>
### IsNullOrEmpty() `method`

##### Summary

Gets a value specifying whether the result cache is a
`null`
reference or if it contains zero items.

##### Returns

`true` if the result cache is `null`
or contains zero items; `false` otherwise.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Messages-Actions-CachedResultActionBase`2'></a>
## CachedResultActionBase\`2 `type`

##### Namespace

MFR.Objects.Messages.Actions

##### Summary

Caches the results of repeated operations using the same inputs in order
to improve performance.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInput | Data type of the input of the action. |
| TResult | Data type of the result of the action. |

##### Remarks

Implementations should inherit from this class when it is believed that
calling an action with the same input will always yield the same result.



Such caching is designed to enhance application performance.



This parent class is especially useful for actions that need to query a
data source whose data rarely changes, but for which access poses a
non-negligible reduction in performance.

<a name='M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-AddResultToCache-`1-'></a>
### AddResultToCache(resultToAdd) `method`

##### Summary

Associates a reference to the `resultToAdd` to the
current value of the
[_input](#F-MFR-Objects-ActionBase-_input 'MFR.Objects.ActionBase._input')
field. using
the internal result cache dictionary.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resultToAdd | [\`1](#T-`1 '`1') | Reference to an instance of `TResult` that is
to be associated with the current input value. |

<a name='M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-AsCachedResultAction'></a>
### AsCachedResultAction() `method`

##### Summary

Returns a reference to this same object, but cast to the
[ICachedResultAction](#T-MFR-Objects-ICachedResultAction 'MFR.Objects.ICachedResultAction')
interface.

##### Returns

Reference to the same object instance as that which invoked this
method, cast to the
[ICachedResultAction](#T-MFR-Objects-ICachedResultAction 'MFR.Objects.ICachedResultAction')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') | Thrown if the implementing object does not also implement the
[ICachedResultAction](#T-MFR-Objects-ICachedResultAction 'MFR.Objects.ICachedResultAction')
interface. |

##### Remarks

Overriders of this method must not call the base class.

<a name='M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-ClearResultCache-System-Action{`0,`1}-'></a>
### ClearResultCache(elementAction) `method`

##### Summary

Clears the cache of results built up from the prior executions of this action.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elementAction | [System.Action{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{`0,`1}') |  |

<a name='M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this message.

##### Returns

A `TResult` instance containing data from the
result of executing the message.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.

<a name='M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-ExecuteOperationIfNotCached'></a>
### ExecuteOperationIfNotCached() `method`

##### Summary

Performs this action's operation if the result could not located in
the result cache.

##### Returns

Reference to an instance of `TResult` that
corresponds to the current input or `null` if an issue occurred.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.



This is a template method, the call to which is wrapped in a robust
and fault-tolerant override of the
[CommonExecute](#M-MFR-Objects-ActionBase-CommonExecute 'MFR.Objects.ActionBase.CommonExecute')
method.



The parent method override (a) validates that the _input field is
not null, (b) checks for thrown exceptions, and(c) checks the result
cache first to see if data corresponding to the input is there.

<a name='M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-Finalize'></a>
### Finalize() `method`

##### Summary

Allows an object to try to free resources and perform other cleanup
operations before it is reclaimed by garbage collection.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Messages-Actions-CachedResultActionBase`2-TryGetCachedResult-`1@-'></a>
### TryGetCachedResult(result) `method`

##### Summary

Attempts to access the result cache dictionary using the current
value of the
[_input](#F-MFR-Objects-ActionBase-_input 'MFR.Objects.ActionBase._input')
field, and asks
whether it is present in the cache.

##### Returns

If the current value of the
[_input](#F-MFR-Objects-ActionBase-_input 'MFR.Objects.ActionBase._input')
field is
present in the result cache dictionary and associated with a
corresponding result, then the `result` parameter
is filled with the corresponding value, and this method returns
`true`; otherwise, the method returns `false` and the
`result` parameter is assigned a `null` reference.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [\`1@](#T-`1@ '`1@') | Reference to a memory location that will receive a reference to an
instance of `TResult` if one is found in the
result cache; otherwise, will be assigned the `null` reference. |

##### Remarks

This method really is merely an alias for the
[TryGetValue](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IDictionary.TryGetValue 'System.Collections.Generic.IDictionary.TryGetValue')
method.



Child classes may override this method in order to
provide additional processing; however, it is mandatory to begin the
override's code with a call to the base class.

<a name='T-MFR-Objects-Messages-Actions-ConfigurationActionType'></a>
## ConfigurationActionType `type`

##### Namespace

MFR.Objects.Messages.Actions

##### Summary



<a name='T-MFR-Objects-Messages-Actions-ImportConfigurationFromFileAction'></a>
## ImportConfigurationFromFileAction `type`

##### Namespace

MFR.Objects.Messages.Actions

##### Summary

Imports configuration from a file that is not the master configuration file.

<a name='M-MFR-Objects-Messages-Actions-ImportConfigurationFromFileAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Messages-Actions-ImportConfigurationFromFileAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ImportConfigurationFromFileAction](#T-MFR-Objects-Messages-Actions-ImportConfigurationFromFileAction 'MFR.Objects.Messages.Actions.ImportConfigurationFromFileAction')
.

<a name='M-MFR-Objects-Messages-Actions-ImportConfigurationFromFileAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction'></a>
## LoadConfigurationFromFileAction `type`

##### Namespace

MFR.Objects.Messages.Actions

##### Summary

Accesses a key and value in the system Registry to load the pathname of
the master configuration file.

<a name='M-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[LoadConfigurationFromFileAction](#T-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction 'MFR.Objects.Messages.Actions.LoadConfigurationFromFileAction')
.

<a name='P-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-Objects-MessageType 'MFR.Objects.MessageType') that is
being used to identify which message this is.

<a name='M-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Messages-Actions-LoadConfigurationFromFileAction-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this message.

##### Returns

String containing the path to the master configuration file loaded
from the system Registry, or blank if an error occurred.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the
[_input](#F-MFR-Objects-ActionBase-_input 'MFR.Objects.ActionBase._input')
field is blank
or `null`. |

##### Remarks

Implementers shall override this method to provide the functionality
of the request.

<a name='T-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction'></a>
## LoadStringFromRegistryAction `type`

##### Namespace

MFR.Objects.Messages.Actions

##### Summary

Accesses a key and value in the system Registry to load the pathname of
the master configuration file.

<a name='M-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[LoadStringFromRegistryAction](#T-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction 'MFR.Objects.Messages.Actions.LoadStringFromRegistryAction')
.

<a name='P-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-Objects-MessageType 'MFR.Objects.MessageType') that is being used
to identify which message this is.

<a name='M-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Messages-Actions-LoadStringFromRegistryAction-ExecuteOperationIfNotCached'></a>
### ExecuteOperationIfNotCached() `method`

##### Summary

Performs this action's operation if the result could not located in
the result cache.

##### Returns

Reference to an instance of an object that implements the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface that corresponds to the result of executing the action.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.



This is a template method, the call to which is wrapped in a robust
and fault-tolerant override of the
[CommonExecute](#M-MFR-Objects-ActionBase-CommonExecute 'MFR.Objects.ActionBase.CommonExecute')
method.



The parent method override (a) validates that the _input field is
not null, (b) checks for thrown exceptions, and(c) checks the result
cache first to see if data corresponding to the input is there.

<a name='T-MFR-Objects-Messages-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Messages.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Messages-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Messages-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
