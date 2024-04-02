<a name='assembly'></a>
# MFR.Messages

## Contents

- [FixedMessageTypeSpecificObjectBase](#T-MFR-Messages-FixedMessageTypeSpecificObjectBase 'MFR.Messages.FixedMessageTypeSpecificObjectBase')
  - [MessageType](#P-MFR-Messages-FixedMessageTypeSpecificObjectBase-MessageType 'MFR.Messages.FixedMessageTypeSpecificObjectBase.MessageType')
- [MessageBase](#T-MFR-Messages-MessageBase 'MFR.Messages.MessageBase')
  - [CommonExecute()](#M-MFR-Messages-MessageBase-CommonExecute 'MFR.Messages.MessageBase.CommonExecute')
  - [Execute()](#M-MFR-Messages-MessageBase-Execute 'MFR.Messages.MessageBase.Execute')
  - [ExecuteAsync()](#M-MFR-Messages-MessageBase-ExecuteAsync 'MFR.Messages.MessageBase.ExecuteAsync')
- [Resources](#T-MFR-Messages-Properties-Resources 'MFR.Messages.Properties.Resources')
  - [Culture](#P-MFR-Messages-Properties-Resources-Culture 'MFR.Messages.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Messages-Properties-Resources-ResourceManager 'MFR.Messages.Properties.Resources.ResourceManager')

<a name='T-MFR-Messages-FixedMessageTypeSpecificObjectBase'></a>
## FixedMessageTypeSpecificObjectBase `type`

##### Namespace

MFR.Messages

##### Summary

Defines the methods, properties, and other functionality that are common
to all objects that are tagged with a
[MessageType](#T-MFR-MessageType 'MFR.MessageType')
enumeration value.

<a name='P-MFR-Messages-FixedMessageTypeSpecificObjectBase-MessageType'></a>
### MessageType `property`

##### Summary

Gets the
[MessageType](#T-MFR-MessageType 'MFR.MessageType')
that is
being used to identify which message this.

<a name='T-MFR-Messages-MessageBase'></a>
## MessageBase `type`

##### Namespace

MFR.Messages

##### Summary

Defines the methods, properties, and other functionality that all
messages have in common.

##### Remarks

All message objects perform operations that do not require any input or output.

<a name='M-MFR-Messages-MessageBase-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Provides the functionality of both the
[Execute](#M-MFR-IMessage-Execute 'MFR.IMessage.Execute')
and
[ExecuteAsync](#M-MFR-IMessage-ExecuteAsync 'MFR.IMessage.ExecuteAsync')
methods.

##### Parameters

This method has no parameters.

##### Remarks

Implementers must override this method in order to provide this
message's functionality.

<a name='M-MFR-Messages-MessageBase-Execute'></a>
### Execute() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

<a name='M-MFR-Messages-MessageBase-ExecuteAsync'></a>
### ExecuteAsync() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

<a name='T-MFR-Messages-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Messages.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Messages-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Messages-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
