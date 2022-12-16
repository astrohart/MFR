<a name='assembly'></a>
# MFR.GUI.Windows.Factories

## Contents

- [GetMainWIndow](#T-MFR-GUI-Windows-Factories-GetMainWIndow 'MFR.GUI.Windows.Factories.GetMainWIndow')
  - [SoleInstance()](#M-MFR-GUI-Windows-Factories-GetMainWIndow-SoleInstance 'MFR.GUI.Windows.Factories.GetMainWIndow.SoleInstance')
- [Resources](#T-MFR-GUI-Windows-Factories-Properties-Resources 'MFR.GUI.Windows.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Windows-Factories-Properties-Resources-Culture 'MFR.GUI.Windows.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Windows-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Windows.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Windows-Factories-GetMainWIndow'></a>
## GetMainWIndow `type`

##### Namespace

MFR.GUI.Windows.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow') interface.

<a name='M-MFR-GUI-Windows-Factories-GetMainWIndow-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow') interface, and returns
a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IMainWindow](#T-MFR-GUI-Windows-Interfaces-IMainWindow 'MFR.GUI.Windows.Interfaces.IMainWindow') interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Windows-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Windows.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Windows-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Windows-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
