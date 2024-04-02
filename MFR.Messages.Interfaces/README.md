<a name='assembly'></a>
# MFR.Messages.Interfaces

## Contents

- [IFixedMessageTypeSpecificObject](#T-MFR-Messages-Interfaces-IFixedMessageTypeSpecificObject 'MFR.Messages.Interfaces.IFixedMessageTypeSpecificObject')
  - [MessageType](#P-MFR-Messages-Interfaces-IFixedMessageTypeSpecificObject-MessageType 'MFR.Messages.Interfaces.IFixedMessageTypeSpecificObject.MessageType')
- [IMacroMessage](#T-MFR-Messages-Interfaces-IMacroMessage 'MFR.Messages.Interfaces.IMacroMessage')
- [IMessage](#T-MFR-Messages-Interfaces-IMessage 'MFR.Messages.Interfaces.IMessage')
  - [Execute()](#M-MFR-Messages-Interfaces-IMessage-Execute 'MFR.Messages.Interfaces.IMessage.Execute')
  - [ExecuteAsync()](#M-MFR-Messages-Interfaces-IMessage-ExecuteAsync 'MFR.Messages.Interfaces.IMessage.ExecuteAsync')
- [Resources](#T-MFR-Messages-Interfaces-Properties-Resources 'MFR.Messages.Interfaces.Properties.Resources')
  - [Culture](#P-MFR-Messages-Interfaces-Properties-Resources-Culture 'MFR.Messages.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-MFR-Messages-Interfaces-Properties-Resources-ResourceManager 'MFR.Messages.Interfaces.Properties.Resources.ResourceManager')

<a name='T-MFR-Messages-Interfaces-IFixedMessageTypeSpecificObject'></a>
## IFixedMessageTypeSpecificObject `type`

##### Namespace

MFR.Messages.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that is
tagged with one of the [MessageType](#T-MFR-MessageType 'MFR.MessageType') enumeration values.

##### Remarks

Objects that implement this interface should treat the configuration
message type as being immutable.

<a name='P-MFR-Messages-Interfaces-IFixedMessageTypeSpecificObject-MessageType'></a>
### MessageType `property`

##### Summary

Gets the [MessageType](#T-MFR-MessageType 'MFR.MessageType') that is
being used to identify which message this.

<a name='T-MFR-Messages-Interfaces-IMacroMessage'></a>
## IMacroMessage `type`

##### Namespace

MFR.Messages.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of an object that
performs more than one message, command, action, or request at a time.

<a name='T-MFR-Messages-Interfaces-IMessage'></a>
## IMessage `type`

##### Namespace

MFR.Messages.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a message object.



In our vocabulary, a `message` object performs an operation that
does not have either inputs or outputs.

<a name='M-MFR-Messages-Interfaces-IMessage-Execute'></a>
### Execute() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

<a name='M-MFR-Messages-Interfaces-IMessage-ExecuteAsync'></a>
### ExecuteAsync() `method`

##### Summary

Executes this command and does not return anything.

##### Parameters

This method has no parameters.

<a name='T-MFR-Messages-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

MFR.Messages.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-MFR-Messages-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-MFR-Messages-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
