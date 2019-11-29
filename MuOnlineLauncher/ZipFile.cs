using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Windows.Forms;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Core;

namespace MuOnlineLauncher
{
    class ZipFileManager
    {
        public static void ExtractZipFile(string zipName,string unZipPath,string fileFilter)
        {
            try
            {
                FastZip fz = new FastZip();
                fz.ExtractZip(zipName, unZipPath, fileFilter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
