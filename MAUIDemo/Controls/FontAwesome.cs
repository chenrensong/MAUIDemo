using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDemo.Controls
{
    public class FontAwesome : Label
    {

        private static readonly string FontAwesomeFontFamily = "fontawesome";

        public static readonly BindableProperty IconProperty;


        public FontAwesomeIcon Icon
        {
            get
            {
                return (FontAwesomeIcon)GetValue(IconProperty);
            }
            set
            {
                SetValue(IconProperty, value);
            }
        }


        static FontAwesome()
        {
            IconProperty = BindableProperty.Create(nameof(Icon), typeof(FontAwesomeIcon), typeof(FontAwesome), propertyChanged: OnIconPropertyChanged);
        }

        private static void OnIconPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            bindable.SetValue(Label.FontFamilyProperty, FontAwesomeFontFamily);
            bindable.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
            bindable.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
            bindable.SetValue(Label.TextProperty, char.ConvertFromUtf32((int)newValue));
        }


    }


    public enum FlipOrientation
    {
        Normal,
        Horizontal,
        Vertical
    }

}
