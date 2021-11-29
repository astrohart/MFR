<a name='assembly'></a>
# MFR.Registry.Helpers.Tests

## Contents

- [RegistryHiveExtensionsTests](#T-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests')
  - [CLASSES_ROOT_HIVE_NAME](#F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-CLASSES_ROOT_HIVE_NAME 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests.CLASSES_ROOT_HIVE_NAME')
  - [CURRENT_CONFIG_HIVE_NAME](#F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-CURRENT_CONFIG_HIVE_NAME 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests.CURRENT_CONFIG_HIVE_NAME')
  - [CURRENT_USER_HIVE_NAME](#F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-CURRENT_USER_HIVE_NAME 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests.CURRENT_USER_HIVE_NAME')
  - [DYN_DATA_HIVE_NAME](#F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-DYN_DATA_HIVE_NAME 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests.DYN_DATA_HIVE_NAME')
  - [FAKE_KEY_PATH](#F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-FAKE_KEY_PATH 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests.FAKE_KEY_PATH')
  - [LOCAL_MACHINE_HIVE_NAME](#F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-LOCAL_MACHINE_HIVE_NAME 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests.LOCAL_MACHINE_HIVE_NAME')
  - [PERFORMANCE_DATA_HIVE_NAME](#F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-PERFORMANCE_DATA_HIVE_NAME 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests.PERFORMANCE_DATA_HIVE_NAME')
  - [USERS_HIVE_NAME](#F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-USERS_HIVE_NAME 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests.USERS_HIVE_NAME')
  - [Test_RemoveRegistryHive_Method_Works()](#M-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-Test_RemoveRegistryHive_Method_Works 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests.Test_RemoveRegistryHive_Method_Works')
  - [Test_ToRegistryHive_Method_ReturnsCorrectValue_ForAllValidInputs()](#M-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-Test_ToRegistryHive_Method_ReturnsCorrectValue_ForAllValidInputs 'MFR.Registry.Helpers.Tests.RegistryHiveExtensionsTests.Test_ToRegistryHive_Method_ReturnsCorrectValue_ForAllValidInputs')
- [Resources](#T-MFR-Registry-Helpers-Tests-Properties-Resources 'MFR.Registry.Helpers.Tests.Properties.Resources')
  - [Culture](#P-MFR-Registry-Helpers-Tests-Properties-Resources-Culture 'MFR.Registry.Helpers.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Registry-Helpers-Tests-Properties-Resources-ResourceManager 'MFR.Registry.Helpers.Tests.Properties.Resources.ResourceManager')

<a name='T-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests'></a>
## RegistryHiveExtensionsTests `type`

##### Namespace

MFR.Registry.Helpers.Tests

##### Summary

Provides unit tests for the methods, properties, and events of the
[RegistryHiveExtensions](#T-MFR-RegistryHiveExtensions 'MFR.RegistryHiveExtensions')
class.

<a name='F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-CLASSES_ROOT_HIVE_NAME'></a>
### CLASSES_ROOT_HIVE_NAME `constants`

##### Summary

String containing the name of the `HKEY_CLASSES_ROOT` Registry hive.

<a name='F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-CURRENT_CONFIG_HIVE_NAME'></a>
### CURRENT_CONFIG_HIVE_NAME `constants`

##### Summary

String containing the name of the `HKEY_CURRENT_CONFIG`
Registry hive.

<a name='F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-CURRENT_USER_HIVE_NAME'></a>
### CURRENT_USER_HIVE_NAME `constants`

##### Summary

String containing the name of the `HKEY_CURRENT_USER` Registry hive.

<a name='F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-DYN_DATA_HIVE_NAME'></a>
### DYN_DATA_HIVE_NAME `constants`

##### Summary

String containing the name of the `HKEY_DYN_DATA` Registry hive.

<a name='F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-FAKE_KEY_PATH'></a>
### FAKE_KEY_PATH `constants`

##### Summary

String containing the path to a fake key in the system Registry.

<a name='F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-LOCAL_MACHINE_HIVE_NAME'></a>
### LOCAL_MACHINE_HIVE_NAME `constants`

##### Summary

String containing the name of the `HKEY_LOCAL_MACHINE` Registry hive.

<a name='F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-PERFORMANCE_DATA_HIVE_NAME'></a>
### PERFORMANCE_DATA_HIVE_NAME `constants`

##### Summary

String containing the name of the `HKEY_PERFORMANCE_DATA`
Registry hive.

<a name='F-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-USERS_HIVE_NAME'></a>
### USERS_HIVE_NAME `constants`

##### Summary

String containing the name of the `HKEY_USERS` Registry hive.

<a name='M-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-Test_RemoveRegistryHive_Method_Works'></a>
### Test_RemoveRegistryHive_Method_Works() `method`

##### Summary

Asserts that the
[RemoveHiveName](#M-MFR-RegistryHiveExtensions-RemoveHiveName 'MFR.RegistryHiveExtensions.RemoveHiveName')
method correctly strips the hive name from a fake path to a Registry
key under HKEY_CURRENT_USER.

##### Parameters

This method has no parameters.

<a name='M-MFR-Registry-Helpers-Tests-RegistryHiveExtensionsTests-Test_ToRegistryHive_Method_ReturnsCorrectValue_ForAllValidInputs'></a>
### Test_ToRegistryHive_Method_ReturnsCorrectValue_ForAllValidInputs() `method`

##### Summary

Asserts that the
[ToRegistryHive](#M-MFR-RegistryHiveExtensions-ToRegistryHive 'MFR.RegistryHiveExtensions.ToRegistryHive')
string extension method returns the correct
[RegistryHive](#T-Microsoft-Win32-RegistryHive 'Microsoft.Win32.RegistryHive')
enumeration value for the
string it is given as valid input.

##### Parameters

This method has no parameters.

<a name='T-MFR-Registry-Helpers-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Registry.Helpers.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Registry-Helpers-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Registry-Helpers-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
