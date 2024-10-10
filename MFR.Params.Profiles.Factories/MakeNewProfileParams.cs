using MFR.Params.Profiles.Interfaces;
using PostSharp.Patterns.Diagnostics;
using System;

namespace MFR.Params.Profiles.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Params.Profiles.Interfaces.IProfileParams" /> interface, and
    /// returns references to them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewProfileParams
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Params.Profiles.Interfaces.IProfileParams" /> interface and
        /// returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Params.Profiles.Interfaces.IProfileParams" /> interface.
        /// </returns>
        public static IProfileParams FromScratch()
            => new ProfileParams();

        /// <summary>
        /// Assigns the specified <paramref name="name" /> to the profile params object.
        /// </summary>
        /// <param name="self">
        /// (Required.) Reference to an instance of an object that
        /// implements the <see cref="T:MFR.Params.Profiles.Interfaces.IProfileParams" />
        /// interface to which the new <paramref name="name" />  should be assigned.
        /// </param>
        /// <param name="name">
        /// (Required.) String containing the new name to assign to the profile params
        /// object.
        /// </param>
        /// <returns>
        /// Reference to the same instance of the object that called this method,
        /// for fluent use.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="self" />, is passed a <see langword="null" /> value.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="name" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public static IProfileParams HavingName(this IProfileParams self,
            string name)
        {
            if (self == null) throw new ArgumentNullException(nameof(self));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(name)
                );

            self.Name = name;
            return self;
        }
    }
}