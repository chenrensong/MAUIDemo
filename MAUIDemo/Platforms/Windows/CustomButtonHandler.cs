using MAUIDemo.Controls;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIDemo;

public partial class CustomButtonHandler : ViewHandler<ICustomButton, Microsoft.UI.Xaml.Controls.Button>
{

    protected override void ConnectHandler(Microsoft.UI.Xaml.Controls.Button platformView)
    {
        base.ConnectHandler(platformView);
        platformView.Click += PlatformView_Click;
    }

    protected override void DisconnectHandler(Microsoft.UI.Xaml.Controls.Button platformView)
    {
        base.DisconnectHandler(platformView);
        platformView.Click -= PlatformView_Click;
    }

    private void PlatformView_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        VirtualView.SendClick(sender, e);
    }

    public static void MapContent(CustomButtonHandler handler, ICustomButton view)
    {
        var nativeView = handler.PlatformView;
        nativeView.Content = view.Content;
    }

    protected override Microsoft.UI.Xaml.Controls.Button CreatePlatformView()
    {
        return new Microsoft.UI.Xaml.Controls.Button();
    }
}
