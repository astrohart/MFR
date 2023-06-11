<a name='assembly'></a>
# MFR.GUI.Constants

## Contents

- [ProgramText](#T-MFR-GUI-Constants-ProgramText 'MFR.GUI.Constants.ProgramText')
  - [CompanyName](#P-MFR-GUI-Constants-ProgramText-CompanyName 'MFR.GUI.Constants.ProgramText.CompanyName')
  - [MainWindowTitle](#P-MFR-GUI-Constants-ProgramText-MainWindowTitle 'MFR.GUI.Constants.ProgramText.MainWindowTitle')
  - [ProductName](#P-MFR-GUI-Constants-ProgramText-ProductName 'MFR.GUI.Constants.ProgramText.ProductName')
  - [ProductNameWithoutCompany](#P-MFR-GUI-Constants-ProgramText-ProductNameWithoutCompany 'MFR.GUI.Constants.ProgramText.ProductNameWithoutCompany')
  - [ShortCompanyName](#P-MFR-GUI-Constants-ProgramText-ShortCompanyName 'MFR.GUI.Constants.ProgramText.ShortCompanyName')
- [Resources](#T-MFR-GUI-Constants-Properties-Resources 'MFR.GUI.Constants.Properties.Resources')
  - [Culture](#P-MFR-GUI-Constants-Properties-Resources-Culture 'MFR.GUI.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-GUI-Constants-Properties-Resources-ResourceManager 'MFR.GUI.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-GUI-Constants-ProgramText'></a>
## ProgramText `type`

##### Namespace

MFR.GUI.Constants

##### Summary

Text to be used throughout the application.

##### Remarks

This class contains static, computed properties, which may seem rather
strange.



There is a reason for this: the static constructor of this class chokes
otherwise.

<a name='P-MFR-GUI-Constants-ProgramText-CompanyName'></a>
### CompanyName `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that represents the company name
associated with the application.

<a name='P-MFR-GUI-Constants-ProgramText-MainWindowTitle'></a>
### MainWindowTitle `property`

##### Summary

Gets the title text that should be utilized for the main application window.

<a name='P-MFR-GUI-Constants-ProgramText-ProductName'></a>
### ProductName `property`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that represents the product name that is
associated with the application.

<a name='P-MFR-GUI-Constants-ProgramText-ProductNameWithoutCompany'></a>
### ProductNameWithoutCompany `property`

##### Summary

Gets the product name without the company name.

<a name='P-MFR-GUI-Constants-ProgramText-ShortCompanyName'></a>
### ShortCompanyName `property`

##### Summary

Gets the short name (without prefixes or suffixes) of the company
that manufactured this tool.

<a name='T-MFR-GUI-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.GUI.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-GUI-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-GUI-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
