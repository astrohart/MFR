using MFR.GUI.Application.Factories;
using MFR.GUI.Application.Interfaces;
using System;

namespace MFR.GUI
{
    /// <summary>
    /// Provides the entry point for the program and all application-level
    /// functionality.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.GUI.Application.Interfaces.IWinApp" /> interface.
        /// </summary>
        private static IWinApp Application
            => GetProjectFileRenamerApp.SoleInstance();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">
        /// (Optional.) Array of strings, each of which represents a different
        /// command-line argument passed to this application.
        /// </param>
        [STAThread]
        public static void Main(string[] args)
            => Application.WinInit(args);
    }
}