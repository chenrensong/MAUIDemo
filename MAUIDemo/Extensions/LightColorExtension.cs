namespace MAUIDemo.Extensions
{
    public class LightColorExtension : IMarkupExtension<Color>
    {

        public Color SrcColor { get; set; }

        public float Alpha { get; set; } = 1.0f;

        public Color ProvideValue(IServiceProvider serviceProvider)
        {
            SrcColor.ToHsl(out var h, out var s, out var l);
            var lightness = Math.Min(l + 0.07f, 1.0f);
            return Color.FromHsla(h, s, lightness, Alpha);
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return (this as IMarkupExtension<Color>).ProvideValue(serviceProvider);
        }
    }
}
