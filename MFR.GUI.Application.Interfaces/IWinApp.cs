using System;

namespace MFR.GUI.Application.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an application object.
    /// </summary>
    public interface IWinApp
    {
        /// <summary>
        /// Called to instruct the application to begin processing.
        /// </summary>
        /// <param name="args">
        /// (Required.) An array of <see cref="T:System.String" />
        /// values, each of which corresponds to a value that was passed by the user on the
        /// application's command line.
        /// </param>
        void WinInit(string[] args);

        /// <summary>
        /// A <see cref="T:System.Guid" /> that uniquely identifies this product.
        /// </summary>
        Guid AppId
        {
            get;
        }
    }
}