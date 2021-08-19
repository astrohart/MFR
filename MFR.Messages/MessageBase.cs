using MFR.Objects.Messages.Interfaces;
using System.Threading.Tasks;

namespace MFR.Objects.Messages
{
    /// <summary>
    /// Defines the methods, properties, and other functionality that all
    /// messages have in common.
    /// </summary>
    /// <remarks>
    /// All message objects perform operations that do not require any input or output.
    /// </remarks>
    public abstract class MessageBase : FixedMessageTypeSpecificObjectBase, IMessage
    {
        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        public void Execute()
            => CommonExecute();

        /// <summary>
        /// Executes this command and does not return anything.
        /// </summary>
        public Task ExecuteAsync()
            => Task.Run(CommonExecute);

        /// <summary>
        /// Provides the functionality of both the
        /// <see
        ///     cref="M:MFR.Objects.IMessage.Execute" />
        /// and
        /// <see
        ///     cref="M:MFR.Objects.IMessage.ExecuteAsync" />
        /// methods.
        /// </summary>
        /// <remarks>
        /// Implementers must override this method in order to provide this
        /// message's functionality.
        /// </remarks>
        protected abstract void CommonExecute();
    }
}