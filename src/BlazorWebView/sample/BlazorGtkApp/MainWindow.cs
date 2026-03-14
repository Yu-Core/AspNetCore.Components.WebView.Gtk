using BlazorGtkApp.Components;
using Gtk;
using Microsoft.AspNetCore.Components.WebView.Gtk;

namespace BlazorGtkApp
{
    public class MainWindow : ApplicationWindow
    {
        public MainWindow(Application application, IServiceProvider serviceProvider)
            : base(new Gtk.Internal.ApplicationWindowHandle(Gtk.Internal.ApplicationWindow.New(application.Handle.DangerousGetHandle()), ownsHandle: false))
        {
            SetDefaultSize(1024, 768);

            this.OnDestroy += (o, e) =>
            {
                application.Quit();
            };

            var blazorWebView = new BlazorWebView();
            blazorWebView.HostPage = Path.Combine("wwwroot", "index.html");
            blazorWebView.Services = serviceProvider;
            blazorWebView.RootComponents.Add<Routes>("#app");

            this.SetChild(blazorWebView);
        }
    }
}
