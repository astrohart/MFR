<a name='assembly'></a>
# MFR.Messages.Actions.Interfaces

## Contents

- [IAction\`2](#T-MFR-Objects-Messages-Actions-Interfaces-IAction`2 'MFR.Messages.Actions.Interfaces.IAction`2')
  - [AsCachedResultAction()](#M-MFR-Objects-Messages-Actions-Interfaces-IAction`2-AsCachedResultAction 'MFR.Messages.Actions.Interfaces.IAction`2.AsCachedResultAction')
  - [WithInput(input)](#M-MFR-Objects-Messages-Actions-Interfaces-IAction`2-WithInput-`0- 'MFR.Messages.Actions.Interfaces.IAction`2.WithInput(`0)')
- [ICachedResultAction\`2](#T-MFR-Objects-Messages-Actions-Interfaces-ICachedResultAction`2 'MFR.Messages.Actions.Interfaces.ICachedResultAction`2')
  - [ClearResultCache(elementAction)](#M-MFR-Objects-Messages-Actions-Interfaces-ICachedResultAction`2-ClearResultCache-System-Action{`0,`1}- 'MFR.Messages.Actions.Interfaces.ICachedResultAction`2.ClearResultCache(System.Action{`0,`1})')
- [Resources](#T-MFR-Objects-Messages-Actions-Interfaces-Properties-Resources 'MFR.Messages.Actions.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Actions-Interfaces-Properties-Resources-Culture 'MFR.Messages.Actions.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Actions-Interfaces-Properties-Resources-ResourceManager 'MFR.Messages.Actions.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Messages-Actions-Interfaces-IAction`2'></a>
## IAction\`2 `type`

##### Namespace

MFR.Messages.Actions.Interfaces

##### Summary

Defines the public-exposed methods and properties of a command object
that performs an message with regards to the application's configuration.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TInput | Name of the class or data type that contains information used to execute
the message.



This object is composed with the message object at runtime. |
| TResult | Name of the class or data type that will carry user state information
about the results of the operation. |

##### Remarks

The messages that can be performed on the application's configuration are:

<a name='M-MFR-Objects-Messages-Actions-Interfaces-IAction`2-AsCachedResultAction'></a>
### AsCachedResultAction() `method`

##### Summary

Returns a reference to this same object, but cast to the
[ICachedResultAction](#T-MFR-Objects-ICachedResultAction 'MFR.ICachedResultAction')
interface.

##### Returns

Reference to the same object instance as that which invoked this
method, cast to the
[ICachedResultAction](#T-MFR-Objects-ICachedResultAction 'MFR.ICachedResultAction')
interface.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') | Thrown if the implementing object does not also implement the
[ICachedResultAction](#T-MFR-Objects-ICachedResultAction 'MFR.ICachedResultAction')
interface. |

<a name='M-MFR-Objects-Messages-Actions-Interfaces-IAction`2-WithInput-`0-'></a>
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

<a name='T-MFR-Objects-Messages-Actions-Interfaces-ICachedResultAction`2'></a>
## ICachedResultAction\`2 `type`

##### Namespace

MFR.Messages.Actions.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an `action`
object that caches the results from the prior times that its operation
has been invoked for the same input..

<a name='M-MFR-Objects-Messages-Actions-Interfaces-ICachedResultAction`2-ClearResultCache-System-Action{`0,`1}-'></a>
### ClearResultCache(elementAction) `method`

##### Summary

Clears all entries that are currently stored in the result cache.



Optionally invokes a delegate for each element of the result cache
prior to performing the clear operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elementAction | [System.Action{\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{`0,`1}') | (Optional.) Reference to an instance of an instance of a
[Action{TInput, TResult}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{TInput, TResult}')
delegate.



If this parameter is not a `null` reference, then the code
referenced by this delegate is invoked for every element of the
result cache, prior to the cache being cleared.



This parameter can be useful should callers, say, need to run
cleanup code to properly release system resources consumed by
elements of the cache, prior to the cache itself being emptied. |

<a name='T-MFR-Objects-Messages-Actions-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Messages.Actions.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Messages-Actions-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Messages-Actions-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
