<a name='assembly'></a>
# MFR.GUI.Windows.Presenters.Events

## Contents

- [AddProfileFailedEventArgs](#T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs 'MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs')
  - [#ctor(message)](#M-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs-#ctor-System-String- 'MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs.#ctor(System.String)')
  - [Message](#P-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs-Message 'MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs.Message')
- [AddProfileFailedEventHandler](#T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventHandler 'MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventHandler')
- [CreateNewBlankProfileRequestedEventArgs](#T-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs 'MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs')
  - [#ctor(name)](#M-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs-#ctor-System-String- 'MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs.#ctor(System.String)')
  - [Name](#P-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs-Name 'MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs.Name')
- [CreateNewBlankProfileRequestedEventHandler](#T-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventHandler 'MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventHandler')
- [Resources](#T-MFR-GUI-Windows-Presenters-Events-Properties-Resources 'MFR.GUI.Windows.Presenters.Events.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Presenters-Events-Properties-Resources-Culture 'MFR.GUI.Windows.Presenters.Events.Properties.Resources.Culture')
  - [Error_ValueCannotBeNullOrWhiteSpace](#P-MFR-GUI-Windows-Presenters-Events-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace 'MFR.GUI.Windows.Presenters.Events.Properties.Resources.Error_ValueCannotBeNullOrWhiteSpace')
  - [ResourceManager](#P-MFR-GUI-Windows-Presenters-Events-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Presenters.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs'></a>
## AddProfileFailedEventArgs `type`

##### Namespace

MFR.GUI.Windows.Presenters.Events

##### Summary

Defines the data that is passed by all events of type
[AddProfileFailedEventHandler](#T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventHandler 'MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventHandler')
.

<a name='M-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Creates a new instance of
[AddProfileFailedEventArgs](#T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs 'MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the error message to display to the user, or
write to the log file, that explains why the Add Profile operation has failed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`message`, is passed a blank or `null`
string for a value. |

<a name='P-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventArgs-Message'></a>
### Message `property`

##### Summary

Gets a string containing an error message that explains why the add profile
operation failed.

##### Remarks

This string can be displayed to the user or written to a log file.

<a name='T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventHandler'></a>
## AddProfileFailedEventHandler `type`

##### Namespace

MFR.GUI.Windows.Presenters.Events

##### Summary

Defines the method signature for the handlers of a AddProfileFailed event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventHandler](#T-T-MFR-GUI-Windows-Presenters-Events-AddProfileFailedEventHandler 'T:MFR.GUI.Windows.Presenters.Events.AddProfileFailedEventHandler') | Reference to the instance of the object that raised the event. |

<a name='T-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs'></a>
## CreateNewBlankProfileRequestedEventArgs `type`

##### Namespace

MFR.GUI.Windows.Presenters.Events

##### Summary

Provides information for CreateNewBlankProfileRequested event handlers.

<a name='M-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Constructs a new instance of
[CreateNewBlankProfileRequestedEventArgs](#T-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs 'MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name to be assigned to the new profile. |

<a name='P-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventArgs-Name'></a>
### Name `property`

##### Summary

Gets a string that contains the name that the user wants to use for the new
Profile.

<a name='T-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventHandler'></a>
## CreateNewBlankProfileRequestedEventHandler `type`

##### Namespace

MFR.GUI.Windows.Presenters.Events

##### Summary

Represents a handler for a CreateNewBlankProfileRequested event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventHandler](#T-T-MFR-GUI-Windows-Presenters-Events-CreateNewBlankProfileRequestedEventHandler 'T:MFR.GUI.Windows.Presenters.Events.CreateNewBlankProfileRequestedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
CreateNewBlankProfileRequested event.

<a name='T-MFR-GUI-Windows-Presenters-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Presenters.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Presenters-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Presenters-Events-Properties-Resources-Error_ValueCannotBeNullOrWhiteSpace'></a>
### Error_ValueCannotBeNullOrWhiteSpace `property`

##### Summary

Looks up a localized string similar to Value cannot be null or whitespace..

<a name='P-MFR-GUI-Windows-Presenters-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
