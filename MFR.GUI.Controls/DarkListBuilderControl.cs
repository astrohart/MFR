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
    public partial class DarkListBuilderControl : DarkUserControl,
        IListBuilderControl
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.GUI.Controls.DarkListBuilderControl" /> and returns a
        /// reference to
        /// it.
        /// </summary>
        public DarkListBuilderControl()
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
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.AddAllButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler AddAllButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.AddAllButtonText" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler AddAllButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.AddAllButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler AddAllButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.AddButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler AddButtonEnabledChanged;

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.AddButtonText" /> property
        /// is updated.
        /// </summary>
        public event EventHandler AddButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.AddButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler AddButtonVisibleChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.RemoveButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.RemoveButtonText" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveButtonTextChanged;

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddAllButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddAllButtonEnabledChanged()
            => AddAllButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddAllButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddAllButtonTextChanged()
            => AddAllButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddAllButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddAllButtonVisibleChanged()
            => AddAllButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddButtonEnabledChanged()
            => AddButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddButtonTextChanged()
            => AddButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddButtonVisibleChanged()
            => AddButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.RemoveButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveButtonEnabledChanged()
            => RemoveButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.RemoveButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveButtonTextChanged()
            => RemoveButtonTextChanged?.Invoke(this, EventArgs.Empty);

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
            removeButton.EnabledChanged += (sender, args)
                => OnRemoveButtonEnabledChanged();
            removeButton.TextChanged += (sender, args)
                => OnRemoveButtonTextChanged();
        }
    }
}