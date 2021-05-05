<a name='assembly'></a>
# MFR.Objects.Messages.Constants

## Contents

- [MessageType](#T-MFR-Objects-Messages-Constants-MessageType 'MFR.Objects.Messages.Constants.MessageType')
  - [LoadAllSolutionsInFolder](#F-MFR-Objects-Messages-Constants-MessageType-LoadAllSolutionsInFolder 'MFR.Objects.Messages.Constants.MessageType.LoadAllSolutionsInFolder')
  - [LoadConfigurationFromFile](#F-MFR-Objects-Messages-Constants-MessageType-LoadConfigurationFromFile 'MFR.Objects.Messages.Constants.MessageType.LoadConfigurationFromFile')
  - [LoadStringFromRegistry](#F-MFR-Objects-Messages-Constants-MessageType-LoadStringFromRegistry 'MFR.Objects.Messages.Constants.MessageType.LoadStringFromRegistry')
  - [SaveConfigurationToFile](#F-MFR-Objects-Messages-Constants-MessageType-SaveConfigurationToFile 'MFR.Objects.Messages.Constants.MessageType.SaveConfigurationToFile')
  - [SaveStringToRegistry](#F-MFR-Objects-Messages-Constants-MessageType-SaveStringToRegistry 'MFR.Objects.Messages.Constants.MessageType.SaveStringToRegistry')
  - [Unknown](#F-MFR-Objects-Messages-Constants-MessageType-Unknown 'MFR.Objects.Messages.Constants.MessageType.Unknown')
  - [UnloadAllLoadedSolutionsInFolder](#F-MFR-Objects-Messages-Constants-MessageType-UnloadAllLoadedSolutionsInFolder 'MFR.Objects.Messages.Constants.MessageType.UnloadAllLoadedSolutionsInFolder')
- [Resources](#T-MFR-Objects-Messages-Constants-Properties-Resources 'MFR.Objects.Messages.Constants.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Constants-Properties-Resources-Culture 'MFR.Objects.Messages.Constants.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Constants-Properties-Resources-ResourceManager 'MFR.Objects.Messages.Constants.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Messages-Constants-MessageType'></a>
## MessageType `type`

##### Namespace

MFR.Objects.Messages.Constants

##### Summary

Values specifying what message to execute.

<a name='F-MFR-Objects-Messages-Constants-MessageType-LoadAllSolutionsInFolder'></a>
### LoadAllSolutionsInFolder `constants`

##### Summary

Loads all the Visual Studio Solutions (*.sln) in the specified
folder, each in its own instance of `devenv.exe`.

<a name='F-MFR-Objects-Messages-Constants-MessageType-LoadConfigurationFromFile'></a>
### LoadConfigurationFromFile `constants`

##### Summary

Loads the configuration from a file.

<a name='F-MFR-Objects-Messages-Constants-MessageType-LoadStringFromRegistry'></a>
### LoadStringFromRegistry `constants`

##### Summary

Loads a string value from the system Registry.

<a name='F-MFR-Objects-Messages-Constants-MessageType-SaveConfigurationToFile'></a>
### SaveConfigurationToFile `constants`

##### Summary

Saves the configuration to a file.

<a name='F-MFR-Objects-Messages-Constants-MessageType-SaveStringToRegistry'></a>
### SaveStringToRegistry `constants`

##### Summary

Saves a string value to the system Registry.

<a name='F-MFR-Objects-Messages-Constants-MessageType-Unknown'></a>
### Unknown `constants`

##### Summary

Generic, unknown message.

<a name='F-MFR-Objects-Messages-Constants-MessageType-UnloadAllLoadedSolutionsInFolder'></a>
### UnloadAllLoadedSolutionsInFolder `constants`

##### Summary

Unloads all Visual Studio Solutions (*.sln) that are currently open
in instances of Visual Studio, that are found in the specified folder.

<a name='T-MFR-Objects-Messages-Constants-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Messages.Constants.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Messages-Constants-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Messages-Constants-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
