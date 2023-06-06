using MFR.GUI.Controls.Interfaces;
using System;
using System.ComponentModel;
using System.Diagnostics;
using xyLOGIX.UI.Dark.Controls;
using xyLOGIX.UI.Dark.Controls.Interfaces;

namespace MFR.GUI.Controls
{
    /// <summary>
    /// A <see cref="T:System.Windows.Forms.UserControl" /> that is dark-themeable and
    /// allows users to create a list of choices by adding one item at a time, and
    /// optionally setting the list order.
    /// </summary>
    public partial class DarkDarkListBuilderControl : DarkUserControl,
        IDarkListBuilderControl
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Controls.DarkDarkListBuilderControl" /> and returns a
        /// reference to
        /// it.
        /// </summary>
        public DarkDarkListBuilderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Add All</b> button can be
        /// selected.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Add All button can be selected."
         )]
        public bool AddAllButtonEnabled
        {
            get => addAllButton.Enabled;
            set {
                var changed = addAllButton.Enabled != value;
                addAllButton.Enabled = value;
                if (changed) OnAddAllButtonEnabledChanged();
            }
        }

        /// <summary>
        /// Gets or sets the <b>Add All</b> button's text.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ), Description("Gets or sets the Add All button's text.")]
        public string AddAllButtonText
        {
            get => addAllButton.Text;
            set {
                var changed = addAllButton.Text != value;
                addAllButton.Text = value;
                if (changed) OnAddAllButtonTextChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Add All</b> button is
        /// visible.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Add All button is visible."
         )]
        public bool AddAllButtonVisible
        {
            get => addAllButton.Visible;
            set {
                var changed = addAllButton.Visible != value;
                addAllButton.Visible = value;
                if (changed) OnAddAllButtonVisibleChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Add</b> button can be
        /// selected.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Add button can be selected."
         )]
        public bool AddButtonEnabled
        {
            get => addButton.Enabled;
            set {
                var changed = addButton.Enabled != value;
                addButton.Enabled = value;
                if (changed) OnAddButtonEnabledChanged();
            }
        }

        /// <summary>
        /// Gets or sets the <c>Add</c> button's text.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ), Description("Gets or sets the Add button's text.")]
        public string AddButtonText
        {
            get => addButton.Text;
            set => addButton.Text = value;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Add</b> button is visible.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Add button is visible."
         )]
        public bool AddButtonVisible
        {
            get => addButton.Visible;
            set {
                var changed = addButton.Visible != value;
                addButton.Visible = value;
                if (changed) OnAddButtonVisibleChanged();
            }
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:xyLOGIX.UI.Dark.Controls.DarkListBox" />
        /// that is displayed on the left-hand side of this user control.
        /// <para />
        /// Typically, this listbox displays available items.
        /// </summary>
        public IDarkListBox LeftListBox
        {
            [DebuggerStepThrough] get => leftListBox;
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:xyLOGIX.UI.Dark.Controls.DarkLabel" />
        /// that is above the left-hand listbox (typically, the left-hand listbox displays
        /// available items).
        /// </summary>
        public IDarkLabel LeftListBoxLabel
        {
            [DebuggerStepThrough] get => leftListBoxLabel;
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Move Down</b> button can be
        /// selected.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Move Down button can be selected."
         )]
        public bool MoveDownButtonEnabled
        {
            get => moveDownButton.Enabled;
            set {
                var changed = moveDownButton.Enabled != value;
                moveDownButton.Enabled = value;
                if (changed) OnMoveDownButtonEnabledChanged();
            }
        }

        /// <summary>
        /// Gets or sets the <b>Move Down</b> button's text.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ), Description("Gets or sets the Move Down button's text.")]
        public string MoveDownButtonText
        {
            get => moveDownButton.Text;
            set {
                var changed = moveDownButton.Text != value;
                moveDownButton.Text = value;
                if (changed) OnMoveDownButtonTextChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Move Down</b> button is
        /// visible.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Move Down button is visible."
         )]
        public bool MoveDownButtonVisible
        {
            get => moveDownButton.Visible;
            set {
                var changed = moveDownButton.Visible != value;
                moveDownButton.Visible = value;
                if (changed) OnMoveDownButtonVisibleChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Move Up</b> button can be
        /// selected.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Move Up button can be selected."
         )]
        public bool MoveUpButtonEnabled
        {
            get => moveUpButton.Enabled;
            set {
                var changed = moveUpButton.Enabled != value;
                moveUpButton.Enabled = value;
                if (changed) OnMoveUpButtonEnabledChanged();
            }
        }

        /// <summary>
        /// Gets or sets the <b>Move Up</b> button's text.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ), Description("Gets or sets the Move Up button's text.")]
        public string MoveUpButtonText
        {
            get => moveUpButton.Text;
            set {
                var changed = moveUpButton.Text != value;
                moveUpButton.Text = value;
                if (changed) OnMoveUpButtonTextChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Move Up</b> button is
        /// visible.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Move Up button is visible."
         )]
        public bool MoveUpButtonVisible
        {
            get => moveUpButton.Visible;
            set {
                var changed = moveUpButton.Visible != value;
                moveUpButton.Visible = value;
                if (changed) OnMoveUpButtonVisibleChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Remove All</b> button can be
        /// selected.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Remove All button can be selected."
         )]
        public bool RemoveAllButtonEnabled
        {
            get => removeAllButton.Enabled;
            set {
                var changed = removeAllButton.Enabled != value;
                removeAllButton.Enabled = value;
                if (changed) OnRemoveAllButtonEnabledChanged();
            }
        }

        /// <summary>
        /// Gets or sets the <b>Remove All</b> button's text.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ), Description("Gets or sets the Remove All button's text.")]
        public string RemoveAllButtonText
        {
            get => removeAllButton.Text;
            set {
                var changed = removeAllButton.Text != value;
                removeAllButton.Text = value;
                if (changed) OnRemoveAllButtonTextChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Remove All</b> button is
        /// visible.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Remove All button is visible."
         )]
        public bool RemoveAllButtonVisible
        {
            get => removeAllButton.Visible;
            set {
                var changed = removeAllButton.Visible != value;
                removeAllButton.Visible = value;
                if (changed) OnRemoveAllButtonVisibleChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value tha indicates whether the <b>Remove</b> button can be
        /// selected.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Remove button can be selected."
         )]
        public bool RemoveButtonEnabled
        {
            get => removeButton.Enabled;
            set {
                var changed = removeButton.Enabled != value;
                removeButton.Enabled = value;
                if (changed) OnRemoveButtonEnabledChanged();
            }
        }

        /// <summary>
        /// Gets or sets the <b>Remove</b> button's text.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ), Description("Gets or sets the Remove button's text.")]
        public string RemoveButtonText
        {
            get => removeButton.Text;
            set {
                var changed = removeButton.Text != value;
                removeButton.Text = value;
                if (changed) OnRemoveButtonTextChanged();
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the <b>Remove</b> button is
        /// visible.
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Content
         ),
         Description(
             "Gets or sets a value tha indicates whether the Remove button is visible."
         )]
        public bool RemoveButtonVisible
        {
            get => removeButton.Visible;
            set {
                var changed = removeButton.Visible != value;
                removeButton.Visible = value;
                if (changed) OnRemoveButtonVisibleChanged();
            }
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:xyLOGIX.UI.Dark.Controls.DarkListBox" />
        /// that is displayed on the right-hand side of this user control.
        /// <para />
        /// Typically, this listbox displays available items.
        /// </summary>
        public IDarkListBox RightListBox
        {
            [DebuggerStepThrough] get => rightListBox;
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:xyLOGIX.UI.Dark.Controls.DarkLabel" />
        /// that is above the right-hand listbox (typically, the right-hand listbox
        /// displays
        /// available items).
        /// </summary>
        public IDarkLabel RightListBoxLabel
        {
            [DebuggerStepThrough] get => rightListBoxLabel;
        }

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler AddAllButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonText" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler AddAllButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler AddAllButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler AddButtonEnabledChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonText" /> property
        /// is updated.
        /// </summary>
        public event EventHandler AddButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler AddButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveDownButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonText" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveDownButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveDownButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveUpButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonText" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveUpButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveUpButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveAllButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonText" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveAllButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveAllButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonText" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveButtonVisibleChanged;

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddAllButtonEnabledChanged()
            => AddAllButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddAllButtonTextChanged()
            => AddAllButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.AddAllButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddAllButtonVisibleChanged()
            => AddAllButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddButtonEnabledChanged()
            => AddButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddButtonTextChanged()
            => AddButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.AddButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddButtonVisibleChanged()
            => AddButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveDownButtonEnabledChanged()
            => MoveDownButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveDownButtonTextChanged()
            => MoveDownButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveDownButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveDownButtonVisibleChanged()
            => MoveDownButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveUpButtonEnabledChanged()
            => MoveUpButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveUpButtonTextChanged()
            => MoveUpButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.MoveUpButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveUpButtonVisibleChanged()
            => MoveUpButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveAllButtonEnabledChanged()
            => RemoveAllButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveAllButtonTextChanged()
            => RemoveAllButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveAllButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveAllButtonVisibleChanged()
            => RemoveAllButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveButtonEnabledChanged()
            => RemoveButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveButtonTextChanged()
            => RemoveButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkDarkListBuilderControl.RemoveButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveButtonVisibleChanged()
            => RemoveButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Subscribes to the events of the component controls for rebroadcast to clients.
        /// </summary>
        private void SubscribeEvents()
        {
            addButton.EnabledChanged += (sender, args)
                => OnAddButtonEnabledChanged();
            addButton.TextChanged += (sender, args) => OnAddButtonTextChanged();
            addButton.VisibleChanged += (sender, args)
                => OnAddButtonVisibleChanged();
            addAllButton.EnabledChanged += (sender, args)
                => OnAddButtonEnabledChanged();
            addAllButton.VisibleChanged += (sender, args)
                => OnAddAllButtonVisibleChanged();
            moveDownButton.EnabledChanged += (sender, args)
                => OnMoveDownButtonEnabledChanged();
            moveDownButton.TextChanged += (sender, args)
                => OnMoveDownButtonTextChanged();
            moveDownButton.VisibleChanged += (sender, args)
                => OnMoveDownButtonVisibleChanged();
            moveUpButton.EnabledChanged += (sender, args)
                => OnMoveUpButtonEnabledChanged();
            moveUpButton.TextChanged += (sender, args)
                => OnMoveUpButtonTextChanged();
            moveUpButton.VisibleChanged += (sender, args)
                => OnMoveUpButtonVisibleChanged();
            removeButton.EnabledChanged += (sender, args)
                => OnRemoveButtonEnabledChanged();
            removeButton.TextChanged += (sender, args)
                => OnRemoveButtonTextChanged();
            removeButton.VisibleChanged += (sender, args)
                => OnRemoveButtonVisibleChanged();
            removeAllButton.EnabledChanged += (sender, args)
                => OnRemoveAllButtonEnabledChanged();
            removeAllButton.TextChanged += (sender, args)
                => OnRemoveAllButtonTextChanged();
            removeAllButton.VisibleChanged += (sender, args)
                => OnRemoveAllButtonVisibleChanged();
        }
    }
}