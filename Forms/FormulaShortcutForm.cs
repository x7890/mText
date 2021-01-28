using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

namespace mText.Forms
{
    public partial class FormulaShortcutForm : Form
    {
        public FormulaShortcutForm()
        {
            InitializeComponent();

            string[][] data = {
                new string[]{"", "Ctrl+“G”", "字母",          "对应下方希腊字母（大写/小写）"},
                new string[]{"", "Ctrl+“G”", "Ctrl+字母",     "对应双线体字母（大写/小写）"},
                new string[]{"", "Ctrl+“G”", "Alt+字母",      "对应手写体字母（大写/小写）"},
                new string[]{"", "Ctrl+“G”", "Ctrl+Alt+字母", "对应哥特体字母（大写/小写）"},
                new string[]{"", "", "", ""},

                new string[]{"", "Ctrl+“G”", "“←”", "←（\\leftarrow或\\gets）"},
                new string[]{"", "Ctrl+“G”", "“→”", "→（\\rightarrow或\\to）"},
                new string[]{"", "Ctrl+“G”", "“↑”", "↑（\\uparrow）"},
                new string[]{"", "Ctrl+“G”", "“↓”", "↓（\\downarrow）"},
                new string[]{"", "Ctrl+“G”", "“1”", "↗（\\nearrow）：指向第1象限角平分线"},
                new string[]{"", "Ctrl+“G”", "“2”", "↖（\\nwarrow）：指向第2象限角平分线"},
                new string[]{"", "Ctrl+“G”", "“3”", "↙（\\searrow）：指向第3象限角平分线"},
                new string[]{"", "Ctrl+“G”", "“4”", "↘（\\swarrow）：指向第4象限角平分线"},
                new string[]{"", "Ctrl+“G”", "Ctrl+“←”", "⇐（\\Leftarrow）"},
                new string[]{"", "Ctrl+“G”", "Ctrl+“→”", "⇒（\\Rightarrow）"},
                new string[]{"", "Ctrl+“G”", "Ctrl+“↑”", "⇑（\\Uparrow）"},
                new string[]{"", "Ctrl+“G”", "Ctrl+“↓”", "⇓（\\Downarrow）"},
                new string[]{"", "Ctrl+“G”", "“-”", "↔（\\leftrightarrow）"},
                new string[]{"", "Ctrl+“G”", "“|”", "↕（\\updownarrow）"},
                new string[]{"", "Ctrl+“G”", "Ctrl+“-”", "⇔（\\Leftrightarrow）"},
                new string[]{"", "Ctrl+“G”", "Ctrl+“|”", "⇕（\\Updownarrow）"},
                new string[]{"", "", "", ""},


                new string[]{"", "Ctrl+“.”", "“.”", "·（\\cdot）"},
                new string[]{"", "Ctrl+“.”", "“-”", "…（\\dots或\\cdots）"},
                new string[]{"", "Ctrl+“.”", "“I”", "⋮（\\vdots）"},
                new string[]{"", "Ctrl+“.”", "“/”", "⋰（\\rddots）"},
                new string[]{"", "Ctrl+“.”", "“\\”", "⋱（\\ddots）"},
                new string[]{"", "Ctrl+“.”", "“1”", "时间1次微分后缀（\\dot）"},
                new string[]{"", "Ctrl+“.”", "“2”", "时间2次微分后缀（\\ddot）"},
                new string[]{"", "Ctrl+“.”", "“3”", "时间3次微分后缀（\\dddot）"},
                new string[]{"", "Ctrl+“.”", "“4”", "时间4次微分后缀（\\ddddot）"},
                new string[]{"", "Ctrl+“.”", "“P”", "∂（\\partial）"},
                new string[]{"", "Ctrl+“.”", "“N”", "▽（\\nabla）"},
                new string[]{"", "Ctrl+“.”", "“V”", "向量符号后缀（\\vec）"},
                new string[]{"", "Ctrl+“.”", "“B”", "均值符号后缀（\\bar）"},
                new string[]{"", "", "", ""},


                new string[]{"", "Ctrl+“K”", "“B”", "∵（\\because）"},
                new string[]{"", "Ctrl+“K”", "“T”", "∴（\\therefore）"},
                new string[]{"", "Ctrl+“K”", "“E”", "∃（\\exists）"},
                new string[]{"", "Ctrl+“K”", "“A”", "∀（\\forall）"},
                new string[]{"", "", "", ""},

                new string[]{"", "Ctrl+“K”", "“D”", "°（\\degree）"},
                new string[]{"", "Ctrl+“K”", "“R”", "根号（\\sqrt）"},
                new string[]{"", "Ctrl+“K”", "Ctrl+“R”", "立方根号（\\cbrt）"},
                new string[]{"", "", "", ""},

                new string[]{"", "Ctrl+“K”", "“7”", "∝（\\propto）：长得像&"},
                new string[]{"", "Ctrl+“K”", "“8”", "×（\\times）：长得像*"},
                new string[]{"", "Ctrl+“K”", "“0”", "∞（\\infty）：长得像00"},
                new string[]{"", "Ctrl+“K”", "“=”", "≡（\\equiv）"},
                new string[]{"", "Ctrl+“K”", "“~”", "≈（\\approx）：1左边的键"},
                new string[]{"", "Ctrl+“K”", "Ctrl+“.”", "⨀（\\odot）"},
                new string[]{"", "Ctrl+“K”", "Ctrl+“8”", "⨂（\\otimes）"},
                new string[]{"", "Ctrl+“K”", "Ctrl+“+”", "⊕（\\oplus）"},
                new string[]{"", "Ctrl+“K”", "“P”", "||（\\parallel）"},
                new string[]{"", "Ctrl+“K”", "“|”", "⊥（\\bot）"},
                new string[]{"", "", "", ""},

                new string[]{"", "Ctrl+“K”", "“I”", "带上下限积分"},
                new string[]{"", "Ctrl+“K”", "“S”", "带上下限求和"},
                new string[]{"", "Ctrl+“K”", "“C”", "左大括号（用于表示分类/分段）"}, // ？
                new string[]{"", "Ctrl+“K”", "“-”", "带字长等号"},
                new string[]{"", "Ctrl+“K”", "“/”", "斜分数线"},

                new string[]{"", "", "", ""},
            };
            foreach (string[] line in data)
            {
                lvKeys.Items.Add(new ListViewItem(line));
            }
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.unicode.org/notes/tn28/UTN28-PlainTextMath-v3.1.pdf");
        }


