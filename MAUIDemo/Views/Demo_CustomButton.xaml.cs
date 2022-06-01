namespace MAUIDemo.Views;

public partial class Demo_CustomButton : ContentPage
{
    public Demo_CustomButton()
    {
        InitializeComponent();
    }

    private async void Alert_Click(object sender, EventArgs e)
    {
        await DisplayAlert("测试标题", "你点击了按钮", "确认");
    }
}