
namespace mText.Forms
{
    partial class TextPasteForm
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
            this.groupBlank = new System.Windows.Forms.GroupBox();
            this.removeBlankLines = new System.Windows.Forms.CheckBox();
            this.removeAllLines = new System.Windows.Forms.CheckBox();
            this.removeAllSpaces = new System.Windows.Forms.CheckBox();
            this.removeBackBlanks = new System.Windows.Forms.CheckBox();
            this.确定 = new System.Windows.Forms.Button();
            this.取消 = new System.Windows.Forms.Button();
            this.重置 = new System.Windows.Forms.Button();
            this.groupFont = new System.Windows.Forms.GroupBox();
            this.reserveStrike = new System.Windows.Forms.CheckBox();
            this.reserveScript = new System.Windows.Forms.CheckBox();
            this.reserveUnderline = new System.Windows.Forms.CheckBox();
            this.reserveItalic = new System.Windows.Forms.CheckBox();
            this.reserveBold = new System.Windows.Forms.CheckBox();
            this.reserveBackColor = new System.Windows.Forms.CheckBox();
            this.reserveForeColor = new System.Windows.Forms.CheckBox();
            this.reserveFontSize = new System.Windows.Forms.CheckBox();
            this.reserveFontName = new System.Windows.Forms.CheckBox();
            this.groupPunct = new System.Windows.Forms.GroupBox();
            this.lowerMinus = new System.Windows.Forms.CheckBox();
            this.lowerPlus = new System.Windows.Forms.CheckBox();
            this.upperColon = new System.Windows.Forms.CheckBox();
            this.lowerColonSpace = new System.Windows.Forms.CheckBox();
            this.lowerColon = new System.Windows.Forms.CheckBox();
            this.upperSemic = new System.Windows.Forms.CheckBox();
            this.lowerSemicSpace = new System.Windows.Forms.CheckBox();
            this.lowerSemic = new System.Windows.Forms.CheckBox();
            this.upperComma = new System.Windows.Forms.CheckBox();
            this.lowerCommaSpace = new System.Windows.Forms.CheckBox();
            this.lowerComma = new System.Windows.Forms.CheckBox();
            this.upperCurl = new System.Windows.Forms.CheckBox();
            this.lowerCurl = new System.Windows.Forms.CheckBox();
            this.upperBracket = new System.Windows.Forms.CheckBox();
            this.lowerBracket = new System.Windows.Forms.CheckBox();
            this.upperParen = new System.Windows.Forms.CheckBox();
            this.lowerParen = new System.Windows.Forms.CheckBox();
            this.groupBlank.SuspendLayout();
            this.groupFont.SuspendLayout();
            this.groupPunct.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBlank
            // 
            this.groupBlank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBlank.Controls.Add(this.removeBlankLines);
            this.groupBlank.Controls.Add(this.removeAllLines);
            this.groupBlank.Controls.Add(this.removeAllSpaces);
            this.groupBlank.Controls.Add(this.removeBackBlanks);
            this.groupBlank.Location = new System.Drawing.Point(13, 13);
            this.groupBlank.Name = "groupBlank";
            this.groupBlank.Size = new System.Drawing.Size(317, 84);
            this.groupBlank.TabIndex = 3;
            this.groupBlank.TabStop = false;
            this.groupBlank.Text = "空白清理";
            // 
            // removeBlankLines
            // 
            this.removeBlankLines.AutoSize = true;
            this.removeBlankLines.Checked = true;
            this.removeBlankLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeBlankLines.Location = new System.Drawing.Point(6, 49);
            this.removeBlankLines.Name = "removeBlankLines";
            this.removeBlankLines.Size = new System.Drawing.Size(119, 19);
            this.removeBlankLines.TabIndex = 2;
            this.removeBlankLines.Text = "去除所有空行";
            this.removeBlankLines.UseVisualStyleBackColor = true;
            // 
            // removeAllLines
            // 
            this.removeAllLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeAllLines.AutoSize = true;
            this.removeAllLines.Checked = true;
            this.removeAllLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeAllLines.Location = new System.Drawing.Point(184, 49);
            this.removeAllLines.Name = "removeAllLines";
            this.removeAllLines.Size = new System.Drawing.Size(119, 19);
            this.removeAllLines.TabIndex = 3;
            this.removeAllLines.Text = "去除所有换行";
            this.removeAllLines.UseVisualStyleBackColor = true;
            // 
            // removeAllSpaces
            // 
            this.removeAllSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeAllSpaces.AutoSize = true;
            this.removeAllSpaces.Checked = true;
            this.removeAllSpaces.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeAllSpaces.Location = new System.Drawing.Point(184, 24);
            this.removeAllSpaces.Name = "removeAllSpaces";
            this.removeAllSpaces.Size = new System.Drawing.Size(119, 19);
            this.removeAllSpaces.TabIndex = 1;
            this.removeAllSpaces.Text = "去除所有空格";
            this.removeAllSpaces.UseVisualStyleBackColor = true;
            // 
            // removeBackBlanks
            // 
            this.removeBackBlanks.AutoSize = true;
            this.removeBackBlanks.Checked = true;
            this.removeBackBlanks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeBackBlanks.Location = new System.Drawing.Point(6, 24);
            this.removeBackBlanks.Name = "removeBackBlanks";
            this.removeBackBlanks.Size = new System.Drawing.Size(119, 19);
            this.removeBackBlanks.TabIndex = 0;
            this.removeBackBlanks.Text = "去除末尾空白";
            this.removeBackBlanks.UseVisualStyleBackColor = true;
            // 
            // 确定
            // 
            this.确定.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.确定.Location = new System.Drawing.Point(38, 502);
            this.确定.Name = "确定";
            this.确定.Size = new System.Drawing.Size(84, 39);
            this.确定.TabIndex = 0;
            this.确定.Text = "确定";
            this.确定.UseVisualStyleBackColor = true;
            this.确定.Click += new System.EventHandler(this.确定_Click);
            // 
            // 取消
            // 
            this.取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.取消.Location = new System.Drawing.Point(128, 502);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(84, 39);
            this.取消.TabIndex = 1;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = true;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // 重置
            // 
            this.重置.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.重置.Location = new System.Drawing.Point(218, 502);
            this.重置.Name = "重置";
            this.重置.Size = new System.Drawing.Size(84, 39);
            this.重置.TabIndex = 2;
            this.重置.Text = "重置";
            this.重置.UseVisualStyleBackColor = true;
            this.重置.Click += new System.EventHandler(this.重置_Click);
            // 
            // groupFont
            // 
            this.groupFont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFont.Controls.Add(this.reserveStrike);
            this.groupFont.Controls.Add(this.reserveScript);
            this.groupFont.Controls.Add(this.reserveUnderline);
            this.groupFont.Controls.Add(this.reserveItalic);
            this.groupFont.Controls.Add(this.reserveBold);
            this.groupFont.Controls.Add(this.reserveBackColor);
            this.groupFont.Controls.Add(this.reserveForeColor);
            this.groupFont.Controls.Add(this.reserveFontSize);
            this.groupFont.Controls.Add(this.reserveFontName);
            this.groupFont.Location = new System.Drawing.Point(13, 103);
            this.groupFont.Name = "groupFont";
            this.groupFont.Size = new System.Drawing.Size(317, 163);
            this.groupFont.TabIndex = 4;
            this.groupFont.TabStop = false;
            this.groupFont.Text = "字体格式";
            // 
            // reserveStrike
            // 
            this.reserveStrike.AutoSize = true;
            this.reserveStrike.Location = new System.Drawing.Point(7, 128);
            this.reserveStrike.Name = "reserveStrike";
            this.reserveStrike.Size = new System.Drawing.Size(104, 19);
            this.reserveStrike.TabIndex = 8;
            this.reserveStrike.Text = "保留删除线";
            this.reserveStrike.UseVisualStyleBackColor = true;
            // 
            // reserveScript
            // 
            this.reserveScript.AutoSize = true;
            this.reserveScript.Location = new System.Drawing.Point(184, 101);
            this.reserveScript.Name = "reserveScript";
            this.reserveScript.Size = new System.Drawing.Size(104, 19);
            this.reserveScript.TabIndex = 7;
            this.reserveScript.Text = "保留上下标";
            this.reserveScript.UseVisualStyleBackColor = true;
            // 
            // reserveUnderline
            // 
            this.reserveUnderline.AutoSize = true;
            this.reserveUnderline.Location = new System.Drawing.Point(7, 102);
            this.reserveUnderline.Name = "reserveUnderline";
            this.reserveUnderline.Size = new System.Drawing.Size(104, 19);
            this.reserveUnderline.TabIndex = 6;
            this.reserveUnderline.Text = "保留下划线";
            this.reserveUnderline.UseVisualStyleBackColor = true;
            // 
            // reserveItalic
            // 
            this.reserveItalic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reserveItalic.AutoSize = true;
            this.reserveItalic.Location = new System.Drawing.Point(184, 75);
            this.reserveItalic.Name = "reserveItalic";
            this.reserveItalic.Size = new System.Drawing.Size(89, 19);
            this.reserveItalic.TabIndex = 5;
            this.reserveItalic.Text = "保留斜体";
            this.reserveItalic.UseVisualStyleBackColor = true;
            // 
            // reserveBold
            // 
            this.reserveBold.AutoSize = true;
            this.reserveBold.Checked = true;
            this.reserveBold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reserveBold.Location = new System.Drawing.Point(7, 76);
            this.reserveBold.Name = "reserveBold";
            this.reserveBold.Size = new System.Drawing.Size(89, 19);
            this.reserveBold.TabIndex = 4;
            this.reserveBold.Text = "保留粗体";
            this.reserveBold.UseVisualStyleBackColor = true;
            // 
            // reserveBackColor
            // 
            this.reserveBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reserveBackColor.AutoSize = true;
            this.reserveBackColor.Location = new System.Drawing.Point(184, 49);
            this.reserveBackColor.Name = "reserveBackColor";
            this.reserveBackColor.Size = new System.Drawing.Size(119, 19);
            this.reserveBackColor.TabIndex = 3;
            this.reserveBackColor.Text = "保留背景颜色";
            this.reserveBackColor.UseVisualStyleBackColor = true;
            // 
            // reserveForeColor
            // 
            this.reserveForeColor.AutoSize = true;
            this.reserveForeColor.Checked = true;
            this.reserveForeColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reserveForeColor.Location = new System.Drawing.Point(7, 50);
            this.reserveForeColor.Name = "reserveForeColor";
            this.reserveForeColor.Size = new System.Drawing.Size(119, 19);
            this.reserveForeColor.TabIndex = 2;
            this.reserveForeColor.Text = "保留字符颜色";
            this.reserveForeColor.UseVisualStyleBackColor = true;
            // 
            // reserveFontSize
            // 
            this.reserveFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reserveFontSize.AutoSize = true;
            this.reserveFontSize.Location = new System.Drawing.Point(184, 24);
            this.reserveFontSize.Name = "reserveFontSize";
            this.reserveFontSize.Size = new System.Drawing.Size(89, 19);
            this.reserveFontSize.TabIndex = 1;
            this.reserveFontSize.Text = "保留字号";
            this.reserveFontSize.UseVisualStyleBackColor = true;
            // 
            // reserveFontName
            // 
            this.reserveFontName.AutoSize = true;
            this.reserveFontName.Location = new System.Drawing.Point(7, 25);
            this.reserveFontName.Name = "reserveFontName";
            this.reserveFontName.Size = new System.Drawing.Size(89, 19);
            this.reserveFontName.TabIndex = 0;
            this.reserveFontName.Text = "保留字体";
            this.reserveFontName.UseVisualStyleBackColor = true;
            // 
            // groupPunct
            // 
            this.groupPunct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPunct.Controls.Add(this.lowerMinus);
            this.groupPunct.Controls.Add(this.lowerPlus);
            this.groupPunct.Controls.Add(this.upperColon);
            this.groupPunct.Controls.Add(this.lowerColonSpace);
            this.groupPunct.Controls.Add(this.lowerColon);
            this.groupPunct.Controls.Add(this.upperSemic);
            this.groupPunct.Controls.Add(this.lowerSemicSpace);
            this.groupPunct.Controls.Add(this.lowerSemic);
            this.groupPunct.Controls.Add(this.upperComma);
            this.groupPunct.Controls.Add(this.lowerCommaSpace);
            this.groupPunct.Controls.Add(this.lowerComma);
            this.groupPunct.Controls.Add(this.upperCurl);
            this.groupPunct.Controls.Add(this.lowerCurl);
            this.groupPunct.Controls.Add(this.upperBracket);
            this.groupPunct.Controls.Add(this.lowerBracket);
            this.groupPunct.Controls.Add(this.upperParen);
            this.groupPunct.Controls.Add(this.lowerParen);
            this.groupPunct.Location = new System.Drawing.Point(13, 272);
            this.groupPunct.Name = "groupPunct";
            this.groupPunct.Size = new System.Drawing.Size(317, 211);
            this.groupPunct.TabIndex = 5;
            this.groupPunct.TabStop = false;
            this.groupPunct.Text = "标点规范";
            // 
            // lowerMinus
            // 
            this.lowerMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lowerMinus.AutoSize = true;
            this.lowerMinus.Checked = true;
            this.lowerMinus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowerMinus.Location = new System.Drawing.Point(184, 179);
            this.lowerMinus.Name = "lowerMinus";
            this.lowerMinus.Size = new System.Drawing.Size(127, 19);
            this.lowerMinus.TabIndex = 16;
            this.lowerMinus.Text = "全角－转半角-";
            this.lowerMinus.UseVisualStyleBackColor = true;
            // 
            // lowerPlus
            // 
            this.lowerPlus.AutoSize = true;
            this.lowerPlus.Checked = true;
            this.lowerPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowerPlus.Location = new System.Drawing.Point(7, 181);
            this.lowerPlus.Name = "lowerPlus";
            this.lowerPlus.Size = new System.Drawing.Size(127, 19);
            this.lowerPlus.TabIndex = 15;
            this.lowerPlus.Text = "全角＋转半角+";
            this.lowerPlus.UseVisualStyleBackColor = true;
            // 
            // upperColon
            // 
            this.upperColon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upperColon.AutoSize = true;
            this.upperColon.Location = new System.Drawing.Point(184, 153);
            this.upperColon.Name = "upperColon";
            this.upperColon.Size = new System.Drawing.Size(67, 19);
            this.upperColon.TabIndex = 14;
            this.upperColon.Text = ":转：";
            this.upperColon.UseVisualStyleBackColor = true;
            this.upperColon.CheckedChanged += new System.EventHandler(this.upperColon_CheckedChanged);
            // 
            // lowerColonSpace
            // 
            this.lowerColonSpace.AutoSize = true;
            this.lowerColonSpace.Enabled = false;
            this.lowerColonSpace.Location = new System.Drawing.Point(70, 155);
            this.lowerColonSpace.Name = "lowerColonSpace";
            this.lowerColonSpace.Size = new System.Drawing.Size(89, 19);
            this.lowerColonSpace.TabIndex = 13;
            this.lowerColonSpace.Text = "并加空格";
            this.lowerColonSpace.UseVisualStyleBackColor = true;
            // 
            // lowerColon
            // 
            this.lowerColon.AutoSize = true;
            this.lowerColon.Location = new System.Drawing.Point(7, 155);
            this.lowerColon.Name = "lowerColon";
            this.lowerColon.Size = new System.Drawing.Size(67, 19);
            this.lowerColon.TabIndex = 12;
            this.lowerColon.Text = "：转:";
            this.lowerColon.UseVisualStyleBackColor = true;
            this.lowerColon.CheckedChanged += new System.EventHandler(this.lowerColon_CheckedChanged);
            // 
            // upperSemic
            // 
            this.upperSemic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upperSemic.AutoSize = true;
            this.upperSemic.Location = new System.Drawing.Point(184, 127);
            this.upperSemic.Name = "upperSemic";
            this.upperSemic.Size = new System.Drawing.Size(67, 19);
            this.upperSemic.TabIndex = 11;
            this.upperSemic.Text = ";转；";
            this.upperSemic.UseVisualStyleBackColor = true;
            this.upperSemic.CheckedChanged += new System.EventHandler(this.upperSemic_CheckedChanged);
            // 
            // lowerSemicSpace
            // 
            this.lowerSemicSpace.AutoSize = true;
            this.lowerSemicSpace.Enabled = false;
            this.lowerSemicSpace.Location = new System.Drawing.Point(70, 129);
            this.lowerSemicSpace.Name = "lowerSemicSpace";
            this.lowerSemicSpace.Size = new System.Drawing.Size(89, 19);
            this.lowerSemicSpace.TabIndex = 10;
            this.lowerSemicSpace.Text = "并加空格";
            this.lowerSemicSpace.UseVisualStyleBackColor = true;
            // 
            // lowerSemic
            // 
            this.lowerSemic.AutoSize = true;
            this.lowerSemic.Location = new System.Drawing.Point(6, 129);
            this.lowerSemic.Name = "lowerSemic";
            this.lowerSemic.Size = new System.Drawing.Size(67, 19);
            this.lowerSemic.TabIndex = 9;
            this.lowerSemic.Text = "；转;";
            this.lowerSemic.UseVisualStyleBackColor = true;
            this.lowerSemic.CheckedChanged += new System.EventHandler(this.lowerSemic_CheckedChanged);
            // 
            // upperComma
            // 
            this.upperComma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upperComma.AutoSize = true;
            this.upperComma.Location = new System.Drawing.Point(184, 103);
            this.upperComma.Name = "upperComma";
            this.upperComma.Size = new System.Drawing.Size(67, 19);
            this.upperComma.TabIndex = 8;
            this.upperComma.Text = ",转，";
            this.upperComma.UseVisualStyleBackColor = true;
            this.upperComma.CheckedChanged += new System.EventHandler(this.upperComma_CheckedChanged);
            // 
            // lowerCommaSpace
            // 
            this.lowerCommaSpace.AutoSize = true;
            this.lowerCommaSpace.Enabled = false;
            this.lowerCommaSpace.Location = new System.Drawing.Point(70, 104);
            this.lowerCommaSpace.Name = "lowerCommaSpace";
            this.lowerCommaSpace.Size = new System.Drawing.Size(89, 19);
            this.lowerCommaSpace.TabIndex = 7;
            this.lowerCommaSpace.Text = "并加空格";
            this.lowerCommaSpace.UseVisualStyleBackColor = true;
            // 
            // lowerComma
            // 
            this.lowerComma.AutoSize = true;
            this.lowerComma.Location = new System.Drawing.Point(6, 103);
            this.lowerComma.Name = "lowerComma";
            this.lowerComma.Size = new System.Drawing.Size(67, 19);
            this.lowerComma.TabIndex = 6;
            this.lowerComma.Text = "，转,";
            this.lowerComma.UseVisualStyleBackColor = true;
            this.lowerComma.CheckedChanged += new System.EventHandler(this.lowerComma_CheckedChanged);
            // 
            // upperCurl
            // 
            this.upperCurl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upperCurl.AutoSize = true;
            this.upperCurl.Location = new System.Drawing.Point(184, 76);
            this.upperCurl.Name = "upperCurl";
            this.upperCurl.Size = new System.Drawing.Size(90, 19);
            this.upperCurl.TabIndex = 5;
            this.upperCurl.Text = "{}转｛｝";
            this.upperCurl.UseVisualStyleBackColor = true;
            this.upperCurl.CheckedChanged += new System.EventHandler(this.upperCurl_CheckedChanged);
            // 
            // lowerCurl
            // 
            this.lowerCurl.AutoSize = true;
            this.lowerCurl.Location = new System.Drawing.Point(6, 77);
            this.lowerCurl.Name = "lowerCurl";
            this.lowerCurl.Size = new System.Drawing.Size(90, 19);
            this.lowerCurl.TabIndex = 4;
            this.lowerCurl.Text = "｛｝转{}";
            this.lowerCurl.UseVisualStyleBackColor = true;
            this.lowerCurl.CheckedChanged += new System.EventHandler(this.lowerCurl_CheckedChanged);
            // 
            // upperBracket
            // 
            this.upperBracket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upperBracket.AutoSize = true;
            this.upperBracket.Location = new System.Drawing.Point(184, 50);
            this.upperBracket.Name = "upperBracket";
            this.upperBracket.Size = new System.Drawing.Size(90, 19);
            this.upperBracket.TabIndex = 3;
            this.upperBracket.Text = "[]转【】";
            this.upperBracket.UseVisualStyleBackColor = true;
            this.upperBracket.CheckedChanged += new System.EventHandler(this.upperBracket_CheckedChanged);
            // 
            // lowerBracket
            // 
            this.lowerBracket.AutoSize = true;
            this.lowerBracket.Location = new System.Drawing.Point(6, 51);
            this.lowerBracket.Name = "lowerBracket";
            this.lowerBracket.Size = new System.Drawing.Size(90, 19);
            this.lowerBracket.TabIndex = 2;
            this.lowerBracket.Text = "【】转[]";
            this.lowerBracket.UseVisualStyleBackColor = true;
            this.lowerBracket.CheckedChanged += new System.EventHandler(this.lowerBracket_CheckedChanged);
            // 
            // upperParen
            // 
            this.upperParen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upperParen.AutoSize = true;
            this.upperParen.Location = new System.Drawing.Point(184, 24);
            this.upperParen.Name = "upperParen";
            this.upperParen.Size = new System.Drawing.Size(90, 19);
            this.upperParen.TabIndex = 1;
            this.upperParen.Text = "()转（）";
            this.upperParen.UseVisualStyleBackColor = true;
            this.upperParen.CheckedChanged += new System.EventHandler(this.upperParen_CheckedChanged);
            // 
            // lowerParen
            // 
            this.lowerParen.AutoSize = true;
            this.lowerParen.Location = new System.Drawing.Point(7, 25);
            this.lowerParen.Name = "lowerParen";
            this.lowerParen.Size = new System.Drawing.Size(90, 19);
            this.lowerParen.TabIndex = 0;
            this.lowerParen.Text = "（）转()";
            this.lowerParen.UseVisualStyleBackColor = true;
            this.lowerParen.CheckedChanged += new System.EventHandler(this.lowerParen_CheckedChanged);
            // 
            // TextPasteForm
            // 
            this.AcceptButton = this.确定;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.取消;
            this.ClientSize = new System.Drawing.Size(342, 553);
            this.Controls.Add(this.groupPunct);
            this.Controls.Add(this.groupFont);
            this.Controls.Add(this.重置);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.确定);
            this.Controls.Add(this.groupBlank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextPasteForm";
            this.Text = "粘贴设置";
            this.groupBlank.ResumeLayout(false);
            this.groupBlank.PerformLayout();
            this.groupFont.ResumeLayout(false);
            this.groupFont.PerformLayout();
            this.groupPunct.ResumeLayout(false);
            this.groupPunct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBlank;
        private System.Windows.Forms.CheckBox removeAllLines;
        private System.Windows.Forms.CheckBox removeBackBlanks;
        private System.Windows.Forms.CheckBox removeBlankLines;
        private System.Windows.Forms.Button 确定;
        private System.Windows.Forms.Button 取消;
        private System.Windows.Forms.Button 重置;
        private System.Windows.Forms.CheckBox removeAllSpaces;
        private System.Windows.Forms.GroupBox groupFont;
        private System.Windows.Forms.CheckBox reserveFontName;
        private System.Windows.Forms.CheckBox reserveFontSize;
        private System.Windows.Forms.CheckBox reserveBackColor;
        private System.Windows.Forms.CheckBox reserveForeColor;
        private System.Windows.Forms.GroupBox groupPunct;
        private System.Windows.Forms.CheckBox reserveBold;
        private System.Windows.Forms.CheckBox reserveItalic;
        private System.Windows.Forms.CheckBox reserveUnderline;
        private System.Windows.Forms.CheckBox lowerCommaSpace;
        private System.Windows.Forms.CheckBox lowerComma;
        private System.Windows.Forms.CheckBox upperCurl;
        private System.Windows.Forms.CheckBox lowerCurl;
        private System.Windows.Forms.CheckBox upperBracket;
        private System.Windows.Forms.CheckBox lowerBracket;
        private System.Windows.Forms.CheckBox upperParen;
        private System.Windows.Forms.CheckBox lowerParen;
        private System.Windows.Forms.CheckBox upperSemic;
        private System.Windows.Forms.CheckBox lowerSemicSpace;
        private System.Windows.Forms.CheckBox lowerSemic;
        private System.Windows.Forms.CheckBox upperComma;
        private System.Windows.Forms.CheckBox upperColon;
        private System.Windows.Forms.CheckBox lowerColonSpace;
        private System.Windows.Forms.CheckBox lowerColon;
        private System.Windows.Forms.CheckBox lowerMinus;
        private System.Windows.Forms.CheckBox lowerPlus;
        private System.Windows.Forms.CheckBox reserveStrike;
        private System.Windows.Forms.CheckBox reserveScript;
    }
}