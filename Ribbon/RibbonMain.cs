using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
