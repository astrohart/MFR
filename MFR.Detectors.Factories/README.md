<a name='assembly'></a>
# MFR.Detectors.Factories

## Contents

- [GetFileFormatDetector](#T-MFR-Detectors-Factories-GetFileFormatDetector 'MFR.Detectors.Factories.GetFileFormatDetector')
  - [SoleInstance()](#M-MFR-Detectors-Factories-GetFileFormatDetector-SoleInstance 'MFR.Detectors.Factories.GetFileFormatDetector.SoleInstance')
- [Resources](#T-MFR-Detectors-Factories-Properties-Resources 'MFR.Detectors.Factories.Properties.Resources')
  - [Culture](#P-MFR-Detectors-Factories-Properties-Resources-Culture 'MFR.Detectors.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Detectors-Factories-Properties-Resources-ResourceManager 'MFR.Detectors.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-Detectors-Factories-GetFileFormatDetector'></a>
## GetFileFormatDetector `type`

##### Namespace

MFR.Detectors.Factories

##### Summary

Provides access to the one and only instance of the object that implements the
[IFileFormatDetector](#T-MFR-Detectors-Interfaces-IFileFormatDetector 'MFR.Detectors.Interfaces.IFileFormatDetector') interface.

<a name='M-MFR-Detectors-Factories-GetFileFormatDetector-SoleInstance'></a>
### SoleInstance() `method`

##### Summary

Obtains access to the sole instance of the object that implements the
[IFileFormatDetector](#T-MFR-Detectors-Interfaces-IFileFormatDetector 'MFR.Detectors.Interfaces.IFileFormatDetector') interface, and
returns a reference to it.

##### Returns

Reference to the one, and only, instance of the object that implements the
[IFileFormatDetector](#T-MFR-Detectors-Interfaces-IFileFormatDetector 'MFR.Detectors.Interfaces.IFileFormatDetector') interface.

##### Parameters

This method has no parameters.

<a name='T-MFR-Detectors-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Detectors.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Detectors-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Detectors-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
