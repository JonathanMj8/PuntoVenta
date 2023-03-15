using Syncfusion.XForms.Buttons;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace PuntoVenta.Behaviors
{
    /// <summary>
    /// This class extends the behavior of the SfSegmentedControl to invoke a command when an event occurs.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class SegmentedControlCommandBehavior : Behavior<SfSegmentedControl>
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CommandProperty, and it is a bindable property.
        /// </summary>
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(SegmentedControlCommandBehavior));

        /// <summary>
        /// Gets or sets the CommandParameterProperty, and it is a bindable property.
        /// </summary>
        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(SegmentedControlCommandBehavior));

        /// <summary>
        /// Gets or sets the ParentBindingContextProperty, and it is a bindable property.
        /// </summary>
        public static readonly BindableProperty ParentBindingContextProperty =
            BindableProperty.Create(nameof(ParentBindingContext), typeof(object), typeof(SegmentedControlCommandBehavior));

        /// <summary>
        /// Gets or sets the Command.
        /// </summary>
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        /// <summary>
        /// Gets or sets the CommandParameter.
        /// </summary>
        public object CommandParameter
        {
            get { return GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        /// <summary>
        /// Gets or sets the ParentBindingContext.
        /// </summary>
        public object ParentBindingContext
        {
            get { return GetValue(ParentBindingContextProperty); }
            set { SetValue(ParentBindingContextProperty, value); }
        }

        /// <summary>
        /// Gets the SegmentedControl.
        /// </summary>
        public SfSegmentedControl SegmentedControl { get; private set; }

        #endregion

        #region Method

        /// <summary>
        /// Invoked when adding segmentedControl to the view.
        /// </summary>
        /// <param name="segmentedControl">Segmented Control</param>
        protected override void OnAttachedTo(SfSegmentedControl segmentedControl)
        {
            if (segmentedControl != null)
            {
                base.OnAttachedTo(segmentedControl);
                SegmentedControl = segmentedControl;
                segmentedControl.BindingContextChanged += OnBindingContextChanged;
                segmentedControl.SelectionChanged += OnSelectionChanged;
            }
        }

        /// <summary>
        /// Invoked when exit from the view.
        /// </summary>
        /// <param name="segmentedControl">Segmented Control</param>
        protected override void OnDetachingFrom(SfSegmentedControl segmentedControl)
        {
            if (segmentedControl != null)
            {
                base.OnDetachingFrom(segmentedControl);
                segmentedControl.BindingContextChanged -= OnBindingContextChanged;
                segmentedControl.SelectionChanged -= OnSelectionChanged;
                SegmentedControl = null;
            }
        }

        /// <summary>
        /// Invoked when segmentedControl binding context is changed.
        /// </summary>
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = SegmentedControl.BindingContext;
        }

        /// <summary>
        /// Invoked when selection is changed.
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">Selection Changed Event Args</param>
        private void OnSelectionChanged(object sender, Syncfusion.XForms.Buttons.SelectionChangedEventArgs e)
        {
            if (Command == null)
            {
                return;
            }

            if (Command.CanExecute(CommandParameter))
            {
                Command.Execute(CommandParameter);
            }
        }

        /// <summary>
        /// Invoked when binding context is changed.
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="e">Event Args</param>
        private void OnBindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        #endregion
    }
}