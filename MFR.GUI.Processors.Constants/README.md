<a name='assembly'></a>
# MFR.GUI.Processors.Constants

## Contents

- [CommandLineProcessorType](#T-MFR-GUI-Processors-Constants-CommandLineProcessorType 'MFR.GUI.Processors.Constants.CommandLineProcessorType')
  - [Automated](#F-MFR-GUI-Processors-Constants-CommandLineProcessorType-Automated 'MFR.GUI.Processors.Constants.CommandLineProcessorType.Automated')
  - [GuiDriven](#F-MFR-GUI-Processors-Constants-CommandLineProcessorType-GuiDriven 'MFR.GUI.Processors.Constants.CommandLineProcessorType.GuiDriven')
  - [Unknown](#F-MFR-GUI-Processors-Constants-CommandLineProcessorType-Unknown 'MFR.GUI.Processors.Constants.CommandLineProcessorType.Unknown')
- [Resources](#T-MFR-GUI-Processors-Constants-Properties-Resources 'MFR.GUI.Processors.Constants.Properties.Resources')
  - [Culture](#P-MFR-GUI-Processors-Constants-Properties-Resources-Culture 'MFR.GUI.Processors.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Processors-Constants-Properties-Resources-ResourceManager 'MFR.GUI.Processors.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Processors-Constants-CommandLineProcessorType'></a>
## CommandLineProcessorType `type`

##### Namespace

MFR.GUI.Processors.Constants

##### Summary

Values to indicate how we are going to process the application's command line.

<a name='F-MFR-GUI-Processors-Constants-CommandLineProcessorType-Automated'></a>
### Automated `constants`

##### Summary

The user has supplied configuration on the command line and then requested that
the operation be started without further intervention.

<a name='F-MFR-GUI-Processors-Constants-CommandLineProcessorType-GuiDriven'></a>
### GuiDriven `constants`

##### Summary

We are going to display the GUI and allow the user to make selections on their
own.

##### Remarks

If the configuration has been specified on the command line, we'll
fill those fields in on the user-interface for the user in advance.

<a name='F-MFR-GUI-Processors-Constants-CommandLineProcessorType-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown command line processor.

<a name='T-MFR-GUI-Processors-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Processors.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Processors-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Processors-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
