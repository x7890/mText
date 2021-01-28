using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Ribbon;
using mText.Forms;
using System.Windows.Forms;

namespace mText
{
    partial class RibbonMain
    {

        private void 字数统计_Click(object sender, RibbonControlEventArgs e)
        {
            if (Control.ModifierKeys == Keys.None)
            {
                new TextCountForm().Count(app);
            }
            else
            {
                new TextCountForm().Show();
            }
        }

        private void 简洁复制_Click(object sender, RibbonControlEventArgs e)
        {
            if (app.Selection.Type == WdSelectionType.wdNoSelection || app.Selection.Type == WdSelectionType.wdSelectionIP)
            {
                Range oldRange = app.Selection.Range;
                // 需要先到行尾再选到行头，才不会复制段落标记
                app.Selection.EndKey(WdUnits.wdLine, WdMovementType.wdMove);
                app.Selection.HomeKey(WdUnits.wdLine, WdMovementType.wdExtend);
                Clipboard.SetText(app.Selection.Text.Trim());
                oldRange.Select();
            }
            else
            {
                Clipboard.SetText(app.Selection.Text.Trim());
            }
        }

        private void 简洁粘贴_Click(object sender, RibbonControlEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                new TextPasteForm().Show();
            }
            else if (Control.ModifierKeys == Keys.Alt)
            {
                new TextPasteForm().Paste(app);
            }
            else
            {
                string text = Clipboard.GetText(TextDataFormat.UnicodeText);
                text = text.Replace(" ", "");
                text = text.Replace("　", "");
                text = text.Replace("\n", "");
                text = text.Replace("\r", "");
                text = text.Replace("\t", "");
                app.Selection.TypeText(text);
            }
        }



        private void 去除网格_Click(object sender, RibbonControlEventArgs e)
        {
            if (Control.ModifierKeys == Keys.None)
            {
                app.ActiveDocument.PageSetup.LayoutMode = WdLayoutMode.wdLayoutModeDefault; // 无网格布局
            }
            else
            {
                app.ActiveDocument.PageSetup.LinesPage = 44; // 默认的44行网格
                app.ActiveDocument.PageSetup.LayoutMode = WdLayoutMode.wdLayoutModeLineGrid; // 行网格布局
            }
        }
        private void 自动断字_Click(object sender, RibbonControlEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                app.Selection.ParagraphFormat.Hyphenation = 0; // 禁止本段自动断字
            }
            else if (Control.ModifierKeys == Keys.Control)
            {
                app.ActiveDocument.AutoHyphenation = false; // 禁用全文自动断字
                app.ActiveDocument.HyphenationZone = 0; // 无断字空间
            }
            else
            { // 启用自动断字
                app.ActiveWindow.View.ShowHyphens = true; // 显示手动连字符
                app.ActiveDocument.AutoHyphenation = true; // 启用自动断字
                app.ActiveDocument.HyphenationZone = 36; // 设置断字空间
                app.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft; // 左对齐
                app.Selection.ParagraphFormat.WordWrap = -1; // 西文自动换行
                app.Selection.ParagraphFormat.Hyphenation = -1; // 允许自动断字
            }
        }

    }
}