        // 按键钩子处理，返回true表示已消耗
        static bool mode_Greek = false; // Ctrl+G
        static bool mode_Dot = false;   // Ctrl+.
        static bool mode_Infer = false; // Ctrl+K
        public static bool FormulaKeyConsumer(Keys modifier, Keys key)
        {
            Word.Application app = Globals.ThisAddIn.Application;
            if (mode_Greek)
            {
                if (IsAccessKey(key, ref mode_Greek)) return false; // 辅助键，非想要的输入
                Key_Greek(app, modifier, key);
                mode_Greek = false;
                return true; // 消耗
            }
            if (mode_Dot)
            {
                if (IsAccessKey(key, ref mode_Dot)) return false;
                Key_Dot(app, modifier, key);
                mode_Dot = false;
                return true;
            }
            if (mode_Infer)
            {
                if (IsAccessKey(key, ref mode_Infer)) return false;
                Key_Infer(app, modifier, key);
                mode_Infer = false;
                return true;
            }

            if (app.Selection.OMaths.Count >= 1)
            {
                switch ((int)modifier + (int)key)
                {
                    case (int)Keys.Control + (int)Keys.G: mode_Greek = true; return true;
                    case (int)Keys.Control + (int)Keys.OemPeriod: mode_Dot = true; return true;
                    case (int)Keys.Control + (int)Keys.K: mode_Infer = true; return true;
                    default: break;
                }
            }

            return false; // 不是应该处理的按键，传给其他程序
        }

        static bool IsAccessKey(Keys key, ref bool state)
        {
            switch (key)
            {
                case Keys.CapsLock:
                case Keys.ControlKey:
                case Keys.Menu:
                case Keys.ShiftKey:
                    {
                        return true; // 辅助切换用的无副作用键，不退出激活模式
                    }
                case Keys.Space:
                    {
                        state = false; // 空格键：退出激活模式
                        return true;
                    }
                default:
                    return false;
            }
        }

