<a name='assembly'></a>
# MFR.GUI.Dialogs.Constants

## Contents

- [ConvertProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ConvertProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ConvertProfileCreateOperationType')
  - [ToString(type)](#M-MFR-GUI-Dialogs-Constants-ConvertProfileCreateOperationType-ToString-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType- 'MFR.GUI.Dialogs.Constants.ConvertProfileCreateOperationType.ToString(MFR.GUI.Dialogs.Constants.ProfileCreateOperationType)')
- [ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType')
  - [New](#F-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-New 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType.New')
  - [SaveAs](#F-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-SaveAs 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType.SaveAs')
- [Resources](#T-MFR-GUI-Dialogs-Constants-Properties-Resources 'MFR.GUI.Dialogs.Constants.Properties.Resources')
  - [Culture](#P-MFR-GUI-Dialogs-Constants-Properties-Resources-Culture 'MFR.GUI.Dialogs.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Dialogs-Constants-Properties-Resources-ResourceManager 'MFR.GUI.Dialogs.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Dialogs-Constants-ConvertProfileCreateOperationType'></a>
## ConvertProfileCreateOperationType `type`

##### Namespace

MFR.GUI.Dialogs.Constants

##### Summary

Method to convert
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType')
values to, e.g., display strings etc.

<a name='M-MFR-GUI-Dialogs-Constants-ConvertProfileCreateOperationType-ToString-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-'></a>
### ToString(type) `method`

##### Summary

Converts the
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') value
passed in the `type` parameter into a string to be displayed
in a graphical user interface.

##### Returns

String containing the display value that corresponds to the value
passed in the `type` parameter, or the
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value if a non-supported value is passed
for the `type` parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [MFR.GUI.Dialogs.Constants.ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') | (Required.) A
[ProfileCreateOperationType](#T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType 'MFR.GUI.Dialogs.Constants.ProfileCreateOperationType') value
that you want to convert. |

<a name='T-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType'></a>
## ProfileCreateOperationType `type`

##### Namespace

MFR.GUI.Dialogs.Constants

##### Summary

Values that specify which type of profile-creation operation is being done.

<a name='F-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-New'></a>
### New `constants`

##### Summary

A new, blank profile is being created.

<a name='F-MFR-GUI-Dialogs-Constants-ProfileCreateOperationType-SaveAs'></a>
### SaveAs `constants`

##### Summary

The user wants to save the current search as a named Profile.

<a name='T-MFR-GUI-Dialogs-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Dialogs.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Dialogs-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Dialogs-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
