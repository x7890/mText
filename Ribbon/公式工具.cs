using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using mText.Forms;
using mText.Utils;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace mText
{
    partial class RibbonMain
    {

        private void 公式工具_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            MessageBox.Show(
                "　　改变公式字体后，若要导出高清PDF，应使用“打印”中的虚拟打印机，而非“导出”功能；并在保存窗口的“选项”中取消“无法嵌入字体情况下显示文本位图”。\n" +
                "　　快捷公式功能仅当光标处在Office Math ML公式（新版Office公式）中时可用。\n" +
                "　　角标修正功能将避开已有上下标格式的文本，对其不做修改。若误添加上下标，请先清除上下标格式后再尝试自动修正上下标，或直接手动修正上下标。\n" +
                "　　矩阵粘贴功能中，若剪贴板文本中不包含明确表示矩阵的特征字符“[”、“]”、“;”、“,”，则需要相邻两列至少有2个连续空格，才会被识别为矩阵格式并分割为多列。否则将当做普通的列向量来转换。\n",
                "提示");
        }

        private void 快捷公式_Click(object sender, RibbonControlEventArgs e)
        {
            if (Control.ModifierKeys == Keys.None)
            {
                if (快捷公式.Checked)
                {
                    快捷公式.Tag = new KeysHook(FormulaShortcutForm.FormulaKeyConsumer);
                }
                else
                {
                    if (快捷公式.Tag is KeysHook) (快捷公式.Tag as KeysHook).Disable();
                }
            }
            else
            {
                快捷公式.Checked = !快捷公式.Checked; // 取消状态点击
                new FormulaShortcutForm().Show();
            }
        }


        private void 化学角标_Click(object sender, RibbonControlEventArgs e)
        {
            app.Selection.ForEachText((Range part) =>
            {
                // 上标
                foreach (Match match in Regex.Matches(part.Text, @"(?<=[A-Z][a-z]*\d*?)([1-9]?[+-])(?![A-Za-z0-9])"))
                {
                    Range range = app.ActiveDocument.Range(part.Start + match.Index, part.Start + match.Index + match.Length);
                    if (range.Font.Superscript == 0 && range.Font.Subscript == 0)
                        range.Font.Superscript = -1;
                }
                // 下标
                foreach (Match match in Regex.Matches(part.Text, @"(?<=[A-Z\(\)\[\]][a-z\(\)\[\]]*)(\d+)(?!\s*[+-]\s*[+-])"))
                {
                    Range range = app.ActiveDocument.Range(part.Start + match.Index, part.Start + match.Index + match.Length);
                    if (range.Font.Superscript == 0 && range.Font.Subscript == 0)
                        range.Font.Subscript = -1;
                    range = app.ActiveDocument.Range(part.Start + match.Index, part.Start + match.Index + match.Length - 1);
                    if (range.Font.Superscript == 0 && range.Font.Subscript == 0)
                        range.Font.Subscript = -1;
                }
            });

        }

        private void 数学下标_Click(object sender, RibbonControlEventArgs e)
        {
            int sub, sup;
            string pattern;
            if (Control.ModifierKeys == Keys.None)
            {
                sub = -1; sup = 0; // 下标
                pattern = @"(?<=([^_\s\d\p{P}\p{Sm}\p{IsCJKUnifiedIdeographs}]))([\.\da-zA-Z\p{IsGreek}]+)";
            }
            else
            {
                sub = 0; sup = -1; // 上标
                pattern = @"(?<=([^_\s\d\p{P}\p{Sm}\p{IsCJKUnifiedIdeographs}]|\D10))([+-]?([1-9]\d*))";
            }

            app.Selection.ForEachText((Range part) =>
            {
                foreach (Match match in Regex.Matches(part.Text, pattern))
                {
                    int start = part.Start + Math.Max(match.Index - 1, 0);
                    Range range = app.ActiveDocument.Range(start, start);
                    if (range.Font.Superscript == 0 && range.Font.Subscript == 0)
                    {
                        range = app.ActiveDocument.Range(part.Start + match.Index, part.Start + match.Index + match.Length);
                        if (range.Font.Superscript == 0 && range.Font.Subscript == 0)
                        {
                            range.Font.Subscript = sub;
                            range.Font.Superscript = sup;
                        }
                    }
                }

            });
        }

        private void 幂次上标_Click(object sender, RibbonControlEventArgs e)
        {
            int sub, sup;
            if (Control.ModifierKeys == Keys.None)
            {
                sub = 0; sup = -1; // 上标
            }
            else
            {
                sub = -1; sup = 0; // 下标
            }

            app.Selection.ForEachText((Range part) =>
            {
                // 幂次上标
                foreach (Match match in Regex.Matches(part.Text, @"(?<=[A-Za-z]*)(\d+)"))
                {
                    Range range = app.ActiveDocument.Range(part.Start + match.Index, part.Start + match.Index + match.Length);
                    if (range.Font.Superscript == 0 && range.Font.Subscript == 0)
                    {
                        range.Font.Subscript = sub;
                        range.Font.Superscript = sup;
                    }
                }
            });
        }

        private void 引文上标_Click(object sender, RibbonControlEventArgs e)
        {
            Range rangeOriginal = app.Selection.Range;
            // 疑似引用
            Find find = app.Selection.Find;
            find.Prepare(@"[\[【]*[\]】]", "^&");
            find.Format = true;
            find.Replacement.Font.Superscript = -1; // 上标
            find.MatchByte = false; // 不区分全半角
            find.MatchWildcards = true; // 使用通配符

            while (find.Execute(Replace: WdReplace.wdReplaceNone) && app.Selection.End <= rangeOriginal.End)
            {
                app.Selection.Range.Start = app.Selection.Range.End;
                if (app.Selection.Font.Superscript == 0 && app.Selection.Font.Subscript == 0 &&
                    Regex.IsMatch(app.Selection.Text, @"^[\[【][\d,-]+[\]】]$"))
                {
                    find.Execute(Replace: WdReplace.wdReplaceOne);
                }
                else
                {
                    find.Execute(Replace: WdReplace.wdReplaceNone); // 不是要找的文献引用，不替换
                }
            }
            rangeOriginal.Select();
        }

        private void 清除角标_Click(object sender, RibbonControlEventArgs e)
        {
            app.Selection.Font.Subscript = 0;
            app.Selection.Font.Superscript = 0;
        }


        private void 矩阵粘贴_Click(object sender, RibbonControlEventArgs e)
        {
            string text = Clipboard.GetText(TextDataFormat.UnicodeText);
            bool same = true; // 每行元素个数是否相同
            bool multiSpaces = text.Contains("  "); // 是否有连续空格

            text = Regex.Replace(text, @"\s+\+\s+", "+"); // 去除运算符空白
            text = Regex.Replace(text, @"\s+\-\s+", "-"); // 去除运算符空白
            text = Regex.Replace(text, @"\s+\*\s+", "*"); // 去除运算符空白
            text = Regex.Replace(text, @"\s+\/\s+", "/"); // 去除运算符空白
            text = Regex.Replace(text, @"\s+\^\s+", "^"); // 去除运算符空白

            text = Regex.Replace(text, @"[\n\r]+", "\n"); // 多换行转单换行
            text = Regex.Replace(text, @"[^\S\n\r]+", " "); // 多空格转单空格

            text = Regex.Replace(text, @"^\s+", ""); // 去除全文开头的空白
            text = Regex.Replace(text, @"\n\s+", "\n");  // 去除中间每行开头的空白
            text = Regex.Replace(text, @"\s+$", ""); // 去除全文结尾的空白

            if (!text.Contains("[") && !text.Contains("]")
                && !text.Contains(",") && !text.Contains(";")
                && !(text.Contains("\n") && multiSpaces)) // 多行时，还要求有连续的空格
                same = false; // 不是多列矩阵
            text = Regex.Replace(text, @"[\[\]]", ""); // 去除方括号
            if (text.Contains(";")) text = text.Replace(";", "\n"); // 行分割

            string[] map = @"alpha beta chi delta epsilon phi gamma eta iota kappa lambda mu nu pi theta rho sigma tau upsilon omega xi psi zeta hbar".Split();
            foreach (string alpha in map)
            {
                text = Regex.Replace(text, @"(?<![\w\\])" + alpha + @"(?![a-zA-Z])", @"\" + alpha);
                text = Regex.Replace(text, @"(?<=_)" + alpha + @"(?![a-zA-Z])", @"\" + alpha);
            }

            string[] lines = text.Split('\n');
            int M = lines.Length;
            string[][] elements = new string[M][];
            for (int i = 0; i < M; i++)
            {
                elements[i] = lines[i].Split(lines[i].Contains(",") ? ',' : ' '); // 有逗号则用逗号分隔，否则用空格分隔
                if (elements[i].Length != elements[0].Length)
                {
                    same = false;
                    break;
                }
            }

            if (same == false)
            {
                // 每行元素不同，应视作每行只有一个
                for (int i = 0; i < M; i++)
                {
                    elements[i] = new string[] { lines[i] };
                }
            }

            int N = elements[0].Length;
            // 分隔每个元素
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    string element = elements[i][j].Trim(); // 去除空白
                    element = element.Replace("*", "\\cdot "); // 替换乘号
                    element = Regex.Replace(element, @"sqrt", "\\sqrt"); // 现成根号
                    element = Regex.Replace(element, @"([^\(\)\s\+\-\*\/\^]+)\^\(1/2\)", "\\sqrt($1)"); // 替换根号
                    element = Regex.Replace(element, @"(?'c'\()([^\(\)]+)(?'-c'\))(?(c)(?!))\^\(1/2\)", "\\sqrt($1)");
                    elements[i][j] = element;
                }
            }


            app.Selection.Text = ""; // 清空选区
            app.Selection.OMaths.Add(app.Selection.Range);

            if (Control.ModifierKeys.HasFlag(Keys.Alt)) // 用方括号包起来
            {
                OMathFunction range = app.Selection.OMaths[1].Functions.Add(app.Selection.Range, WdOMathFunctionType.wdOMathFunctionDelim, 1);
                range.Delim.BegChar = (int)'[';
                range.Delim.SepChar = 0;
                range.Delim.EndChar = (int)']';
                range.Delim.Grow = true;
                range.Delim.Shape = WdOMathShapeType.wdOMathShapeCentered;
                app.Selection.MoveLeft(WdUnits.wdCharacter, 1, WdMovementType.wdMove);
            }


            app.Selection.OMaths[1].Functions.Add(app.Selection.Range, WdOMathFunctionType.wdOMathFunctionMat, M * N, N);
            app.Selection.MoveLeft(WdUnits.wdCharacter, M * N, WdMovementType.wdMove);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    app.Selection.TypeText(elements[i][j]);
                    app.Selection.MoveRight(WdUnits.wdCharacter, 1, WdMovementType.wdMove);
                }
            }

            app.Selection.OMaths.Linearize(); // 转为线性公式
            SendKeys.Send("^="); // 模拟按键，转为专业公式
        }


        private void 公式字体_ItemsLoading(object sender, RibbonControlEventArgs e)
        {
            if (!"loaded".Equals(公式字体.Tag))
            {
                foreach (string name in app.FontNames)
                {
                    if (name.ToLower().Contains("math") || name == "Times New Roman")
                    {
                        RibbonDropDownItem item = Factory.CreateRibbonDropDownItem();
                        item.Label = name;
                        公式字体.Items.Add(item);
                    }
                }
                公式字体.Tag = "loaded"; // 懒加载
            }
        }

        private void 公式字体_TextChanged(object sender, RibbonControlEventArgs e)
        {
            if (公式字体.Text != "")
            {
                foreach (OMath omath in app.Selection.OMaths)
                {
                    omath.Range.Font.Name = 公式字体.Text;
                }
            }
            公式字体.Text = "";
        }




    }
}
