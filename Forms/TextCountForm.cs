using Microsoft.Office.Interop.Word;
using mText.Utils;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace mText.Forms
{
    public partial class TextCountForm : Form
    {
        RegPref regPref;

        public TextCountForm()
        {
            InitializeComponent();
            regPref = new RegPref(this);
            enableSearchStart_CheckedChanged(null, null);
            enableSearchEnd_CheckedChanged(null, null);
        }

        // 设置可用性
        private void enableSearchStart_CheckedChanged(object sender, EventArgs e)
        {
            searchStartCount.Enabled = enableSearchStart.Checked;
            searchStartText.Enabled = enableSearchStart.Checked;
        }

        private void enableSearchEnd_CheckedChanged(object sender, EventArgs e)
        {
            searchEndCount.Enabled = enableSearchEnd.Checked;
            searchEndText.Enabled = enableSearchEnd.Checked;
        }



        private void 确定_Click(object sender, EventArgs e)
        {
            // 检查文本框
            if (enableSearchStart.Checked && searchStartText.Text.Length == 0)
            {
                MessageBox.Show("开始计数文本为空，将取消勾选对应复选框", "字数统计设置");
                enableSearchStart.Checked = false;
            }
            if (enableSearchEnd.Checked && searchEndText.Text.Length == 0)
            {
                MessageBox.Show("结束计数文本为空，将取消勾选对应复选框", "字数统计设置");
                enableSearchEnd.Checked = false;
            }
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


        [DllImport("user32.dll", SetLastError = true)]
        static extern int MessageBoxTimeout(IntPtr hwnd, string text, string title,
                                     uint type, short wLanguageId, int milliseconds);
        // 显示计数
        public void Count(Word.Application app)
        {
            string text;
            if (app.Selection.Type == WdSelectionType.wdNoSelection || app.Selection.Type == WdSelectionType.wdSelectionIP)
            {
                // 未选中区域
                Pages pages = app.ActiveWindow.Panes[1].Pages;
                int startPage = (int)Math.Min(expectedStartPage.Value, pages.Count);
                int endPage = (int)Math.Max(pages.Count - expectedEndPage.Value + 1, 1);
                if (startPage > endPage)
                {
                    MessageBox.Show("起始计数页在终止计数页之后", "字数统计");
                    return;
                }

                if (endPage <= pages.Count - 1)
                {
                    Range startPageRange = app.ActiveDocument.GoTo(WdGoToItem.wdGoToPage, WdGoToDirection.wdGoToAbsolute, startPage);
                    Range endPageRange = app.ActiveDocument.GoTo(WdGoToItem.wdGoToPage, WdGoToDirection.wdGoToAbsolute, endPage + 1);
                    Range range = app.ActiveDocument.Range(startPageRange.Start, endPageRange.Start);
                    text = range.Text;
                }
                else
                {
                    Range startPageRange = app.ActiveDocument.GoTo(WdGoToItem.wdGoToPage, WdGoToDirection.wdGoToAbsolute, startPage);
                    Range range = app.ActiveDocument.Range(startPageRange.Start, app.ActiveDocument.Characters.Count);
                    text = range.Text;
                }

                if (enableSearchStart.Checked)
                {
                    MatchCollection matches = Regex.Matches(text, Regex.Escape(searchStartText.Text));
                    if (matches.Count < searchStartCount.Value)
                    {
                        MessageBox.Show(string.Format("从第{0}页开始，总共只找到{1}个“{2}”", startPage, matches.Count, searchStartText.Text), "字数统计-开始计数文本");
                        return;
                    }
                    text = text.Substring(matches[(int)searchStartCount.Value - 1].Index + searchStartText.Text.Length);
                }

                if (enableSearchEnd.Checked)
                {
                    MatchCollection matches = Regex.Matches(text, Regex.Escape(searchEndText.Text));
                    if (matches.Count < searchEndCount.Value)
                    {
                        MessageBox.Show(string.Format("从第{0}页往前，总共只找到{1}个“{2}”", endPage, matches.Count, searchEndText.Text), "字数统计-结束计数文本");
                        return;
                    }
                    text = text.Substring(0, matches[matches.Count - (int)searchEndCount.Value].Index);
                }
            }
            else
            {
                // 选中区域，以选中区域为准
                text = app.Selection.Text;
            }

            StringBuilder msg = new StringBuilder();
            msg.AppendFormat("中文字数：{0}\n", Regex.Matches(text, @"[\p{IsCJKUnifiedIdeographs}]").Count);
            msg.AppendFormat("英文词数：{0}\n", Regex.Matches(text, @"[a-zA-Z0-9_\-\.@/\\:\$]+").Count);
            msg.AppendFormat("标点数：　{0}\n", Regex.Matches(text, @"[\p{P}]").Count);
            msg.AppendFormat("字符数：　{0}\n", text.Length);

            if (enableAutoClose.Checked)
            {
                MessageBoxTimeout(IntPtr.Zero, msg.ToString(), "字数统计", 0, 0, (int)(autoCloseTime.Value * 1000));
            }
            else
            {
                MessageBox.Show(msg.ToString(), "字数统计");
            }
        }

    }
}
