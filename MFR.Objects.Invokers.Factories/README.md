<a name='assembly'></a>
# MFR.Objects.Invokers.Factories

## Contents

- [MakeNewPathFilterInvoker](#T-MFR-Objects-Invokers-Factories-MakeNewPathFilterInvoker 'MFR.Objects.Invokers.Factories.MakeNewPathFilterInvoker')
  - [For(entry)](#M-MFR-Objects-Invokers-Factories-MakeNewPathFilterInvoker-For-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry- 'MFR.Objects.Invokers.Factories.MakeNewPathFilterInvoker.For(MFR.Objects.FileSystem.Interfaces.IFileSystemEntry)')
  - [FromScratch()](#M-MFR-Objects-Invokers-Factories-MakeNewPathFilterInvoker-FromScratch 'MFR.Objects.Invokers.Factories.MakeNewPathFilterInvoker.FromScratch')
- [Resources](#T-MFR-Objects-Invokers-Factories-Properties-Resources 'MFR.Objects.Invokers.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-Invokers-Factories-Properties-Resources-Culture 'MFR.Objects.Invokers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Invokers-Factories-Properties-Resources-ResourceManager 'MFR.Objects.Invokers.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Invokers-Factories-MakeNewPathFilterInvoker'></a>
## MakeNewPathFilterInvoker `type`

##### Namespace

MFR.Objects.Invokers.Factories

##### Summary

Creates new instances of objects that implement the
[IPathFilterInvoker](#T-MFR-Objects-Invokers-Interfaces-IPathFilterInvoker 'MFR.Objects.Invokers.Interfaces.IPathFilterInvoker')
interface
and initializes them.

<a name='M-MFR-Objects-Invokers-Factories-MakeNewPathFilterInvoker-For-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-'></a>
### For(entry) `method`

##### Summary

Creates a new instance of an object that implements the
[IPathFilterInvoker](#T-MFR-Objects-Invokers-Interfaces-IPathFilterInvoker 'MFR.Objects.Invokers.Interfaces.IPathFilterInvoker')
interface and initializes it with the instance of an object that
implements the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface that is supplied by the `entry` parameter.

##### Returns

Reference to an instance of an object that implements the
[IPathFilterInvoker](#T-MFR-Objects-Invokers-Interfaces-IPathFilterInvoker 'MFR.Objects.Invokers.Interfaces.IPathFilterInvoker')
interface that is initialized with the value of the
[Path](#P-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry-Path 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry.Path')
property of the `entry` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| entry | [MFR.Objects.FileSystem.Interfaces.IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry') | (Required.) Reference to an instance of an object that implements
the
[IFileSystemEntry](#T-MFR-Objects-FileSystem-Interfaces-IFileSystemEntry 'MFR.Objects.FileSystem.Interfaces.IFileSystemEntry')
interface. |

<a name='M-MFR-Objects-Invokers-Factories-MakeNewPathFilterInvoker-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IPathFilterInvoker](#T-MFR-Objects-Invokers-Interfaces-IPathFilterInvoker 'MFR.Objects.Invokers.Interfaces.IPathFilterInvoker')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IPathFilterInvoker](#T-MFR-Objects-Invokers-Interfaces-IPathFilterInvoker 'MFR.Objects.Invokers.Interfaces.IPathFilterInvoker')
interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Invokers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Invokers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Invokers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Invokers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
