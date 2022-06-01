using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace MAUIDemo.Views;

public partial class Demo_HttpServer : ContentPage
{
    IWebHost webHost = null;

    public Demo_HttpServer()
    {
        InitializeComponent();
        base.Loaded += Demo_HttpServer_Loaded;
    }

    private void Demo_HttpServer_Loaded(object sender, EventArgs e)
    {
        Task.Run(() =>
        {
            if (webHost != null)
            {
                return;
            }
            var builder = new WebHostBuilder()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .Configure(app =>
            {
                app.MapWhen(context =>
                {
                    return context.Request.Path.Value.StartsWith("/hi");
                }, builder =>
                {
                    builder.Run(async (context) =>
                    {
                        var value = string.Empty;
                        if (context.Request.Query.ContainsKey("switch"))
                        {
                            value = context.Request.Query["switch"];
                        }
                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            lbMsg.Text = value;
                        });
                        await context.Response.WriteAsync("hello world!");
                    });
                });
            }).UseKestrel((option) => { }).UseUrls("http://localhost:8080");
            webHost = builder.Build();
            webHost.Run();
        });
    }
}