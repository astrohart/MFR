using MFR.Params.Profiles.Interfaces;
using PostSharp.Patterns.Diagnostics;
using xyLOGIX.Validators.Factories;
using xyLOGIX.Validators.Interfaces;

namespace MFR.Params.Profiles.Validators.Factories
{
    /// <summary>
    /// Creates new instances of validator objects that check the properties of
    /// instances of objects that implement the
    /// <see cref="T:MFR.Params.Profiles.Interfaces.IProfileParams" /> interface.
    /// </summary>
    public class
        MakeNewProfileParamsValidator : ObjectValidatorFactoryBase<
            IProfileParams>
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MakeNewProfileParamsValidator() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MakeNewProfileParamsValidator() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Params.Profiles.Validators.Factories.MakeNewProfileParamsValidator" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MakeNewProfileParamsValidator For
        {
            get;
        } = new MakeNewProfileParamsValidator();

        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IObjectValidator" /> interface and
        /// returns a reference to it, for the <paramref name="objectToValidate" />
        /// specified.
        /// </summary>
        /// <param name="objectToValidate">
        /// (Required.) Reference to an instance of the object whose properties' values are
        /// to be validated.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Validators.Interfaces.IObjectValidator" /> interface.
        /// </returns>
        public override IObjectValidator Object(IProfileParams objectToValidate)
            => new ProfileParamsValidator(objectToValidate);
    }
}