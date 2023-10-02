<a name='assembly'></a>
# MFR.GUI.Application.Factories

## Contents

- [GetProjectFileRenamerApp](#T-MFR-GUI-Application-Factories-GetProjectFileRenamerApp 'MFR.GUI.Application.Factories.GetProjectFileRenamerApp')
  - [SoleInstance()](#M-MFR-GUI-Application-Factories-GetProjectFileRenamerApp-SoleInstance 'MFR.GUI.Application.Factories.GetProjectFileRenamerApp.SoleInstance')
- [Resources](#T-MFR-GUI-Application-Factories-Properties-Resources 'MFR.GUI.Application.Factories.Properties.Resources')
  - [Culture](#P-MFR-GUI-Application-Factories-Properties-Resources-Culture 'MFR.GUI.Application.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Application-Factories-Properties-Resources-ResourceManager 'MFR.GUI.Application.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Application-Factories-GetProjectFileRenamerApp'></a>
## GetProjectFileRenamerApp `type`

##### Namespace

MFR.GUI.Application.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IWinApp](#T-MFR-GUI-Application-Interfaces-IWinApp 'MFR.GUI.Application.Interfaces.IWinApp') interface.

<a name='M-MFR-GUI-Application-Factories-GetProjectFileRenamerApp-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IWinApp](#T-MFR-GUI-Application-Interfaces-IWinApp 'MFR.GUI.Application.Interfaces.IWinApp') interface, and returns
a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IWinApp](#T-MFR-GUI-Application-Interfaces-IWinApp 'MFR.GUI.Application.Interfaces.IWinApp') interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-GUI-Application-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Application.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Application-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Application-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
