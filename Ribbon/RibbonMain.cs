using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;

namespace mText
{
    public partial class RibbonMain
    {
        Word.Application app;

        private void RibbonMain_Load(object sender, RibbonUIEventArgs e)
        {
            app = Globals.ThisAddIn.Application;
        }

    }
}
