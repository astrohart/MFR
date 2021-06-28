<a name='assembly'></a>
# MFR.Objects

## Contents

- [ProgramFlowHelper](#T-MFR-Objects-ProgramFlowHelper 'MFR.Objects.ProgramFlowHelper')
  - [StartDebugger()](#M-MFR-Objects-ProgramFlowHelper-StartDebugger 'MFR.Objects.ProgramFlowHelper.StartDebugger')
- [Reflector](#T-MFR-Objects-Reflector 'MFR.Objects.Reflector')
  - [#ctor(targetNamespace)](#M-MFR-Objects-Reflector-#ctor-System-String- 'MFR.Objects.Reflector.#ctor(System.String)')
  - [#ctor(targetAssembly,targetNamespace)](#M-MFR-Objects-Reflector-#ctor-System-String,System-String- 'MFR.Objects.Reflector.#ctor(System.String,System.String)')
  - [_targetAssembly](#F-MFR-Objects-Reflector-_targetAssembly 'MFR.Objects.Reflector._targetAssembly')
  - [_targetNamespace](#F-MFR-Objects-Reflector-_targetNamespace 'MFR.Objects.Reflector._targetNamespace')
  - [Call(obj,func,parameters)](#M-MFR-Objects-Reflector-Call-System-Object,System-String,System-Object[]- 'MFR.Objects.Reflector.Call(System.Object,System.String,System.Object[])')
  - [Call2(obj,func,parameters)](#M-MFR-Objects-Reflector-Call2-System-Object,System-String,System-Object[]- 'MFR.Objects.Reflector.Call2(System.Object,System.String,System.Object[])')
  - [CallAs(type,obj,func,parameters)](#M-MFR-Objects-Reflector-CallAs-System-Type,System-Object,System-String,System-Object[]- 'MFR.Objects.Reflector.CallAs(System.Type,System.Object,System.String,System.Object[])')
  - [CallAs2(type,obj,func,parameters)](#M-MFR-Objects-Reflector-CallAs2-System-Type,System-Object,System-String,System-Object[]- 'MFR.Objects.Reflector.CallAs2(System.Type,System.Object,System.String,System.Object[])')
  - [Get(obj,propertyName)](#M-MFR-Objects-Reflector-Get-System-Object,System-String- 'MFR.Objects.Reflector.Get(System.Object,System.String)')
  - [GetAs(type,obj,propertyName)](#M-MFR-Objects-Reflector-GetAs-System-Type,System-Object,System-String- 'MFR.Objects.Reflector.GetAs(System.Type,System.Object,System.String)')
  - [GetEnum(typeName,name)](#M-MFR-Objects-Reflector-GetEnum-System-String,System-String- 'MFR.Objects.Reflector.GetEnum(System.String,System.String)')
  - [GetType(typeName)](#M-MFR-Objects-Reflector-GetType-System-String- 'MFR.Objects.Reflector.GetType(System.String)')
  - [New(typeName,parameters)](#M-MFR-Objects-Reflector-New-System-String,System-Object[]- 'MFR.Objects.Reflector.New(System.String,System.Object[])')
- [Resources](#T-MFR-Objects-Properties-Resources 'MFR.Objects.Properties.Resources')
  - [Culture](#P-MFR-Objects-Properties-Resources-Culture 'MFR.Objects.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Properties-Resources-ResourceManager 'MFR.Objects.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-ProgramFlowHelper'></a>
## ProgramFlowHelper `type`

##### Namespace

MFR.Objects

##### Summary

Defines methods and properties to aid in controlling the flow of the program.

<a name='M-MFR-Objects-ProgramFlowHelper-StartDebugger'></a>
### StartDebugger() `method`

##### Summary

Launches the Visual Studio Debugger.

##### Parameters

This method has no parameters.

##### Remarks

This method should be called only as necessary to automatically
launch the Visual Studio Debugger, attached to the currently-running
process instance.



Such calls should be commented out or deleted when no longer needed.

<a name='T-MFR-Objects-Reflector'></a>
## Reflector `type`

##### Namespace

MFR.Objects

##### Summary

This class is from the Front-End for Dosbox and is used to present a
'vista' dialog box to select folders. Being able to use a vista style
dialog box to select folders is much better then using the shell folder
browser. http://code.google.com/p/fed/ Example: var r = new
Reflector("System.Windows.Forms");

<a name='M-MFR-Objects-Reflector-#ctor-System-String-'></a>
### #ctor(targetNamespace) `constructor`

##### Summary

Constructs a new instance of [Reflector](#T-MFR-Objects-Reflector 'MFR.Objects.Reflector')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetNamespace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the C# namespace that
contains the target object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter,
`targetNamespace`
, is passed a blank or
`null`
string for a value. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if no referenced assemblies can be found. |

<a name='M-MFR-Objects-Reflector-#ctor-System-String,System-String-'></a>
### #ctor(targetAssembly,targetNamespace) `constructor`

##### Summary

Constructs a new instance of [Reflector](#T-MFR-Objects-Reflector 'MFR.Objects.Reflector')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| targetAssembly | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the assembly to reflect
the target object from. |
| targetNamespace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the C# namespace that
contains the target object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if either of the required parameters,
`targetAssembly`
or `targetNamespace`, are
passed blank or `null` strings for values. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if no referenced assemblies can be found. |

<a name='F-MFR-Objects-Reflector-_targetAssembly'></a>
### _targetAssembly `constants`

##### Summary

Reference to an instance of
[Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly')
that corresponds to the target assembly.

<a name='F-MFR-Objects-Reflector-_targetNamespace'></a>
### _targetNamespace `constants`

##### Summary

String containing the C# namespace that contains the target object.

<a name='M-MFR-Objects-Reflector-Call-System-Object,System-String,System-Object[]-'></a>
### Call(obj,func,parameters) `method`

##### Summary

Calls a method on the target object.

##### Returns

Reference to an instance of an object that contains the target
method's return value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to the target object. |
| func | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the method to be called on
the target object. |
| parameters | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Required.) Zero or more parameter values to be passed to the target
method as arguments. |

<a name='M-MFR-Objects-Reflector-Call2-System-Object,System-String,System-Object[]-'></a>
### Call2(obj,func,parameters) `method`

##### Summary

Calls a method on the target object.

##### Returns

Reference to an instance of an object that contains the target
method's return value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to the target object. |
| func | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the method to be called on
the target object. |
| parameters | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Required.) Zero or more parameter values to be passed to the target
method as arguments. |

<a name='M-MFR-Objects-Reflector-CallAs-System-Type,System-Object,System-String,System-Object[]-'></a>
### CallAs(type,obj,func,parameters) `method`

##### Summary

Calls a method on the target object, with the caller masquerading as
the [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') specified by the
`type`
parameter.

##### Returns

Reference to an instance of an object that contains the target
method's return value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | (Required.) A [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') that specifies the type
that caller should be masqueraded as. |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to the target object. |
| func | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the method to be called on
the target object. |
| parameters | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Required.) Zero or more parameter values to be passed to the target
method as arguments. |

<a name='M-MFR-Objects-Reflector-CallAs2-System-Type,System-Object,System-String,System-Object[]-'></a>
### CallAs2(type,obj,func,parameters) `method`

##### Summary

Calls a method on the target object, with the caller masquerading as
the [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') specified by the
`type`
parameter.

##### Returns

Reference to an instance of an object that contains the target
method's return value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | (Required.) A [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') that specifies the type
that caller should be masqueraded as. |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to the target object. |
| func | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the method to be called on
the target object. |
| parameters | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Required.) Zero or more parameter values to be passed to the target
method as arguments. |

<a name='M-MFR-Objects-Reflector-Get-System-Object,System-String-'></a>
### Get(obj,propertyName) `method`

##### Summary

Invokes the getter of a property of the target object.

##### Returns

Reference to an instance of [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') that
contains the value returned from the target property's getter accessor.



This method returns `null` if an error occurred
during the process of invoking the getter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to the target object. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the target property. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `obj`, is passed
a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `propertyName`,
is passed a blank or `null` string for a value. |

<a name='M-MFR-Objects-Reflector-GetAs-System-Type,System-Object,System-String-'></a>
### GetAs(type,obj,propertyName) `method`

##### Summary

Masquerading as the [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') value referred to by
the `type` command, calls the getter of a property
of the target object.

##### Returns

Reference to an instance of [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') that
contains the value returned from the target property's getter accessor.



This method returns `null` if an error occurred
during the process of invoking the getter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | A [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') that specifies which type the caller
should be masqueraded as. |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | (Required.) Reference to the target object. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the target property. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `obj`, is passed
a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `propertyName`,
is passed a blank or `null` string for a value. |

<a name='M-MFR-Objects-Reflector-GetEnum-System-String,System-String-'></a>
### GetEnum(typeName,name) `method`

##### Summary

Given the fully-qualified `typeName` of an
`enum`
, and the `name` of one of its
members, attempts to fetch the requested enumeration member's value
from the target enumeration.

##### Returns

Value of the enumeration member requested, or `null`
if either the member or enumeration type requested cannot be located
in the target assembly, or some other type of error has occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified name of a .NET
Framework enumeration type. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the name of the particular member of
the enumeration whose value is to be obtained. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `typeName`, is
passed a blank or `null` string for a value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `name`, is passed
a blank or `null` string for a value. |

<a name='M-MFR-Objects-Reflector-GetType-System-String-'></a>
### GetType(typeName) `method`

##### Summary

Given a string containing the fully-qualified name of a .NET
Framework type, attempts to get a reference to an instance of
[Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type')
containing the reflection information for
that type.

##### Returns

A [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') instance containing the reflection
information for the type whose fully-qualified name is specified.



If the `typeName` cannot be parsed, or no such type
can be located, then this method returns `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified name of a .NET
Framework type. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `typeName`, is
passed a blank or `null` string for a value. |

<a name='M-MFR-Objects-Reflector-New-System-String,System-Object[]-'></a>
### New(typeName,parameters) `method`

##### Summary

Invokes the constructor of the target object, and returns a
reference to an instance of the target object.

##### Returns

Reference to an instance of the target object resulting from the
constructor that has been invoked.



This method returns `null` in the event that the
specified type cannot be found in the target assembly, or if the
constructor overload that should be invoked cannot be determined
from the information provided, or some other error occurs.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) String containing the fully-qualified name of a .NET
Framework type. |
| parameters | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Required.) Zero or more values to be passed to the constructor of
the target object as arguments. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `typeName`, is
passed a blank or `null` string for a value. |

<a name='T-MFR-Objects-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
