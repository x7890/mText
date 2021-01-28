using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace mText.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void FormVersion_Load(object sender, EventArgs e)
        {

        }

        // 显示普通对话框
        public void ShowMsg(string msg, string title = "")
        {
            Text = title;
            linkLabelInfo.Text = msg;
            linkLabelInfo.Links.Clear();
            Height += linkLabelInfo.Height;
            Show();
        }

        // 显示帮助
        public void ShowHelp()
        {
            Height += linkLabelInfo.Height;
            Show();
        }

        // 显示程序版本
        public void ShowVersion()
        {
            int start;
            string link;

            Text = "程序版本";

            linkLabelInfo.Text = "";
            linkLabelInfo.Text += "mText v";
            linkLabelInfo.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
            linkLabelInfo.Text += " By x7890";
            linkLabelInfo.Text += "\n";

            linkLabelInfo.Text += "项目主页：";
            start = linkLabelInfo.Text.Length;
            link = "https://github.com/x7890/mText";
            linkLabelInfo.Text += link;
            linkLabelInfo.Links.Add(start, link.Length, link);
            linkLabelInfo.Text += "\n";

            linkLabelInfo.Text += "检查新版本：";
            start = linkLabelInfo.Text.Length;
            link = "https://github.com/x7890/mText/releases";
            linkLabelInfo.Text += link;
            linkLabelInfo.Links.Add(start, link.Length, link);
            linkLabelInfo.Text += "\n";

            Height += linkLabelInfo.Height;
            Show();
        }



        // 链接点击
        private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        // 确定按钮
        private void 确定_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
