<a name='assembly'></a>
# MFR.Settings.Profiles.Actions.Factories

## Contents

- [GetProfileCollectionAction](#T-MFR-Settings-Profiles-Actions-Factories-GetProfileCollectionAction 'MFR.Settings.Profiles.Actions.Factories.GetProfileCollectionAction')
  - [For\`\`2(actionType)](#M-MFR-Settings-Profiles-Actions-Factories-GetProfileCollectionAction-For``2-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionActionType- 'MFR.Settings.Profiles.Actions.Factories.GetProfileCollectionAction.For``2(MFR.Settings.Profiles.Actions.Constants.ProfileCollectionActionType)')
- [Resources](#T-MFR-Settings-Profiles-Actions-Factories-Properties-Resources 'MFR.Settings.Profiles.Actions.Factories.Properties.Resources')
  - [Culture](#P-MFR-Settings-Profiles-Actions-Factories-Properties-Resources-Culture 'MFR.Settings.Profiles.Actions.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Profiles-Actions-Factories-Properties-Resources-ResourceManager 'MFR.Settings.Profiles.Actions.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Settings-Profiles-Actions-Factories-GetProfileCollectionAction'></a>
## GetProfileCollectionAction `type`

##### Namespace

MFR.Settings.Profiles.Actions.Factories

##### Summary

Creates instances of objects that implement the
[IAction](#T-MFR-Messages-Actions-Interfaces-IAction 'MFR.Messages.Actions.Interfaces.IAction')
interface, in order to perform actions on the list of profiles.

##### Remarks

In our parlance, an Action is a process that has both an input and an output.

<a name='M-MFR-Settings-Profiles-Actions-Factories-GetProfileCollectionAction-For``2-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionActionType-'></a>
### For\`\`2(actionType) `method`

##### Summary

Creates a new instance of an object that implements the
[IAction](#T-MFR-Messages-Actions-Interfaces-IAction 'MFR.Messages.Actions.Interfaces.IAction')
interface and returns a reference to it.

##### Returns

Reference to an instance of an object that implements the
[IAction](#T-MFR-Messages-Actions-Interfaces-IAction 'MFR.Messages.Actions.Interfaces.IAction')
interface
that corresponds to the specified
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| actionType | [MFR.Settings.Profiles.Actions.Constants.ProfileCollectionActionType](#T-MFR-Settings-Profiles-Actions-Constants-ProfileCollectionActionType 'MFR.Settings.Profiles.Actions.Constants.ProfileCollectionActionType') | (Required.) A
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
value that
indicates what action to execute. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown if no action is available that corresponds to the
[MessageType](#T-MFR-Messages-Constants-MessageType 'MFR.Messages.Constants.MessageType')
value provided
in the `actionType` parameter. |

<a name='T-MFR-Settings-Profiles-Actions-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Profiles.Actions.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Profiles-Actions-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Profiles-Actions-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
