using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace MuOnlineLauncher
{
    public class ResolutionSoundFunc
    {
        public void resolution(UInt32 resolutionName, UInt32 resolutionNameA, UInt32 windowMode, UInt32 volumeLevel)
        {
            RegistryKey key = Registry.CurrentUser; // OUR REGISTERY KEY
            key = key.OpenSubKey(@"Software\Webzen\Mu\Config", true);
            key.SetValue("Resolution", resolutionName, RegistryValueKind.DWord);
            key.SetValue("ResolutionA", resolutionNameA, RegistryValueKind.DWord);
            key.SetValue("WindowMode", windowMode, RegistryValueKind.DWord);
            key.SetValue("VolumeLevel", volumeLevel, RegistryValueKind.DWord);
            key.Close();
            MessageBox.Show("Resolution changed successful!");
        }
        public void sound(UInt32 sound)
        {
            RegistryKey key = Registry.CurrentUser; // OUR REGISTERY KEY
            key = key.OpenSubKey(@"Software\Webzen\Mu\Config", true);
            key.SetValue("VolumeLevel", sound, RegistryValueKind.DWord); // Set Volume Level to 1 - ON
            key.Close();
            if (sound != 0x00000005)
            {
                MessageBox.Show("The Sound is disabled!"); // Message
            }
            else
            {
                MessageBox.Show("The Sound is enabled!"); // Message
            }

        }
    }
}



