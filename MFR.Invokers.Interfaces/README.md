<a name='assembly'></a>
# MFR.Invokers.Interfaces

## Contents

- [IPathFilterInvoker](#T-MFR-Invokers-Interfaces-IPathFilterInvoker 'MFR.Invokers.Interfaces.IPathFilterInvoker')
  - [AndPath()](#M-MFR-Invokers-Interfaces-IPathFilterInvoker-AndPath-System-String- 'MFR.Invokers.Interfaces.IPathFilterInvoker.AndPath(System.String)')
  - [Passes(pathFilter)](#M-MFR-Invokers-Interfaces-IPathFilterInvoker-Passes-System-Predicate{System-String}- 'MFR.Invokers.Interfaces.IPathFilterInvoker.Passes(System.Predicate{System.String})')
- [Resources](#T-MFR-Invokers-Interfaces-Properties-Resources 'MFR.Invokers.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Invokers-Interfaces-Properties-Resources-Culture 'MFR.Invokers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Invokers-Interfaces-Properties-Resources-ResourceManager 'MFR.Invokers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Invokers-Interfaces-IPathFilterInvoker'></a>
## IPathFilterInvoker `type`

##### Namespace

MFR.Invokers.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of all path filter invoker objects.

<a name='M-MFR-Invokers-Interfaces-IPathFilterInvoker-AndPath-System-String-'></a>
### AndPath() `method`

##### Summary

Fluent-builder method that set the path that the path-filtering
predicate is to be invoked upon.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

<a name='M-MFR-Invokers-Interfaces-IPathFilterInvoker-Passes-System-Predicate{System-String}-'></a>
### Passes(pathFilter) `method`

##### Summary

Gets the result of invoking the path-filtering predicate on the path
specified by calling the [AndPath](#M-MFR-IPathFilterInvoker-AndPath 'MFR.IPathFilterInvoker.AndPath') method.

##### Returns

`true` if the path passed to the predicate is to be
allowed in the operation; `false` otherwise. This
method also returns `true` if the `pathFilter` is passed a `null` reference.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathFilter | [System.Predicate{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate{System.String}') | A [Predicate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Predicate 'System.Predicate'), taking a string as argument,
that decides whether the path should be allowed. |

<a name='T-MFR-Invokers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Invokers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Invokers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Invokers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
