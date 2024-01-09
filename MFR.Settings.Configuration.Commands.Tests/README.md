<a name='assembly'></a>
# MFR.Settings.Configuration.Commands.Tests

## Contents

- [Resources](#T-MFR-Settings-Configuration-Commands-Tests-Properties-Resources 'MFR.Settings.Configuration.Commands.Tests.Properties.Resources')
  - [Culture](#P-MFR-Settings-Configuration-Commands-Tests-Properties-Resources-Culture 'MFR.Settings.Configuration.Commands.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Settings-Configuration-Commands-Tests-Properties-Resources-ResourceManager 'MFR.Settings.Configuration.Commands.Tests.Properties.Resources.ResourceManager')
- [SaveConfigurationToFileCommandTests](#T-MFR-Settings-Configuration-Commands-Tests-SaveConfigurationToFileCommandTests 'MFR.Settings.Configuration.Commands.Tests.SaveConfigurationToFileCommandTests')
  - [FILE_PATH](#F-MFR-Settings-Configuration-Commands-Tests-SaveConfigurationToFileCommandTests-FILE_PATH 'MFR.Settings.Configuration.Commands.Tests.SaveConfigurationToFileCommandTests.FILE_PATH')
  - [BlankConfig](#P-MFR-Settings-Configuration-Commands-Tests-SaveConfigurationToFileCommandTests-BlankConfig 'MFR.Settings.Configuration.Commands.Tests.SaveConfigurationToFileCommandTests.BlankConfig')
  - [Test_SaveConfigurationToFile_Works_ForvalidInputs()](#M-MFR-Settings-Configuration-Commands-Tests-SaveConfigurationToFileCommandTests-Test_SaveConfigurationToFile_Works_ForvalidInputs 'MFR.Settings.Configuration.Commands.Tests.SaveConfigurationToFileCommandTests.Test_SaveConfigurationToFile_Works_ForvalidInputs')
- [SaveStringToRegistryCommandTests](#T-MFR-Settings-Configuration-Commands-Tests-SaveStringToRegistryCommandTests 'MFR.Settings.Configuration.Commands.Tests.SaveStringToRegistryCommandTests')
  - [Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry()](#M-MFR-Settings-Configuration-Commands-Tests-SaveStringToRegistryCommandTests-Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry 'MFR.Settings.Configuration.Commands.Tests.SaveStringToRegistryCommandTests.Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry')

<a name='T-MFR-Settings-Configuration-Commands-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Settings.Configuration.Commands.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Settings-Configuration-Commands-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Settings-Configuration-Commands-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Settings-Configuration-Commands-Tests-SaveConfigurationToFileCommandTests'></a>
## SaveConfigurationToFileCommandTests `type`

##### Namespace

MFR.Settings.Configuration.Commands.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[SaveConfigurationToFileCommand](#T-MFR-SaveConfigurationToFileCommand 'MFR.SaveConfigurationToFileCommand')
class.

##### Remarks

This class enables callers to provide a filename and a config
object reference, bundled together inside a File System Entry POCO, and
it is serialized to disk.

<a name='F-MFR-Settings-Configuration-Commands-Tests-SaveConfigurationToFileCommandTests-FILE_PATH'></a>
### FILE_PATH `constants`

##### Summary

File in the root of the C: drive where the data is to be saved.

<a name='P-MFR-Settings-Configuration-Commands-Tests-SaveConfigurationToFileCommandTests-BlankConfig'></a>
### BlankConfig `property`

##### Summary

Empty config object for testing.

<a name='M-MFR-Settings-Configuration-Commands-Tests-SaveConfigurationToFileCommandTests-Test_SaveConfigurationToFile_Works_ForvalidInputs'></a>
### Test_SaveConfigurationToFile_Works_ForvalidInputs() `method`

##### Summary

TODO: Add unit test documentation here

##### Parameters

This method has no parameters.

<a name='T-MFR-Settings-Configuration-Commands-Tests-SaveStringToRegistryCommandTests'></a>
## SaveStringToRegistryCommandTests `type`

##### Namespace

MFR.Settings.Configuration.Commands.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[SaveStringToRegistryCommand](#T-MFR-SaveStringToRegistryCommand 'MFR.SaveStringToRegistryCommand')
class.

<a name='M-MFR-Settings-Configuration-Commands-Tests-SaveStringToRegistryCommandTests-Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry'></a>
### Test_CanSuccessfullySave_AppConfigFilePath_ToRegistry() `method`

##### Summary

Asserts that the
[Execute](#M-MFR-LoadStringFromRegistryAction-Execute 'MFR.LoadStringFromRegistryAction.Execute')
method correctly loads a path from the system Registry.

##### Parameters

This method has no parameters.
