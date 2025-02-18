<a name='assembly'></a>
# MFR.GUI.Processors

## Contents

- [AutoStartCommandLineProcessor](#T-MFR-GUI-Processors-AutoStartCommandLineProcessor 'MFR.GUI.Processors.AutoStartCommandLineProcessor')
  - [#ctor()](#M-MFR-GUI-Processors-AutoStartCommandLineProcessor-#ctor 'MFR.GUI.Processors.AutoStartCommandLineProcessor.#ctor')
  - [Instance](#P-MFR-GUI-Processors-AutoStartCommandLineProcessor-Instance 'MFR.GUI.Processors.AutoStartCommandLineProcessor.Instance')
  - [Type](#P-MFR-GUI-Processors-AutoStartCommandLineProcessor-Type 'MFR.GUI.Processors.AutoStartCommandLineProcessor.Type')
  - [#cctor()](#M-MFR-GUI-Processors-AutoStartCommandLineProcessor-#cctor 'MFR.GUI.Processors.AutoStartCommandLineProcessor.#cctor')
  - [Process()](#M-MFR-GUI-Processors-AutoStartCommandLineProcessor-Process 'MFR.GUI.Processors.AutoStartCommandLineProcessor.Process')
- [CommandLineProcessorBase](#T-MFR-GUI-Processors-CommandLineProcessorBase 'MFR.GUI.Processors.CommandLineProcessorBase')
  - [#ctor()](#M-MFR-GUI-Processors-CommandLineProcessorBase-#ctor 'MFR.GUI.Processors.CommandLineProcessorBase.#ctor')
  - [CommandLineInfo](#P-MFR-GUI-Processors-CommandLineProcessorBase-CommandLineInfo 'MFR.GUI.Processors.CommandLineProcessorBase.CommandLineInfo')
  - [ConfigProvider](#P-MFR-GUI-Processors-CommandLineProcessorBase-ConfigProvider 'MFR.GUI.Processors.CommandLineProcessorBase.ConfigProvider')
  - [CurrentConfig](#P-MFR-GUI-Processors-CommandLineProcessorBase-CurrentConfig 'MFR.GUI.Processors.CommandLineProcessorBase.CurrentConfig')
  - [Type](#P-MFR-GUI-Processors-CommandLineProcessorBase-Type 'MFR.GUI.Processors.CommandLineProcessorBase.Type')
  - [#cctor()](#M-MFR-GUI-Processors-CommandLineProcessorBase-#cctor 'MFR.GUI.Processors.CommandLineProcessorBase.#cctor')
  - [Process()](#M-MFR-GUI-Processors-CommandLineProcessorBase-Process 'MFR.GUI.Processors.CommandLineProcessorBase.Process')
- [GuiDrivenCommandLineProcessor](#T-MFR-GUI-Processors-GuiDrivenCommandLineProcessor 'MFR.GUI.Processors.GuiDrivenCommandLineProcessor')
  - [#ctor()](#M-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-#ctor 'MFR.GUI.Processors.GuiDrivenCommandLineProcessor.#ctor')
  - [Instance](#P-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-Instance 'MFR.GUI.Processors.GuiDrivenCommandLineProcessor.Instance')
  - [MainWindow](#P-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-MainWindow 'MFR.GUI.Processors.GuiDrivenCommandLineProcessor.MainWindow')
  - [Type](#P-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-Type 'MFR.GUI.Processors.GuiDrivenCommandLineProcessor.Type')
  - [#cctor()](#M-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-#cctor 'MFR.GUI.Processors.GuiDrivenCommandLineProcessor.#cctor')
  - [Process()](#M-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-Process 'MFR.GUI.Processors.GuiDrivenCommandLineProcessor.Process')
- [NoCommandLineProcessor](#T-MFR-GUI-Processors-NoCommandLineProcessor 'MFR.GUI.Processors.NoCommandLineProcessor')
  - [#ctor()](#M-MFR-GUI-Processors-NoCommandLineProcessor-#ctor 'MFR.GUI.Processors.NoCommandLineProcessor.#ctor')
  - [Instance](#P-MFR-GUI-Processors-NoCommandLineProcessor-Instance 'MFR.GUI.Processors.NoCommandLineProcessor.Instance')
  - [Type](#P-MFR-GUI-Processors-NoCommandLineProcessor-Type 'MFR.GUI.Processors.NoCommandLineProcessor.Type')
  - [#cctor()](#M-MFR-GUI-Processors-NoCommandLineProcessor-#cctor 'MFR.GUI.Processors.NoCommandLineProcessor.#cctor')
  - [Process()](#M-MFR-GUI-Processors-NoCommandLineProcessor-Process 'MFR.GUI.Processors.NoCommandLineProcessor.Process')
- [Resources](#T-MFR-GUI-Processors-Properties-Resources 'MFR.GUI.Processors.Properties.Resources')
  - [Culture](#P-MFR-GUI-Processors-Properties-Resources-Culture 'MFR.GUI.Processors.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Processors-Properties-Resources-ResourceManager 'MFR.GUI.Processors.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Processors-AutoStartCommandLineProcessor'></a>
## AutoStartCommandLineProcessor `type`

##### Namespace

MFR.GUI.Processors

##### Summary

Processes the command line of the application in the event the application is
auto-started; i.e., it is configured and ran on the command line by another
tool as part of a pipeline or workflow.

<a name='M-MFR-GUI-Processors-AutoStartCommandLineProcessor-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Processors-AutoStartCommandLineProcessor-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[ICommandLineProcessor](#T-MFR-GUI-Processors-Interfaces-ICommandLineProcessor 'MFR.GUI.Processors.Interfaces.ICommandLineProcessor') interface
and that represents the command-line processor that acts when the user
specifies the `--autoStart` flag on the command line.

<a name='P-MFR-GUI-Processors-AutoStartCommandLineProcessor-Type'></a>
### Type `property`

##### Summary

Gets a [CommandLineProcessorType](#T-MFR-GUI-Processors-Constants-CommandLineProcessorType 'MFR.GUI.Processors.Constants.CommandLineProcessorType')
enumeration value that identifies the type of processing this processor does.

<a name='M-MFR-GUI-Processors-AutoStartCommandLineProcessor-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Processors-AutoStartCommandLineProcessor-Process'></a>
### Process() `method`

##### Summary

Executes the processing specified by this processor type.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Processors-CommandLineProcessorBase'></a>
## CommandLineProcessorBase `type`

##### Namespace

MFR.GUI.Processors

##### Summary

Defines the events, methods, properties, and behaviors for all command-line
processors.

<a name='M-MFR-GUI-Processors-CommandLineProcessorBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of
[CommandLineProcessorBase](#T-MFR-GUI-Processors-CommandLineProcessorBase 'MFR.GUI.Processors.CommandLineProcessorBase') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor is marked `protected`
due to the fact that this class is marked `abstract`.

<a name='P-MFR-GUI-Processors-CommandLineProcessorBase-CommandLineInfo'></a>
### CommandLineInfo `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[ICommandLineInfo](#T-MFR-CommandLine-Models-Interfaces-ICommandLineInfo 'MFR.CommandLine.Models.Interfaces.ICommandLineInfo') interface
from which settings should be read.

<a name='P-MFR-GUI-Processors-CommandLineProcessorBase-ConfigProvider'></a>
### ConfigProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface.

##### Remarks

The object that implements the
[IProjectFileRenamerConfigProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IProjectFileRenamerConfigProvider 'MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider')
interface allows access to the config settings that the user can use to
control the behavior of the application.



As this class is an abstract base class, we made this property
`protected`
so that our child classes can see it.

<a name='P-MFR-GUI-Processors-CommandLineProcessorBase-CurrentConfig'></a>
### CurrentConfig `property`

##### Summary

Gets or sets a reference to an instance of an object that implements the
[IProjectFileRenamerConfig](#T-MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfig 'MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig')
interface.

##### Remarks

This property can be both read from and written to.  This way, if a
command-line processor decides to update the config from the command
line, then the data currently being stored and loaded by the config
provider can be manipulated by simply setting this property.



Given that this class is an abstract base class, we have marked this property
as `protected` so that our child classes can see it.

<a name='P-MFR-GUI-Processors-CommandLineProcessorBase-Type'></a>
### Type `property`

##### Summary

Gets a [CommandLineProcessorType](#T-MFR-GUI-Processors-Constants-CommandLineProcessorType 'MFR.GUI.Processors.Constants.CommandLineProcessorType')
enumeration value that identifies the type of processing this processor does.

<a name='M-MFR-GUI-Processors-CommandLineProcessorBase-#cctor'></a>
### #cctor() `method`

##### Summary

Initializes static data or performs actions that need to be performed once only
for the [CommandLineProcessorBase](#T-MFR-GUI-Processors-CommandLineProcessorBase 'MFR.GUI.Processors.CommandLineProcessorBase') class.

##### Parameters

This method has no parameters.

##### Remarks

This constructor is called automatically prior to the first instance being
created or before any static members are referenced.

<a name='M-MFR-GUI-Processors-CommandLineProcessorBase-Process'></a>
### Process() `method`

##### Summary

Executes the processing specified by this processor type.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Processors-GuiDrivenCommandLineProcessor'></a>
## GuiDrivenCommandLineProcessor `type`

##### Namespace

MFR.GUI.Processors

##### Summary

Processes the command line, filling in form fields on the GUI with values
supplied by the user on the command line but otherwise does not run automated
operations.

<a name='M-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[ICommandLineProcessor](#T-MFR-GUI-Processors-Interfaces-ICommandLineProcessor 'MFR.GUI.Processors.Interfaces.ICommandLineProcessor') interface
and which represents the processor that allows the application's user interface
to be shown, but with command-line argument values specifying the settings of
the controls.

<a name='P-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-MainWindow'></a>
### MainWindow `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow') interface that
represents the main window of the application.

<a name='P-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-Type'></a>
### Type `property`

##### Summary

Gets a [CommandLineProcessorType](#T-MFR-GUI-Processors-Constants-CommandLineProcessorType 'MFR.GUI.Processors.Constants.CommandLineProcessorType')
enumeration value that identifies the type of processing this processor does.

<a name='M-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Processors-GuiDrivenCommandLineProcessor-Process'></a>
### Process() `method`

##### Summary

Executes the processing specified by this processor type.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Processors-NoCommandLineProcessor'></a>
## NoCommandLineProcessor `type`

##### Namespace

MFR.GUI.Processors

##### Summary

Processes operations that occur when the user launches the application with
nothing specified on the command line.

<a name='M-MFR-GUI-Processors-NoCommandLineProcessor-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-GUI-Processors-NoCommandLineProcessor-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[ICommandLineProcessor](#T-MFR-GUI-Processors-Interfaces-ICommandLineProcessor 'MFR.GUI.Processors.Interfaces.ICommandLineProcessor') interface
and which represents the processor that supports the use case when the user
supplies nothing on the application's command line at launch.

<a name='P-MFR-GUI-Processors-NoCommandLineProcessor-Type'></a>
### Type `property`

##### Summary

Gets a [CommandLineProcessorType](#T-MFR-GUI-Processors-Constants-CommandLineProcessorType 'MFR.GUI.Processors.Constants.CommandLineProcessorType')
enumeration value that identifies the type of processing this processor does.

<a name='M-MFR-GUI-Processors-NoCommandLineProcessor-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-GUI-Processors-NoCommandLineProcessor-Process'></a>
### Process() `method`

##### Summary

Executes the processing specified by this processor type.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Processors-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Processors.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Processors-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Processors-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