        static void Key_Greek(Word.Application app, Keys modifer, Keys key)
        {
            switch (key)
            {
                case Keys k when k >= Keys.A && k <= Keys.Z:
                    {
                        int cap = (modifer.HasFlag(Keys.Shift) ? 1 : 0) ^ (Console.CapsLock ? 1 : 0); // 大小写
                        int id = (int)key - (int)Keys.A; // 字母键
                        char ch = (char)(id + (cap == 1 ? 'A' : 'a')); // 字母

                        if (modifer.HasFlag((int)Keys.Alt + Keys.Control))
                        {
                            app.Selection.TypeText("\\fraktur" + ch); // 哥特体
                        }
                        else if (modifer.HasFlag(Keys.Control))
                        {
                            app.Selection.TypeText("\\double" + ch); // 双线体
                        }
                        else if (modifer.HasFlag(Keys.Alt))
                        {
                            app.Selection.TypeText("\\script" + ch); // 手写体
                        }
                        else
                        {
                            // 希腊字母
                            string[] map = @"alpha beta chi delta epsilon phi gamma eta iota ? kappa lambda mu nu ? pi theta rho sigma tau upsilon ? omega xi psi zeta".Split();
                            string type = map[id];
                            switch (key)
                            {
                                case Keys.J: type = cap == 0 ? "varphi" : "vartheta"; break;
                                case Keys.O: type = cap == 0 ? "varrho" : "varsigma"; break;
                                case Keys.V: type = cap == 0 ? "varepsilon" : "varpi"; break;
                                default: if (cap == 1) type = type.Substring(0, 1).ToUpper() + type.Substring(1); break; // 转大写
                            }
                            app.Selection.TypeText("\\" + type);
                        }
                        break;
                    }
                case Keys.Left: app.Selection.TypeText(modifer == Keys.None ? "\\leftarrow" : "\\Leftarrow"); break;
                case Keys.Right: app.Selection.TypeText(modifer == Keys.None ? "\\rightarrow" : "\\Rightarrow"); break;
                case Keys.Up: app.Selection.TypeText(modifer == Keys.None ? "\\uparrow" : "\\Uparrow"); break;
                case Keys.Down: app.Selection.TypeText(modifer == Keys.None ? "\\downarrow" : "\\Downarrow"); break;

                case Keys.D1: app.Selection.TypeText("\\nearrow"); break;
                case Keys.D2: app.Selection.TypeText("\\nwarrow"); break;
                case Keys.D3: app.Selection.TypeText("\\searrow"); break;
                case Keys.D4: app.Selection.TypeText("\\swarrow"); break;

                case Keys.OemMinus:
                    app.Selection.TypeText(modifer == Keys.None ? "\\leftrightarrow" : "\\Leftrightarrow"); break;
                case Keys.OemPipe:
                    app.Selection.TypeText(modifer == Keys.None ? "\\updownarrow" : "\\Updownarrow"); break;

            }
        }
        static void Key_Dot(Word.Application app, Keys modifer, Keys key)
        {
            switch (key)
            {
                case Keys.OemPeriod: app.Selection.TypeText("\\cdot"); break;
                case Keys.OemMinus: app.Selection.TypeText("\\cdots"); break;
                case Keys.I: app.Selection.TypeText("\\vdots"); break;
                case Keys.OemQuestion: app.Selection.TypeText("\\rddots"); break;
                case Keys.OemPipe: app.Selection.TypeText("\\ddots"); break;

                case Keys.D1: app.Selection.TypeText("\\dot"); break;
                case Keys.D2: app.Selection.TypeText("\\ddot"); break;
                case Keys.D3: app.Selection.TypeText("\\dddot"); break;
                case Keys.D4: app.Selection.TypeText("\\ddddot"); break;

                case Keys.P: app.Selection.TypeText("\\partial"); break;
                case Keys.N: app.Selection.TypeText("\\nabla"); break;
                case Keys.V: app.Selection.TypeText("\\vec"); break;
                case Keys.B: app.Selection.TypeText("\\bar"); break;

            }
        }
        static void Key_Infer(Word.Application app, Keys modifer, Keys key)
        {
            switch (key)
            {
                case Keys.B: app.Selection.TypeText("\\because"); break;
                case Keys.T: app.Selection.TypeText("\\therefore"); break;
                case Keys.E: app.Selection.TypeText("\\exists"); break;
                case Keys.A: app.Selection.TypeText("\\forall"); break;

                case Keys.D: app.Selection.TypeText("\\degree"); break;
                case Keys.R: app.Selection.TypeText(modifer == Keys.None ? "\\sqrt" : "\\cbrt"); break;

                case Keys.D7: app.Selection.TypeText("\\propto"); break;
                case Keys.D8: app.Selection.TypeText(modifer == Keys.None ? "\\times" : "\\otimes"); break;
                case Keys.D0: app.Selection.TypeText("\\infty"); break;

                case Keys.Oemplus: app.Selection.TypeText(modifer == Keys.None ? "\\equiv" : "\\oplus"); break;
                case Keys.Oemtilde: app.Selection.TypeText("\\approx"); break;

                case Keys.OemPeriod: app.Selection.TypeText("\\odot"); break;

                case Keys.P: app.Selection.TypeText("\\parallel"); break;
                case Keys.OemPipe: app.Selection.TypeText("\\bot"); break;

                case Keys.I: AddIntegral(app); break;
                case Keys.S: AddSum(app); break;
                case Keys.C: AddCurl(app); break;
                case Keys.OemMinus: AddLongEqual(app); break;
                case Keys.OemQuestion: AddFraction(app); break;

            }
        }

