using MFR.GUI.Controls.Events;
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
        IDarkListBuilderControl
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

            SubscribeEvents();
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
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Visible
         ),
         Description(
             "Gets a reference to the ListBox that displays the items that are available."
         )]
        public IDarkListBox LeftListBox
        {
            [DebuggerStepThrough] get => leftListBox;
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:xyLOGIX.UI.Dark.Controls.DarkLabel" />
        /// that is above the left-hand listbox (typically, the left-hand listbox displays
        /// available items).
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Visible
         ),
         Description(
             "Gets a reference to the Label that is above the ListBox on the left-hand side of the list-builder control."
         )]
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
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Visible
         ),
         Description(
             "Gets a reference to the ListBox that displays the items that are in the list that the user is building."
         )]
        public IDarkListBox RightListBox
        {
            [DebuggerStepThrough] get => rightListBox;
        }

        /// <summary>
        /// Gets a reference to the <see cref="T:xyLOGIX.UI.Dark.Controls.DarkLabel" />
        /// that is above the right-hand listbox (typically, the right-hand listbox
        /// displays the list that the user is is building.
        /// available items).
        /// </summary>
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
         DesignerSerializationVisibility(
             DesignerSerializationVisibility.Visible
         ),
         Description(
             "Gets a reference to the Label that is above the ListBox on the right-hand side of the list-builder control."
         )]
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
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.AddButtonText" />
        /// property
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
        /// Occurs when the <b>Add</b> operation has been successfully completed.
        /// </summary>
        public event EventHandler Added;

        /// <summary>
        /// Occurs when the <b>Add All</b> operation has been successfully completed.
        /// </summary>
        public event EventHandler AddedAll;

        /// <summary>
        /// Occurs before an <b>Add</b> operation is started.  Allows the handler to cancel
        /// the operation.
        /// </summary>
        public event CancelEventHandler Adding;

        /// <summary>
        /// Occurs before an <c>Add All</c> operation is started.  Allows the handler to
        /// cancel the operation.
        /// </summary>
        public event CancelEventHandler AddingAll;

        /// <summary>
        /// Occurs when an item has been moved down in either of the lists.
        /// </summary>
        /// <remarks>
        /// This event indicates to its handler, to which side of the list-builder control
        /// that this event pertains.
        /// </remarks>
        public event ListBuilderEventHandler MovedDown;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.MoveDownButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveDownButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.MoveDownButtonText" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveDownButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.MoveDownButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveDownButtonVisibleChanged;

        /// <summary>
        /// Occurs when an item has been moved up in either of the lists.
        /// </summary>
        /// <remarks>
        /// This event indicates to its handler, to which side of the list-builder control
        /// that this event pertains.
        /// </remarks>
        public event ListBuilderEventHandler MovedUp;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Contols.DarkListBuilderControl.MoveUpButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveUpButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.MoveUpButtonText" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveUpButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.MoveUpButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler MoveUpButtonVisibleChanged;

        /// <summary>
        /// Occurs when the <b>Move Down</b> button has been clicked, but before the
        /// selected item has been moved down in the list.
        /// </summary>
        /// <remarks>
        /// This event indicates to its handler, to which side of the list-builder control
        /// that this event pertains.
        /// </remarks>
        public event ListBuilderCancelEventHandler MovingDown;

        /// <summary>
        /// Occurs when an item is about to be moved up in either of the lists.
        /// </summary>
        /// <remarks>
        /// This event indicates to its handler, to which side of the list-builder control
        /// that this event pertains.
        /// </remarks>
        public event ListBuilderCancelEventHandler MovingUp;

        /// <summary>
        /// Occurs when the
        /// <see
        ///     cref="P:MFR.GUI.Controls.DarkListBuilderControl.RemoveAllButtonEnabled" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveAllButtonEnabledChanged;

        /// <summary>
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.RemoveAllButtonText" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveAllButtonTextChanged;

        /// <summary>
        /// Occurs when the
        /// <see
        ///     cref="P:MFR.GUI.Controls.DarkListBuilderControl.RemoveAllButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveAllButtonVisibleChanged;

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
        /// Occurs when the
        /// <see cref="P:MFR.GUI.Controls.DarkListBuilderControl.RemoveButtonVisible" />
        /// property's value is updated.
        /// </summary>
        public event EventHandler RemoveButtonVisibleChanged;

        /// <summary>
        /// Occurs when an item has been removed from either of the lists.
        /// </summary>
        public event EventHandler Removed;

        /// <summary>
        /// Occurs when the <b>Remove All</b> operation has finished.
        /// </summary>
        public event EventHandler RemovedAll;

        /// <summary>
        /// Occurs before a <b>Removing</b> operation is started.  Allows the handler to
        /// cancel the operation.
        /// </summary>
        public event CancelEventHandler Removing;

        /// <summary>
        /// Occurs before a <b>Remove All</b> operation is started.  Allows the handler to
        /// cancel the operation.
        /// </summary>
        public event CancelEventHandler RemovingAll;

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
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddAllButtonTextChanged" />
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
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddButtonEnabledChanged" />
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
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnAddButtonVisibleChanged()
            => AddButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.Added" />
        /// event.
        /// </summary>
        protected virtual void OnAdded()
            => Added?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddedAll" />
        /// event.
        /// </summary>
        protected virtual void OnAddedAll()
            => AddedAll?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.Adding" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnAdding(CancelEventArgs e)
            => Adding?.Invoke(this, e);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.AddingAll" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnAddingAll(CancelEventArgs e)
            => AddingAll?.Invoke(this, e);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.MovedDown" />
        /// event.
        /// </summary>
        protected virtual void OnMovedDown()
            => MovedDown?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.MoveDownButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveDownButtonEnabledChanged()
            => MoveDownButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.MoveDownButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveDownButtonTextChanged()
            => MoveDownButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.MoveDownButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveDownButtonVisibleChanged()
            => MoveDownButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.MovedUp" />
        /// event.
        /// </summary>
        protected virtual void OnMovedUp()
            => MovedUp?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.MoveUpButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveUpButtonEnabledChanged()
            => MoveUpButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.MoveUpButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveUpButtonTextChanged()
            => MoveUpButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.MoveUpButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnMoveUpButtonVisibleChanged()
            => MoveUpButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.MovingDown" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnMovingDown(CancelEventArgs e)
            => MovingDown?.Invoke(this, e);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.MovingUp" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnMovingUp(CancelEventArgs e)
            => MovingUp?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.RemoveAllButtonEnabledChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveAllButtonEnabledChanged()
            => RemoveAllButtonEnabledChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.RemoveAllButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveAllButtonTextChanged()
            => RemoveAllButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.RemoveAllButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveAllButtonVisibleChanged()
            => RemoveAllButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

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
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.RemoveButtonTextChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveButtonTextChanged()
            => RemoveButtonTextChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.GUI.Controls.DarkListBuilderControl.RemoveButtonVisibleChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRemoveButtonVisibleChanged()
            => RemoveButtonVisibleChanged?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.Removed" />
        /// event.
        /// </summary>
        protected virtual void OnRemoved()
            => Removed?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.RemovedAll" />
        /// event.
        /// </summary>
        protected virtual void OnRemovedAll()
            => RemovedAll?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.Removing" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnRemoving(CancelEventArgs e)
            => Removing?.Invoke(this, e);

        /// <summary>
        /// Raises the <see cref="E:MFR.GUI.Controls.DarkListBuilderControl.RemovingAll" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:System.ComponentModel.CancelEventArgs" /> that
        /// allows us to cancel the operation that this event is notifying the caller of.
        /// <para />
        /// To cancel the operation, handlers should set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" />.
        /// </param>
        protected virtual void OnRemovingAll(CancelEventArgs e)
            => RemovingAll?.Invoke(this, e);

        private void OnClickAddAllButton(object sender, EventArgs e)
        {
            var ce = new CancelEventArgs();
            OnAddingAll(ce);
            if (ce.Cancel) return;

            // TODO: Add code here to implement the Add All operation.

            OnAddedAll();
        }

        private void OnClickAddButton(object sender, EventArgs e)
        {
            var ce = new CancelEventArgs();
            OnAdding(ce);
            if (ce.Cancel) return;

            // TODO: Add code here to implement the Add operation

            OnAdded();
        }

        private void OnClickMoveDownButton(object sender, EventArgs e)
        {
            var ce = new CancelEventArgs();
            OnMovingDown(ce);
            if (ce.Cancel) return;

            // TODO: Add code here to implement the Move Down operation

            OnMovedDown();
        }

        private void OnClickMoveUpButton(object sender, EventArgs e)
        {
            var ce = new CancelEventArgs();
            OnMovingUp(ce);
            if (ce.Cancel) return;

            // TODO: Add code here to implement he Move Up operation

            OnMovedUp();
        }

        private void OnClickRemoveAllButton(object sender, EventArgs e)
        {
            var ce = new CancelEventArgs();
            OnRemovingAll(ce);
            if (ce.Cancel) return;

            // TODO: Add code here to implement the Remove All operation

            OnRemovedAll();
        }

        private void OnClickRemoveButton(object sender, EventArgs e)
        {
            var ce = new CancelEventArgs();
            OnRemoving(ce);
            if (ce.Cancel) return;

            // TODO: Add code here to implement the Remove operation

            OnRemoved();
        }

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