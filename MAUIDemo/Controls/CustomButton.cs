using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDemo.Controls
{

    public interface ICustomButton : IView, ICustomButtonController
    {
        string Content { get; set; }
    }

    public interface ICustomButtonController : IViewController
    {
        void SendClick(object sender, object args);
    }


    public class CustomButton : View, ICustomButton
    {
        public event EventHandler Click;
        public static readonly BindableProperty ContentProperty;
        static CustomButton()
        {
            ContentProperty = BindableProperty.Create(nameof(Content),
                typeof(string),
                typeof(CustomButton), propertyChanged:
                OnContentPropertyChanged);
        }

        private static void OnContentPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {

        }

        public string Content
        {
            get
            {
                return (string)GetValue(ContentProperty);
            }
            set
            {
                SetValue(ContentProperty, value);
            }
        }



        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SendClick(object sender, object args)
        {
            Click?.Invoke(sender, EventArgs.Empty);
        }
    }
}
