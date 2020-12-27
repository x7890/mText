using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mText
{
    class RegPref
    {
        public static string root = @"SOFTWARE\x7890\mText";

        public static void SavePref()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "mText";
            dialog.Filter = "注册表备份文件(*.reg)|*.reg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = dialog.FileName.ToString();
                Process.Start("regedit", "/e \"" + savePath + "\" \"HKEY_CURRENT_USER\\" + root + "\"");
            }
        }
    }
}
