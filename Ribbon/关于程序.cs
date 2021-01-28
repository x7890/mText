using Microsoft.Office.Tools.Ribbon;
using mText.Forms;
using mText.Utils;

namespace mText
{
    partial class RibbonMain
    {

        private void 使用说明_Click(object sender, RibbonControlEventArgs e)
        {
            new AboutForm().ShowHelp();
        }

        private void 程序版本_Click(object sender, RibbonControlEventArgs e)
        {
            new AboutForm().ShowVersion();
        }

        private void 设置备份_Click(object sender, RibbonControlEventArgs e)
        {
            RegPref.SaveToFile();
        }

    }
}
