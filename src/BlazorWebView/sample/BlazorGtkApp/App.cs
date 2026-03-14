using Gtk;

namespace BlazorGtkApp
{
    public class App
    {
        private const string applicationId = "com.companyname.blazorgtkapp";

        private readonly Application app;

        private readonly IServiceProvider _serviceProvider;

        private ApplicationWindow? window;

        public App(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            app = Application.New(applicationId, Gio.ApplicationFlags.NonUnique);
            GLib.Functions.SetPrgname("BlazorGtkApp");
            // Set the human-readable application name for app bar and task list.
            GLib.Functions.SetApplicationName("BlazorGtkApp");
            app.OnActivate += ApplicationActivate;
        }

        private void ApplicationActivate(Gio.Application sender, EventArgs args)
        {
            window = new MainWindow(app, _serviceProvider);
            window.Present();
        }

        public int Run(string[] args)
        {
            try
            {
                string[] argv = [applicationId, .. args];
                return app.RunWithSynchronizationContext(argv);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return -1;
            }
        }
    }
}
