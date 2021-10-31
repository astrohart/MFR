<a name='assembly'></a>
# MFR.RunningObjects.Factories

## Contents

- [GetRunningObject](#T-MFR-Objects-RunningObjects-Factories-GetRunningObject 'MFR.RunningObjects.Factories.GetRunningObject')
  - [ByDisplayName(displayName)](#M-MFR-Objects-RunningObjects-Factories-GetRunningObject-ByDisplayName-System-String- 'MFR.RunningObjects.Factories.GetRunningObject.ByDisplayName(System.String)')
  - [DisplayNames()](#M-MFR-Objects-RunningObjects-Factories-GetRunningObject-DisplayNames 'MFR.RunningObjects.Factories.GetRunningObject.DisplayNames')
- [Resources](#T-MFR-Objects-RunningObjects-Factories-Properties-Resources 'MFR.RunningObjects.Factories.Properties.Resources')
  - [Culture](#P-MFR-Objects-RunningObjects-Factories-Properties-Resources-Culture 'MFR.RunningObjects.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-RunningObjects-Factories-Properties-Resources-ResourceManager 'MFR.RunningObjects.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-RunningObjects-Factories-GetRunningObject'></a>
## GetRunningObject `type`

##### Namespace

MFR.RunningObjects.Factories

##### Summary

Contains methods that allow access to running object information.

<a name='M-MFR-Objects-RunningObjects-Factories-GetRunningObject-ByDisplayName-System-String-'></a>
### ByDisplayName(displayName) `method`

##### Summary

Gets an entry from the Running Object Table (ROT) by
`displayName`.

##### Returns

Reference to an instance of an object that represents the fetched
entry, if found; otherwise, `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| displayName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the display name of the running object
that is to be looked up. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `displayName`, is
passed a blank or `null` string for a value. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | If any one of the lookup operations that the operating system is
instructed to perform in order to carry out the lookup fail. |

<a name='M-MFR-Objects-RunningObjects-Factories-GetRunningObject-DisplayNames'></a>
### DisplayNames() `method`

##### Summary

Gets the full list of display names of all the elements of the
running object table.

##### Returns

Collection of strings, each of which contains the display name of a
running object.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-RunningObjects-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.RunningObjects.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-RunningObjects-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-RunningObjects-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
