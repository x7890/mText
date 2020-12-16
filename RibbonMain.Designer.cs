
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
            this.gTmpl = this.Factory.CreateRibbonGroup();
            this.gRef = this.Factory.CreateRibbonGroup();
            this.gCapt = this.Factory.CreateRibbonGroup();
            this.gAbout = this.Factory.CreateRibbonGroup();
            this.gAbout_btnInfo = this.Factory.CreateRibbonButton();
            this.gAbout_btnVersion = this.Factory.CreateRibbonButton();
            this.mText.SuspendLayout();
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
            this.gBody.Label = "正文编辑";
            this.gBody.Name = "gBody";
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
            // 
            // gAbout_btnVersion
            // 
            this.gAbout_btnVersion.Image = ((System.Drawing.Image)(resources.GetObject("gAbout_btnVersion.Image")));
            this.gAbout_btnVersion.Label = "程序版本";
            this.gAbout_btnVersion.Name = "gAbout_btnVersion";
            this.gAbout_btnVersion.ScreenTip = "程序版本";
            this.gAbout_btnVersion.ShowImage = true;
            this.gAbout_btnVersion.SuperTip = "查看版本号及最新版网址";
            // 
            // RibbonMain
            // 
            this.Name = "RibbonMain";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.mText);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonMain_Load);
            this.mText.ResumeLayout(false);
            this.mText.PerformLayout();
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
    }

    partial class ThisRibbonCollection
    {
        internal RibbonMain RibbonMain
        {
            get { return this.GetRibbon<RibbonMain>(); }
        }
    }
}
