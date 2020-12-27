using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace mText
{
    public partial class RibbonMain
    {
        Word.Application app;

        private void RibbonMain_Load(object sender, RibbonUIEventArgs e)
        {
            app = Globals.ThisAddIn.Application;
        }

        // 正文编辑-字数统计
        private void gBody_btnCount_Click(object sender, RibbonControlEventArgs e)
        {
            new FormCountSettings().Count(app);
        }
        // 正文编辑-字数统计-立刻统计
        private void gBody_btnCountNow_Click(object sender, RibbonControlEventArgs e)
        {
            new FormCountSettings().Count(app);
        }
        // 正文编辑-字数统计-统计设置
        private void gBody_btnCountSettings_Click(object sender, RibbonControlEventArgs e)
        {
            new FormCountSettings().Show();
        }


        // 正文编辑-公式字母
        ShortcutHookHelper gBody_btnFormula_Hook = new ShortcutHookHelper();
        ShortcutHookHelper.KeyCodeChecker gBody_btnFormula_HookDelegate;
        bool gBody_btnFormula_waiting = false;
        private void gBody_btnFormula_Click(object sender, RibbonControlEventArgs e)
        {
            if (Control.ModifierKeys.HasFlag(Keys.Control))
            {
                gBody_btnFormula.Checked = !gBody_btnFormula.Checked;
                string info = "";
                info += "当光标处在公式区时：\n" +
                    "  按Ctrl+G并松开，再按字母键：插入小写希腊字母\n" +
                    "  按Ctrl+Shift+G，仅松开Ctrl(保留Shift)，再按字母键：插入大写希腊字母\n" +
                    "  按Ctrl+Alt+G，仅松开Ctrl(保留Alt)，再按字母键：插入小写手写体字母\n" +
                    "  按Ctrl+Alt+Shift+G，仅松开Ctrl(保留Alt+Shift)，再按字母键：插入大写手写体字母\n" +
                    "  按Ctrl+Alt+G，仅松开Alt(保留Ctrl)，再按字母键：插入小写双线体字母\n" +
                    "  按Ctrl+Alt+Shift+G，仅松开Alt(保留Ctrl+Shift)，再按字母键：插入大写双线体字母\n" +
                    "  按Ctrl+Alt+G并松开，再按字母键：插入小写哥特体字母\n" +
                    "  按Ctrl+Alt+Shift+G并松开，再按字母键：插入大写哥特体字母\n" +
                    "当切换Caps Lock时，大小写切换。\n" +
                    "总之，对和字母同时按的控制键，无控制键对应希腊字母，Alt对应手写体，Ctrl对应双线体，Ctrl+Alt对应哥特体；所有Shift用于切换大小写。\n" +
                    "插入完成之后，需要手动用空格或其他符号确认并完成转化。";
                MessageBox.Show(info, "说明");
            }
            else
            {
                if (gBody_btnFormula.Checked)
                { // 点击
                    gBody_btnFormula_HookDelegate = new ShortcutHookHelper.KeyCodeChecker(gBody_btnFormula_HookProc);
                    gBody_btnFormula_Hook.enable(gBody_btnFormula_HookDelegate);
                }
                else
                { // 取消点击
                    gBody_btnFormula_Hook.disable();
                }
            }
        }
        private bool gBody_btnFormula_HookProc(int code)
        {
            if (code == (int)Keys.CapsLock)
            {

            }
            else if (gBody_btnFormula_waiting)
            {
                string[] map = @"alpha beta chi delta varepsilon phi gamma eta iota varphi kappa lambda mu nu o pi theta rho sigma tau upsilon varpi omega xi psi zeta".Split();
                int cap = (Control.ModifierKeys.HasFlag(Keys.Shift) ? 1 : 0) ^ (Console.CapsLock ? 1 : 0); // 大小写

                if (code >= (int)Keys.A && code <= (int)Keys.Z)
                {
                    int id = code - (int)Keys.A;
                    char ch = (char)(id + (cap == 1 ? 'A' : 'a'));
                    if (Control.ModifierKeys.HasFlag(Keys.Alt) && Control.ModifierKeys.HasFlag(Keys.Control))
                    {
                        app.Selection.TypeText(@"\fraktur" + ch); // 哥特体
                    }
                    else if (Control.ModifierKeys.HasFlag(Keys.Alt))
                    {
                        app.Selection.TypeText(@"\script" + ch); // 手写体
                    }
                    else if (Control.ModifierKeys.HasFlag(Keys.Control))
                    {
                        app.Selection.TypeText(@"\double" + ch); // 双线体
                    }
                    else
                    {
                        string type = map[id];
                        if (cap == 1) type = type.Substring(0, 1).ToUpper() + type.Substring(1);
                        app.Selection.TypeText(@"\" + type); // 希腊字母
                    }
                }

                gBody_btnFormula_waiting = false;
                return true;
            }
            else if (code == (int)Keys.G && Control.ModifierKeys.HasFlag(Keys.Control))
            {
                if (app.Selection.OMaths.Count >= 1)
                {
                    gBody_btnFormula_waiting = true;
                    return true;
                }
            }
            return false;
        }



        // 关于程序-使用说明
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
        // 关于程序-程序版本
        private void gAbout_btnVersion_Click(object sender, RibbonControlEventArgs e)
        {
            new FormVersion().Show();
        }
        // 关于程序-设置备份
        private void gAbout_btnExportPref_Click(object sender, RibbonControlEventArgs e)
        {
            RegPref.SavePref();
        }


    }
}
