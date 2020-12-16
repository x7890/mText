using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace mText
{
    public partial class FormVersion : Form
    {
        public FormVersion()
        {
            InitializeComponent();
        }

        private void FormVersion_Load(object sender, EventArgs e)
        {
            int start;
            string link;

            linkLabel1.Text = "";
            linkLabel1.Text += "mText v";
            linkLabel1.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
            linkLabel1.Text += " By x7890";
            linkLabel1.Text += "\n";

            linkLabel1.Text += "项目主页：";
            start = linkLabel1.Text.Length;
            link = "https://github.com/x7890/mText";
            linkLabel1.Text += link;
            linkLabel1.Links.Add(start, link.Length, link);
            linkLabel1.Text += "\n";

            linkLabel1.Text += "检查新版本：";
            start = linkLabel1.Text.Length;
            link = "https://github.com/x7890/mText/releases";
            linkLabel1.Text += link;
            linkLabel1.Links.Add(start, link.Length, link);
            linkLabel1.Text += "\n";

            linkLabel1.Text += "要想卸载，请到控制面板进行移除。\n";

            Height += linkLabel1.Height;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
