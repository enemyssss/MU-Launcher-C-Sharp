using System.Windows.Forms;
using System.Diagnostics;


namespace MuOnlineLauncher
{
    class KillTask
    {
        //Kill Task Func
        public void end_Task(string task)
        {
            string processName = task.Replace(".exe", "");
            foreach (Process process in Process.GetProcessesByName(processName))
            {
                MessageBox.Show("You can open the game only once!");
                process.Kill();
                
            }
        }
    }
}
