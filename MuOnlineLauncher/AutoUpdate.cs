using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MyProg;
using System.ComponentModel;


namespace MuOnlineLauncher
{
    class Updater
    {

        public void CheckAndUpdate()
        {
            var myFile = new IniFile(@"Launcher\config.ini"); // Read file config.ini - Inifile.cs
            var clientVersionWeb = myFile.Read("ClientVersionWeb"); // Read the ClientVersionWeb from file ClientVersionWeb - Inifile.cs
            var oldVersion = myFile.Read("Version"); // Takes the client version from the file config.ini
            var updatePath = myFile.Read("UpdatePath"); // Takes the url adresse from the file config.ini
            string newVersion = new WebClient().DownloadString(clientVersionWeb); // Checks the version on the webserver


            // Version Check
            if (oldVersion != newVersion)
            {
                if (!File.Exists("Launcher/config.ini")) // config.ini check
                {
                    MessageBox.Show("The file config.ini doesnt exist!");
                }
                else if (!myFile.KeyExists("ClientVersionWeb"))
                {
                    myFile.Write("ClientVersionWeb", "http://127.0.0.1/launcher/version.txt");
                    Application.Restart();
                }
                else if (!myFile.KeyExists("Version"))
                {
                    myFile.Write("Version", "1.0.0.0");
                    Application.Restart();
                }
                else if (!myFile.KeyExists("UpdatePath"))
                {
                    myFile.Write("UpdatePath", "http://127.0.0.1/launcher/update/update.zip");
                    Application.Restart();
                }
                else
                { 
                    MessageBox.Show("New update available!");
                    DownloadFile(updatePath, "update.zip");
                    ZipFileManager.ExtractZipFile("update.zip", @".\", null);
                    File.Delete("update.zip");
                    MessageBox.Show("Update finished successfully!");
                    Application.Restart();
                }
            }
        }

        //Download Function 
        private void DownloadFile(string url,string fileName)
        {
            WebClient cln = new WebClient();
            cln.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.33 Safari/537.36");
            cln.DownloadFile(url, fileName);
        }

        private void DownloadComplete(object sender,AsyncCompletedEventArgs e)
        {
            MessageBox.Show("New Update Downloaded successful!");
        }

    }
}
