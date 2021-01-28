using Microsoft.Office.Interop.Word;
using mText.Utils;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace mText.Forms
{
    public partial class TextPasteForm : Form
    {
        RegPref regPref;

        public TextPasteForm()
        {
            InitializeComponent();
            regPref = new RegPref(this);
        }

        private void 确定_Click(object sender, EventArgs e)
        {
            // 保存设置
            regPref.Save();
            Close();
        }

        private void 取消_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 重置_Click(object sender, EventArgs e)
        {
            regPref.Reset();
            Close();
        }

        public void Paste(Word.Application app)
        {
            Range range = app.Selection.Range; // 原始文档

            // 后台新建一个文档用于处理
            Document docTmp = app.Documents.Add(Visible: false);
            Range rangeTmp = docTmp.Range();
            rangeTmp.PasteAndFormat(WdRecoveryType.wdFormatOriginalFormatting);


            // 字体格式
            if (!reserveFontName.Checked) rangeTmp.Font.Name = range.Font.Name;
            if (!reserveFontSize.Checked) rangeTmp.Font.Size = range.Font.Size;
            if (!reserveForeColor.Checked) rangeTmp.Font.Color = range.Font.Color;
            if (!reserveBackColor.Checked) rangeTmp.HighlightColorIndex = range.HighlightColorIndex;
            if (!reserveBold.Checked) rangeTmp.Font.Bold = range.Font.Bold;
            if (!reserveItalic.Checked) rangeTmp.Font.Italic = range.Font.Italic;
            if (!reserveUnderline.Checked)
            {
                rangeTmp.Font.Underline = range.Font.Underline;
                rangeTmp.Font.UnderlineColor = range.Font.UnderlineColor;
            }
            if (!reserveScript.Checked)
            {
                rangeTmp.Font.Subscript = range.Font.Subscript;
                rangeTmp.Font.Superscript = range.Font.Superscript;
            }
            if (!reserveStrike.Checked)
            {
                rangeTmp.Font.StrikeThrough = range.Font.StrikeThrough;
                rangeTmp.Font.DoubleStrikeThrough = range.Font.DoubleStrikeThrough;
            }


            // 空白清理
            if (removeBackBlanks.Checked)
            {
                MatchCollection matches = Regex.Matches(docTmp.Range().Text, @"(\s+)$"); // 仅去除末尾空白
                if (matches.Count > 0)
                {
                    docTmp.Range(matches[0].Index, docTmp.Characters.Count).Delete();
                }
            }
            if (removeAllSpaces.Checked)
            {
                docTmp.Range().Find.Prepare("^w", "").Execute(Replace: WdReplace.wdReplaceAll);
            }
            if (removeBlankLines.Checked)
            {
                docTmp.Range().Find.Prepare("^w^p", "^p").Execute(Replace: WdReplace.wdReplaceAll);
                docTmp.Range().Find.Prepare("^p^p", "").Execute(Replace: WdReplace.wdReplaceAll);
            }
            if (removeAllLines.Checked)
            {
                docTmp.Range().Find.Prepare("^p", "").Execute(Replace: WdReplace.wdReplaceAll);
            }


            // 标点规范
            if (lowerParen.Checked) docTmp.Range().Find.Prepare("（", "(").Execute(Replace: WdReplace.wdReplaceAll);
            if (lowerParen.Checked) docTmp.Range().Find.Prepare("）", ")").Execute(Replace: WdReplace.wdReplaceAll);
            if (upperParen.Checked) docTmp.Range().Find.Prepare("(", "（").Execute(Replace: WdReplace.wdReplaceAll);
            if (upperParen.Checked) docTmp.Range().Find.Prepare(")", "）").Execute(Replace: WdReplace.wdReplaceAll);
            if (lowerBracket.Checked) docTmp.Range().Find.Prepare("【", "[").Execute(Replace: WdReplace.wdReplaceAll);
            if (lowerBracket.Checked) docTmp.Range().Find.Prepare("】", "]").Execute(Replace: WdReplace.wdReplaceAll);
            if (upperBracket.Checked) docTmp.Range().Find.Prepare("[", "【").Execute(Replace: WdReplace.wdReplaceAll);
            if (upperBracket.Checked) docTmp.Range().Find.Prepare("]", "】").Execute(Replace: WdReplace.wdReplaceAll);
            if (lowerBracket.Checked) docTmp.Range().Find.Prepare("｛", "{").Execute(Replace: WdReplace.wdReplaceAll);
            if (lowerBracket.Checked) docTmp.Range().Find.Prepare("｝", "}").Execute(Replace: WdReplace.wdReplaceAll);
            if (upperBracket.Checked) docTmp.Range().Find.Prepare("{", "｛").Execute(Replace: WdReplace.wdReplaceAll);
            if (upperBracket.Checked) docTmp.Range().Find.Prepare("}", "｝").Execute(Replace: WdReplace.wdReplaceAll);

            if (lowerComma.Checked)
                docTmp.Range().Find.Prepare("，", lowerCommaSpace.Checked ? ", " : ",").Execute(Replace: WdReplace.wdReplaceAll);
            if (lowerSemic.Checked)
                docTmp.Range().Find.Prepare("；", lowerSemicSpace.Checked ? "; " : ";").Execute(Replace: WdReplace.wdReplaceAll);
            if (lowerColon.Checked)
                docTmp.Range().Find.Prepare("：", lowerColonSpace.Checked ? ": " : ":").Execute(Replace: WdReplace.wdReplaceAll);
            if (upperComma.Checked) docTmp.Range().Find.Prepare(",", "，").Execute(Replace: WdReplace.wdReplaceAll);
            if (upperSemic.Checked) docTmp.Range().Find.Prepare(";", "；").Execute(Replace: WdReplace.wdReplaceAll);
            if (upperColon.Checked) docTmp.Range().Find.Prepare(":", "：").Execute(Replace: WdReplace.wdReplaceAll);

            if (lowerPlus.Checked) docTmp.Range().Find.Prepare("＋", "+").Execute(Replace: WdReplace.wdReplaceAll);
            if (lowerMinus.Checked) docTmp.Range().Find.Prepare("－", "-").Execute(Replace: WdReplace.wdReplaceAll);


            // 用剪贴板做中转并粘贴
            docTmp.Range(0, docTmp.Characters.Count - 1).Copy();
            app.Selection.Paste();

            docTmp.Close(SaveChanges: false); // 关闭临时文档，且不保存
        }



        // 3对括号
        private void lowerParen_CheckedChanged(object sender, EventArgs e)
        {
            if (lowerParen.Checked) upperParen.Checked = false;
        }
        private void upperParen_CheckedChanged(object sender, EventArgs e)
        {
            if (upperParen.Checked) lowerParen.Checked = false;
        }
        private void lowerBracket_CheckedChanged(object sender, EventArgs e)
        {
            if (lowerBracket.Checked) upperBracket.Checked = false;
        }
        private void upperBracket_CheckedChanged(object sender, EventArgs e)
        {
            if (upperBracket.Checked) lowerBracket.Checked = false;
        }
        private void lowerCurl_CheckedChanged(object sender, EventArgs e)
        {
            if (lowerCurl.Checked) upperCurl.Checked = false;
        }
        private void upperCurl_CheckedChanged(object sender, EventArgs e)
        {
            if (upperCurl.Checked) lowerCurl.Checked = false;
        }

        // 3对分号
        private void lowerComma_CheckedChanged(object sender, EventArgs e)
        {
            if (lowerCommaSpace.Enabled = lowerComma.Checked) upperComma.Checked = false;
        }

        private void upperComma_CheckedChanged(object sender, EventArgs e)
        {
            if (upperComma.Checked) lowerCommaSpace.Enabled = lowerComma.Checked = false;
        }

        private void lowerSemic_CheckedChanged(object sender, EventArgs e)
        {
            if (lowerSemicSpace.Enabled = lowerSemic.Checked) upperSemic.Checked = false;
        }

        private void upperSemic_CheckedChanged(object sender, EventArgs e)
        {
            if (upperSemic.Checked) lowerSemicSpace.Enabled = lowerSemic.Checked = false;
        }

        private void lowerColon_CheckedChanged(object sender, EventArgs e)
        {
            if (lowerColonSpace.Enabled = lowerColon.Checked) upperColon.Checked = false;
        }

        private void upperColon_CheckedChanged(object sender, EventArgs e)
        {
            if (upperColon.Checked) lowerColonSpace.Enabled = lowerColon.Checked = false;
        }



    }
}
