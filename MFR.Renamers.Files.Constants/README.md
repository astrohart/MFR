<a name='assembly'></a>
# MFR.Renamers.Files.Constants

## Contents

- [Resources](#T-MFR-Renamers-Files-Constants-Properties-Resources 'MFR.Renamers.Files.Constants.Properties.Resources')
  - [Culture](#P-MFR-Renamers-Files-Constants-Properties-Resources-Culture 'MFR.Renamers.Files.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Renamers-Files-Constants-Properties-Resources-ResourceManager 'MFR.Renamers.Files.Constants.Properties.Resources.ResourceManager')
- [SpecializedFileData](#T-MFR-Renamers-Files-Constants-SpecializedFileData 'MFR.Renamers.Files.Constants.SpecializedFileData')
  - [BinaryFileSkipped](#F-MFR-Renamers-Files-Constants-SpecializedFileData-BinaryFileSkipped 'MFR.Renamers.Files.Constants.SpecializedFileData.BinaryFileSkipped')
  - [NoChange](#F-MFR-Renamers-Files-Constants-SpecializedFileData-NoChange 'MFR.Renamers.Files.Constants.SpecializedFileData.NoChange')

<a name='T-MFR-Renamers-Files-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Renamers.Files.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Renamers-Files-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Renamers-Files-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Renamers-Files-Constants-SpecializedFileData'></a>
## SpecializedFileData `type`

##### Namespace

MFR.Renamers.Files.Constants

##### Summary

Specialized data that is to be returned in the event that a file meets certain
criteria, but we do not want to halt an operation.

<a name='F-MFR-Renamers-Files-Constants-SpecializedFileData-BinaryFileSkipped'></a>
### BinaryFileSkipped `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a specialized GUID that
substitutes for file data of a binary file, so that we can skip these files
without failing the overall operation..

<a name='F-MFR-Renamers-Files-Constants-SpecializedFileData-NoChange'></a>
### NoChange `constants`

##### Summary

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains a specialized GUID that
indicates that the replacement operation did not change the contents of the
file.  This should clue the calling method to skip to the next file.
