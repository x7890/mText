using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace mText.Forms
{
    public partial class RefTmplForm : Form
    {
        Word.Application app;
        public RefTmplForm(Word.Application app)
        {
            InitializeComponent();
            this.app = app;
        }

    }
}
