using System.Threading.Tasks;

namespace MFR.Messages.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a message object.
    /// <para />
    /// In our vocabulary, a <c>message</c> object performs an operation that
    /// does not have either inputs or outputs.
    /// </summary>
    public interface IMessage : IFixedMessageTypeSpecificObject
    {
        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        void Execute();

        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        Task ExecuteAsync();
    }
}