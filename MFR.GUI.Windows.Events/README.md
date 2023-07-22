<a name='assembly'></a>
# MFR.GUI.Windows.Events

## Contents

- [MainWindowStateChangedEventArgs](#T-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs 'MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs')
  - [#ctor(oldState,newState)](#M-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs-#ctor-MFR-GUI-Windows-Constants-MainWindowState,MFR-GUI-Windows-Constants-MainWindowState- 'MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs.#ctor(MFR.GUI.Windows.Constants.MainWindowState,MFR.GUI.Windows.Constants.MainWindowState)')
  - [NewState](#P-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs-NewState 'MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs.NewState')
  - [OldState](#P-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs-OldState 'MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs.OldState')
- [MainWindowStateChangedEventHandler](#T-MFR-GUI-Windows-Events-MainWindowStateChangedEventHandler 'MFR.GUI.Windows.Events.MainWindowStateChangedEventHandler')
- [Resources](#T-MFR-GUI-Windows-Events-Properties-Resources 'MFR.GUI.Windows.Events.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Events-Properties-Resources-Culture 'MFR.GUI.Windows.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Windows-Events-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs'></a>
## MainWindowStateChangedEventArgs `type`

##### Namespace

MFR.GUI.Windows.Events

##### Summary

Provides information for `MainWindowStateChanged` event handlers.

<a name='M-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs-#ctor-MFR-GUI-Windows-Constants-MainWindowState,MFR-GUI-Windows-Constants-MainWindowState-'></a>
### #ctor(oldState,newState) `constructor`

##### Summary

Constructs a new instance of
[MainWindowStateChangedEventArgs](#T-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs 'MFR.GUI.Windows.Events.MainWindowStateChangedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| oldState | [MFR.GUI.Windows.Constants.MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState') | (Required.) One of the
[MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState') enumeration values
that describes the former state. |
| newState | [MFR.GUI.Windows.Constants.MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState') | (Required.) One of the
[MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState') enumeration values
that describes the current state. |

<a name='P-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs-NewState'></a>
### NewState `property`

##### Summary

Gets one of the [MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState')
enumeration values that describes the current state.

<a name='P-MFR-GUI-Windows-Events-MainWindowStateChangedEventArgs-OldState'></a>
### OldState `property`

##### Summary

Gets one of the [MainWindowState](#T-MFR-GUI-Windows-Constants-MainWindowState 'MFR.GUI.Windows.Constants.MainWindowState')
enumeration values that describes the former state.

<a name='T-MFR-GUI-Windows-Events-MainWindowStateChangedEventHandler'></a>
## MainWindowStateChangedEventHandler `type`

##### Namespace

MFR.GUI.Windows.Events

##### Summary

Represents a handler for a `MainWindowStateChanged` event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.GUI.Windows.Events.MainWindowStateChangedEventHandler](#T-T-MFR-GUI-Windows-Events-MainWindowStateChangedEventHandler 'T:MFR.GUI.Windows.Events.MainWindowStateChangedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
`MainWindowStateChanged` event.

<a name='T-MFR-GUI-Windows-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
