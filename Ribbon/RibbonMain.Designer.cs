
namespace mText
{
    partial class RibbonMain : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonMain()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.mText = this.Factory.CreateRibbonTab();
            this.文本工具 = this.Factory.CreateRibbonGroup();
            this.字数统计 = this.Factory.CreateRibbonButton();
            this.简洁复制 = this.Factory.CreateRibbonButton();
            this.简洁粘贴 = this.Factory.CreateRibbonButton();
            this.页面修正 = this.Factory.CreateRibbonSplitButton();
            this.去除网格 = this.Factory.CreateRibbonButton();
            this.自动断字 = this.Factory.CreateRibbonButton();
            this.公式工具 = this.Factory.CreateRibbonGroup();
            this.快捷公式 = this.Factory.CreateRibbonToggleButton();
            this.角标修正 = this.Factory.CreateRibbonSplitButton();
            this.化学角标 = this.Factory.CreateRibbonButton();
            this.数学下标 = this.Factory.CreateRibbonButton();
            this.幂次上标 = this.Factory.CreateRibbonButton();
            this.引文上标 = this.Factory.CreateRibbonButton();
            this.清除角标 = this.Factory.CreateRibbonButton();
            this.矩阵粘贴 = this.Factory.CreateRibbonButton();
            this.公式字体 = this.Factory.CreateRibbonComboBox();
            this.索引工具 = this.Factory.CreateRibbonGroup();
            this.引文模板 = this.Factory.CreateRibbonButton();
            this.标注编号 = this.Factory.CreateRibbonSplitButton();
            this.图片工具 = this.Factory.CreateRibbonGroup();
            this.关于程序 = this.Factory.CreateRibbonGroup();
            this.使用说明 = this.Factory.CreateRibbonButton();
            this.程序版本 = this.Factory.CreateRibbonButton();
            this.设置备份 = this.Factory.CreateRibbonButton();
            this.mText.SuspendLayout();
            this.文本工具.SuspendLayout();
            this.公式工具.SuspendLayout();
            this.索引工具.SuspendLayout();
            this.关于程序.SuspendLayout();
            this.SuspendLayout();
            // 
            // mText
            // 
            this.mText.Groups.Add(this.文本工具);
            this.mText.Groups.Add(this.公式工具);
            this.mText.Groups.Add(this.索引工具);
            this.mText.Groups.Add(this.图片工具);
            this.mText.Groups.Add(this.关于程序);
            this.mText.KeyTip = "C";
            this.mText.Label = "mText";
            this.mText.Name = "mText";
            // 
            // 文本工具
            // 
            this.文本工具.Items.Add(this.字数统计);
            this.文本工具.Items.Add(this.简洁复制);
            this.文本工具.Items.Add(this.简洁粘贴);
            this.文本工具.Items.Add(this.页面修正);
            this.文本工具.Label = "文本工具";
            this.文本工具.Name = "文本工具";
            // 
            // 字数统计
            // 
            this.字数统计.KeyTip = "G";
            this.字数统计.Label = "字数统计";
            this.字数统计.Name = "字数统计";
            this.字数统计.OfficeImageId = "AlignRelativeToPage";
            this.字数统计.ScreenTip = "字数统计";
            this.字数统计.ShowImage = true;
            this.字数统计.SuperTip = "统计光标选中区域或预设区域的字数。预设区域只在未选中文本时有效。按Ctrl+本按钮进行设置";
            this.字数统计.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.字数统计_Click);
            // 
            // 简洁复制
            // 
            this.简洁复制.KeyTip = "C";
            this.简洁复制.Label = "简洁复制";
            this.简洁复制.Name = "简洁复制";
            this.简洁复制.OfficeImageId = "Copy";
            this.简洁复制.ScreenTip = "简洁复制";
            this.简洁复制.ShowImage = true;
            this.简洁复制.SuperTip = "以纯文本形式复制所选文本并去除头尾空格，不含编号。若不选中文本，则复制光标所在行。";
            this.简洁复制.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.简洁复制_Click);
            // 
            // 简洁粘贴
            // 
            this.简洁粘贴.KeyTip = "V";
            this.简洁粘贴.Label = "简洁粘贴";
            this.简洁粘贴.Name = "简洁粘贴";
            this.简洁粘贴.OfficeImageId = "Paste";
            this.简洁粘贴.ScreenTip = "简洁粘贴";
            this.简洁粘贴.ShowImage = true;
            this.简洁粘贴.SuperTip = "按Ctrl+本按钮进行设置。按Alt+本按钮则按设置格式粘贴。直接点击本按钮，则总是去除空白符（空格、换行）并粘贴为纯文本。";
            this.简洁粘贴.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.简洁粘贴_Click);
            // 
            // 页面修正
            // 
            this.页面修正.Items.Add(this.去除网格);
            this.页面修正.Items.Add(this.自动断字);
            this.页面修正.KeyTip = "P";
            this.页面修正.Label = "页面修正";
            this.页面修正.Name = "页面修正";
            this.页面修正.OfficeImageId = "ControlWizards";
            this.页面修正.ScreenTip = "页面修正";
            this.页面修正.SuperTip = "聚合常用页面修正功能";
            // 
            // 去除网格
            // 
            this.去除网格.KeyTip = "G";
            this.去除网格.Label = "去除网格";
            this.去除网格.Name = "去除网格";
            this.去除网格.OfficeImageId = "DatasheetGridlinesHorizontal";
            this.去除网格.ScreenTip = "去除网格";
            this.去除网格.ShowImage = true;
            this.去除网格.SuperTip = "取消页面网格，以防止行间出现较大空白（如图片）。按Ctrl+本按钮，设置网格为默认的每页44行的行网格。（手动设置方法：页面设置-文档网络）";
            this.去除网格.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.去除网格_Click);
            // 
            // 自动断字
            // 
            this.自动断字.KeyTip = "S";
            this.自动断字.Label = "自动断字";
            this.自动断字.Name = "自动断字";
            this.自动断字.OfficeImageId = "HyphenationOptions";
            this.自动断字.ScreenTip = "自动断字";
            this.自动断字.ShowImage = true;
            this.自动断字.SuperTip = "设置左对齐，并在英文换行时自动添加连字符。按Shift+本按钮，取消本段自动断字。按Ctrl+本按钮，取消整篇文档自动断字。（手动设置方法：禁止西文断行，并启用自" +
    "动断字）";
            this.自动断字.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.自动断字_Click);
            // 
            // 公式工具
            // 
            this.公式工具.DialogLauncher = ribbonDialogLauncherImpl1;
            this.公式工具.Items.Add(this.快捷公式);
            this.公式工具.Items.Add(this.角标修正);
            this.公式工具.Items.Add(this.矩阵粘贴);
            this.公式工具.Items.Add(this.公式字体);
            this.公式工具.Label = "公式工具";
            this.公式工具.Name = "公式工具";
            this.公式工具.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.公式工具_DialogLauncherClick);
            // 
            // 快捷公式
            // 
            this.快捷公式.KeyTip = "E";
            this.快捷公式.Label = "快捷公式";
            this.快捷公式.Name = "快捷公式";
            this.快捷公式.OfficeImageId = "EquationProfessional";
            this.快捷公式.ScreenTip = "快捷公式";
            this.快捷公式.ShowImage = true;
            this.快捷公式.SuperTip = "使用一些快捷键输入公式中的符号。按Ctrl+本按钮查看详细帮助。";
            this.快捷公式.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.快捷公式_Click);
            // 
            // 角标修正
            // 
            this.角标修正.Items.Add(this.化学角标);
            this.角标修正.Items.Add(this.数学下标);
            this.角标修正.Items.Add(this.幂次上标);
            this.角标修正.Items.Add(this.引文上标);
            this.角标修正.Items.Add(this.清除角标);
            this.角标修正.KeyTip = "X";
            this.角标修正.Label = "角标修正";
            this.角标修正.Name = "角标修正";
            this.角标修正.OfficeImageId = "GoToFootnote";
            this.角标修正.ScreenTip = "角标修正";
            this.角标修正.SuperTip = "识别并修正所选区域的上下角标（识别不一定准确）。对已经具有上下标格式的部分不做处理";
            // 
            // 化学角标
            // 
            this.化学角标.KeyTip = "M";
            this.化学角标.Label = "化学角标";
            this.化学角标.Name = "化学角标";
            this.化学角标.OfficeImageId = "ReplaceDialog";
            this.化学角标.ScreenTip = "化学角标";
            this.化学角标.ShowImage = true;
            this.化学角标.SuperTip = "将选中区域中的疑似离子符号改为上标，疑似原子个数改为下标";
            this.化学角标.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.化学角标_Click);
            // 
            // 数学下标
            // 
            this.数学下标.KeyTip = "E";
            this.数学下标.Label = "数学下标";
            this.数学下标.Name = "数学下标";
            this.数学下标.OfficeImageId = "ExtendedTextFormattingMenu";
            this.数学下标.ScreenTip = "数学下标";
            this.数学下标.ShowImage = true;
            this.数学下标.SuperTip = "将选中区域中的疑似数学下标设置下标格式。（按Ctrl再点击，则转为上标）";
            this.数学下标.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.数学下标_Click);
            // 
            // 幂次上标
            // 
            this.幂次上标.KeyTip = "P";
            this.幂次上标.Label = "幂次上标";
            this.幂次上标.Name = "幂次上标";
            this.幂次上标.OfficeImageId = "Superscript";
            this.幂次上标.ScreenTip = "幂次上标";
            this.幂次上标.ShowImage = true;
            this.幂次上标.SuperTip = "将选中区域中的数字转为上标。（按Ctrl再点击，则转为下标）";
            this.幂次上标.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.幂次上标_Click);
            // 
            // 引文上标
            // 
            this.引文上标.KeyTip = "A";
            this.引文上标.Label = "引文上标";
            this.引文上标.Name = "引文上标";
            this.引文上标.OfficeImageId = "GroupFieldValidation";
            this.引文上标.ScreenTip = "引文上标";
            this.引文上标.ShowImage = true;
            this.引文上标.SuperTip = "将选中区域中的方括号文献引用转为上标。";
            this.引文上标.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.引文上标_Click);
            // 
            // 清除角标
            // 
            this.清除角标.KeyTip = "C";
            this.清除角标.Label = "清除角标";
            this.清除角标.Name = "清除角标";
            this.清除角标.OfficeImageId = "ClearAllFormatting";
            this.清除角标.ScreenTip = "清除角标";
            this.清除角标.ShowImage = true;
            this.清除角标.SuperTip = "清除所选区域的所有上下角标。";
            this.清除角标.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.清除角标_Click);
            // 
            // 矩阵粘贴
            // 
            this.矩阵粘贴.KeyTip = "M";
            this.矩阵粘贴.Label = "矩阵粘贴";
            this.矩阵粘贴.Name = "矩阵粘贴";
            this.矩阵粘贴.OfficeImageId = "GetExternalDataImportClassic";
            this.矩阵粘贴.ScreenTip = "矩阵粘贴";
            this.矩阵粘贴.ShowImage = true;
            this.矩阵粘贴.SuperTip = "粘贴MATLAB结果为公式，自动转换矩阵和希腊字母。若按Ctrl+本按钮，则粘贴时加上矩阵方括号。注意：纯空格分隔的矩阵需要有至少两个连续分隔用的空格才会被分隔为" +
    "多列。";
            this.矩阵粘贴.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.矩阵粘贴_Click);
            // 
            // 公式字体
            // 
            this.公式字体.Label = "公式字体";
            this.公式字体.Name = "公式字体";
            this.公式字体.ScreenTip = "公式字体";
            this.公式字体.SuperTip = "批量设置所选区域种公式的字体";
            this.公式字体.Text = null;
            this.公式字体.ItemsLoading += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.公式字体_ItemsLoading);
            this.公式字体.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.公式字体_TextChanged);
            // 
            // 索引工具
            // 
            this.索引工具.Items.Add(this.引文模板);
            this.索引工具.Items.Add(this.标注编号);
            this.索引工具.Label = "索引工具";
            this.索引工具.Name = "索引工具";
            this.索引工具.Visible = false;
            // 
            // 引文模板
            // 
            this.引文模板.Label = "引文模板";
            this.引文模板.Name = "引文模板";
            this.引文模板.OfficeImageId = "GroupBusinessDataCatalogEntitiesEdit";
            this.引文模板.ScreenTip = "引文模板";
            this.引文模板.ShowImage = true;
            this.引文模板.SuperTip = "按指定格式生成文献引用文本";
            // 
            // 标注编号
            // 
            this.标注编号.Label = "标注编号";
            this.标注编号.Name = "标注编号";
            this.标注编号.ScreenTip = "标注编号";
            this.标注编号.SuperTip = "添加图注、表注、公式编号等。（手动设置方法：页面设置-文档网络）";
            // 
            // 图片工具
            // 
            this.图片工具.Label = "图片工具";
            this.图片工具.Name = "图片工具";
            this.图片工具.Visible = false;
            // 
            // 关于程序
            // 
            this.关于程序.Items.Add(this.使用说明);
            this.关于程序.Items.Add(this.程序版本);
            this.关于程序.Items.Add(this.设置备份);
            this.关于程序.Label = "关于程序";
            this.关于程序.Name = "关于程序";
            // 
            // 使用说明
            // 
            this.使用说明.Label = "使用说明";
            this.使用说明.Name = "使用说明";
            this.使用说明.OfficeImageId = "ChangeToTentativeAcceptInvitation";
            this.使用说明.ScreenTip = "使用说明";
            this.使用说明.ShowImage = true;
            this.使用说明.SuperTip = "查看使用方法";
            this.使用说明.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.使用说明_Click);
            // 
            // 程序版本
            // 
            this.程序版本.Label = "程序版本";
            this.程序版本.Name = "程序版本";
            this.程序版本.OfficeImageId = "GroupServerReadOnly";
            this.程序版本.ScreenTip = "程序版本";
            this.程序版本.ShowImage = true;
            this.程序版本.SuperTip = "查看版本号及最新版网址";
            this.程序版本.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.程序版本_Click);
            // 
            // 设置备份
            // 
            this.设置备份.Label = "设置备份";
            this.设置备份.Name = "设置备份";
            this.设置备份.OfficeImageId = "ButtonAddinDisabled";
            this.设置备份.ScreenTip = "设置备份";
            this.设置备份.ShowImage = true;
            this.设置备份.SuperTip = "本程序自定义设置项储存在注册表内，卸载时会自动删除。使用此按钮备份到文件";
            this.设置备份.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.设置备份_Click);
            // 
            // RibbonMain
            // 
            this.Name = "RibbonMain";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.mText);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonMain_Load);
            this.mText.ResumeLayout(false);
            this.mText.PerformLayout();
            this.文本工具.ResumeLayout(false);
            this.文本工具.PerformLayout();
            this.公式工具.ResumeLayout(false);
            this.公式工具.PerformLayout();
            this.索引工具.ResumeLayout(false);
            this.索引工具.PerformLayout();
            this.关于程序.ResumeLayout(false);
            this.关于程序.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab mText;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup 文本工具;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup 索引工具;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup 图片工具;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup 关于程序;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 程序版本;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 使用说明;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 设置备份;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton 快捷公式;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 字数统计;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 简洁复制;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 引文模板;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup 公式工具;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 化学角标;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 简洁粘贴;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 数学下标;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox 公式字体;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton 角标修正;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 去除网格;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton 页面修正;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 自动断字;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 矩阵粘贴;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton 标注编号;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 幂次上标;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 引文上标;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton 清除角标;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonMain RibbonMain
        {
            get { return this.GetRibbon<RibbonMain>(); }
        }
    }
}
