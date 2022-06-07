namespace MAUIDemo.Views;

public partial class Demo_BindableLayout : ContentPage
{
    public IList<Achievement> Achievements { get; set; } = new List<Achievement>();

    public Demo_BindableLayout()
    {
        InitializeComponent();
        Achievements.Add(new Achievement() { Text = "test1" });
        Achievements.Add(new Achievement() { Text = "test2" });

        //BindableLayout.SetItemsSource(layout, Achievements);
    }

    public class Achievement
    {
        public string Text { get; set; }
    }
}