        // 插入带上下限积分
        static void AddIntegral(Word.Application app)
        {
            app.Selection.OMaths.Add(app.Selection.Range);
            OMathFunction range = app.Selection.OMaths[1].Functions.Add(app.Selection.Range, WdOMathFunctionType.wdOMathFunctionNary);
            range.Nary.Char = (int)'∫';
            range.Nary.Grow = false;
            range.Nary.SubSupLim = true;
            range.Nary.HideSub = false;
            range.Nary.HideSub = false;
            app.Selection.MoveLeft(WdUnits.wdCharacter, 3, WdMovementType.wdMove); // 移动光标至积分下限
        }
        // 插入带上下限求和
        static void AddSum(Word.Application app)
        {
            app.Selection.OMaths.Add(app.Selection.Range);
            OMathFunction range = app.Selection.OMaths[1].Functions.Add(app.Selection.Range, WdOMathFunctionType.wdOMathFunctionNary);
            range.Nary.Char = (int)'∑';
            range.Nary.Grow = false;
            range.Nary.SubSupLim = false; // 写在上下方
            range.Nary.HideSub = false;
            range.Nary.HideSub = false;
            app.Selection.MoveLeft(WdUnits.wdCharacter, 3, WdMovementType.wdMove); // 移动光标至求和下限
        }
        // 插入左大括号
        static void AddCurl(Word.Application app)
        {
            app.Selection.OMaths.Add(app.Selection.Range);
            OMathFunction range = app.Selection.OMaths[1].Functions.Add(app.Selection.Range, WdOMathFunctionType.wdOMathFunctionDelim, 1);
            range.Delim.BegChar = (int)'{';
            range.Delim.SepChar = 0;
            range.Delim.EndChar = 0;
            range.Delim.Grow = true;
            range.Delim.Shape = WdOMathShapeType.wdOMathShapeCentered;
            app.Selection.MoveLeft(WdUnits.wdCharacter, 1, WdMovementType.wdMove);
        }
        // 插入带字长等号
        static void AddLongEqual(Word.Application app)
        {
            app.Selection.OMaths.Add(app.Selection.Range);
            app.Selection.TypeText(" "); // 与分数前面分开
            OMathFunction range = app.Selection.OMaths[1].Functions.Add(app.Selection.Range, WdOMathFunctionType.wdOMathFunctionFrac);
            range.Frac.Type = WdOMathFracType.wdOMathFracBar;
            app.Selection.TypeText(" "); // 与分数后面分开

            app.Selection.MoveLeft(WdUnits.wdCharacter, 2, WdMovementType.wdMove);
            app.Selection.TypeText(" "); // 分母占位
            app.Selection.OMaths[1].BuildUp();

            app.Selection.MoveUp(WdUnits.wdLine, 1, WdMovementType.wdMove);
            range = app.Selection.OMaths[1].Functions.Add(app.Selection.Range, WdOMathFunctionType.wdOMathFunctionBar);
            range.Bar.BarTop = false;

            app.Selection.MoveLeft(WdUnits.wdCharacter, 1, WdMovementType.wdMove);
        }
        // 插入斜分数线
        static void AddFraction(Word.Application app)
        {
            app.Selection.OMaths.Add(app.Selection.Range);
            OMathFunction range = app.Selection.OMaths[1].Functions.Add(app.Selection.Range, WdOMathFunctionType.wdOMathFunctionFrac);
            range.Frac.Type = WdOMathFracType.wdOMathFracSkw;
            app.Selection.MoveLeft(WdUnits.wdCharacter, 2, WdMovementType.wdMove);
        }

    }
}
