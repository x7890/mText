
namespace mText.Forms
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.linkLabelInfo = new System.Windows.Forms.LinkLabel();
            this.确定 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabelInfo
            // 
            this.linkLabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelInfo.AutoSize = true;
            this.linkLabelInfo.Font = new System.Drawing.Font("宋体", 9.5F);
            this.linkLabelInfo.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabelInfo.Location = new System.Drawing.Point(12, 9);
            this.linkLabelInfo.MaximumSize = new System.Drawing.Size(550, 0);
            this.linkLabelInfo.Name = "linkLabelInfo";
            this.linkLabelInfo.Size = new System.Drawing.Size(544, 480);
            this.linkLabelInfo.TabIndex = 1;
            this.linkLabelInfo.Text = resources.GetString("linkLabelInfo.Text");
            this.linkLabelInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfo_LinkClicked);
            // 
            // 确定
            // 
            this.确定.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.确定.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.确定.Location = new System.Drawing.Point(241, 13);
            this.确定.MinimumSize = new System.Drawing.Size(100, 30);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(100, 30);
            this.确定.TabIndex = 0;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            this.确定.Click += new System.EventHandler(this.确定_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 55);
            this.Controls.Add(this.确定);
            this.Controls.Add(this.linkLabelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "使用说明";
            this.Load += new System.EventHandler(this.FormVersion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelInfo;
        private System.Windows.Forms.Button 确定;
    }
}