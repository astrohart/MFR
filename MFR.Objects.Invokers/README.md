<a name='assembly'></a>
# MFR.Objects.Invokers

## Contents

- [PathFilterInvokerBase](#T-MFR-Objects-Invokers-PathFilterInvokerBase 'MFR.Objects.Invokers.PathFilterInvokerBase')
  - [#ctor()](#M-MFR-Objects-Invokers-PathFilterInvokerBase-#ctor 'MFR.Objects.Invokers.PathFilterInvokerBase.#ctor')
  - [Instance](#P-MFR-Objects-Invokers-PathFilterInvokerBase-Instance 'MFR.Objects.Invokers.PathFilterInvokerBase.Instance')
  - [Path](#P-MFR-Objects-Invokers-PathFilterInvokerBase-Path 'MFR.Objects.Invokers.PathFilterInvokerBase.Path')
  - [#cctor()](#M-MFR-Objects-Invokers-PathFilterInvokerBase-#cctor 'MFR.Objects.Invokers.PathFilterInvokerBase.#cctor')
  - [AndPath()](#M-MFR-Objects-Invokers-PathFilterInvokerBase-AndPath-System-String- 'MFR.Objects.Invokers.PathFilterInvokerBase.AndPath(System.String)')
  - [Passes(pathFilter)](#M-MFR-Objects-Invokers-PathFilterInvokerBase-Passes-System-Predicate{System-String}- 'MFR.Objects.Invokers.PathFilterInvokerBase.Passes(System.Predicate{System.String})')
- [Resources](#T-MFR-Objects-Invokers-Properties-Resources 'MFR.Objects.Invokers.Properties.Resources')
  - [Culture](#P-MFR-Objects-Invokers-Properties-Resources-Culture 'MFR.Objects.Invokers.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Invokers-Properties-Resources-ResourceManager 'MFR.Objects.Invokers.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Invokers-PathFilterInvokerBase'></a>
## PathFilterInvokerBase `type`

##### Namespace

MFR.Objects.Invokers

##### Summary

Provides common functionality for all path filter invoker objects.

<a name='M-MFR-Objects-Invokers-PathFilterInvokerBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Invokers-PathFilterInvokerBase-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [PathFilterInvokerBase](#T-MFR-Objects-Invokers-PathFilterInvokerBase 'MFR.Objects.Invokers.PathFilterInvokerBase').

<a name='P-MFR-Objects-Invokers-PathFilterInvokerBase-Path'></a>
### Path `property`

##### Summary

Gets or sets a string that contains the path to be decided upon.

<a name='M-MFR-Objects-Invokers-PathFilterInvokerBase-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Invokers-PathFilterInvokerBase-AndPath-System-String-'></a>
### AndPath() `method`

##### Summary

Fluent-builder method that set the path that the path-filtering
predicate is to be invoked upon.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Invokers-PathFilterInvokerBase-Passes-System-Predicate{System-String}-'></a>
### Passes(pathFilter) `method`

##### Summary

Gets the result of invoking the path-filtering predicate on the path
specified by calling the [AndPath](#M-MFR-Objects-IPathFilterInvoker-AndPath 'MFR.Objects.IPathFilterInvoker.AndPath') method.

##### Returns

`true` if the path passed to the predicate is to be
allowed in the operation; `false` otherwise. This
method also returns `true` if the `pathFilter` is passed a `null` reference.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | A [Predicate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate'), taking a string as argument,
that decides whether the path should be allowed. |

<a name='T-MFR-Objects-Invokers-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Invokers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Invokers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Invokers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
