<a name='assembly'></a>
# MFR.CommandLine.Parsers.Events

## Contents

- [DisplayHelpEventArgs](#T-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs 'MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs')
  - [#ctor(helpText)](#M-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs-#ctor-System-String- 'MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs.#ctor(System.String)')
  - [HelpText](#P-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs-HelpText 'MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs.HelpText')
- [DisplayHelpEventHandler](#T-MFR-CommandLine-Parsers-Events-DisplayHelpEventHandler 'MFR.CommandLine.Parsers.Events.DisplayHelpEventHandler')
- [Resources](#T-MFR-CommandLine-Parsers-Events-Properties-Resources 'MFR.CommandLine.Parsers.Events.Properties.Resources')
  - [Culture](#P-MFR-CommandLine-Parsers-Events-Properties-Resources-Culture 'MFR.CommandLine.Parsers.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-CommandLine-Parsers-Events-Properties-Resources-ResourceManager 'MFR.CommandLine.Parsers.Events.Properties.Resources.ResourceManager')

<a name='T-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs'></a>
## DisplayHelpEventArgs `type`

##### Namespace

MFR.CommandLine.Parsers.Events

##### Summary

Provides information for DisplayHelp event handlers.

<a name='M-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs-#ctor-System-String-'></a>
### #ctor(helpText) `constructor`

##### Summary

Constructs a new instance of
[DisplayHelpEventArgs](#T-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs 'MFR.CommandLine.Parsers.Events.DisplayHelpEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| helpText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the Help text that is to be displayed. |

<a name='P-MFR-CommandLine-Parsers-Events-DisplayHelpEventArgs-HelpText'></a>
### HelpText `property`

##### Summary

Gets a string that contains the Help text that is to be displayed.

<a name='T-MFR-CommandLine-Parsers-Events-DisplayHelpEventHandler'></a>
## DisplayHelpEventHandler `type`

##### Namespace

MFR.CommandLine.Parsers.Events

##### Summary

Represents a handler for a DisplayHelp event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:MFR.CommandLine.Parsers.Events.DisplayHelpEventHandler](#T-T-MFR-CommandLine-Parsers-Events-DisplayHelpEventHandler 'T:MFR.CommandLine.Parsers.Events.DisplayHelpEventHandler') | Reference to the instance of the object that raised the event. |

##### Remarks

This delegate merely specifies the signature of all methods that handle the
DisplayHelp event.

<a name='T-MFR-CommandLine-Parsers-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.CommandLine.Parsers.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-CommandLine-Parsers-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-CommandLine-Parsers-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
