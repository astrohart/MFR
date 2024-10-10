using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs.Tests
{
    /// <summary>
    /// Defines the events, methods, properties, and behaviors for all test fixtures
    /// that display forms and dialog boxes.
    /// </summary>
    public abstract class DialogTestBase
    {
        /// <summary>
        /// Method that can be overriden by children of this class in order to do
        /// processing once all tests have been completed.
        /// <remarks>
        /// This method normally would have been marked as <c>abstract</c>; we mark it as
        /// <c>virtual</c> instead, so that overriding this method is optional.
        /// <para />
        /// If child classes have no processing that needs to be done upon completion of
        /// all unit tests, then they do not have to override this method.
        /// </remarks>
        /// </summary>
        [TearDown]
        protected virtual void Cleanup() { }

        /// <summary>
        /// Called prior to running any of the unit tests.
        /// </summary>
        /// <remarks>
        /// The base class version of this method calls the
        /// <see cref="M:System.Windows.Forms.Application.EnableVisualStyles" /> and
        /// <see
        ///     cref="M:System.Windows.Forms.Application.SetCompatibleTextRenderingDefault" />
        /// methods in order to prepare the GUI of the forms and dialog boxes so it has a
        /// modern look and feel.
        /// </remarks>
        [SetUp]
        [STAThread]
        protected virtual void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}