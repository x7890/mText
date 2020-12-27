
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonMain));
            this.mText = this.Factory.CreateRibbonTab();
            this.gBody = this.Factory.CreateRibbonGroup();
            this.gBody_btnCount = this.Factory.CreateRibbonSplitButton();
            this.gBody_btnCountSettings = this.Factory.CreateRibbonButton();
            this.gBody_btnFormula = this.Factory.CreateRibbonToggleButton();
            this.gTmpl = this.Factory.CreateRibbonGroup();
            this.gRef = this.Factory.CreateRibbonGroup();
            this.gCapt = this.Factory.CreateRibbonGroup();
            this.gAbout = this.Factory.CreateRibbonGroup();
            this.gAbout_btnInfo = this.Factory.CreateRibbonButton();
            this.gAbout_btnVersion = this.Factory.CreateRibbonButton();
            this.gAbout_btnExportPref = this.Factory.CreateRibbonButton();
            this.gBody_btnCountNow = this.Factory.CreateRibbonButton();
            this.mText.SuspendLayout();
            this.gBody.SuspendLayout();
            this.gAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mText
            // 
            this.mText.Groups.Add(this.gBody);
            this.mText.Groups.Add(this.gTmpl);
            this.mText.Groups.Add(this.gRef);
            this.mText.Groups.Add(this.gCapt);
            this.mText.Groups.Add(this.gAbout);
            this.mText.KeyTip = "C";
            this.mText.Label = "mText";
            this.mText.Name = "mText";
            // 
            // gBody
            // 
            this.gBody.Items.Add(this.gBody_btnCount);
            this.gBody.Items.Add(this.gBody_btnFormula);
            this.gBody.Label = "正文编辑";
            this.gBody.Name = "gBody";
            // 
            // gBody_btnCount
            // 
            this.gBody_btnCount.Image = ((System.Drawing.Image)(resources.GetObject("gBody_btnCount.Image")));
            this.gBody_btnCount.Items.Add(this.gBody_btnCountNow);
            this.gBody_btnCount.Items.Add(this.gBody_btnCountSettings);
            this.gBody_btnCount.KeyTip = "G";
            this.gBody_btnCount.Label = "字数统计";
            this.gBody_btnCount.Name = "gBody_btnCount";
            this.gBody_btnCount.ScreenTip = "字数统计";
            this.gBody_btnCount.SuperTip = "统计光标选中区域或预设区域的字数。预设区域只在未选中文本时有效";
            this.gBody_btnCount.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gBody_btnCount_Click);
            // 
            // gBody_btnCountSettings
            // 
            this.gBody_btnCountSettings.Image = ((System.Drawing.Image)(resources.GetObject("gBody_btnCountSettings.Image")));
            this.gBody_btnCountSettings.Label = "统计设置";
            this.gBody_btnCountSettings.Name = "gBody_btnCountSettings";
            this.gBody_btnCountSettings.ScreenTip = "统计设置";
            this.gBody_btnCountSettings.ShowImage = true;
            this.gBody_btnCountSettings.SuperTip = "设置字数统计条件";
            this.gBody_btnCountSettings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gBody_btnCountSettings_Click);
            // 
            // gBody_btnFormula
            // 
            this.gBody_btnFormula.Image = ((System.Drawing.Image)(resources.GetObject("gBody_btnFormula.Image")));
            this.gBody_btnFormula.Label = "公式字母";
            this.gBody_btnFormula.Name = "gBody_btnFormula";
            this.gBody_btnFormula.ScreenTip = "公式字母";
            this.gBody_btnFormula.ShowImage = true;
            this.gBody_btnFormula.SuperTip = "按Ctrl+本按钮查看详细帮助。";
            this.gBody_btnFormula.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gBody_btnFormula_Click);
            // 
            // gTmpl
            // 
            this.gTmpl.Label = "模板工具";
            this.gTmpl.Name = "gTmpl";
            this.gTmpl.Visible = false;
            // 
            // gRef
            // 
            this.gRef.Label = "引用工具";
            this.gRef.Name = "gRef";
            this.gRef.Visible = false;
            // 
            // gCapt
            // 
            this.gCapt.Label = "截图工具";
            this.gCapt.Name = "gCapt";
            this.gCapt.Visible = false;
            // 
            // gAbout
            // 
            this.gAbout.Items.Add(this.gAbout_btnInfo);
            this.gAbout.Items.Add(this.gAbout_btnVersion);
            this.gAbout.Items.Add(this.gAbout_btnExportPref);
            this.gAbout.Label = "关于程序";
            this.gAbout.Name = "gAbout";
            // 
            // gAbout_btnInfo
            // 
            this.gAbout_btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("gAbout_btnInfo.Image")));
            this.gAbout_btnInfo.Label = "使用说明";
            this.gAbout_btnInfo.Name = "gAbout_btnInfo";
            this.gAbout_btnInfo.ScreenTip = "使用说明";
            this.gAbout_btnInfo.ShowImage = true;
            this.gAbout_btnInfo.SuperTip = "查看使用方法";
            this.gAbout_btnInfo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gAbout_btnInfo_Click);
            // 
            // gAbout_btnVersion
            // 
            this.gAbout_btnVersion.Image = ((System.Drawing.Image)(resources.GetObject("gAbout_btnVersion.Image")));
            this.gAbout_btnVersion.Label = "程序版本";
            this.gAbout_btnVersion.Name = "gAbout_btnVersion";
            this.gAbout_btnVersion.ScreenTip = "程序版本";
            this.gAbout_btnVersion.ShowImage = true;
            this.gAbout_btnVersion.SuperTip = "查看版本号及最新版网址";
            this.gAbout_btnVersion.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gAbout_btnVersion_Click);
            // 
            // gAbout_btnExportPref
            // 
            this.gAbout_btnExportPref.Image = ((System.Drawing.Image)(resources.GetObject("gAbout_btnExportPref.Image")));
            this.gAbout_btnExportPref.Label = "设置备份";
            this.gAbout_btnExportPref.Name = "gAbout_btnExportPref";
            this.gAbout_btnExportPref.ScreenTip = "设置备份";
            this.gAbout_btnExportPref.ShowImage = true;
            this.gAbout_btnExportPref.SuperTip = "本程序自定义设置项储存在注册表内，卸载时会自动删除。使用此按钮备份到文件";
            this.gAbout_btnExportPref.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gAbout_btnExportPref_Click);
            // 
            // gBody_btnCountNow
            // 
            this.gBody_btnCountNow.Image = ((System.Drawing.Image)(resources.GetObject("gBody_btnCountNow.Image")));
            this.gBody_btnCountNow.Label = "立刻统计";
            this.gBody_btnCountNow.Name = "gBody_btnCountNow";
            this.gBody_btnCountNow.ScreenTip = "立刻统计";
            this.gBody_btnCountNow.ShowImage = true;
            this.gBody_btnCountNow.SuperTip = "功能与点击父菜单相同，但便于访问键（Alt+C G 空格）访问";
            this.gBody_btnCountNow.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.gBody_btnCountNow_Click);
            // 
            // RibbonMain
            // 
            this.Name = "RibbonMain";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.mText);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonMain_Load);
            this.mText.ResumeLayout(false);
            this.mText.PerformLayout();
            this.gBody.ResumeLayout(false);
            this.gBody.PerformLayout();
            this.gAbout.ResumeLayout(false);
            this.gAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab mText;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gBody;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gTmpl;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gRef;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gCapt;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup gAbout;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton gAbout_btnVersion;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton gAbout_btnInfo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton gAbout_btnExportPref;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton gBody_btnCountSettings;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton gBody_btnCount;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton gBody_btnFormula;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton gBody_btnCountNow;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonMain RibbonMain
        {
            get { return this.GetRibbon<RibbonMain>(); }
        }
    }
}
