using System;
using System.Diagnostics;
using xyLOGIX.Core.Extensions;
using xyLOGIX.UI.Dark.Controls.Interfaces;

namespace MFR.GUI.Dialogs.Interfaces
{
    public interface ICustomizeOperationsDialog : IForm
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.UI.Dark.Controls.Interfaces.IDarkListBuilderControl" />
        /// interface.
        /// </summary>
        IDarkListBuilderControl OperationListBuilder { [DebuggerStepThrough] get; }
    }
}