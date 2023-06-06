using System;
using System.Diagnostics;
using xyLOGIX.UI.Dark.Controls;
using xyLOGIX.UI.Dark.Controls.Interfaces;

namespace MFR.GUI.Controls.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of a list-builder control
    /// that allows users to create a list of choices by adding one item at a time, and
    /// optionally setting the list order..
    /// </summary>
    public interface IDarkListBuilderControl : IDarkUserControl
    {
        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Add All</b> button can be
        /// selected.
        /// </summary>
        bool AddAllButtonEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <b>Add All</b> button's text.
        /// </summary>
        string AddAllButtonText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Add All</b> button is
        /// visible.
        /// </summary>
        bool AddAllButtonVisible
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Add</b> button can be
        /// selected.
        /// </summary>
        bool AddButtonEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <b>Add</b> button's text.
        /// </summary>
        string AddButtonText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Add</b> button is visible.
        /// </summary>
        bool AddButtonVisible
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:xyLOGIX.UI.Dark.Controls.DarkListBox" />
        /// that is displayed on the left-hand side of this user control.
        /// <para />
        /// Typically, this listbox displays available items.
        /// </summary>
        IDarkListBox LeftListBox
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:xyLOGIX.UI.Dark.Controls.DarkLabel" />
        /// that is above the left-hand listbox (typically, the left-hand listbox displays
        /// available items).
        /// </summary>
        IDarkLabel LeftListBoxLabel
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Move Down</b> button can be
        /// selected.
        /// </summary>
        bool MoveDownButtonEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <b>Move Down</b> button's text.
        /// </summary>
        string MoveDownButtonText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Move Down</b> button is
        /// visible.
        /// </summary>
        bool MoveDownButtonVisible
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Move Up</b> button can be
        /// selected.
        /// </summary>
        bool MoveUpButtonEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <b>Move Up</b> button's text.
        /// </summary>
        string MoveUpButtonText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Move Up</b> button is
        /// visible.
        /// </summary>
        bool MoveUpButtonVisible
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Remove All</b> button can be
        /// selected.
        /// </summary>
        bool RemoveAllButtonEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <b>Remove All</b> button's text.
        /// </summary>
        string RemoveAllButtonText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Remove All</b> button is
        /// visible.
        /// </summary>
        bool RemoveAllButtonVisible
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Remove</b> button can be
        /// selected.
        /// </summary>
        bool RemoveButtonEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <b>Remove</b> button's text.
        /// </summary>
        string RemoveButtonText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Remove</b> button is
        /// visible.
        /// </summary>
        bool RemoveButtonVisible
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:xyLOGIX.UI.Dark.Controls.DarkListBox" />
        /// that is displayed on the right-hand side of this user control.
        /// <para />
        /// Typically, this listbox displays available items.
        /// </summary>
        IDarkListBox RightListBox
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:xyLOGIX.UI.Dark.Controls.DarkLabel" />
        /// that is above the right-hand listbox (typically, the right-hand listbox
        /// displays
        /// available items).
        /// </summary>
        IDarkLabel RightListBoxLabel
        {
            [DebuggerStepThrough] get;
        }

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddAllButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        event EventHandler AddAllButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddAllButtonText" />
        /// property's value is updated.
        /// </summary>
        event EventHandler AddAllButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddAllButtonVisible" />
        /// property's value is updated.
        /// </summary>
        event EventHandler AddAllButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        event EventHandler AddButtonEnabledChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddButtonText" /> property
        /// is updated.
        /// </summary>
        event EventHandler AddButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.AddButtonVisible" />
        /// property's value is updated.
        /// </summary>
        event EventHandler AddButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveDownButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        event EventHandler MoveDownButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveDownButtonText" />
        /// property's value is updated.
        /// </summary>
        event EventHandler MoveDownButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveDownButtonVisible" />
        /// property's value is updated.
        /// </summary>
        event EventHandler MoveDownButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveUpButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        event EventHandler MoveUpButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveUpButtonText" />
        /// property's value is updated.
        /// </summary>
        event EventHandler MoveUpButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.MoveUpButtonVisible" />
        /// property's value is updated.
        /// </summary>
        event EventHandler MoveUpButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveAllButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        event EventHandler RemoveAllButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveAllButtonText" />
        /// property's value is updated.
        /// </summary>
        event EventHandler RemoveAllButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveAllButtonVisible" />
        /// property's value is updated.
        /// </summary>
        event EventHandler RemoveAllButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        event EventHandler RemoveButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveButtonText" />
        /// property's value is updated.
        /// </summary>
        event EventHandler RemoveButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.Interfaces.IDarkListBuilderControl.RemoveButtonVisible" />
        /// property's value is updated.
        /// </summary>
        event EventHandler RemoveButtonVisibleChanged;
    }
}