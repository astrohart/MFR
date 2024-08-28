<a name='assembly'></a>
# MFR.Tests.Common

## Contents

- [ConfigurationBuilder](#T-MFR-Tests-Common-ConfigurationBuilder 'MFR.Tests.Common.ConfigurationBuilder')
  - [#ctor()](#M-MFR-Tests-Common-ConfigurationBuilder-#ctor 'MFR.Tests.Common.ConfigurationBuilder.#ctor')
  - [_matchCase](#F-MFR-Tests-Common-ConfigurationBuilder-_matchCase 'MFR.Tests.Common.ConfigurationBuilder._matchCase')
  - [_matchExactWord](#F-MFR-Tests-Common-ConfigurationBuilder-_matchExactWord 'MFR.Tests.Common.ConfigurationBuilder._matchExactWord')
  - [Instance](#P-MFR-Tests-Common-ConfigurationBuilder-Instance 'MFR.Tests.Common.ConfigurationBuilder.Instance')
  - [#cctor()](#M-MFR-Tests-Common-ConfigurationBuilder-#cctor 'MFR.Tests.Common.ConfigurationBuilder.#cctor')
  - [AndSetMatchExactWord(matchExactWord)](#M-MFR-Tests-Common-ConfigurationBuilder-AndSetMatchExactWord-System-Boolean- 'MFR.Tests.Common.ConfigurationBuilder.AndSetMatchExactWord(System.Boolean)')
  - [Build()](#M-MFR-Tests-Common-ConfigurationBuilder-Build 'MFR.Tests.Common.ConfigurationBuilder.Build')
  - [BuildConfigurationForUseCase(matchCase,matchExactWord)](#M-MFR-Tests-Common-ConfigurationBuilder-BuildConfigurationForUseCase-System-Boolean,System-Boolean- 'MFR.Tests.Common.ConfigurationBuilder.BuildConfigurationForUseCase(System.Boolean,System.Boolean)')
  - [SetMatchCase(matchCase)](#M-MFR-Tests-Common-ConfigurationBuilder-SetMatchCase-System-Boolean- 'MFR.Tests.Common.ConfigurationBuilder.SetMatchCase(System.Boolean)')
- [RegistryDataExchangeTestsBase](#T-MFR-Tests-Common-RegistryDataExchangeTestsBase 'MFR.Tests.Common.RegistryDataExchangeTestsBase')
  - [COMPANY_NAME](#F-MFR-Tests-Common-RegistryDataExchangeTestsBase-COMPANY_NAME 'MFR.Tests.Common.RegistryDataExchangeTestsBase.COMPANY_NAME')
  - [CONFIG_FILE_NAME](#F-MFR-Tests-Common-RegistryDataExchangeTestsBase-CONFIG_FILE_NAME 'MFR.Tests.Common.RegistryDataExchangeTestsBase.CONFIG_FILE_NAME')
  - [DEFAULT_CONFIG_FILE_DIR](#F-MFR-Tests-Common-RegistryDataExchangeTestsBase-DEFAULT_CONFIG_FILE_DIR 'MFR.Tests.Common.RegistryDataExchangeTestsBase.DEFAULT_CONFIG_FILE_DIR')
  - [DEFAULT_CONFIG_FILE_PATH](#F-MFR-Tests-Common-RegistryDataExchangeTestsBase-DEFAULT_CONFIG_FILE_PATH 'MFR.Tests.Common.RegistryDataExchangeTestsBase.DEFAULT_CONFIG_FILE_PATH')
  - [KEY_PATH](#F-MFR-Tests-Common-RegistryDataExchangeTestsBase-KEY_PATH 'MFR.Tests.Common.RegistryDataExchangeTestsBase.KEY_PATH')
  - [PRODUCT_NAME](#F-MFR-Tests-Common-RegistryDataExchangeTestsBase-PRODUCT_NAME 'MFR.Tests.Common.RegistryDataExchangeTestsBase.PRODUCT_NAME')
  - [VALUE_NAME](#F-MFR-Tests-Common-RegistryDataExchangeTestsBase-VALUE_NAME 'MFR.Tests.Common.RegistryDataExchangeTestsBase.VALUE_NAME')
- [Resources](#T-MFR-Tests-Common-Properties-Resources 'MFR.Tests.Common.Properties.Resources')
  - [Culture](#P-MFR-Tests-Common-Properties-Resources-Culture 'MFR.Tests.Common.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Tests-Common-Properties-Resources-ResourceManager 'MFR.Tests.Common.Properties.Resources.ResourceManager')
- [StringConstants](#T-MFR-Tests-Common-StringConstants 'MFR.Tests.Common.StringConstants')
  - [DEVENV_FILENAME](#F-MFR-Tests-Common-StringConstants-DEVENV_FILENAME 'MFR.Tests.Common.StringConstants.DEVENV_FILENAME')
  - [DOTFOLDER_PATH_KNOWN_TO_EXIST](#F-MFR-Tests-Common-StringConstants-DOTFOLDER_PATH_KNOWN_TO_EXIST 'MFR.Tests.Common.StringConstants.DOTFOLDER_PATH_KNOWN_TO_EXIST')
  - [EMPTY_STRING](#F-MFR-Tests-Common-StringConstants-EMPTY_STRING 'MFR.Tests.Common.StringConstants.EMPTY_STRING')
  - [EXISTING_TEMP_FILE](#F-MFR-Tests-Common-StringConstants-EXISTING_TEMP_FILE 'MFR.Tests.Common.StringConstants.EXISTING_TEMP_FILE')
  - [EXISTING_TEMP_FILE_FILENAME_ONLY](#F-MFR-Tests-Common-StringConstants-EXISTING_TEMP_FILE_FILENAME_ONLY 'MFR.Tests.Common.StringConstants.EXISTING_TEMP_FILE_FILENAME_ONLY')
  - [FAKE_PROJECT_NAME_WITH_DOTS](#F-MFR-Tests-Common-StringConstants-FAKE_PROJECT_NAME_WITH_DOTS 'MFR.Tests.Common.StringConstants.FAKE_PROJECT_NAME_WITH_DOTS')
  - [FAKE_PROJECT_NAME_WITH_DOTS_EXACT_WORD_MATCH_REGEX](#F-MFR-Tests-Common-StringConstants-FAKE_PROJECT_NAME_WITH_DOTS_EXACT_WORD_MATCH_REGEX 'MFR.Tests.Common.StringConstants.FAKE_PROJECT_NAME_WITH_DOTS_EXACT_WORD_MATCH_REGEX')
  - [FILE_GUARANTEED_TO_EXIST](#F-MFR-Tests-Common-StringConstants-FILE_GUARANTEED_TO_EXIST 'MFR.Tests.Common.StringConstants.FILE_GUARANTEED_TO_EXIST')
  - [FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY](#F-MFR-Tests-Common-StringConstants-FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY 'MFR.Tests.Common.StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY')
  - [FILE_GUARANTEED_TO_EXIST_FILENAME_WITHOUT_EXTENSION](#F-MFR-Tests-Common-StringConstants-FILE_GUARANTEED_TO_EXIST_FILENAME_WITHOUT_EXTENSION 'MFR.Tests.Common.StringConstants.FILE_GUARANTEED_TO_EXIST_FILENAME_WITHOUT_EXTENSION')
  - [FILE_MATCHING_OPERATIONAL_CRITERIA](#F-MFR-Tests-Common-StringConstants-FILE_MATCHING_OPERATIONAL_CRITERIA 'MFR.Tests.Common.StringConstants.FILE_MATCHING_OPERATIONAL_CRITERIA')
  - [FOLDER_MATCHING_OPERATIONAL_CRITIERIA](#F-MFR-Tests-Common-StringConstants-FOLDER_MATCHING_OPERATIONAL_CRITIERIA 'MFR.Tests.Common.StringConstants.FOLDER_MATCHING_OPERATIONAL_CRITIERIA')
  - [FOLDER_THAT_IS_GUARANTEED_TO_EXIST](#F-MFR-Tests-Common-StringConstants-FOLDER_THAT_IS_GUARANTEED_TO_EXIST 'MFR.Tests.Common.StringConstants.FOLDER_THAT_IS_GUARANTEED_TO_EXIST')
  - [GIBBERISH](#F-MFR-Tests-Common-StringConstants-GIBBERISH 'MFR.Tests.Common.StringConstants.GIBBERISH')
  - [GITREPOS_GIT_DIR_PATH](#F-MFR-Tests-Common-StringConstants-GITREPOS_GIT_DIR_PATH 'MFR.Tests.Common.StringConstants.GITREPOS_GIT_DIR_PATH')
  - [GITREPOS_OBJ_FOLDER_PATH](#F-MFR-Tests-Common-StringConstants-GITREPOS_OBJ_FOLDER_PATH 'MFR.Tests.Common.StringConstants.GITREPOS_OBJ_FOLDER_PATH')
  - [GITREPOS_SOLUTION_PACKAGES_FOLDER_PATH](#F-MFR-Tests-Common-StringConstants-GITREPOS_SOLUTION_PACKAGES_FOLDER_PATH 'MFR.Tests.Common.StringConstants.GITREPOS_SOLUTION_PACKAGES_FOLDER_PATH')
  - [GITREPOS_SOLUTION_VS_DOTFOLDER_PATH](#F-MFR-Tests-Common-StringConstants-GITREPOS_SOLUTION_VS_DOTFOLDER_PATH 'MFR.Tests.Common.StringConstants.GITREPOS_SOLUTION_VS_DOTFOLDER_PATH')
  - [JUNK_SOLUTION_PROCESSORS_FACTORIES_CSPROJ_FILE_PATH](#F-MFR-Tests-Common-StringConstants-JUNK_SOLUTION_PROCESSORS_FACTORIES_CSPROJ_FILE_PATH 'MFR.Tests.Common.StringConstants.JUNK_SOLUTION_PROCESSORS_FACTORIES_CSPROJ_FILE_PATH')
  - [MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_FOLDER](#F-MFR-Tests-Common-StringConstants-MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_FOLDER 'MFR.Tests.Common.StringConstants.MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_FOLDER')
  - [MFR_TESTS_PROJECT_BIN_FOLDER_PATH](#F-MFR-Tests-Common-StringConstants-MFR_TESTS_PROJECT_BIN_FOLDER_PATH 'MFR.Tests.Common.StringConstants.MFR_TESTS_PROJECT_BIN_FOLDER_PATH')
  - [MFR_TESTS_PROJECT_OBJ_FOLDER_PATH](#F-MFR-Tests-Common-StringConstants-MFR_TESTS_PROJECT_OBJ_FOLDER_PATH 'MFR.Tests.Common.StringConstants.MFR_TESTS_PROJECT_OBJ_FOLDER_PATH')
  - [NEW_TEMP_FILE](#F-MFR-Tests-Common-StringConstants-NEW_TEMP_FILE 'MFR.Tests.Common.StringConstants.NEW_TEMP_FILE')
  - [NEW_TEMP_FILE_FILENAME_ONLY](#F-MFR-Tests-Common-StringConstants-NEW_TEMP_FILE_FILENAME_ONLY 'MFR.Tests.Common.StringConstants.NEW_TEMP_FILE_FILENAME_ONLY')
  - [NONEXISTENT_FILE](#F-MFR-Tests-Common-StringConstants-NONEXISTENT_FILE 'MFR.Tests.Common.StringConstants.NONEXISTENT_FILE')
  - [NONEXISTENT_FOLDER](#F-MFR-Tests-Common-StringConstants-NONEXISTENT_FOLDER 'MFR.Tests.Common.StringConstants.NONEXISTENT_FOLDER')
  - [NOTEPAD_PATH](#F-MFR-Tests-Common-StringConstants-NOTEPAD_PATH 'MFR.Tests.Common.StringConstants.NOTEPAD_PATH')
  - [NULL_STRING](#F-MFR-Tests-Common-StringConstants-NULL_STRING 'MFR.Tests.Common.StringConstants.NULL_STRING')
  - [PATHNAME_OF_DOTFILE](#F-MFR-Tests-Common-StringConstants-PATHNAME_OF_DOTFILE 'MFR.Tests.Common.StringConstants.PATHNAME_OF_DOTFILE')
  - [PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER](#F-MFR-Tests-Common-StringConstants-PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER 'MFR.Tests.Common.StringConstants.PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER')
  - [PATHNAME_OF_FILE_HAVING_NO_EXTENSION](#F-MFR-Tests-Common-StringConstants-PATHNAME_OF_FILE_HAVING_NO_EXTENSION 'MFR.Tests.Common.StringConstants.PATHNAME_OF_FILE_HAVING_NO_EXTENSION')
  - [PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER](#F-MFR-Tests-Common-StringConstants-PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER 'MFR.Tests.Common.StringConstants.PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER')
  - [PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER](#F-MFR-Tests-Common-StringConstants-PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER 'MFR.Tests.Common.StringConstants.PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER')
  - [PATHNAME_OF_FILE_LOCATED_IN_VS_DOTFOLDER](#F-MFR-Tests-Common-StringConstants-PATHNAME_OF_FILE_LOCATED_IN_VS_DOTFOLDER 'MFR.Tests.Common.StringConstants.PATHNAME_OF_FILE_LOCATED_IN_VS_DOTFOLDER')
  - [PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER](#F-MFR-Tests-Common-StringConstants-PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER 'MFR.Tests.Common.StringConstants.PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER')
  - [PORTFOLIO_MONITOR_SOLUTION_FOLDER_PATH](#F-MFR-Tests-Common-StringConstants-PORTFOLIO_MONITOR_SOLUTION_FOLDER_PATH 'MFR.Tests.Common.StringConstants.PORTFOLIO_MONITOR_SOLUTION_FOLDER_PATH')
  - [PORTFOLIO_MONITOR_X_UDL_FILE](#F-MFR-Tests-Common-StringConstants-PORTFOLIO_MONITOR_X_UDL_FILE 'MFR.Tests.Common.StringConstants.PORTFOLIO_MONITOR_X_UDL_FILE')
  - [PORTRFOLIO_MONITOR_VS_FOLDER_PATH](#F-MFR-Tests-Common-StringConstants-PORTRFOLIO_MONITOR_VS_FOLDER_PATH 'MFR.Tests.Common.StringConstants.PORTRFOLIO_MONITOR_VS_FOLDER_PATH')
  - [SUBFOLDER_OF_BIN_DIR](#F-MFR-Tests-Common-StringConstants-SUBFOLDER_OF_BIN_DIR 'MFR.Tests.Common.StringConstants.SUBFOLDER_OF_BIN_DIR')
  - [SUBFOLDER_OF_GIT_FOLDER](#F-MFR-Tests-Common-StringConstants-SUBFOLDER_OF_GIT_FOLDER 'MFR.Tests.Common.StringConstants.SUBFOLDER_OF_GIT_FOLDER')
  - [SUBFOLDER_OF_OBJ_FOLDER](#F-MFR-Tests-Common-StringConstants-SUBFOLDER_OF_OBJ_FOLDER 'MFR.Tests.Common.StringConstants.SUBFOLDER_OF_OBJ_FOLDER')
  - [SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER](#F-MFR-Tests-Common-StringConstants-SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER 'MFR.Tests.Common.StringConstants.SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER')
  - [SUBFOLDER_OF_VS_DOTFOLDER](#F-MFR-Tests-Common-StringConstants-SUBFOLDER_OF_VS_DOTFOLDER 'MFR.Tests.Common.StringConstants.SUBFOLDER_OF_VS_DOTFOLDER')
  - [WHITESPACE](#F-MFR-Tests-Common-StringConstants-WHITESPACE 'MFR.Tests.Common.StringConstants.WHITESPACE')
  - [WINDOWS_SYSTEM_FOLDER](#F-MFR-Tests-Common-StringConstants-WINDOWS_SYSTEM_FOLDER 'MFR.Tests.Common.StringConstants.WINDOWS_SYSTEM_FOLDER')
  - [MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH](#P-MFR-Tests-Common-StringConstants-MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH 'MFR.Tests.Common.StringConstants.MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH')

<a name='T-MFR-Tests-Common-ConfigurationBuilder'></a>
## ConfigurationBuilder `type`

##### Namespace

MFR.Tests.Common

##### Summary

Builds instances of fake
[ProjectFileRenamerConfig](#T-MFR-Settings-Configuration-ProjectFileRenamerConfig 'MFR.Settings.Configuration.ProjectFileRenamerConfig')
objects in a fluent
manner, initialized for unit tests.

<a name='M-MFR-Tests-Common-ConfigurationBuilder-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-MFR-Tests-Common-ConfigurationBuilder-_matchCase'></a>
### _matchCase `constants`

##### Summary

Determines whether the case should be matched during a search for a string.

<a name='F-MFR-Tests-Common-ConfigurationBuilder-_matchExactWord'></a>
### _matchExactWord `constants`

##### Summary

Determines whether a whole word should be matched when searching for
a string value.

<a name='P-MFR-Tests-Common-ConfigurationBuilder-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[ConfigurationBuilder](#T-MFR-Tests-Common-ConfigurationBuilder 'MFR.Tests.Common.ConfigurationBuilder').

<a name='M-MFR-Tests-Common-ConfigurationBuilder-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Tests-Common-ConfigurationBuilder-AndSetMatchExactWord-System-Boolean-'></a>
### AndSetMatchExactWord(matchExactWord) `method`

##### Summary

Sets the value of the
[_matchExactWord](#F-MFR-Tests-Common-ConfigurationBuilder-_matchExactWord 'MFR.Tests.Common.ConfigurationBuilder._matchExactWord')
field to the value of the `matchExactWord` parameter.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchExactWord | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) New value for the
[_matchExactWord](#F-MFR-Tests-Common-ConfigurationBuilder-_matchExactWord 'MFR.Tests.Common.ConfigurationBuilder._matchExactWord')
field. Default is `true`. |

<a name='M-MFR-Tests-Common-ConfigurationBuilder-Build'></a>
### Build() `method`

##### Summary

Creates a new instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile')
interface and returns a
reference to it.

##### Returns

Reference to an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile')
interface.

##### Parameters

This method has no parameters.

##### Remarks

The new instance's properties are initialized with the values
provided to this class' other methods.

<a name='M-MFR-Tests-Common-ConfigurationBuilder-BuildConfigurationForUseCase-System-Boolean,System-Boolean-'></a>
### BuildConfigurationForUseCase(matchCase,matchExactWord) `method`

##### Summary

Provides an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile')
interface with its
`matchCase`
and `matchExactWord` settings
configured as specified for the current use case.

##### Returns

Reference to an instance of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile')
interface whose
[IConfigurationMatchCase](#P-MFR-Settings-Configuration-Interfaces-IConfigurationMatchCase 'MFR.Settings.Configuration.Interfaces.IConfigurationMatchCase')
and
[IConfigurationMatchExactWord](#P-MFR-Settings-Configuration-Interfaces-IConfigurationMatchExactWord 'MFR.Settings.Configuration.Interfaces.IConfigurationMatchExactWord')
properties are set to the same values as were passed for the
`matchCase` and `matchExactWord`
parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) Specifies whether the case is matched when searching and replacing. |
| matchExactWord | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Required.) Specifies whether search text must be a part of another
word or pattern or can only be matched if it consists of a whole word. |

<a name='M-MFR-Tests-Common-ConfigurationBuilder-SetMatchCase-System-Boolean-'></a>
### SetMatchCase(matchCase) `method`

##### Summary

Sets the value of the
[_matchCase](#F-MFR-Tests-Common-ConfigurationBuilder-_matchCase 'MFR.Tests.Common.ConfigurationBuilder._matchCase')
field to the value of the `matchCase` parameter.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| matchCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) New value for the
[_matchCase](#F-MFR-Tests-Common-ConfigurationBuilder-_matchCase 'MFR.Tests.Common.ConfigurationBuilder._matchCase')
field. Default is `true.` |

<a name='T-MFR-Tests-Common-RegistryDataExchangeTestsBase'></a>
## RegistryDataExchangeTestsBase `type`

##### Namespace

MFR.Tests.Common

##### Summary

Defines the events, methods, properties, and behaviors for all unit test
fixtures that test methods and objects that perform data exchange to and from
the system Registry.

<a name='F-MFR-Tests-Common-RegistryDataExchangeTestsBase-COMPANY_NAME'></a>
### COMPANY_NAME `constants`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the name of the company that
is associated with the application.

<a name='F-MFR-Tests-Common-RegistryDataExchangeTestsBase-CONFIG_FILE_NAME'></a>
### CONFIG_FILE_NAME `constants`

##### Summary

String containing the name of a config file.

<a name='F-MFR-Tests-Common-RegistryDataExchangeTestsBase-DEFAULT_CONFIG_FILE_DIR'></a>
### DEFAULT_CONFIG_FILE_DIR `constants`

##### Summary

String containing the fully-qualified pathname of a folder that stores the
config file.

<a name='F-MFR-Tests-Common-RegistryDataExchangeTestsBase-DEFAULT_CONFIG_FILE_PATH'></a>
### DEFAULT_CONFIG_FILE_PATH `constants`

##### Summary

String containing the fully-qualified pathname of the master
config file.

##### Remarks

The master config file is defined to be that file, containing
a JSON representation of an object that implements the
[IProfile](#T-MFR-Settings-Profiles-Interfaces-IProfile 'MFR.Settings.Profiles.Interfaces.IProfile')
interface, exists
in the centralized location that is used by the application.



(Other such files may exist, but these are exports/imports.)

<a name='F-MFR-Tests-Common-RegistryDataExchangeTestsBase-KEY_PATH'></a>
### KEY_PATH `constants`

##### Summary

Fully-qualified pathname to where we expect that the path to the
config file has been written to.

<a name='F-MFR-Tests-Common-RegistryDataExchangeTestsBase-PRODUCT_NAME'></a>
### PRODUCT_NAME `constants`

##### Summary

Gets a [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the product name that is
associated with the application.

<a name='F-MFR-Tests-Common-RegistryDataExchangeTestsBase-VALUE_NAME'></a>
### VALUE_NAME `constants`

##### Summary

Name of the Registry value under which the path to the application's
config file is to be stored.

<a name='T-MFR-Tests-Common-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Tests.Common.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Tests-Common-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Tests-Common-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-MFR-Tests-Common-StringConstants'></a>
## StringConstants `type`

##### Namespace

MFR.Tests.Common

##### Summary

Common string constants for use in unit tests.

<a name='F-MFR-Tests-Common-StringConstants-DEVENV_FILENAME'></a>
### DEVENV_FILENAME `constants`

##### Summary

The executable filename of the DevEnv (Visual Studio) application.

<a name='F-MFR-Tests-Common-StringConstants-DOTFOLDER_PATH_KNOWN_TO_EXIST'></a>
### DOTFOLDER_PATH_KNOWN_TO_EXIST `constants`

##### Summary

String containing the path to a 'dotfolder' -- i.e., a folder whose
name starts with a dot.

##### Remarks

Here, we pass the location of the .android folder, which is
guaranteed to be exist under the %USERPROFILE% folder since the
Visual Studio IDE is installed.

<a name='F-MFR-Tests-Common-StringConstants-EMPTY_STRING'></a>
### EMPTY_STRING `constants`

##### Summary

Constant whose value is the empty string.

<a name='F-MFR-Tests-Common-StringConstants-EXISTING_TEMP_FILE'></a>
### EXISTING_TEMP_FILE `constants`

##### Summary

String consisting of the fully-qualified pathname of a
randomly-created, zero-length temporary file.

<a name='F-MFR-Tests-Common-StringConstants-EXISTING_TEMP_FILE_FILENAME_ONLY'></a>
### EXISTING_TEMP_FILE_FILENAME_ONLY `constants`

##### Summary

String consisting of the same value as the
[EXISTING_TEMP_FILE](#F-MFR-Tests-Common-StringConstants-EXISTING_TEMP_FILE 'MFR.Tests.Common.StringConstants.EXISTING_TEMP_FILE')
constant, but only containing the filename and extension of the file
instead of the full path.

<a name='F-MFR-Tests-Common-StringConstants-FAKE_PROJECT_NAME_WITH_DOTS'></a>
### FAKE_PROJECT_NAME_WITH_DOTS `constants`

##### Summary

String that contains a fake project name.

<a name='F-MFR-Tests-Common-StringConstants-FAKE_PROJECT_NAME_WITH_DOTS_EXACT_WORD_MATCH_REGEX'></a>
### FAKE_PROJECT_NAME_WITH_DOTS_EXACT_WORD_MATCH_REGEX `constants`

##### Summary

String containing a regex searching for the
[FAKE_PROJECT_NAME_WITH_DOTS](#F-MFR-Tests-Common-StringConstants-FAKE_PROJECT_NAME_WITH_DOTS 'MFR.Tests.Common.StringConstants.FAKE_PROJECT_NAME_WITH_DOTS')
constant's value as an exact-word match.

<a name='F-MFR-Tests-Common-StringConstants-FILE_GUARANTEED_TO_EXIST'></a>
### FILE_GUARANTEED_TO_EXIST `constants`

##### Summary

String consisting of the path to a file that is guaranteed to exist
on the local machine.

##### Remarks

We started by making this constant equal to the path to `NOTEPAD.EXE`,
which we know is installed with every version and edition of Windows.

<a name='F-MFR-Tests-Common-StringConstants-FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY'></a>
### FILE_GUARANTEED_TO_EXIST_FILENAME_ONLY `constants`

##### Summary

String consisting of the same text as the
[FILE_GUARANTEED_TO_EXIST](#F-MFR-Tests-Common-StringConstants-FILE_GUARANTEED_TO_EXIST 'MFR.Tests.Common.StringConstants.FILE_GUARANTEED_TO_EXIST')
constant, but with just a filename and extension.

<a name='F-MFR-Tests-Common-StringConstants-FILE_GUARANTEED_TO_EXIST_FILENAME_WITHOUT_EXTENSION'></a>
### FILE_GUARANTEED_TO_EXIST_FILENAME_WITHOUT_EXTENSION `constants`

##### Summary

String consisting of the filename and extension only of the
[FILE_GUARANTEED_TO_EXIST](#F-MFR-Tests-Common-StringConstants-FILE_GUARANTEED_TO_EXIST 'MFR.Tests.Common.StringConstants.FILE_GUARANTEED_TO_EXIST')
constant.

<a name='F-MFR-Tests-Common-StringConstants-FILE_MATCHING_OPERATIONAL_CRITERIA'></a>
### FILE_MATCHING_OPERATIONAL_CRITERIA `constants`

##### Summary

String containing the fully-qualified pathname of a file that
matches the criteria for operating upon.

##### Remarks

This constant must always be set to the path of a project (*.csproj)
file that actually exists.

<a name='F-MFR-Tests-Common-StringConstants-FOLDER_MATCHING_OPERATIONAL_CRITIERIA'></a>
### FOLDER_MATCHING_OPERATIONAL_CRITIERIA `constants`

##### Summary

String containing the path of a folder that the RenameSubFolder
operation would consider fair game for acting upon.

##### Remarks

This constant must always be set to the path of a project folder
that exists.

<a name='F-MFR-Tests-Common-StringConstants-FOLDER_THAT_IS_GUARANTEED_TO_EXIST'></a>
### FOLDER_THAT_IS_GUARANTEED_TO_EXIST `constants`

##### Summary

String containing the path to a folder that is guaranteed to exist.

<a name='F-MFR-Tests-Common-StringConstants-GIBBERISH'></a>
### GIBBERISH `constants`

##### Summary

String consisting of complete gibberish.

<a name='F-MFR-Tests-Common-StringConstants-GITREPOS_GIT_DIR_PATH'></a>
### GITREPOS_GIT_DIR_PATH `constants`

##### Summary

String containing the fully-qualified pathname of the `.git` dotfolder
under the `xyLOGIX.Interop.GitRepos` solution folder.

<a name='F-MFR-Tests-Common-StringConstants-GITREPOS_OBJ_FOLDER_PATH'></a>
### GITREPOS_OBJ_FOLDER_PATH `constants`

##### Summary

String containing the fully-qualified pathname of a `obj` folder in the
`xyLOGIX.Interop.GitRepos` project.

<a name='F-MFR-Tests-Common-StringConstants-GITREPOS_SOLUTION_PACKAGES_FOLDER_PATH'></a>
### GITREPOS_SOLUTION_PACKAGES_FOLDER_PATH `constants`

##### Summary

String containing the fully-qualified pathname of the `packages` folder
for the `xyLOGIX.Interop.GitRepos`
solution.

<a name='F-MFR-Tests-Common-StringConstants-GITREPOS_SOLUTION_VS_DOTFOLDER_PATH'></a>
### GITREPOS_SOLUTION_VS_DOTFOLDER_PATH `constants`

##### Summary

String containing the fully-qualified pathname of the `.vs` dotfolder of
the `xyLOGIX.Interop.GitRepos` solution.

<a name='F-MFR-Tests-Common-StringConstants-JUNK_SOLUTION_PROCESSORS_FACTORIES_CSPROJ_FILE_PATH'></a>
### JUNK_SOLUTION_PROCESSORS_FACTORIES_CSPROJ_FILE_PATH `constants`

##### Summary

String containing the path to a .csproj file in the Junk Solution
that has factory objects.

<a name='F-MFR-Tests-Common-StringConstants-MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_FOLDER'></a>
### MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_FOLDER `constants`

##### Summary

String containing the path of the folder in which the MFR project
solution file lives.

<a name='F-MFR-Tests-Common-StringConstants-MFR_TESTS_PROJECT_BIN_FOLDER_PATH'></a>
### MFR_TESTS_PROJECT_BIN_FOLDER_PATH `constants`

##### Summary

String containing the fully-qualified pathname of a `bin\`
folder in a project.

<a name='F-MFR-Tests-Common-StringConstants-MFR_TESTS_PROJECT_OBJ_FOLDER_PATH'></a>
### MFR_TESTS_PROJECT_OBJ_FOLDER_PATH `constants`

##### Summary

String containing the fully-qualified pathname of a `obj\`
folder in the `MFR.Tests` project.

<a name='F-MFR-Tests-Common-StringConstants-NEW_TEMP_FILE'></a>
### NEW_TEMP_FILE `constants`

##### Summary

String consisting of the fully-qualified pathname of a
randomly-created, zero-length temporary file that is to be used in a
file-rename operation test.

<a name='F-MFR-Tests-Common-StringConstants-NEW_TEMP_FILE_FILENAME_ONLY'></a>
### NEW_TEMP_FILE_FILENAME_ONLY `constants`

##### Summary

String consisting of the same value as the
[NEW_TEMP_FILE](#F-MFR-Tests-Common-StringConstants-NEW_TEMP_FILE 'MFR.Tests.Common.StringConstants.NEW_TEMP_FILE')
constant, but only containing the filename and extension of the file
instead of the full path.

<a name='F-MFR-Tests-Common-StringConstants-NONEXISTENT_FILE'></a>
### NONEXISTENT_FILE `constants`

##### Summary

String consisting of the path to a file. The path contains only
unique identifiers for folder and filename components -- which are
regenerated each time this constant is referred to --so the file
referenced is, more or less, guaranteed not to exist on the file system.

<a name='F-MFR-Tests-Common-StringConstants-NONEXISTENT_FOLDER'></a>
### NONEXISTENT_FOLDER `constants`

##### Summary

String consisting of the path to a folder that we can guarantee will
not exist on the system.

<a name='F-MFR-Tests-Common-StringConstants-NOTEPAD_PATH'></a>
### NOTEPAD_PATH `constants`

##### Summary

String containing the path to the Windows Notepad utility.

<a name='F-MFR-Tests-Common-StringConstants-NULL_STRING'></a>
### NULL_STRING `constants`

##### Summary

Constant whose value is the null string.

<a name='F-MFR-Tests-Common-StringConstants-PATHNAME_OF_DOTFILE'></a>
### PATHNAME_OF_DOTFILE `constants`

##### Summary

String containing the fully-qualified pathname of a file in the
%USERPROFILE% folder whose name begins with a period (dot).

<a name='F-MFR-Tests-Common-StringConstants-PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER'></a>
### PATHNAME_OF_FILE_CONTAINED_IN_PROJECT_OBJ_FOLDER `constants`

##### Summary

String containing the fully-qualified pathname of a file that is
inside the `obj\` folder of a project.

<a name='F-MFR-Tests-Common-StringConstants-PATHNAME_OF_FILE_HAVING_NO_EXTENSION'></a>
### PATHNAME_OF_FILE_HAVING_NO_EXTENSION `constants`

##### Summary

String containing the fully-qualified pathname of a file that has no extension.

<a name='F-MFR-Tests-Common-StringConstants-PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER'></a>
### PATHNAME_OF_FILE_LOCATED_IN_BIN_FOLDER `constants`

##### Summary

String containing the fully-qualified pathname of a file that is in
a `bin\` folder of a particular project.

<a name='F-MFR-Tests-Common-StringConstants-PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER'></a>
### PATHNAME_OF_FILE_LOCATED_IN_GIT_DOTFOLDER `constants`

##### Summary

String containing the fully-qualified pathname of one of the index
files that are commonly found in a Git repository's `.git\` dotfolder.

<a name='F-MFR-Tests-Common-StringConstants-PATHNAME_OF_FILE_LOCATED_IN_VS_DOTFOLDER'></a>
### PATHNAME_OF_FILE_LOCATED_IN_VS_DOTFOLDER `constants`

##### Summary

String containing the fully-qualified pathname of a file that is
located within the `.vs\` dotfolder of a solution.

<a name='F-MFR-Tests-Common-StringConstants-PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER'></a>
### PATHNAME_TO_FILE_CONTAINED_IN_PACKAGES_FOLDER `constants`

##### Summary

String containing the fully-qualified pathname of a file that is
located within the `packages` subfolder of a solution.

<a name='F-MFR-Tests-Common-StringConstants-PORTFOLIO_MONITOR_SOLUTION_FOLDER_PATH'></a>
### PORTFOLIO_MONITOR_SOLUTION_FOLDER_PATH `constants`

##### Summary

String containing the fully-qualified pathname of the solution folder for the
`PortfolioMonitor` solution.

<a name='F-MFR-Tests-Common-StringConstants-PORTFOLIO_MONITOR_X_UDL_FILE'></a>
### PORTFOLIO_MONITOR_X_UDL_FILE `constants`

##### Summary

String containing the path to the file `x.udl` under the
Portfolio Monitor solution folder.

<a name='F-MFR-Tests-Common-StringConstants-PORTRFOLIO_MONITOR_VS_FOLDER_PATH'></a>
### PORTRFOLIO_MONITOR_VS_FOLDER_PATH `constants`

##### Summary

String containing the fully-qualified pathname of the `.vs` dotfolder for
the `PortfolioMonitor` solution.

<a name='F-MFR-Tests-Common-StringConstants-SUBFOLDER_OF_BIN_DIR'></a>
### SUBFOLDER_OF_BIN_DIR `constants`

##### Summary

String consisting of the path to a subfolder of a project's \bin folder.

<a name='F-MFR-Tests-Common-StringConstants-SUBFOLDER_OF_GIT_FOLDER'></a>
### SUBFOLDER_OF_GIT_FOLDER `constants`

##### Summary

String containing the fully-qualified pathname of a subfolder of the
`.git\` folder of a solution.

<a name='F-MFR-Tests-Common-StringConstants-SUBFOLDER_OF_OBJ_FOLDER'></a>
### SUBFOLDER_OF_OBJ_FOLDER `constants`

##### Summary

String consisting of the path to a subfolder of a project's
`obj\` subfolder.

<a name='F-MFR-Tests-Common-StringConstants-SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER'></a>
### SUBFOLDER_OF_SOLUTION_PACKAGES_FOLDER `constants`

##### Summary

String consisting of the path to a subfolder of the `packages\`
folder of a solution.

<a name='F-MFR-Tests-Common-StringConstants-SUBFOLDER_OF_VS_DOTFOLDER'></a>
### SUBFOLDER_OF_VS_DOTFOLDER `constants`

##### Summary

String consisting of the path to a subfolder of a solution's '\.vs' dotfolder.

<a name='F-MFR-Tests-Common-StringConstants-WHITESPACE'></a>
### WHITESPACE `constants`

##### Summary

Constant containing whitespace (three spaces and a tab character).

<a name='F-MFR-Tests-Common-StringConstants-WINDOWS_SYSTEM_FOLDER'></a>
### WINDOWS_SYSTEM_FOLDER `constants`

##### Summary

String consisting of the path to the Windows System32 folder.

<a name='P-MFR-Tests-Common-StringConstants-MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH'></a>
### MASS_FILE_RENAMER_VISUAL_STUDIO_SOLUTION_PATH `property`

##### Summary

String containing the path to the .sln file for the Mass File
Renamer project.
