<a name='assembly'></a>
# MFR.FileSystem.Win32

## Contents

- [NativeMethods](#T-MFR-FileSystem-Win32-NativeMethods 'MFR.FileSystem.Win32.NativeMethods')
  - [MAX_LENGTH](#F-MFR-FileSystem-Win32-NativeMethods-MAX_LENGTH 'MFR.FileSystem.Win32.NativeMethods.MAX_LENGTH')
  - [PathCompactPathEx(path)](#M-MFR-FileSystem-Win32-NativeMethods-PathCompactPathEx-System-String- 'MFR.FileSystem.Win32.NativeMethods.PathCompactPathEx(System.String)')
  - [PathCompactPathEx(pszOut,szPath,cchMax,dwFlags)](#M-MFR-FileSystem-Win32-NativeMethods-PathCompactPathEx-System-Text-StringBuilder,System-String,System-Int32,System-Int32- 'MFR.FileSystem.Win32.NativeMethods.PathCompactPathEx(System.Text.StringBuilder,System.String,System.Int32,System.Int32)')
- [Resources](#T-MFR-FileSystem-Win32-Properties-Resources 'MFR.FileSystem.Win32.Properties.Resources')
  - [Culture](#P-MFR-FileSystem-Win32-Properties-Resources-Culture 'MFR.FileSystem.Win32.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-FileSystem-Win32-Properties-Resources-ResourceManager 'MFR.FileSystem.Win32.Properties.Resources.ResourceManager')

<a name='T-MFR-FileSystem-Win32-NativeMethods'></a>
## NativeMethods `type`

##### Namespace

MFR.FileSystem.Win32

##### Summary

Definitions of native Win32 API method calls that can be used to activate
functionality found in the Microsoft Windows operating system.

<a name='F-MFR-FileSystem-Win32-NativeMethods-MAX_LENGTH'></a>
### MAX_LENGTH `constants`

##### Summary

Gets the maximum length of a shortened path, in characters, not counting the
terminating null character.

<a name='M-MFR-FileSystem-Win32-NativeMethods-PathCompactPathEx-System-String-'></a>
### PathCompactPathEx(path) `method`

##### Summary

Truncates a path to fit within a certain number of characters by replacing path
components with ellipses.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the truncated path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname to be truncated. |

<a name='M-MFR-FileSystem-Win32-NativeMethods-PathCompactPathEx-System-Text-StringBuilder,System-String,System-Int32,System-Int32-'></a>
### PathCompactPathEx(pszOut,szPath,cchMax,dwFlags) `method`

##### Summary

Truncates a path to fit within a certain number of characters by replacing path
components with ellipses.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pszOut | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | (Required.) A [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder')
that receives the result. |
| szPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains
the pathname to be truncated. |
| cchMax | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) The maximum number of characters to be
contained in the new [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String'), including the terminating
null character. For example, if `cchMax` = 8, the resulting
[String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') can contain a maximum of 7 characters plus the
terminating null character. |
| dwFlags | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) Reserved.  Set to zero. |

<a name='T-MFR-FileSystem-Win32-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.FileSystem.Win32.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-FileSystem-Win32-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-FileSystem-Win32-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
