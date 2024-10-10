<a name='assembly'></a>
# MFR.GUI.Dialogs.Events

## Contents

- [ModifiedEventArgs](#T-MFR-GUI-Dialogs-Events-ModifiedEventArgs 'MFR.GUI.Dialogs.Events.ModifiedEventArgs')
  - [Handled](#P-MFR-GUI-Dialogs-Events-ModifiedEventArgs-Handled 'MFR.GUI.Dialogs.Events.ModifiedEventArgs.Handled')
- [ModifiedEventHandler](#T-MFR-GUI-Dialogs-Events-ModifiedEventHandler 'MFR.GUI.Dialogs.Events.ModifiedEventHandler')
- [Resources](#T-MFR-GUI-Dialogs-Events-Properties-Resources 'MFR.GUI.Dialogs.Events.Properties.Resources')
  - [Culture](#P-MFR-GUI-Dialogs-Events-Properties-Resources-Culture 'MFR.GUI.Dialogs.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Dialogs-Events-Properties-Resources-ResourceManager 'MFR.GUI.Dialogs.Events.Properties.Resources.ResourceManager')
- [SendErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs')
  - [#ctor(exception,errorReportContent,reproductionSteps,nameOfUser,emailAddressOfUser)](#M-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-#ctor-System-Exception,System-String,System-String,System-String,System-String- 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs.#ctor(System.Exception,System.String,System.String,System.String,System.String)')
  - [EmailAddressOfUser](#P-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-EmailAddressOfUser 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs.EmailAddressOfUser')
  - [ErrorReportContent](#P-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-ErrorReportContent 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs.ErrorReportContent')
  - [Exception](#P-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-Exception 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs.Exception')
  - [NameOfUser](#P-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-NameOfUser 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs.NameOfUser')
  - [ReproductionSteps](#P-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-ReproductionSteps 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs.ReproductionSteps')
  - [#cctor()](#M-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-#cctor 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs.#cctor')
- [SendErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler')
- [ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs')
  - [#ctor(exception,errorReportContent)](#M-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-#ctor-System-Exception,System-String- 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs.#ctor(System.Exception,System.String)')
  - [ErrorReportContent](#P-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-ErrorReportContent 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs.ErrorReportContent')
  - [Exception](#P-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-Exception 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs.Exception')
  - [#cctor()](#M-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-#cctor 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs.#cctor')
- [ViewErrorReportRequestedEventHandler](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler')

<a name='T-MFR-GUI-Dialogs-Events-ModifiedEventArgs'></a>
## ModifiedEventArgs `type`

##### Namespace

MFR.GUI.Dialogs.Events

##### Summary

Provides information for a Modified event.

<a name='P-MFR-GUI-Dialogs-Events-ModifiedEventArgs-Handled'></a>
### Handled `property`

##### Summary

Gets or sets a value indicating whether a Modified event has been
handled. Can be set by handlers of the event.

<a name='T-MFR-GUI-Dialogs-Events-ModifiedEventHandler'></a>
## ModifiedEventHandler `type`

##### Namespace

MFR.GUI.Dialogs.Events

##### Summary

Represents a handler for a Modified event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.GUI.Dialogs.Events.ModifiedEventHandler](#T-T-MFR-GUI-Dialogs-Events-ModifiedEventHandler 'T:MFR.GUI.Dialogs.Events.ModifiedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle
the Modified event.

<a name='T-MFR-GUI-Dialogs-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Dialogs.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Dialogs-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Dialogs-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs'></a>
## SendErrorReportRequestedEventArgs `type`

##### Namespace

MFR.GUI.Dialogs.Events

##### Summary

Provides information for SendErrorReportRequested event handlers.

<a name='M-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-#ctor-System-Exception,System-String,System-String,System-String,System-String-'></a>
### #ctor(exception,errorReportContent,reproductionSteps,nameOfUser,emailAddressOfUser) `constructor`

##### Summary

Constructs a new instance of
[SendErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) Reference to an instance of [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that
describes the error to be reported. |
| errorReportContent | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the content of the detailed error report to be
sent. |
| reproductionSteps | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the user's report of what was happening that led
up to the error. |
| nameOfUser | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the user. |
| emailAddressOfUser | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the email address of
the user. |

<a name='P-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-EmailAddressOfUser'></a>
### EmailAddressOfUser `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the email address of the user.

##### Remarks

If the user declines to provide their email address, then the value of
this property is the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='P-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-ErrorReportContent'></a>
### ErrorReportContent `property`

##### Summary

Gets a string that contains the detailed error report that is to be sent.

<a name='P-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to an instance of [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that
describes the error being reported.

<a name='P-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-NameOfUser'></a>
### NameOfUser `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the user if it has
been provided.

##### Remarks

If the user declines to share their name, then the value of this property is
set to the [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Empty 'System.String.Empty') value.

<a name='P-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-ReproductionSteps'></a>
### ReproductionSteps `property`

##### Summary

Gets a string that contains the user's explanation of what led up to the error.

<a name='M-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[SendErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventArgs')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler'></a>
## SendErrorReportRequestedEventHandler `type`

##### Namespace

MFR.GUI.Dialogs.Events

##### Summary

Represents a handler for a SendErrorReportRequested event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler](#T-T-MFR-GUI-Dialogs-Events-SendErrorReportRequestedEventHandler 'T:MFR.GUI.Dialogs.Events.SendErrorReportRequestedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the SendErrorReportRequested event.

<a name='T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs'></a>
## ViewErrorReportRequestedEventArgs `type`

##### Namespace

MFR.GUI.Dialogs.Events

##### Summary

Provides information for ViewErrorReportRequested event handlers.

<a name='M-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-#ctor-System-Exception,System-String-'></a>
### #ctor(exception,errorReportContent) `constructor`

##### Summary

Constructs a new instance of
[ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | (Required.) A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that
describes the error that occurred. |
| errorReportContent | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the text of the report. |

<a name='P-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-ErrorReportContent'></a>
### ErrorReportContent `property`

##### Summary

Gets a string that contains the detailed error report that is to be sent.

<a name='P-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to the [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') instance that
describes the error that occurred.

<a name='M-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the
[ViewErrorReportRequestedEventArgs](#T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventArgs 'MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventArgs')
class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.



We've decorated this constructor with the `[Log(AttributeExclude = true)]`
attribute in order to simplify the logging output.

<a name='T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler'></a>
## ViewErrorReportRequestedEventHandler `type`

##### Namespace

MFR.GUI.Dialogs.Events

##### Summary

Represents a handler for a ViewErrorReportRequested event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler](#T-T-MFR-GUI-Dialogs-Events-ViewErrorReportRequestedEventHandler 'T:MFR.GUI.Dialogs.Events.ViewErrorReportRequestedEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the ViewErrorReportRequested event.
