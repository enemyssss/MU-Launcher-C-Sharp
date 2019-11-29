using System;
using System.Windows.Forms;
using MyProg;
using System.Threading;




namespace MuOnlineLauncher
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            var path = new IniFile(@"Launcher\config.ini");
            var language = path.Read("Language");

            switch (language)
            {
                case "1":
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-EN");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-EN");
                    break;

                case "2":
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("bg-BG");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
                    break;

                case "3":
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
                    break;
                case "4":
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");
                    break;
                case "5":
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pl-PL");
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pl-PL");
                    break;

                default:
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-EN");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-EN");
                    break;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LauncherMenu());
        }
    }
}
