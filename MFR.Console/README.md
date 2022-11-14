<a name='assembly'></a>
# mfrc

## Contents

- [Program](#T-MFR-Console-Program 'MFR.Console.Program')
  - [CommandLineParser](#P-MFR-Console-Program-CommandLineParser 'MFR.Console.Program.CommandLineParser')
  - [Configuration](#P-MFR-Console-Program-Configuration 'MFR.Console.Program.Configuration')
  - [ConfigurationProvider](#P-MFR-Console-Program-ConfigurationProvider 'MFR.Console.Program.ConfigurationProvider')
  - [FileRenamer](#P-MFR-Console-Program-FileRenamer 'MFR.Console.Program.FileRenamer')
  - [Main()](#M-MFR-Console-Program-Main-System-String[]- 'MFR.Console.Program.Main(System.String[])')

<a name='T-MFR-Console-Program'></a>
## Program `type`

##### Namespace

MFR.Console

##### Summary

Provides the application-level functionality.

<a name='P-MFR-Console-Program-CommandLineParser'></a>
### CommandLineParser `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ICommandLineParser](#T-MFR-CommandLine-Parsers-Interfaces-ICommandLineParser 'MFR.CommandLine.Parsers.Interfaces.ICommandLineParser')
interface.

<a name='P-MFR-Console-Program-Configuration'></a>
### Configuration `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IConfiguration](#T-MFR-Settings-Configuration-Interfaces-IConfiguration 'MFR.Settings.Configuration.Interfaces.IConfiguration')
interface.

<a name='P-MFR-Console-Program-ConfigurationProvider'></a>
### ConfigurationProvider `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IConfigurationProvider](#T-MFR-Settings-Configuration-Providers-Interfaces-IConfigurationProvider 'MFR.Settings.Configuration.Providers.Interfaces.IConfigurationProvider')
interface.

<a name='P-MFR-Console-Program-FileRenamer'></a>
### FileRenamer `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IFileRenamer](#T-MFR-Renamers-Files-Interfaces-IFileRenamer 'MFR.Renamers.Files.Interfaces.IFileRenamer') interface.

<a name='M-MFR-Console-Program-Main-System-String[]-'></a>
### Main() `method`

##### Summary

Application entry point.

##### Parameters

This method has no parameters.
