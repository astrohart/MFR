<a name='assembly'></a>
# MFR.Invokers.Factories

## Contents

- [MakeNewPathFilterInvoker](#T-MFR-Invokers-Factories-MakeNewPathFilterInvoker 'MFR.Invokers.Factories.MakeNewPathFilterInvoker')
  - [For(entry)](#M-MFR-Invokers-Factories-MakeNewPathFilterInvoker-For-MFR-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Invokers.Factories.MakeNewPathFilterInvoker.For(MFR.FileSystem.Interfaces.IFileSystemEntry)')
  - [FromScratch()](#M-MFR-Invokers-Factories-MakeNewPathFilterInvoker-FromScratch 'MFR.Invokers.Factories.MakeNewPathFilterInvoker.FromScratch')
- [Resources](#T-MFR-Invokers-Factories-Properties-Resources 'MFR.Invokers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Invokers-Factories-Properties-Resources-Culture 'MFR.Invokers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Invokers-Factories-Properties-Resources-ResourceManager 'MFR.Invokers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Invokers-Factories-MakeNewPathFilterInvoker'></a>
## MakeNewPathFilterInvoker `type`

##### Namespace

MFR.Invokers.Factories

##### Summary

Creates new instances of objects that implement the
[IPathFilterInvoker](#T-MFR-Invokers-Interfaces-IPathFilterInvoker 'MFR.Invokers.Interfaces.IPathFilterInvoker')
interface
and initializes them.

<a name='M-MFR-Invokers-Factories-MakeNewPathFilterInvoker-For-MFR-FileSystem-Interfaces-IFileSystemEntry-'></a>
### For(entry) `method`

##### Summary

Creates a new instance of an object that implements the
[IPathFilterInvoker](#T-MFR-Invokers-Interfaces-IPathFilterInvoker 'MFR.Invokers.Interfaces.IPathFilterInvoker')
interface and initializes it with the instance of an object that
implements the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface that is supplied by the `entry` parameter.

##### Returns

Reference to an instance of an object that implements the
[IPathFilterInvoker](#T-MFR-Invokers-Interfaces-IPathFilterInvoker 'MFR.Invokers.Interfaces.IPathFilterInvoker')
interface that is initialized with the value of the
[Path](#P-MFR-FileSystem-Interfaces-IFileSystemEntry-Path 'MFR.FileSystem.Interfaces.IFileSystemEntry.Path')
property of the `entry` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the
[IFileSystemEntry](#T-MFR-FileSystem-Interfaces-IFileSystemEntry 'MFR.FileSystem.Interfaces.IFileSystemEntry')
interface. |

<a name='M-MFR-Invokers-Factories-MakeNewPathFilterInvoker-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IPathFilterInvoker](#T-MFR-Invokers-Interfaces-IPathFilterInvoker 'MFR.Invokers.Interfaces.IPathFilterInvoker')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IPathFilterInvoker](#T-MFR-Invokers-Interfaces-IPathFilterInvoker 'MFR.Invokers.Interfaces.IPathFilterInvoker')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Invokers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Invokers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Invokers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Invokers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
