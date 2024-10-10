using MFR.Operations.Constants;
using MFR.Operations.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Operations
{
    /// <summary>
    /// Provides functionality that is shared among all operation-type-specific
    /// objects.
    /// </summary>
    [Log(AttributeExclude = true)]
    public abstract class OperationTypeSpecificObjectBase : IOperationTypeSpecificObject
    {
        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public abstract OperationType OperationType
        {
            get;
            protected set;
        }

        /// <summary>
        /// Initializes the
        /// <see
        ///     cref="P:MFR.IOperationSpecificObject.OperationType" />
        /// property with the specific
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// value that
        /// corresponds to the type of operation being performed.
        /// </summary>
        /// <param name="type">
        /// (Required.) One of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values that
        /// specifies the type of operation being performed.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        /// <remarks>
        /// This method is optional. If the objects in the bridge hierarchy
        /// implement the
        /// <see
        ///     cref="P:MFR.IOperationSpecificObject.OperationType" />
        /// property themselves, then this method is not necessary to be called.
        /// <para />
        /// However, it is made <c>virtual</c> so that child implementations may
        /// override its functionality.
        /// </remarks>
        public virtual dynamic AndOperationType(OperationType type)
        {
            OperationType = type;

            return this;
        }

        /// <summary>
        /// Constructs a new instance of <see cref="T:MFR.OperationSpecificObjectBase" /> and returns a reference to it.
        /// </summary>
        protected OperationTypeSpecificObjectBase()
        {
            OperationType = OperationType.Unknown;  // default
        }
    }
}