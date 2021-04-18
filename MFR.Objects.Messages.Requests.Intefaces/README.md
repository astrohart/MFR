<a name='assembly'></a>
# MFR.Objects.Messages.Requests.Intefaces

## Contents

- [IRequest\`1](#T-MFR-Objects-Messages-Requests-Intefaces-IRequest`1 'MFR.Objects.Messages.Requests.Intefaces.IRequest`1')
  - [Execute()](#M-MFR-Objects-Messages-Requests-Intefaces-IRequest`1-Execute 'MFR.Objects.Messages.Requests.Intefaces.IRequest`1.Execute')
  - [ExecuteAsync()](#M-MFR-Objects-Messages-Requests-Intefaces-IRequest`1-ExecuteAsync 'MFR.Objects.Messages.Requests.Intefaces.IRequest`1.ExecuteAsync')
- [Resources](#T-MFR-Objects-Messages-Requests-Intefaces-Properties-Resources 'MFR.Objects.Messages.Requests.Intefaces.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Requests-Intefaces-Properties-Resources-Culture 'MFR.Objects.Messages.Requests.Intefaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Requests-Intefaces-Properties-Resources-ResourceManager 'MFR.Objects.Messages.Requests.Intefaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Messages-Requests-Intefaces-IRequest`1'></a>
## IRequest\`1 `type`

##### Namespace

MFR.Objects.Messages.Requests.Intefaces

##### Summary

Defines the public-exposed methods and properties of an object that
implements requests that can be performed on behalf of the application.



In our vocabulary, a `request` is a command that only has a result;
i.e., it does not take any inputs.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult | Name of the class that will receive results of the operation. |

##### Remarks

Defines a request. Requests differ from messages in that requests do not
have any input parameters.



To make a request that does not return an output, compose this object
with [Void](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Void 'System.Void').

<a name='M-MFR-Objects-Messages-Requests-Intefaces-IRequest`1-Execute'></a>
### Execute() `method`

##### Summary

Executes this message.

##### Returns

A `TResult` instance containing data from the
result of executing the message.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Messages-Requests-Intefaces-IRequest`1-ExecuteAsync'></a>
### ExecuteAsync() `method`

##### Summary

Executes this message.

##### Returns

A `TResult` instance containing data from the
result of executing the message.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Messages-Requests-Intefaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Messages.Requests.Intefaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Messages-Requests-Intefaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Messages-Requests-Intefaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
