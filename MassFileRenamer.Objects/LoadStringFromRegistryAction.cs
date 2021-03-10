using PostSharp.Patterns.Diagnostics;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Accesses a key and value in the system Registry to load the pathname of
    /// the master configuration file.
    /// </summary>
    public class LoadStringFromRegistryAction : CachedActionBase<
        IRegQueryExpression<string>, IFileSystemEntry>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LoadStringFromRegistryAction() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected LoadStringFromRegistryAction() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.LoadStringFromRegistryAction" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static LoadStringFromRegistryAction Instance
        {
            get;
        } = new LoadStringFromRegistryAction();

        /// <summary>
        /// Gets the <see cref="T:MassFileRenamer.Objects.MessageType" /> that is
        /// being used to identify which message this is.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override MessageType MessageType
            => MessageType.LoadStringFromRegistry;

        /// <summary>
        /// Performs this action's operation if the result could not located in
        /// the result cache.
        /// </summary>
        /// <returns>
        /// Reference to an instance of <typeparamref name="TResult" /> that
        /// corresponds to the current input or <c>null</c> if an issue occurred.
        /// </returns>
        /// <remarks>
        /// Implementers shall override this method to provide the functionality
        /// of the request.
        /// <para />
        /// This is a template method, the call to which is wrapped in a robust
        /// and fault-tolerant override of the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.ActionBase.CommonExecute" />
        /// method.
        /// <para />
        /// The parent method override (a) validates that the _input field is
        /// not null, (b) checks for thrown exceptions, and(c) checks the result
        /// cache first to see if data corresponding to the input is there.
        /// </remarks>
        protected override IFileSystemEntry ExecuteOperationIfNotCached()
        {
            // Run validation on the properties of the input registry query
            // expression object. This method throws exceptions if data is not valid.
            GetRegistryExpressionValidator<string>.Instance()
                                                  .ForRegQueryExpression(_input)
                                                  .Validate();

            return MakeNewFileSystemEntry.ForPath(
                SystemPreparer.GetRegistryString(
                                  _input.KeyPath, _input.ValueName,
                                  _input.DefaultValue
                              )
                              .Replace("\"", string.Empty)
            );
        }
    }
}