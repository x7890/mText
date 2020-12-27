using Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace mText
{
    public partial class FormCountSettings : Form
    {
        public FormCountSettings()
        {
            InitializeComponent();

            RegistryKey root = Registry.CurrentUser.OpenSubKey(RegPref.root);
            cbStartText.Checked = (int)root.GetValue("CountSettings.cbStartText", 0) == 1;
            numStartPage.Value = Math.Max((int)root.GetValue("CountSettings.numStartPage", 1), 1);
            numStartWord.Value = Math.Max((int)root.GetValue("CountSettings.numStartWord", 1), 1);
            txtStartText.Text = (string)root.GetValue("CountSettings.txtStartText", "");

            cbEndText.Checked = (int)root.GetValue("CountSettings.cbEndPage", 0) == 1;
            numEndPage.Value = Math.Max((int)root.GetValue("CountSettings.numEndPage", 1), 1);
            numEndWord.Value = Math.Max((int)root.GetValue("CountSettings.numEndWord", 1), 1);
            txtEndText.Text = (string)root.GetValue("CountSettings.txtEndText", "");

            root.Close();

            cbStartText_CheckedChanged(null, null);
            cbEndText_CheckedChanged(null, null);
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            // 检查文本框
            if (cbStartText.Checked && txtStartText.Text.Length == 0)
            {
                MessageBox.Show("开始计数文本为空，将取消勾选对应复选框", "字数统计设置");
                cbStartText.Checked = false;
            }
            if (cbEndText.Checked && txtEndText.Text.Length == 0)
            {
                MessageBox.Show("结束计数文本为空，将取消勾选对应复选框", "字数统计设置");
                cbEndText.Checked = false;
            }


            // 保存设置
            RegistryKey root = Registry.CurrentUser.OpenSubKey(RegPref.root, true);

            root.SetValue("CountSettings.cbStartText", cbStartText.Checked == true, RegistryValueKind.DWord);
            root.SetValue("CountSettings.numStartPage", numStartPage.Value, RegistryValueKind.DWord);
            root.SetValue("CountSettings.numStartWord", numStartWord.Value, RegistryValueKind.DWord);
            root.SetValue("CountSettings.txtStartText", txtStartText.Text);

            root.SetValue("CountSettings.cbEndPage", cbEndText.Checked == true, RegistryValueKind.DWord);
            root.SetValue("CountSettings.numEndPage", numEndPage.Value, RegistryValueKind.DWord);
            root.SetValue("CountSettings.numEndWord", numEndWord.Value, RegistryValueKind.DWord);
            root.SetValue("CountSettings.txtEndText", txtEndText.Text);
            root.Close();

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        // 显示计数
        public void Count(Microsoft.Office.Interop.Word.Application app)
        {
            string text;
            if (app.Selection.Type == WdSelectionType.wdNoSelection
                || app.Selection.Type == WdSelectionType.wdSelectionIP)
            {
                // 未选中区域
                Pages pages = app.ActiveWindow.Panes[1].Pages;
                int startPage = Math.Min((int)numStartPage.Value, pages.Count) - 1;
                int endPage = pages.Count - Math.Min((int)numEndPage.Value, pages.Count);
                if (startPage > endPage)
                {
                    MessageBox.Show("起始计数页在终止计数页之后", "字数统计");
                    return;
                }

                object objWhat = WdGoToItem.wdGoToPage;
                object objWhich = WdGoToDirection.wdGoToAbsolute;
                object objCount = startPage;
                object objMissing = Missing.Value;
                Range startPageRange = app.ActiveDocument.GoTo(ref objWhat, ref objWhich, ref objCount, ref objMissing);
                if (endPage < pages.Count - 1)
                {
                    objCount = endPage + 1;
                    Range endPageRange = app.ActiveDocument.GoTo(ref objWhat, ref objWhich, ref objCount, ref objMissing);
                    Range range = app.ActiveDocument.Range(startPageRange.Start, endPageRange.Start);
                    text = range.Text;
                }
                else
                {
                    Range range = app.ActiveDocument.Range(startPageRange.Start, app.ActiveDocument.Characters.Count);
                    text = range.Text;
                }

                if (cbStartText.Checked)
                {
                    MatchCollection matches = Regex.Matches(text, Regex.Escape(txtStartText.Text));
                    if (matches.Count < numStartWord.Value)
                    {
                        MessageBox.Show("从第" + startPage.ToString() + "页开始，" +
                                "总共只找到" + matches.Count.ToString() + "个“" + txtStartText.Text + "”", "字数统计-开始计数文本");
                        return;
                    }
                    text = text.Substring(matches[(int)numStartWord.Value - 1].Index + txtStartText.Text.Length);
                }

                if (cbEndText.Checked)
                {
                    MatchCollection matches = Regex.Matches(text, Regex.Escape(txtEndText.Text));
                    if (matches.Count < numEndWord.Value)
                    {
                        MessageBox.Show("从第" + endPage.ToString() + "页往前，" +
                                "总共只找到" + matches.Count.ToString() + "个“" + txtEndText.Text + "”", "字数统计-结束计数文本");
                        return;
                    }
                    text = text.Substring(0, matches[matches.Count - (int)numStartWord.Value].Index);
                }
            }
            else
            {
                // 选中区域，以选中区域为准
                text = app.Selection.Text;
            }

            int 字符数 = text.Length;
            int 英文词数 = Regex.Matches(text, @"[a-zA-Z0-9_\-\.@/\\:\$]+").Count;
            int 中文字数 = Regex.Matches(text, @"[\u4E00-\u9FA5]").Count;
            int 全角标点数 = Regex.Matches(text, @"[^\x00-\xff\u4E00-\u9FA5]").Count;
            int 全角字符数 = Regex.Matches(text, @"[^\x00-\xff]").Count;
            string msg = "";
            msg += "英文词数：" + 英文词数 + "\n";
            msg += "中文字数：" + 中文字数 + "\n";
            msg += "英文词数+中文字数：" + (英文词数 + 中文字数) + "\n";
            msg += "字符数(含标点与空白符)：" + 字符数 + "\n";
            msg += "全角标点数：" + 全角标点数 + "\n";
            msg += "全角字符数：" + 全角字符数 + "\n";
            MessageBox.Show(msg, "字数统计");
        }


        // 设置可用性

        private void cbStartText_CheckedChanged(object sender, EventArgs e)
        {
            numStartWord.Enabled = cbStartText.Checked;
            txtStartText.Enabled = cbStartText.Checked;
        }

        private void cbEndText_CheckedChanged(object sender, EventArgs e)
        {
            numEndWord.Enabled = cbEndText.Checked;
            txtEndText.Enabled = cbEndText.Checked;
        }
    }
}
