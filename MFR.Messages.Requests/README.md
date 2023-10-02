<a name='assembly'></a>
# MFR.Messages.Requests

## Contents

- [RequestBase\`1](#T-MFR-Messages-Requests-RequestBase`1 'MFR.Messages.Requests.RequestBase`1')
  - [Result](#P-MFR-Messages-Requests-RequestBase`1-Result 'MFR.Messages.Requests.RequestBase`1.Result')
  - [CommonExecute()](#M-MFR-Messages-Requests-RequestBase`1-CommonExecute 'MFR.Messages.Requests.RequestBase`1.CommonExecute')
  - [Execute()](#M-MFR-Messages-Requests-RequestBase`1-Execute 'MFR.Messages.Requests.RequestBase`1.Execute')
  - [ExecuteAsync()](#M-MFR-Messages-Requests-RequestBase`1-ExecuteAsync 'MFR.Messages.Requests.RequestBase`1.ExecuteAsync')
- [Resources](#T-MFR-Messages-Requests-Properties-Resources 'MFR.Messages.Requests.Properties.Resources')
  - [Culture](#P-MFR-Messages-Requests-Properties-Resources-Culture 'MFR.Messages.Requests.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Messages-Requests-Properties-Resources-ResourceManager 'MFR.Messages.Requests.Properties.Resources.ResourceManager')

<a name='T-MFR-Messages-Requests-RequestBase`1'></a>
## RequestBase\`1 `type`

##### Namespace

MFR.Messages.Requests

##### Summary

Defines the methods, properties, events, and functionality that all
configuration-request objects share.

<a name='P-MFR-Messages-Requests-RequestBase`1-Result'></a>
### Result `property`

##### Summary

Gets a reference to an instance of an object of type
`TResult` that contains the results of executing this
`Request`.

<a name='M-MFR-Messages-Requests-RequestBase`1-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Executes this message.

##### Returns

A `TResult` instance containing data from the
result of executing the message.

##### Parameters

This method has no parameters.

##### Remarks

Implementers shall override this method to provide the functionality
of the request.

<a name='M-MFR-Messages-Requests-RequestBase`1-Execute'></a>
### Execute() `method`

##### Summary

Executes this message.

##### Returns

A `TResult` instance containing data from the
result of executing the message.

##### Parameters

This method has no parameters.

<a name='M-MFR-Messages-Requests-RequestBase`1-ExecuteAsync'></a>
### ExecuteAsync() `method`

##### Summary

Executes this message asynchronously.

##### Returns

A `TResult` instance containing data from the
result of executing the message.

##### Parameters

This method has no parameters.

<a name='T-MFR-Messages-Requests-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Messages.Requests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Messages-Requests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Messages-Requests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
