
namespace mText.Forms
{
    partial class TextCountForm
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
            this.groupStart = new System.Windows.Forms.GroupBox();
            this.expectedStartPage = new System.Windows.Forms.NumericUpDown();
            this.labelStart = new System.Windows.Forms.Label();
            this.searchStartText = new System.Windows.Forms.TextBox();
            this.searchStartCount = new System.Windows.Forms.NumericUpDown();
            this.enableSearchStart = new System.Windows.Forms.CheckBox();
            this.确定 = new System.Windows.Forms.Button();
            this.取消 = new System.Windows.Forms.Button();
            this.groupEnd = new System.Windows.Forms.GroupBox();
            this.expectedEndPage = new System.Windows.Forms.NumericUpDown();
            this.labelEnd = new System.Windows.Forms.Label();
            this.searchEndText = new System.Windows.Forms.TextBox();
            this.searchEndCount = new System.Windows.Forms.NumericUpDown();
            this.enableSearchEnd = new System.Windows.Forms.CheckBox();
            this.autoCloseTime = new System.Windows.Forms.NumericUpDown();
            this.enableAutoClose = new System.Windows.Forms.CheckBox();
            this.重置 = new System.Windows.Forms.Button();
            this.groupStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expectedStartPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchStartCount)).BeginInit();
            this.groupEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expectedEndPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEndCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCloseTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupStart
            // 
            this.groupStart.Controls.Add(this.expectedStartPage);
            this.groupStart.Controls.Add(this.labelStart);
            this.groupStart.Controls.Add(this.searchStartText);
            this.groupStart.Controls.Add(this.searchStartCount);
            this.groupStart.Controls.Add(this.enableSearchStart);
            this.groupStart.Location = new System.Drawing.Point(13, 13);
            this.groupStart.Name = "groupStart";
            this.groupStart.Size = new System.Drawing.Size(459, 110);
            this.groupStart.TabIndex = 2;
            this.groupStart.TabStop = false;
            this.groupStart.Text = "开始计数位置";
            // 
            // expectedStartPage
            // 
            this.expectedStartPage.Location = new System.Drawing.Point(45, 19);
            this.expectedStartPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.expectedStartPage.Name = "expectedStartPage";
            this.expectedStartPage.Size = new System.Drawing.Size(80, 25);
            this.expectedStartPage.TabIndex = 1;
            this.expectedStartPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(3, 25);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(178, 15);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "从第            页开始";
            // 
            // searchStartText
            // 
            this.searchStartText.Location = new System.Drawing.Point(30, 79);
            this.searchStartText.Name = "searchStartText";
            this.searchStartText.Size = new System.Drawing.Size(386, 25);
            this.searchStartText.TabIndex = 2;
            // 
            // searchStartCount
            // 
            this.searchStartCount.Location = new System.Drawing.Point(186, 50);
            this.searchStartCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.searchStartCount.Name = "searchStartCount";
            this.searchStartCount.Size = new System.Drawing.Size(80, 25);
            this.searchStartCount.TabIndex = 1;
            this.searchStartCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // enableSearchStart
            // 
            this.enableSearchStart.AutoSize = true;
            this.enableSearchStart.Location = new System.Drawing.Point(6, 53);
            this.enableSearchStart.Name = "enableSearchStart";
            this.enableSearchStart.Size = new System.Drawing.Size(410, 19);
            this.enableSearchStart.TabIndex = 0;
            this.enableSearchStart.Text = "不晚于该页或以后，第            次出现的以下文本后";
            this.enableSearchStart.UseVisualStyleBackColor = true;
            this.enableSearchStart.CheckedChanged += new System.EventHandler(this.enableSearchStart_CheckedChanged);
            // 
            // 确定
            // 
            this.确定.Location = new System.Drawing.Point(493, 63);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(139, 45);
            this.确定.TabIndex = 0;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            this.确定.Click += new System.EventHandler(this.确定_Click);
            // 
            // 取消
            // 
            this.取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.取消.Location = new System.Drawing.Point(493, 119);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(139, 45);
            this.取消.TabIndex = 1;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // groupEnd
            // 
            this.groupEnd.Controls.Add(this.expectedEndPage);
            this.groupEnd.Controls.Add(this.labelEnd);
            this.groupEnd.Controls.Add(this.searchEndText);
            this.groupEnd.Controls.Add(this.searchEndCount);
            this.groupEnd.Controls.Add(this.enableSearchEnd);
            this.groupEnd.Location = new System.Drawing.Point(13, 138);
            this.groupEnd.Name = "groupEnd";
            this.groupEnd.Size = new System.Drawing.Size(459, 110);
            this.groupEnd.TabIndex = 3;
            this.groupEnd.TabStop = false;
            this.groupEnd.Text = "结束计数位置";
            // 
            // expectedEndPage
            // 
            this.expectedEndPage.Location = new System.Drawing.Point(77, 22);
            this.expectedEndPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.expectedEndPage.Name = "expectedEndPage";
            this.expectedEndPage.Size = new System.Drawing.Size(80, 25);
            this.expectedEndPage.TabIndex = 1;
            this.expectedEndPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(6, 27);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(208, 15);
            this.labelEnd.TabIndex = 3;
            this.labelEnd.Text = "到倒数第            页结束";
            // 
            // searchEndText
            // 
            this.searchEndText.Location = new System.Drawing.Point(30, 79);
            this.searchEndText.Name = "searchEndText";
            this.searchEndText.Size = new System.Drawing.Size(386, 25);
            this.searchEndText.TabIndex = 2;
            // 
            // searchEndCount
            // 
            this.searchEndCount.Location = new System.Drawing.Point(213, 49);
            this.searchEndCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.searchEndCount.Name = "searchEndCount";
            this.searchEndCount.Size = new System.Drawing.Size(80, 25);
            this.searchEndCount.TabIndex = 1;
            this.searchEndCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // enableSearchEnd
            // 
            this.enableSearchEnd.AutoSize = true;
            this.enableSearchEnd.Location = new System.Drawing.Point(6, 53);
            this.enableSearchEnd.Name = "enableSearchEnd";
            this.enableSearchEnd.Size = new System.Drawing.Size(440, 19);
            this.enableSearchEnd.TabIndex = 0;
            this.enableSearchEnd.Text = "不早于该页或以前，倒数第            次出现的以下文本前";
            this.enableSearchEnd.UseVisualStyleBackColor = true;
            this.enableSearchEnd.CheckedChanged += new System.EventHandler(this.enableSearchEnd_CheckedChanged);
            // 
            // autoCloseTime
            // 
            this.autoCloseTime.DecimalPlaces = 1;
            this.autoCloseTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.autoCloseTime.Location = new System.Drawing.Point(58, 257);
            this.autoCloseTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.autoCloseTime.Name = "autoCloseTime";
            this.autoCloseTime.Size = new System.Drawing.Size(80, 25);
            this.autoCloseTime.TabIndex = 1;
            this.autoCloseTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // enableAutoClose
            // 
            this.enableAutoClose.AutoSize = true;
            this.enableAutoClose.Location = new System.Drawing.Point(13, 260);
            this.enableAutoClose.Name = "enableAutoClose";
            this.enableAutoClose.Size = new System.Drawing.Size(290, 19);
            this.enableAutoClose.TabIndex = 0;
            this.enableAutoClose.Text = "在            秒后自动关闭统计结果";
            this.enableAutoClose.UseVisualStyleBackColor = true;
            this.enableAutoClose.CheckedChanged += new System.EventHandler(this.enableSearchEnd_CheckedChanged);
            // 
            // 重置
            // 
            this.重置.Location = new System.Drawing.Point(493, 175);
            this.重置.Name = "重置";
            this.重置.Size = new System.Drawing.Size(139, 45);
            this.重置.TabIndex = 1;
            this.重置.Text = "重置";
            this.重置.UseVisualStyleBackColor = true;
            this.重置.Click += new System.EventHandler(this.重置_Click);
            // 
            // TextCountForm
            // 
            this.AcceptButton = this.确定;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.取消;
            this.ClientSize = new System.Drawing.Size(644, 290);
            this.Controls.Add(this.autoCloseTime);
            this.Controls.Add(this.groupEnd);
            this.Controls.Add(this.重置);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.确定);
            this.Controls.Add(this.enableAutoClose);
            this.Controls.Add(this.groupStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextCountForm";
            this.Text = "字数统计设置";
            this.groupStart.ResumeLayout(false);
            this.groupStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expectedStartPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchStartCount)).EndInit();
            this.groupEnd.ResumeLayout(false);
            this.groupEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expectedEndPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEndCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoCloseTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupStart;
        private System.Windows.Forms.NumericUpDown expectedStartPage;
        private System.Windows.Forms.NumericUpDown searchStartCount;
        private System.Windows.Forms.CheckBox enableSearchStart;
        private System.Windows.Forms.TextBox searchStartText;
        private System.Windows.Forms.Button 确定;
        private System.Windows.Forms.Button 取消;
        private System.Windows.Forms.GroupBox groupEnd;
        private System.Windows.Forms.TextBox searchEndText;
        private System.Windows.Forms.NumericUpDown searchEndCount;
        private System.Windows.Forms.NumericUpDown expectedEndPage;
        private System.Windows.Forms.CheckBox enableSearchEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.NumericUpDown autoCloseTime;
        private System.Windows.Forms.CheckBox enableAutoClose;
        private System.Windows.Forms.Button 重置;
    }
}