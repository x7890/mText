using Microsoft.Office.Interop.Word;
using System;

namespace mText.Utils
{
    static class SelectionExtension
    {
        // 挖除域，对剩下的文本执行操作
        public static void ForEachText(this Selection sel, Action<Range> action)
        {
            var app = sel.Application;
            Range range = sel.Range;

            int next = range.Start;
            for (int i = 1; i <= range.Fields.Count; i++)
            {
                range.Fields[i].Select();
                Range rangeField = app.Selection.Range;
                if (next < rangeField.Start) action(app.ActiveDocument.Range(next, rangeField.Start));
                next = rangeField.End;
            }
            if (next < range.End) action(app.ActiveDocument.Range(next, range.End));
            
            range.Select(); // 重新选择原有选区
        }
    }

    static class RangeExtensin
    {
        public static Find Prepare(this Find find, string FindText, string ReplaceWith)
        {
            find.ClearFormatting();
            find.Text = FindText;
            find.Replacement.ClearFormatting();
            find.Replacement.Text = ReplaceWith;
            find.Format = false;

            // 将所有查找选项设置为保险值，保证纯文本原样替换
            find.CorrectHangulEndings = false;
            find.Forward = true;
            find.MatchByte = true; // 区分全半角
            find.MatchCase = true; // 区分大小写
            find.MatchControl = false;
            find.MatchDiacritics = false;
            find.MatchSoundsLike = false;
            find.MatchAllWordForms = false;
            find.MatchWholeWord = false;
            find.MatchWildcards = false; // 使用通配符
            find.Wrap = WdFindWrap.wdFindStop; // 查找完停止
            return find;
        }

    }
}
