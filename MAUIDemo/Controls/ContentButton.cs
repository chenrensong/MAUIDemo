using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUIDemo.Controls
{
    public partial class ContentButton : ContentView
    {
        public static readonly BindableProperty CommandProperty;
        public static readonly BindableProperty CommandParameterProperty;

        static ContentButton()
        {
            CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ContentButton), null, BindingMode.Default);
            CommandParameterProperty =
           BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(ContentButton));
        }

        /// <summary>
        /// Occurs when the Button is clicked.
        /// </summary>
        public event EventHandler Clicked;
        /// <summary>
        /// Occurs when the Button is pressed.
        /// </summary>
        public event EventHandler Pressed;
        /// <summary>
        /// Occurs when the Button is released.
        /// <para>The released event always occur before the clicked event.</para>
        /// </summary>
        public event EventHandler Released;

        public event EventHandler<bool> VisuallyPressedChanged;

        /// <summary>
        /// Gets or sets the command to invoke when the button is activated. This is a bindable property.
        /// </summary>
        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }
        /// <summary>
        /// Gets or sets the parameter to pass to the Command property. This is a bindable property.
        /// </summary>
        public object CommandParameter
        {
            get => GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }

        private bool isVisuallyPressed;

        public ContentButton()
        {
            var touchEffect = new TouchRoutingEffect
            {
                Capture = true
            };
            touchEffect.TouchAction += TouchEffect_TouchAction;
            Effects.Add(touchEffect);
        }


        private void OnClicked()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
            VisualStateManager.GoToState(this, nameof(Clicked));
        }

        private void OnPressed()
        {
            Pressed?.Invoke(this, EventArgs.Empty);
            VisualStateManager.GoToState(this, nameof(Pressed));
        }

        private void OnReleased()
        {
            Released?.Invoke(this, EventArgs.Empty);
            VisualStateManager.GoToState(this, nameof(Released));
        }

        private void OnNormal()
        {
            VisualStateManager.GoToState(this, "Normal");
        }


        protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);

            // so that the touch events are ignored and bypassed to this control
            if (child is VisualElement visualChild)
            {
                visualChild.InputTransparent = true;
            }
        }

        private long? currentId;
        private object touchEffect_lock = new object();
        private void TouchEffect_TouchAction(object sender, TouchActionEventArgs e)
        {
            // only track one touch
            if (currentId != e.Id && e.Type != TouchActionType.Pressed)
            {
                return;
            }
            lock (touchEffect_lock)
            {
                //var isHandle = false;
                switch (e.Type)
                {
                    case TouchActionType.Pressed:
                        currentId = e.Id;
                        OnPressed();
                        isVisuallyPressed = true;
                        VisuallyPressedChanged?.Invoke(this, true);

                        break;
                    case TouchActionType.Moved:
                        if (isVisuallyPressed)
                        {
                            bool isInside = e.Location.X >= 0 && e.Location.Y >= 0 && e.Location.X <= Bounds.Width && e.Location.Y <= Bounds.Height;
                            if (!isInside)
                            {
                                OnNormal();
                                isVisuallyPressed = false;
                                VisuallyPressedChanged?.Invoke(this, false);
                            }
                        }
                        break;
                    case TouchActionType.Cancelled:
                        currentId = null;
                        isVisuallyPressed = false;
                        VisuallyPressedChanged?.Invoke(this, false);
                        break;
                    case TouchActionType.Released:
                        currentId = null;
                        if (isVisuallyPressed)
                        {
                            OnReleased();
                            OnClicked();
                            OnNormal();
                            if (Command != null && Command.CanExecute(CommandParameter))
                            {
                                Command.Execute(CommandParameter);
                            }
                            isVisuallyPressed = false;
                            VisuallyPressedChanged?.Invoke(this, false);

                        }
                        break;
                }
            }
        }
    }
}
