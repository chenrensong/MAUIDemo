namespace MAUIDemo.Controls;

public partial class ImageButton : ContentButton
{
    public static readonly BindableProperty AspectProperty = BindableProperty.Create(nameof(Aspect),
        typeof(Aspect), typeof(ImageButton));

    public static readonly BindableProperty NormalImageProperty = BindableProperty.Create(nameof(NormalImage),
        typeof(ImageSource), typeof(ImageButton), propertyChanged:OnNormalImageChanged);

    public static readonly BindableProperty PressedImageProperty = BindableProperty.Create(nameof(PressedImage),
        typeof(ImageSource), typeof(ImageButton), propertyChanged: OnPressedImageChanged);

    public static readonly BindableProperty DisabledImageProperty = BindableProperty.Create(nameof(DisabledImage),
        typeof(ImageSource), typeof(ImageButton), propertyChanged: OnDisabledImageChanged);

    [System.ComponentModel.TypeConverter(typeof(ImageSourceConverter))]
    public ImageSource NormalImage
    {
        get
        {
            return (ImageSource)GetValue(NormalImageProperty);
        }
        set
        {
            SetValue(NormalImageProperty, value);
        }
    }

    [System.ComponentModel.TypeConverter(typeof(ImageSourceConverter))]
    public ImageSource PressedImage
    {
        get
        {
            return (ImageSource)base.GetValue(ImageButton.PressedImageProperty);
        }
        set
        {
            base.SetValue(ImageButton.PressedImageProperty, value);
        }
    }

    [System.ComponentModel.TypeConverter(typeof(ImageSourceConverter))]
    public ImageSource DisabledImage
    {
        get
        {
            return (ImageSource)base.GetValue(ImageButton.DisabledImageProperty);
        }
        set
        {
            base.SetValue(ImageButton.DisabledImageProperty, value);
        }
    }

    public Aspect Aspect
    {
        get { return (Aspect)GetValue(AspectProperty); }
        set { SetValue(AspectProperty, value); }
    }


    private static void OnNormalImageChanged(BindableObject bindable, object oldValue, object newValue)
    {
    }

    private static void OnPressedImageChanged(BindableObject bindable, object oldValue, object newValue)
    {
    }

    private static void OnDisabledImageChanged(BindableObject bindable, object oldValue, object newValue)
    {
    }

    public ImageButton()
    {
        InitializeComponent();
    }
}