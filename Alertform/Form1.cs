using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alertform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AlertForm1 al = new AlertForm1("hello world",AlertForm1.AlertOptions.OK, AlertForm1.AlertType.success);
            var aa = al.ShowDialog();
            label1.Text = "failed";
            if (al.rDialogResult)
            {
                label1.Text = "successful";
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AlertForm1 al = new AlertForm1("hello world RETRY", AlertForm1.AlertOptions.RETRYCANCEL, AlertForm1.AlertType.success);
            var aa = al.ShowDialog();
            label1.Text = "failed";
            if (al.rDialogResult)
            {
                label1.Text = "successful";
            }
        }
    }
}
