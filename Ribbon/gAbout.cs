using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace mText
{
    // 关于程序
    public partial class RibbonMain
    {

        // 使用说明
        private void gAbout_btnInfo_Click(object sender, RibbonControlEventArgs e)
        {
            string info = "";
            info += "以下使用A、B、C、D字母指代键盘按键，也包括屏幕上的按钮。\n";
            info += "按键表示方法说明：\n";
            info += "    A+B：按住A键，按一下B键，再松开A键。\n";
            info += "         也称作按下A键时按B键/点击B按钮，下同。\n";
            info += "    A+B+C：按住A、B键(顺序无关)，按一下C键，再松开A、B键。\n";
            info += "    A+B+C+D：按住A、B、C键不要松开，按一下D键，再松开A、B、C键。\n";
            info += "约定：对于用空格或逗号分隔的多个按键序列，依次独立完成即可。如：\n";
            info += "    “A B”表示按一下A键，再按一下B键；\n";
            info += "    “A+B C”表示按住A键，按一下B键，松开A键，再单独按一下C键。\n";
            info += "以上描述中，“按一下”表示按完后立刻松开。\n";
            info += "对于屏幕上的按钮，则为鼠标单击。\n";
            info += "\n";
            info += "右击屏幕按钮，可“添加到快速访问工具栏”。对于该工具栏上的按钮：\n";
            info += "    按一下“Alt”，快速访问工具栏将显示数字访问键。\n";
            info += "    按“Alt+对应数字”，或“Alt 对应数字”，可执行对应按键，\n";
            info += "        分别相当于“按下Alt时用鼠标点击该按钮”和“直接用鼠标点击该按钮”；\n";
            info += "        对于更长的访问键功能则同理。\n";
            info += "    按“Ctrl+Alt+对应数字”，相当于“按下Ctrl和Alt时用鼠标点击此按钮”。\n";
            info += "    按“Shift+Alt+对应数字”，相当于“按下Shift和Alt时用鼠标点击此按钮”。\n";
            info += "    按“Ctrl+Shift+Alt+对应数字”，相当于“按下Ctrl、Shift、Alt时用鼠标点击此按钮”。\n";
            info += "    其他无Alt键引导的按键序列无法仅使用键盘完成，仍应用鼠标点击按钮。\n";
            info += "    快速访问工具栏为Office自带功能，并非本扩展程序的功能。\n";
            info += "\n";
            info += "当鼠标悬停在按钮上时，屏幕上将显示各个按钮的简要使用帮助。\n";
            info += "\n";
            MessageBox.Show(info, "使用说明");
        }

        // 程序版本
        private void gAbout_btnVersion_Click(object sender, RibbonControlEventArgs e)
        {
            new VersionForm().Show();
        }

        // 设置备份
        private void gAbout_btnExportPref_Click(object sender, RibbonControlEventArgs e)
        {
            RegPref.SavePref();
        }


    }
}
