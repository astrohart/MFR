<a name='assembly'></a>
# MFR.Generators.RegularExpressions

## Contents

- [MatchExactWordOnlyRegularExpressionGenerator](#T-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator 'MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator')
  - [#ctor()](#M-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator-#ctor 'MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator.#ctor')
  - [Instance](#P-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator-Instance 'MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator.Instance')
  - [RegularExpressionType](#P-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator-RegularExpressionType 'MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator.RegularExpressionType')
  - [#cctor()](#M-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator-#cctor 'MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator.#cctor')
  - [Generate(value)](#M-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator-Generate-System-String- 'MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator.Generate(System.String)')
- [MatchWholeLineRegularExpressionGenerator](#T-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator 'MFR.Generators.RegularExpressions.MatchWholeLineRegularExpressionGenerator')
  - [#ctor()](#M-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator-#ctor 'MFR.Generators.RegularExpressions.MatchWholeLineRegularExpressionGenerator.#ctor')
  - [Instance](#P-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator-Instance 'MFR.Generators.RegularExpressions.MatchWholeLineRegularExpressionGenerator.Instance')
  - [RegularExpressionType](#P-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator-RegularExpressionType 'MFR.Generators.RegularExpressions.MatchWholeLineRegularExpressionGenerator.RegularExpressionType')
  - [#cctor()](#M-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator-#cctor 'MFR.Generators.RegularExpressions.MatchWholeLineRegularExpressionGenerator.#cctor')
  - [Generate(value)](#M-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator-Generate-System-String- 'MFR.Generators.RegularExpressions.MatchWholeLineRegularExpressionGenerator.Generate(System.String)')
- [RegularExpressionGeneratorBase](#T-MFR-Objects-Generators-RegularExpressions-RegularExpressionGeneratorBase 'MFR.Generators.RegularExpressions.RegularExpressionGeneratorBase')
  - [GeneratorType](#P-MFR-Objects-Generators-RegularExpressions-RegularExpressionGeneratorBase-GeneratorType 'MFR.Generators.RegularExpressions.RegularExpressionGeneratorBase.GeneratorType')
  - [RegularExpressionType](#P-MFR-Objects-Generators-RegularExpressions-RegularExpressionGeneratorBase-RegularExpressionType 'MFR.Generators.RegularExpressions.RegularExpressionGeneratorBase.RegularExpressionType')
- [Resources](#T-MFR-Objects-Generators-RegularExpressions-Properties-Resources 'MFR.Generators.RegularExpressions.Properties.Resources')
  - [Culture](#P-MFR-Objects-Generators-RegularExpressions-Properties-Resources-Culture 'MFR.Generators.RegularExpressions.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Generators-RegularExpressions-Properties-Resources-ResourceManager 'MFR.Generators.RegularExpressions.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator'></a>
## MatchExactWordOnlyRegularExpressionGenerator `type`

##### Namespace

MFR.Generators.RegularExpressions

##### Summary

Generator of regular expressions for exact-word matches.

<a name='M-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [MatchExactWordOnlyRegularExpressionGenerator](#T-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator 'MFR.Generators.RegularExpressions.MatchExactWordOnlyRegularExpressionGenerator') .

<a name='P-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator-RegularExpressionType'></a>
### RegularExpressionType `property`

##### Summary

Gets the [RegularExpressionType](#T-MFR-Objects-Generators-RegularExpressions-Constants-RegularExpressionType 'MFR.Generators.RegularExpressions.Constants.RegularExpressionType')
value that uniquely identifies which type of regular expressions
that this object handles.

<a name='M-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Generators-RegularExpressions-MatchExactWordOnlyRegularExpressionGenerator-Generate-System-String-'></a>
### Generate(value) `method`

##### Summary

Transforms the input `value` into the output value.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') whose value is the result of the transformation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is to be transformed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed a blank or `null` string for a value. |

<a name='T-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator'></a>
## MatchWholeLineRegularExpressionGenerator `type`

##### Namespace

MFR.Generators.RegularExpressions

##### Summary

Generator of regular expressions for exact-word matches.

<a name='M-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [MatchWholeLineRegularExpressionGenerator](#T-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator 'MFR.Generators.RegularExpressions.MatchWholeLineRegularExpressionGenerator') .

<a name='P-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator-RegularExpressionType'></a>
### RegularExpressionType `property`

##### Summary

Gets the [RegularExpressionType](#T-MFR-Objects-Generators-RegularExpressions-Constants-RegularExpressionType 'MFR.Generators.RegularExpressions.Constants.RegularExpressionType')
value that uniquely identifies which type of regular expressions
that this object handles.

<a name='M-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Generators-RegularExpressions-MatchWholeLineRegularExpressionGenerator-Generate-System-String-'></a>
### Generate(value) `method`

##### Summary

Transforms the input `value` into the output value.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') whose value is the result of the transformation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.) The [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') that is to be transformed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the required parameter, `value`, is
passed a blank or `null` string for a value. |

<a name='T-MFR-Objects-Generators-RegularExpressions-RegularExpressionGeneratorBase'></a>
## RegularExpressionGeneratorBase `type`

##### Namespace

MFR.Generators.RegularExpressions

##### Summary

Defines the services that are available to all of the concrete
implementations of

<a name='P-MFR-Objects-Generators-RegularExpressions-RegularExpressionGeneratorBase-GeneratorType'></a>
### GeneratorType `property`

##### Summary

A [GeneratorType](#T-MFR-Objects-Generators-Constants-GeneratorType 'MFR.Generators.Constants.GeneratorType')
value that specifies which type of generator this object is.

<a name='P-MFR-Objects-Generators-RegularExpressions-RegularExpressionGeneratorBase-RegularExpressionType'></a>
### RegularExpressionType `property`

##### Summary

Gets the
[RegularExpressionType](#T-MFR-Objects-Generators-RegularExpressions-Constants-RegularExpressionType 'MFR.Generators.RegularExpressions.Constants.RegularExpressionType')
value that uniquely identifies which type of regular expressions
that this object handles.

<a name='T-MFR-Objects-Generators-RegularExpressions-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Generators.RegularExpressions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Generators-RegularExpressions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Generators-RegularExpressions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
