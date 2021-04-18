<a name='assembly'></a>
# MFR.Objects

## Contents

- [ProgramFlowHelper](#T-MFR-Objects-ProgramFlowHelper 'MFR.Objects.ProgramFlowHelper')
  - [StartDebugger()](#M-MFR-Objects-ProgramFlowHelper-StartDebugger 'MFR.Objects.ProgramFlowHelper.StartDebugger')
- [Reflector](#T-MFR-Objects-Reflector 'MFR.Objects.Reflector')
- [Resources](#T-MFR-Objects-Properties-Resources 'MFR.Objects.Properties.Resources')
  - [Culture](#P-MFR-Objects-Properties-Resources-Culture 'MFR.Objects.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Properties-Resources-ResourceManager 'MFR.Objects.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-ProgramFlowHelper'></a>
## ProgramFlowHelper `type`

##### Namespace

MFR.Objects

##### Summary

Defines methods and properties to aid in controlling the flow of the program.

<a name='M-MFR-Objects-ProgramFlowHelper-StartDebugger'></a>
### StartDebugger() `method`

##### Summary

Launches the Visual Studio Debugger.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Reflector'></a>
## Reflector `type`

##### Namespace

MFR.Objects

##### Summary

This class is from the Front-End for Dosbox and is used to present a
'vista' dialog box to select folders. Being able to use a vista style
dialog box to select folders is much better then using the shell folder
browser. http://code.google.com/p/fed/ Example: var r = new Reflector("System.Windows.Forms");

<a name='T-MFR-Objects-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
