
namespace mText.Forms
{
    partial class FormulaShortcutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaShortcutForm));
            this.确定 = new System.Windows.Forms.Button();
            this.lvKeys = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabelInfo = new System.Windows.Forms.LinkLabel();
            this.imgGreek = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgGreek)).BeginInit();
            this.SuspendLayout();
            // 
            // 确定
            // 
            this.确定.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.确定.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.确定.Location = new System.Drawing.Point(314, 835);
            this.确定.MinimumSize = new System.Drawing.Size(100, 30);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(100, 30);
            this.确定.TabIndex = 0;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            this.确定.Click += new System.EventHandler(this.确定_Click);
            // 
            // lvKeys
            // 
            this.lvKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvKeys.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvKeys.FullRowSelect = true;
            this.lvKeys.GridLines = true;
            this.lvKeys.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvKeys.HideSelection = false;
            this.lvKeys.Location = new System.Drawing.Point(12, 12);
            this.lvKeys.Name = "lvKeys";
            this.lvKeys.Size = new System.Drawing.Size(703, 457);
            this.lvKeys.TabIndex = 2;
            this.lvKeys.UseCompatibleStateImageBehavior = false;
            this.lvKeys.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "";
            this.columnHeader0.Width = 1;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "第一次输入";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "第二次输入（如有）";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 185;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "　　　　对应内容";
            this.columnHeader3.Width = 319;
            // 
            // linkLabelInfo
            // 
            this.linkLabelInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabelInfo.AutoSize = true;
            this.linkLabelInfo.Font = new System.Drawing.Font("宋体", 9.5F);
            this.linkLabelInfo.LinkArea = new System.Windows.Forms.LinkArea(207, 3);
            this.linkLabelInfo.Location = new System.Drawing.Point(12, 482);
            this.linkLabelInfo.MaximumSize = new System.Drawing.Size(730, 0);
            this.linkLabelInfo.Name = "linkLabelInfo";
            this.linkLabelInfo.Size = new System.Drawing.Size(715, 132);
            this.linkLabelInfo.TabIndex = 4;
            this.linkLabelInfo.TabStop = true;
            this.linkLabelInfo.Text = resources.GetString("linkLabelInfo.Text");
            this.linkLabelInfo.UseCompatibleTextRendering = true;
            this.linkLabelInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfo_LinkClicked);
            // 
            // imgGreek
            // 
            this.imgGreek.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgGreek.Image = ((System.Drawing.Image)(resources.GetObject("imgGreek.Image")));
            this.imgGreek.Location = new System.Drawing.Point(127, 617);
            this.imgGreek.Name = "imgGreek";
            this.imgGreek.Size = new System.Drawing.Size(476, 212);
            this.imgGreek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGreek.TabIndex = 5;
            this.imgGreek.TabStop = false;
            // 
            // FormulaShortcutForm
            // 
            this.AcceptButton = this.确定;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.确定;
            this.ClientSize = new System.Drawing.Size(732, 877);
            this.Controls.Add(this.imgGreek);
            this.Controls.Add(this.linkLabelInfo);
            this.Controls.Add(this.lvKeys);
            this.Controls.Add(this.确定);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 800);
            this.Name = "FormulaShortcutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快捷键说明";
            ((System.ComponentModel.ISupportInitialize)(this.imgGreek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button 确定;
        private System.Windows.Forms.ListView lvKeys;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.LinkLabel linkLabelInfo;
        private System.Windows.Forms.PictureBox imgGreek;
    }
}