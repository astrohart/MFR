using MFR.Params.Profiles.Interfaces;
using MFR.Settings.Profiles.Providers.Factories;
using MFR.Settings.Profiles.Providers.Interfaces;
using xyLOGIX.Validators;
using xyLOGIX.Validators.Events;

namespace MFR.Params.Profiles.Validators
{
    /// <summary>
    /// Validates the data in the properties of an instance of an object that
    /// implements the <see cref="T:MFR.Params.Profiles.Interfaces.IProfileParams" />
    /// interface.
    /// </summary>
    public class ProfileParamsValidator : ObjectValidatorBase<IProfileParams>
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Validators.ObjectValidatorBase" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="objectToValidate">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Params.Profiles.Interfaces.IProfileParams" /> interface that
        /// has the data to be validated.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="objectToValidate" />, is passed a
        /// <see langword="null" /> value.
        /// </exception>
        public ProfileParamsValidator(IProfileParams objectToValidate) : base(
            objectToValidate
        ) { }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Settings.Profiles.Providers.Interfaces.IProfileProvider" />
        /// interface.
        /// </summary>
        private static IProfileProvider ProfileProvider
        {
            get;
        } = GetProfileProvider.SoleInstance();

        /// <summary>
        /// When implemented by a class, evaluates the condition it checks and
        /// updates the <see cref="P:System.Web.UI.IValidator.IsValid" /> property.
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            if (string.IsNullOrWhiteSpace(ObjectToValidate.Name))
            {
                OnValidationFailed(
                    new ValidationFailedEventArgs(
                        "Profile name cannot be blank."
                    )
                );
                return;
            }

            // Check whether there is an existing profile with the name we are wanting to use.
            // If so, then the user must be shown an error message to inform the user that the
            // name cannot be reused.
            if (ProfileProvider.Profiles.HasProfileNamed(ObjectToValidate.Name))
            {
                OnValidationFailed(
                    new ValidationFailedEventArgs(
                        $"A profile with the name '{ObjectToValidate.Name}' already exists."
                    )
                );
                return;
            }

            OnValidationSucceeded();
        }
    }
}