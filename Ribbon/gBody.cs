using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace mText
{
    // 正文编辑
    public partial class RibbonMain
    {

        // 字数统计
        private void gBody_btnCount_Click(object sender, RibbonControlEventArgs e)
        {
            new CountSettingsForm().Count(app);
        }
        // 字数统计-立刻统计
        private void gBody_btnCountNow_Click(object sender, RibbonControlEventArgs e)
        {
            new CountSettingsForm().Count(app);
        }
        // 字数统计-统计设置
        private void gBody_btnCountSettings_Click(object sender, RibbonControlEventArgs e)
        {
            new CountSettingsForm().Show();
        }


        // 公式字母
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


        // 简洁复制
        private void gBody_btnCopyText_Click(object sender, RibbonControlEventArgs e)
        {
            string text = app.Selection.Text;
            Clipboard.SetText(text);
        }



    }
}
