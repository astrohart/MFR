using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace MFR.Params.Profiles.Validators
{
    public class ProfileParamsValidator : IValidator
    {
        /// <summary>When implemented by a class, evaluates the condition it checks and updates the <see cref="P:System.Web.UI.IValidator.IsValid" /> property.</summary>
        public void Validate()
            => throw new NotImplementedException();

        /// <summary>When implemented by a class, gets or sets a value indicating whether the user-entered content in the specified control passes validation.</summary>
        /// <returns>
        /// <see langword="true" /> if the content is valid; otherwise, <see langword="false" />.</returns>
        public bool IsValid
        {
            get;
            set;
        }

        /// <summary>When implemented by a class, gets or sets the error message text generated when the condition being validated fails.</summary>
        /// <returns>The error message to generate.</returns>
        public string ErrorMessage
        {
            get;
            set;
        }
    }
}
