using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using MyProg;


namespace MuOnlineLauncher
{
    public partial class LauncherMenu : Form
    {
        public LauncherMenu()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = Image.FromFile(@"Launcher\background.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // MAIN START
        //Play Button
        private void play_Click(object sender, EventArgs e)
        {
            var closeMain = new MuOnlineLauncher.KillTask();
            var update = new MuOnlineLauncher.Updater();
            try
            {
                update.CheckAndUpdate(); // Check for new version and 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            closeMain.end_Task("main"); // KILL MAIN 
            if (File.Exists("main.exe")) // MAIN CHECK
            {
                Process.Start("main.exe"); // MAIN START
            }
            else
            {
                MessageBox.Show("The file MAIN.EXE doesnt exist!"); //FALSE
            }

        }
        //Close Button
        private void close_Click(object sender, EventArgs e)
        {

            Application.Exit(); // Application EXIT
        }

        //Website Button
        private void website_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile(@"Launcher\config.ini");
            if (!File.Exists("Launcher/config.ini")) // config.ini check
            {
                MessageBox.Show("The file config.ini doesnt exist!");
            }
            else if (!MyIni.KeyExists("Website"))
            {
                MyIni.Write("Website", "http://127.0.0.1/");
                Application.Restart();
            }
            else
            {
                var website = MyIni.Read("Website");
                Process.Start(website);
            }
        }
        //Forum Button
        private void forum_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile(@"Launcher\config.ini");
            if (!File.Exists("Launcher/config.ini")) // config.ini check
            {
                MessageBox.Show("The file config.ini doesnt exist!");
            }
            else if (!MyIni.KeyExists("Forum"))
            {
                MyIni.Write("Forum", "http://127.0.0.1/");
                Application.Restart();
            }
            else
            {
                var forum = MyIni.Read("Forum");
                Process.Start(forum);
            }
        }

        //MENU - Settings
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void resolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        RegistryKey key = Registry.CurrentUser; // OUR REGISTERY KEY
        //FULL SCREEN Settings -->
        private void fullScreen800x600_Click(object sender, EventArgs e)
        {
            var chngResolution = new ResolutionSoundFunc();
            chngResolution.resolution(0x00000001, 0x00000001, 0x00000000, 0x00000005);//Resolution,ResolutionA,WindowMode,VolumeLevel
            Application.Restart();
        }

        private void fullScreen1024x768_Click(object sender, EventArgs e)
        {
            var chngResolution = new ResolutionSoundFunc();
            chngResolution.resolution(0x00000002, 0x00000002, 0x00000000, 0x00000005);//Resolution,ResolutionA,WindowMode,VolumeLevel
            Application.Restart();
        }

        private void fullScreen1280x1024_Click(object sender, EventArgs e)
        {
            var chngResolution = new ResolutionSoundFunc();
            chngResolution.resolution(0x00000003, 0x00000003, 0x00000000, 0x00000005);//Resolution,ResolutionA,WindowMode,VolumeLevel
            Application.Restart();
        }
        // FULL SCREEN SETTINGS END <---

        //Window Mode Settings -->
        private void windowScreen800x600_Click(object sender, EventArgs e)
        {
            var chngResolution = new ResolutionSoundFunc();
            chngResolution.resolution(0x00000001, 0x00000001, 0x00000001, 0x00000005);//Resolution,ResolutionA,WindowMode,VolumeLevel
            Application.Restart();
        }

        private void windowScreen1024x768_Click(object sender, EventArgs e)
        {
            var chngResolution = new ResolutionSoundFunc();
            chngResolution.resolution(0x00000002, 0x00000002, 0x00000001, 0x00000005);//Resolution,ResolutionA,WindowMode,VolumeLevel
            Application.Restart();
        }


        private void windowScreen1280x1024_Click(object sender, EventArgs e)
        {
            var chngResolution = new ResolutionSoundFunc();
            chngResolution.resolution(0x00000003, 0x00000003, 0x00000001, 0x00000005);//Resolution,ResolutionA,WindowMode,VolumeLevel
            Application.Restart();
        }

        //Window Mode Settings <--

        private void Launcher_Load(object sender, EventArgs e)
        {

        }

        private void windowScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        // Sound Settings
        // Sound ON -->
        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var soundOption = new ResolutionSoundFunc();
            soundOption.sound(0x00000005);  // Sound ON
            Application.Restart();
        }
        //Sound ON END <-- 

        // Sound OFF
        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var soundOption = new ResolutionSoundFunc();
            soundOption.sound(0x00000000);  // Sound OFF
            Application.Restart();
        }
        //Sound OFF END <--

        // Language Settings 
        //English
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile(@"Launcher\config.ini");
            if (!File.Exists("Launcher/config.ini")) // config.ini check
            {
                MessageBox.Show("The file config.ini doesnt exist!");
            }
            else if (!MyIni.KeyExists("Language"))
            {
                MyIni.Write("Language", "1");
                Application.Restart();
            }
            else
            {
                MyIni.DeleteKey("Language");
                MyIni.Write("Language", "1");
                Application.Restart();
            }
        }

        // Bulgarian Language
        private void bulgarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile(@"Launcher\config.ini");
            if (!File.Exists("Launcher/config.ini")) // config.ini check
            {
                MessageBox.Show("The file config.ini doesnt exist!");
            }
            else if (!MyIni.KeyExists("Language"))
            {
                MyIni.Write("Language", "1");
                Application.Restart();
            }
            else
            {
                MyIni.DeleteKey("Language");
                MyIni.Write("Language", "2");
                Application.Restart();
            }
        }

        //Spain Language
        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile(@"Launcher\config.ini");
            if (!File.Exists("Launcher/config.ini")) // config.ini check
            {
                MessageBox.Show("The file config.ini doesnt exist!");
            }
            else if (!MyIni.KeyExists("Language"))
            {
                MyIni.Write("Language", "1");
                Application.Restart();
            }
            else
            {
                MyIni.DeleteKey("Language");
                MyIni.Write("Language", "3");
                Application.Restart();
            }
        }

        //Russian Language
        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile(@"Launcher\config.ini");
            if (!File.Exists("Launcher/config.ini")) // config.ini check
            {
                MessageBox.Show("The file config.ini doesnt exist!");
            }
            else if (!MyIni.KeyExists("Language"))
            {
                MyIni.Write("Language", "1");
                Application.Restart();
            }
            else
            {
                MyIni.DeleteKey("Language");
                MyIni.Write("Language", "4");
                Application.Restart();
            }

        }

        private void PolishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MyIni = new IniFile(@"Launcher\config.ini");
            if (!File.Exists("Launcher/config.ini")) // config.ini check
            {
                MessageBox.Show("The file config.ini doesnt exist!");
            }
            else if (!MyIni.KeyExists("Language"))
            {
                MyIni.Write("Language", "1");
                Application.Restart();
            }
            else
            {
                MyIni.DeleteKey("Language");
                MyIni.Write("Language", "5");
                Application.Restart();
            }
        }

        private void LanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}


    

