
namespace mText
{
    partial class FormCountSettings
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
            this.numStartPage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartText = new System.Windows.Forms.TextBox();
            this.numStartWord = new System.Windows.Forms.NumericUpDown();
            this.cbStartText = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupEnd = new System.Windows.Forms.GroupBox();
            this.numEndPage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndText = new System.Windows.Forms.TextBox();
            this.numEndWord = new System.Windows.Forms.NumericUpDown();
            this.cbEndText = new System.Windows.Forms.CheckBox();
            this.groupStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartWord)).BeginInit();
            this.groupEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndWord)).BeginInit();
            this.SuspendLayout();
            // 
            // groupStart
            // 
            this.groupStart.Controls.Add(this.numStartPage);
            this.groupStart.Controls.Add(this.label1);
            this.groupStart.Controls.Add(this.txtStartText);
            this.groupStart.Controls.Add(this.numStartWord);
            this.groupStart.Controls.Add(this.cbStartText);
            this.groupStart.Location = new System.Drawing.Point(13, 13);
            this.groupStart.Name = "groupStart";
            this.groupStart.Size = new System.Drawing.Size(459, 110);
            this.groupStart.TabIndex = 2;
            this.groupStart.TabStop = false;
            this.groupStart.Text = "开始计数位置";
            // 
            // numStartPage
            // 
            this.numStartPage.Location = new System.Drawing.Point(45, 19);
            this.numStartPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartPage.Name = "numStartPage";
            this.numStartPage.Size = new System.Drawing.Size(80, 25);
            this.numStartPage.TabIndex = 1;
            this.numStartPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "从第            页开始";
            // 
            // txtStartText
            // 
            this.txtStartText.Location = new System.Drawing.Point(30, 79);
            this.txtStartText.Name = "txtStartText";
            this.txtStartText.Size = new System.Drawing.Size(386, 25);
            this.txtStartText.TabIndex = 2;
            // 
            // numStartWord
            // 
            this.numStartWord.Location = new System.Drawing.Point(186, 50);
            this.numStartWord.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartWord.Name = "numStartWord";
            this.numStartWord.Size = new System.Drawing.Size(80, 25);
            this.numStartWord.TabIndex = 1;
            this.numStartWord.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbStartText
            // 
            this.cbStartText.AutoSize = true;
            this.cbStartText.Location = new System.Drawing.Point(6, 53);
            this.cbStartText.Name = "cbStartText";
            this.cbStartText.Size = new System.Drawing.Size(410, 19);
            this.cbStartText.TabIndex = 0;
            this.cbStartText.Text = "不晚于该页或以后，第            次出现的以下文本后";
            this.cbStartText.UseVisualStyleBackColor = true;
            this.cbStartText.CheckedChanged += new System.EventHandler(this.cbStartText_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(493, 84);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(139, 45);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(493, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupEnd
            // 
            this.groupEnd.Controls.Add(this.numEndPage);
            this.groupEnd.Controls.Add(this.label2);
            this.groupEnd.Controls.Add(this.txtEndText);
            this.groupEnd.Controls.Add(this.numEndWord);
            this.groupEnd.Controls.Add(this.cbEndText);
            this.groupEnd.Location = new System.Drawing.Point(13, 138);
            this.groupEnd.Name = "groupEnd";
            this.groupEnd.Size = new System.Drawing.Size(459, 110);
            this.groupEnd.TabIndex = 3;
            this.groupEnd.TabStop = false;
            this.groupEnd.Text = "结束计数位置";
            // 
            // numEndPage
            // 
            this.numEndPage.Location = new System.Drawing.Point(81, 22);
            this.numEndPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEndPage.Name = "numEndPage";
            this.numEndPage.Size = new System.Drawing.Size(80, 25);
            this.numEndPage.TabIndex = 1;
            this.numEndPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "到倒数第            页结束";
            // 
            // txtEndText
            // 
            this.txtEndText.Location = new System.Drawing.Point(30, 79);
            this.txtEndText.Name = "txtEndText";
            this.txtEndText.Size = new System.Drawing.Size(386, 25);
            this.txtEndText.TabIndex = 2;
            // 
            // numEndWord
            // 
            this.numEndWord.Location = new System.Drawing.Point(213, 49);
            this.numEndWord.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEndWord.Name = "numEndWord";
            this.numEndWord.Size = new System.Drawing.Size(80, 25);
            this.numEndWord.TabIndex = 1;
            this.numEndWord.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbEndText
            // 
            this.cbEndText.AutoSize = true;
            this.cbEndText.Location = new System.Drawing.Point(6, 53);
            this.cbEndText.Name = "cbEndText";
            this.cbEndText.Size = new System.Drawing.Size(440, 19);
            this.cbEndText.TabIndex = 0;
            this.cbEndText.Text = "不早于该页或以前，倒数第            次出现的以下文本前";
            this.cbEndText.UseVisualStyleBackColor = true;
            this.cbEndText.CheckedChanged += new System.EventHandler(this.cbEndText_CheckedChanged);
            // 
            // FormCountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 260);
            this.Controls.Add(this.groupEnd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCountSettings";
            this.Text = "字数统计设置";
            this.groupStart.ResumeLayout(false);
            this.groupStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartWord)).EndInit();
            this.groupEnd.ResumeLayout(false);
            this.groupEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndWord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupStart;
        private System.Windows.Forms.NumericUpDown numStartPage;
        private System.Windows.Forms.NumericUpDown numStartWord;
        private System.Windows.Forms.CheckBox cbStartText;
        private System.Windows.Forms.TextBox txtStartText;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupEnd;
        private System.Windows.Forms.TextBox txtEndText;
        private System.Windows.Forms.NumericUpDown numEndWord;
        private System.Windows.Forms.NumericUpDown numEndPage;
        private System.Windows.Forms.CheckBox cbEndText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}