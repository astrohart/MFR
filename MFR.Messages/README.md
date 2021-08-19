<a name='assembly'></a>
# MFR.Objects.Messages

## Contents

- [FixedMessageTypeSpecificObjectBase](#T-MFR-Objects-Messages-FixedMessageTypeSpecificObjectBase 'MFR.Objects.Messages.FixedMessageTypeSpecificObjectBase')
  - [MessageType](#P-MFR-Objects-Messages-FixedMessageTypeSpecificObjectBase-MessageType 'MFR.Objects.Messages.FixedMessageTypeSpecificObjectBase.MessageType')
- [MessageBase](#T-MFR-Objects-Messages-MessageBase 'MFR.Objects.Messages.MessageBase')
  - [CommonExecute()](#M-MFR-Objects-Messages-MessageBase-CommonExecute 'MFR.Objects.Messages.MessageBase.CommonExecute')
  - [Execute()](#M-MFR-Objects-Messages-MessageBase-Execute 'MFR.Objects.Messages.MessageBase.Execute')
  - [ExecuteAsync()](#M-MFR-Objects-Messages-MessageBase-ExecuteAsync 'MFR.Objects.Messages.MessageBase.ExecuteAsync')
- [Resources](#T-MFR-Objects-Messages-Properties-Resources 'MFR.Objects.Messages.Properties.Resources')
  - [Culture](#P-MFR-Objects-Messages-Properties-Resources-Culture 'MFR.Objects.Messages.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Objects-Messages-Properties-Resources-ResourceManager 'MFR.Objects.Messages.Properties.Resources.ResourceManager')

<a name='T-MFR-Objects-Messages-FixedMessageTypeSpecificObjectBase'></a>
## FixedMessageTypeSpecificObjectBase `type`

##### Namespace

MFR.Objects.Messages

##### Summary

Defines the methods, properties, and other functionality that are common
to all objects that are tagged with a
[MessageType](#T-MFR-Objects-MessageType 'MFR.Objects.MessageType')
enumeration value.

<a name='P-MFR-Objects-Messages-FixedMessageTypeSpecificObjectBase-MessageType'></a>
### MessageType `property`

##### Summary

Gets the
[MessageType](#T-MFR-Objects-MessageType 'MFR.Objects.MessageType')
that is
being used to identify which message this is.

<a name='T-MFR-Objects-Messages-MessageBase'></a>
## MessageBase `type`

##### Namespace

MFR.Objects.Messages

##### Summary

Defines the methods, properties, and other functionality that all
messages have in common.

##### Remarks

All message objects perform operations that do not require any input or output.

<a name='M-MFR-Objects-Messages-MessageBase-CommonExecute'></a>
### CommonExecute() `method`

##### Summary

Provides the functionality of both the
[Execute](#M-MFR-Objects-IMessage-Execute 'MFR.Objects.IMessage.Execute')
and
[ExecuteAsync](#M-MFR-Objects-IMessage-ExecuteAsync 'MFR.Objects.IMessage.ExecuteAsync')
methods.

##### Parameters

This method has no parameters.

##### Remarks

Implementers must override this method in order to provide this
message's functionality.

<a name='M-MFR-Objects-Messages-MessageBase-Execute'></a>
### Execute() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

<a name='M-MFR-Objects-Messages-MessageBase-ExecuteAsync'></a>
### ExecuteAsync() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

<a name='T-MFR-Objects-Messages-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Objects.Messages.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Objects-Messages-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Objects-Messages-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
