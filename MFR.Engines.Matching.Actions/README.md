<a name='assembly'></a>
# MFR.Engines.Matching.Actions

## Contents

- [Get](#T-MFR-Engines-Matching-Actions-Get 'MFR.Engines.Matching.Actions.Get')
  - [StringMatcherForOperation()](#M-MFR-Engines-Matching-Actions-Get-StringMatcherForOperation-MFR-Operations-Constants-OperationType,MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration- 'MFR.Engines.Matching.Actions.Get.StringMatcherForOperation(MFR.Operations.Constants.OperationType,MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration)')
- [Resources](#T-MFR-Engines-Matching-Actions-Properties-Resources 'MFR.Engines.Matching.Actions.Properties.Resources')
  - [Culture](#P-MFR-Engines-Matching-Actions-Properties-Resources-Culture 'MFR.Engines.Matching.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Engines-Matching-Actions-Properties-Resources-ResourceManager 'MFR.Engines.Matching.Actions.Properties.Resources.ResourceManager')

<a name='T-MFR-Engines-Matching-Actions-Get'></a>
## Get `type`

##### Namespace

MFR.Engines.Matching.Actions

##### Summary

Exposes static methods to get references to objects that perform
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') pattern-matching based on the current operation
being performed and the current application configuration settings.

<a name='M-MFR-Engines-Matching-Actions-Get-StringMatcherForOperation-MFR-Operations-Constants-OperationType,MFR-Settings-Configuration-Interfaces-IProjectFileRenamerConfiguration-'></a>
### StringMatcherForOperation() `method`

##### Summary

Attempts to obtain a reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface for the
current operation.

##### Returns

Reference to an instance of an object that implements the
[IStringMatcher](#T-MFR-Matchers-Interfaces-IStringMatcher 'MFR.Matchers.Interfaces.IStringMatcher') interface that
corresponds to the current operation and matching configuration.

##### Parameters

This method has no parameters.

<a name='T-MFR-Engines-Matching-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Engines.Matching.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Engines-Matching-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Engines-Matching-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
