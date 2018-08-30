using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace WorkingWithFonts.GTK
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();
            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("WorkingWithFonts");
            window.Show();
            Gtk.Application.Run();
        }
    }
}