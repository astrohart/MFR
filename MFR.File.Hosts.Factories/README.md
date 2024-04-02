<a name='assembly'></a>
# MFR.File.Hosts.Factories

## Contents

- [MakeNewFileHost](#T-MFR-File-Hosts-Factories-MakeNewFileHost 'MFR.File.Hosts.Factories.MakeNewFileHost')
  - [AndStream(self,stream)](#M-MFR-File-Hosts-Factories-MakeNewFileHost-AndStream-MFR-File-Hosts-Interfaces-IFileHost,System-IO-Stream- 'MFR.File.Hosts.Factories.MakeNewFileHost.AndStream(MFR.File.Hosts.Interfaces.IFileHost,System.IO.Stream)')
  - [ForPath(path)](#M-MFR-File-Hosts-Factories-MakeNewFileHost-ForPath-System-String- 'MFR.File.Hosts.Factories.MakeNewFileHost.ForPath(System.String)')
  - [HavingEncoding(self,encoding)](#M-MFR-File-Hosts-Factories-MakeNewFileHost-HavingEncoding-MFR-File-Hosts-Interfaces-IFileHost,System-Text-Encoding- 'MFR.File.Hosts.Factories.MakeNewFileHost.HavingEncoding(MFR.File.Hosts.Interfaces.IFileHost,System.Text.Encoding)')
- [Resources](#T-MFR-File-Hosts-Factories-Properties-Resources 'MFR.File.Hosts.Factories.Properties.Resources')
  - [Culture](#P-MFR-File-Hosts-Factories-Properties-Resources-Culture 'MFR.File.Hosts.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-File-Hosts-Factories-Properties-Resources-ResourceManager 'MFR.File.Hosts.Factories.Properties.Resources.ResourceManager')

<a name='T-MFR-File-Hosts-Factories-MakeNewFileHost'></a>
## MakeNewFileHost `type`

##### Namespace

MFR.File.Hosts.Factories

##### Summary

Creates new instances of objects that implement the
[IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost') interface, and returns
references to them.

<a name='M-MFR-File-Hosts-Factories-MakeNewFileHost-AndStream-MFR-File-Hosts-Interfaces-IFileHost,System-IO-Stream-'></a>
### AndStream(self,stream) `method`

##### Summary

Builder extension method that initializes the
[Stream](#P-MFR-File-Hosts-Interfaces-IFileHost-Stream 'MFR.File.Hosts.Interfaces.IFileHost.Stream')
property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.File.Hosts.Interfaces.IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost') | (Required.) Reference to an instance of an object that implements
the
[IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost')
interface. |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | (Required.) Reference to an instance of [Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') that
is currently open on the file having the path specified. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='M-MFR-File-Hosts-Factories-MakeNewFileHost-ForPath-System-String-'></a>
### ForPath(path) `method`

##### Summary

Creates a new instance of an object that implements the
[IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost') interface and returns a
reference to it.

##### Returns

Reference to an instance of an object that implements the
[IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost') interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that contains the fully-qualified
pathname of a file for which the new object is to be initialized. |

<a name='M-MFR-File-Hosts-Factories-MakeNewFileHost-HavingEncoding-MFR-File-Hosts-Interfaces-IFileHost,System-Text-Encoding-'></a>
### HavingEncoding(self,encoding) `method`

##### Summary

Builder extension method that initializes the [Encoding](#P-MFR-File-Hosts-Interfaces-IFileHost-Encoding 'MFR.File.Hosts.Interfaces.IFileHost.Encoding') property.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [MFR.File.Hosts.Interfaces.IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost') | (Required.) Reference to an instance of an object that implements
the
[IFileHost](#T-MFR-File-Hosts-Interfaces-IFileHost 'MFR.File.Hosts.Interfaces.IFileHost')
interface. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | (Required.) A [Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') value specifying the text encoding of the file. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `self`, is
passed a `null` value. |

<a name='T-MFR-File-Hosts-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.File.Hosts.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-File-Hosts-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-File-Hosts-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
