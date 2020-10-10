using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermalogMultiScannerDemo.winforms
{
    public partial class sideForm2 : MetroFramework.Forms.MetroForm // Form
    {

        MDIParent3 ic;
        public sideForm2()
        {
            InitializeComponent();
        }

        public sideForm2(MDIParent3 md)
        {
            InitializeComponent();
            ic = md;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            // ic.setupDevices_new();
            winforms.testForm1 fm = new testForm1();
            fm.ShowDialog();
        }
    }
}
