using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace TextDecoration.GTK
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();
            var app = new TextDecoration.App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("TextDecoration");
            window.Show();
            Gtk.Application.Run();
        }
    }
}