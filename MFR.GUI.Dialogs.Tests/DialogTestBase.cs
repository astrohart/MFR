using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace MFR.GUI.Dialogs.Tests
{
    public abstract class DialogTestBase
    {
        [SetUp]
        [STAThread]
        protected virtual void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        [TearDown]
        protected virtual void Cleanup() { }
    }
}
