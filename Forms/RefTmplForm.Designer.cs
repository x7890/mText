
namespace mText.Forms
{
    partial class RefTmplForm
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
            this.lbRefResult = new System.Windows.Forms.Label();
            this.tbRefResult = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbRefResult
            // 
            this.lbRefResult.AutoSize = true;
            this.lbRefResult.Location = new System.Drawing.Point(12, 9);
            this.lbRefResult.Name = "lbRefResult";
            this.lbRefResult.Size = new System.Drawing.Size(67, 15);
            this.lbRefResult.TabIndex = 1;
            this.lbRefResult.Text = "引用结果";
            // 
            // tbRefResult
            // 
            this.tbRefResult.Location = new System.Drawing.Point(15, 27);
            this.tbRefResult.Multiline = true;
            this.tbRefResult.Name = "tbRefResult";
            this.tbRefResult.Size = new System.Drawing.Size(397, 97);
            this.tbRefResult.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(490, 9);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 32);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInsert.Location = new System.Drawing.Point(571, 9);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 32);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "插入";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(652, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // RefTmplForm
            // 
            this.AcceptButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbRefResult);
            this.Controls.Add(this.lbRefResult);
            this.Name = "RefTmplForm";
            this.Text = "引文模板";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRefResult;
        private System.Windows.Forms.TextBox tbRefResult;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}